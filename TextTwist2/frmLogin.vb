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
        If Not String.IsNullOrWhiteSpace(txtUsername.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPassword.Text) Then
            If textTwist.extraerCredenciales() <> Nothing Then
                Dim filePath As String = textTwist.extraerCredenciales()
                Dim username As String = txtUsername.Text
                Dim password As String = txtPassword.Text
                Dim credentials() As String = File.ReadAllLines(filePath)
                For Each line As String In credentials
                    Dim parts() As String = line.Split(",")
                    If parts(0) = username AndAlso parts(1) = password Then
                        ' Credenciales correctas, mostrar el formulario principal y ocultar el formulario de inicio de sesión
                        usr = txtUsername.Text
                        usrpswrd = txtPassword.Text
                        MessageBox.Show("Credenciales correctas", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        registrado = True
                        frmMenu.Show()
                        Me.Close()
                    End If
                Next
                If Not registrado Then
                    ' Credenciales incorrectas, mostrar un mensaje de error
                    MessageBox.Show("Credenciales incorrectas", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Parece que uno de los ficheros no existe: credenciales.txt", "Error en los archivos del juego", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Ninguno de los campos puede estar en blanco. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            registrado = False
        End If
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If Not String.IsNullOrWhiteSpace(txtUsername.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPassword.Text) Then
            If textTwist.extraerCredenciales() <> Nothing Then
                Dim filePath As String = textTwist.extraerCredenciales()
                Dim username As String = txtUsername.Text
                Dim password As String = txtPassword.Text
                Dim usuarioExiste As Boolean = False
                Dim puntuacion As String = 0 ' asumiendo que la puntuación se ingresa manualmente en un cuadro de texto
                ' Guardar los datos en un archivo de texto
                Dim lines() As String = File.ReadAllLines(filePath)
                For Each line As String In lines
                    Dim parts() As String = line.Split(",")
                    Dim existingUsername As String = parts(0)
                    ' Si el usuario ya existe, mostrar un mensaje y salir del evento de registro
                    If existingUsername = username Then
                        MessageBox.Show("Ya existe el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        usuarioExiste = True
                        Exit For
                    End If
                Next
                If Not usuarioExiste Then
                    ' Mostrar un mensaje de éxito
                    MessageBox.Show("Registro completado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim data As String = username & "," & password & "," & puntuacion & vbCrLf ' agregar la puntuación a la cadena de datos
                    File.AppendAllText(filePath, data)
                End If
            Else
                MessageBox.Show("Parece que uno de los ficheros no existe: credenciales.txt", "Error en los archivos del juego", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Ninguno de los campos puede estar en blanco. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmMenu.Show()
        Me.Close()
    End Sub
End Class