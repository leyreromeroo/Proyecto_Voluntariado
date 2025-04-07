Public Class Voluntario
    Implements IEquatable(Of Voluntario)

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

    Public Sub New()
        Telefono = New List(Of TelefonoVoluntarios)()
        Disponibilidad = New List(Of DisponibilidadVoluntarios)()
    End Sub

    Public Sub New(dNI As String, nombre As String, apellido1 As String, apellido2 As String, fechaNacimiento As Date, telefono As List(Of TelefonoVoluntarios))
        Me.DNI = dNI
        Me.Nombre = nombre
        Me.Apellido1 = apellido1
        Me.Apellido2 = apellido2
        Me.FechaNacimiento = fechaNacimiento
        Me.Telefono = telefono
    End Sub

    Public Sub New(dNI As String, nombre As String, apellido1 As String, apellido2 As String, fechaNacimiento As Date, direccion As String, telefono As List(Of TelefonoVoluntarios), email As String, areaInteres As String, disponibilidad As List(Of DisponibilidadVoluntarios))
        Me.DNI = dNI
        Me.Nombre = nombre
        Me.Apellido1 = apellido1
        Me.Apellido2 = apellido2
        Me.FechaNacimiento = fechaNacimiento
        Me.Direccion = direccion
        Me.Telefono = telefono
        Me.Email = email
        Me.AreaInteres = areaInteres
        Me.Disponibilidad = disponibilidad
    End Sub

    Public Sub New(dNI As String, nombre As String, apellido1 As String)
        Me.DNI = dNI
        Me.Nombre = nombre
        Me.Apellido1 = apellido1
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Voluntario))
    End Function

    Public Overloads Function Equals(other As Voluntario) As Boolean Implements IEquatable(Of Voluntario).Equals
        Return other IsNot Nothing AndAlso
               DNI = other.DNI
    End Function
End Class
