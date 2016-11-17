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
        Me.lblBuscarLocalidad = New System.Windows.Forms.Label()
        Me.txtBoxBuscarLocalidad = New System.Windows.Forms.TextBox()
        Me.btnBuscarLocalidad = New System.Windows.Forms.Button()
        Me.cmbLocalidades = New System.Windows.Forms.ComboBox()
        Me.lblLocalidadesEncontradas = New System.Windows.Forms.Label()
        Me.btnVotar = New System.Windows.Forms.Button()
        Me.lblSeparador = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.lblPartido = New System.Windows.Forms.Label()
        Me.cmbPartidos = New System.Windows.Forms.ComboBox()
        Me.ComunidadTableAdapter1 = New CapaDatos.DSEleccionesTableAdapters.ComunidadTableAdapter()
        Me.cmbElecciones = New System.Windows.Forms.ComboBox()
        Me.lblElecciones = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBuscarLocalidad
        '
        Me.lblBuscarLocalidad.AutoSize = True
        Me.lblBuscarLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarLocalidad.Location = New System.Drawing.Point(93, 52)
        Me.lblBuscarLocalidad.Name = "lblBuscarLocalidad"
        Me.lblBuscarLocalidad.Size = New System.Drawing.Size(153, 24)
        Me.lblBuscarLocalidad.TabIndex = 6
        Me.lblBuscarLocalidad.Text = "Buscar localidad:"
        '
        'txtBoxBuscarLocalidad
        '
        Me.txtBoxBuscarLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxBuscarLocalidad.Location = New System.Drawing.Point(273, 49)
        Me.txtBoxBuscarLocalidad.Name = "txtBoxBuscarLocalidad"
        Me.txtBoxBuscarLocalidad.Size = New System.Drawing.Size(192, 28)
        Me.txtBoxBuscarLocalidad.TabIndex = 5
        '
        'btnBuscarLocalidad
        '
        Me.btnBuscarLocalidad.Location = New System.Drawing.Point(496, 44)
        Me.btnBuscarLocalidad.Name = "btnBuscarLocalidad"
        Me.btnBuscarLocalidad.Size = New System.Drawing.Size(78, 42)
        Me.btnBuscarLocalidad.TabIndex = 4
        Me.btnBuscarLocalidad.Text = "Buscar"
        Me.btnBuscarLocalidad.UseVisualStyleBackColor = True
        '
        'cmbLocalidades
        '
        Me.cmbLocalidades.FormattingEnabled = True
        Me.cmbLocalidades.Location = New System.Drawing.Point(273, 95)
        Me.cmbLocalidades.Name = "cmbLocalidades"
        Me.cmbLocalidades.Size = New System.Drawing.Size(192, 24)
        Me.cmbLocalidades.TabIndex = 7
        '
        'lblLocalidadesEncontradas
        '
        Me.lblLocalidadesEncontradas.AutoSize = True
        Me.lblLocalidadesEncontradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidadesEncontradas.Location = New System.Drawing.Point(21, 93)
        Me.lblLocalidadesEncontradas.Name = "lblLocalidadesEncontradas"
        Me.lblLocalidadesEncontradas.Size = New System.Drawing.Size(225, 24)
        Me.lblLocalidadesEncontradas.TabIndex = 8
        Me.lblLocalidadesEncontradas.Text = "Localidades encontradas:"
        '
        'btnVotar
        '
        Me.btnVotar.Location = New System.Drawing.Point(305, 294)
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
        Me.lblSeparador.Location = New System.Drawing.Point(-27, 122)
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
        Me.lblDni.Location = New System.Drawing.Point(102, 214)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(145, 24)
        Me.lblDni.TabIndex = 22
        Me.lblDni.Text = "Introduce tu dni:"
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(274, 211)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(192, 28)
        Me.txtDni.TabIndex = 21
        '
        'lblPartido
        '
        Me.lblPartido.AutoSize = True
        Me.lblPartido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartido.Location = New System.Drawing.Point(72, 251)
        Me.lblPartido.Name = "lblPartido"
        Me.lblPartido.Size = New System.Drawing.Size(175, 24)
        Me.lblPartido.TabIndex = 24
        Me.lblPartido.Text = "Partido al que votar:"
        '
        'cmbPartidos
        '
        Me.cmbPartidos.FormattingEnabled = True
        Me.cmbPartidos.Location = New System.Drawing.Point(274, 253)
        Me.cmbPartidos.Name = "cmbPartidos"
        Me.cmbPartidos.Size = New System.Drawing.Size(192, 24)
        Me.cmbPartidos.TabIndex = 25
        '
        'ComunidadTableAdapter1
        '
        Me.ComunidadTableAdapter1.ClearBeforeFill = True
        '
        'cmbElecciones
        '
        Me.cmbElecciones.FormattingEnabled = True
        Me.cmbElecciones.Location = New System.Drawing.Point(274, 172)
        Me.cmbElecciones.Name = "cmbElecciones"
        Me.cmbElecciones.Size = New System.Drawing.Size(192, 24)
        Me.cmbElecciones.TabIndex = 27
        '
        'lblElecciones
        '
        Me.lblElecciones.AutoSize = True
        Me.lblElecciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElecciones.Location = New System.Drawing.Point(12, 170)
        Me.lblElecciones.Name = "lblElecciones"
        Me.lblElecciones.Size = New System.Drawing.Size(235, 24)
        Me.lblElecciones.TabIndex = 26
        Me.lblElecciones.Text = "Elecciones a las que votar:"
        '
        'frmVotar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 460)
        Me.Controls.Add(Me.cmbElecciones)
        Me.Controls.Add(Me.lblElecciones)
        Me.Controls.Add(Me.cmbPartidos)
        Me.Controls.Add(Me.lblPartido)
        Me.Controls.Add(Me.lblDni)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.lblSeparador)
        Me.Controls.Add(Me.btnVotar)
        Me.Controls.Add(Me.lblLocalidadesEncontradas)
        Me.Controls.Add(Me.cmbLocalidades)
        Me.Controls.Add(Me.lblBuscarLocalidad)
        Me.Controls.Add(Me.txtBoxBuscarLocalidad)
        Me.Controls.Add(Me.btnBuscarLocalidad)
        Me.Name = "frmVotar"
        Me.Text = "Votar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComunidadTableAdapter1 As CapaDatos.DSEleccionesTableAdapters.ComunidadTableAdapter
    Friend WithEvents lblBuscarLocalidad As Label
    Friend WithEvents txtBoxBuscarLocalidad As TextBox
    Friend WithEvents btnBuscarLocalidad As Button
    Friend WithEvents cmbLocalidades As ComboBox
    Friend WithEvents lblLocalidadesEncontradas As Label
    Friend WithEvents btnVotar As Button
    Friend WithEvents lblSeparador As Label
    Friend WithEvents lblDni As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents lblPartido As Label
    Friend WithEvents cmbPartidos As ComboBox
    Friend WithEvents cmbElecciones As ComboBox
    Friend WithEvents lblElecciones As Label
End Class
