Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Clases

Public Class GestionVoluntariados
    Private ReadOnly _voluntariados As List(Of Voluntariado)
    'Private _servidor As String = Environment.MachineName
    'Private ReadOnly _servidorAlternativo As String = "."
    Private _cadenaConexion

    Public ReadOnly Property Voluntariados As List(Of Voluntariado)
        Get
            Return _voluntariados
        End Get
    End Property

    Public Sub New()
        _voluntariados = New List(Of Voluntariado)()
        'Comprobación para que la BBDD funcione siempre
        Dim servidor As String
        If Environment.MachineName = "4V-PRO-948" Then
            servidor = "4V-PRO-948\SQLEXPRESS"
        Else
            servidor = "."
        End If

        _cadenaConexion = "Data Source = " & servidor & "; Initial Catalog = PROYECTO_VOLUNTARIADO2; Integrated Security = SSPI; MultipleActiveResultSets=true"
    End Sub


    Public Function BuscarODS(ByRef msgError As String) As ReadOnlyCollection(Of ODS)
        Dim listaOds As New List(Of ODS)
        msgError = ""
        Dim oConexion As New SqlConnection(_cadenaConexion)
        Try
            oConexion.Open()
            Dim sql As String = "Select NUMODS, Nombre From ODS"
            Dim cmdOds As New SqlCommand(sql, oConexion)
            Dim drOds As SqlDataReader = cmdOds.ExecuteReader
            Do While drOds.Read
                Dim ods As New ODS(drOds("NUMODS").ToString, drOds("NOMBRE").ToString, drOds("DESCRIPCION").ToString)
                listaOds.Add(ods)
            Loop
        Catch ex As Exception
            msgError = ex.Message
        Finally
            oConexion.Close()
        End Try
        Return listaOds.AsReadOnly
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
