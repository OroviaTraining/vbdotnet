Module ModuleLists
    Sub Main2()
        Dim employees = New List(Of Employee)
        Dim employee As Employee
        Dim rand As New Random

        'Create random 1000 employee objects
        For i As Byte = 1 To 100 Step 1
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

        'Processing the list linq to objects
        'Method 1
        Console.WriteLine("Name{0}{1}Salary{2}Age", vbTab, vbTab, vbTab)
        Console.WriteLine("---------------------------------------------")
        For i = 0 To employees.Count - 1
            With employees(i)
                Console.WriteLine("{0}{1}{2}{3}{4}{5}", .EmpName, vbTab, vbTab, .Salary, vbTab, .Age)
            End With
        Next

        'Method 2
        Console.WriteLine("Name{0}{1}Salary{2}Age", vbTab, vbTab, vbTab)
        Console.WriteLine("---------------------------------------------")
        'Loop on values of the list
        For Each emp In employees
            With emp
                Console.WriteLine("{0}{1}{2}{3}{4}{5}", .EmpName, vbTab, vbTab, .Salary, vbTab, .Age)
            End With
        Next

        'Method 3 using linq and lamba expression
        employees.ForEach(AddressOf ProcessEmployee)

        employees.ForEach(Sub(K)
                              With K
                                  Console.WriteLine("{0}{1}{2}{3}{4}{5}", .EmpName, vbTab, vbTab, .Salary, vbTab, .Age)
                              End With
                          End Sub)

        'Give 10% hike for salary <=10000, 7% hike for salary 10000 and 50000 and 3% above that
        employees.ForEach(Sub(P)
                              With P
                                  If P.Salary <= 10000 Then
                                      '10% Hike
                                      P.Salary = P.Salary * 1.1
                                  ElseIf P.Salary <= 50000 Then
                                      '7%
                                      P.Salary *= 1.07
                                  Else
                                      P.Salary *= 1.03
                                  End If
                              End With
                          End Sub)


    End Sub

    Private Sub ProcessEmployee(E As Employee)
        With E
            Console.WriteLine("{0}{1}{2}{3}{4}{5}", .EmpName, vbTab, vbTab, .Salary, vbTab, .Age)
        End With
    End Sub
End Module
