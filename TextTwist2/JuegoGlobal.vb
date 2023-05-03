Imports ClasesJuego

Module JuegoGlobal
    Public usr As String
    Public textTwist As New Juego
    Public sonido, tiempo As Boolean
    Public Function ConectarMenu() As Boolean
        My.Computer.Audio.Play(My.Resources.MainMenu, AudioPlayMode.BackgroundLoop)
        Return True
    End Function
    Public Function ConectarJuego() As Boolean
        My.Computer.Audio.Play(My.Resources.MainGame, AudioPlayMode.BackgroundLoop)
        Return True
    End Function
    Public Function Desconectar() As Boolean
        My.Computer.Audio.Stop()
        Return True
    End Function
End Module
