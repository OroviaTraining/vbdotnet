Public Class ClassShape
    Public Property id As Int32
    Private _width As Int32
    Public Property Width() As Int32
        Get
            Return _width
        End Get
        Set(ByVal value As Int32)
            _width = value
        End Set
    End Property
    Public Sub ShowVolume()

    End Sub
End Class
