﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.pnlAnyadirVoluntariado = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlAnyadirVoluntariado.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAnyadirVoluntariado
        '
        Me.pnlAnyadirVoluntariado.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlAnyadirVoluntariado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAnyadirVoluntariado.Controls.Add(Me.Label1)
        Me.pnlAnyadirVoluntariado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlAnyadirVoluntariado.Location = New System.Drawing.Point(32, 28)
        Me.pnlAnyadirVoluntariado.Name = "pnlAnyadirVoluntariado"
        Me.pnlAnyadirVoluntariado.Size = New System.Drawing.Size(743, 196)
        Me.pnlAnyadirVoluntariado.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Gestión de Acciones de Voluntariado"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlAnyadirVoluntariado)
        Me.Name = "FrmPrincipal"
        Me.Text = "Gestión Voluntariado"
        Me.pnlAnyadirVoluntariado.ResumeLayout(False)
        Me.pnlAnyadirVoluntariado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlAnyadirVoluntariado As Panel
    Friend WithEvents Label1 As Label
End Class
