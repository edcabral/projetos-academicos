Imports System.ComponentModel

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.BackColor = Color.FromArgb(215, Color.Gray)
        btn_fechar.BackColor = Color.FromArgb(215, Color.Gray)
        Panel1.BackColor = Color.FromArgb(215, Color.Black)
        Panel1.Location = New Point((Me.ClientSize.Width - Panel1.Width) / 2, (Me.ClientSize.Height - Panel1.Height) / 2)
        DGV_1.Location = New Point((Me.ClientSize.Width - DGV_1.Width) / 2, (Me.ClientSize.Height - DGV_1.Height) / 2)
    End Sub

    Private Sub EncerrarSeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSeToolStripMenuItem.Click
        If MsgBox("Deseja realmente encerrar a sessão?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO") = MsgBoxResult.Yes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub Form4_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Show()
    End Sub

    Private Sub FecharProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharProgramaToolStripMenuItem.Click
        resp = MsgBox("Deseja realmente encerrar o programa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATEÇÃO")
        If resp = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub NovaVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaVendaToolStripMenuItem.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub EmCartazToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmCartazToolStripMenuItem.Click
        DGV_1.Visible = True
        btn_fechar.Visible = True
        carregar_catalogo()
    End Sub

    Private Sub btn_fechar_MouseLeave(sender As Object, e As EventArgs) Handles btn_fechar.MouseLeave
        ToolTip1.Hide(btn_fechar)
    End Sub

    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        DGV_1.Visible = False
        btn_fechar.Visible = False
    End Sub

    Private Sub btn_fechar_MouseHover(sender As Object, e As EventArgs) Handles btn_fechar.MouseHover
        ToolTip1.Show("Ocultar dados", btn_fechar, 0, -30)
    End Sub

End Class