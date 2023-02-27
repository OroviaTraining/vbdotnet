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
            Dim dtx1 As New TrainingDataContext
            EmployeeDeletedBindingSource.DataSource = dtx1.EmployeeDeleteds
            'dtx1 will go out of scope and gets destroyed, so no worry
        End If
    End Sub
End Class