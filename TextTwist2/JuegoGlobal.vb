Imports ClasesJuego

Module JuegoGlobal
    Public textTwist As Juego
    Public sonido, tiempo As Boolean
    Public Function ConectarMenu() As Boolean
        My.Computer.Audio.Play(My.Resources.MainMenu, AudioPlayMode.BackgroundLoop)
        Return True
    End Function
    Public Function DesconectarMenu() As Boolean
        My.Computer.Audio.Stop()
        Return True
    End Function
    Public Function ConectarJuego() As Boolean
        My.Computer.Audio.Play(My.Resources.MainGame, AudioPlayMode.BackgroundLoop)
        Return True
    End Function
    Public Function DesconectarJuego() As Boolean
        My.Computer.Audio.Stop()
        Return True
    End Function

    Dim palabra1 As New Palabra("camote", "Tubérculo comestible de América Central y México.")
    Dim palabra2 As New Palabra("cometa", "Cuerpo celeste compuesto de hielo y polvo que describe una órbita elíptica alrededor del Sol.")
    Dim palabra3 As New Palabra("acote", "Conjunto de ramas de la vid, después de cortar los racimos.")
    Dim palabra4 As New Palabra("cateo", "Examen o inspección minuciosa que se hace para buscar algo.")
    Dim palabra5 As New Palabra("mateo", "Nombre propio de varón.")
    Dim palabra6 As New Palabra("meato", "Cada una de las aberturas u orificios naturales de algunos animales.")
    Dim palabra7 As New Palabra("acto", "Acción que realiza una persona.")
    Dim palabra8 As New Palabra("ateo", "Que niega la existencia de Dios o deidades.")
    Dim palabra9 As New Palabra("atoe", "No se encontró significado para esta palabra.")
    Dim palabra10 As New Palabra("cate", "Verbo que significa poner atención o cuidado en algo.")

    Public Nivel1 As New ArrayList From {palabra1, palabra2, palabra3, palabra4, palabra5, palabra6, palabra7, palabra8, palabra9, palabra10}

End Module
