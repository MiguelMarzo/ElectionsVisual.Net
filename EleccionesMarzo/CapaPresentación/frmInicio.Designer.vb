﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.btnBuscarLocalidad = New System.Windows.Forms.Button()
        Me.dgvConsultas = New System.Windows.Forms.DataGridView()
        Me.txtBoxBuscarLocalidad = New System.Windows.Forms.TextBox()
        Me.lblBuscarLocalidad = New System.Windows.Forms.Label()
        Me.lblCenso = New System.Windows.Forms.Label()
        Me.txtBoxCensoNombreLocalidad = New System.Windows.Forms.TextBox()
        Me.btnCenso = New System.Windows.Forms.Button()
        Me.lblCensoLocalidad = New System.Windows.Forms.Label()
        Me.CalendarioCenso = New System.Windows.Forms.MonthCalendar()
        Me.lblCensoFecha = New System.Windows.Forms.Label()
        Me.cmbComunidad = New System.Windows.Forms.ComboBox()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.lblCmbComunidades = New System.Windows.Forms.Label()
        Me.lblCmbProvincias = New System.Windows.Forms.Label()
        Me.lblLocalidades = New System.Windows.Forms.Label()
        Me.cmbLocalidades = New System.Windows.Forms.ComboBox()
        Me.lblSeparador1 = New System.Windows.Forms.Label()
        Me.btnVotar = New System.Windows.Forms.Button()
        Me.DsElecciones1 = New CapaDatos.DSElecciones()
        Me.lblSeparador2 = New System.Windows.Forms.Label()
        Me.lblSeparador3 = New System.Windows.Forms.Label()
        CType(Me.dgvConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsElecciones1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscarLocalidad
        '
        Me.btnBuscarLocalidad.Location = New System.Drawing.Point(407, 30)
        Me.btnBuscarLocalidad.Name = "btnBuscarLocalidad"
        Me.btnBuscarLocalidad.Size = New System.Drawing.Size(78, 42)
        Me.btnBuscarLocalidad.TabIndex = 0
        Me.btnBuscarLocalidad.Text = "Buscar"
        Me.btnBuscarLocalidad.UseVisualStyleBackColor = True
        '
        'dgvConsultas
        '
        Me.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultas.Location = New System.Drawing.Point(529, 30)
        Me.dgvConsultas.Name = "dgvConsultas"
        Me.dgvConsultas.RowTemplate.Height = 24
        Me.dgvConsultas.Size = New System.Drawing.Size(701, 760)
        Me.dgvConsultas.TabIndex = 1
        '
        'txtBoxBuscarLocalidad
        '
        Me.txtBoxBuscarLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxBuscarLocalidad.Location = New System.Drawing.Point(185, 35)
        Me.txtBoxBuscarLocalidad.Name = "txtBoxBuscarLocalidad"
        Me.txtBoxBuscarLocalidad.Size = New System.Drawing.Size(192, 28)
        Me.txtBoxBuscarLocalidad.TabIndex = 2
        '
        'lblBuscarLocalidad
        '
        Me.lblBuscarLocalidad.AutoSize = True
        Me.lblBuscarLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarLocalidad.Location = New System.Drawing.Point(1, 38)
        Me.lblBuscarLocalidad.Name = "lblBuscarLocalidad"
        Me.lblBuscarLocalidad.Size = New System.Drawing.Size(153, 24)
        Me.lblBuscarLocalidad.TabIndex = 3
        Me.lblBuscarLocalidad.Text = "Buscar localidad:"
        '
        'lblCenso
        '
        Me.lblCenso.AutoSize = True
        Me.lblCenso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCenso.Location = New System.Drawing.Point(153, 150)
        Me.lblCenso.Name = "lblCenso"
        Me.lblCenso.Size = New System.Drawing.Size(146, 24)
        Me.lblCenso.TabIndex = 6
        Me.lblCenso.Text = "Consultar censo"
        '
        'txtBoxCensoNombreLocalidad
        '
        Me.txtBoxCensoNombreLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxCensoNombreLocalidad.Location = New System.Drawing.Point(157, 196)
        Me.txtBoxCensoNombreLocalidad.Name = "txtBoxCensoNombreLocalidad"
        Me.txtBoxCensoNombreLocalidad.Size = New System.Drawing.Size(192, 28)
        Me.txtBoxCensoNombreLocalidad.TabIndex = 5
        '
        'btnCenso
        '
        Me.btnCenso.Location = New System.Drawing.Point(423, 296)
        Me.btnCenso.Name = "btnCenso"
        Me.btnCenso.Size = New System.Drawing.Size(100, 72)
        Me.btnCenso.TabIndex = 4
        Me.btnCenso.Text = "Consultar"
        Me.btnCenso.UseVisualStyleBackColor = True
        '
        'lblCensoLocalidad
        '
        Me.lblCensoLocalidad.AutoSize = True
        Me.lblCensoLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCensoLocalidad.Location = New System.Drawing.Point(53, 196)
        Me.lblCensoLocalidad.Name = "lblCensoLocalidad"
        Me.lblCensoLocalidad.Size = New System.Drawing.Size(75, 18)
        Me.lblCensoLocalidad.TabIndex = 7
        Me.lblCensoLocalidad.Text = "Localidad:"
        '
        'CalendarioCenso
        '
        Me.CalendarioCenso.Location = New System.Drawing.Point(157, 254)
        Me.CalendarioCenso.MaxSelectionCount = 1
        Me.CalendarioCenso.Name = "CalendarioCenso"
        Me.CalendarioCenso.TabIndex = 8
        '
        'lblCensoFecha
        '
        Me.lblCensoFecha.AutoSize = True
        Me.lblCensoFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCensoFecha.Location = New System.Drawing.Point(2, 241)
        Me.lblCensoFecha.Name = "lblCensoFecha"
        Me.lblCensoFecha.Size = New System.Drawing.Size(128, 18)
        Me.lblCensoFecha.TabIndex = 9
        Me.lblCensoFecha.Text = "Fecha elecciones:"
        '
        'cmbComunidad
        '
        Me.cmbComunidad.FormattingEnabled = True
        Me.cmbComunidad.Location = New System.Drawing.Point(157, 528)
        Me.cmbComunidad.Name = "cmbComunidad"
        Me.cmbComunidad.Size = New System.Drawing.Size(192, 24)
        Me.cmbComunidad.TabIndex = 10
        '
        'cmbProvincia
        '
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Location = New System.Drawing.Point(157, 587)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(192, 24)
        Me.cmbProvincia.TabIndex = 11
        '
        'lblCmbComunidades
        '
        Me.lblCmbComunidades.AutoSize = True
        Me.lblCmbComunidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCmbComunidades.Location = New System.Drawing.Point(12, 526)
        Me.lblCmbComunidades.Name = "lblCmbComunidades"
        Me.lblCmbComunidades.Size = New System.Drawing.Size(133, 24)
        Me.lblCmbComunidades.TabIndex = 12
        Me.lblCmbComunidades.Text = "Comunidades:"
        '
        'lblCmbProvincias
        '
        Me.lblCmbProvincias.AutoSize = True
        Me.lblCmbProvincias.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCmbProvincias.Location = New System.Drawing.Point(44, 585)
        Me.lblCmbProvincias.Name = "lblCmbProvincias"
        Me.lblCmbProvincias.Size = New System.Drawing.Size(101, 24)
        Me.lblCmbProvincias.TabIndex = 13
        Me.lblCmbProvincias.Text = "Provincias:"
        '
        'lblLocalidades
        '
        Me.lblLocalidades.AutoSize = True
        Me.lblLocalidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidades.Location = New System.Drawing.Point(29, 641)
        Me.lblLocalidades.Name = "lblLocalidades"
        Me.lblLocalidades.Size = New System.Drawing.Size(116, 24)
        Me.lblLocalidades.TabIndex = 15
        Me.lblLocalidades.Text = "Localidades:"
        '
        'cmbLocalidades
        '
        Me.cmbLocalidades.FormattingEnabled = True
        Me.cmbLocalidades.Location = New System.Drawing.Point(157, 643)
        Me.cmbLocalidades.Name = "cmbLocalidades"
        Me.cmbLocalidades.Size = New System.Drawing.Size(192, 24)
        Me.cmbLocalidades.TabIndex = 14
        '
        'lblSeparador1
        '
        Me.lblSeparador1.AutoSize = True
        Me.lblSeparador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeparador1.Location = New System.Drawing.Point(12, 117)
        Me.lblSeparador1.Name = "lblSeparador1"
        Me.lblSeparador1.Size = New System.Drawing.Size(480, 24)
        Me.lblSeparador1.TabIndex = 16
        Me.lblSeparador1.Text = "_______________________________________________"
        '
        'btnVotar
        '
        Me.btnVotar.Location = New System.Drawing.Point(157, 725)
        Me.btnVotar.Name = "btnVotar"
        Me.btnVotar.Size = New System.Drawing.Size(183, 70)
        Me.btnVotar.TabIndex = 17
        Me.btnVotar.Text = "Ir a Votar"
        Me.btnVotar.UseVisualStyleBackColor = True
        '
        'DsElecciones1
        '
        Me.DsElecciones1.DataSetName = "DSElecciones"
        Me.DsElecciones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblSeparador2
        '
        Me.lblSeparador2.AutoSize = True
        Me.lblSeparador2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeparador2.Location = New System.Drawing.Point(12, 487)
        Me.lblSeparador2.Name = "lblSeparador2"
        Me.lblSeparador2.Size = New System.Drawing.Size(480, 24)
        Me.lblSeparador2.TabIndex = 18
        Me.lblSeparador2.Text = "_______________________________________________"
        '
        'lblSeparador3
        '
        Me.lblSeparador3.AutoSize = True
        Me.lblSeparador3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeparador3.Location = New System.Drawing.Point(12, 684)
        Me.lblSeparador3.Name = "lblSeparador3"
        Me.lblSeparador3.Size = New System.Drawing.Size(480, 24)
        Me.lblSeparador3.TabIndex = 19
        Me.lblSeparador3.Text = "_______________________________________________"
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 807)
        Me.Controls.Add(Me.lblSeparador3)
        Me.Controls.Add(Me.lblSeparador2)
        Me.Controls.Add(Me.btnVotar)
        Me.Controls.Add(Me.lblSeparador1)
        Me.Controls.Add(Me.lblLocalidades)
        Me.Controls.Add(Me.cmbLocalidades)
        Me.Controls.Add(Me.lblCmbProvincias)
        Me.Controls.Add(Me.lblCmbComunidades)
        Me.Controls.Add(Me.cmbProvincia)
        Me.Controls.Add(Me.cmbComunidad)
        Me.Controls.Add(Me.lblCensoFecha)
        Me.Controls.Add(Me.CalendarioCenso)
        Me.Controls.Add(Me.lblCensoLocalidad)
        Me.Controls.Add(Me.lblCenso)
        Me.Controls.Add(Me.txtBoxCensoNombreLocalidad)
        Me.Controls.Add(Me.btnCenso)
        Me.Controls.Add(Me.lblBuscarLocalidad)
        Me.Controls.Add(Me.txtBoxBuscarLocalidad)
        Me.Controls.Add(Me.dgvConsultas)
        Me.Controls.Add(Me.btnBuscarLocalidad)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInicio"
        Me.Text = "Elecciones"
        CType(Me.dgvConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsElecciones1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscarLocalidad As Button
    Friend WithEvents dgvConsultas As DataGridView
    Friend WithEvents txtBoxBuscarLocalidad As TextBox
    Friend WithEvents lblBuscarLocalidad As Label
    Friend WithEvents lblCenso As Label
    Friend WithEvents txtBoxCensoNombreLocalidad As TextBox
    Friend WithEvents btnCenso As Button
    Friend WithEvents lblCensoLocalidad As Label
    Friend WithEvents CalendarioCenso As MonthCalendar
    Friend WithEvents lblCensoFecha As Label
    Friend WithEvents DsElecciones1 As CapaDatos.DSElecciones
    Friend WithEvents cmbComunidad As ComboBox
    Friend WithEvents cmbProvincia As ComboBox
    Friend WithEvents lblCmbComunidades As Label
    Friend WithEvents lblCmbProvincias As Label
    Friend WithEvents lblLocalidades As Label
    Friend WithEvents cmbLocalidades As ComboBox
    Friend WithEvents lblSeparador1 As Label
    Friend WithEvents btnVotar As Button
    Friend WithEvents lblSeparador2 As Label
    Friend WithEvents lblSeparador3 As Label
End Class
