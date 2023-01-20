Module LinqToSQL
    Sub main()

        'Add new product
        'CreateProduct()

        'Modify existing object
        'UpdateProduct(5)

        'Delete a record from database
        'DeleteProduct(4)

        'Select records
        SelectProduct()

    End Sub

    Private Sub CreateProduct()
        'Create datacontext object
        Dim dtx As New TrainingDataContext
        dtx.Log = Console.Out

        'Create a new asset object and populate with data
        Dim obj = New Asset
        With obj
            .pID = 5
            .pName = "Mouse"
            .pCost = 2.5D
            .pInstock = True
            .creDate = Now()
            .creUser = "DCNK"
        End With

        'Insert this object to Product table
        dtx.Assets.InsertOnSubmit(obj)

        'Commit the changes
        dtx.SubmitChanges()
    End Sub

    Private Sub UpdateProduct(pid As Int32)
        'Create datacontext object
        Dim dtx As New TrainingDataContext
        dtx.Log = Console.Out

        'Get the record from the database
        Dim qry = From T In dtx.Assets
                  Where T.pID = pid
                  Select T
        Dim productObj = qry.Single()

        'Modifiy to your heart content
        With productObj
            .pCost += 5D
            .amdDate = Now
            .amdUser = "Tanya"
        End With

        'Commit the changes
        dtx.SubmitChanges()

    End Sub

    Private Sub DeleteProduct(pid As Int32)
        'Create datacontext object
        Dim dtx As New TrainingDataContext
        dtx.Log = Console.Out

        'Get the record from the database
        Dim qry = From T In dtx.Assets
                  Where T.pID = pid
                  Select T
        Dim productObj = qry.Single()

        'Delete this from the collection
        dtx.Assets.DeleteOnSubmit(productObj)

        'Commit the changes
        dtx.SubmitChanges()

    End Sub

    Private Sub SelectProduct()
        'Create datacontext object
        Dim dtx As New TrainingDataContext
        dtx.Log = Console.Out

        'Get all records that are in stock and cost < 50
        'Dim products = (From T In dtx.Assets
        '                Where T.pInstock = True AndAlso T.pCost < 50).ToList

        Dim products = (From T In dtx.Assets
                        Where T.pInstock = True).ToList

        products.ForEach(Sub(B)
                             Console.WriteLine("{0},{1}", B.pID, B.pName)
                         End Sub)

        'Increase price of all object by 10%
        products.ForEach(Sub(Y)
                             With Y
                                 .pCost *= 1.1D
                                 .amdDate = Now()
                                 .amdUser = "DCN"
                             End With
                         End Sub)

        'Commit the changes
        dtx.SubmitChanges()
    End Sub
End Module
