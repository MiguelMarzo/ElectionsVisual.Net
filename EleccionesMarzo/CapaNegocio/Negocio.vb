Imports CapaDatos
Imports Entidades

Public Class Negocio

    Private _datos As New Datos
    Private Const EDAD_MINIMA As Long = 6574

    Public Function DevolverComunidades() As List(Of Comunidad)

        Return _datos.DevolverComunidades
    End Function

    Public Function DevolverPartidosPorLocalidad() As List(Of Partido)
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
    Public Function Votar(ByVal per As Persona, ByVal elecciones As Elecciones, ByVal localidad As Localidad, ByVal partido As Partido)
        Return _datos.Votar(per, elecciones, localidad, partido)
    End Function
    Public Function eleccionesPorLocalidad() As List(Of Elecciones)
        Return _datos.eleccionesPorLocalidad()
    End Function
    Public Function devolverPersonaPorDNI(dni As String, localidad As Localidad) As Persona
        Return _datos.devolverPersonaPorDNI(dni, localidad)(0)
    End Function

    Public Function introducirVotos(ByVal partido As Partido, ByVal eleccion As Elecciones, ByVal localidad As Localidad, ByVal numVotos As Integer)
        Return _datos.introducirVotos(partido, eleccion, localidad, numVotos)
    End Function
    Public Function DevolverElecciones() As List(Of Elecciones)
        Return _datos.DevolverElecciones()
    End Function

    Public Function Finalizar() As String
        Return _datos.Finalizar()
    End Function
    Public Function TieneVotos(ByVal partido As Partido, ByVal eleccion As Elecciones, ByVal localidad As Localidad) As Integer
        Return _datos.TieneVotos(partido, eleccion, localidad)
    End Function

End Class