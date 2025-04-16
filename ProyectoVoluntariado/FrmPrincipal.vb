Imports System.Collections.ObjectModel
Imports System.Collections.Specialized.BitVector32
Imports System.Data.SqlClient
Imports Clases
Imports Gestion


Public Class FrmPrincipal

    Private voluntariado As New Voluntariado
    Private listaODS As New List(Of ODS)
    Private listaVoluntarios As New List(Of Voluntario)
    Private listaTipos As New List(Of TipoVoluntariado)

    Dim gestor As New GestionVoluntariados
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualizarCboOds()
        ActualizarCboOrganizaciones()
        ActualizarlstAlumnos()
        CargarVoluntariados()

        Dim tiposActividades As List(Of TipoVoluntariado) = gestor.ListaTiposActivi()
        cboTipoActividad.DataSource = tiposActividades
        cboTipoActividad.DisplayMember = "Nombre"  ' Especificamos que se muestre la propiedad "Nombre"

    End Sub

    Private Sub CargarVoluntariados()
        Dim conexion As New SqlConnection(gestion.cadenaConexion)
        Dim comando As New SqlCommand("SELECT CODACTIVIDAD, NOMBRE FROM ACTIVIDAD", conexion)
        Dim adaptador As New SqlDataAdapter(comando)
        Dim dt As New DataTable()

        Try
            conexion.Open()
            adaptador.Fill(dt)

            cmbNombreActividadEliminar.DisplayMember = "NOMBRE"       ' Lo que se muestra
            cmbNombreActividadEliminar.ValueMember = "CODACTIVIDAD"   ' Lo que se usa internamente
            cmbNombreActividadEliminar.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error al cargar los voluntariados: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
    Private Sub ActualizarCboOds()
        Dim msgError As String = ""
        Dim listaOds As ReadOnlyCollection(Of ODS)
        cboODS.Items.Clear()
        listaOds = gestion.BuscarODS(msgError)
        If Not String.IsNullOrWhiteSpace(msgError) Then
            MessageBox.Show(msgError)
            Exit Sub
        End If
        cboODS.Items.AddRange(listaOds.ToArray)
    End Sub

    Private Sub ActualizarCboOrganizaciones()
        Dim msgError As String = ""
        Dim listaOrganizaciones As ReadOnlyCollection(Of Organizacion)
        cboOrganizaciones.Items.Clear()
        listaOrganizaciones = gestion.BuscarOrganizaciones(msgError)
        If Not String.IsNullOrWhiteSpace(msgError) Then
            MessageBox.Show(msgError)
            Exit Sub
        End If
        cboOrganizaciones.Items.AddRange(listaOrganizaciones.ToArray)
    End Sub

    Private Sub ActualizarlstAlumnos()
        Dim msgError As String = ""
        Dim listaAlumnos As ReadOnlyCollection(Of Voluntario)
        lstbAlumn.Items.Clear()
        listaAlumnos = gestion.MostrarAlumnos()
        lstbAlumn.Items.AddRange(listaAlumnos.ToArray)
    End Sub
    Private Sub btnAnadirOds_Click(sender As Object, e As EventArgs) Handles btnAnadirODS.Click
        Dim odsSeleccionado As ODS = TryCast(cboODS.SelectedItem, ODS)
        If odsSeleccionado Is Nothing Then Exit Sub
        lstOdsAnyadidos.Items.Add(odsSeleccionado)
        cboODS.Items.Remove(odsSeleccionado)
    End Sub

    Private Sub btnEliminarOds_Click(sender As Object, e As EventArgs) Handles btnEliminarODS.Click
        If lstOdsAnyadidos.SelectedItem Is Nothing Then Exit Sub
        lstOdsAnyadidos.Items.Remove(lstOdsAnyadidos.SelectedItem)

    End Sub

    Private Sub btnAnadirAlumnos_Click(sender As Object, e As EventArgs) Handles btnAnadirAlumnos.Click
        If lstbAlumn.SelectedItem IsNot Nothing Then
            Dim voluntarioSeleccionado As Voluntario = lstbAlumn.SelectedItem
            lstbAlumn.Items.Remove(voluntarioSeleccionado)
            lstbAlumnAnadidos.Items.Add(voluntarioSeleccionado)
        Else
            MessageBox.Show("Selecciona un alumno antes de añadir.")
        End If
    End Sub

    Private Sub btnEliminarAlumnos_Click(sender As Object, e As EventArgs) Handles btnEliminarAlumnos.Click
        If lstbAlumnAnadidos.SelectedItem IsNot Nothing Then
            Dim voluntarioSeleccionado As Voluntario = lstbAlumnAnadidos.SelectedItem
            lstbAlumnAnadidos.Items.Remove(voluntarioSeleccionado)
            lstbAlumn.Items.Add(voluntarioSeleccionado)
        Else
            MessageBox.Show("Selecciona un alumno antes de añadir.")
        End If
    End Sub

    Private Sub btnCrearActividad_Click(sender As Object, e As EventArgs) Handles btnCrearActividad.Click
        Dim odsSeleccionados As New List(Of ODS)
        Dim voluntariosSeleccionados As New List(Of Voluntario)
        Dim organizacion As Organizacion = TryCast(cboOrganizaciones.SelectedItem, Organizacion)
        Dim tipoActividad As TipoVoluntariado = TryCast(cboTipoActividad.SelectedItem, TipoVoluntariado)

        For Each item As ODS In lstOdsAnyadidos.Items
            odsSeleccionados.Add(item)
        Next

        For Each item As Voluntario In lstbAlumnAnadidos.Items
            voluntariosSeleccionados.Add(item)
        Next

        Dim msgError As String = gestion.CrearActividad(tipoActividad, txtCapacidad.Text, txtNombre.Text, dtpFechaInicio.Text, dtpFechaFin.Text, txtDescripcion.Text, organizacion, odsSeleccionados, voluntariosSeleccionados)
        If msgError = True Then
            MessageBox.Show("Actividad creada exitosamente.")
            CargarVoluntariados()
        Else
            MessageBox.Show("Error al crear la actividad: " & msgError)
        End If
    End Sub

    Private Sub btnEliminarActividad_Click(sender As Object, e As EventArgs) Handles btnEliminarActividad.Click
        Dim actividadSeleccionada = CType(cmbNombreActividadEliminar.SelectedItem, DataRowView)
        If actividadSeleccionada IsNot Nothing Then
            Dim nombreActividad As String = actividadSeleccionada("Nombre").ToString()
            Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar la actividad " & nombreActividad & "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If resultado = DialogResult.Yes Then
                MessageBox.Show($"" & gestion.EliminarVoluntariado(actividadSeleccionada("CODACTIVIDAD")))
                CargarVoluntariados()
            End If
        End If
    End Sub


End Class
