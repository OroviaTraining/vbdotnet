Public Class Customer
    Public Property custID As Int32
    Public Property custName As String
    Public Property custCity As String
    Private Shared nextID As Int32 = 0
    Public Property Orders As List(Of Order)
    Public Property Dependents As List(Of Customer)

    Sub New()
        custID = nextID + 1
        nextID += 1
        Orders = New List(Of [Order])
    End Sub
End Class
