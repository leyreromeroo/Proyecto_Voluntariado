Public Class Voluntario
    Public Property DNI As String
    Public Property Nombre As String
    Public Property Apellido1 As String
    Public Property Apellido2 As String
    Public Property FechaNacimiento As Date
    Public Property Direccion As String
    Public Property Telefono As List(Of TelefonoVoluntarios)
    Public Property Email As String
    Public Property AreaInteres As String
    Public Property Disponibilidad As List(Of DisponibilidadVoluntarios)
End Class
