Imports Clases

Public Class GestionVoluntariados
    Private Voluntariados As List(Of Voluntariado)
    Private servidor = "DESKTOP-096N7MC" ' Aquí pondremos el nombre de nuestro servidor de SqlServer
    Private cadenaConexion = $"Data Source = {servidor}; Initial Catalog = PROYECTO_VOLUNTARIADO2; Integrated Security = SSPI; MultipleActiveResultSets=true"

    Private servidorAlternativo As String = "."

    Public Sub New()
        Voluntariados = New List(Of Voluntariado)()

    End Sub

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
