Imports CapaNegocio
Imports Entidades
Public Class Form1
    Private _negocio As New Negocio
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each comunidad In _negocio.DevolverComunidades
            cmbComunidad.Items.Add(comunidad.Nombre)
        Next
        cmbProvincia.Enabled = False
        cmbLocalidades.Enabled = False
    End Sub

    Private Sub btnBuscarLocalidad_Click(sender As Object, e As EventArgs) Handles btnBuscarLocalidad.Click
        dgvConsultas.DataSource = _negocio.LocalidadesPorNombre(txtBoxBuscarLocalidad.Text)
    End Sub

    Private Sub btnCenso_Click(sender As Object, e As EventArgs) Handles btnCenso.Click
        dgvConsultas.DataSource = _negocio.PersonasQuePuedenVotarEnUnaFecha(txtBoxCensoNombreLocalidad.Text, CalendarioCenso.SelectionRange.Start.ToShortDateString)
    End Sub

    Private Sub cmbComunidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbComunidad.SelectedIndexChanged
        cmbProvincia.Items.Clear()
        For Each provincia In _negocio.ProvinciasPorComunidad(cmbComunidad.SelectedItem.ToString)
            cmbProvincia.Items.Add(provincia.Nombre)
        Next
        cmbProvincia.Enabled = True
    End Sub

    Private Sub cmbProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProvincia.SelectedIndexChanged
        dgvConsultas.DataSource = _negocio.LocalidadesPorProvincia(cmbProvincia.SelectedItem.ToString)
        cmbLocalidades.Items.Clear()
        For Each localidad In _negocio.LocalidadesPorProvincia(cmbProvincia.SelectedItem.ToString)
            cmbLocalidades.Items.Add(localidad.nombre.ToString.Trim)
        Next
        cmbLocalidades.Enabled = True
    End Sub

    Private Sub cmbLocalidades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLocalidades.SelectedIndexChanged
        Dim votantes As New List(Of Persona)
        votantes = _negocio.PersonasPorLocalidad(cmbLocalidades.SelectedItem.Trim)
        dgvConsultas.DataSource = votantes
    End Sub
End Class