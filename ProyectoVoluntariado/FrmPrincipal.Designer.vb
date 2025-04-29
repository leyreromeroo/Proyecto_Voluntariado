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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.LBL_NOMBRE_ACTIVIDAD = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblFechaIni = New System.Windows.Forms.Label()
        Me.lblCapacidad = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.label24 = New System.Windows.Forms.Label()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.grpConsultarAct = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grpGestionAct = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.cboOrganizaciones = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnCrearActividad = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lstbAlumnAnadidos = New System.Windows.Forms.ListBox()
        Me.lstbAlumn = New System.Windows.Forms.ListBox()
        Me.btnAnadirODS = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAnadirAlumnos = New System.Windows.Forms.Button()
        Me.btnEliminarAlumnos = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnEliminarODS = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboTipoActividad = New System.Windows.Forms.ComboBox()
        Me.lstOdsAnyadidos = New System.Windows.Forms.ListBox()
        Me.cboODS = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.grpEdicionAct = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtbEstado = New System.Windows.Forms.TextBox()
        Me.cmbActividades = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbNombreActividadEliminar = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.btnEliminarActividad = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grpConsultarAct.SuspendLayout()
        Me.grpGestionAct.SuspendLayout()
        Me.grpEdicionAct.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(260, 72)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 13)
        Me.Label21.TabIndex = 59
        Me.Label21.Text = "FECHA FIN"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(23, 72)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 13)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "FECHA INICIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 240)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "ALUMNOS CON MISMO TIPO DE ACTIVIDAD"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(133, 19)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(340, 20)
        Me.txtNombre.TabIndex = 32
        '
        'LBL_NOMBRE_ACTIVIDAD
        '
        Me.LBL_NOMBRE_ACTIVIDAD.AutoSize = True
        Me.LBL_NOMBRE_ACTIVIDAD.Location = New System.Drawing.Point(16, 22)
        Me.LBL_NOMBRE_ACTIVIDAD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_NOMBRE_ACTIVIDAD.Name = "LBL_NOMBRE_ACTIVIDAD"
        Me.LBL_NOMBRE_ACTIVIDAD.Size = New System.Drawing.Size(114, 13)
        Me.LBL_NOMBRE_ACTIVIDAD.TabIndex = 31
        Me.LBL_NOMBRE_ACTIVIDAD.Text = "NOMBRE ACTIVIDAD"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(58, 46)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 13)
        Me.Label22.TabIndex = 60
        Me.Label22.Text = "CAPACIDAD"
        '
        'lblFechaIni
        '
        Me.lblFechaIni.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFechaIni.Enabled = False
        Me.lblFechaIni.Location = New System.Drawing.Point(159, 172)
        Me.lblFechaIni.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(80, 15)
        Me.lblFechaIni.TabIndex = 84
        '
        'lblCapacidad
        '
        Me.lblCapacidad.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCapacidad.Enabled = False
        Me.lblCapacidad.Location = New System.Drawing.Point(159, 142)
        Me.lblCapacidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCapacidad.Name = "lblCapacidad"
        Me.lblCapacidad.Size = New System.Drawing.Size(245, 13)
        Me.lblCapacidad.TabIndex = 82
        '
        'lblTipo
        '
        Me.lblTipo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTipo.Enabled = False
        Me.lblTipo.Location = New System.Drawing.Point(159, 110)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(245, 13)
        Me.lblTipo.TabIndex = 80
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNombre.Enabled = False
        Me.lblNombre.Location = New System.Drawing.Point(159, 82)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(245, 13)
        Me.lblNombre.TabIndex = 78
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 27)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "NOMBRE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(159, 26)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "CONSULTAR ACTIVIDAD"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(63, 175)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(77, 13)
        Me.Label31.TabIndex = 88
        Me.Label31.Text = "FECHA INICIO"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(63, 144)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(68, 13)
        Me.Label32.TabIndex = 87
        Me.Label32.Text = "CAPACIDAD"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(63, 112)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(32, 13)
        Me.Label33.TabIndex = 86
        Me.Label33.Text = "TIPO"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(63, 84)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(54, 13)
        Me.Label34.TabIndex = 85
        Me.Label34.Text = "NOMBRE"
        '
        'label24
        '
        Me.label24.AutoSize = True
        Me.label24.Location = New System.Drawing.Point(252, 175)
        Me.label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(62, 13)
        Me.label24.TabIndex = 90
        Me.label24.Text = "FECHA FIN"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFechaFin.Enabled = False
        Me.lblFechaFin.Location = New System.Drawing.Point(324, 172)
        Me.lblFechaFin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(80, 15)
        Me.lblFechaFin.TabIndex = 89
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Location = New System.Drawing.Point(133, 41)
        Me.txtCapacidad.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(72, 20)
        Me.txtCapacidad.TabIndex = 91
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "NIF ORGANIZACION"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(157, 51)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(248, 20)
        Me.TextBox1.TabIndex = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(63, 201)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "DESCRIPCION"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDescripcion.Enabled = False
        Me.lblDescripcion.Location = New System.Drawing.Point(159, 201)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(245, 42)
        Me.lblDescripcion.TabIndex = 101
        '
        'grpConsultarAct
        '
        Me.grpConsultarAct.Controls.Add(Me.Label10)
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
        Me.grpConsultarAct.Location = New System.Drawing.Point(535, 16)
        Me.grpConsultarAct.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpConsultarAct.Name = "grpConsultarAct"
        Me.grpConsultarAct.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpConsultarAct.Size = New System.Drawing.Size(414, 258)
        Me.grpConsultarAct.TabIndex = 103
        Me.grpConsultarAct.TabStop = False
        Me.grpConsultarAct.Text = "CONSULTAR ACTIVIDAD"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(-223, 136)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "TIPO ACTIVIDAD"
        '
        'grpGestionAct
        '
        Me.grpGestionAct.Controls.Add(Me.dtpFechaFin)
        Me.grpGestionAct.Controls.Add(Me.dtpFechaInicio)
        Me.grpGestionAct.Controls.Add(Me.cboOrganizaciones)
        Me.grpGestionAct.Controls.Add(Me.Label16)
        Me.grpGestionAct.Controls.Add(Me.btnCrearActividad)
        Me.grpGestionAct.Controls.Add(Me.Label15)
        Me.grpGestionAct.Controls.Add(Me.Label14)
        Me.grpGestionAct.Controls.Add(Me.lstbAlumnAnadidos)
        Me.grpGestionAct.Controls.Add(Me.lstbAlumn)
        Me.grpGestionAct.Controls.Add(Me.btnAnadirODS)
        Me.grpGestionAct.Controls.Add(Me.Label7)
        Me.grpGestionAct.Controls.Add(Me.btnAnadirAlumnos)
        Me.grpGestionAct.Controls.Add(Me.btnEliminarAlumnos)
        Me.grpGestionAct.Controls.Add(Me.txtDescripcion)
        Me.grpGestionAct.Controls.Add(Me.btnEliminarODS)
        Me.grpGestionAct.Controls.Add(Me.Label11)
        Me.grpGestionAct.Controls.Add(Me.cboTipoActividad)
        Me.grpGestionAct.Controls.Add(Me.lstOdsAnyadidos)
        Me.grpGestionAct.Controls.Add(Me.cboODS)
        Me.grpGestionAct.Controls.Add(Me.Label2)
        Me.grpGestionAct.Controls.Add(Me.LBL_NOMBRE_ACTIVIDAD)
        Me.grpGestionAct.Controls.Add(Me.txtNombre)
        Me.grpGestionAct.Controls.Add(Me.Label3)
        Me.grpGestionAct.Controls.Add(Me.txtCapacidad)
        Me.grpGestionAct.Controls.Add(Me.Label22)
        Me.grpGestionAct.Controls.Add(Me.Label21)
        Me.grpGestionAct.Controls.Add(Me.Label20)
        Me.grpGestionAct.Location = New System.Drawing.Point(31, 8)
        Me.grpGestionAct.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpGestionAct.Name = "grpGestionAct"
        Me.grpGestionAct.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpGestionAct.Size = New System.Drawing.Size(490, 550)
        Me.grpGestionAct.TabIndex = 104
        Me.grpGestionAct.TabStop = False
        Me.grpGestionAct.Text = "GESTION DE ACTIVIDADES"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Location = New System.Drawing.Point(340, 68)
        Me.dtpFechaFin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(132, 20)
        Me.dtpFechaFin.TabIndex = 128
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Location = New System.Drawing.Point(98, 68)
        Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(142, 20)
        Me.dtpFechaInicio.TabIndex = 127
        '
        'cboOrganizaciones
        '
        Me.cboOrganizaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrganizaciones.FormattingEnabled = True
        Me.cboOrganizaciones.Location = New System.Drawing.Point(340, 41)
        Me.cboOrganizaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboOrganizaciones.Name = "cboOrganizaciones"
        Me.cboOrganizaciones.Size = New System.Drawing.Size(133, 21)
        Me.cboOrganizaciones.TabIndex = 125
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(223, 46)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 13)
        Me.Label16.TabIndex = 124
        Me.Label16.Text = "ORGANIZACIONES"
        '
        'btnCrearActividad
        '
        Me.btnCrearActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearActividad.Location = New System.Drawing.Point(171, 508)
        Me.btnCrearActividad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCrearActividad.Name = "btnCrearActividad"
        Me.btnCrearActividad.Size = New System.Drawing.Size(85, 27)
        Me.btnCrearActividad.TabIndex = 123
        Me.btnCrearActividad.Text = "CREAR ACTIVIDAD"
        Me.btnCrearActividad.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(270, 240)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 13)
        Me.Label15.TabIndex = 122
        Me.Label15.Text = "ALUMNOS AÑADIDOS"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(230, 301)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 38)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "=>"
        '
        'lstbAlumnAnadidos
        '
        Me.lstbAlumnAnadidos.FormattingEnabled = True
        Me.lstbAlumnAnadidos.Location = New System.Drawing.Point(272, 267)
        Me.lstbAlumnAnadidos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstbAlumnAnadidos.Name = "lstbAlumnAnadidos"
        Me.lstbAlumnAnadidos.Size = New System.Drawing.Size(200, 95)
        Me.lstbAlumnAnadidos.TabIndex = 120
        '
        'lstbAlumn
        '
        Me.lstbAlumn.FormattingEnabled = True
        Me.lstbAlumn.Location = New System.Drawing.Point(26, 267)
        Me.lstbAlumn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstbAlumn.Name = "lstbAlumn"
        Me.lstbAlumn.Size = New System.Drawing.Size(203, 95)
        Me.lstbAlumn.TabIndex = 119
        '
        'btnAnadirODS
        '
        Me.btnAnadirODS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadirODS.Location = New System.Drawing.Point(44, 198)
        Me.btnAnadirODS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAnadirODS.Name = "btnAnadirODS"
        Me.btnAnadirODS.Size = New System.Drawing.Size(85, 27)
        Me.btnAnadirODS.TabIndex = 117
        Me.btnAnadirODS.Text = "AÑADIR"
        Me.btnAnadirODS.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 395)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "DESCRIPCIÓN"
        '
        'btnAnadirAlumnos
        '
        Me.btnAnadirAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadirAlumnos.Location = New System.Drawing.Point(79, 365)
        Me.btnAnadirAlumnos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAnadirAlumnos.Name = "btnAnadirAlumnos"
        Me.btnAnadirAlumnos.Size = New System.Drawing.Size(85, 27)
        Me.btnAnadirAlumnos.TabIndex = 114
        Me.btnAnadirAlumnos.Text = "AÑADIR"
        Me.btnAnadirAlumnos.UseVisualStyleBackColor = True
        '
        'btnEliminarAlumnos
        '
        Me.btnEliminarAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarAlumnos.Location = New System.Drawing.Point(322, 365)
        Me.btnEliminarAlumnos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEliminarAlumnos.Name = "btnEliminarAlumnos"
        Me.btnEliminarAlumnos.Size = New System.Drawing.Size(85, 27)
        Me.btnEliminarAlumnos.TabIndex = 113
        Me.btnEliminarAlumnos.Text = "ELIMINAR"
        Me.btnEliminarAlumnos.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(26, 418)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(447, 76)
        Me.txtDescripcion.TabIndex = 112
        '
        'btnEliminarODS
        '
        Me.btnEliminarODS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarODS.Location = New System.Drawing.Point(133, 198)
        Me.btnEliminarODS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEliminarODS.Name = "btnEliminarODS"
        Me.btnEliminarODS.Size = New System.Drawing.Size(85, 27)
        Me.btnEliminarODS.TabIndex = 110
        Me.btnEliminarODS.Text = "ELIMINAR"
        Me.btnEliminarODS.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(307, 94)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "TIPO ACTIVIDAD"
        '
        'cboTipoActividad
        '
        Me.cboTipoActividad.FormattingEnabled = True
        Me.cboTipoActividad.Location = New System.Drawing.Point(284, 113)
        Me.cboTipoActividad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTipoActividad.Name = "cboTipoActividad"
        Me.cboTipoActividad.Size = New System.Drawing.Size(188, 21)
        Me.cboTipoActividad.TabIndex = 104
        '
        'lstOdsAnyadidos
        '
        Me.lstOdsAnyadidos.FormattingEnabled = True
        Me.lstOdsAnyadidos.Location = New System.Drawing.Point(18, 138)
        Me.lstOdsAnyadidos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstOdsAnyadidos.Name = "lstOdsAnyadidos"
        Me.lstOdsAnyadidos.Size = New System.Drawing.Size(239, 56)
        Me.lstOdsAnyadidos.TabIndex = 101
        '
        'cboODS
        '
        Me.cboODS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboODS.FormattingEnabled = True
        Me.cboODS.Location = New System.Drawing.Point(18, 113)
        Me.cboODS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboODS.Name = "cboODS"
        Me.cboODS.Size = New System.Drawing.Size(239, 21)
        Me.cboODS.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "ODS"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(54, 115)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(119, 25)
        Me.btnGuardar.TabIndex = 98
        Me.btnGuardar.Text = "GUARDAR CAMBIO"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'grpEdicionAct
        '
        Me.grpEdicionAct.Controls.Add(Me.Button1)
        Me.grpEdicionAct.Controls.Add(Me.txtbEstado)
        Me.grpEdicionAct.Controls.Add(Me.cmbActividades)
        Me.grpEdicionAct.Controls.Add(Me.GroupBox1)
        Me.grpEdicionAct.Controls.Add(Me.btnGuardar)
        Me.grpEdicionAct.Controls.Add(Me.Label6)
        Me.grpEdicionAct.Location = New System.Drawing.Point(535, 310)
        Me.grpEdicionAct.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpEdicionAct.Name = "grpEdicionAct"
        Me.grpEdicionAct.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpEdicionAct.Size = New System.Drawing.Size(203, 183)
        Me.grpEdicionAct.TabIndex = 106
        Me.grpEdicionAct.TabStop = False
        Me.grpEdicionAct.Text = "EDICION DE ACTIVIDADES"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(73, 72)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 20)
        Me.Button1.TabIndex = 126
        Me.Button1.Text = "CAMBIAR ESTADO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtbEstado
        '
        Me.txtbEstado.Location = New System.Drawing.Point(7, 72)
        Me.txtbEstado.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtbEstado.Name = "txtbEstado"
        Me.txtbEstado.ReadOnly = True
        Me.txtbEstado.Size = New System.Drawing.Size(63, 20)
        Me.txtbEstado.TabIndex = 124
        '
        'cmbActividades
        '
        Me.cmbActividades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActividades.FormattingEnabled = True
        Me.cmbActividades.Location = New System.Drawing.Point(7, 48)
        Me.cmbActividades.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbActividades.Name = "cmbActividades"
        Me.cmbActividades.Size = New System.Drawing.Size(179, 21)
        Me.cmbActividades.TabIndex = 125
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(242, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(253, 183)
        Me.GroupBox1.TabIndex = 107
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EDICION DE ACTIVIDADES"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(7, 156)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 25)
        Me.Button2.TabIndex = 98
        Me.Button2.Text = "GUARDAR CAMBIO"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 29)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 13)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "MODIFICAR ACTIVIDAD"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(7, 122)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(220, 20)
        Me.TextBox2.TabIndex = 105
        Me.TextBox2.Text = "ESCRIBIR NOMBRE ACTIVIDAD"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(7, 62)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(220, 20)
        Me.TextBox3.TabIndex = 75
        Me.TextBox3.Text = "ESCRIBIR NOMBRE ACTIVIDAD"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(7, 90)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(219, 17)
        Me.ListBox1.TabIndex = 98
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbNombreActividadEliminar)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.btnEliminarActividad)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(752, 310)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(197, 183)
        Me.GroupBox2.TabIndex = 108
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ELIMINAR ACTIVIDADES"
        '
        'cmbNombreActividadEliminar
        '
        Me.cmbNombreActividadEliminar.FormattingEnabled = True
        Me.cmbNombreActividadEliminar.Location = New System.Drawing.Point(10, 48)
        Me.cmbNombreActividadEliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbNombreActividadEliminar.Name = "cmbNombreActividadEliminar"
        Me.cmbNombreActividadEliminar.Size = New System.Drawing.Size(179, 21)
        Me.cmbNombreActividadEliminar.TabIndex = 126
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 29)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 108
        Me.Label13.Text = "NOMBRE"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.ListBox3)
        Me.GroupBox3.Location = New System.Drawing.Point(242, 11)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(253, 183)
        Me.GroupBox3.TabIndex = 107
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "EDICION DE ACTIVIDADES"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(7, 156)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(119, 25)
        Me.Button4.TabIndex = 98
        Me.Button4.Text = "GUARDAR CAMBIO"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "MODIFICAR ACTIVIDAD"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(7, 122)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(220, 20)
        Me.TextBox4.TabIndex = 105
        Me.TextBox4.Text = "ESCRIBIR NOMBRE ACTIVIDAD"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(7, 62)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(220, 20)
        Me.TextBox5.TabIndex = 75
        Me.TextBox5.Text = "ESCRIBIR NOMBRE ACTIVIDAD"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(7, 90)
        Me.ListBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(219, 17)
        Me.ListBox3.TabIndex = 98
        '
        'btnEliminarActividad
        '
        Me.btnEliminarActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarActividad.Location = New System.Drawing.Point(50, 114)
        Me.btnEliminarActividad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEliminarActividad.Name = "btnEliminarActividad"
        Me.btnEliminarActividad.Size = New System.Drawing.Size(119, 25)
        Me.btnEliminarActividad.TabIndex = 98
        Me.btnEliminarActividad.Text = "ELIMINAR"
        Me.btnEliminarActividad.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 29)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 73
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(958, 567)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpEdicionAct)
        Me.Controls.Add(Me.grpConsultarAct)
        Me.Controls.Add(Me.grpGestionAct)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FrmPrincipal"
        Me.Text = "Gestión Voluntariado"
        Me.grpConsultarAct.ResumeLayout(False)
        Me.grpConsultarAct.PerformLayout()
        Me.grpGestionAct.ResumeLayout(False)
        Me.grpGestionAct.PerformLayout()
        Me.grpEdicionAct.ResumeLayout(False)
        Me.grpEdicionAct.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents LBL_NOMBRE_ACTIVIDAD As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblFechaIni As Label
    Friend WithEvents lblCapacidad As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents label24 As Label
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents txtCapacidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents grpConsultarAct As GroupBox
    Friend WithEvents grpGestionAct As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents grpEdicionAct As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstOdsAnyadidos As ListBox
    Friend WithEvents cboODS As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboTipoActividad As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnEliminarODS As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents btnEliminarActividad As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnAnadirAlumnos As Button
    Friend WithEvents btnEliminarAlumnos As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAnadirODS As Button
    Friend WithEvents lstbAlumnAnadidos As ListBox
    Friend WithEvents lstbAlumn As ListBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnCrearActividad As Button
    Friend WithEvents cmbActividades As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtbEstado As TextBox
    Friend WithEvents cboOrganizaciones As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbNombreActividadEliminar As ComboBox
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents dtpFechaInicio As DateTimePicker
End Class
