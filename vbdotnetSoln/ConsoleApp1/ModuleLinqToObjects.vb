Module ModuleLinqToObjects
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

        'Find all employees with age < 25 and store the result in new list
        'SELECT * FROM Employees WHERE Age <25
        Dim qry25 = From T In employees
                    Where T.Age < 25
                    Select T
        Dim result25 = qry25.ToList()
        ShowEmployees(result25)

        'Shortcut of above
        Dim result25a = (From T In employees
                         Where T.Age < 25
                         Select T).ToList
        ShowEmployees(result25)

        'Query 2
        Dim result1 = (From G In employees
                       Where G.Age < 25 AndAlso G.Salary > 50000 AndAlso G.Salary < 60000
                       Select G).ToList
        ShowEmployees(result1)

        'Query 3. return only Employee and Age
        'SELECT name,salary FROM Employees WHERE age <15 and salary BETWEEN 50000 AND 60000
        'The result is called anonymous objects
        Dim resul2 = (From G In employees
                      Where G.Age < 25 AndAlso G.Salary > 50000 AndAlso G.Salary < 60000
                      Select G.EmpName, G.Salary, G.Age).ToList
        resul2.ForEach(Sub(P)
                           With P
                               Console.WriteLine("{0}{1}{2}{3}{4}{5}", .EmpName, vbTab, vbTab, .Salary, vbTab, .Age)
                           End With
                       End Sub)

        Console.ReadLine()
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
        With emp
            Console.WriteLine("{0}{1}{2}{3}{4}{5}", .EmpName, vbTab, vbTab, .Salary, vbTab, .Age)
        End With
    End Sub
End Module
