Imports System.IO
Imports System.Windows.Forms.LinkLabel

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Leer los datos del archivo de texto y cargarlos en la interfaz de usuario
        'Dim filePath As String = "credenciales.txt"
        'Dim lines() As String = File.ReadAllLines(filePath)

        'For Each line As String In lines
        '    Dim parts() As String = line.Split(",")
        '    Dim username As String = parts(0)
        '    Dim password As String = parts(1)
        'Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        ' Verificar las credenciales en el archivo de texto
        Dim filePath As String = "credenciales.txt"
        Dim credentials() As String = File.ReadAllLines(filePath)
        For Each line As String In credentials
            Dim parts() As String = line.Split(",")
            If parts(0) = username AndAlso parts(1) = password Then
                ' Credenciales correctas, mostrar el formulario principal y ocultar el formulario de inicio de sesión
                usr = txtUsername.Text
                MessageBox.Show("Credenciales Correctas", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Return
            End If
        Next
        ' Credenciales incorrectas, mostrar un mensaje de error
        MessageBox.Show("Credenciales incorrectas. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        ' Guardar los datos en un archivo de texto
        Dim filePath As String = "credenciales.txt"
        Dim lines() As String = File.ReadAllLines(filePath)
        Dim data As String = username & "," & password & vbCrLf
        For Each line As String In lines
            Dim parts() As String = line.Split(",")
            Dim existingUsername As String = parts(0)
            ' Si el usuario ya existe, mostrar un mensaje y salir del evento de registro
            If existingUsername = username Then
                MessageBox.Show("Ya existe el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next
        File.AppendAllText(filePath, data)
        ' Mostrar un mensaje de éxito
        MessageBox.Show("Registro completado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class