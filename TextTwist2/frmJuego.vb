﻿Imports ClasesJuego

Public Class frmJuego
    Private tiempoRestante As Integer = 150 'Dos minutos en segundos
    Private Sub frmJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sonido = True Then
            btnSonido.Text = "🔊"
            ConectarJuego()
        Else
            btnSonido.Text = "🔈"
            Desconectar()
        End If
        If tiempo = True Then
            Me.lblHora.Text = String.Format("{0:m\:ss}", TimeSpan.FromSeconds(tiempoRestante))
            Timer1.Interval = 1000 'Un segundo
            Timer1.Start()
        Else
            Timer1.Start()
            lblHora.Text = "Ꝏ"
        End If
        lblPuntos.Text = textTwist.Puntos
        GenerarBotones(Nivel1(1).texto)
        GenerarGapsBlanco(Nivel1)
    End Sub
    Dim btnsGlobales As New List(Of Button)
    Private Sub Btn_Click(sender As Object, e As EventArgs)
        ' Aquí va el código que se ejecutará al hacer click en el botón
        ' Para acceder al botón que ha sido clickeado, podemos utilizar la variable "sender"
        Dim btnCaracteres As Button = DirectCast(sender, Button)
        'MessageBox.Show("Has clickeado el botón " & btnCaracteres.Text)
        lblTextoBotones.Text += sender.text
        ' Deshabilitar el botón para que no se pueda pulsar de nuevo
        btnCaracteres.Enabled = False
        btnsGlobales.Add(btnCaracteres)
    End Sub
    Dim lblsGapsBlancos As New List(Of ArrayList)
    Dim lblsPalabras As New ArrayList
    Private Sub GenerarGapsBlanco(Nivel As ArrayList)
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
                Me.Controls.Add(label)
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
    Private botonesA As List(Of Button) = New List(Of Button)()

    Private Sub GenerarBotones(palabra As String)
        Dim anchoBoton As Integer = 50
        Dim espacioEntreBotones As Integer = 20
        Dim xInicial As Integer = Me.Width - ((anchoBoton + espacioEntreBotones) * palabra.Length - espacioEntreBotones) - 150
        Dim yInicial As Integer = 300
        Dim letras As List(Of Char) = palabra.ToList() ' Convertimos la palabra en una lista de caracteres
        letras = letras.OrderBy(Function() Guid.NewGuid()).ToList() ' Barajamos los caracteres
        Dim contadorLetras As Integer = 0
        For Each letra As Char In letras
            Dim boton As New Button()
            contadorLetras += 1
            boton.Name = "btnCaracteres" & contadorLetras
            boton.Width = anchoBoton
            boton.Height = anchoBoton
            boton.BackColor = Color.White
            boton.Location = New Point(xInicial, yInicial)
            boton.Text = letra.ToString.ToUpper
            Me.Controls.Add(boton)
            xInicial += anchoBoton + espacioEntreBotones
            AddHandler boton.Click, AddressOf Btn_Click
            botonesA.Add(boton)
        Next
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblPuntos.Text = textTwist.Puntos
        If tiempo = True Then
            tiempoRestante -= 1
            If tiempoRestante >= 0 Then
                Me.lblHora.Text = String.Format("{0:m\:ss}", TimeSpan.FromSeconds(tiempoRestante))
            Else
                Timer1.Stop()
                Dim result As DialogResult = MessageBox.Show("Tiempo Finalizado", "¡Juego Finalizado!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If result = DialogResult.OK Then
                    Form1.Show()
                    Me.Hide()
                End If
                'Aquí es donde puedes hacer cualquier cosa que necesites hacer cuando el tiempo se agote
            End If
        Else
            lblHora.Text = "Ꝏ"
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSonido.Click
        If btnSonido.Text = "🔊" Then
            If Desconectar() Then btnSonido.Text = "🔈"
            sonido = False
        Else
            If ConectarJuego() Then btnSonido.Text = "🔊"
            sonido = True
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each btn As Button In btnsGlobales
            btn.Enabled = True
        Next
        lblTextoBotones.Text = ""
    End Sub


    Private Sub btnTwist_Click(sender As Object, e As EventArgs) Handles btnTwist.Click
        botonesA = botonesA.OrderBy(Function() Guid.NewGuid()).ToList()
        For i As Integer = 0 To botonesA.Count - 1
            Dim boton As Button = botonesA(i)
            Dim xInicial As Integer = Me.Width - ((boton.Width + 20) * botonesA.Count - 20) - 150
            Dim yInicial As Integer = 300
            boton.Location = New Point(xInicial + (boton.Width + 20) * i, yInicial)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblPuntos.Text = textTwist.Puntos
        Dim palabraComprobar As New Palabra(lblTextoBotones.Text)
        If textTwist.ComprobarPalabra(palabraComprobar, Nivel1) Then
            Dim posicion As Integer = Nivel1.IndexOf(palabraComprobar)
            Dim lblsEnPosicion As ArrayList = CType(lblsGapsBlancos.Item(posicion), ArrayList)
            For Each lbl As Label In lblsEnPosicion
                lbl.ForeColor = Color.Black
                lbl.Font = New Font("Segoe UI", 18, FontStyle.Regular)
                lbl.Text = lbl.Text.ToUpper
            Next
            palabraAcertada = palabraComprobar.Texto
            For Each btn As Button In btnsGlobales
                btn.Enabled = True
            Next
            lblTextoBotones.Text = ""
        Else
            For Each btn As Button In btnsGlobales
                btn.Enabled = True
            Next
            lblTextoBotones.Text = ""
        End If
    End Sub
    Dim palabraAcertada As String
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnLastWord.Click
        lblTextoBotones.Text = palabraAcertada
    End Sub

    Private Sub Button1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button1.KeyPress
        lblPuntos.Text = textTwist.Puntos
    End Sub
End Class