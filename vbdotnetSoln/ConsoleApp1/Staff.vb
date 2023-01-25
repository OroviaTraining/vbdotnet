Public Class Staff
    Public Property fname As String
    Public Property lname As String

    Private _jobRole As String
    Private validJobes As New List(Of String) From {"developer", "team leader", "trainee", "project manager"}
    Public Property jobRole As String ' Both read and write
        Get
            Return _jobRole.ToUpper
        End Get
        Set(value As String)
            Dim t = value.ToLower()
            'If validJobes.Contains(t) Then
            '    _jobRole = value
            'Else
            '    Throw New Exception("Job role is not value")
            'End If
            'If validJobes.Exists(Function(K) K = t) Then
            '    _jobRole = value
            'Else
            '    Throw New Exception("Job role is not value")
            'End If
            If validJobes.Any(Function(K)
                                  Dim result As Boolean
                                  If K = t Then
                                      result = True
                                  Else
                                      result = False
                                  End If
                                  Return result
                              End Function) Then
                _jobRole = value
            Else
                Throw New Exception("Job role is not value")
            End If
        End Set

    End Property
    Public ReadOnly Property name As String
        Get
            Return $"{fname},{lname}"
        End Get
    End Property
    Public Property DOB As Date
    Public ReadOnly Property age As Int32


End Class
