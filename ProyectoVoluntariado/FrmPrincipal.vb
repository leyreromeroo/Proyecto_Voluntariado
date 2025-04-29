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

        ' Deshabilitar los campos de texto
        lblNombre.Enabled = False
        lblTipo.Enabled = False
        lblCapacidad.Enabled = False
        lblFechaIni.Enabled = False
        lblFechaFin.Enabled = False
        lblDescripcion.Enabled = False

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

            ' Crear copias independientes del DataTable para cada ComboBox
            Dim dtEliminar As DataTable = dt.Copy()
            Dim dtConsultar As DataTable = dt.Copy()

            ' Configurar el ComboBox para eliminar actividades
            cmbNombreActividadEliminar.DisplayMember = "NOMBRE"       ' Lo que se muestra  
            cmbNombreActividadEliminar.ValueMember = "CODACTIVIDAD"   ' Lo que se usa internamente  
            cmbNombreActividadEliminar.DataSource = dtEliminar
            cmbNombreActividadEliminar.SelectedIndex = -1

            ' Configurar el ComboBox para consultar actividades
            CmbNombreActividadConsultar.DisplayMember = "NOMBRE"       ' Lo que se muestra  
            CmbNombreActividadConsultar.ValueMember = "CODACTIVIDAD"   ' Lo que se usa internamente  
            CmbNombreActividadConsultar.DataSource = dtConsultar
            CmbNombreActividadConsultar.SelectedIndex = -1

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
        If String.IsNullOrWhiteSpace(txtNombre.Text) OrElse String.IsNullOrWhiteSpace(txtCapacidad.Text) OrElse
                  String.IsNullOrWhiteSpace(dtpFechaInicio.Text) OrElse String.IsNullOrWhiteSpace(dtpFechaFin.Text) OrElse
                  String.IsNullOrWhiteSpace(txtDescripcion.Text) Then
            MessageBox.Show("Por favor, completa todos los campos.")
            Exit Sub
        End If

        If lstOdsAnyadidos.Items.Count = 0 Then
            MessageBox.Show("Por favor, añade al menos una ODS.")
            Exit Sub
        End If

        If lstbAlumnAnadidos.Items.Count = 0 Then
            MessageBox.Show("Por favor, añade al menos un voluntario.")
            Exit Sub
        End If

        If cboOrganizaciones.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, selecciona una organización.")
            Exit Sub
        End If

        If cboTipoActividad.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, selecciona un tipo de actividad.")
            Exit Sub
        End If

        Dim capacidad As Integer
        If Not Integer.TryParse(txtCapacidad.Text, capacidad) OrElse capacidad < 1 Then
            MessageBox.Show("La capacidad debe ser un número mayor que 1.")
            Exit Sub
        End If

        Dim fechaInicio As Date, fechaFin As Date
        If Not Date.TryParse(dtpFechaInicio.Text, fechaInicio) OrElse Not Date.TryParse(dtpFechaFin.Text, fechaFin) Then
            MessageBox.Show("Las fechas deben ser válidas.")
            Exit Sub
        End If

        If fechaInicio > fechaFin Then
            MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.")
            Exit Sub
        End If

        If fechaInicio < DateTime.Now Then
            MessageBox.Show("La fecha de inicio no puede ser anterior a la fecha actual.")
            Exit Sub
        End If

        If fechaFin < DateTime.Now Then
            MessageBox.Show("La fecha de fin no puede ser anterior a la fecha actual.")
            Exit Sub
        End If

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

    Private Sub CmbNombreActividadConsultar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbNombreActividadConsultar.SelectedIndexChanged
        ' Deshabilitar los campos de texto
        lblNombre.Enabled = True
        lblTipo.Enabled = True
        lblCapacidad.Enabled = True
        lblFechaIni.Enabled = True
        lblFechaFin.Enabled = True
        lblDescripcion.Enabled = True

        Dim actividadSeleccionada = CType(CmbNombreActividadConsultar.SelectedItem, DataRowView)

        If actividadSeleccionada IsNot Nothing Then
            Dim nombreActividad As String = actividadSeleccionada("Nombre").ToString()
            'Ahora se habilitan los datos y se muestran
            lblNombre.Text = nombreActividad

            Dim voluntariado As New Voluntariado
            voluntariado = gestion.BuscarVoluntariado(actividadSeleccionada("CodActividad"))


            lblTipo.Text = voluntariado.Tipo.ToString()
            lblCapacidad.Text = voluntariado.Capacidad.ToString()
            lblFechaIni.Text = voluntariado.FechaInicio.ToString()
            lblFechaFin.Text = voluntariado.FechaFin.ToString()
            lblDescripcion.Text = voluntariado.Descripcion.ToString()

        End If
    End Sub


End Class
