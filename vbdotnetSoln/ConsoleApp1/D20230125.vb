Module D20230125
    Sub main10()
        Dim obj1 As New Staff
        With obj1
            .fname = "DC"
            .lname = "Kumar"
            .jobRole = "deveLoper"
            .DOB = New Date(1968, 3, 29)
        End With
        Console.WriteLine(obj1.name)

        Dim obj2 As New Staff
        Try
            With obj1
                .fname = "ABC"
                .lname = "def"
                .jobRole = "Butcher"
                .DOB = New Date(1900, 3, 29)
            End With
        Catch ex As Exception
            Console.WriteLine("Data is not valid")
        End Try
    End Sub
End Module
