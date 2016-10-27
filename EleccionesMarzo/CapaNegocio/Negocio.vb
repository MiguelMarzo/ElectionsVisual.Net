Imports CapaDatos
Imports Entidades

Public Class Negocio

    Private _datos As New Datos
    Private Const EDAD_MINIMA As Integer = 18

    Public Function DevolverComunidades() As List(Of Comunidad)

        Return _datos.DevolverComunidades
    End Function
    Public Function DevolverProvincias() As List(Of Provincia)

        Return _datos.DevolverProvincias
    End Function

    Public Function LocalidadesPorNombre(nombre As String) As List(Of Localidad)

        Return _datos.LocalidadesPorNombre(nombre)
    End Function

    Public Function PersonasPorLocalidad(idLocalidad As Integer) As List(Of Persona)
        Return _datos.PersonasPorLocalidad(idLocalidad)
    End Function
    Public Function PersonasQuePuedenVotarEnUnaFecha(idLocalidad As Integer, fechaElecciones As Date) As List(Of Persona)
        Return _datos.PersonasQuePuedenVotarEnUnaFecha(idLocalidad, fechaElecciones, EDAD_MINIMA)
    End Function

End Class