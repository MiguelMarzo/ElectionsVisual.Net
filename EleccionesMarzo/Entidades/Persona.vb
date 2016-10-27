
Public Class Persona : Implements IEquatable(Of Persona)

    Public Property Id As String
    Public Property dni As String
    Public Property apellido1 As String
    Public Property apellido2 As String
    Public Property nombrePila As String
    Public Property nombreCompleto As String = nombrePila & " " & apellido1 & " " & apellido2
    Public Property fechaNac As Date
    Public Property domicilio As String
    Public Property codigoPostal As String
    Public Property idLocalidad As Integer
    Public Sub New()

    End Sub
    Public Sub New(id As String, dni As String, apellido1 As String, apellido2 As String, nombrePila As String, fechaNac As Date, domicilio As String, codigoPostal As String, idLocalidad As Integer)
        Me.Id = id
        Me.dni = dni
        Me.apellido1 = apellido1
        Me.apellido2 = apellido2
        Me.nombrePila = nombrePila
        Me.fechaNac = fechaNac
        Me.domicilio = domicilio
        Me.codigoPostal = codigoPostal
        Me.idLocalidad = idLocalidad
    End Sub
    Public Overloads Function Equals(other As Persona) As Boolean Implements IEquatable(Of Persona).Equals
        Return Id.ToUpper.Equals(other.Id.ToUpper)
    End Function
End Class