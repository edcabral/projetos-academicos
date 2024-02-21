Imports System.ComponentModel

Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_vendas()
    End Sub

    Private Sub Form8_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form3.Show()
    End Sub
End Class