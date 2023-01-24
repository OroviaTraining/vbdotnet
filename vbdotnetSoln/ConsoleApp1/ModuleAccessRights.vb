Module ModuleAccessRights
    Sub main8()
        Dim c1Obj1 As New Class1
        c1Obj1.e = 10
        c1Obj1.f = 25
        Console.WriteLine(c1Obj1.Sum())
        Dim c1Obj2 As New Class1
        c1Obj2.e = 2.6
        c1Obj2.f = 2.9

        Console.WriteLine(c1Obj2.Sum())

        'Create and assign values to public 
        Dim obj3 = New Class1()
        With obj3
            .e = 9
            .f = 12
        End With


        'Create and assign values to public 
        Dim obj4 = New Class1 With {.e = 12.5, .f = 90.78}
        Console.WriteLine(obj4.factor(7.12))
        Console.WriteLine(obj4.Sum(9, 15, 5))


        Dim obj2 As New Class2
    End Sub
End Module
