<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntroducirVotos
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
        Me.cmbPartidos = New System.Windows.Forms.ComboBox()
        Me.lblPartido = New System.Windows.Forms.Label()
        Me.lblVotos = New System.Windows.Forms.Label()
        Me.txtVotos = New System.Windows.Forms.TextBox()
        Me.btnIntroducir = New System.Windows.Forms.Button()
        Me.lblLocalidades = New System.Windows.Forms.Label()
        Me.cmbLocalidades = New System.Windows.Forms.ComboBox()
        Me.lblProvincias = New System.Windows.Forms.Label()
        Me.lblCmbComunidades = New System.Windows.Forms.Label()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.cmbComunidades = New System.Windows.Forms.ComboBox()
        Me.lblSeparador = New System.Windows.Forms.Label()
        Me.cmbElecciones = New System.Windows.Forms.ComboBox()
        Me.lblElecciones = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbPartidos
        '
        Me.cmbPartidos.FormattingEnabled = True
        Me.cmbPartidos.Location = New System.Drawing.Point(185, 270)
        Me.cmbPartidos.Name = "cmbPartidos"
        Me.cmbPartidos.Size = New System.Drawing.Size(192, 24)
        Me.cmbPartidos.TabIndex = 27
        '
        'lblPartido
        '
        Me.lblPartido.AutoSize = True
        Me.lblPartido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartido.Location = New System.Drawing.Point(68, 268)
        Me.lblPartido.Name = "lblPartido"
        Me.lblPartido.Size = New System.Drawing.Size(68, 24)
        Me.lblPartido.TabIndex = 26
        Me.lblPartido.Text = "Partido"
        Me.lblPartido.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVotos
        '
        Me.lblVotos.AutoSize = True
        Me.lblVotos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVotos.Location = New System.Drawing.Point(78, 318)
        Me.lblVotos.Name = "lblVotos"
        Me.lblVotos.Size = New System.Drawing.Size(58, 24)
        Me.lblVotos.TabIndex = 28
        Me.lblVotos.Text = "Votos"
        Me.lblVotos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtVotos
        '
        Me.txtVotos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVotos.Location = New System.Drawing.Point(185, 318)
        Me.txtVotos.Name = "txtVotos"
        Me.txtVotos.Size = New System.Drawing.Size(192, 28)
        Me.txtVotos.TabIndex = 29
        '
        'btnIntroducir
        '
        Me.btnIntroducir.Location = New System.Drawing.Point(209, 362)
        Me.btnIntroducir.Name = "btnIntroducir"
        Me.btnIntroducir.Size = New System.Drawing.Size(118, 55)
        Me.btnIntroducir.TabIndex = 30
        Me.btnIntroducir.Text = "Introducir Votos"
        Me.btnIntroducir.UseVisualStyleBackColor = True
        '
        'lblLocalidades
        '
        Me.lblLocalidades.AutoSize = True
        Me.lblLocalidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidades.Location = New System.Drawing.Point(3, 140)
        Me.lblLocalidades.Name = "lblLocalidades"
        Me.lblLocalidades.Size = New System.Drawing.Size(310, 24)
        Me.lblLocalidades.TabIndex = 40
        Me.lblLocalidades.Text = "Localidades de la provincia elegida:"
        '
        'cmbLocalidades
        '
        Me.cmbLocalidades.FormattingEnabled = True
        Me.cmbLocalidades.Location = New System.Drawing.Point(365, 140)
        Me.cmbLocalidades.Name = "cmbLocalidades"
        Me.cmbLocalidades.Size = New System.Drawing.Size(192, 24)
        Me.cmbLocalidades.TabIndex = 39
        '
        'lblProvincias
        '
        Me.lblProvincias.AutoSize = True
        Me.lblProvincias.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvincias.Location = New System.Drawing.Point(3, 86)
        Me.lblProvincias.Name = "lblProvincias"
        Me.lblProvincias.Size = New System.Drawing.Size(319, 24)
        Me.lblProvincias.TabIndex = 38
        Me.lblProvincias.Text = "Provincias de la comunidad elegida: "
        '
        'lblCmbComunidades
        '
        Me.lblCmbComunidades.AutoSize = True
        Me.lblCmbComunidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCmbComunidades.Location = New System.Drawing.Point(3, 27)
        Me.lblCmbComunidades.Name = "lblCmbComunidades"
        Me.lblCmbComunidades.Size = New System.Drawing.Size(133, 24)
        Me.lblCmbComunidades.TabIndex = 37
        Me.lblCmbComunidades.Text = "Comunidades:"
        '
        'cmbProvincia
        '
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Location = New System.Drawing.Point(365, 86)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(192, 24)
        Me.cmbProvincia.TabIndex = 36
        '
        'cmbComunidades
        '
        Me.cmbComunidades.FormattingEnabled = True
        Me.cmbComunidades.Location = New System.Drawing.Point(365, 27)
        Me.cmbComunidades.Name = "cmbComunidades"
        Me.cmbComunidades.Size = New System.Drawing.Size(192, 24)
        Me.cmbComunidades.TabIndex = 35
        '
        'lblSeparador
        '
        Me.lblSeparador.AutoSize = True
        Me.lblSeparador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeparador.Location = New System.Drawing.Point(-218, 181)
        Me.lblSeparador.Name = "lblSeparador"
        Me.lblSeparador.Size = New System.Drawing.Size(1040, 24)
        Me.lblSeparador.TabIndex = 41
        Me.lblSeparador.Text = "_________________________________________________________________________________" &
    "______________________"
        '
        'cmbElecciones
        '
        Me.cmbElecciones.FormattingEnabled = True
        Me.cmbElecciones.Location = New System.Drawing.Point(185, 228)
        Me.cmbElecciones.Name = "cmbElecciones"
        Me.cmbElecciones.Size = New System.Drawing.Size(192, 24)
        Me.cmbElecciones.TabIndex = 43
        '
        'lblElecciones
        '
        Me.lblElecciones.AutoSize = True
        Me.lblElecciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElecciones.Location = New System.Drawing.Point(27, 228)
        Me.lblElecciones.Name = "lblElecciones"
        Me.lblElecciones.Size = New System.Drawing.Size(109, 24)
        Me.lblElecciones.TabIndex = 42
        Me.lblElecciones.Text = "Elecciones:"
        '
        'frmIntroducirVotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 447)
        Me.Controls.Add(Me.cmbElecciones)
        Me.Controls.Add(Me.lblElecciones)
        Me.Controls.Add(Me.lblSeparador)
        Me.Controls.Add(Me.lblLocalidades)
        Me.Controls.Add(Me.cmbLocalidades)
        Me.Controls.Add(Me.lblProvincias)
        Me.Controls.Add(Me.lblCmbComunidades)
        Me.Controls.Add(Me.cmbProvincia)
        Me.Controls.Add(Me.cmbComunidades)
        Me.Controls.Add(Me.btnIntroducir)
        Me.Controls.Add(Me.txtVotos)
        Me.Controls.Add(Me.lblVotos)
        Me.Controls.Add(Me.cmbPartidos)
        Me.Controls.Add(Me.lblPartido)
        Me.Name = "frmIntroducirVotos"
        Me.Text = "frmIntroducirVotos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbPartidos As ComboBox
    Friend WithEvents lblPartido As Label
    Friend WithEvents lblVotos As Label
    Friend WithEvents txtVotos As TextBox
    Friend WithEvents btnIntroducir As Button
    Friend WithEvents lblLocalidades As Label
    Friend WithEvents cmbLocalidades As ComboBox
    Friend WithEvents lblProvincias As Label
    Friend WithEvents lblCmbComunidades As Label
    Friend WithEvents cmbProvincia As ComboBox
    Friend WithEvents cmbComunidades As ComboBox
    Friend WithEvents lblSeparador As Label
    Friend WithEvents cmbElecciones As ComboBox
    Friend WithEvents lblElecciones As Label
End Class
