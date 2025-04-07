<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblContadorAlumn = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtListaODS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtListaAlumn = New System.Windows.Forms.TextBox()
        Me.listbTipo = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.LBL_NOMBRE_ACTIVIDAD = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblFechaIni = New System.Windows.Forms.Label()
        Me.lblCapacidad = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtBorrarActividad = New System.Windows.Forms.TextBox()
        Me.txtNombreCambiar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.label24 = New System.Windows.Forms.Label()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.txtFechaIni = New System.Windows.Forms.TextBox()
        Me.txtFechaFin = New System.Windows.Forms.TextBox()
        Me.btnAñadirAlumn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBorrarODS = New System.Windows.Forms.Button()
        Me.btnAñadirODS = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.grpConsultarAct = New System.Windows.Forms.GroupBox()
        Me.grpGestionAct = New System.Windows.Forms.GroupBox()
        Me.btnPonerEntidad = New System.Windows.Forms.Button()
        Me.lstDatosAnyadidos = New System.Windows.Forms.ListBox()
        Me.cboODS = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listbCampo = New System.Windows.Forms.ListBox()
        Me.txtCambio = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.grpEdicionAct = New System.Windows.Forms.GroupBox()
        Me.grpConsultarAct.SuspendLayout()
        Me.grpGestionAct.SuspendLayout()
        Me.grpEdicionAct.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(358, 129)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 16)
        Me.Label21.TabIndex = 59
        Me.Label21.Text = "FECHA FIN"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(68, 132)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(93, 16)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "FECHA INICIO"
        '
        'lblContadorAlumn
        '
        Me.lblContadorAlumn.AutoSize = True
        Me.lblContadorAlumn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContadorAlumn.Location = New System.Drawing.Point(28, 548)
        Me.lblContadorAlumn.Name = "lblContadorAlumn"
        Me.lblContadorAlumn.Size = New System.Drawing.Size(57, 36)
        Me.lblContadorAlumn.TabIndex = 57
        Me.lblContadorAlumn.Text = "2/7"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(21, 513)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(251, 16)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "CANTIDAD VOLUNTARIOS AÑADIDOS:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(318, 323)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(226, 16)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "LISTA ALUMNOS CON MISMO TIPO"
        '
        'txtListaODS
        '
        Me.txtListaODS.Location = New System.Drawing.Point(304, 343)
        Me.txtListaODS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtListaODS.Multiline = True
        Me.txtListaODS.Name = "txtListaODS"
        Me.txtListaODS.Size = New System.Drawing.Size(251, 112)
        Me.txtListaODS.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 323)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "LISTA ALUMNOS CON MISMO TIPO"
        '
        'txtListaAlumn
        '
        Me.txtListaAlumn.Location = New System.Drawing.Point(23, 343)
        Me.txtListaAlumn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtListaAlumn.Multiline = True
        Me.txtListaAlumn.Name = "txtListaAlumn"
        Me.txtListaAlumn.Size = New System.Drawing.Size(251, 112)
        Me.txtListaAlumn.TabIndex = 35
        '
        'listbTipo
        '
        Me.listbTipo.FormattingEnabled = True
        Me.listbTipo.ItemHeight = 16
        Me.listbTipo.Location = New System.Drawing.Point(177, 89)
        Me.listbTipo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.listbTipo.Name = "listbTipo"
        Me.listbTipo.Size = New System.Drawing.Size(291, 20)
        Me.listbTipo.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "TIPO ACTIVIDAD"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(177, 32)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(292, 22)
        Me.txtNombre.TabIndex = 32
        '
        'LBL_NOMBRE_ACTIVIDAD
        '
        Me.LBL_NOMBRE_ACTIVIDAD.AutoSize = True
        Me.LBL_NOMBRE_ACTIVIDAD.Location = New System.Drawing.Point(21, 36)
        Me.LBL_NOMBRE_ACTIVIDAD.Name = "LBL_NOMBRE_ACTIVIDAD"
        Me.LBL_NOMBRE_ACTIVIDAD.Size = New System.Drawing.Size(140, 16)
        Me.LBL_NOMBRE_ACTIVIDAD.TabIndex = 31
        Me.LBL_NOMBRE_ACTIVIDAD.Text = "NOMBRE ACTIVIDAD"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(77, 66)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 16)
        Me.Label22.TabIndex = 60
        Me.Label22.Text = "CAPACIDAD"
        '
        'lblFechaIni
        '
        Me.lblFechaIni.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFechaIni.Location = New System.Drawing.Point(212, 212)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(213, 16)
        Me.lblFechaIni.TabIndex = 84
        '
        'lblCapacidad
        '
        Me.lblCapacidad.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCapacidad.Location = New System.Drawing.Point(212, 175)
        Me.lblCapacidad.Name = "lblCapacidad"
        Me.lblCapacidad.Size = New System.Drawing.Size(213, 16)
        Me.lblCapacidad.TabIndex = 82
        '
        'lblTipo
        '
        Me.lblTipo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTipo.Location = New System.Drawing.Point(212, 135)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(213, 16)
        Me.lblTipo.TabIndex = 80
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNombre.Location = New System.Drawing.Point(212, 101)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(213, 16)
        Me.lblNombre.TabIndex = 78
        '
        'txtBorrarActividad
        '
        Me.txtBorrarActividad.Location = New System.Drawing.Point(316, 559)
        Me.txtBorrarActividad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBorrarActividad.Name = "txtBorrarActividad"
        Me.txtBorrarActividad.Size = New System.Drawing.Size(228, 22)
        Me.txtBorrarActividad.TabIndex = 76
        Me.txtBorrarActividad.Text = "ESCRIBIR NOMBRE ACTIVIDAD"
        '
        'txtNombreCambiar
        '
        Me.txtNombreCambiar.Location = New System.Drawing.Point(9, 76)
        Me.txtNombreCambiar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreCambiar.Name = "txtNombreCambiar"
        Me.txtNombreCambiar.Size = New System.Drawing.Size(292, 22)
        Me.txtNombreCambiar.TabIndex = 75
        Me.txtNombreCambiar.Text = "ESCRIBIR NOMBRE ACTIVIDAD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(311, 513)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 16)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "ELIMINAR ACTIVIDAD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 16)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "MODIFICAR ACTIVIDAD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(212, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 16)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "CONSULTAR ACTIVIDAD"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(84, 215)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(93, 16)
        Me.Label31.TabIndex = 88
        Me.Label31.Text = "FECHA INICIO"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(84, 177)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(84, 16)
        Me.Label32.TabIndex = 87
        Me.Label32.Text = "CAPACIDAD"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(84, 138)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(38, 16)
        Me.Label33.TabIndex = 86
        Me.Label33.Text = "TIPO"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(84, 103)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(66, 16)
        Me.Label34.TabIndex = 85
        Me.Label34.Text = "NOMBRE"
        '
        'label24
        '
        Me.label24.AutoSize = True
        Me.label24.Location = New System.Drawing.Point(84, 250)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(76, 16)
        Me.label24.TabIndex = 90
        Me.label24.Text = "FECHA FIN"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFechaFin.Location = New System.Drawing.Point(212, 247)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(213, 16)
        Me.lblFechaFin.TabIndex = 89
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Location = New System.Drawing.Point(177, 60)
        Me.txtCapacidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(292, 22)
        Me.txtCapacidad.TabIndex = 91
        '
        'txtFechaIni
        '
        Me.txtFechaIni.Location = New System.Drawing.Point(177, 129)
        Me.txtFechaIni.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFechaIni.Name = "txtFechaIni"
        Me.txtFechaIni.Size = New System.Drawing.Size(114, 22)
        Me.txtFechaIni.TabIndex = 92
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Location = New System.Drawing.Point(443, 126)
        Me.txtFechaFin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(114, 22)
        Me.txtFechaFin.TabIndex = 93
        '
        'btnAñadirAlumn
        '
        Me.btnAñadirAlumn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAñadirAlumn.Location = New System.Drawing.Point(73, 463)
        Me.btnAñadirAlumn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAñadirAlumn.Name = "btnAñadirAlumn"
        Me.btnAñadirAlumn.Size = New System.Drawing.Size(41, 31)
        Me.btnAñadirAlumn.TabIndex = 94
        Me.btnAñadirAlumn.Text = "+"
        Me.btnAñadirAlumn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(156, 463)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 31)
        Me.Button1.TabIndex = 95
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBorrarODS
        '
        Me.btnBorrarODS.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarODS.Location = New System.Drawing.Point(443, 463)
        Me.btnBorrarODS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBorrarODS.Name = "btnBorrarODS"
        Me.btnBorrarODS.Size = New System.Drawing.Size(41, 31)
        Me.btnBorrarODS.TabIndex = 97
        Me.btnBorrarODS.Text = "-"
        Me.btnBorrarODS.UseVisualStyleBackColor = True
        '
        'btnAñadirODS
        '
        Me.btnAñadirODS.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAñadirODS.Location = New System.Drawing.Point(361, 463)
        Me.btnAñadirODS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAñadirODS.Name = "btnAñadirODS"
        Me.btnAñadirODS.Size = New System.Drawing.Size(41, 31)
        Me.btnAñadirODS.TabIndex = 96
        Me.btnAñadirODS.Text = "+"
        Me.btnAñadirODS.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 16)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "NIF ORGANIZACION"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(209, 63)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(217, 22)
        Me.TextBox1.TabIndex = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(84, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 16)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "DESCRIPCION"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDescripcion.Location = New System.Drawing.Point(212, 283)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(213, 16)
        Me.lblDescripcion.TabIndex = 101
        '
        'grpConsultarAct
        '
        Me.grpConsultarAct.Controls.Add(Me.Label5)
        Me.grpConsultarAct.Controls.Add(Me.Label8)
        Me.grpConsultarAct.Controls.Add(Me.lblNombre)
        Me.grpConsultarAct.Controls.Add(Me.lblDescripcion)
        Me.grpConsultarAct.Controls.Add(Me.lblTipo)
        Me.grpConsultarAct.Controls.Add(Me.TextBox1)
        Me.grpConsultarAct.Controls.Add(Me.lblCapacidad)
        Me.grpConsultarAct.Controls.Add(Me.Label4)
        Me.grpConsultarAct.Controls.Add(Me.lblFechaIni)
        Me.grpConsultarAct.Controls.Add(Me.Label34)
        Me.grpConsultarAct.Controls.Add(Me.Label33)
        Me.grpConsultarAct.Controls.Add(Me.Label32)
        Me.grpConsultarAct.Controls.Add(Me.Label31)
        Me.grpConsultarAct.Controls.Add(Me.lblFechaFin)
        Me.grpConsultarAct.Controls.Add(Me.label24)
        Me.grpConsultarAct.Location = New System.Drawing.Point(685, 10)
        Me.grpConsultarAct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpConsultarAct.Name = "grpConsultarAct"
        Me.grpConsultarAct.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpConsultarAct.Size = New System.Drawing.Size(457, 321)
        Me.grpConsultarAct.TabIndex = 103
        Me.grpConsultarAct.TabStop = False
        Me.grpConsultarAct.Text = "CONSULTAR ACTIVIDAD"
        '
        'grpGestionAct
        '
        Me.grpGestionAct.Controls.Add(Me.btnPonerEntidad)
        Me.grpGestionAct.Controls.Add(Me.lstDatosAnyadidos)
        Me.grpGestionAct.Controls.Add(Me.cboODS)
        Me.grpGestionAct.Controls.Add(Me.Label2)
        Me.grpGestionAct.Controls.Add(Me.LBL_NOMBRE_ACTIVIDAD)
        Me.grpGestionAct.Controls.Add(Me.txtNombre)
        Me.grpGestionAct.Controls.Add(Me.txtBorrarActividad)
        Me.grpGestionAct.Controls.Add(Me.txtListaODS)
        Me.grpGestionAct.Controls.Add(Me.btnBorrarODS)
        Me.grpGestionAct.Controls.Add(Me.Label1)
        Me.grpGestionAct.Controls.Add(Me.lblContadorAlumn)
        Me.grpGestionAct.Controls.Add(Me.btnAñadirODS)
        Me.grpGestionAct.Controls.Add(Me.listbTipo)
        Me.grpGestionAct.Controls.Add(Me.Button1)
        Me.grpGestionAct.Controls.Add(Me.txtListaAlumn)
        Me.grpGestionAct.Controls.Add(Me.btnAñadirAlumn)
        Me.grpGestionAct.Controls.Add(Me.Label3)
        Me.grpGestionAct.Controls.Add(Me.txtFechaFin)
        Me.grpGestionAct.Controls.Add(Me.txtFechaIni)
        Me.grpGestionAct.Controls.Add(Me.Label11)
        Me.grpGestionAct.Controls.Add(Me.txtCapacidad)
        Me.grpGestionAct.Controls.Add(Me.Label7)
        Me.grpGestionAct.Controls.Add(Me.Label22)
        Me.grpGestionAct.Controls.Add(Me.Label21)
        Me.grpGestionAct.Controls.Add(Me.Label20)
        Me.grpGestionAct.Controls.Add(Me.Label18)
        Me.grpGestionAct.Location = New System.Drawing.Point(41, 10)
        Me.grpGestionAct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpGestionAct.Name = "grpGestionAct"
        Me.grpGestionAct.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpGestionAct.Size = New System.Drawing.Size(604, 596)
        Me.grpGestionAct.TabIndex = 104
        Me.grpGestionAct.TabStop = False
        Me.grpGestionAct.Text = "GESTION DE ACTIVIDADES"
        '
        'btnPonerEntidad
        '
        Me.btnPonerEntidad.Location = New System.Drawing.Point(418, 274)
        Me.btnPonerEntidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPonerEntidad.Name = "btnPonerEntidad"
        Me.btnPonerEntidad.Size = New System.Drawing.Size(51, 25)
        Me.btnPonerEntidad.TabIndex = 103
        Me.btnPonerEntidad.Text = "-"
        Me.btnPonerEntidad.UseVisualStyleBackColor = True
        '
        'lstDatosAnyadidos
        '
        Me.lstDatosAnyadidos.FormattingEnabled = True
        Me.lstDatosAnyadidos.ItemHeight = 16
        Me.lstDatosAnyadidos.Location = New System.Drawing.Point(177, 199)
        Me.lstDatosAnyadidos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstDatosAnyadidos.Name = "lstDatosAnyadidos"
        Me.lstDatosAnyadidos.Size = New System.Drawing.Size(233, 100)
        Me.lstDatosAnyadidos.TabIndex = 101
        '
        'cboODS
        '
        Me.cboODS.FormattingEnabled = True
        Me.cboODS.Location = New System.Drawing.Point(177, 164)
        Me.cboODS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboODS.Name = "cboODS"
        Me.cboODS.Size = New System.Drawing.Size(291, 24)
        Me.cboODS.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "ODS"
        '
        'listbCampo
        '
        Me.listbCampo.FormattingEnabled = True
        Me.listbCampo.ItemHeight = 16
        Me.listbCampo.Location = New System.Drawing.Point(9, 111)
        Me.listbCampo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.listbCampo.Name = "listbCampo"
        Me.listbCampo.Size = New System.Drawing.Size(291, 20)
        Me.listbCampo.TabIndex = 98
        '
        'txtCambio
        '
        Me.txtCambio.Location = New System.Drawing.Point(9, 150)
        Me.txtCambio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCambio.Name = "txtCambio"
        Me.txtCambio.Size = New System.Drawing.Size(292, 22)
        Me.txtCambio.TabIndex = 105
        Me.txtCambio.Text = "ESCRIBIR NOMBRE ACTIVIDAD"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(9, 192)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(159, 31)
        Me.btnGuardar.TabIndex = 98
        Me.btnGuardar.Text = "GUARDAR CAMBIO"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'grpEdicionAct
        '
        Me.grpEdicionAct.Controls.Add(Me.btnGuardar)
        Me.grpEdicionAct.Controls.Add(Me.Label6)
        Me.grpEdicionAct.Controls.Add(Me.txtCambio)
        Me.grpEdicionAct.Controls.Add(Me.txtNombreCambiar)
        Me.grpEdicionAct.Controls.Add(Me.listbCampo)
        Me.grpEdicionAct.Location = New System.Drawing.Point(685, 353)
        Me.grpEdicionAct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpEdicionAct.Name = "grpEdicionAct"
        Me.grpEdicionAct.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpEdicionAct.Size = New System.Drawing.Size(337, 225)
        Me.grpEdicionAct.TabIndex = 106
        Me.grpEdicionAct.TabStop = False
        Me.grpEdicionAct.Text = "EDICION DE ACTIVIDADES"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1141, 633)
        Me.Controls.Add(Me.grpEdicionAct)
        Me.Controls.Add(Me.grpGestionAct)
        Me.Controls.Add(Me.grpConsultarAct)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmPrincipal"
        Me.Text = "Gestión Voluntariado"
        Me.grpConsultarAct.ResumeLayout(False)
        Me.grpConsultarAct.PerformLayout()
        Me.grpGestionAct.ResumeLayout(False)
        Me.grpGestionAct.PerformLayout()
        Me.grpEdicionAct.ResumeLayout(False)
        Me.grpEdicionAct.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblContadorAlumn As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtListaODS As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtListaAlumn As TextBox
    Friend WithEvents listbTipo As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents LBL_NOMBRE_ACTIVIDAD As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblFechaIni As Label
    Friend WithEvents lblCapacidad As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtBorrarActividad As TextBox
    Friend WithEvents txtNombreCambiar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents label24 As Label
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents txtCapacidad As TextBox
    Friend WithEvents txtFechaIni As TextBox
    Friend WithEvents txtFechaFin As TextBox
    Friend WithEvents btnAñadirAlumn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBorrarODS As Button
    Friend WithEvents btnAñadirODS As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents grpConsultarAct As GroupBox
    Friend WithEvents grpGestionAct As GroupBox
    Friend WithEvents listbCampo As ListBox
    Friend WithEvents txtCambio As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents grpEdicionAct As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstDatosAnyadidos As ListBox
    Friend WithEvents cboODS As ComboBox
    Friend WithEvents btnPonerEntidad As Button
End Class
