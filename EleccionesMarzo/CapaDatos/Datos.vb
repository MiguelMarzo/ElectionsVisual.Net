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

    Public Function ProvinciasPorComunidad(nombreComunidad As String) As List(Of Provincia)
        Dim provincias = From drp In dsElecciones.Provincia
                         Where drp.ComunidadRow.nombre = nombreComunidad
                         Order By drp.nombre Ascending
                         Select New Provincia(drp.idProvincia, drp.nombre, drp.idComunidad)

        Return provincias.ToList
    End Function

    Public Function LocalidadesPorProvincia(nombreProvincia As String) As List(Of Localidad)
        Dim localidades = From drp In dsElecciones.Localidad
                          Where drp.ProvinciaRow.nombre = nombreProvincia
                          Order By drp.nombre Ascending
                          Select New Localidad(drp.idLocalidad, drp.nombre, drp.idProvincia, drp.habitantes)

        Return localidades.ToList
    End Function

    Public Function LocalidadesPorNombre(nombre As String) As List(Of Localidad)
        Dim localidades = From drp In dsElecciones.Localidad
                          Where drp.nombre.ToUpper.StartsWith(nombre.Trim.ToUpper)
                          Select New Localidad(drp.idLocalidad, drp.nombre, drp.habitantes, drp.idProvincia)

        Return localidades.ToList
    End Function

    Public Function PersonasPorLocalidad(nombreLocalidad As String) As List(Of Persona)
        Dim personas = From drp In dsElecciones.Persona
                       Where drp.LocalidadRow.nombre.ToUpper.Trim = nombreLocalidad.ToUpper.Trim
                       Select New Persona(drp.idPersona, drp.dni, drp.apellido1.Trim, drp.apellido2.Trim, drp.nombrePila.Trim, drp.fechaNac, drp.domicilio.Trim, drp.codigoPostal.Trim, drp.idLocalidad)

        Return personas.ToList
    End Function

    Public Function PersonasQuePuedenVotarEnUnaFecha(nombreLocalidad As String, fechaElecciones As Date, edadMinima As Long) As List(Of Persona)
        Dim personas = From drp In dsElecciones.Persona
                       Where drp.LocalidadRow.nombre.TrimEnd.ToUpper = nombreLocalidad.ToUpper AndAlso DateDiff(DateInterval.Year, drp.fechaNac, fechaElecciones) > edadMinima
                       Select New Persona(drp.idPersona, drp.dni, drp.apellido1.Trim, drp.apellido2.Trim, drp.nombrePila.Trim, drp.fechaNac, drp.domicilio.Trim, drp.codigoPostal.Trim, drp.idLocalidad)

        Return personas.ToList
    End Function
End Class
