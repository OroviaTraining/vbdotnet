Module Module1

    Sub Main()
        'Create employee object
        'Dim emp1 = New Employee()

        ''Change the properties of this object
        'emp1.EmpID = "ABCDE"
        'emp1.EmpName = "DCN"
        'emp1.Salary = 50000D
        'emp1.DOB = New Date(1968, 3, 29)
        'emp1.Married = True
        'Console.WriteLine("{0},{1},{2},{3},{4}", emp1.EmpID, emp1.EmpName, emp1.Salary, emp1.DOB, emp1.Married)

        'Create product Object
        ' All the following statement do the same job
        Dim P As Product
        P = New Product
        Dim Q As New Product
        Dim R = New Product

        'Assign property values
        With P
            .PID = 1
            .PName = "Laptops"
            .PCost = 17500.99D
            .PCatg = Product.PROD_CATG.COMPUTER
        End With
        Console.WriteLine("ID={0},Name={1},Cost={2},Catg={3}", P.PID, P.PName, P.PCost, P.PCatg)


        'Understand List
        'Create list of integers
        Dim primes As New List(Of Int32)
        'Add 5 prime numbers
        primes.Add(2)
        primes.Add(3)
        With primes
            .Add(5)
            .Add(7)
            .Add(11)
        End With
        primes.Add(13)
        primes.Add(17)

        'Create a list of with some default or intial entries
        Dim largePrimes As New List(Of Decimal) From {10, 30, 67.6, 900, 89}
        With largePrimes
            .Add(5)
            .Add(7)
            .Add(11)
        End With
        'Add these to the beginning
        largePrimes.Insert(0, 1009)
        largePrimes.Insert(4, 2009)

        'I can change value of list
        largePrimes(3)=76
        largePrimes(6) = largePrimes(3) + largePrimes(1) * 35

        'Remove 7th Item
        largePrimes.RemoveAt(6)


        'Create a list of 3 employess
        Dim employees = New List(Of Employee)
        'Add 1st employee
        Dim emp1 As New Employee
        emp1.EmpID = "EP1"
        employees.Add(emp1)

        'Add 2st employee
        Dim emp2 As New Employee
        With emp2
            .EmpID = "ABCDE"
            .EmpName = "DCN"
            .Salary = 50000D
            .DOB = New Date(1968, 3, 29)
            .Married = True
        End With
        employees.Add(emp2)

        'Add 3st employee
        Dim emp3 As New Employee
        emp3.EmpID = "EP3"
        employees.Add(emp3)


    End Sub

End Module
