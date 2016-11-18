Imports CapaDatos
Imports Entidades

Public Class Negocio

    Private _datos As New Datos
    Private Const EDAD_MINIMA As Long = 6574

    Public Function DevolverComunidades() As List(Of Comunidad)

        Return _datos.DevolverComunidades
    End Function

    Public Function DevolverPartidos() As List(Of Partido)
        Return _datos.DevolverPartidos
    End Function

    Public Function DevolverLocalidades() As List(Of Localidad)
        Return _datos.DevolverLocalidades
    End Function
    Public Function DevolverProvincias() As List(Of Provincia)

        Return _datos.DevolverProvincias
    End Function

    Public Function ProvinciasPorComunidad(comunidad As Comunidad) As List(Of Provincia)
        Return _datos.ProvinciasPorComunidad(comunidad)
    End Function

    Public Function LocalidadesPorProvincia(provincia As Provincia) As List(Of Localidad)
        Return _datos.LocalidadesPorProvincia(provincia)
    End Function

    Public Function LocalidadesPorNombre(nombre As String) As List(Of Localidad)

        Return _datos.LocalidadesPorNombre(nombre)
    End Function

    Public Function PersonasPorLocalidad(idLocalidad As String) As List(Of Persona)
        Return _datos.PersonasPorLocalidad(idLocalidad)
    End Function
    Public Function PersonasQuePuedenVotarEnUnaFecha(idLocalidad As String, fechaElecciones As Date) As List(Of Persona)
        Return _datos.PersonasQuePuedenVotarEnUnaFecha(idLocalidad, fechaElecciones, EDAD_MINIMA)
    End Function
    Public Function Votar(ByVal per As Persona, ByVal elecciones As Elecciones, ByVal localidad As Localidad)
        Return _datos.Votar(per, elecciones, localidad)
    End Function
    Public Function eleccionesDeHoy() As List(Of Elecciones)
        Return _datos.eleccionesDeHoy()
    End Function
    Public Function devolverPersonaPorDNI(dni As String) As Persona
        Return _datos.devolverPersonaPorDNI(dni)(0)
    End Function


End Class