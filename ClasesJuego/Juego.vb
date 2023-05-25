Public Class Juego
    Private _Ronda As Integer = 1
    Private _Puntos As Integer = 0
    Private _ficheroPalabras As String = "../.././Ficheros/palabras.txt"
    Private _ficheroCredenciales As String = "../.././Ficheros/credenciales.txt"

    Public Property Puntos As Integer
        Get
            Return _Puntos
        End Get
        Set
            _Puntos = Value
        End Set
    End Property

    Public Property Ronda As Integer
        Get
            Return _Ronda
        End Get
        Set
            _Ronda = Value
        End Set
    End Property
    Public ReadOnly Property ficheroPalabras() As String
        Get
            Return _ficheroPalabras
        End Get
    End Property
    Public ReadOnly Property ficheroCredenciales() As String
        Get
            Return _ficheroCredenciales
        End Get
    End Property

    Private PalabrasAcertadas As New ArrayList

    Public Function ComprobarPalabra(palabra As Palabra, Nivel As ArrayList) As Boolean
        If PalabrasAcertadas.Contains(palabra.Texto) Then
            Return False ' La palabra ya ha sido acertada antes, no sumar puntos
        End If
        For Each palabraNivel As Palabra In Nivel
            If palabra.Texto.Equals(palabraNivel.Texto, StringComparison.OrdinalIgnoreCase) Then
                Puntos = Puntos + 1500
                PalabrasAcertadas.Add(palabra.Texto)
                Return True
            End If
        Next
        Return False ' La palabra no está en el nivel
    End Function
    Public Function SubirRonda(Nivel As ArrayList) As Boolean
        If Puntos / 1500 = Nivel.ToArray.Length Then
            Return True
        End If
        Return False
    End Function
    Public Function extraerPalabras() As String
        If System.IO.File.Exists(_ficheroPalabras) Then
            Return _ficheroPalabras
        Else
            Return Nothing
        End If
    End Function
    Public Function extraerCredenciales() As String
        If System.IO.File.Exists(_ficheroCredenciales) Then
            Return _ficheroCredenciales
        Else
            Return Nothing
        End If
    End Function


End Class
