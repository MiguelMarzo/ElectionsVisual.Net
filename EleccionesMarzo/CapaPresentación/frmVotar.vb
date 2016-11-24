Imports CapaNegocio
Imports Entidades
Public Class frmVotar

    Private Sub frmVotar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each comunidad In _negocio.DevolverComunidades
            cmbComunidades.Items.Add(comunidad)
            cmbComunidades.DisplayMember = "nombre"
        Next
        txtDni.Enabled = False
        cmbPartidos.Enabled = False
        btnVotar.Enabled = False
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
        For Each eleccion In _negocio.eleccionesPorLocalidad
            cmbElecciones.Items.Add(eleccion)
            cmbElecciones.DisplayMember = "tipo"
        Next
        'Comprueba que hoy haya alguna eleccion posible para votar, de lo contrario, avisará
        If cmbElecciones.Items.Count > 0 Then
            cmbElecciones.SelectedIndex = 0
        Else
            MessageBox.Show("No hay elecciones en esta Pista: añade una en la db º_º")
            Exit Sub
        End If
        'Abilita los controles inferiores del formulario para proceder al voto
        For Each partido In _negocio.DevolverPartidosPorLocalidad
            cmbPartidos.Items.Add(partido)
            cmbPartidos.DisplayMember = "nombre"
        Next
        txtDni.Enabled = True
        cmbPartidos.Enabled = True
        btnVotar.Enabled = True
        lblElecciones.Enabled = True
        cmbElecciones.Enabled = True
    End Sub
    Private Sub btnVotar_Click(sender As Object, e As EventArgs) Handles btnVotar.Click
        'Comprueba si los campos necesarios para el voto han sido rellenados/seleccionados
        'En este caso son "Elecciones", "Partidos" y "DNI"
        If cmbElecciones.SelectedItem Is Nothing Or cmbPartidos.SelectedItem Is Nothing Or lblDni.Text = Nothing Then
            MessageBox.Show("Error, introduce localidad, dni y partido al que votar")
            Exit Sub
        Else
            'En caso de que si que se hayan proporcionado los datos se comprueba si existe una persona con ese DNI
            'De no ser así avisará con un msgBox y cancelará el voto
            Dim per As Persona
            Try
                per = _negocio.devolverPersonaPorDNI(txtDni.Text, cmbLocalidades.SelectedItem)
            Catch ex As Exception
                MessageBox.Show("DNI no encontrado")
                Exit Sub
            End Try

            'Una vez conotrolado que esa persona exista se llama al método votar, el cual controla los demás fallos que
            'puedan ocurrir durante su ejecución, si fallase, el catch recogería la excepción y avisaría de que el voto no
            'se ha efectuado correctamente
            Try
                Dim exito As Boolean = _negocio.Votar(per, cmbElecciones.SelectedItem, cmbLocalidades.SelectedItem, cmbPartidos.SelectedItem)
                If exito = True Then MessageBox.Show("Voto realizado correctamente") Else MessageBox.Show("Error al votar")
            Catch ex As Exception
                MessageBox.Show("Error al votar")
            End Try
        End If
    End Sub

    Private Sub btnIntroducirVotos_Click(sender As Object, e As EventArgs) Handles btnIntroducirVotos.Click
        frmIntroducirVotos.Show()
    End Sub
End Class