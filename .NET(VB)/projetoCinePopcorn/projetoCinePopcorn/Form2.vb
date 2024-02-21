Imports System.ComponentModel
Imports System.IO

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(215, Color.Black)
        Panel1.Location = New Point((Me.ClientSize.Width - Panel1.Width) / 2, (Me.ClientSize.Height - Panel1.Height) / 2)
        combobox_cargo()
        combobox_status()
        If txt_cpf.Text = "" Or
           txt_nome.Text = "" Or
           txt_email.Text = "" Or
           txt_celular.Text = "" Or
           txt_senha.Text = "" Or
           txt_rsenha.Text = "" Or
           cmb_cargo.Text = "" Or
           cmb_status.Text = "" Or
           Path.Combine(Application.StartupPath, "imagens\new_user.png").Equals(img_foto.ImageLocation, StringComparison.OrdinalIgnoreCase) Then
            btn_editar.Enabled = False
            btn_deletar.Enabled = False
        End If

    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form3.Show()
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO" 'título da janela de dialogo
                .InitialDirectory = Application.StartupPath & "\fotos" 'diretório incial
                .ShowDialog() 'chamar janela de diálogo
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            sql = "SELECT * FROM tb_usuarios WHERE cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)

            If Not rs.EOF Then
                txt_nome.Text = If(Not IsDBNull(rs.Fields(1).Value), rs.Fields(1).Value.ToString(), "")
                txt_dataNasc.Text = If(Not IsDBNull(rs.Fields(2).Value), rs.Fields(2).Value.ToString(), "")
                txt_email.Text = If(Not IsDBNull(rs.Fields(3).Value), rs.Fields(3).Value.ToString(), "")
                txt_senha.Text = If(Not IsDBNull(rs.Fields(4).Value), rs.Fields(4).Value.ToString(), "")
                txt_rsenha.Text = If(Not IsDBNull(rs.Fields(4).Value), rs.Fields(4).Value.ToString(), "")
                txt_celular.Text = If(Not IsDBNull(rs.Fields(5).Value), rs.Fields(5).Value.ToString(), "")
                cmb_cargo.Text = If(Not IsDBNull(rs.Fields(6).Value), rs.Fields(6).Value.ToString(), "")
                cmb_status.Text = If(Not IsDBNull(rs.Fields(7).Value), rs.Fields(7).Value.ToString(), "")
                img_foto.Load(rs.Fields(8).Value.ToString())
                btn_salvar.Enabled = False
                btn_editar.Enabled = True
                btn_deletar.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Erro na execução: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            If txt_cpf.Text = "" Or
           txt_nome.Text = "" Or
           txt_email.Text = "" Or
           txt_celular.Text = "" Or
           txt_senha.Text = "" Or
           txt_rsenha.Text = "" Or
           cmb_cargo.Text = "" Or
           cmb_status.Text = "" Or
           Path.Combine(Application.StartupPath, "imagens\new_user.png").Equals(img_foto.ImageLocation, StringComparison.OrdinalIgnoreCase) Then
                MsgBox("Preencha todos os campos para continuar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            ElseIf txt_senha.Text <> txt_rsenha.Text Then
                MsgBox("Senhas não condizentes!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_senha.Clear()
                txt_rsenha.Clear()
                txt_senha.Focus()
            Else
                sql = "INSERT INTO tb_usuarios VALUES ('" & txt_cpf.Text & "','" & txt_nome.Text & "'," &
                                                  "'" & txt_dataNasc.Text & "','" & txt_email.Text & "'," &
                                                  "'" & txt_senha.Text & "','" & txt_celular.Text & "'," &
                                                  "'" & cmb_cargo.Text & "','" & cmb_status.Text & "','" & diretorio & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro()
            End If

        Catch ex As Exception
            MsgBox("Erro na execução! " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_cpf_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cpf.MouseDoubleClick
        Try
            txt_cpf.Text = ""
            txt_nome.Text = ""
            txt_dataNasc.Text = ""
            txt_email.Text = ""
            txt_celular.Text = ""
            txt_senha.Text = ""
            txt_rsenha.Text = ""
            cmb_cargo.Text = ""
            cmb_status.Text = ""
            img_foto.Load(Application.StartupPath & "\imagens\new_user.png")
            btn_salvar.Enabled = True
        Catch ex As Exception
            MsgBox("Erro na execução!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_deletar_Click(sender As Object, e As EventArgs) Handles btn_deletar.Click
        Try
            If MsgBox("Deseja realmente excluir este cadastro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO") = MsgBoxResult.Yes Then
                sql = "DELETE FROM tb_usuarios WHERE cpf='" & txt_cpf.Text & "'"
                db.Execute(sql)
                MsgBox("Dados excluídos com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro()
                Me.Refresh()
                btn_salvar.Enabled = True
                btn_editar.Enabled = False
                btn_deletar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Erro na execução: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Try
            If txt_cpf.Text = "" OrElse
               txt_nome.Text = "" OrElse
               txt_email.Text = "" OrElse
               txt_celular.Text = "" OrElse
               txt_senha.Text = "" OrElse
               txt_rsenha.Text = "" OrElse
               cmb_cargo.Text = "" OrElse
               cmb_status.Text = "" Then
                MsgBox("Preencha todos os campos para continuar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            ElseIf txt_senha.Text <> txt_rsenha.Text Then
                MsgBox("Senhas não condizentes!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_senha.Clear()
                txt_rsenha.Clear()
                txt_senha.Focus()
            Else
                resp = MsgBox("Deseja realmente editar este cadastro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    sql = "UPDATE tb_usuarios SET " &
                    "cpf='" & txt_cpf.Text & "'," &
                    "nome='" & txt_nome.Text & "'," &
                    "dataNasc='" & txt_dataNasc.Text & "'," &
                    "email='" & txt_email.Text & "'," &
                    "senha='" & txt_senha.Text & "'," &
                    "celular='" & txt_celular.Text & "'," &
                    "cargo='" & cmb_cargo.Text & "'," &
                    "status_usuario='" & cmb_status.Text & "'," &
                    "foto='" & diretorio & "' " &
                    "WHERE cpf='" & txt_cpf.Text & "'"

                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    limpar_cadastro()
                    btn_salvar.Enabled = True
                    btn_editar.Enabled = False
                    btn_deletar.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro na execução! " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

End Class