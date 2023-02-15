Public Class FormProductDetails
    Public Property RowData As Product
    Private Sub FormProductDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductBindingSource.DataSource = RowData
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        'Commit any changes done on the screen
        ProductBindingSource.EndEdit()
        Me.Close()
    End Sub
End Class