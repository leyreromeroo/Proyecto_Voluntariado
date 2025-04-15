Public Class Organizacion
    Implements IEquatable(Of Organizacion)

    Public Property NIF As String
    Public Property Nombre As String
    Public Property Telefono As String
    Public Property Localidad As String

<<<<<<< HEAD
    Public Sub New(nIF As String, nombre As String, telefono As String, localidad As String)
        Me.Nombre = nombre
        Me.NIF = nIF
        Me.Telefono = telefono
        Me.Localidad = localidad
    End Sub

    'Public Sub New(nIF As String)
    '    Me.NIF = nIF
    'End Sub

    Public Sub New(nIF As String, nombre As String)
        Me.NIF = nIF
        Me.Nombre = nombre
    End Sub

    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub
    Public Sub New()

    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Organizacion))
    End Function

    Public Overloads Function Equals(other As Organizacion) As Boolean Implements IEquatable(Of Organizacion).Equals
        Return other IsNot Nothing AndAlso
               NIF = other.NIF
    End Function

    Public Overrides Function ToString() As String
        Return $"{Nombre}"
    End Function
=======
    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub
>>>>>>> 00ef619c841195e70ce559ab86410dcacb1a7439
End Class
