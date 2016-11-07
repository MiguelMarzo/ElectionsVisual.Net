Imports CapaDatos
Imports Entidades

Public Class Negocio

    Private _datos As New Datos
    Private Const EDAD_MINIMA As Long = 6574

    Public Function DevolverComunidades() As List(Of Comunidad)

        Return _datos.DevolverComunidades
    End Function
    Public Function DevolverProvincias() As List(Of Provincia)

        Return _datos.DevolverProvincias
    End Function

    Public Function ProvinciasPorComunidad(nombreComunidad As String) As List(Of Provincia)
        Return _datos.ProvinciasPorComunidad(nombreComunidad)
    End Function

    Public Function LocalidadesPorProvincia(nombreProvincia As String) As List(Of Localidad)
        Return _datos.LocalidadesPorProvincia(nombreProvincia)
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

End Class