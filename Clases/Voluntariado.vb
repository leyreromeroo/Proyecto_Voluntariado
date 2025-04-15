Public Class Voluntariado
    Implements IEquatable(Of Voluntariado)
    Public Property Codigo As Integer
    'Public Property Tipo As New List(Of String) From {"Medioambiental", "Social", "Educacional", "Técnico"}
    Public Property Tipo As List(Of TipoVoluntariado)
    Public Property Capacidad As Integer
    Public Property Estado As String
    Public Property Nombre As String
    Public Property FechaInicio As Date
    Public Property FechaFin As Date
    Public Property Descripcion As String
    Public Property Organizaciones As Organizacion
    Public Property ListaODS As List(Of ODS)
    Public Property Voluntarios As List(Of Voluntario)

    Public Sub New()
        Organizaciones = New Organizacion
        ListaODS = New List(Of ODS)()
        Voluntarios = New List(Of Voluntario)()
    End Sub

    Public Sub New(codActividad As Integer, capacidad As Integer, estado As String, nombre As String, fechaInicio As Date, fechaFin As Date, descripcion As String)
        Me.Codigo = Codigo
        Tipo = New List(Of TipoVoluntariado)
        Me.Capacidad = capacidad
        Me.Estado = estado
        Me.Nombre = nombre
        Me.FechaInicio = fechaInicio
        Me.FechaFin = fechaFin
        Me.Descripcion = descripcion
        Organizaciones = New Organizacion
        ListaODS = New List(Of ODS)()
        Voluntarios = New List(Of Voluntario)()
    End Sub
    Public Sub AgregarODS(ods As ODS)
        ListaODS.Add(ods)
    End Sub
    Public Sub AgregarVoluntario(voluntario As Voluntario)
        Voluntarios.Add(voluntario)
    End Sub

    Public Sub New(codigo As Integer, nombre As String)
        Me.Codigo = codigo
        Me.Nombre = nombre
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Voluntariado))
    End Function

    Public Overloads Function Equals(other As Voluntariado) As Boolean Implements IEquatable(Of Voluntariado).Equals
        Return other IsNot Nothing AndAlso
               Codigo = other.Codigo
    End Function

    Public Overrides Function ToString() As String
        Return $"Voluntariado {Codigo}: {Nombre}"
    End Function
End Class
