Imports CapaNegocio
Imports Entidades
Public Class Form1
    Private _negocio As New Negocio
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscarLocalidad_Click(sender As Object, e As EventArgs) Handles btnBuscarLocalidad.Click
        dgvConsultas.DataSource = _negocio.LocalidadesPorNombre(txtBoxBuscarLocalidad.Text)
    End Sub

    Private Sub btnCenso_Click(sender As Object, e As EventArgs) Handles btnCenso.Click
        dgvConsultas.DataSource = _negocio.PersonasQuePuedenVotarEnUnaFecha(txtBoxCensoNombreLocalidad.Text, CalendarioCenso.SelectionRange.Start.ToShortDateString)
    End Sub
End Class