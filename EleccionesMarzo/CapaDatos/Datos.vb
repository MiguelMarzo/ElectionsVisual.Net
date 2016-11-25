Imports Entidades
Public Class Datos

    Private dsElecciones As DSElecciones
    Private daVotos As New DSEleccionesTableAdapters.VotosTableAdapter
    Private daPartidosPorLocalidadesYElecciones As New DSEleccionesTableAdapters.PartidosPorLocalidadTableAdapter
    Private daPersona As New DSEleccionesTableAdapters.PersonaTableAdapter
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

            daVotos.Fill(dsElecciones.Votos)

            'Adaptador para PartidosPorLocalidades

            daPartidosPorLocalidadesYElecciones.Fill(dsElecciones.PartidosPorLocalidad)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Función para obtener todas las Comunidades
    Public Function DevolverComunidades() As List(Of Comunidad)
        Dim comunidades = From dr In dsElecciones.Comunidad
                          Order By dr.nombre Descending
                          Select New Comunidad(dr.idComunidad, dr.nombre)

        Return comunidades.ToList
    End Function

    'Función para obtener todas las Provincias
    Public Function DevolverProvincias() As List(Of Provincia)
        Dim provincias = From dr In dsElecciones.Provincia
                         Order By dr.nombre Descending
                         Select New Provincia(dr.idProvincia, dr.nombre, dr.idComunidad)

        Return provincias.ToList
    End Function

    'Función para obtener todas las Localidades
    Public Function DevolverLocalidades() As List(Of Localidad)
        Dim localidades = From drLocalidades In dsElecciones.Localidad
                          Order By drLocalidades.nombre Descending
                          Select New Localidad(drLocalidades.idLocalidad, drLocalidades.nombre, drLocalidades.idProvincia)

        Return localidades.ToList
    End Function

    'Función para obtener todos los Partidos
    Public Function DevolverPartidos() As List(Of Partido)
        Dim partidos = From drPartidos In dsElecciones.Partidos
                       Order By drPartidos.nombre Descending
                       Select New Partido(drPartidos.idPartido, drPartidos.nombre)

        Return partidos.ToList

    End Function
    Public Function DevolverElecciones() As List(Of Elecciones)
        Dim elecciones = From drElecciones In dsElecciones.Elecciones
                         Order By drElecciones.fecha
                         Select New Elecciones(drElecciones.idElecciones, drElecciones.fecha, drElecciones.tipo)

        Return elecciones.ToList
    End Function

    'Función para obtener las Provincias que pertenecen a una Comunidad
    Public Function ProvinciasPorComunidad(comunidad As Comunidad) As List(Of Provincia)
        Dim provincias = From drp In dsElecciones.Provincia
                         Where drp.idComunidad = comunidad.Id
                         Order By drp.nombre Descending
                         Select New Provincia(drp.idProvincia, drp.nombre, drp.idComunidad)

        Return provincias.ToList
    End Function

    'Función para obtener todas las Localidades de una Provincia
    Public Function LocalidadesPorProvincia(provincia As Provincia) As List(Of Localidad)
        Dim localidades = From drp In dsElecciones.Localidad
                          Where drp.idProvincia = provincia.Id
                          Order By drp.nombre Descending
                          Select New Localidad(drp.idLocalidad, drp.nombre, drp.idProvincia)

        Return localidades.ToList
    End Function

    'Función que busca y devuelve las Localidades cuyo nombre empieze o sea el proporcionado
    Public Function LocalidadesPorNombre(nombre As String) As List(Of Localidad)
        Dim localidades = From drp In dsElecciones.Localidad
                          Where drp.nombre.ToUpper.StartsWith(nombre.Trim.ToUpper)
                          Order By drp.nombre Descending
                          Select New Localidad(drp.idLocalidad, drp.nombre, drp.idProvincia)

        Return localidades.ToList
    End Function

    'Función que devuelve las Personas residentes en una Localidad independientemente de si pueden votar o no
    Public Function PersonasPorLocalidad(idLocalidad As String) As List(Of Persona)
        If dsElecciones.Persona.Rows.Count = 0 OrElse TryCast(dsElecciones.Persona.Rows(0), DSElecciones.PersonaRow).idLocalidad <> idLocalidad Then
            daPersona.FillByIdLocalidad(dsElecciones.Persona, idLocalidad)
        End If
        Dim personas = From drp In dsElecciones.Persona
                       Where drp.idLocalidad = idLocalidad
                       Order By drp.nombre
                       Select New Persona(drp.idPersona, drp.dni, drp.apellido1.Trim, drp.apellido2.Trim, drp.nombrePila.Trim, drp.fechaNac, drp.domicilio.Trim, drp.codigoPostal.Trim, drp.idLocalidad)

        Return personas.ToList
    End Function

    'Función que devuelve las Personas de una Localidad concreta que pueden Votar en una Fecha específica con una EdadMinima índicada
    Public Function PersonasQuePuedenVotarEnUnaFecha(idLocalidad As String, fechaElecciones As Date, edadMinima As Long) As List(Of Persona)
        If dsElecciones.Persona.Rows.Count = 0 OrElse TryCast(dsElecciones.Persona.Rows(0), DSElecciones.PersonaRow).idLocalidad <> idLocalidad Then
            daPersona.FillByIdLocalidad(dsElecciones.Persona, idLocalidad)
        End If
        Dim personas = From drp In dsElecciones.Persona
                       Where drp.idLocalidad = idLocalidad AndAlso PuedeVotar(drp.fechaNac, fechaElecciones)
                       Order By drp.nombre
                       Select New Persona(drp.idPersona, drp.dni, drp.apellido1.Trim, drp.apellido2.Trim, drp.nombrePila.Trim, drp.fechaNac, drp.domicilio.Trim, drp.codigoPostal.Trim, drp.idLocalidad)

        Return personas.ToList
    End Function

    'Función que comprueba si una Persona puede Votar en una Fecha comparandola con la Fecha de nacimiento de esa Persona
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

    'Función que ejecuta una instrucción de Insert en el DataSet y luego en la BD, en la tabla Voto
    Public Function Votar(ByVal per As Persona, ByVal eleccion As Elecciones, ByVal localidad As Localidad, ByVal partido As Partido) As Boolean
        'Primero comprueba si esa persona, de esa localidad puede votar, es  decir, si es mayor de 18 años
        'Devolvería False si no fuese así o si la persona no perteneciese a la Localidad dada
        Try
            If PersonasQuePuedenVotarEnUnaFecha(localidad.Id, eleccion.fecha, 18).Contains(per) Then
                Dim votos = From drVotos In dsElecciones.Votos
                            Where drVotos.PersonaRow.dni = per.dni AndAlso drVotos.idElecciones = eleccion.id
                            Select New Voto(drVotos.idPersona, drVotos.idElecciones)
                'Si la Persona puede votar en esa Localidad se comprueba si ya ha votado en estas Elecciones concretas antes
                If (votos.ToList.Count <> 0) Then
                    Return False
                Else
                    'Si todo está correcto, se realiza la actualización en el DataSet
                    Dim dtVotos As DataTable
                    dtVotos = dsElecciones.Votos

                    Dim drVoto As DataRow = dtVotos.NewRow
                    drVoto("idPersona") = per.Id
                    drVoto("idElecciones") = eleccion.id
                    dtVotos.Rows.Add(drVoto)
                    'Y por último se da la orden de Update y AcceptChanges para trasladar los cambios sufridos por el DataSet a la BD
                    daVotos.Update(drVoto)

                    dsElecciones.AcceptChanges()

                    Return True
                End If
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function IntroducirVotos(ByVal partido As Partido, ByVal eleccion As Elecciones, ByVal localidad As Localidad, ByVal numVotos As Integer)
        Dim dtPartidosPorLocalidad As DataTable
        dtPartidosPorLocalidad = dsElecciones.PartidosPorLocalidad
        Dim drPartidoPorLocalidad As DataRow = dtPartidosPorLocalidad.NewRow
        Try
            'dataset1.Tables(0).Rows(4).Item(0) = "Wingtip Toys"
            'dsElecciones.PartidosPorLocalidad.votosTotalesColumn = 123

            For Each par In dsElecciones.PartidosPorLocalidad.Rows

            Next
            'dsElecciones.Tables("PartidosPorLocalidad").Rows
            'drPartidoPorLocalidad("idPartido") = partido.id
            drPartidoPorLocalidad("idLocalidad") = localidad.Id
            drPartidoPorLocalidad("votosTotales") = numVotos
            drPartidoPorLocalidad("idElecciones") = eleccion.id
            dtPartidosPorLocalidad.Rows.Add(drPartidoPorLocalidad)
            'daPartidosPorLocalidadesYElecciones.Update(drPartidoPorLocalidad)
            'dsElecciones.AcceptChanges()
        Catch ex As Exception

        End Try

        Return True
    End Function
    'Función para obetener aquellas Elecciones que se celebren en el dia de Hoy
    Public Function EleccionesPorLocalidad() As List(Of Elecciones)
        Dim elecciones = From drPartidosPorLocalidad In dsElecciones.PartidosPorLocalidad
                         Where drPartidosPorLocalidad.EleccionesRow.fecha >= Today
                         Select New Elecciones(drPartidosPorLocalidad.idElecciones,
                             drPartidosPorLocalidad.EleccionesRow.fecha,
                             drPartidosPorLocalidad.EleccionesRow.tipo)

        Return elecciones.ToList
    End Function

    'Función para obtener el objecto Persona cuyo DNI es dado como parámetro
    'El parámetro localidad solo es para poder hacer el FillByIdLocalidad
    Public Function DevolverPersonaPorDNI(dni As String, localidad As Localidad) As List(Of Persona)
        If dsElecciones.Persona.Rows.Count = 0 OrElse TryCast(dsElecciones.Persona.Rows(0), DSElecciones.PersonaRow).idLocalidad <> localidad.Id Then
            daPersona.FillByIdLocalidad(dsElecciones.Persona, localidad.Id)
        End If
        Dim per = From drPersonas In dsElecciones.Persona
                  Where drPersonas.dni.Trim = dni.Trim
                  Select New Persona(drPersonas.idLocalidad, drPersonas.dni, drPersonas.apellido1, drPersonas.apellido2, drPersonas.nombrePila,
                      drPersonas.fechaNac, drPersonas.domicilio, drPersonas.codigoPostal, drPersonas.idLocalidad)

        Return per.ToList
    End Function

    Public Function Finalizar() As String
        If dsElecciones.HasChanges Then
            Dim partidosSinVotos = From drPartidos In dsElecciones.PartidosPorLocalidad
                                   Where drPartidos.votosTotales = 0
                                   Select New PartidosPorLocalidad(drPartidos.idPartido, drPartidos.idLocalidad,
                                       drPartidos.votosTotales, drPartidos.idElecciones)

            If partidosSinVotos.ToList.Count > 0 Then
                Dim partNoVotos As String = "Los partidos: "
                For Each partido In partidosSinVotos.ToList
                    partNoVotos += partido.idPartido
                Next
                partNoVotos += " no tienen votos"
                Return partNoVotos
            Else
                Dim votosDeTodosLosPartidos As Integer = 0
                For Each localidad In DevolverLocalidades()
                    For Each eleccion In DevolverElecciones()
                        For Each partido In (From drPartidos In dsElecciones.PartidosPorLocalidad).ToList
                            votosDeTodosLosPartidos += partido.votosTotales
                        Next
                        If votosDeTodosLosPartidos > PersonasQuePuedenVotarEnUnaFecha(localidad.Id,
                                                                                   eleccion.fecha,
                                                                                   18).ToList.Count Then
                            Return "Error, hay más votos que población censada"

                        Else
                            dsElecciones.AcceptChanges()
                            Return "Cambios aceptados"
                        End If
                    Next

                Next

            End If

        Else
            Return "Error, no hay cambios"
        End If


    End Function


End Class