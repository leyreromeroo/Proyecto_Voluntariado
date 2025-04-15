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
<<<<<<< HEAD
        ActualizarCboOrganizaciones()
        ActualizarlstAlumnos()
        CargarVoluntariados()
        ' cboTipoActividad.Items.AddRange(voluntariado.Tipo.ToArray)
=======
        ActualizarCboOds()
        'cboTipoActividad.Items.AddRange(voluntariado.Tipo.ToArray)
>>>>>>> 00ef619c841195e70ce559ab86410dcacb1a7439

        'Dim lista As List(Of Voluntario) = gestion.MostrarAlumnos()
        'For Each vol As Voluntario In lista
        '    lstbAlumn.Items.Add(vol)
        'Next


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
        Dim listaOrg As ReadOnlyCollection(Of Organizacion)
        cboOrg.Items.Clear()
        listaOrg = gestion.BuscarOrg(msgError)
        If Not String.IsNullOrWhiteSpace(msgError) Then
            MessageBox.Show(msgError)
            Exit Sub
        End If
        cboOrg.Items.AddRange(listaOrg.ToArray)
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
    End Sub

    Private Sub btnEliminarOds_Click(sender As Object, e As EventArgs) Handles btnEliminarODS.Click
        If lstOdsAnyadidos.SelectedItem Is Nothing Then Exit Sub
        lstOdsAnyadidos.Items.Remove(lstOdsAnyadidos.SelectedItem)
    End Sub

    Private Sub btnAnadirTiposACt_Click(sender As Object, e As EventArgs) Handles btnAñadirTipoAc.Click

        Dim tipoSeleccionado As TipoVoluntariado = TryCast(cboTipoActividad.SelectedItem, TipoVoluntariado)
        If tipoSeleccionado IsNot Nothing Then
            ' Evitamos duplicados
            If Not lstTipoActividad.Items.Contains(tipoSeleccionado.Nombre) Then
                lstTipoActividad.Items.Add(tipoSeleccionado)
            End If
        End If


    End Sub

    Private Sub btnEliminarTiposACt_Click(sender As Object, e As EventArgs) Handles btnEliminarTipoAc.Click
        If lstTipoActividad.SelectedItem Is Nothing Then Exit Sub
        lstTipoActividad.Items.Remove(lstTipoActividad.SelectedItem)
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
<<<<<<< HEAD
        'Dim listaTipoActividad As New List(Of TipoVoluntariado)
        'Dim odsSeleccionados As New List(Of ODS)
        'Dim voluntariosSeleccionados As New List(Of Voluntario)
        'Dim organizacion As New Organizacion

        'Dim tipoActividad As New TipoVoluntariado With {
        '    .Nombre = lstTipoActividad.Items.ToString() 'No sé si es item y hacer un for each
        '}
        'listaTipoActividad.Add(tipoActividad)

        'Dim org As Organizacion = TryCast(cboOrganizaciones.SelectedItem, Organizacion)

        'For Each item As ODS In lstOdsAnyadidos.Items
        '    odsSeleccionados.Add(item)
        'Next
        'For Each item As Voluntario In lstbAlumnAnadidos.Items
        '    voluntariosSeleccionados.Add(item)
        'Next

        'MessageBox.Show($"{gestion.CrearActividad(listaTipoActividad, txtCapacidad.Text, txtNombre.Text, txtFechaIni.Text, txtFechaFin.Text, txtDescripcion.Text, org, odsSeleccionados, voluntariosSeleccionados)}")
        Dim listaTipoActividad As New List(Of TipoVoluntariado)
        Dim odsSeleccionados As New List(Of ODS)
        Dim voluntariosSeleccionados As New List(Of Voluntario)
        Dim organizacion As Organizacion = TryCast(cboOrganizaciones.SelectedItem, Organizacion)

        For Each item As TipoVoluntariado In lstTipoActividad.Items
            listaTipoActividad.Add(item)
        Next

        For Each item As ODS In lstOdsAnyadidos.Items
            odsSeleccionados.Add(item)
        Next

        For Each item As Voluntario In lstbAlumnAnadidos.Items
            voluntariosSeleccionados.Add(item)
        Next

        'Dim nuevaActividad As New Voluntariado With {
        '    .Nombre = txtNombre.Text,
        '    .Capacidad = Convert.ToInt32(txtCapacidad.Text),
        '    .FechaInicio = Convert.ToDateTime(txtFechaIni.Text),
        '    .FechaFin = Convert.ToDateTime(txtFechaFin.Text),
        '    .Descripcion = txtDescripcion.Text,
        '    .Organizaciones = organizacion,
        '    .Tipo = listaTipoActividad,
        '    .ListaODS = odsSeleccionados,
        '    .Voluntarios = voluntariosSeleccionados
        '}

        'Dim msgError As String = gestion.CrearActividad(nuevaActividad)
        Dim msgError As String = gestion.CrearActividad(listaTipoActividad, txtCapacidad.Text, txtNombre.Text, txtFechaIni.Text, txtFechaFin.Text, txtDescripcion.Text, organizacion, odsSeleccionados, voluntariosSeleccionados)
        If String.IsNullOrWhiteSpace(msgError) Then
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

=======
        Dim nombreActividad As String = txtNombre.Text
        Dim cantidadAlumnos As Integer = txtCapacidad.Text
        Dim tipoActividad As New List(Of TipoVoluntariado)
        For i As Integer = 0 To lstTipoActividad.Items.Count - 1
            tipoActividad.Add(lstTipoActividad.Items(i))
        Next
        gestor.CrearActividad(tipoActividad, cantidadAlumnos, )
    End Sub

>>>>>>> 00ef619c841195e70ce559ab86410dcacb1a7439

End Class
