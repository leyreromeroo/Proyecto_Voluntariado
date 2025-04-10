﻿Imports System.Collections.ObjectModel
Imports System.Collections.Specialized.BitVector32
Imports Clases
Imports Gestion


Public Class FrmPrincipal

    Private voluntariado As New Voluntariado
    Dim gestor As New GestionVoluntariados
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualizarCboOds()
        'cboTipoActividad.Items.AddRange(voluntariado.Tipo.ToArray)

        Dim lista As List(Of Voluntario) = gestion.MostrarAlumnos()
        For Each vol As Voluntario In lista
            lstbAlumn.Items.Add(vol)
        Next


        Dim tiposActividades As List(Of TipoVoluntariado) = gestor.ListaTiposActivi()
        cboTipoActividad.DataSource = tiposActividades
        cboTipoActividad.DisplayMember = "Nombre"  ' Especificamos que se muestre la propiedad "Nombre"

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

    Private Sub btnAnadirOds_Click(sender As Object, e As EventArgs) Handles btnAnadirOds.Click
        Dim odsSeleccionada As ODS = TryCast(cboODS.SelectedItem, ODS)
        If odsSeleccionada Is Nothing Then Exit Sub
        lstDatosAnyadidos.Items.Add(odsSeleccionada.Nombre)
    End Sub

    Private Sub btnEliminarOds_Click(sender As Object, e As EventArgs) Handles btnEliminarOds.Click
        If lstDatosAnyadidos.SelectedItem Is Nothing Then Exit Sub
        lstDatosAnyadidos.Items.Remove(lstDatosAnyadidos.SelectedItem)
    End Sub

    Private Sub btnAnadirTiposACt_Click(sender As Object, e As EventArgs) Handles btnAñadirTipoAc.Click

        Dim tipoSeleccionado As TipoVoluntariado = TryCast(cboTipoActividad.SelectedItem, TipoVoluntariado)
        If tipoSeleccionado IsNot Nothing Then
            ' Evitamos duplicados
            If Not lstTipoActividad.Items.Contains(tipoSeleccionado.Nombre) Then
                lstTipoActividad.Items.Add(tipoSeleccionado.Nombre)
            End If
        End If


    End Sub

    Private Sub btnEliminarTiposACt_Click(sender As Object, e As EventArgs) Handles btnEliminarTipoAc.Click
        If lstTipoActividad.SelectedItem Is Nothing Then Exit Sub
        lstTipoActividad.Items.Remove(lstTipoActividad.SelectedItem)
    End Sub


    ' Evento para Agregar Acción
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Función para agregar una acción")
    End Sub

    ' Evento para Eliminar Acción
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Función para eliminar una acción")
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub lstDatosAnyadidos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDatosAnyadidos.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoActividad.SelectedIndexChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

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
        gestor.AnyadirVoluntariado()
    End Sub
End Class
