<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnBuscarLocalidad = New System.Windows.Forms.Button()
        Me.dgvConsultas = New System.Windows.Forms.DataGridView()
        Me.txtBoxBuscarLocalidad = New System.Windows.Forms.TextBox()
        Me.lblBuscarLocalidad = New System.Windows.Forms.Label()
        CType(Me.dgvConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvConsultas.Location = New System.Drawing.Point(535, 12)
        Me.dgvConsultas.Name = "dgvConsultas"
        Me.dgvConsultas.RowTemplate.Height = 24
        Me.dgvConsultas.Size = New System.Drawing.Size(732, 973)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1279, 997)
        Me.Controls.Add(Me.lblBuscarLocalidad)
        Me.Controls.Add(Me.txtBoxBuscarLocalidad)
        Me.Controls.Add(Me.dgvConsultas)
        Me.Controls.Add(Me.btnBuscarLocalidad)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Elecciones"
        CType(Me.dgvConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscarLocalidad As Button
    Friend WithEvents dgvConsultas As DataGridView
    Friend WithEvents txtBoxBuscarLocalidad As TextBox
    Friend WithEvents lblBuscarLocalidad As Label
End Class
