Public Class FormValidation
    Private dirty As Boolean
    Private Sub FormValidation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setup
        lblMessage.Text = String.Empty
        cboCity.SelectedIndex = 0
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
        Dim ollOk = Me.ValidateChildren(ValidationConstraints.Visible)
        If ollOk Then
            'Save the data

            dirty = False
        End If



    End Sub

    Private Sub txtID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtID.Validating
        Dim empID As Int32
        Try
            empID = Int32.Parse(txtID.Text)
            If empID < 1000 OrElse empID > 5000 Then
                ErrorProviderForm.SetError(txtID, "Employee ID is not valid")
                e.Cancel = True
            End If
        Catch ex As Exception
            ErrorProviderForm.SetError(txtID, "Employee ID is not valid")
            e.Cancel = True
        End Try

    End Sub
    Private Sub txtID_Validated(sender As Object, e As EventArgs) Handles txtID.Validated
        ErrorProviderForm.SetError(txtID, String.Empty)
    End Sub

    Private Sub txtName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating
        Dim empName = txtName.Text.Trim
        If empName.Length < 10 OrElse empName.Length > 50 Then
            ErrorProviderForm.SetError(txtName, "Employee name must between 10 and 50 ")
            e.Cancel = True
        Else
            ErrorProviderForm.SetError(txtName, String.Empty)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox3.Text = TextBox1.Text + " " + TextBox2.Text
        dirty = True
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox3.Text = TextBox1.Text + " " + TextBox2.Text
        dirty = True
    End Sub

    Private Sub FormValidation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If dirty Then
            Dim result = MessageBox.Show("All your changes will be lost. Do you still want to close", My.Settings.ProductName, MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub FormValidation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed


    End Sub

    Private Sub ToggleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToggleToolStripMenuItem.Click
        Me.ContextMenuStrip = ContextMenuStrip2
    End Sub

    Private Sub ToogleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToogleToolStripMenuItem.Click
        Me.ContextMenuStrip = ContextMenuStrip1
    End Sub

    Private Sub TextBox3_MouseHover(sender As Object, e As EventArgs) Handles TextBox3.MouseHover
        TextBox3.Cursor = Cursors.WaitCursor
    End Sub

    Private Sub FormValidation_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        'Open a word documen

    End Sub

    Private Sub GBQual_Validated(sender As Object, e As EventArgs) Handles GBQual.Validated
        clearError(GBQual)
    End Sub

    Private Sub GBQual_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GBQual.Validating
        If rbBE.Checked = False AndAlso rbME.Checked = False AndAlso Not rbMPhil.Checked AndAlso Not rbPHd.Checked Then
            e.Cancel = True
            ErrorProviderForm.SetError(GBQual, "Atleast one qualification is required ")
        End If
    End Sub

    'Private Sub rbBE_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles rbBE.Validating,
    '        rbME.Validating, rbMPhil.Validating, rbPHd.Validating
    '    If rbBE.Checked = False AndAlso rbME.Checked = False AndAlso Not rbMPhil.Checked AndAlso Not rbPHd.Checked Then
    '        e.Cancel = True
    '        ErrorProviderForm.SetError(GBQual, "Atleast one qualification is required ")
    '    End If
    'End Sub

    Private Sub cboCity_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboCity.Validating
        If cboCity.SelectedIndex = 0 Then
            e.Cancel = True
            ErrorProviderForm.SetError(cboCity, "Atleast one city is requid")
        End If
    End Sub

    Private Sub cboCity_Validated(sender As Object, e As EventArgs) Handles cboCity.Validated
        clearError(cboCity)
    End Sub

    Private Sub clearError(ByVal ctl As Control)
        ErrorProviderForm.SetError(ctl, String.Empty)
    End Sub
End Class