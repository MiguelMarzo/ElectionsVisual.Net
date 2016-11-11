Imports CapaNegocio
Public Class frmVotar
    Private Sub frmVotar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscarLocalidad_Click(sender As Object, e As EventArgs) Handles btnBuscarLocalidad.Click

        Dim localidadesEncontradas = _negocio.LocalidadesPorNombre(txtBoxBuscarLocalidad.Text)
        If localidadesEncontradas Is Nothing Then
            MessageBox.Show("Localidad no encontrada")
        Else
            cmbLocalidades.Items.Clear()
            For Each localidad In localidadesEncontradas
                cmbLocalidades.Items.Add(localidad.nombre)
            Next
        End If
    End Sub
End Class