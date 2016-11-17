Imports Entidades
Public Class Datos

    Private dsElecciones As DSElecciones
    Dim daPersona As New DSEleccionesTableAdapters.PersonaTableAdapter
    Public Sub iki()
        Dim cadCon As String = My.Settings.EleccionesMarzoConnectionString
    End Sub
    Public Sub New()
        CrearDataSetCompleto()
    End Sub
    Private Sub CrearDataSetCompleto()
        dsElecciones = New DSElecciones
        Try
            ' Adaptador para poder traer la table comunidades a la memoria de visual
            Dim daComunidades As New DSEleccionesTableAdapters.ComunidadTableAdapter
            daComunidades.Fill(dsElecciones.Comunidad) ' El metodo fill llena mediante el adaptador la tabla Comunidad.

            'Adaptador para Provincia
            Dim daProvincia As New DSEleccionesTableAdapters.ProvinciaTableAdapter
            daProvincia.Fill(dsElecciones.Provincia)

            'Adaptador para Localidad
            Dim daLocalidad As New DSEleccionesTableAdapters.LocalidadTableAdapter
            daLocalidad.Fill(dsElecciones.Localidad)

            'Adaptador para Elecciones
            Dim daElecciones As New DSEleccionesTableAdapters.EleccionesTableAdapter
            daElecciones.Fill(dsElecciones.Elecciones)

            'Adaptador para Partidos
            Dim daPartidos As New DSEleccionesTableAdapters.PartidosTableAdapter
            daPartidos.Fill(dsElecciones.Partidos)

            'Adaptador para Votos
            Dim daVotos As New DSEleccionesTableAdapters.VotosTableAdapter
            daVotos.Fill(dsElecciones.Votos)

            'Adaptador para PartidosPorLocalidades
            Dim daPartidosPorLocalidadesYElecciones As New DSEleccionesTableAdapters.PartidosPorLocalidadTableAdapter
            daPartidosPorLocalidadesYElecciones.Fill(dsElecciones.PartidosPorLocalidad)

        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Public Function DevolverComunidades() As List(Of Comunidad)
        Dim comunidades = From dr In dsElecciones.Comunidad
                          Order By dr.nombre Descending
                          Select New Comunidad(dr.idComunidad, dr.nombre)

        Return comunidades.ToList
    End Function

    Public Function DevolverProvincias() As List(Of Provincia)
        Dim provincias = From dr In dsElecciones.Provincia
                         Order By dr.nombre Descending
                         Select New Provincia(dr.idProvincia, dr.nombre, dr.idComunidad)

        Return provincias.ToList
    End Function

    Public Function ProvinciasPorComunidad(comunidad As Comunidad) As List(Of Provincia)
        Dim provincias = From drp In dsElecciones.Provincia
                         Where drp.idComunidad = comunidad.Id
                         Order By drp.nombre Descending
                         Select New Provincia(drp.idProvincia, drp.nombre, drp.idComunidad)

        Return provincias.ToList
    End Function

    Public Function DevolverLocalidades() As List(Of Localidad)
        Dim localidades = From drLocalidades In dsElecciones.Localidad
                          Order By drLocalidades.nombre Descending
                          Select New Localidad(drLocalidades.idLocalidad, drLocalidades.nombre, drLocalidades.idProvincia)

        Return localidades.ToList
    End Function

    Public Function LocalidadesPorProvincia(provincia As Provincia) As List(Of Localidad)
        Dim localidades = From drp In dsElecciones.Localidad
                          Where drp.idProvincia = provincia.Id
                          Order By drp.nombre Descending
                          Select New Localidad(drp.idLocalidad, drp.nombre, drp.idProvincia)

        Return localidades.ToList
    End Function

    Public Function LocalidadesPorNombre(nombre As String) As List(Of Localidad)
        Dim localidades = From drp In dsElecciones.Localidad
                          Where drp.nombre.ToUpper.StartsWith(nombre.Trim.ToUpper)
                          Order By drp.nombre Descending
                          Select New Localidad(drp.idLocalidad, drp.nombre, drp.idProvincia)

        Return localidades.ToList
    End Function

    Public Function PersonasPorLocalidad(idLocalidad As String) As List(Of Persona)
        If Not IsNothing(daPersona) Then
            daPersona.FillBy(dsElecciones.Persona, idLocalidad)
        End If
        Dim personas = From drp In dsElecciones.Persona
                       Where drp.idLocalidad = idLocalidad
                       Order By drp.nombre
                       Select New Persona(drp.idPersona, drp.dni, drp.apellido1.Trim, drp.apellido2.Trim, drp.nombrePila.Trim, drp.fechaNac, drp.domicilio.Trim, drp.codigoPostal.Trim, drp.idLocalidad)

        Return personas.ToList
    End Function

    Public Function PersonasQuePuedenVotarEnUnaFecha(idLocalidad As String, fechaElecciones As Date, edadMinima As Long) As List(Of Persona)
        If Not IsNothing(daPersona) Then
            daPersona.FillBy(dsElecciones.Persona, idLocalidad)
        End If
        Dim personas = From drp In dsElecciones.Persona
                       Where drp.idLocalidad = idLocalidad AndAlso puedeVotar(drp.fechaNac, fechaElecciones)
                       Order By drp.nombre
                       Select New Persona(drp.idPersona, drp.dni, drp.apellido1.Trim, drp.apellido2.Trim, drp.nombrePila.Trim, drp.fechaNac, drp.domicilio.Trim, drp.codigoPostal.Trim, drp.idLocalidad)

        Return personas.ToList
    End Function

    Private Function PuedeVotar(fechaNac As Date, fechaElecciones As Date) As Boolean
        Dim años = fechaElecciones.Year - fechaNac.Year
        Dim mes = fechaElecciones.Month - fechaNac.Month
        Dim day = fechaElecciones.Day - fechaNac.Day
        If años = 18 And mes = 0 Then
            If day >= 0 Then
                Return True
            Else
                Return False
            End If
        End If
        If años > 18 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Votar(ByVal idPersona As Integer, ByVal idElecciones As Integer, ByVal idPartido As Integer) As Boolean
        Try
            Dim voto As DataRow = dsElecciones.Votos.NewRow()
            voto("idPersona") = idPersona
            voto("idElecciones") = idElecciones
            voto("idPartido") = idPartido
            dsElecciones.Votos.AddVotosRow(voto)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function DevolverPartidos() As List(Of Partido)
        Dim partidos = From drPartidos In dsElecciones.Partidos
                       Order By drPartidos.nombre Descending
                       Select New Partido(drPartidos.idPartido, drPartidos.nombre)

        Return partidos.ToList

    End Function


End Class