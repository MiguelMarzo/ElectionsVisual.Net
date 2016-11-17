Imports CapaNegocio
Public Class frmVotar
    Private Sub frmVotar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each partido In _negocio.DevolverPartidos
            cmbPartidos.Items.Add(partido.nombre)
        Next
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

    Private Sub btnVotar_Click(sender As Object, e As EventArgs) Handles btnVotar.Click
        If cmbLocalidades.SelectedItem = Nothing Or cmbPartidos.SelectedItem = Nothing Or lblDni.Text = Nothing Then
            MessageBox.Show("Error, introduce localidad, dni y partido al que votar")
            Exit Sub
        Else
            'TODO DNI-ID
            Dim exito As Boolean = _negocio.Votar(txtDni.Text, )
        End If
    End Sub
End Class