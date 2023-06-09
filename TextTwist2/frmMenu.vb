﻿Imports System.IO

Public Class frmMenu
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
        lstRanking.Show()
        If sonidoActivo() Then
            btnSound.Text = "🔊"
            ConectarMenu()
        Else
            btnSound.Text = "🔈"
            Desconectar()
        End If
        If registrado Then
            lblUsuario.Text = usr
            ' Leer los datos del archivo de texto y cargarlos en la interfaz de usuario
            If textTwist.extraerCredenciales() <> Nothing Then
                Dim filePath As String = textTwist.extraerCredenciales()
                Dim lines() As String = File.ReadAllLines(filePath)

                ' Crear una lista de tuplas (nombre de usuario, puntuación)
                Dim ranking As New List(Of Tuple(Of String, Integer))()
                For Each line As String In lines
                    Dim parts() As String = line.Split(",")
                    Dim username As String = parts(0)
                    Dim password As String = parts(1)
                    Dim puntuacion As Integer = Integer.Parse(parts(2))
                    ranking.Add(New Tuple(Of String, Integer)(username, puntuacion))
                Next

                ' Ordenar la lista de tuplas por puntuación de mayor a menor
                ranking.Sort(Function(x, y) y.Item2.CompareTo(x.Item2))

                ' Actualizar la ListBox con los elementos ordenados
                lstRanking.Items.Clear()
                For Each item As Tuple(Of String, Integer) In ranking
                    lstRanking.Items.Add(item.Item1 & " ------ " & item.Item2)
                Next
            Else
                MessageBox.Show("Parece que uno de los ficheros no existe: credenciales.txt", "Error en los archivos del juego", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            lblUsuario.Text = "No Registrado"
            lstRanking.Items.Add("Usuario No Identificado")
        End If
    End Sub

    Private Sub btnSound_Click_1(sender As Object, e As EventArgs) Handles btnSound.Click
        If sonidoActivo() Then
            Desconectar()
            btnSound.Text = "🔈"
        Else
            ConectarMenu()
            btnSound.Text = "🔊"
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Public Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        MessageBox.Show("En este juego se pondrá a prueba tu vocabulario de español. Con las letras que se muestren disponibles, deberás formar palabras de 3 o más letras. Cada acierto te otorgará 1500 puntos. Puedes escoger el modo contrarreloj, en el cual tendrás que intentar acertar el máximo número de palabras y acumular la cantidad más alta de puntos posibles, poniendo a prueba tu rapidez mental, o puedes escoger el modo interminable, donde podrás tomarte tu tiempo para pensar y descifrar las palabras a tu ritmo.", "Ayuda de usuario", MessageBoxButtons.OK, MessageBoxIcon.Question)
    End Sub

    Private Sub frmMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If ActiveForm Is Me AndAlso e.KeyCode = Keys.F1 Then
            btnAyuda_Click(sender, e)
        End If
    End Sub

End Class
