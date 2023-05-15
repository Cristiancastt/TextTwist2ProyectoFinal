Public Class Palabra
    Implements IEquatable(Of Palabra)
    Public Property Texto As String
    Public Property Significado As String
    Public Sub New(texto As String)
        Me.Texto = texto
    End Sub
    Public Sub New(texto As String, significado As String)
        Me.New(texto)
        Me.Significado = significado
    End Sub
    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Palabra))
    End Function
    Public Overloads Function Equals(other As Palabra) As Boolean Implements IEquatable(Of Palabra).Equals
        Return other IsNot Nothing AndAlso
               Texto.Equals(other.Texto, StringComparison.InvariantCultureIgnoreCase)
    End Function
    Public Shared Operator =(left As Palabra, right As Palabra) As Boolean
        Return EqualityComparer(Of Palabra).Default.Equals(left, right)
    End Operator
    Public Shared Operator <>(left As Palabra, right As Palabra) As Boolean
        Return Not left = right
    End Operator
End Class
