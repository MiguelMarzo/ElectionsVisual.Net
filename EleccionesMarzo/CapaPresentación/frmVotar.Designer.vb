<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVotar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnVotar = New System.Windows.Forms.Button()
        Me.lblSeparador = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.lblPartido = New System.Windows.Forms.Label()
        Me.cmbPartidos = New System.Windows.Forms.ComboBox()
        Me.cmbElecciones = New System.Windows.Forms.ComboBox()
        Me.lblElecciones = New System.Windows.Forms.Label()
        Me.lblLocalidades = New System.Windows.Forms.Label()
        Me.cmbLocalidades = New System.Windows.Forms.ComboBox()
        Me.lblProvincias = New System.Windows.Forms.Label()
        Me.lblCmbComunidades = New System.Windows.Forms.Label()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.cmbComunidades = New System.Windows.Forms.ComboBox()
        Me.ComunidadTableAdapter1 = New CapaDatos.DSEleccionesTableAdapters.ComunidadTableAdapter()
        Me.SuspendLayout()
        '
        'btnVotar
        '
        Me.btnVotar.Location = New System.Drawing.Point(242, 367)
        Me.btnVotar.Name = "btnVotar"
        Me.btnVotar.Size = New System.Drawing.Size(118, 55)
        Me.btnVotar.TabIndex = 9
        Me.btnVotar.Text = "Votar"
        Me.btnVotar.UseVisualStyleBackColor = True
        '
        'lblSeparador
        '
        Me.lblSeparador.AutoSize = True
        Me.lblSeparador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeparador.Location = New System.Drawing.Point(-13, 155)
        Me.lblSeparador.Name = "lblSeparador"
        Me.lblSeparador.Size = New System.Drawing.Size(1040, 24)
        Me.lblSeparador.TabIndex = 20
        Me.lblSeparador.Text = "_________________________________________________________________________________" &
    "______________________"
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.Location = New System.Drawing.Point(87, 315)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(145, 24)
        Me.lblDni.TabIndex = 22
        Me.lblDni.Text = "Introduce tu dni:"
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(242, 311)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(192, 28)
        Me.txtDni.TabIndex = 21
        '
        'lblPartido
        '
        Me.lblPartido.AutoSize = True
        Me.lblPartido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartido.Location = New System.Drawing.Point(8, 240)
        Me.lblPartido.Name = "lblPartido"
        Me.lblPartido.Size = New System.Drawing.Size(175, 24)
        Me.lblPartido.TabIndex = 24
        Me.lblPartido.Text = "Partido al que votar:"
        '
        'cmbPartidos
        '
        Me.cmbPartidos.FormattingEnabled = True
        Me.cmbPartidos.Location = New System.Drawing.Point(333, 242)
        Me.cmbPartidos.Name = "cmbPartidos"
        Me.cmbPartidos.Size = New System.Drawing.Size(192, 24)
        Me.cmbPartidos.TabIndex = 25
        '
        'cmbElecciones
        '
        Me.cmbElecciones.FormattingEnabled = True
        Me.cmbElecciones.Location = New System.Drawing.Point(333, 195)
        Me.cmbElecciones.Name = "cmbElecciones"
        Me.cmbElecciones.Size = New System.Drawing.Size(192, 24)
        Me.cmbElecciones.TabIndex = 27
        '
        'lblElecciones
        '
        Me.lblElecciones.AutoSize = True
        Me.lblElecciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElecciones.Location = New System.Drawing.Point(8, 195)
        Me.lblElecciones.Name = "lblElecciones"
        Me.lblElecciones.Size = New System.Drawing.Size(235, 24)
        Me.lblElecciones.TabIndex = 26
        Me.lblElecciones.Text = "Elecciones a las que votar:"
        '
        'lblLocalidades
        '
        Me.lblLocalidades.AutoSize = True
        Me.lblLocalidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidades.Location = New System.Drawing.Point(8, 126)
        Me.lblLocalidades.Name = "lblLocalidades"
        Me.lblLocalidades.Size = New System.Drawing.Size(310, 24)
        Me.lblLocalidades.TabIndex = 34
        Me.lblLocalidades.Text = "Localidades de la provincia elegida:"
        '
        'cmbLocalidades
        '
        Me.cmbLocalidades.FormattingEnabled = True
        Me.cmbLocalidades.Location = New System.Drawing.Point(333, 128)
        Me.cmbLocalidades.Name = "cmbLocalidades"
        Me.cmbLocalidades.Size = New System.Drawing.Size(192, 24)
        Me.cmbLocalidades.TabIndex = 33
        '
        'lblProvincias
        '
        Me.lblProvincias.AutoSize = True
        Me.lblProvincias.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvincias.Location = New System.Drawing.Point(8, 72)
        Me.lblProvincias.Name = "lblProvincias"
        Me.lblProvincias.Size = New System.Drawing.Size(319, 24)
        Me.lblProvincias.TabIndex = 32
        Me.lblProvincias.Text = "Provincias de la comunidad elegida: "
        '
        'lblCmbComunidades
        '
        Me.lblCmbComunidades.AutoSize = True
        Me.lblCmbComunidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCmbComunidades.Location = New System.Drawing.Point(8, 13)
        Me.lblCmbComunidades.Name = "lblCmbComunidades"
        Me.lblCmbComunidades.Size = New System.Drawing.Size(133, 24)
        Me.lblCmbComunidades.TabIndex = 31
        Me.lblCmbComunidades.Text = "Comunidades:"
        '
        'cmbProvincia
        '
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Location = New System.Drawing.Point(333, 74)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(192, 24)
        Me.cmbProvincia.TabIndex = 30
        '
        'cmbComunidades
        '
        Me.cmbComunidades.FormattingEnabled = True
        Me.cmbComunidades.Location = New System.Drawing.Point(333, 15)
        Me.cmbComunidades.Name = "cmbComunidades"
        Me.cmbComunidades.Size = New System.Drawing.Size(192, 24)
        Me.cmbComunidades.TabIndex = 29
        '
        'ComunidadTableAdapter1
        '
        Me.ComunidadTableAdapter1.ClearBeforeFill = True
        '
        'frmVotar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 460)
        Me.Controls.Add(Me.lblLocalidades)
        Me.Controls.Add(Me.cmbLocalidades)
        Me.Controls.Add(Me.lblProvincias)
        Me.Controls.Add(Me.lblCmbComunidades)
        Me.Controls.Add(Me.cmbProvincia)
        Me.Controls.Add(Me.cmbComunidades)
        Me.Controls.Add(Me.cmbElecciones)
        Me.Controls.Add(Me.lblElecciones)
        Me.Controls.Add(Me.cmbPartidos)
        Me.Controls.Add(Me.lblPartido)
        Me.Controls.Add(Me.lblDni)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.lblSeparador)
        Me.Controls.Add(Me.btnVotar)
        Me.Name = "frmVotar"
        Me.Text = "Votar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComunidadTableAdapter1 As CapaDatos.DSEleccionesTableAdapters.ComunidadTableAdapter
    Friend WithEvents btnVotar As Button
    Friend WithEvents lblSeparador As Label
    Friend WithEvents lblDni As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents lblPartido As Label
    Friend WithEvents cmbPartidos As ComboBox
    Friend WithEvents cmbElecciones As ComboBox
    Friend WithEvents lblElecciones As Label
    Friend WithEvents lblLocalidades As Label
    Friend WithEvents cmbLocalidades As ComboBox
    Friend WithEvents lblProvincias As Label
    Friend WithEvents lblCmbComunidades As Label
    Friend WithEvents cmbProvincia As ComboBox
    Friend WithEvents cmbComunidades As ComboBox
End Class
