Public Class DisponibilidadVoluntarios
    Public Property DNI As String
    Public Property DiaSemana As String
    Public Property Horario As String

    Public Sub New(dNI As String, diaSemana As String, horario As String)
        Me.DNI = dNI
        Me.DiaSemana = diaSemana
        Me.Horario = horario
    End Sub
End Class
