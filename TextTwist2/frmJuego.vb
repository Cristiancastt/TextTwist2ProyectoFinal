Imports System.IO
Imports ClasesJuego
Public Class frmJuego
    Private tiempoRestante As Integer = 150 'Dos minutos en segundos
    Dim Nivel As New ArrayList
    Private Sub frmJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRonda.Text = textTwist.Ronda
        extraerDatosFichero(textTwist.Ronda)
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
        GenerarBotones(Nivel(0).texto)
        GenerarGapsBlanco(Nivel)
    End Sub
    Private Sub extraerDatosFichero(numero As Integer)
        Nivel.Clear()
        Dim lineaInicio As Integer = 0
        Dim lineaFin As Integer = 0
        If numero = 1 Then
            lineaInicio = 0
            lineaFin = 2  'todo Poner a 10 cuando acabe pruebas
        ElseIf numero = 2 Then
            lineaInicio = 11
            lineaFin = 25
        ElseIf numero = 3 Then
            lineaInicio = 26
            lineaFin = 40
        End If
        Dim lines As String() = File.ReadAllLines("palabras.txt")
        Dim contadorLinea As Integer = 0
        For Each line As String In lines
            contadorLinea += 1
            If contadorLinea >= lineaInicio AndAlso contadorLinea <= lineaFin Then
                Dim valores As String() = line.Split(","c)
                Dim palabra As New Palabra(valores(0), valores(1))
                Nivel.Add(palabra)
            End If
        Next
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
    Dim lblTag As New ArrayList
    Dim lblTagUnico As New ArrayList
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
                label.BorderStyle = BorderStyle.FixedSingle
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
        'todo borrar todos losbotones llamado   boton.Name = "btnCaracteres" & contadorLetras
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
                MessageBox.Show("Tiempo Finalizado", "¡Juego Finalizado!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form1.Show()
                Me.Close()
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
        If textTwist.SubirRonda(Nivel) Then
            textTwist.Puntos = 0
            textTwist.Ronda += 1
            For Each btnEliminar As Button In botonesA
                btnEliminar.Visible = False
                btnEliminar.Hide()
            Next
            botonesA.Clear()
            For i = 0 To Nivel.Count - 1
                Dim posicion As Integer = i
                Dim lblsEnPosicion As ArrayList = CType(lblsGapsBlancos.Item(posicion), ArrayList)
                For Each lbl As Label In lblsEnPosicion
                    lbl.Visible = False
                    lbl.Hide()
                Next
            Next
            lblsPalabras.Clear()
            Nivel.Clear()

            extraerDatosFichero(textTwist.Ronda)
            GenerarBotones(Nivel(0).texto)
            GenerarGapsBlanco(Nivel)
        End If
        lblPuntos.Text = textTwist.Puntos
        Dim palabraComprobar As New Palabra(lblTextoBotones.Text)
        If textTwist.ComprobarPalabra(palabraComprobar, Nivel) Then
            Dim posicion As Integer = Nivel.IndexOf(palabraComprobar)
            Dim lblsEnPosicion As ArrayList = CType(lblsGapsBlancos.Item(posicion), ArrayList)
            Dim lblUltPosicionX As Integer
            Dim lblUltPocisionY As Integer
            For Each lbl As Label In lblsEnPosicion
                lbl.ForeColor = Color.Black
                lbl.Font = New Font("Segoe UI", 18, FontStyle.Regular)
                lbl.Text = lbl.Text.ToUpper
                lbl.Tag = palabraComprobar.Texto
                lblTag.Add(lbl.Tag)
                lblUltPosicionX = lbl.Location.X
                lblUltPocisionY = lbl.Location.Y
            Next
            palabraAcertada = palabraComprobar.Texto
            For Each btn As Button In btnsGlobales
                btn.Enabled = True
            Next
            lblTextoBotones.Text = ""
            MostrarDefinicion(lblUltPosicionX + 60, lblUltPocisionY + 3)
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
    Private Sub MostrarDefinicion(x As Integer, y As Integer)
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
            Controls.Add(btnDef)
        Next
        AddHandler btnDef.Click, AddressOf btnDef_click
    End Sub
    Private Sub btnDef_click(sender As Object, a As EventArgs)
        Dim btnDefSendes As Button = sender
        Dim defMostrar As Palabra
        For Each tag As String In lblTagUnico
            If btnDefSendes.Tag.Equals(tag) Then
                For Each palBuscar As Palabra In Nivel
                    If tag.Equals(palBuscar.Texto, StringComparison.OrdinalIgnoreCase) Then
                        MessageBox.Show(palBuscar.Significado)
                    End If
                Next
            End If
        Next
    End Sub
End Class