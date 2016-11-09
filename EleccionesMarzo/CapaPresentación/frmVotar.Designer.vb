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
        Me.ComunidadTableAdapter1 = New CapaDatos.DSEleccionesTableAdapters.ComunidadTableAdapter()
        Me.lblBuscarLocalidad = New System.Windows.Forms.Label()
        Me.txtBoxBuscarLocalidad = New System.Windows.Forms.TextBox()
        Me.btnBuscarLocalidad = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComunidadTableAdapter1
        '
        Me.ComunidadTableAdapter1.ClearBeforeFill = True
        '
        'lblBuscarLocalidad
        '
        Me.lblBuscarLocalidad.AutoSize = True
        Me.lblBuscarLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarLocalidad.Location = New System.Drawing.Point(44, 52)
        Me.lblBuscarLocalidad.Name = "lblBuscarLocalidad"
        Me.lblBuscarLocalidad.Size = New System.Drawing.Size(153, 24)
        Me.lblBuscarLocalidad.TabIndex = 6
        Me.lblBuscarLocalidad.Text = "Buscar localidad:"
        '
        'txtBoxBuscarLocalidad
        '
        Me.txtBoxBuscarLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxBuscarLocalidad.Location = New System.Drawing.Point(228, 49)
        Me.txtBoxBuscarLocalidad.Name = "txtBoxBuscarLocalidad"
        Me.txtBoxBuscarLocalidad.Size = New System.Drawing.Size(192, 28)
        Me.txtBoxBuscarLocalidad.TabIndex = 5
        '
        'btnBuscarLocalidad
        '
        Me.btnBuscarLocalidad.Location = New System.Drawing.Point(450, 44)
        Me.btnBuscarLocalidad.Name = "btnBuscarLocalidad"
        Me.btnBuscarLocalidad.Size = New System.Drawing.Size(78, 42)
        Me.btnBuscarLocalidad.TabIndex = 4
        Me.btnBuscarLocalidad.Text = "Buscar"
        Me.btnBuscarLocalidad.UseVisualStyleBackColor = True
        '
        'frmVotar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 655)
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
End Class
