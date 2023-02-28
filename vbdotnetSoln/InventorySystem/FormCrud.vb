Public Class FormCrud
    Private dtx As New TrainingDataContext


    Private Sub FormCrud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmployeeBindingSource.DataSource = dtx.Employees
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        EmployeeBindingSource.EndEdit()
        Try
            dtx.SubmitChanges()
            ShowMessage("Saved OK", Color.Green)
        Catch ex As Exception
            ShowMessage(ex.Message, Color.Red)
        End Try
    End Sub

    Private Sub ShowMessage(ByVal msg As String, ByVal clr As Color)
        lblMessage.Text = msg
        lblMessage.ForeColor = clr
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 2 Then
            'Refresh the datagrid, we will use new datacontext
            If Employee.deletFlag = True Then
                Dim dtx1 As New TrainingDataContext
                EmployeeDeletedBindingSource.DataSource = dtx1.EmployeeDeleteds
                Employee.deletFlag = False
            End If

            'dtx1 will go out of scope and gets destroyed, so no worry
        ElseIf TabControl1.SelectedIndex = 1 Then
            'Change log
            If Employee.updateFlag = True Then

            End If
        Else
            'do whatever u want
        End If

        'Select Case TabControl1.SelectedIndex
        '    Case 0
        '        Dim dtx1 As New TrainingDataContext
        '        EmployeeDeletedBindingSource.DataSource = dtx1.EmployeeDeleteds
        '    Case 1

        '    Case 2
        'End Select


    End Sub
End Class