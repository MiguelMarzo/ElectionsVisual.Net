Imports CapaNegocio
Imports Entidades
Public Class Form1
    Private _negocio As New Negocio
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim comunidades As New List(Of Comunidad)
        comunidades = _negocio.DevolverComunidades
        For Each comunidad In comunidades
            cmbComunidad.Items.Add(comunidad.Nombre)
        Next
    End Sub

    Private Sub btnBuscarLocalidad_Click(sender As Object, e As EventArgs) Handles btnBuscarLocalidad.Click
        dgvConsultas.DataSource = _negocio.LocalidadesPorNombre(txtBoxBuscarLocalidad.Text)
    End Sub

    Private Sub btnCenso_Click(sender As Object, e As EventArgs) Handles btnCenso.Click
        dgvConsultas.DataSource = _negocio.PersonasQuePuedenVotarEnUnaFecha(txtBoxCensoNombreLocalidad.Text, CalendarioCenso.SelectionRange.Start.ToShortDateString)
    End Sub

    Private Sub cmbComunidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbComunidad.SelectedIndexChanged
        cmbProvincia.Items.Clear()
        Dim provincias As New List(Of Provincia)
        provincias = _negocio.ProvinciasPorComunidad(cmbComunidad.SelectedItem.ToString.Trim)
        For Each provincia In provincias
            cmbProvincia.Items.Add(provincia.Nombre)
        Next
    End Sub

    Private Sub cmbProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProvincia.SelectedIndexChanged
        Dim localidades As New List(Of Localidad)
        localidades = _negocio.LocalidadesPorProvincia(cmbProvincia.SelectedItem.ToString.Trim)
        dgvConsultas.DataSource = localidades
    End Sub
End Class