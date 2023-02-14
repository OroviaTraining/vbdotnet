Public Class FormTable
    Private dtx As New InventoryDataContext
    Private Sub FormTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbTableBindingSource.DataSource = dtx.DbTables
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DbTableBindingSource.EndEdit()
        Try
            dtx.SubmitChanges()
        Catch ex As Exception
            LabelMessage.Text = ex.Message
        End Try
    End Sub
End Class