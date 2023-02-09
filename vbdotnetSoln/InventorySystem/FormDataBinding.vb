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

        'Step 1. Populate with regions
        Dim regions = dtx.Regions.ToList
        regions.Insert(0, New Region With {.RegionID = 0, .RegionDescription = "Choose .."})
        With cboRegions
            .DataSource = regions
            .DisplayMember = "RegionDescription"
            .ValueMember = "RegionID"
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

    Private Sub cboRegions_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboRegions.SelectionChangeCommitted
        'Show territory
        Dim regionID = CType(cboRegions.SelectedValue, Int32)
        Dim terrories = dtx.TerritoryByRegion(regionID).ToList
        'Add dummy record
        terrories.Insert(0, New TerritoryByRegionResult With {.TerritoryID = 0, .TerritoryDescription = "Choose ...."})
        With cboTerri
            .DataSource = terrories
            .DisplayMember = "TerritoryDescription"
            .ValueMember = "TerritoryID"
        End With

        'Clear employees
        cboEmployees.DataSource = Nothing
    End Sub

    Private Sub cboTerri_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboTerri.SelectionChangeCommitted
        'Show all employees in this territory
        Dim terID = cboTerri.SelectedValue.ToString
        Dim employees = dtx.EmployeeByTerritory(terID).ToList
        With cboEmployees
            .DataSource = employees
            .DisplayMember = "EmployeeName"
            .ValueMember = "EmployeeID"
        End With
    End Sub
End Class