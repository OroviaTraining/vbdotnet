Public Class FormProducts
    Public Property productList As New List(Of Product)
    Private pID As Byte
    Private qry As IEnumerable(Of Product) = From Y In productList Where Y.PID = pID Select Y
    Private productObj As Product
    Private Sub dcn(sender As Object, e As EventArgs) Handles ButtonSave.Click
        'Read values from the screen into product object
        Dim obj As New Product
        With obj
            .PID = Byte.Parse(txtID.Text)
            .PName = txtName.Text
            .PCost = Decimal.Parse(txtCost.Text)
            .PCatg = Product.PROD_CATG.METALS
        End With

        'Add this to the list
        productList.Add(obj)

        'Refresh Datagridview
        DataGridViewProducts.DataSource = Nothing
        DataGridViewProducts.DataSource = productList

        MessageBox.Show("Add product OK")
    End Sub

    Private Sub FormProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim obj As Product
        'Create 100 test products
        For i = 1 To 100
            obj = New Product
            With obj
                .PID = i
                .PName = "Name " + i.ToString()
                .PCost = i * 50.75
                Select Case i
                    Case < 25
                        .PCatg = Product.PROD_CATG.COMPUTER
                    Case < 50
                        .PCatg = Product.PROD_CATG.FURNITURE
                    Case < 75
                        .PCatg = Product.PROD_CATG.METALS
                    Case Else
                        .PCatg = Product.PROD_CATG.TOOLS
                End Select
            End With
            productList.Add(obj)
        Next

        'Show the data in the grid
        DataGridViewProducts.DataSource = productList
    End Sub

    Private Sub ButtonLookup_Click(sender As Object, e As EventArgs) Handles ButtonLookup.Click
        Dim obj As Product
        'Get lookup ID
        Dim productID As Byte
        productID = Byte.Parse(txtID.Text)

        ''Search productlist
        'For i = 0 To productList.Count - 1
        '    obj = productList(i)
        '    If productID = obj.PID Then
        '        txtName.Text = obj.PName
        '        txtCost.Text = obj.PCost
        '        Exit For
        '    End If
        'Next

        ''Method 2
        'For i = 0 To productList.Count - 1
        '    obj = productList(i)
        '    If SearchProductID2(productID, obj) Then
        '        txtName.Text = obj.PName
        '        txtCost.Text = obj.PCost
        '        Exit For
        '    End If
        'Next

        ''Using methods of list and Linq
        'obj = productList.Find(AddressOf SearchMethod)
        'txtName.Text = obj.PName
        'txtCost.Text = obj.PCost

        'obj = productList.Find(Function(P)
        '                           Return P.PID = productID
        '                       End Function)
        obj = productList.Find(Function(K) K.PID = productID)
        If obj IsNot Nothing Then
            txtName.Text = obj.PName
            txtCost.Text = obj.PCost
        Else
            MessageBox.Show("Product ID is not valiud")
        End If
    End Sub

    Private Function SearchProductID(id As Byte, obj As Product) As Boolean
        Dim result As Boolean
        If id = obj.PID Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function
    Private Function SearchProductID1(id As Byte, obj As Product) As Boolean
        Dim result As Boolean = False
        If id = obj.PID Then
            result = True
        End If
        Return result
    End Function
    Private Function SearchProductID2(id As Byte, obj As Product) As Boolean
        Return id = obj.PID
    End Function
    Private Function SearchMethod(obj As Product) As Boolean
        Dim productID As Byte
        productID = Byte.Parse(txtID.Text)
        Return productID = obj.PID
    End Function

    Private Sub ButtonFast_Click(sender As Object, e As EventArgs) Handles ButtonFast.Click
        'Set the variable nefore calling the qry
        pID = Byte.Parse(txtID.Text)
        productObj = qry.Single()
        ShowProduct()
    End Sub

    ''' <summary>
    ''' Set the variable productObj before calling function
    ''' </summary>
    Private Sub ShowProduct()
        With productObj
            txtName.Text = .PName
            txtCost.Text = .PCost
        End With
    End Sub
End Class