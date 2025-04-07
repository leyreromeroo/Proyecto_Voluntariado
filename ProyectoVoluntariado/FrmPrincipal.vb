Imports System.Collections.ObjectModel
Imports System.Collections.Specialized.BitVector32
Imports Clases
Imports Gestion


Public Class FrmPrincipal

    Private voluntariado As New Voluntariado
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'en el Load que automáticamente (con datos puestos a mano  en código) se inserte una actividad con varios ODS en BD
        actualizarCboOds()
        cboTipoActividad.Items.AddRange(voluntariado.Tipo.ToArray)

    End Sub

    Private Sub actualizarCboOds()
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
End Class
