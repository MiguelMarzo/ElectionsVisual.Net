Imports Entidades

Public Class Elecciones : Implements IEquatable(Of Elecciones)

    Public Property id As Integer
    Public Property fecha As Date
    Public Property tipo As String


    Public Sub New()

    End Sub

    Public Sub New(ByVal id As Integer, ByVal fecha As Date, ByVal tipo As String)
        Me.id = id
        Me.fecha = fecha
        Me.tipo = tipo
    End Sub


    Public Function Equals(other As Elecciones) As Boolean Implements IEquatable(Of Elecciones).Equals
        Return id.Equals(other.id)
    End Function
End Class
