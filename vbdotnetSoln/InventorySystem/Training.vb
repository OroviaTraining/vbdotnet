Imports System.Data.Linq

Partial Public Class TrainingDataContext
End Class

Partial Public Class Employee
    Public Shared deletFlag As Boolean = True
    Public Shared updateFlag As Boolean = True
    Private Sub OnValidate(action As ChangeAction)
        Select Case action
            Case ChangeAction.Insert
                Me.credate = Now
                Me.creuser = "DCN"

            Case ChangeAction.Update
                Me.amddate = Now
                Me.amduser = "dcn"
                updateFlag = True
            Case ChangeAction.Delete
                deletFlag = True
        End Select
    End Sub

    Private Sub OnCreated()
        Dim a = Me.ename
    End Sub

    Private Sub OnLoaded()
        Dim a = Me.ename
    End Sub
End Class

Partial Public Class BCategory
    Private Sub OnValidate(action As ChangeAction)
        Select Case action
            Case ChangeAction.Insert
                Me.credate = Now
                Me.creuser = "DCN"

            Case ChangeAction.Update
                Me.amddate = Now
                Me.amduser = "dcn"
            Case ChangeAction.Delete
        End Select
    End Sub
End Class
