Public Class TipoVoluntariado
    Public Property Nombre As String
    Public Sub New()
    End Sub
    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
