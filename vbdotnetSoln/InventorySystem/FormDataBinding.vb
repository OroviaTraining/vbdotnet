Imports System.IO

Public Class FormDataBinding
    Private dtx As New NorthwindDataContext
    Private Sub FormDataBinding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setup datasource for combo box
        CategoryBindingSource.DataSource = dtx.Categories
        Dim chooseItem As New Category
        With chooseItem
            .CategoryID = 0
            .CategoryName = "Choose ...."
        End With
        CategoryBindingSource.Insert(0, chooseItem)
        cboCategory.SelectedIndex = 0

        'Setup products combobox
        With cboProducts
            .DataSource = dtx.Products
            .DisplayMember = "ProductName"
            .ValueMember = "ProductID"
        End With
    End Sub

    Private Sub cboCategory_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboCategory.SelectionChangeCommitted
        'get the index of the item selected
        Dim idx = cboCategory.SelectedIndex

        'get the category is from valuemeber
        Dim catgID = cboCategory.SelectedValue

        'Get the category object
        Dim catgObj = CType(cboCategory.SelectedItem, Category)
        'Show the category photo
        'PictureBox1.Image = Image.FromStream(New MemoryStream(catgObj.Picture.ToArray))

    End Sub

    Private Sub cboProducts_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboProducts.SelectionChangeCommitted
        'get the index of the item selected
        Dim idx = cboProducts.SelectedIndex

        'get the category is from valuemeber
        Dim catgID = cboProducts.SelectedValue

        'Get the category object
        Dim catgObj = CType(cboProducts.SelectedItem, Product)
    End Sub
End Class