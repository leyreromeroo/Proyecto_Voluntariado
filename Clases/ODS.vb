Public Class ODS
    Implements IEquatable(Of ODS)

    Public Property Numero As Integer
    Public Property Nombre As String
    Public Property Descripcion As String

    Public Sub New(numero As Integer, nombre As String, descripcion As String)
        Me.Numero = numero
        Me.Nombre = nombre
        Me.Descripcion = descripcion
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, ODS))
    End Function

    Public Overloads Function Equals(other As ODS) As Boolean Implements IEquatable(Of ODS).Equals
        Return other IsNot Nothing AndAlso
               Numero = other.Numero
    End Function

    Public Overrides Function ToString() As String
        Return $"ODS {Numero}: {Nombre}"
    End Function

End Class
