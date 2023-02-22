Public Class FormCatg1
    Private dtx As New NorthwindDataContext 
    Private Sub FormCatg1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoryBindingSource.DataSource = dtx.Categories
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CategoryBindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CategoryBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CategoryBindingSource.MoveLast()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CategoryBindingSource.MoveFirst()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CategoryBindingSource.EndEdit()
        dtx.SubmitChanges()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CategoryBindingSource.AddNew()
    End Sub
End Class