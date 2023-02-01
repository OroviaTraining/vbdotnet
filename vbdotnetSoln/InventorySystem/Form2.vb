Public Class Form2
    Private dtx As New InventoryDataContext
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GraphicBindingSource.DataSource = dtx.Graphics
    End Sub

    Private Sub GraphicBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GraphicBindingNavigatorSaveItem.Click
        GraphicBindingSource.EndEdit()
        dtx.SubmitChanges()
    End Sub
End Class