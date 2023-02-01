Public Class Order
    Private _id As Int32
    Public Property OrderID() As Int32
        Get
            Return _id
        End Get
        Set(ByVal value As Int32)
            _id = value
        End Set
    End Property
    Private Shared nextID As Int32 = 0
    Sub New()
        OrderID = nextID + 1
        nextID += 1
    End Sub

    Public Property OrderDate As Date
    Public Property OrderTotal As Decimal
End Class
