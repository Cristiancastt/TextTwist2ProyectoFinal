﻿Imports System.Diagnostics.Eventing.Reader
Imports System.IO

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
        Timer1.Interval = 5000 '5 segundos
        Timer1.Start()
        lstRanking.Hide()
        btnSound.Text = "🔊"
        ConectarMenu()
        sonido = True
        If registrado Then
            lblUsuario.Text = usr
            ' Leer los datos del archivo de texto y cargarlos en la interfaz de usuario
            Dim filePath As String = "../.././Ficheros/credenciales.txt"
            If FicheroExisteComprobacion(filePath) Then
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
            End If
        Else
            lblUsuario.Text = "No Registrado"
            lstRanking.Items.Add("Usuario No Identificado")
        End If
    End Sub

    Private Sub btnSound_Click_1(sender As Object, e As EventArgs) Handles btnSound.Click
        If btnSound.Text = "🔊" Then
            Desconectar()
            btnSound.Text = "🔈"
            sonido = False
        Else
            ConectarMenu()
            btnSound.Text = "🔊"
            sonido = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        lstRanking.Show()
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If registrado Then
            lblUsuario.Text = usr
            ' Leer los datos del archivo de texto y cargarlos en la interfaz de usuario
            Dim filePath As String = "../.././Ficheros/credenciales.txt"
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
            lblUsuario.Text = "No Registrado"
            lstRanking.Items.Add("Usuario No Identificado")
        End If
    End Sub
End Class