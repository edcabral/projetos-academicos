Imports System.ComponentModel

Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_1.Location = New Point((Me.ClientSize.Width - DGV_1.Width) / 2, (Me.ClientSize.Height - DGV_1.Height) / 2)
        carrega_usuários()
    End Sub

    Private Sub Form7_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form3.Show()
    End Sub
End Class