Public Class Voluntariado
    Public Property Codigo As Integer
    Public Property Tipo As New List(Of String) From {"Medioambiental", "Social", "Educacional", "Técnico"}
    Public Property Capacidad As Integer
    Public Property Estado As String
    Public Property Nombre As String
    Public Property FechaInicio As Date
    Public Property FechaFin As Date
    Public Property Descripcion As String
    Public Property Organizaciones As List(Of Organizacion)
    Public Property ODS As List(Of ODS)
    Public Property Voluntarios As List(Of Voluntario)
    Public Property Noticias As List(Of Noticia)
End Class
