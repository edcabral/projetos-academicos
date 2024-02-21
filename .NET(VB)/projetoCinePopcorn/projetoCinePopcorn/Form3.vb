Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(190, Color.Black)
        btn_fechar.BackColor = Color.FromArgb(215, Color.Gray)
        Panel1.Location = New Point((Me.ClientSize.Width - Panel1.Width) / 2, (Me.ClientSize.Height - Panel1.Height) / 2)
        MenuStrip1.BackColor = Color.FromArgb(215, Color.Gray)
        DGV_1.Location = New Point((Me.ClientSize.Width - DGV_1.Width) / 2, (Me.ClientSize.Height - DGV_1.Height) / 2)
    End Sub

    Private Sub EncerrarSeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSeToolStripMenuItem.Click
        If MsgBox("Deseja realmente encerrar a sessão?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO") = MsgBoxResult.Yes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub GerenciarContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciarContasToolStripMenuItem.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub FecharProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharProgramaToolStripMenuItem.Click
        resp = MsgBox("Deseja realmente encerrar o programa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATEÇÃO")
        If resp = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub EmCartazToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmCartazToolStripMenuItem.Click
        DGV_1.Visible = True
        btn_fechar.Visible = True
        carregar_catalogo1()
    End Sub

    Private Sub btn_fechar_MouseHover(sender As Object, e As EventArgs) Handles btn_fechar.MouseHover
        ToolTip1.Show("Ocultar dados", btn_fechar, 0, -30)
    End Sub
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        DGV_1.Visible = False
        btn_fechar.Visible = False
    End Sub

    Private Sub btn_fechar_MouseLeave(sender As Object, e As EventArgs) Handles btn_fechar.MouseLeave
        ToolTip1.Hide(btn_fechar)
    End Sub

    Private Sub EditarCatálogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarCatálogoToolStripMenuItem.Click
        Me.Close()
        Form6.Show()
    End Sub

    Private Sub ContasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContasToolStripMenuItem1.Click
        Me.Close()
        Form7.Show()
    End Sub

    Private Sub RelatóriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatóriosToolStripMenuItem.Click
        Me.Close()
        Form8.Show()
    End Sub
End Class