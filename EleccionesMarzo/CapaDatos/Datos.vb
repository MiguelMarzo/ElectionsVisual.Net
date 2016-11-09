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

    Public Function ProvinciasPorComunidad(nombreComunidad As String) As List(Of Provincia)
        Dim provincias = From drp In dsElecciones.Provincia
                         Where drp.ComunidadRow.nombre = nombreComunidad
                         Order By drp.nombre Descending
                         Select New Provincia(drp.idProvincia, drp.nombre, drp.idComunidad)

        Return provincias.ToList
    End Function

    Public Function LocalidadesPorProvincia(nombreProvincia As String) As List(Of Localidad)
        Dim localidades = From drp In dsElecciones.Localidad
                          Where drp.ProvinciaRow.nombre = nombreProvincia
                          Order By drp.nombre Descending
                          Select New Localidad(drp.idLocalidad, drp.nombre, drp.idProvincia, 0)

        Return localidades.ToList
    End Function

    Public Function LocalidadesPorNombre(nombre As String) As List(Of Localidad)
        Dim localidades = From drp In dsElecciones.Localidad
                          Where drp.nombre.ToUpper.StartsWith(nombre.Trim.ToUpper)
                          Order By drp.nombre Descending
                          Select New Localidad(drp.idLocalidad, drp.nombre, 0, drp.idProvincia)

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
        'DateDiff(DateInterval.Day, drp.fechaNac, fechaElecciones) >= edadMinima
        Dim personas = From drp In dsElecciones.Persona
                       Where drp.idLocalidad = idLocalidad AndAlso puedeVotar(drp.fechaNac, fechaElecciones)
                       Order By drp.nombre
                       Select New Persona(drp.idPersona, drp.dni, drp.apellido1.Trim, drp.apellido2.Trim, drp.nombrePila.Trim, drp.fechaNac, drp.domicilio.Trim, drp.codigoPostal.Trim, drp.idLocalidad)

        Return personas.ToList
    End Function

    Private Function puedeVotar(fechaNac As Date, fechaElecciones As Date) As Boolean
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
End Class