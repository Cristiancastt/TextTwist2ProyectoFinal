Imports System.IO
Imports ClasesJuego
Public Class frmJuego
    Private Sub frmJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRonda.Text = textTwist.Ronda
        extraerDatosPalabras(textTwist.Ronda)
        If sonidoActivo() Then
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
            lblHora.Text = "Ꝏ"
        End If
        lblPuntos.Text = textTwist.Puntos
        GenerarBotones(Nivel(0).texto)
        GenerarGapsBlanco(Nivel)
    End Sub
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
            boton.Anchor = (AnchorStyles.Bottom) + (AnchorStyles.Right)
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
                frmMenu.Show()
                Me.Close()
                'Aquí es donde puedes hacer cualquier cosa que necesites hacer cuando el tiempo se agote
            End If
        Else
            lblHora.Text = "Ꝏ"
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSonido.Click
        If sonidoActivo() Then
            Desconectar()
            btnSonido.Text = "🔈"
        Else
            ConectarJuego()
            btnSonido.Text = "🔊"
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmMenu.Show()
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
        If textTwist.SubirRonda(Nivel) Then
            textTwist.Puntos = 0
            textTwist.Ronda += 1
            lblPuntos.Text = textTwist.Puntos
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
            EliminarBotones()
            lblTag.Clear()
            lblTagUnico.Clear()
            lblsGapsBlancos.Clear()
            extraerDatosPalabras(textTwist.Ronda)
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
        If registrado Then
            Dim nombreUsuario As String = usr
            Dim password As String = usrpswrd
            Dim puntuacionActual As Integer = Integer.Parse(textTwist.Puntos)

            ' Verificar si el usuario ya existe en el archivo de texto y obtener su puntuación total
            Dim puntuacionTotal As Integer = 0
            If textTwist.extraerPalabras() <> Nothing Then
                Dim filePath As String = textTwist.extraerPalabras()
                Dim lines() As String = File.ReadAllLines(textTwist.extraerPalabras())
                For Each line As String In lines
                    Dim parts() As String = line.Split(",")
                    Dim username As String = parts(0)
                    Dim pwd As String = parts(1)
                    Dim puntuacion As Integer
                    If parts.Length >= 3 AndAlso Integer.TryParse(parts(2), puntuacion) Then
                        If username = nombreUsuario AndAlso pwd = password Then
                            puntuacionTotal = puntuacion
                            Exit For
                        End If
                    End If
                Next

                ' Sumar la puntuación actual a la puntuación total
                puntuacionTotal += puntuacionActual

                ' Actualizar la línea correspondiente en el archivo de texto con la nueva puntuación total
                Dim updatedLines As New List(Of String)()
                Dim lineIndex As Integer = -1
                For i As Integer = 0 To lines.Length - 1
                    Dim parts() As String = lines(i).Split(",")
                    Dim username As String = parts(0)
                    If username = nombreUsuario Then
                        lineIndex = i
                        Exit For
                    End If
                Next
                If lineIndex >= 0 Then
                    Dim parts() As String = lines(lineIndex).Split(",")
                    updatedLines.AddRange(lines.Take(lineIndex))
                    updatedLines.Add(nombreUsuario & "," & password & "," & puntuacionTotal.ToString())
                    updatedLines.AddRange(lines.Skip(lineIndex + 1))
                    File.WriteAllLines(filePath, updatedLines)
                Else
                    ' Si el usuario no existe, agregar una nueva línea al archivo de texto con sus datos y puntuación total
                    Dim data As String = nombreUsuario & "," & password & "," & puntuacionTotal.ToString() & vbCrLf
                    File.AppendAllText(filePath, data)
                End If
                ' Mostrar un mensaje con la puntuación total del usuario
                MessageBox.Show("Registro completado con éxito. Su puntuación total es: " & puntuacionTotal.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Parece que uno de los ficheros no existe: palabras.txt", "Error en los archivos del juego", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnLastWord.Click
        lblTextoBotones.Text = palabraAcertada
    End Sub

    Private Sub frmJuego_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If ActiveForm Is Me AndAlso e.KeyCode = Keys.F1 Then
            frmMenu.btnAyuda_Click(sender, e)
        End If
    End Sub

End Class
