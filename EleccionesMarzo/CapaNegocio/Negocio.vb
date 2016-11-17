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
    Public Function Votar(ByVal idPersona As Integer, ByVal idElecciones As Integer, ByVal idPartido As Integer)
        Return _datos.Votar(idPersona, idElecciones, idPartido)
    End Function
End Class