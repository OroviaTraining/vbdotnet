Public Class PlayGround
    Dim dtx As New InventoryDataContext

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Enable log
        dtx.Log = Console.Out
        'Bring product id =2
        Dim qry = From T In dtx.Products
                  Where T.pid = 2
        Dim obj = qry.Single()

        'Inrease the value by 10%
        obj.pcost = obj.pcost * 1.1

        Try
            dtx.SubmitChanges()
        Catch ex As Exception
            Button1_Click(Nothing, Nothing)
        End Try
    End Sub
End Class