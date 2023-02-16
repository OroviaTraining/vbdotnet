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

    Private Sub ProductDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDataGridView.CellContentClick
        Dim colName = ProductDataGridView.Columns(e.ColumnIndex).Name
        Select Case colName
            Case "colEdit"
                'Edit operation
                Dim result = MessageBox.Show("Do you want to edit?", My.Settings.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If result = DialogResult.Yes Then
                    Dim rowData = CType(ProductDataGridView.Rows(e.RowIndex).DataBoundItem, Product)
                    With My.Forms.FormProductDetails
                        .RowData = rowData
                        .ShowDialog()
                    End With
                End If
            Case "colDelete", "btnDelete"
                'Delete operation
                Dim result = MessageBox.Show("Do you want to delete?", My.Settings.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    ProductDataGridView.Rows.RemoveAt(e.RowIndex)
                End If
        End Select

    End Sub
End Class