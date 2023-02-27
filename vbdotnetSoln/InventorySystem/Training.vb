Imports System.Data.Linq

Partial Public Class TrainingDataContext
End Class

Partial Public Class Employee
    Private Sub OnValidate(action As ChangeAction)
        Select Case action
            Case ChangeAction.Insert
                Me.credate = Now
                Me.creuser = "DCN"
            Case ChangeAction.Update
                Me.amddate = Now
                Me.amduser = "dcn"
        End Select
    End Sub

    Private Sub OnCreated()
        Dim a = Me.ename
    End Sub

    Private Sub OnLoaded()
        Dim a = Me.ename
    End Sub
End Class
