Public Class FormPC
    Private dtx As New TrainingDataContext
    Private Sub FormPC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtx.Log = Console.Out
        BrandBindingSource.DataSource = dtx.Brands
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Dim brandObj = CType(ComboBox1.SelectedItem, Brand)
        BCategoryBindingSource.DataSource = brandObj.BCategories
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dtx.SubmitChanges()
    End Sub
End Class