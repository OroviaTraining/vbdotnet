Imports System.Data.Linq

Partial Public Class InventoryDataContext

End Class
Partial Public Class DbTable
    Private Sub OnCreated()
        Dim a = Me.seqNo
    End Sub

    Private Sub OnValidate(action As ChangeAction)

        Select Case action
            Case ChangeAction.Delete
                'Add a record in to the log file
            Case ChangeAction.Insert
                ValidateTypes()
                'Set created date and user
                Me.creDate = Today
                Me.creUser = "DCN"

            Case ChangeAction.Update
                ValidateTypes()
                'Add auti trail
                Me.amdDate = Today
                Me.amdUser = "Dcn"
        End Select
    End Sub

    Private Sub ValidateTypes()
        Dim cnt As Byte
        'Make sure only one checkbox is selected
        If Me.type1 = True Then cnt += 1
        If Me.type2 = True Then cnt += 1
        If Me.type3 = True Then cnt += 1
        If cnt = 0 OrElse cnt > 1 Then
            Throw New Exception("Only 1 type is allowed")
        End If
    End Sub

    Private Sub OnLoaded()
        'Use this event to initilaise other fields

    End Sub

    Private Sub Ontype1Changing(value As Boolean)

    End Sub
    Private Sub Ontype1Changed()
        If Me.type1 = True Then
            Me.type2 = False
            Me.type3 = False
        End If
    End Sub

    Private Sub Ontype2Changing(value As Boolean)

    End Sub
    Private Sub Ontype2Changed()
        If Me.type2 = True Then
            Me.type1 = False
            Me.type3 = False
        End If
    End Sub

    Private Sub Ontype3Changed()
        If Me.type3 = True Then
            Me.type1 = False
            Me.type2 = False
        End If
    End Sub
    Private Sub Ontype3Changing(value As Boolean)

    End Sub


End Class

