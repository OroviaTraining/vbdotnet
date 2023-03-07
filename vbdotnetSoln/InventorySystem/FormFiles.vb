
Public Class FormFiles
    Public Enum GRADES
        PASS = 10
        FAIL = 11
        DIST = 12
        MERIT = 20
    End Enum
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        System.IO.File.WriteAllText("C:\Temp\Training\message.txt", txtData.Text)
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        'Do save only when there is a data
        'If txtData.Text.Length = 0 Then Exit Sub
        If txtData.Text.Length > 0 Then
            If System.IO.File.Exists("C:\Temp\Training\employees.txt") Then
                txtData.Text = System.IO.File.ReadAllText("C:\Temp\Training\employees.txt")
            Else
                MessageBox.Show("File does not eixts")
            End If
        End If
    End Sub

    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        System.IO.File.AppendAllText("C:\Temp\Training\message.txt", txtData.Text)
    End Sub

    Private Sub btnFolder_Click(sender As Object, e As EventArgs) Handles btnFolder.Click
        Dim SelectedPath As String
        Dim filePath As String
        Dim result = FolderBrowserDialog1.ShowDialog()
        If result = DialogResult.OK Then
            'Get the folder name
            SelectedPath = FolderBrowserDialog1.SelectedPath
            filePath = SelectedPath + "\" + "employees.txt"
            System.IO.File.WriteAllText(filePath, txtData.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filePath As String
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            filePath = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filePath As String
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            filePath = SaveFileDialog1.FileName
        End If

    End Sub
End Class