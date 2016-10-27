Public Class Provincia : Implements IEquatable(Of Provincia)

    Public Property Id As String
    Public Property Nombre As String
    Public Property IdComunidad As String
    Public Property NombreComunidad As String
    Public Sub New()

    End Sub
    Public Sub New(id As String, nombre As String, idComunidad As String)
        Me.Id = id
        Me.Nombre = nombre
        Me.IdComunidad = idComunidad
    End Sub

    Public Overloads Function Equals(other As Provincia) As Boolean Implements IEquatable(Of Provincia).Equals
        Return Id.Equals(other.Id)
    End Function
    Public Sub New(id As String, nombre As String, idComunidad As String, nombreComunidad As String)
        Me.Id = id
        Me.Nombre = nombre
        Me.IdComunidad = idComunidad
        Me.NombreComunidad = nombreComunidad
    End Sub
End Class
