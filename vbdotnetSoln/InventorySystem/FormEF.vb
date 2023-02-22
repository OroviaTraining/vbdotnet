Public Class FormEF
    Dim dtx As New NorthwindEntities

    Private Sub FormEF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoryBindingSource.DataSource = dtx.CategoryEFs.ToList
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dtx.SaveChanges()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim obj As New CategoryEF
        Dim id As Int32 = Date.Now.Millisecond
        With obj
            .CategoryID = id
            .CategoryName = $"Name {id}"
            .Description = $"Description {id}"
        End With
        dtx.CategoryEFs.Add(obj)
        dtx.SaveChanges()
        CategoryBindingSource.Add(obj)
    End Sub
End Class