Public Class FormCatg
    Private dtx As New NorthwindDataContext
    Private txtBoxes As List(Of TextBox)
    Private currentObj As Category
    Private Sub FormCatg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoryBindingSource.DataSource = dtx.Categories
        ShowData()
        txtBoxes = New List(Of TextBox) From {txtID, txtName, txtDesc}
        'txtBoxes = New List(Of TextBox)
        'txtBoxes.Add(txtID)
        'txtBoxes.Add(txtName)
        'txtBoxes.Add(txtDesc)
    End Sub

    Private Sub CategoryBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles CategoryBindingSource.PositionChanged
        'Get the current category
        If CategoryBindingSource.Position < 0 Then Exit Sub
        currentObj = CType(CategoryBindingSource.Current, Category)
        ShowData()
    End Sub
    ''' <summary>
    ''' Populate screen with data from current object
    ''' </summary>
    ''' <changelog>
    ''' 21/02/2023,DC,Created
    ''' 22/02/2023,SN, Fixed a bug
    ''' </changelog>
    Private Sub ShowData()
        With currentObj
            txtID.Text = .CategoryID
            txtName.Text = .CategoryName
            txtDesc.Text = .Description
        End With
        txtID.ReadOnly = True
        btnNew.Visible = False
        btnSave.Visible = True
    End Sub
    Private Sub ClearData()
        txtBoxes.ForEach(Sub(B)
                             B.Text = String.Empty
                         End Sub)
        txtID.ReadOnly = False
        btnNew.Visible = True
        btnSave.Visible = Not btnNew.Visible
    End Sub
    ''' <summary>
    ''' Updating or create
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not Me.ValidateChildren() Then
            MessageBox.Show("Please fix the data")
            Exit Sub
        End If

        With currentObj
            .CategoryID = txtID.Text
            .CategoryName = txtName.Text
            .Description = txtDesc.Text
        End With
        dtx.SubmitChanges()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearData()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If Not Me.ValidateChildren() Then
            MessageBox.Show("Please fix the data")
            Exit Sub
        End If
        'Add new record
        currentObj = New Category
        'Populate the data
        With currentObj
            .CategoryID = txtID.Text
            .CategoryName = txtName.Text
            .Description = txtDesc.Text
        End With
        CategoryBindingSource.Add(currentObj)
        'dtx.Categories.InsertOnSubmit(currentObj)
        dtx.SubmitChanges()
        'CategoryBindingSource.ResetBindings(False)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        CategoryBindingSource.RemoveCurrent()
        dtx.SubmitChanges()
        'dtx.Categories.DeleteOnSubmit(currentObj)
        'dtx.SubmitChanges()
        'CategoryBindingSource.ResetBindings(False)
    End Sub
End Class