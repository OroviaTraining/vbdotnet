Module Playground
    Sub main()
        Dim fromDate = Date.Parse("01/01/2020")
        Dim toDate = Date.Parse("31/01/2020")
        Dim months = emplMonthsInService(fromDate, toDate)

    End Sub

    Private Function emplMonthsInService(ByVal fromDate As Date, ByVal toDate As Date) As Int32
        Dim daysWorked = (toDate - fromDate).TotalDays
        Dim elapsed = daysWorked \ 30
        Return elapsed
    End Function
End Module
