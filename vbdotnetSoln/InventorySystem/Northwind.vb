Partial Public Class NorthwindDataContext
End Class
Partial Public Class EmployeeByTerritoryResult
    Public Property EmployeeName As String
        Get
            Return $"{Me.Title} {Me.FirstName} {Me.LastName }"
        End Get
        Set(value As String)

        End Set
    End Property
End Class
