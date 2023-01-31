Public Class Form1
    Private dtx As New InventoryDataContext
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GraphicBindingSource.DataSource = dtx.Graphics
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        dtx.SubmitChanges()
    End Sub

    Private Sub ButtonRefesh_Click(sender As Object, e As EventArgs) Handles ButtonRefesh.Click
    End Sub
End Class
