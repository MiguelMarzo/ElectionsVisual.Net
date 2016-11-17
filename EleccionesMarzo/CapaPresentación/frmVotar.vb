Imports CapaNegocio
Imports Entidades
Public Class frmVotar

    Private Sub frmVotar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each partido In _negocio.DevolverPartidos
            cmbPartidos.Items.Add(partido)
            cmbPartidos.DisplayMember = "nombre"
        Next
        txtDni.Enabled = False
        cmbPartidos.Enabled = False
        btnVotar.Enabled = False
        cmbElecciones.Enabled = False
        For Each eleccion In _negocio.eleccionesDeHoy
            cmbElecciones.Items.Add(eleccion)
            cmbElecciones.DisplayMember = "tipo"
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
            cmbLocalidades.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmbLocalidades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLocalidades.SelectedIndexChanged
        txtDni.Enabled = True
        cmbPartidos.Enabled = True
        btnVotar.Enabled = True
        lblElecciones.Enabled = True
        cmbElecciones.Enabled = True
    End Sub
    Private Sub btnVotar_Click(sender As Object, e As EventArgs) Handles btnVotar.Click
        If cmbElecciones.SelectedItem Is Nothing Or cmbPartidos.SelectedItem Is Nothing Or lblDni.Text = Nothing Then
            MessageBox.Show("Error, introduce localidad, dni y partido al que votar")
            Exit Sub
        Else
            'Dim per As Persona

            'per = _negocio.devolverIdDePersonaPorDNI(txtDni.Text)
            Try
            Catch ex As Exception
                MessageBox.Show("DNI no encontrado")
                Exit Sub
            End Try
            Dim eleccion As Elecciones = cmbElecciones.SelectedItem
            Dim partido As Partido = cmbPartidos.SelectedItem

            Dim exito As Boolean = _negocio.Votar(1, eleccion.id, partido.id)
            Try
            Catch ex As Exception
                MessageBox.Show("Error al votar")
            End Try

        End If
    End Sub
End Class