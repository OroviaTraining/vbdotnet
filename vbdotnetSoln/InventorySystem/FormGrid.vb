Public Class FormGrid
    Private dtx As New NorthwindDataContext
    Private Sub FormGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductBindingSource.DataSource = dtx.Products
    End Sub

    Private Sub ProductDataGridView_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ProductDataGridView.RowHeaderMouseDoubleClick
        'Get the product object of row clicked
        'Dim gridRow = ProductDataGridView.Rows(e.RowIndex)
        'Dim productData = CType(gridRow.DataBoundItem, Product)
        Dim rowData = CType(ProductDataGridView.Rows(e.RowIndex).DataBoundItem, Product)
        With My.Forms.FormProductDetails
            .RowData = rowData
            .ShowDialog()
        End With

    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Try
            dtx.SubmitChanges()

        Catch ex As Exception
            LabelMessage.Text = ex.Message
        End Try
    End Sub
End Class