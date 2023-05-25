Imports System.IO
Imports System.Windows.Forms.LinkLabel
Public Class frmLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If login(txtUsername.Text, txtPassword.Text) Then
            Me.Close()
        End If
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        register(txtUsername.Text, txtPassword.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmMenu.Show()
        Me.Close()
    End Sub
End Class