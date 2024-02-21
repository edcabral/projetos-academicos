Imports System.ComponentModel

Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(190, Color.Black)
        Panel1.Location = New Point((Me.ClientSize.Width - Panel1.Width) / 2, (Me.ClientSize.Height - Panel1.Height) / 2)
        Panel2.BackColor = Color.FromArgb(190, Color.Gray)
        Try
            sql = "Select * from tb_filmes"
            rs = db.Execute(sql)

            If Not rs.EOF Then
                rs.MoveFirst() ' Mova para o primeiro registro

                ' Adicionar os itens da coluna "Filmes" à ComboBox
                Do While Not rs.EOF
                    cmb_filmes.Items.Add(rs.Fields("Filmes").Value.ToString())
                    rs.MoveNext()
                Loop
            End If

            sql = "Select * from tb_ingressos"
            rs = db.Execute(sql)

            If Not rs.EOF Then
                rs.MoveFirst()

                Do While Not rs.EOF
                    cmb_ingresso.Items.Add(rs.Fields(0).Value.ToString())
                    rs.MoveNext()
                Loop
            End If

        Catch ex As Exception
            MsgBox("Erro na execução!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Form5_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form4.Show()
    End Sub

    Private Sub cmb_filmes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_filmes.SelectedIndexChanged
        Try
            If cmb_filmes.SelectedIndex <> -1 Then
                sql = "Select * from tb_filmes where Filmes = '" & cmb_filmes.SelectedItem.ToString() & "'"
                rs = db.Execute(sql)

                If Not rs.EOF Then
                    txt_sala.Text = rs.Fields(3).Value.ToString()
                End If
            End If
            If txt_sala.Text <> "" Then
                Panel2.Enabled = True
                sql = "select * from tb_sala where Sala = '" & txt_sala.Text & "'"
                rs = db.Execute(UCase(sql))

                If Not rs.EOF Then
                    cmb_secao.Items.Add(rs.Fields(1).Value.ToString())
                    cmb_secao.Items.Add(rs.Fields(2).Value.ToString())
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro na execução!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private qtde_poltronas As Integer = 0
    Private Sub Imagem_Click(sender As Object, e As EventArgs) Handles A1.Click, A2.Click, A3.Click, A4.Click, B1.Click, B2.Click, B3.Click, B4.Click, C1.Click, C2.Click, C3.Click, C4.Click, D1.Click, D2.Click, D3.Click, D4.Click
        Try
            sql = "Select * from tb_ingressos"
            rs = db.Execute(sql)

            If TypeOf sender Is PictureBox Then
                Dim imagemClicada As PictureBox = DirectCast(sender, PictureBox)
                If imagemClicada.BackColor = Color.DarkGray Then
                    ' Se for, define a nova cor desejada
                    imagemClicada.BackColor = Color.LightGreen
                    qtde_poltronas += 1 'adicionar ao contador a quantodade de poltronas
                Else
                    ' Se não for, retorna à cor original
                    imagemClicada.BackColor = Color.DarkGray
                    qtde_poltronas -= 1 'retirar do contador a quantidade de poltonas
                End If
            End If
            AtualizarValor()
        Catch ex As Exception
            MsgBox("Erro na execução!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub ResetarCores()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is PictureBox Then
                Dim imagem As PictureBox = DirectCast(ctrl, PictureBox)
                imagem.BackColor = Color.DarkGray
            End If
        Next
        qtde_poltronas = 0 ' Reseta o contador para zero
        AtualizarValor()
    End Sub

    Private Sub AtualizarValor()
        Try
            If cmb_ingresso.SelectedIndex <> -1 Then
                sql = "Select * from tb_ingressos where Tipo_ingresso = '" & cmb_ingresso.SelectedItem.ToString() & "'"
                rs = db.Execute(sql)

                If Not rs.EOF Then
                    Dim valorTotal As Decimal = rs.Fields(1).Value * qtde_poltronas
                    txt_valor.Text = String.Format("{0:C}", valorTotal)
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro na execução!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub cmb_ingresso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ingresso.SelectedIndexChanged
        Try
            If cmb_ingresso.SelectedIndex <> -1 Then
                sql = "Select * from tb_ingressos where Tipo_ingresso = '" & cmb_ingresso.SelectedItem.ToString() & "'"
                rs = db.Execute(sql)

                If Not rs.EOF Then
                    Dim valorTotal As Decimal = rs.Fields(1).Value * qtde_poltronas
                    txt_valor.Text = String.Format("{0:C}", valorTotal)
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro na execução!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        Try
            If cmb_filmes.Text = "" Or
               cmb_secao.Text = "" Or
               cmb_ingresso.Text = "" Then
                MsgBox("Para continuar preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            ElseIf txt_valor.Text = 0 Then
                MsgBox("Selecione pelo menos um assento!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            ElseIf qtde_poltronas > 2 Then
                MsgBox("Você só pode adicionar até 2 ingressos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = "INSERT INTO tb_vendas (filme, sala, secao, qtd_ingressos, valor) VALUES " &
           "('" & cmb_filmes.Text & "','" & txt_sala.Text & "','" & cmb_secao.Text & "'," &
           "'" & qtde_poltronas & "','" & txt_valor.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Venda realizada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_venda()
                ResetarCores()
                Me.Hide()
                Form4.Show()
            End If

        Catch ex As Exception
            MsgBox("Erro na execução!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

End Class