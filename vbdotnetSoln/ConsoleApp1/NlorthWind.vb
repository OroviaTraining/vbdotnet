Module NlorthWind
    Sub main()
        'call SP and get all the data in a list
        Dim dtx As New NortWindDataContext
        dtx.Log = Console.Out
        Dim myCustomers = dtx.CustomersByCountry("USA").ToList
        myCustomers.ForEach(Sub(N)
                                Console.WriteLine("{0},{1}", N.CustomerID, N.CompanyName)
                            End Sub)

        'Call the next SP
        Dim orders = dtx.CountOrdersByCustomer(5).ToList
        orders.ForEach(Sub(P)
                           ProcessOrders(P)
                       End Sub)

        ''Traditional way of looping
        'For Each N In myCustomers
        '    Console.WriteLine(N.CustomerID, N.CompanyName)
        'Next

    End Sub


    Private Sub ProcessOrders(ByVal obj As CountOrdersByCustomerResult)
        Console.WriteLine($"{obj.CustomerID},{obj.Cnt},{obj.Total}")
    End Sub

End Module
