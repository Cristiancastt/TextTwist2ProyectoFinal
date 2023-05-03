Public Class Usuario
    Implements IEquatable(Of Usuario)
    Public Property Usuario As String
    Public Property Constrasena As String
    Public Sub New(usuario As String, constrasena As String)
        Me.Usuario = usuario
        Me.Constrasena = constrasena
    End Sub
    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Usuario))
    End Function
    Public Overloads Function Equals(other As Usuario) As Boolean Implements IEquatable(Of Usuario).Equals
        Return other IsNot Nothing AndAlso
               Usuario = other.Usuario
    End Function
    Public Overrides Function GetHashCode() As Integer
        Dim hashCode As Long = -1326562129
        hashCode = (hashCode * -1521134295 + EqualityComparer(Of String).Default.GetHashCode(Usuario)).GetHashCode()
        Return hashCode
    End Function
    Public Shared Operator =(left As Usuario, right As Usuario) As Boolean
        Return EqualityComparer(Of Usuario).Default.Equals(left, right)
    End Operator
    Public Shared Operator <>(left As Usuario, right As Usuario) As Boolean
        Return Not left = right
    End Operator
End Class
