Imports CapaNegocio
Imports Entidades
Public Class frmInicio
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each comunidad In _negocio.DevolverComunidades
            cmbComunidad.Items.Add(comunidad)
            cmbComunidad.DisplayMember = "nombre"
        Next
        cmbProvincia.Enabled = False
        cmbLocalidades.Enabled = False
    End Sub

    Private Sub btnBuscarLocalidad_Click(sender As Object, e As EventArgs) Handles btnBuscarLocalidad.Click
        dgvConsultas.DataSource = _negocio.LocalidadesPorNombre(txtBoxBuscarLocalidad.Text)
    End Sub

    Private Sub btnCenso_Click(sender As Object, e As EventArgs) Handles btnCenso.Click
        Dim localidad = _negocio.LocalidadesPorNombre(txtBoxCensoNombreLocalidad.Text)
        Dim idLocalidad = localidad(0).Id
        dgvConsultas.DataSource = _negocio.PersonasQuePuedenVotarEnUnaFecha(idLocalidad, CalendarioCenso.SelectionRange.Start.ToShortDateString)
    End Sub

    Private Sub cmbComunidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbComunidad.SelectedIndexChanged
        cmbProvincia.Items.Clear()
        Dim com As Comunidad = cmbComunidad.SelectedItem
        For Each provincia In _negocio.ProvinciasPorComunidad(com)
            cmbProvincia.Items.Add(provincia)
            cmbProvincia.DisplayMember = "nombre"
        Next
        cmbProvincia.Enabled = True
    End Sub

    Private Sub cmbProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProvincia.SelectedIndexChanged
        Dim prov As Provincia = cmbProvincia.SelectedItem
        Dim localidades As New List(Of Localidad)
        localidades = _negocio.LocalidadesPorProvincia(prov)
        dgvConsultas.DataSource = localidades
        cmbLocalidades.Items.Clear()
        For Each localidad In _negocio.LocalidadesPorProvincia(prov)
            cmbLocalidades.Items.Add(localidad)
            cmbLocalidades.DisplayMember = "nombre"
        Next
        cmbLocalidades.Enabled = True
    End Sub

    Private Sub cmbLocalidades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLocalidades.SelectedIndexChanged
        Dim votantes As New List(Of Persona)
        Dim loc As Localidad = cmbLocalidades.SelectedItem
        dgvConsultas.DataSource = _negocio.PersonasQuePuedenVotarEnUnaFecha(loc.Id, Today)
    End Sub

    Private Sub btnVotar_Click(sender As Object, e As EventArgs) Handles btnVotar.Click
        frmVotar.Show()
    End Sub
End Class