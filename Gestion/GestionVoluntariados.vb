﻿Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Imports Clases

Public Class GestionVoluntariados
    Private ReadOnly _voluntariados As List(Of Voluntariado)
    'Private _servidor As String = Environment.MachineName
    'Private ReadOnly _servidorAlternativo As String = "."
    Public cadenaConexion As String

    Public ReadOnly Property Voluntariados As List(Of Voluntariado)
        Get
            Return _voluntariados
        End Get
    End Property

    'Public Sub New()
    '    _voluntariados = New List(Of Voluntariado)()
    '    'Comprobación para que la BBDD funcione siempre
    '    Dim servidor As String
    '    If Environment.MachineName = "4V-PRO-948" Then
    '        servidor = "4V-PRO-948\SQLEXPRESS"
    '    Else
    '        servidor = "."
    '    End If

    '    cadenaConexion = "Data Source = " & servidor & "; Initial Catalog = PROYECTO_VOLUNTARIADO2; Integrated Security = SSPI; MultipleActiveResultSets=true"
    'End Sub

    Public Sub New()
        _voluntariados = New List(Of Voluntariado)()
        Dim servidor As String
        servidor = NombreServidor()
        cadenaConexion = $"Data Source={servidor}; Initial Catalog = PROYECTO_VOLUNTARIADO2; Integrated Security = SSPI; MultipleActiveResultSets=true"
        'conexion = New SqlConnection(cadenaConexion) La conexión se abre en cada función
        VerificarOCrearBaseDeDatos(servidor)
    End Sub
    Public Function NombreServidor() As String
        Try
            If File.Exists("fichero.txt") Then
                Dim lineas() As String = File.ReadAllLines("fichero.txt")
                If lineas.Length > 0 Then
                    Return lineas(0)
                Else
                    Return "El fichero está vacío. Usando servidor por defecto."
                End If
            Else
                File.WriteAllText("fichero.txt", ".")
                Return "El fichero no existía. Se ha creado con el servidor por defecto."
            End If
        Catch ex As Exception
            Return $"Error al manejar el fichero: {ex.Message}"
        End Try
    End Function

    Private Sub VerificarOCrearBaseDeDatos(servidor As String)
        Dim cadenaConexionMaster As String = $"Data Source={servidor}; Initial Catalog=master; Integrated Security=SSPI;"
        Using conexion As New SqlConnection(cadenaConexionMaster)
            Try
                conexion.Open()
                Dim consultaVerificar As String = "IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'PROYECTO_VOLUNTARIADO2') CREATE DATABASE PROYECTO_VOLUNTARIADO2;"
                Dim cmdVerificar As New SqlCommand(consultaVerificar, conexion)
                cmdVerificar.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception($"Error al verificar o crear la base de datos: {ex.Message}")
            End Try
        End Using
    End Sub

    Public Function CrearActividad(tipo As TipoVoluntariado, capacidad As Integer, nombre As String, fechaInicio As Date, fechaFin As Date, descripcion As String, nif_org As Organizacion, listaODS As List(Of ODS), listaVoluntarios As List(Of Voluntario)) As String
        Dim msgError As String = ""
        ' Validaciones iniciales
        If String.IsNullOrWhiteSpace(nombre) Then
            Return "El nombre no puede estar vacío"
        End If

        If String.IsNullOrWhiteSpace(descripcion) Then
            Return "La descripción no puede estar vacía"
        End If

        If capacidad <= 0 Then
            Return "La capacidad debe ser mayor que 0"
        End If

        If fechaInicio > fechaFin Then
            Return "La fecha de inicio no puede ser posterior a la fecha de fin"
        End If

        If fechaInicio < Date.Today Then
            Return "La fecha de inicio no puede ser anterior al día actual"
        End If

        If String.IsNullOrWhiteSpace(nif_org.NIF) Then
            Return "El NIF de la organización no puede estar vacío"
        End If
        If tipo Is Nothing OrElse String.IsNullOrWhiteSpace(tipo.Nombre) Then
            Return "Debe seleccionar al menos un tipo"
        End If

        If listaODS Is Nothing OrElse listaODS.Count = 0 Then
            Return "Debe seleccionar al menos un ODS"
        End If

        If listaVoluntarios Is Nothing OrElse listaVoluntarios.Count = 0 Then Return "Debe asignar al menos un voluntario"

        Dim oConexion As New SqlConnection(cadenaConexion)
        Try
            oConexion.Open()

            ' 1. Verificar que la organización existe
            Dim sqlVerificarOrg As String = "SELECT COUNT(*) FROM ORGANIZACIONES WHERE NIF = @NIF"
            Dim cmdVerificarOrg As New SqlCommand(sqlVerificarOrg, oConexion)
            cmdVerificarOrg.Parameters.AddWithValue("@NIF", nif_org.NIF)
            Dim numOrg As Integer = cmdVerificarOrg.ExecuteScalar()

            If numOrg = 0 Then
                Return "La organización no existe"
            End If

            ' 3. Verificar que los ODS existen Funciona
            For Each ods In listaODS
                Dim sqlVerificarODS As String = "SELECT COUNT(*) FROM ODS WHERE NUMODS = @NumODS"
                Dim cmdVerificarODS As New SqlCommand(sqlVerificarODS, oConexion)
                cmdVerificarODS.Parameters.AddWithValue("@NumODS", ods.Numero)
                Dim numODS As Integer = cmdVerificarODS.ExecuteScalar()

                If numODS = 0 Then
                    Return $"El ODS {ods} no existe"
                End If
            Next

            ' 4. Insertar la actividad FALLA
            Dim sqlInsertActividad As String = "INSERT INTO ACTIVIDAD (NOMBRE, ESTADO, DESCRIPCION, FECHAINICIO, FECHAFIN, CAPACIDAD, NIF_ORG, NOMBRE_TIPOACT) VALUES (@Nombre, 'DISPONIBLE', @Descripcion, @FechaInicio, @FechaFin, @Capacidad, @Nif_org, @TipoAct)"

            Dim cmdInsertActividad As New SqlCommand(sqlInsertActividad, oConexion)
            cmdInsertActividad.Parameters.AddWithValue("@Nombre", nombre)
            cmdInsertActividad.Parameters.AddWithValue("@Descripcion", descripcion)
            cmdInsertActividad.Parameters.AddWithValue("@FechaInicio", fechaInicio)
            cmdInsertActividad.Parameters.AddWithValue("@FechaFin", fechaFin)
            cmdInsertActividad.Parameters.AddWithValue("@Capacidad", capacidad)
            cmdInsertActividad.Parameters.AddWithValue("@Nif_org", nif_org.NIF)
            cmdInsertActividad.Parameters.AddWithValue("@TipoAct", tipo.Nombre)

            Dim filasActividad As Integer = cmdInsertActividad.ExecuteNonQuery()

            If filasActividad = 0 Then
                Return "No se pudo insertar la actividad"
            End If


            'Dim cmdCodActividad As New SqlCommand($"SELECT CODACTIVIDAD FROM ACTIVIDAD WHERE ACTIVIDAD.NOMBRE = '{nombre}'")
            Dim cmdCodActividad As New SqlCommand("SELECT CODACTIVIDAD FROM ACTIVIDAD WHERE NOMBRE = @nombre", oConexion)
            cmdCodActividad.Parameters.AddWithValue("@nombre", nombre)
            ' Ejecutar la consulta
            Dim codActividad As Integer = cmdCodActividad.ExecuteScalar() ' Ya tienes el codActividad

            ' 5. Añadir Voluntarios
            For Each voluntario In listaVoluntarios
                Dim cmdVol As New SqlCommand("INSERT INTO PARTICIPA_VOLUNTARIO_ACTIVIDAD (DNI, CODACTIVIDAD) VALUES (@dni, @idActividad)", oConexion)

                cmdVol.Parameters.AddWithValue("@dni", voluntario.DNI)
                cmdVol.Parameters.AddWithValue("@idActividad", codActividad)
                Dim rowsAffected As Integer = cmdVol.ExecuteNonQuery()
                If rowsAffected = 0 Then
                    Return $"No se pudo asociar el voluntario {voluntario.Nombre} al voluntariado"
                End If
            Next

            ' 6. Insertar las relaciones con ODS
            For Each ods In listaODS
                Dim sqlInsertODS As String = "INSERT INTO CONTIENE_VOLUNTARIADO_ODS (CODACTIVIDAD, NUMODS) VALUES (@CodActividad, @NumODS)"
                Dim cmdInsertODS As New SqlCommand(sqlInsertODS, oConexion)
                cmdInsertODS.Parameters.AddWithValue("@CodActividad", codActividad)
                cmdInsertODS.Parameters.AddWithValue("@NumODS", ods.Numero)

                Dim rowsAffected As Integer = cmdInsertODS.ExecuteNonQuery()

                If rowsAffected = 0 Then
                    Return $"No se pudo asociar el ODS {ods} al voluntariado"
                End If
            Next
        Catch ex As Exception
            Return ex.Message
        Finally
            oConexion.Close()
        End Try
        Return msgError = ""
    End Function

    Public Function EliminarVoluntariado(codActividad As Integer) As String
        ' Validación inicial
        If codActividad <= 0 Then Return "El código de actividad no es válido"

        Dim oConexion As New SqlConnection(cadenaConexion)
        Dim msgError As String = ""

        Try
            oConexion.Open()

            ' 1. Verificar que la actividad existe y es un voluntariado
            Dim sqlVerificarActividad As String = "SELECT COUNT(*) FROM ACTIVIDAD
                                             WHERE ACTIVIDAD.CODACTIVIDAD = @CodActividad"
            Dim cmdVerificarActividad As New SqlCommand(sqlVerificarActividad, oConexion)
            cmdVerificarActividad.Parameters.AddWithValue("@CodActividad", codActividad)
            Dim countActividad As Integer = cmdVerificarActividad.ExecuteScalar()

            If countActividad > 0 Then
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

            ' 3. Verificar que no tiene noticias asociadas
            Dim sqlVerificarNoticias As String = "SELECT COUNT(*) FROM NOTICIAS 
                                                 WHERE CODACTIVIDAD = @CodActividad"
            Dim cmdVerificarNoticias As New SqlCommand(sqlVerificarNoticias, oConexion)
            cmdVerificarNoticias.Parameters.AddWithValue("@CodActividad", codActividad)
            Dim numNoticias As Integer = cmdVerificarNoticias.ExecuteScalar()

            If numNoticias > 0 Then
                '5. Eliminar relaciones con noticias
                Dim sqlEliminarNoticias As String = "DELETE FROM NOTICIAS 
                                                 WHERE CODACTIVIDAD = @CodActividad"
                Dim cmdEliminarNoticias As New SqlCommand(sqlEliminarNoticias, oConexion)
                cmdEliminarNoticias.Parameters.AddWithValue("@CodActividad", codActividad)
                Dim filasEliminadasNoticias As Integer = cmdEliminarNoticias.ExecuteNonQuery()
                If filasEliminadasNoticias = 0 Then msgError &= ControlChars.NewLine & "No se pudo eliminar la noticia"
            Else
                msgError &= ControlChars.NewLine & "No se puede eliminar el voluntariado porque no tiene noticias asociadas"
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
    Public Function BuscarODS(ByRef msgError As String) As ReadOnlyCollection(Of ODS)
        Dim listaOds As New List(Of ODS)
        msgError = ""
        Dim oConexion As New SqlConnection(cadenaConexion)
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

    Public Function BuscarOrganizaciones(ByRef msgError As String) As ReadOnlyCollection(Of Organizacion)
        Dim listaOrganizaciones As New List(Of Organizacion)
        msgError = ""
        Dim oConexion As New SqlConnection(cadenaConexion)
        Try
            oConexion.Open()
            Dim sql As String = "SELECT NIF, Nombre FROM ORGANIZACIONES"
            Dim cmdOrg As New SqlCommand(sql, oConexion)
            Dim drOrg As SqlDataReader = cmdOrg.ExecuteReader
            Do While drOrg.Read
                Dim org As New Organizacion(drOrg("NIF").ToString, drOrg("Nombre").ToString)
                listaOrganizaciones.Add(org)
            Loop
        Catch ex As Exception
            msgError = ex.Message
        Finally
            oConexion.Close()
        End Try
        Return listaOrganizaciones.AsReadOnly
    End Function
    Public Function BuscarAlumnosDelMismoTipo(nombreTìpo As String) As List(Of Voluntario)
        Dim listaVoluntarios As New List(Of Voluntario)
        Dim conexion As New SqlConnection(cadenaConexion)
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
        Dim conexion As New SqlConnection(cadenaConexion)
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

    Public Function MostrarAlumnos() As ReadOnlyCollection(Of Voluntario)
        Dim listaVoluntarios As New List(Of Voluntario)
        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()
        Dim consulta As String = $"SELECT VOLUNTARIO.DNI,VOLUNTARIO.NOMBRE,VOLUNTARIO.APELLIDO1 FROM VOLUNTARIO"
        Dim cmdMostrarAlumnos As New SqlCommand(consulta, conexion)
        Dim drMostrarAlumnos As SqlDataReader = cmdMostrarAlumnos.ExecuteReader
        Do While drMostrarAlumnos.Read
            Dim vol As New Voluntario(drMostrarAlumnos("DNI"), drMostrarAlumnos("NOMBRE"), drMostrarAlumnos("Apellido1"))
            listaVoluntarios.Add(vol)
        Loop
        conexion.Close()
        Return listaVoluntarios.AsReadOnly
    End Function
    'Zona del último merge
    Public Function BuscarVoluntariado(codActividad As Integer) As Voluntariado
        Dim voluntariado As Voluntariado = Nothing
        Dim conexion As New SqlConnection(cadenaConexion)
        Try
            conexion.Open()
            Dim consulta As String = "SELECT CODACTIVIDAD, CAPACIDAD, ESTADO, NOMBRE, FECHAINICIO, FECHAFIN, DESCRIPCION, NOMBRE_TIPOACT FROM ACTIVIDAD WHERE CODACTIVIDAD = @CodActividad"
            Dim cmdBuscarVoluntariado As New SqlCommand(consulta, conexion)
            cmdBuscarVoluntariado.Parameters.AddWithValue("@CodActividad", codActividad)
            Dim drBuscarVoluntariado As SqlDataReader = cmdBuscarVoluntariado.ExecuteReader
            If drBuscarVoluntariado.Read() Then
                voluntariado = New Voluntariado(
                    drBuscarVoluntariado("CODACTIVIDAD"),
                    drBuscarVoluntariado("CAPACIDAD"),
                    drBuscarVoluntariado("ESTADO"),
                    drBuscarVoluntariado("NOMBRE"),
                    drBuscarVoluntariado("FECHAINICIO"),
                    drBuscarVoluntariado("FECHAFIN"),
                    drBuscarVoluntariado("DESCRIPCION"),
                    drBuscarVoluntariado("NOMBRE_TIPOACT")
                )
            End If
        Catch ex As Exception
            Throw New Exception("Error al buscar el voluntariado: " & ex.Message)
        Finally
            conexion.Close()
        End Try
        Return voluntariado
    End Function

    Public Function MostrarActividades() As List(Of Voluntariado)
        Dim nombreActividad As String
        Dim listaVoluntariados As New List(Of Voluntariado)
        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()
        Dim consulta As String = $"SELECT ACTIVIDAD.NOMBRE, ACTIVIDAD.ESTADO, ACTIVIDAD.CODACTIVIDAD FROM ACTIVIDAD"
        Dim cmdMostrarVoluntariados As New SqlCommand(consulta, conexion)
        Dim drMostrarVoluntariados As SqlDataReader = cmdMostrarVoluntariados.ExecuteReader
        Do While drMostrarVoluntariados.Read
            nombreActividad = drMostrarVoluntariados("NOMBRE")
            Dim vol As New Voluntariado(nombreActividad, drMostrarVoluntariados("ESTADO"), drMostrarVoluntariados("CODACTIVIDAD"))
            listaVoluntariados.Add(vol)
        Loop
        conexion.Close()
        Return listaVoluntariados
    End Function


    Public Function GuardarNuevoEstado(nuevoEstado As String, codigoVol As String) As String
        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()
        Dim consulta As String = $"SELECT NOMBRE FROM ACTIVIDAD WHERE CODACTIVIDAD='{codigoVol}' AND ESTADO = '{nuevoEstado}'"
        Dim cmdGuardarNuevoEstado As New SqlCommand(consulta, conexion)
        Dim devuelveQuery As String = cmdGuardarNuevoEstado.ExecuteScalar()

        If devuelveQuery Is Nothing Then
            Dim consulta2 As String = $"UPDATE ACTIVIDAD SET ESTADO='{nuevoEstado}' WHERE CODACTIVIDAD='{codigoVol}'"
            Dim cmdGuardarNuevoEstado2 As New SqlCommand(consulta2, conexion)
            Dim numeroFilas2 As Integer = cmdGuardarNuevoEstado2.ExecuteNonQuery()

            If numeroFilas2 > 0 Then
                conexion.Close()
                Return "Cambio Guardado"
            Else
                conexion.Close()
                Return "Error al guardar el cambio, vuelve a intentarlo"
            End If
        Else
            Return "Error: No puedes poner el mismo estado que antes"
        End If

    End Function

    Public Function ActividadPorFecha(fechaIni As Date, fechaFin As Date) As List(Of Voluntariado)
        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()
        Dim nombreActividad As String
        Dim listaVoluntariados As New List(Of Voluntariado)
        Dim consulta As String = $"SELECT ACTIVIDAD.NOMBRE FROM ACTIVIDAD WHERE FECHAINICIO BETWEEN '{fechaIni}' AND '{fechaFin}'"
        Dim cmdActividadPorFecha As New SqlCommand(consulta, conexion)
        Dim drActividadPorFecha As SqlDataReader = cmdActividadPorFecha.ExecuteReader()
        Do While drActividadPorFecha.Read
            nombreActividad = drActividadPorFecha("NOMBRE")
            Dim vol As New Voluntariado(nombreActividad)
            listaVoluntariados.Add(vol)
        Loop
        conexion.Close()
        Return listaVoluntariados

    End Function

    Public Function MostrarCursos() As List(Of String)
        Dim listaCursos As New List(Of String)
        Dim año1 As Integer = 2019
        Dim año2 As Integer = 2020
        For i As Integer = 0 To 5

            Dim curso As String = año1.ToString + "-" + año2.ToString
            listaCursos.Add(curso)
            año1 = año1 + 1
            año2 = año2 + 1
        Next
        Return listaCursos
    End Function




End Class
