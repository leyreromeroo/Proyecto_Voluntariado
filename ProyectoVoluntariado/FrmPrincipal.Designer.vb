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
        Me.txtFechaIni = New System.Windows.Forms.TextBox()
        Me.txtFechaFin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.grpConsultarAct = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grpGestionAct = New System.Windows.Forms.GroupBox()
        Me.btnCrearActividad = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lstbAlumnAnadidos = New System.Windows.Forms.ListBox()
        Me.lstbAlumn = New System.Windows.Forms.ListBox()
        Me.btnAnadirODS = New System.Windows.Forms.Button()
        Me.btnAñadirTipoAc = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAnadirAlumnos = New System.Windows.Forms.Button()
        Me.btnEliminarAlumnos = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.btnEliminarTipoAc = New System.Windows.Forms.Button()
        Me.btnEliminarODS = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lstTipoActividad = New System.Windows.Forms.ListBox()
        Me.cboTipoActividad = New System.Windows.Forms.ComboBox()
        Me.lstDatosAnyadidos = New System.Windows.Forms.ListBox()
        Me.cboODS = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.grpEdicionAct = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.txtbEstado = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.Label21.Location = New System.Drawing.Point(297, 89)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 16)
        Me.Label21.TabIndex = 59
        Me.Label21.Text = "FECHA FIN"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(77, 89)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(93, 16)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "FECHA INICIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(282, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "ALUMNOS CON MISMO TIPO DE ACTIVIDAD"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(177, 23)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(292, 22)
        Me.txtNombre.TabIndex = 32
        '
        'LBL_NOMBRE_ACTIVIDAD
        '
        Me.LBL_NOMBRE_ACTIVIDAD.AutoSize = True
        Me.LBL_NOMBRE_ACTIVIDAD.Location = New System.Drawing.Point(21, 27)
        Me.LBL_NOMBRE_ACTIVIDAD.Name = "LBL_NOMBRE_ACTIVIDAD"
        Me.LBL_NOMBRE_ACTIVIDAD.Size = New System.Drawing.Size(140, 16)
        Me.LBL_NOMBRE_ACTIVIDAD.TabIndex = 31
        Me.LBL_NOMBRE_ACTIVIDAD.Text = "NOMBRE ACTIVIDAD"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(77, 57)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 16)
        Me.Label22.TabIndex = 60
        Me.Label22.Text = "CAPACIDAD"
        '
        'lblFechaIni
        '
        Me.lblFechaIni.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFechaIni.Enabled = False
        Me.lblFechaIni.Location = New System.Drawing.Point(212, 212)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(107, 19)
        Me.lblFechaIni.TabIndex = 84
        '
        'lblCapacidad
        '
        Me.lblCapacidad.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCapacidad.Enabled = False
        Me.lblCapacidad.Location = New System.Drawing.Point(212, 175)
        Me.lblCapacidad.Name = "lblCapacidad"
        Me.lblCapacidad.Size = New System.Drawing.Size(327, 16)
        Me.lblCapacidad.TabIndex = 82
        '
        'lblTipo
        '
        Me.lblTipo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTipo.Enabled = False
        Me.lblTipo.Location = New System.Drawing.Point(212, 135)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(327, 16)
        Me.lblTipo.TabIndex = 80
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNombre.Enabled = False
        Me.lblNombre.Location = New System.Drawing.Point(212, 101)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(327, 16)
        Me.lblNombre.TabIndex = 78
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "NOMBRE"
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
        Me.label24.Location = New System.Drawing.Point(336, 215)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(76, 16)
        Me.label24.TabIndex = 90
        Me.label24.Text = "FECHA FIN"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFechaFin.Enabled = False
        Me.lblFechaFin.Location = New System.Drawing.Point(432, 212)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(107, 19)
        Me.lblFechaFin.TabIndex = 89
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Location = New System.Drawing.Point(177, 51)
        Me.txtCapacidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(292, 22)
        Me.txtCapacidad.TabIndex = 91
        '
        'txtFechaIni
        '
        Me.txtFechaIni.Location = New System.Drawing.Point(177, 86)
        Me.txtFechaIni.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFechaIni.Name = "txtFechaIni"
        Me.txtFechaIni.Size = New System.Drawing.Size(95, 22)
        Me.txtFechaIni.TabIndex = 92
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Location = New System.Drawing.Point(379, 86)
        Me.txtFechaFin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(90, 22)
        Me.txtFechaFin.TabIndex = 93
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
        Me.TextBox1.Size = New System.Drawing.Size(330, 22)
        Me.TextBox1.TabIndex = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(84, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 16)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "DESCRIPCION"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDescripcion.Enabled = False
        Me.lblDescripcion.Location = New System.Drawing.Point(212, 247)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(327, 52)
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
        Me.grpConsultarAct.Location = New System.Drawing.Point(662, 20)
        Me.grpConsultarAct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpConsultarAct.Name = "grpConsultarAct"
        Me.grpConsultarAct.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpConsultarAct.Size = New System.Drawing.Size(603, 318)
        Me.grpConsultarAct.TabIndex = 103
        Me.grpConsultarAct.TabStop = False
        Me.grpConsultarAct.Text = "CONSULTAR ACTIVIDAD"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(-297, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 16)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "TIPO ACTIVIDAD"
        '
        'grpGestionAct
        '
        Me.grpGestionAct.Controls.Add(Me.btnCrearActividad)
        Me.grpGestionAct.Controls.Add(Me.Label15)
        Me.grpGestionAct.Controls.Add(Me.Label14)
        Me.grpGestionAct.Controls.Add(Me.lstbAlumnAnadidos)
        Me.grpGestionAct.Controls.Add(Me.lstbAlumn)
        Me.grpGestionAct.Controls.Add(Me.btnAnadirODS)
        Me.grpGestionAct.Controls.Add(Me.btnAñadirTipoAc)
        Me.grpGestionAct.Controls.Add(Me.Label7)
        Me.grpGestionAct.Controls.Add(Me.btnAnadirAlumnos)
        Me.grpGestionAct.Controls.Add(Me.btnEliminarAlumnos)
        Me.grpGestionAct.Controls.Add(Me.TextBox8)
        Me.grpGestionAct.Controls.Add(Me.btnEliminarTipoAc)
        Me.grpGestionAct.Controls.Add(Me.btnEliminarODS)
        Me.grpGestionAct.Controls.Add(Me.Label11)
        Me.grpGestionAct.Controls.Add(Me.lstTipoActividad)
        Me.grpGestionAct.Controls.Add(Me.cboTipoActividad)
        Me.grpGestionAct.Controls.Add(Me.lstDatosAnyadidos)
        Me.grpGestionAct.Controls.Add(Me.cboODS)
        Me.grpGestionAct.Controls.Add(Me.Label2)
        Me.grpGestionAct.Controls.Add(Me.LBL_NOMBRE_ACTIVIDAD)
        Me.grpGestionAct.Controls.Add(Me.txtNombre)
        Me.grpGestionAct.Controls.Add(Me.Label3)
        Me.grpGestionAct.Controls.Add(Me.txtFechaFin)
        Me.grpGestionAct.Controls.Add(Me.txtFechaIni)
        Me.grpGestionAct.Controls.Add(Me.txtCapacidad)
        Me.grpGestionAct.Controls.Add(Me.Label22)
        Me.grpGestionAct.Controls.Add(Me.Label21)
        Me.grpGestionAct.Controls.Add(Me.Label20)
        Me.grpGestionAct.Location = New System.Drawing.Point(41, 10)
        Me.grpGestionAct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpGestionAct.Name = "grpGestionAct"
        Me.grpGestionAct.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpGestionAct.Size = New System.Drawing.Size(604, 677)
        Me.grpGestionAct.TabIndex = 104
        Me.grpGestionAct.TabStop = False
        Me.grpGestionAct.Text = "GESTION DE ACTIVIDADES"
        '
        'btnCrearActividad
        '
        Me.btnCrearActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearActividad.Location = New System.Drawing.Point(228, 625)
        Me.btnCrearActividad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCrearActividad.Name = "btnCrearActividad"
        Me.btnCrearActividad.Size = New System.Drawing.Size(113, 33)
        Me.btnCrearActividad.TabIndex = 123
        Me.btnCrearActividad.Text = "CREAR ACTIVIDAD"
        Me.btnCrearActividad.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(360, 295)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(146, 16)
        Me.Label15.TabIndex = 122
        Me.Label15.Text = "ALUMNOS AÑADIDOS"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(282, 384)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 16)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "=>"
        '
        'lstbAlumnAnadidos
        '
        Me.lstbAlumnAnadidos.FormattingEnabled = True
        Me.lstbAlumnAnadidos.ItemHeight = 16
        Me.lstbAlumnAnadidos.Location = New System.Drawing.Point(317, 329)
        Me.lstbAlumnAnadidos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstbAlumnAnadidos.Name = "lstbAlumnAnadidos"
        Me.lstbAlumnAnadidos.Size = New System.Drawing.Size(238, 116)
        Me.lstbAlumnAnadidos.TabIndex = 120
        '
        'lstbAlumn
        '
        Me.lstbAlumn.FormattingEnabled = True
        Me.lstbAlumn.ItemHeight = 16
        Me.lstbAlumn.Location = New System.Drawing.Point(34, 329)
        Me.lstbAlumn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstbAlumn.Name = "lstbAlumn"
        Me.lstbAlumn.Size = New System.Drawing.Size(238, 116)
        Me.lstbAlumn.TabIndex = 119
        '
        'btnAnadirODS
        '
        Me.btnAnadirODS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadirODS.Location = New System.Drawing.Point(58, 244)
        Me.btnAnadirODS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAnadirODS.Name = "btnAnadirODS"
        Me.btnAnadirODS.Size = New System.Drawing.Size(113, 33)
        Me.btnAnadirODS.TabIndex = 117
        Me.btnAnadirODS.Text = "AÑADIR"
        Me.btnAnadirODS.UseVisualStyleBackColor = True
        '
        'btnAñadirTipoAc
        '
        Me.btnAñadirTipoAc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAñadirTipoAc.Location = New System.Drawing.Point(379, 246)
        Me.btnAñadirTipoAc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAñadirTipoAc.Name = "btnAñadirTipoAc"
        Me.btnAñadirTipoAc.Size = New System.Drawing.Size(80, 31)
        Me.btnAñadirTipoAc.TabIndex = 116
        Me.btnAñadirTipoAc.Text = "AÑADIR"
        Me.btnAñadirTipoAc.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 486)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 16)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "DESCRIPCIÓN"
        '
        'btnAnadirAlumnos
        '
        Me.btnAnadirAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadirAlumnos.Location = New System.Drawing.Point(94, 449)
        Me.btnAnadirAlumnos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAnadirAlumnos.Name = "btnAnadirAlumnos"
        Me.btnAnadirAlumnos.Size = New System.Drawing.Size(113, 33)
        Me.btnAnadirAlumnos.TabIndex = 114
        Me.btnAnadirAlumnos.Text = "AÑADIR"
        Me.btnAnadirAlumnos.UseVisualStyleBackColor = True
        '
        'btnEliminarAlumnos
        '
        Me.btnEliminarAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarAlumnos.Location = New System.Drawing.Point(379, 449)
        Me.btnEliminarAlumnos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminarAlumnos.Name = "btnEliminarAlumnos"
        Me.btnEliminarAlumnos.Size = New System.Drawing.Size(113, 33)
        Me.btnEliminarAlumnos.TabIndex = 113
        Me.btnEliminarAlumnos.Text = "ELIMINAR"
        Me.btnEliminarAlumnos.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(34, 515)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(534, 92)
        Me.TextBox8.TabIndex = 112
        '
        'btnEliminarTipoAc
        '
        Me.btnEliminarTipoAc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarTipoAc.Location = New System.Drawing.Point(470, 246)
        Me.btnEliminarTipoAc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminarTipoAc.Name = "btnEliminarTipoAc"
        Me.btnEliminarTipoAc.Size = New System.Drawing.Size(85, 31)
        Me.btnEliminarTipoAc.TabIndex = 111
        Me.btnEliminarTipoAc.Text = "ELIMINAR"
        Me.btnEliminarTipoAc.UseVisualStyleBackColor = True
        '
        'btnEliminarODS
        '
        Me.btnEliminarODS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarODS.Location = New System.Drawing.Point(177, 244)
        Me.btnEliminarODS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminarODS.Name = "btnEliminarODS"
        Me.btnEliminarODS.Size = New System.Drawing.Size(113, 33)
        Me.btnEliminarODS.TabIndex = 110
        Me.btnEliminarODS.Text = "ELIMINAR"
        Me.btnEliminarODS.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(409, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 16)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "TIPO ACTIVIDAD"
        '
        'lstTipoActividad
        '
        Me.lstTipoActividad.FormattingEnabled = True
        Me.lstTipoActividad.ItemHeight = 16
        Me.lstTipoActividad.Location = New System.Drawing.Point(379, 172)
        Me.lstTipoActividad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstTipoActividad.Name = "lstTipoActividad"
        Me.lstTipoActividad.Size = New System.Drawing.Size(176, 68)
        Me.lstTipoActividad.TabIndex = 105
        '
        'cboTipoActividad
        '
        Me.cboTipoActividad.FormattingEnabled = True
        Me.cboTipoActividad.Location = New System.Drawing.Point(379, 139)
        Me.cboTipoActividad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboTipoActividad.Name = "cboTipoActividad"
        Me.cboTipoActividad.Size = New System.Drawing.Size(176, 24)
        Me.cboTipoActividad.TabIndex = 104
        '
        'lstDatosAnyadidos
        '
        Me.lstDatosAnyadidos.FormattingEnabled = True
        Me.lstDatosAnyadidos.ItemHeight = 16
        Me.lstDatosAnyadidos.Location = New System.Drawing.Point(24, 170)
        Me.lstDatosAnyadidos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstDatosAnyadidos.Name = "lstDatosAnyadidos"
        Me.lstDatosAnyadidos.Size = New System.Drawing.Size(329, 68)
        Me.lstDatosAnyadidos.TabIndex = 101
        '
        'cboODS
        '
        Me.cboODS.FormattingEnabled = True
        Me.cboODS.Location = New System.Drawing.Point(24, 139)
        Me.cboODS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboODS.Name = "cboODS"
        Me.cboODS.Size = New System.Drawing.Size(329, 24)
        Me.cboODS.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "ODS"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(72, 141)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(159, 31)
        Me.btnGuardar.TabIndex = 98
        Me.btnGuardar.Text = "GUARDAR CAMBIO"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'grpEdicionAct
        '
        Me.grpEdicionAct.Controls.Add(Me.Button1)
        Me.grpEdicionAct.Controls.Add(Me.txtbEstado)
        Me.grpEdicionAct.Controls.Add(Me.ComboBox2)
        Me.grpEdicionAct.Controls.Add(Me.GroupBox1)
        Me.grpEdicionAct.Controls.Add(Me.btnGuardar)
        Me.grpEdicionAct.Controls.Add(Me.Label6)
        Me.grpEdicionAct.Location = New System.Drawing.Point(662, 381)
        Me.grpEdicionAct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpEdicionAct.Name = "grpEdicionAct"
        Me.grpEdicionAct.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpEdicionAct.Size = New System.Drawing.Size(308, 225)
        Me.grpEdicionAct.TabIndex = 106
        Me.grpEdicionAct.TabStop = False
        Me.grpEdicionAct.Text = "EDICION DE ACTIVIDADES"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(323, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(337, 225)
        Me.GroupBox1.TabIndex = 107
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EDICION DE ACTIVIDADES"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(9, 192)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 31)
        Me.Button2.TabIndex = 98
        Me.Button2.Text = "GUARDAR CAMBIO"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 16)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "MODIFICAR ACTIVIDAD"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(9, 150)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(292, 22)
        Me.TextBox2.TabIndex = 105
        Me.TextBox2.Text = "ESCRIBIR NOMBRE ACTIVIDAD"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(9, 76)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(292, 22)
        Me.TextBox3.TabIndex = 75
        Me.TextBox3.Text = "ESCRIBIR NOMBRE ACTIVIDAD"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(9, 111)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(291, 20)
        Me.ListBox1.TabIndex = 98
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Location = New System.Drawing.Point(976, 381)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(291, 225)
        Me.GroupBox2.TabIndex = 108
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ELIMINAR ACTIVIDADES"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 16)
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
        Me.GroupBox3.Location = New System.Drawing.Point(323, 13)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(337, 225)
        Me.GroupBox3.TabIndex = 107
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "EDICION DE ACTIVIDADES"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(9, 192)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(159, 31)
        Me.Button4.TabIndex = 98
        Me.Button4.Text = "GUARDAR CAMBIO"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 16)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "MODIFICAR ACTIVIDAD"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(9, 150)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(292, 22)
        Me.TextBox4.TabIndex = 105
        Me.TextBox4.Text = "ESCRIBIR NOMBRE ACTIVIDAD"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(9, 76)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(292, 22)
        Me.TextBox5.TabIndex = 75
        Me.TextBox5.Text = "ESCRIBIR NOMBRE ACTIVIDAD"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 16
        Me.ListBox3.Location = New System.Drawing.Point(9, 111)
        Me.ListBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(291, 20)
        Me.ListBox3.TabIndex = 98
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(66, 140)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(159, 31)
        Me.Button6.TabIndex = 98
        Me.Button6.Text = "ELIMINAR"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 16)
        Me.Label12.TabIndex = 73
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(15, 61)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(232, 22)
        Me.TextBox7.TabIndex = 75
        Me.TextBox7.Text = "ESCRIBIR NOMBRE ACTIVIDAD"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(9, 59)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(280, 24)
        Me.ComboBox2.TabIndex = 125
        '
        'txtbEstado
        '
        Me.txtbEstado.Location = New System.Drawing.Point(9, 89)
        Me.txtbEstado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbEstado.Name = "txtbEstado"
        Me.txtbEstado.ReadOnly = True
        Me.txtbEstado.Size = New System.Drawing.Size(127, 22)
        Me.txtbEstado.TabIndex = 124
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(142, 89)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 25)
        Me.Button1.TabIndex = 126
        Me.Button1.Text = "CAMBIAR ESTADO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(1277, 698)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpEdicionAct)
        Me.Controls.Add(Me.grpConsultarAct)
        Me.Controls.Add(Me.grpGestionAct)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
    Friend WithEvents txtFechaIni As TextBox
    Friend WithEvents txtFechaFin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents grpConsultarAct As GroupBox
    Friend WithEvents grpGestionAct As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents grpEdicionAct As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstDatosAnyadidos As ListBox
    Friend WithEvents cboODS As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lstTipoActividad As ListBox
    Friend WithEvents cboTipoActividad As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnEliminarTipoAc As Button
    Friend WithEvents btnEliminarODS As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnAnadirAlumnos As Button
    Friend WithEvents btnEliminarAlumnos As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAnadirODS As Button
    Friend WithEvents btnAñadirTipoAc As Button
    Friend WithEvents lstbAlumnAnadidos As ListBox
    Friend WithEvents lstbAlumn As ListBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnCrearActividad As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtbEstado As TextBox
End Class
