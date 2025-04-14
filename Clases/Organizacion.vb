Public Class Organizacion
    Public Property CodigoEmpresa As Integer
    Public Property Nombre As String
    Public Property NIF As String
    Public Property ActividadEconomica As String
    Public Property Telefono As String
    Public Property Localidad As String

    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub
End Class
