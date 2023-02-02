Public Class FormValidation
    Private Sub FormValidation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setup
        lblMessage.Text = String.Empty
    End Sub

    Private Sub ShowMessage(ByVal msg As String, ByVal clr As Color)
        lblMessage.Text = msg
        lblMessage.ForeColor = clr
    End Sub

    Private Sub ShowErrorMessage(ByVal msg As String)
        ShowMessage(msg, My.Settings.ErrorMessageColor)
    End Sub
    Private Sub ShowSuccessMessage(ByVal msg As String)
        ShowMessage(msg, My.Settings.SuccessMessageColor)
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Validate empID
        'Dim empID As Int32
        'Try
        '    empID = Int32.Parse(txtID.Text)
        '    If empID < 1000 OrElse empID > 5000 Then
        '        ErrorProviderForm.SetError(txtID, "Employee ID is not valid")
        '        'ShowErrorMessage("Employee ID is not valid")
        '        Return
        '    Else
        '        ErrorProviderForm.SetError(txtID, String.Empty)
        '    End If
        'Catch ex As Exception
        '    ErrorProviderForm.SetError(txtID, "Employee ID is not valid")
        'End Try


        'Validate employee name
        'Dim empName = txtName.Text.Trim
        'If empName.Length < 10 OrElse empName.Length > 50 Then
        '    ErrorProviderForm.SetError(txtName, "Employee name must between 10 and 50 ")
        '    'ShowErrorMessage("Employee ID is not valid")
        '    Return
        'Else
        '    ErrorProviderForm.SetError(txtName, String.Empty)
        'End If

        'Save the data to user


    End Sub

    Private Sub txtID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtID.Validating
        Dim empID As Int32
        Try
            empID = Int32.Parse(txtID.Text)
            If empID < 1000 OrElse empID > 5000 Then
                ErrorProviderForm.SetError(txtID, "Employee ID is not valid")
            Else
                ErrorProviderForm.SetError(txtID, String.Empty)
            End If
        Catch ex As Exception
            ErrorProviderForm.SetError(txtID, "Employee ID is not valid")
        End Try

    End Sub

    Private Sub txtName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating
        Dim empName = txtName.Text.Trim
        If empName.Length < 10 OrElse empName.Length > 50 Then
            ErrorProviderForm.SetError(txtName, "Employee name must between 10 and 50 ")
        Else
            ErrorProviderForm.SetError(txtName, String.Empty)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class