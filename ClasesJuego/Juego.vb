Public Class Juego
    Private Shared _Ronda As Integer = 1
    Private Shared _Puntos As Integer = 0

    Public Shared Property Puntos As Integer
        Get
            Return _Puntos
        End Get
        Set
            _Puntos = Value
        End Set
    End Property

    Public Shared Property Ronda As Integer
        Get
            Return _Ronda
        End Get
        Set

            _Ronda = Value
        End Set
    End Property

    Private Shared PalabrasAcertadas As New ArrayList

    Public Shared Function ComprobarPalabra(palabra As Palabra, Nivel As ArrayList) As Boolean
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


    Public Shared Function SubirRonda() As Boolean
        If Puntos / 1500 = Nivel1.ToArray.Length Then
            Ronda += 1
            Return True
        End If
        Return False
    End Function
End Class
