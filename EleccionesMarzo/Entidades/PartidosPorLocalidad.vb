Public Class PartidosPorLocalidad : Implements IEquatable(Of PartidosPorLocalidad)
    Public Property idPartido As Integer
    Public Property idLocalidad As Integer
    Public Property votosTotales As Integer
    Public Property idElecciones As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal idPartido As Integer, ByVal idLocalida As Integer, ByVal votosTotales As Integer, ByVal idElecciones As Integer)
        Me.idPartido = idPartido
        Me.idLocalidad = idLocalidad
        Me.votosTotales = votosTotales
        Me.idElecciones = idElecciones

    End Sub

    Public Function Equals(other As PartidosPorLocalidad) As Boolean Implements IEquatable(Of PartidosPorLocalidad).Equals
        Return idPartido.Equals(other.idPartido) AndAlso idElecciones.Equals(other.idElecciones)
    End Function

End Class
