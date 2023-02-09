Partial Class ClassShape
    Private Shared idNos As Int32 = 0
    Sub New()
        Me.Width = 0
        Me.id = idNos
        idNos += 1
    End Sub
End Class
