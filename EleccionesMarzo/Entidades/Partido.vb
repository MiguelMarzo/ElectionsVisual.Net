Imports Entidades

Public Class Partido : Implements IEquatable(Of Partido)
    Public Property id As Integer
    Public Property nombre As String


    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer, ByVal nombre As String)
        Me.id = id
        Me.nombre = nombre
    End Sub

    Public Function Equals(other As Partido) As Boolean Implements IEquatable(Of Partido).Equals
        Return id.Equals(other.id)
    End Function
End Class
