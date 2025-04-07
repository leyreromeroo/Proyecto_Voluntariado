Imports System.Collections.ObjectModel
Imports System.Collections.Specialized.BitVector32
Imports Clases
Imports Gestion

Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar colores y estilos
        Me.BackColor = Color.LightSteelBlue

        ' Panel principal
        Dim panelGestor As New Panel With {
            .Size = New Size(400, 500),
            .Location = New Point(20, 20),
            .BackColor = Color.WhiteSmoke
        }
        Me.Controls.Add(panelGestor)

        ' Label título
        Dim lblTitulo As New Label With {
            .Text = "Gestión de Acciones de Voluntariado",
            .Font = New Font("Segoe UI", 14, FontStyle.Bold),
            .Location = New Point(50, 10),
            .AutoSize = True
        }
        panelGestor.Controls.Add(lblTitulo)

        ' TextBox para Descripción
        Dim txtDescripcion As New TextBox With {
            .Size = New Size(250, 30),
            .Location = New Point(50, 50)
        }
        panelGestor.Controls.Add(txtDescripcion)

        ' ListBox para Organizaciones
        Dim lstOrganizaciones As New ListBox With {
            .Size = New Size(250, 100),
            .Location = New Point(50, 90)
        }
        panelGestor.Controls.Add(lstOrganizaciones)

        ' Botón Agregar Acción
        Dim btnAgregar As New Button With {
            .Text = "Agregar Acción",
            .Size = New Size(150, 40),
            .Location = New Point(50, 200),
            .BackColor = ColorTranslator.FromHtml("#4CAF50"),
            .ForeColor = Color.White
        }
        AddHandler btnAgregar.Click, AddressOf btnAgregar_Click
        panelGestor.Controls.Add(btnAgregar)

        ' Botón Eliminar Acción
        Dim btnEliminar As New Button With {
            .Text = "Eliminar Acción",
            .Size = New Size(150, 40),
            .Location = New Point(50, 250),
            .BackColor = ColorTranslator.FromHtml("#F44336"),
            .ForeColor = Color.White
        }
        AddHandler btnEliminar.Click, AddressOf btnEliminar_Click
        panelGestor.Controls.Add(btnEliminar)

        ' DataGridView para listar acciones
        Dim dgvAcciones As New DataGridView With {
            .Size = New Size(500, 400),
            .Location = New Point(450, 20)
        }
        Me.Controls.Add(dgvAcciones)

        'en el Load que automáticamente (con datos puestos a mano  en código) se inserte una actividad con varios ODS en BD
        actualizarCboOds()

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


End Class
