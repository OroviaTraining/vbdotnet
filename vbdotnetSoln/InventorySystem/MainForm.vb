Public Class MainForm
    Private Sub GraphicsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GraphicsToolStripMenuItem.Click
        With My.Forms.Form1
            .MdiParent = Me
            .Show()
        End With
    End Sub
End Class