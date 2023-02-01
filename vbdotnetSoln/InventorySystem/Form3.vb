Public Class Form3
    Dim dtx As New InventoryDataContext

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Create a new customer
        Dim cust1 As New Customer
        With cust1
            .custName = "Joe Smith"
            .custCity = "London"
        End With

        'Add few orders for this customer
        Dim ordObj As New Order
        With ordObj
            .OrderDate = Today
            .OrderTotal = 100.95
        End With
        'Add this order to customer object
        cust1.Orders.Add(ordObj)

        Dim cust2 As New Customer
        With cust2
            .custName = "Andy"
            .custCity = "Leeds"
        End With
        Dim objs = GenerateRandomOrders(5)
        ' Add these 5 objects to this customer
        For Each obj In objs
            cust2.Orders.Add(obj)
        Next

        Dim cust3 As New Customer
        With cust3
            .custName = "Jim Hartley"
            .custCity = "Hull"
        End With
        cust3.Orders.AddRange(GenerateRandomOrders(3))

    End Sub

    Private Function GenerateRandomOrders(ByVal cnt As Byte) As List(Of Order)
        Dim result As New List(Of Order)
        Dim ordObj As Order
        Dim rnd As New Random
        Dim mm, dd As Byte
        For i = 1 To cnt
            ordObj = New [Order]
            With ordObj
                dd = rnd.Next(1, 30)
                mm = rnd.Next(1, 12)
                .OrderDate = New Date(Today.Year, mm, dd)
                .OrderTotal = rnd.Next(100, 800)
            End With
            result.Add(ordObj)
        Next
        Return result
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Add a customer and 2 orders
        Dim cust1 As New UKCustomer
        Dim id As String

        With cust1
            id = Guid.NewGuid.ToString.ToUpper
            id = id.Replace("-", "")
            id = id.Substring(0, 10)
            .custID = id
            .custName = "Joe Smith"
            .custCity = "London"
        End With
        dtx.UKCustomers.InsertOnSubmit(cust1)

        'Add few orders for this customer
        Dim ordObj As New CustOrder
        With ordObj
            .orderDate = Today
            .orderTotal = 100.95
        End With
        'Add this order to customer entity
        cust1.CustOrders.Add(ordObj)
        dtx.SubmitChanges()

        Dim cust3 As New UKCustomer
        With cust3
            .custID = Guid.NewGuid.ToString.ToUpper.Replace("-", "").Substring(0, 10)
            .custName = "Jim Hartley"
            .custCity = "Hull"
        End With
        dtx.UKCustomers.InsertOnSubmit(cust3)

        cust3.CustOrders.AddRange(GenerateRandomDBOrders(10))
        dtx.SubmitChanges()

    End Sub
    Private Function GenerateRandomDBOrders(ByVal cnt As Byte) As List(Of CustOrder)
        Dim result As New List(Of CustOrder)
        Dim ordObj As CustOrder
        Dim rnd As New Random
        Dim mm, dd As Byte
        For i = 1 To cnt
            ordObj = New CustOrder
            With ordObj
                dd = rnd.Next(1, 30)
                mm = rnd.Next(1, 12)
                .orderDate = New Date(Today.Year, mm, dd)
                .orderTotal = rnd.Next(100, 800)
            End With
            result.Add(ordObj)
        Next
        Return result
    End Function
End Class