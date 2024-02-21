Imports System.ComponentModel

Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(215, Color.Black)
        Panel1.Location = New Point((Me.ClientSize.Width - Panel1.Width) / 2, (Me.ClientSize.Height - Panel1.Height) / 2)
        carregar_salas()
        btn_deletar.Enabled = False
    End Sub
    Private Sub btn_deletar_Click(sender As Object, e As EventArgs) Handles btn_deletar.Click
        Try
            resp = MsgBox("Deseja realmente retirar este filme do catálogo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = MsgBoxResult.Yes Then
                sql = "delete from tb_filmes where Filmes='" & txt_nomeFilme.Text & "'"
                rs = db.Execute(sql)
                MsgBox("O filme foi retirado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Me.Close()
                Form3.Show()
            End If
        Catch ex As Exception
            MsgBox("Erro na execução!" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            If txt_nomeFilme.Text = "" Or
               txt_genero.Text = "" Or
               txt_duracao.Text = "" Or
               cmb_sala.Text = "" Then
                MsgBox("Preencha todos os campos para continuar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = "insert into tb_filmes values('" & txt_nomeFilme.Text & "','" & txt_genero.Text & "'," &
                                                "'" & txt_duracao.Text & "','" & cmb_sala.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Me.Close()
                Form3.Show()
            End If
        Catch ex As Exception
            MsgBox("Erro na execução!" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_nomeFilme_LostFocus(sender As Object, e As EventArgs) Handles txt_nomeFilme.LostFocus
        sql = "select * from tb_filmes where Filmes='" & txt_nomeFilme.Text & "'"
        rs = db.Execute(UCase(sql))

        If Not rs.EOF Then
            txt_genero.Text = rs.Fields(1).Value
            txt_duracao.Text = rs.Fields(2).Value
            cmb_sala.Text = rs.Fields(3).Value
            btn_salvar.Enabled = False
            btn_deletar.Enabled = True
        End If
    End Sub

    Private Sub Form6_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form3.Show()
    End Sub
End Class