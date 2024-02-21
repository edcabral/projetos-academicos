Imports System.ComponentModel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Alterar a cor do fundo do painel
        Panel1.BackColor = Color.FromArgb(215, Color.Black)

        'Centralizar o painel e imagem de fundo
        'PictureBox1.Location = New Point((Me.ClientSize.Width - PictureBox1.Width) / 2, (Me.ClientSize.Height - PictureBox1.Height) / 2)
        Panel1.Location = New Point((Me.ClientSize.Width - Panel1.Width) / 2, (Me.ClientSize.Height - Panel1.Height) / 2)

        conectar_banco_access()
    End Sub

    Private Sub chk_esenha_CheckedChanged(sender As Object, e As EventArgs) Handles chk_esenha.CheckedChanged
        Try
            If (chk_esenha.Checked) Then
                txt_senha.PasswordChar = ControlChars.NullChar
            Else
                txt_senha.PasswordChar = "●"
            End If
        Catch ex As Exception
            MsgBox("Erro na execução!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_senha_GotFocus(sender As Object, e As EventArgs) Handles txt_senha.GotFocus
        ToolTip1.Hide(txt_email)
        ToolTip2.Hide(txt_senha)
    End Sub

    Private Sub txt_email_GotFocus(sender As Object, e As EventArgs) Handles txt_email.GotFocus
        ToolTip1.Hide(txt_email)
        ToolTip2.Hide(txt_senha)
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MsgBox("Deseja realmente sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            sql = "select*from tb_usuarios where email='" & txt_email.Text & "' and senha='" & txt_senha.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                Dim cargo = rs.Fields(6).Value
                If cargo = "GERENTE" Then
                    If rs.Fields(7).Value = "BLOQUEADO" Then
                        MsgBox("Conta bloqueada, contate um Gerente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                        txt_email.Clear()
                        txt_senha.Clear()
                    Else
                        MsgBox("Login efetuado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        Me.Hide()
                        Form3.Show()
                        txt_email.Clear()
                        txt_senha.Clear()
                    End If
                Else
                    If rs.Fields(7).Value = "BLOQUEADO" Then
                        MsgBox("Conta bloqueada, contate um Gerente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                        txt_email.Clear()
                        txt_senha.Clear()
                    Else
                        MsgBox("Login efetuado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        Me.Hide()
                        Form4.Show()
                        txt_email.Clear()
                        txt_senha.Clear()
                    End If
                End If
                'inserir um tooltip no txt_senha e e-mail
            ElseIf String.IsNullOrEmpty(txt_email.Text) And String.IsNullOrEmpty(txt_senha.Text) Then
                ToolTip1.Show("Digite seu e-mail!", txt_email, 0, -30)
                ToolTip2.Show("Digite sua senha!", txt_senha, 0, -30)
            ElseIf String.IsNullOrEmpty(txt_email.Text) Then
                ToolTip1.Show("Digite seu e-mail!", txt_email, 0, -30)
            ElseIf String.IsNullOrEmpty(txt_senha.Text) Then
                ToolTip2.Show("Digite sua senha!", txt_senha, 0, -30)
            Else
                MsgBox("E-mail ou senha incorretos, tente novamente!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_email.Clear()
                txt_senha.Clear()
            End If

        Catch ex As Exception
            MsgBox("Erro na execução!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class
