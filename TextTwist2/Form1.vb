Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTimed.Click
        tiempo = True
        frmJuego.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUntimed.Click
        tiempo = False
        frmJuego.Show()
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSound.Text = "🔊"
        Conectar()
    End Sub

    Private Sub btnSound_Click_1(sender As Object, e As EventArgs) Handles btnSound.Click
        If btnSound.Text = "🔊" Then
            If Desconectar() Then btnSound.Text = "🔈"
        Else
            If Conectar() Then btnSound.Text = "🔊"
        End If
    End Sub
End Class
