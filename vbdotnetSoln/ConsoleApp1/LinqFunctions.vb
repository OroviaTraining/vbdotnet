Module LinqFunctions
    Sub main()
        Dim dtx As New NortWindDataContext
        dtx.Log = Console.Out
        Dim x As Int32 = dtx.OrderCountByEmployee(5)
        Dim y = dtx.OrderCountByEmployee(8)
        Dim z As Nullable(Of Int32)
        Dim w As Int32
        If z.HasValue Then
            Console.WriteLine("Z has a value")
        Else
            Console.WriteLine("Z has a no value")
        End If

        z = 5
        If z.HasValue Then
            Console.WriteLine($"Z has a value{z.Value}, {z}")
        Else
            Console.WriteLine("Z has a no value")
        End If
    End Sub
End Module
