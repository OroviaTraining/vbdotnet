Public Class FormGrid
    Private dtx As New NorthwindDataContext
    Private Sub FormGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setup Category Dropdown list
        CategoryBindingSource.DataSource = dtx.Categories
        CategoryID.DisplayMember = "CategoryName"
        CategoryID.ValueMember = "CategoryID"

        'Setup Supplier dropdown list
        SupplierBindingSource.DataSource = dtx.Suppliers
        ColSID.DisplayMember = "CompanyName"
        ColSID.ValueMember = "SupplierID"

        ProductBindingSource.DataSource = dtx.Products
        'ProductBindingSource.Filter = "ProductID > 50"
        'ProductBindingSource.ResetBindings(False)
        dtx.Log = Console.Out
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
        'Ignore if user has clicked on column header
        If e.RowIndex < 0 Then Exit Sub

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

    Private Sub chkDisc_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisc.CheckedChanged
        'Dim chk = CType(sender, CheckBox)
        'If chk.Checked Then
        '    Dim qry = From t In dtx.Products
        '              Where t.Discontinued = False
        '    ProductBindingSource.DataSource = qry
        'Else
        '    ProductBindingSource.DataSource = dtx.Products
        'End If
    End Sub

    Private Sub ButtonFilter_Click(sender As Object, e As EventArgs) Handles ButtonFilter.Click
        Dim qry = From t In dtx.Products Select t
        'Filter by discontinued
        If chkDisc.Checked Then
            qry = From x In qry
                  Where x.Discontinued = False
                  Select x
        End If

        'Filter by product name
        Dim pName = txtName.Text.Trim
        If pName <> String.Empty Then
            qry = From t In qry
                  Where t.ProductName.StartsWith(pName)
        End If

        Dim price As Decimal
        price = Decimal.Parse(mtxtPrice.Text)
        Select Case cboOp.SelectedIndex
            Case 0
                'Greater then
                qry = From x In qry
                      Where x.UnitPrice > price
                      Select x
            Case 1
                'Less then
                qry = From x In qry
                      Where x.UnitPrice < price
                      Select x
            Case 2
                qry = From x In qry
                      Where x.UnitPrice = price
                      Select x
        End Select

        ProductBindingSource.DataSource = qry
    End Sub

    Private Sub CategoryBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles CategoryBindingSource.CurrentChanged
        Dim catgObj = CType(CategoryBindingSource.Current, Category)
        TextBoxDesc.Text = catgObj.Description
    End Sub

    Private Sub CategoryBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles CategoryBindingSource.CurrentItemChanged

    End Sub

    Private Sub CategoryBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles CategoryBindingSource.PositionChanged

    End Sub

    Private Sub ProductBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ProductBindingSource.CurrentChanged
        Dim prodObj = CType(ProductBindingSource.Current, Product)
        TextBoxStock.Text = prodObj.QuantityPerUnit
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        ProductBindingSource.RemoveCurrent()
    End Sub
End Class