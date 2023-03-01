Public Class FormParentChild
    Private dtx As New TrainingDataContext
    Private Sub FormParentChild_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtx.Log = Console.Out
        BrandBindingSource.DataSource = dtx.Brands
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        dtx.SubmitChanges()
    End Sub
End Class