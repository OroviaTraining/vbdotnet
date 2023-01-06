Public Class FormMain
    Private Sub tsbNewEmployee_Click(sender As Object, e As EventArgs) Handles tsbNewEmployee.Click
        mnNewEmployee_Click(Nothing, Nothing)
    End Sub

    Private Sub tsbMonthlyReport_Click(sender As Object, e As EventArgs) Handles tsbMonthlyReport.Click
        My.Forms.FormMonthlyReport.MdiParent = Me
        My.Forms.FormMonthlyReport.Show()
    End Sub

    Private Sub tsbExit_Click(sender As Object, e As EventArgs) Handles tsbExit.Click
        Application.Exit()
    End Sub

    Private Sub mnNewEmployee_Click(sender As Object, e As EventArgs) Handles mnNewEmployee.Click
        My.Forms.FormNewEmployee.MdiParent = Me
        My.Forms.FormNewEmployee.Show()
    End Sub

    Private Sub mnuGraphs_Click(sender As Object, e As EventArgs) Handles mnuGraphs.Click
        Dim obj = New FormGraphs()
        'obj.MdiParent = Me
        'obj.StartPosition = FormStartPosition.CenterParent
        'obj.Show()

        'With obj
        '    .MdiParent = Me
        '    .StartPosition = FormStartPosition.CenterParent
        '    .Show()
        'End With
        With My.Forms.FormNewEmployee
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub tsbGraph_Click(sender As Object, e As EventArgs) Handles tsbGraph.Click
        mnuGraphs_Click(Nothing, Nothing)
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        My.Forms.FormTabs.Show()
        My.Forms.FormTabs.MdiParent = Me
    End Sub
End Class