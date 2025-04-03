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
    End Sub

    ' Evento para Agregar Acción
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Función para agregar una acción")
    End Sub

    ' Evento para Eliminar Acción
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Función para eliminar una acción")
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles label24.Click

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles lblFechaFin.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
