Public Class Comunidad : Implements IEquatable(Of Comunidad)

    Public Property Id As String
    Public Property Nombre As String

    Public Sub New()

    End Sub
    Public Sub New(id As String, nombre As String)
        Me.Id = id
        Me.Nombre = nombre
    End Sub

    Public Overloads Function Equals(other As Comunidad) As Boolean Implements IEquatable(Of Comunidad).Equals
        Return Id.ToUpper.Equals(other.Id.ToUpper)
    End Function


End Class

