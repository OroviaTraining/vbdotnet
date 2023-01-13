Module ModuleListMethods
    Sub main3()
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
        'ShowEmployees(employees)

        'Find all employees with age < 25 and store the result in new list
        Dim result25 As New List(Of Employee)
        For i = 0 To employees.Count - 1
            With employees(i)
                If .Age < 25 Then
                    result25.Add(employees(i))
                End If
            End With
        Next
        'ShowEmployees(result25)

        'Use builtin function
        Dim result25a = employees.FindAll(Function(G) G.Age < 25)
        'ShowEmployees(result25a)

        'Use builtin function. get all employee whose age < 25 and whose salary is more than 50000
        Dim result25b = employees.FindAll(Function(G) G.Age < 25 AndAlso G.Salary > 50000 AndAlso G.Salary < 60000)
        ShowEmployees(result25b)

        'If there anyone whose salary is 75000
        If employees.Any(Function(P) P.Salary = 75000) = True Then
            'Get that object
            employee = employees.Find(Function(P) P.Salary = 75000)
            Console.WriteLine("Yes, we have one")
            ShowEmployee(employee)
        End If

        'Better way to do the above function
        employee = employees.Find(Function(P) P.Salary > 95000)
        If employee IsNot Nothing Then
            ShowEmployee(employee)
        Else
            Console.WriteLine("No, we have none")
        End If

        'Similar to above. But there must be a record otherwise throw exception
        'employee = employees.First(Function(P) P.Salary = 95000)
        'ShowEmployee(employee)

        'Similar to above. But there must be a record otherwise return default value ( nothing)
        employee = employees.FirstOrDefault(Function(P) P.Salary = 95000)
        If employee IsNot Nothing Then
            ShowEmployee(employee)
        Else
            Console.WriteLine("No, we have none")
        End If
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
