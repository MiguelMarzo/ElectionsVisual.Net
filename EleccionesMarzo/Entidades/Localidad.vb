
Public Class Localidad : Implements IEquatable(Of Localidad)

    Public Property Id As String
    Public Property nombre As String
    Public Property NumHabitantes As Integer
    Public Property IdProvincia As String
    Public Sub New()

    End Sub
    Public Sub New(id As String, nombre As String, numHabitantes As Integer, idProvincia As String)
        Me.Id = id
        Me.IdProvincia = idProvincia
        Me.nombre = nombre
        Me.NumHabitantes = numHabitantes
    End Sub

    Public Overloads Function Equals(other As Localidad) As Boolean Implements IEquatable(Of Localidad).Equals
        Return Id.ToUpper.Equals(other.Id.ToUpper)
    End Function
End Class