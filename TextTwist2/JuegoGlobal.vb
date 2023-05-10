Imports ClasesJuego

Module JuegoGlobal
    Public usr, usrpswrd As String
    Public textTwist As New Juego
    Public sonido, tiempo, registrado As Boolean
    Public Function ConectarMenu() As Boolean
        Try
            My.Computer.Audio.Play(My.Resources.MainMenu, AudioPlayMode.BackgroundLoop)
        Catch ex As Exception
            MessageBox.Show("Parece que uno de los recursos para la música no existe. El juego continuará sin música.", "Error en los archivos del juego", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return True
    End Function
    Public Function ConectarJuego() As Boolean
        Try
            My.Computer.Audio.Play(My.Resources.MainGame, AudioPlayMode.BackgroundLoop)
        Catch ex As Exception
            MessageBox.Show("Parece que uno de los recursos para la música no existe. El juego continuará sin música.", "Error en los archivos del juego", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return True
    End Function
    Public Function Desconectar() As Boolean
        My.Computer.Audio.Stop()
        Return True
    End Function
    Public Function FicheroExisteComprobacion(filePath As String)
        If System.IO.File.Exists(filePath) Then
            Return True
        Else
            MessageBox.Show("Parece que uno de los ficheros no existe: " & filePath, "Error en los archivos del juego", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function
    Public Sub EliminarBotones()
        For Each btn As Button In frmJuego.Controls.OfType(Of Button)()
            If btn.Name = "btnDef" Then
                btn.Hide()
            End If
        Next
    End Sub
End Module
