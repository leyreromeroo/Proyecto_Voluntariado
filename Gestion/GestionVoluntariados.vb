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

    Public Function CrearActividad(tipo As List(Of TipoVoluntariado), capacidad As Integer, nombre As String, fechaInicio As Date, fechaFin As Date, descripcion As String, nif_org As Organizacion, listaODS As List(Of ODS), listaVoluntarios As List(Of Voluntario), ByRef msgError As String) As String
        ' Validaciones iniciales
        If String.IsNullOrWhiteSpace(nombre) Then
            msgError = "El nombre no puede estar vacío"
            Return False
        End If

        If String.IsNullOrWhiteSpace(descripcion) Then
            msgError = "La descripción no puede estar vacía"
            Return False
        End If

        If capacidad <= 0 Then
            msgError = "La capacidad debe ser mayor que 0"
            Return False
        End If

        If fechaInicio > fechaFin Then
            msgError = "La fecha de inicio no puede ser posterior a la fecha de fin"
            Return False
        End If

        If fechaInicio < Date.Today Then
            msgError = "La fecha de inicio no puede ser anterior al día actual"
            Return False
        End If

        If String.IsNullOrWhiteSpace(nif_org.NIF) Then
            msgError = "El NIF de la organización no puede estar vacío"
            Return False
        End If
        If tipo Is Nothing OrElse tipo.Count = 0 Then
            msgError = "Debe seleccionar al menos un tipo"
            Return False
        End If

        If listaODS Is Nothing OrElse listaODS.Count = 0 Then
            msgError = "Debe seleccionar al menos un ODS"
            Return False
        End If

        If listaVoluntarios Is Nothing OrElse listaVoluntarios.Count = 0 Then Return "Debe asignar al menos un voluntario"

        Dim oConexion As New SqlConnection(_cadenaConexion)
        ' Dim transaction As SqlTransaction = Nothing
        msgError = ""
        Try
            oConexion.Open()

            ' 1. Verificar que la organización existe
            Dim sqlVerificarOrg As String = "SELECT COUNT(*) FROM ORGANIZACIONES WHERE NIF = @NIF"
            Dim cmdVerificarOrg As New SqlCommand(sqlVerificarOrg, oConexion)
            cmdVerificarOrg.Parameters.AddWithValue("@NIF", nif_org)
            Dim numOrg As Integer = cmdVerificarOrg.ExecuteScalar()

            If numOrg = 0 Then
                Return msgError = "La organización no existe"
            End If

            ' 2. Verificar que el tipo de actividad existe
            Dim sqlVerificarTipo As String = "SELECT COUNT(*) FROM TIPO_ACTIVIDAD WHERE NOMBRE = @TipoAct"
            Dim cmdVerificarTipo As New SqlCommand(sqlVerificarTipo, oConexion)
            cmdVerificarTipo.Parameters.AddWithValue("@TipoAct", tipo)
            Dim countTipo As Integer = cmdVerificarTipo.ExecuteScalar()

            If countTipo = 0 Then
                Return msgError = "El tipo de actividad no existe"
            End If

            ' 3. Verificar que los ODS existen
            For Each ods In listaODS
                Dim sqlVerificarODS As String = "SELECT COUNT(*) FROM ODS WHERE NUMODS = @NumODS"
                Dim cmdVerificarODS As New SqlCommand(sqlVerificarODS, oConexion)
                cmdVerificarODS.Parameters.AddWithValue("@NumODS", ods)
                Dim numODS As Integer = cmdVerificarODS.ExecuteScalar()

                If numODS = 0 Then
                    Return msgError = $"El ODS {ods} no existe"
                End If
            Next

            ' 4. Insertar la actividad
            Dim sqlInsertActividad As String = "INSERT INTO ACTIVIDAD (NOMBRE, ESTADO, DESCRIPCION, FECHAINICIO, FECHAFIN, CAPACIDAD, NIF_ORG, NOMBRE_TIPOACT) VALUES (@Nombre, 'DISPONIBLE', @Descripcion, @FechaInicio, @FechaFin, @Capacidad, @Nif_org, @TipoAct)"

            Dim cmdInsertActividad As New SqlCommand(sqlInsertActividad, oConexion)
            cmdInsertActividad.Parameters.AddWithValue("@Nombre", nombre)
            cmdInsertActividad.Parameters.AddWithValue("@Descripcion", descripcion)
            cmdInsertActividad.Parameters.AddWithValue("@FechaInicio", fechaInicio)
            cmdInsertActividad.Parameters.AddWithValue("@FechaFin", fechaFin)
            cmdInsertActividad.Parameters.AddWithValue("@Capacidad", capacidad)
            cmdInsertActividad.Parameters.AddWithValue("@Nif_org", nif_org)
            cmdInsertActividad.Parameters.AddWithValue("@TipoAct", tipo)

            Dim filasActividad As Integer = cmdInsertActividad.ExecuteNonQuery()

            If filasActividad = 0 Then
                Return msgError = "No se pudo insertar la actividad"
            End If

            ' 5. Insertar las relaciones con ODS
            For Each ods In listaODS
                Dim sqlInsertODS As String = "INSERT INTO CONTIENE_VOLUNTARIADO_ODS (CODACTIVIDAD, NUMODS) VALUES (@CodActividad, @NumODS)"
                Dim cmdInsertODS As New SqlCommand(sqlInsertODS, oConexion)
                'cmdInsertODS.Parameters.AddWithValue("@CodActividad", codActividad)
                cmdInsertODS.Parameters.AddWithValue("@NumODS", ods)

                Dim rowsAffected As Integer = cmdInsertODS.ExecuteNonQuery()

                If rowsAffected = 0 Then
                    Return msgError = $"No se pudo asociar el ODS {ods} al voluntariado"
                End If
            Next
            Dim cmdCodActividad As New SqlCommand($"SELECT PARTICIPA_VOLUNTARIO_ACTIVIDAD.CODACTIVIDAD FROM PARTICIPA_VOLUNTARIO_ACTIVIDAD WHERE PARTICIPA_VOLUNTARIO_ACTIVIDAD.CODACTIVIDAD IN (SELECT ACTIVIDAD.CODACTIVIDAD FROM ACTIVIDAD WHERE ACTIVIDAD.NOMBRE = {nombre}")
            Dim codActividad As Integer = Integer.TryParse(cmdCodActividad.ToString, codActividad)
            ' 6. Añadir Voluntarios
            For Each dni In listaVoluntarios
                Dim cmdVol As New SqlCommand("INSERT INTO PARTICIPA_VOLUNTARIO_ACTIVIDAD (DNI, CODACTIVIDAD) VALUES (@dni, @idActividad)", oConexion)

                cmdVol.Parameters.AddWithValue("@dni", dni)
                cmdVol.Parameters.AddWithValue("@idActividad", codActividad)
                cmdVol.ExecuteNonQuery()
            Next

        Catch ex As Exception
            Return msgError = ex.Message
        Finally
            oConexion.Close()
        End Try
        Return msgError = $"Voluntariado {nombre} creado correctamente)"
    End Function

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
                Dim ods As New ODS(drOds("NUMODS").ToString, drOds("NOMBRE").ToString)
                listaOds.Add(ods)
            Loop
        Catch ex As Exception
            msgError = ex.Message
        Finally
            oConexion.Close()
        End Try
        Return listaOds.AsReadOnly
    End Function
    Public Function BuscarOrg(ByRef msgError As String) As ReadOnlyCollection(Of Organizacion)
        Dim listaOrg As New List(Of Organizacion)
        msgError = ""
        Dim oConexion As New SqlConnection(_cadenaConexion)
        Try
            oConexion.Open()
            Dim sql As String = "Select ORGANIZACIONES.NOMBRE From ORGANIZACIONES"
            Dim cmdOrg As New SqlCommand(sql, oConexion)
            Dim drOrg As SqlDataReader = cmdOrg.ExecuteReader
            Do While drOrg.Read
                Dim org As New Organizacion(drOrg("NOMBRE"))
                listaOrg.Add(org)
            Loop
        Catch ex As Exception
            msgError = ex.Message
        Finally
            oConexion.Close()
        End Try
        Return listaOrg.AsReadOnly
    End Function
    Public Function BuscarAlumnosDelMismoTipo(nombreTìpo As String) As List(Of Voluntario)
        Dim listaVoluntarios As New List(Of Voluntario)
        Dim conexion As New SqlConnection(_cadenaConexion)
        conexion.Open()
        Dim consulta As String = $"SELECT VOLUNTARIO.DNI, VOLUNTARIO.NOMBRE, VOLUNTARIO.APELLIDO1 FROM VOLUNTARIO INNER JOIN PREFIERE_VOLUNTARIO_TIPOACTIVIDAD ON VOLUNTARIO.DNI = PREFIERE_VOLUNTARIO_TIPOACTIVIDAD.DNI WHERE PREFIERE_VOLUNTARIO_TIPOACTIVIDAD.NOMBRE_TIPOACT ={nombreTìpo} ;"
        Dim cmdBuscarAlumnosDelMismoTipo As New SqlCommand(consulta, conexion)
        Dim drBuscarAlumnosDelMismoTipo As SqlDataReader = cmdBuscarAlumnosDelMismoTipo.ExecuteReader
        Do While drBuscarAlumnosDelMismoTipo.Read
            Dim vol As New Voluntario(drBuscarAlumnosDelMismoTipo("DNI"), drBuscarAlumnosDelMismoTipo("NOMBRE"), drBuscarAlumnosDelMismoTipo("Apellido1"))
            listaVoluntarios.Add(vol)
        Loop
        Return listaVoluntarios
        conexion.Close()
    End Function

    Public Function ListaTiposActivi() As List(Of TipoVoluntariado)
        Dim conexion As New SqlConnection(_cadenaConexion)
        conexion.Open()

        Dim consultaSQL As String = $"SELECT * FROM TIPO_ACTIVIDAD"
        Dim cmdTipos As New SqlCommand(consultaSQL, conexion)
        Dim drTipos As SqlDataReader = cmdTipos.ExecuteReader
        Dim listaTodosTiposAct As New List(Of TipoVoluntariado)
        While drTipos.Read
            listaTodosTiposAct.Add(New TipoVoluntariado(drTipos("NOMBRE")))
        End While
        conexion.Close()
        Return listaTodosTiposAct
    End Function

    Public Function MostrarAlumnos() As List(Of Voluntario)
        Dim listaVoluntarios As New List(Of Voluntario)
        Dim conexion As New SqlConnection(_cadenaConexion)
        conexion.Open()
        Dim consulta As String = $"SELECT VOLUNTARIO.DNI,VOLUNTARIO.NOMBRE,VOLUNTARIO.APELLIDO1 FROM VOLUNTARIO"
        Dim cmdMostrarAlumnos As New SqlCommand(consulta, conexion)
        Dim drMostrarAlumnos As SqlDataReader = cmdMostrarAlumnos.ExecuteReader
        Do While drMostrarAlumnos.Read
            Dim vol As New Voluntario(drMostrarAlumnos("DNI"), drMostrarAlumnos("NOMBRE"), drMostrarAlumnos("Apellido1"))
            listaVoluntarios.Add(vol)
        Loop
        conexion.Close()
        Return listaVoluntarios
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
    Public Function EliminarVoluntariado(codActividad As Integer, ByRef msgError As String) As String
        ' Validación inicial
        If codActividad <= 0 Then Return "El código de actividad no es válido"

        Dim oConexion As New SqlConnection(_cadenaConexion)
        msgError = ""

        Try
            oConexion.Open()

            ' 1. Verificar que la actividad existe y es un voluntariado
            Dim sqlVerificarActividad As String = "SELECT COUNT(*) FROM ACTIVIDAD
                                          WHERE ACTIVIDAD.CODACTIVIDAD = @CodActividad"
            Dim cmdVerificarActividad As New SqlCommand(sqlVerificarActividad, oConexion)
            cmdVerificarActividad.Parameters.AddWithValue("@CodActividad", codActividad)
            Dim countActividad As Integer = cmdVerificarActividad.ExecuteScalar()

            If countActividad = 0 Then
                ' 2. Eliminar relaciones con ODS
                Dim sqlEliminarODS As String = "DELETE FROM CONTIENE_VOLUNTARIADO_ODS 
                                        WHERE CODACTIVIDAD = @CodActividad"
                Dim cmdEliminarODS As New SqlCommand(sqlEliminarODS, oConexion)
                cmdEliminarODS.Parameters.AddWithValue("@CodActividad", codActividad)
                Dim filasEliminadasODS As Integer = cmdEliminarODS.ExecuteNonQuery()
                If filasEliminadasODS = 0 Then msgError &= ControlChars.NewLine & "No se pudo eliminar el ODS"
            Else
                msgError &= ControlChars.NewLine & "El voluntariado no existe o el código no corresponde a un voluntariado"
            End If

            ' 3. Verificar que no tiene participantes inscritos
            Dim sqlVerificarParticipantes As String = "SELECT COUNT(*) FROM PARTICIPA_VOLUNTARIO_ACTIVIDAD 
                                              WHERE CODACTIVIDAD = @CodActividad"
            Dim cmdVerificarParticipantes As New SqlCommand(sqlVerificarParticipantes, oConexion)
            cmdVerificarParticipantes.Parameters.AddWithValue("@CodActividad", codActividad)
            Dim numParticipantes As Integer = cmdVerificarParticipantes.ExecuteScalar()

            If numParticipantes > 0 Then
                '5. Eliminar relaciones con voluntarios
                Dim sqlEliminarParticipantes As String = "DELETE FROM PARTICIPA_VOLUNTARIO_ACTIVIDAD 
                                              WHERE CODACTIVIDAD = @CodActividad"
                Dim cmdEliminarParticipantes As New SqlCommand(sqlEliminarParticipantes, oConexion)
                cmdEliminarParticipantes.Parameters.AddWithValue("@CodActividad", codActividad)
                Dim filasEliminadasParticipantes As Integer = cmdEliminarParticipantes.ExecuteNonQuery()
                If filasEliminadasParticipantes = 0 Then msgError &= ControlChars.NewLine & "No se pudo eliminar el participante"
            Else
                msgError &= ControlChars.NewLine & "No se puede eliminar el voluntariado porque no tiene voluntarios inscritos"
            End If

            ' 6. Eliminar la actividad
            Dim sqlEliminarActividad As String = "DELETE FROM ACTIVIDAD 
                                              WHERE CODACTIVIDAD = @CodActividad"
            Dim cmdEliminarActividad As New SqlCommand(sqlEliminarActividad, oConexion)
            cmdEliminarActividad.Parameters.AddWithValue("@CodActividad", codActividad)
            Dim filasEliminadas As Integer = cmdEliminarActividad.ExecuteNonQuery()

            If filasEliminadas = 0 Then Return "No se pudo eliminar el voluntariado"

            Return $"Voluntariado {codActividad} eliminado correctamente"

        Catch ex As Exception
            Return "Error general al eliminar el voluntariado: " & ex.Message
        Finally

            oConexion.Close()

        End Try
    End Function


End Class
