Imports Clases

Public Class GestionVoluntariados
    Private Voluntariados As List(Of Voluntariado)
    Private servidor As String = Environment.MachineName
    Private servidorAlternativo As String = "."
    Private cadenaConexion = $"Data Source = {servidor}; Initial Catalog = PROYECTO_VOLUNTARIADO2; Integrated Security = SSPI; MultipleActiveResultSets=true"



    Public Sub New()
        Voluntariados = New List(Of Voluntariado)()
        EstablecerServidor()
    End Sub

    Private Sub EstablecerServidor()
        servidor = If(ProbarConexion(servidor), servidor, If(ProbarConexion(servidorAlternativo), servidorAlternativo, Nothing))

        If servidor IsNot Nothing Then
            cadenaConexion = $"Data Source = {servidor}; Initial Catalog = PROYECTO_VOLUNTARIADO2; Integrated Security = SSPI; MultipleActiveResultSets=true"

        End If
    End Sub

    Private Function ProbarConexion(servidor As String) As Boolean
        Dim conexion As New SqlClient.SqlConnection($"Data Source = {servidor}; Initial Catalog = master; Integrated Security = SSPI;")
        Try
            conexion.Open()
            conexion.Close()
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Sub AgregarVoluntariado(voluntariado As Voluntariado)
        Voluntariados.Add(voluntariado)
    End Sub

    Public Function ObtenerVoluntariados() As List(Of Voluntariado)
        Return Voluntariados
    End Function

    Public Function BuscarVoluntariadoPorCodigo(codigo As Integer) As Voluntariado
        Return Voluntariados.FirstOrDefault(Function(v) v.Codigo = codigo)
    End Function

    Public Sub EliminarVoluntariado(codigo As Integer)
        Dim voluntariado As Voluntariado = BuscarVoluntariadoPorCodigo(codigo)
        If voluntariado IsNot Nothing Then
            Voluntariados.Remove(voluntariado)
        End If
    End Sub

    Public Sub ActualizarVoluntariado(codigo As Integer, nuevoVoluntariado As Voluntariado)
        Dim index As Integer = Voluntariados.FindIndex(Function(v) v.Codigo = codigo)
        If index <> -1 Then
            Voluntariados(index) = nuevoVoluntariado
        End If
    End Sub
End Class
