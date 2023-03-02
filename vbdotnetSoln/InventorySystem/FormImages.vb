Public Class FormImages
    Private Sub FormImages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tvMain.ExpandAll()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        tvMain.ExpandAll()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        tvMain.CollapseAll()
    End Sub

    Private Sub tvMain_Click(sender As Object, e As EventArgs) Handles tvMain.Click

    End Sub

    Private Sub tvMain_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvMain.AfterSelect
        'Select Case e.Node.Text
        '    Case "Edupay"
        '        'Root node is clicked
        '    Case "Employees"
        '        'Employees is clicked
        '        SplitContainer1.Panel2.Controls.Add(New CtlAddress)

        'End Select
        Dim id As Int32 = CType(e.Node.Tag, Int32)
        Select Case id
            Case 0
                'Root node is clicked
            Case 10
                'Employees is clicked
                SplitContainer1.Panel2.Controls.Clear()
                SplitContainer1.Panel2.Controls.Add(New CtlAddress)
            Case 13
                'Employees is clicked
                SplitContainer1.Panel2.Controls.Clear()
                SplitContainer1.Panel2.Controls.Add(New ctlBacs)

        End Select
    End Sub
End Class