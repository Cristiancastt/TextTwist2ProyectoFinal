﻿Imports System.IO
Imports ClasesJuego
Public Module JuegoGlobal
    Public usr, usrpswrd As String
    Public textTwist As New Juego
    Public tiempo, registrado As Boolean
    Private sonido As Boolean = True
    Public tiempoRestante As Integer = 150 'Dos minutos en segundos
    Public Sub ConectarMenu()
        sonido = True
        Try
            My.Computer.Audio.Play(My.Resources.MainMenu, AudioPlayMode.BackgroundLoop)
        Catch ex As Exception
            MessageBox.Show("Parece que uno de los recursos para la música no existe. El juego continuará sin música.", "Error en los archivos del juego", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub ConectarJuego()
        sonido = True
        Try
            My.Computer.Audio.Play(My.Resources.MainGame, AudioPlayMode.BackgroundLoop)
        Catch ex As Exception
            MessageBox.Show("Parece que uno de los recursos para la música no existe. El juego continuará sin música.", "Error en los archivos del juego", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub Desconectar()
        sonido = False
        My.Computer.Audio.Stop()
    End Sub
    Public Function sonidoActivo() As Boolean
        Return sonido
    End Function

    Public Sub EliminarBotones()
        For Each btn As Button In frmJuego.Controls.OfType(Of Button)()
            If btn.Name = "btnDef" Then
                frmJuego.Controls.Remove(btn)
            End If
        Next
    End Sub
    Public Nivel As New ArrayList
    Public Sub extraerDatosPalabras(numero As Integer)
        Nivel.Clear()
        Dim lineaInicio As Integer = 0
        Dim lineaFin As Integer = 0
        If numero = 1 Then
            lineaInicio = 0
            lineaFin = 10  'todo Poner a 10 cuando acabe pruebas
        ElseIf numero = 2 Then
            lineaInicio = 11
            lineaFin = 25
        ElseIf numero = 3 Then
            lineaInicio = 26
            lineaFin = 40
        End If
        If textTwist.extraerPalabras() <> Nothing Then
            Dim lines As String() = File.ReadAllLines(textTwist.extraerPalabras())
            Dim contadorLinea As Integer = 0
            For Each line As String In lines
                contadorLinea += 1
                If contadorLinea >= lineaInicio AndAlso contadorLinea <= lineaFin Then
                    Dim valores As String() = line.Split(",")
                    Dim palabra As New Palabra(valores(0), valores(1))
                    Nivel.Add(palabra)
                End If
            Next
        End If
    End Sub

    Public btnsGlobales As New List(Of Button)
    Public lblsGapsBlancos As New List(Of ArrayList)
    Public lblsPalabras As New ArrayList
    Public lblTag As New ArrayList
    Public lblTagUnico As New ArrayList

    Public Sub GenerarGapsBlanco(Nivel As ArrayList)
        Dim x As Integer = 10
        Dim y As Integer = 10
        Dim labelWidth As Integer = 50
        Dim labelHeight As Integer = 30
        Dim palabraGeneradora As Palabra
        Dim anchoTotal As Integer = 0
        Dim espacioEntreLabels As Integer = 10
        Dim contador As Integer = 0
        For Each palabraGeneradora In Nivel
            contador += 1
            Dim lblsPalabras As New ArrayList ' crea un nuevo ArrayList para cada palabra
            For Each letra As Char In palabraGeneradora.Texto
                Dim label As New Label()
                label.Text = letra
                label.ForeColor = Color.White 'Cambiar el color a blanco
                label.BackColor = Color.White
                label.Size = New Size(labelWidth, labelHeight)
                label.Location = New Point(x, y)
                label.Tag = palabraGeneradora
                label.BorderStyle = BorderStyle.FixedSingle
                frmJuego.Controls.Add(label)
                x += labelWidth + 5
                If x > 10 + labelWidth * 10 + espacioEntreLabels * 9 Then
                    x = x + espacioEntreLabels
                    y = 10
                End If
                lblsPalabras.Add(label)
            Next
            lblsGapsBlancos.Add(lblsPalabras)
            x = 10
            y += labelHeight + 5
        Next
    End Sub

    Public botonesA As List(Of Button) = New List(Of Button)()

    Public palabraAcertada As String

    Public Sub MostrarDefinicion(x As Integer, y As Integer)
        Dim btnDef As New Button
        For Each tag1 As String In lblTag
            If Not lblTagUnico.Contains(tag1) Then
                lblTagUnico.Add(tag1)
            End If
        Next
        For Each tag2 As String In lblTagUnico
            btnDef.Name = "btnDef"
            btnDef.FlatStyle = FlatStyle.Flat
            btnDef.BackgroundImageLayout = ImageLayout.Stretch
            btnDef.BackgroundImage = New Bitmap(My.Resources.interrogante, 20, 15)
            'btnDef.Text = "?"
            btnDef.FlatAppearance.BorderSize = 0
            btnDef.Location = New Point(x, y)
            btnDef.Size = New Size(35, 25)
            btnDef.Tag = tag2
            frmJuego.Controls.Add(btnDef)
        Next
        AddHandler btnDef.Click, AddressOf btnDef_click
    End Sub
    Public Sub btnDef_click(sender As Object, a As EventArgs)
        Dim btnDefSendes As Button = sender
        For Each tag As String In lblTagUnico
            If btnDefSendes.Tag.Equals(tag) Then
                For Each palBuscar As Palabra In Nivel
                    If tag.Equals(palBuscar.Texto, StringComparison.OrdinalIgnoreCase) Then
                        MessageBox.Show(palBuscar.Significado, "¿Qué significa esta palabra?", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Next
            End If
        Next
    End Sub

    Public Function login(usuario As String, contra As String) As Boolean
        If Not String.IsNullOrWhiteSpace(usuario) AndAlso Not String.IsNullOrWhiteSpace(contra) Then
            If textTwist.extraerCredenciales() <> Nothing Then
                Dim filePath As String = textTwist.extraerCredenciales()
                Dim username As String = usuario
                Dim password As String = contra
                Dim credentials() As String = File.ReadAllLines(filePath)
                For Each line As String In credentials
                    Dim parts() As String = line.Split(",")
                    If parts(0) = username AndAlso parts(1) = password Then
                        ' Credenciales correctas, mostrar el formulario principal y ocultar el formulario de inicio de sesión
                        usr = usuario
                        usrpswrd = contra
                        MessageBox.Show("Credenciales correctas", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        registrado = True
                        frmMenu.Show()
                        'Me.Close()
                        Return True
                    End If
                Next
                If Not registrado Then
                    ' Credenciales incorrectas, mostrar un mensaje de error
                    MessageBox.Show("Credenciales incorrectas", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Else
                MessageBox.Show("Parece que uno de los ficheros no existe: credenciales.txt", "Error en los archivos del juego", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Ninguno de los campos puede estar en blanco. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            registrado = False
        End If
    End Function
    Public Function register(usuario As String, contra As String) As Boolean
        If Not String.IsNullOrWhiteSpace(usuario) AndAlso Not String.IsNullOrWhiteSpace(contra) Then
            If textTwist.extraerCredenciales() <> Nothing Then
                Dim filePath As String = textTwist.extraerCredenciales()
                Dim username As String = usuario
                Dim password As String = contra
                Dim usuarioExiste As Boolean = False
                Dim puntuacion As String = "0" ' Asignar un valor inicial a la puntuación como cadena

                ' Guardar los datos en un archivo de texto
                Dim lines() As String = File.ReadAllLines(filePath)

                ' Verificar si el usuario ya existe
                For Each line As String In lines
                    Dim parts() As String = line.Split(",")
                    Dim existingUsername As String = parts(0).Trim() ' Eliminar espacios en blanco alrededor del nombre de usuario

                    ' Si el usuario ya existe, mostrar un mensaje y salir del evento de registro
                    If existingUsername = username Then
                        MessageBox.Show("Ya existe el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        usuarioExiste = True
                        Exit For
                        Return False
                    End If
                Next
                If Not usuarioExiste Then
                    MessageBox.Show("Registro completado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim newData As String = username & "," & password & "," & puntuacion
                    File.AppendAllText(filePath, Environment.NewLine & newData)
                    Return True
                End If
            Else
                MessageBox.Show("Parece que uno de los ficheros no existe: credenciales.txt", "Error en los archivos del juego", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Ninguno de los campos puede estar en blanco. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return False
    End Function

End Module
