Module SingleOrDefault
    Sub main()
        Dim employees = New List(Of Employee)
        Dim employee As Employee
        Dim rand As New Random

        'Create random 1000 employee objects
        For i As Int16 = 1 To 20000
            'Create a new object
            employee = New Employee()
            'Populate with data
            With employee
                .EmpID = String.Format("EP{0}", i)
                .EmpName = String.Format("Name{0}", i)
                .Salary = rand.Next(100000)
                .Age = rand.Next(18, 70)
                If rand.Next(100) < 50 Then
                    .Married = True
                Else
                    .Married = False
                End If
                'Short cut for above
                .Married = If(rand.Next(100) < 50, True, False)
            End With
            'Add to list
            employees.Add(employee)
        Next

        'Get the first employe whose salary is 25000
        Dim qry = From T In employees
                  Where T.Salary = 25000
                  Select T
        employee = qry.FirstOrDefault()
        ShowEmployee(employee)

        'Method 2 uisng lamba express
        Dim result = employees.FirstOrDefault(Function(U) U.Salary = 25000)
        ShowEmployee(result)

        'Get the employee with given emp ID
        Dim empid = "EP10"
        Dim result1 = employees.Single(Function(U) U.EmpID = empid)
        ShowEmployee(result1)

        empid = "EPAB"
        result1 = employees.SingleOrDefault(Function(U) U.EmpID = empid)
        ShowEmployee(result1)

        'Resusing the query
        Dim eid As String = String.Empty
        'Create a query to get emplpyee by id
        Dim employeeByID = From K In employees
                           Where K.EmpID = eid
                           Select K
        'Get an employee
        eid = "EP10"
        employee = employeeByID.Single()
        ShowEmployee(employee)

        'Get second employee
        eid = "EP14"
        employee = employeeByID.Single()
        ShowEmployee(employee)


    End Sub
    Private Sub ShowEmployees(ByVal objs As List(Of Employee))
        Console.WriteLine("Name{0}{1}Salary{2}Age", vbTab, vbTab, vbTab)
        Console.WriteLine("---------------------------------------------")
        For i = 0 To objs.Count - 1
            With objs(i)
                Console.WriteLine("{0}{1}{2}{3}{4}{5}", .EmpName, vbTab, vbTab, .Salary, vbTab, .Age)
            End With
        Next
        Console.WriteLine("There are {0} employees", objs.Count)
    End Sub
    Private Sub ShowEmployee(ByVal emp As Employee)
        'Vlidate the parameters
        If emp Is Nothing Then Exit Sub
        With emp
            Console.WriteLine("{0}{1}{2}{3}{4}{5}", .EmpName, vbTab, vbTab, .Salary, vbTab, .Age)
        End With
    End Sub
End Module
