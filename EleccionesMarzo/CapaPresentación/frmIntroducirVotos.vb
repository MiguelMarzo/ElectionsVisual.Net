Public Class frmIntroducirVotos
    Private Sub frmIntroducirVotos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each comunidad In _negocio.DevolverComunidades
            cmbComunidades.Items.Add(comunidad)
            cmbComunidades.DisplayMember = "nombre"
        Next
        cmbPartidos.Enabled = False
        cmbElecciones.Enabled = False

    End Sub

    Private Sub cmbComunidades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbComunidades.SelectedIndexChanged
        For Each provincia In _negocio.ProvinciasPorComunidad(cmbComunidades.SelectedItem)
            cmbProvincia.Items.Add(provincia)
            cmbProvincia.DisplayMember = "nombre"
        Next
    End Sub

    Private Sub cmbProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProvincia.SelectedIndexChanged
        For Each localidad In _negocio.LocalidadesPorProvincia(cmbProvincia.SelectedItem)
            cmbLocalidades.Items.Add(localidad)
            cmbLocalidades.DisplayMember = "nombre"
        Next
    End Sub

    Private Sub cmbLocalidades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLocalidades.SelectedIndexChanged
        For Each eleccion In _negocio.DevolverElecciones
            cmbElecciones.Items.Add(eleccion)
            cmbElecciones.DisplayMember = "tipo"
        Next
        'Comprueba que hoy haya alguna eleccion, de lo contrario, avisará
        If cmbElecciones.Items.Count > 0 Then
            cmbElecciones.SelectedIndex = 0
        Else
            MessageBox.Show("No hay elecciones... Pista: añade una en la db º_º")
            Exit Sub
        End If
        'Abilita los controles inferiores del formulario para proceder al voto
        For Each partido In _negocio.DevolverPartidosPorLocalidad
            cmbPartidos.Items.Add(partido)
            cmbPartidos.DisplayMember = "nombre"
        Next
        cmbPartidos.Enabled = True
        lblElecciones.Enabled = True
        cmbElecciones.Enabled = True
    End Sub

    Private Sub btnIntroducir_Click(sender As Object, e As EventArgs) Handles btnIntroducir.Click
        Dim numVotos As Integer = 0
        Try
            numVotos = Integer.Parse(txtVotos.Text)
        Catch ex As Exception
            MessageBox.Show("Cantidad de votos no válida")
            Exit Sub
        End Try
        Dim votosActuales As Integer = _negocio.TieneVotos(cmbPartidos.SelectedItem, cmbElecciones.SelectedItem, cmbLocalidades.SelectedItem)
        If votosActuales > 0 Then
            Dim editar = MessageBox.Show("Ese partido ya tiene establecidos " & votosActuales & ". ¿Editar de todas formas?", "holis", MessageBoxButtons.YesNo)
            If editar = DialogResult.Yes Then
                MessageBox.Show(_negocio.introducirVotos(cmbPartidos.SelectedItem, cmbElecciones.SelectedItem, cmbLocalidades.SelectedItem, numVotos))
            End If
        End If

    End Sub
End Class