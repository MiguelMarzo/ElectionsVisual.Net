Imports Entidades
Public Class Datos

    Private dsElecciones As DSElecciones
    Public Sub New()
        CrearDataSetCompleto()
    End Sub
    Private Sub CrearDataSetCompleto()
        dsElecciones = New DSElecciones
        Dim daComunidades As New DSEleccionesTableAdapters.ComunidadTableAdapter
        ' Adaptador para poder traer la table comunidades a la memoria de visual
        daComunidades.Fill(dsElecciones.Comunidad)
        ' El metodo fill llena mediante el adaptador la tabla Comunidad.
        Dim daProvincia As New DSEleccionesTableAdapters.ProvinciaTableAdapter
        daProvincia.Fill(dsElecciones.Provincia)
        ' Hacemos los mismo para la tabla Provincia.
        Dim daLocalidad As New DSEleccionesTableAdapters.LocalidadTableAdapter
        daLocalidad.Fill(dsElecciones.Localidad)
        'Lo mismo con LOCALIDAD
        Dim daPersona As New DSEleccionesTableAdapters.PersonaTableAdapter
        daPersona.Fill(dsElecciones.Persona)
        'Tabién PERSONA
    End Sub

    Public Function DevolverComunidades() As List(Of Comunidad)
        Dim comunidades = From dr In dsElecciones.Comunidad
                          Select New Comunidad(dr.idComunidad, dr.nombre)

        Return comunidades.ToList
    End Function

    Public Function DevolverProvincias() As List(Of Provincia)
        Dim provincias = From dr In dsElecciones.Provincia
                         Select New Provincia(dr.idProvincia, dr.nombre, dr.idComunidad)

        Return provincias.ToList
    End Function

    Public Function LocalidadesPorProvincia(nombreProvincia As String) As List(Of Localidad)
        Dim localidades = From drp In dsElecciones.Localidad
                          Where drp.ProvinciaRow.nombre = nombreProvincia
                          Order By drp.nombre Ascending
                          Select New Localidad(drp.idLocalidad, drp.idProvincia, drp.nombre, drp.habitantes)

        Return localidades.ToList
    End Function

    Public Function LocalidadesPorNombre(nombre As String) As List(Of Localidad)
        Dim localidades = From drp In dsElecciones.Localidad
                          Where drp.nombre.StartsWith(nombre.Trim)
                          Select New Localidad(drp.idLocalidad, drp.idProvincia, drp.nombre, drp.habitantes)

        Return localidades.ToList
    End Function

    Public Function PersonasPorLocalidad(idLocalidad As Integer) As List(Of Persona)
        Dim personas = From drp In dsElecciones.Persona
                       Where drp.idLocalidad = idLocalidad
                       Select New Persona(drp.idPersona, drp.dni, drp.apellido1, drp.apellido1, drp.nombrePila, drp.fechaNac, drp.domicilio, drp.codigoPostal, drp.idLocalidad)

        Return personas.ToList
    End Function

    Public Function PersonasQuePuedenVotarEnUnaFecha(idLocalidad As Integer, fechaElecciones As Date, edadMinima As Integer) As List(Of Persona)
        Dim personas = From drp In dsElecciones.Persona
                       Where drp.idLocalidad = idLocalidad AndAlso DateDiff(DateInterval.Year, fechaElecciones, drp.fechaNac) > edadMinima
                       Select New Persona(drp.idPersona, drp.dni, drp.apellido1, drp.apellido1, drp.nombrePila, drp.fechaNac, drp.domicilio, drp.codigoPostal, drp.idLocalidad)

        Return personas.ToList
    End Function

End Class
