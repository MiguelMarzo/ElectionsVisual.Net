Imports Entidades

Public Class Voto : Implements IEquatable(Of Voto)
    Public Property idPersona As Integer
    Public Property idElecciones As Integer
    Public Property idPartido As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal idPersona As Integer, ByVal idElecciones As Integer, ByVal idPartida As Integer)
        Me.idPersona = idPersona
        Me.idElecciones = idElecciones
        Me.idPartido = idPartido
    End Sub

    Public Function Equals(other As Voto) As Boolean Implements IEquatable(Of Voto).Equals
        Return idPersona.Equals(other.idPersona) AndAlso idElecciones.Equals(other.idElecciones)
    End Function
End Class
