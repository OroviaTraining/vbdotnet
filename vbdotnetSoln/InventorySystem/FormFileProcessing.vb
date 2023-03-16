Imports System.IO

Public Class FormFileProcessing
    Private countries As New List(Of Country)
    Private filePath As String
    Private destFile As String
    Private manfNames As New List(Of String)

    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click
        'Get file path to process
        If OpenFileDialog1.ShowDialog <> DialogResult.OK Then Exit Sub

        filePath = OpenFileDialog1.FileName
        txtFile.Text = filePath
        btnMethod1.Enabled = True : btnMethod2.Enabled = True : btnMethod3.Enabled = True : btnMethod4.Enabled = True


        ' ProcessMethod1()
    End Sub

    ''' <summary>
    ''' Before calling this function make sure the field filepath is set.
    ''' </summary>
    Private Sub ProcessMethod1()
        'Open the file for processing
        Using reader As StreamReader = New StreamReader(filePath)
            'Read and ignore header or column reader
            Dim data = reader.ReadLine()

            'read one more line
            data = reader.ReadLine()

            While data <> ""
                'Split this into comma
                Dim items = data.Split(",")
                'Remove all trailing and leading dbl quotes
                items(0) = items(0).Replace("""", "")
                items(1) = items(1).Replace("""", "")
                items(2) = items(2).Replace("""", "")

                'Some country have no populate, ignore them
                'Put this  item into the object
                Try
                    Dim obj = New Country()
                    With obj
                        .CountryName = items(0)
                        .CountryCode = items(1)
                        .Population = Integer.Parse(items(2))
                    End With

                    'Put object into the list
                    countries.Add(obj)
                Catch ex As Exception
                    'Ignore
                End Try
                'read one more line
                data = reader.ReadLine()
            End While

        End Using

        'Show the data in the grid
        dgvCountry.DataSource = countries

        btnSave.Enabled = True
    End Sub



    Private Sub FormFileProcessing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim empl As ClassShape
        Dim emp2 As New ClassShape

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dtx As New TrainingDataContext
        Dim obj As PCountry
        'First we will add to data context
        countries.ForEach(Sub(B)
                              'If the record is already present then we will update otherwise we will add new record
                              obj = dtx.PCountries.SingleOrDefault(Function(P) P.cnCode = B.CountryCode)
                              If obj Is Nothing Then
                                  obj = New PCountry
                                  With obj
                                      .cnCode = B.CountryCode
                                      .cnName = B.CountryName
                                      .cnPopu = B.Population
                                  End With
                                  dtx.PCountries.InsertOnSubmit(obj)
                              Else
                                  With obj
                                      .cnName = B.CountryName
                                      .cnPopu = B.Population
                                  End With
                              End If
                          End Sub)
        'After that we will submit changes
        dtx.SubmitChanges()
    End Sub

    Private Sub btnMethod1_Click(sender As Object, e As EventArgs) Handles btnMethod1.Click
        ProcessMethod1()
    End Sub

    Private Sub ProcessMethod2()
        Dim data As String = String.Empty

        'Open the file for processing
        Using reader As StreamReader = New StreamReader(filePath)
            'Read and ignore header or column reader
            reader.ReadLine()

            Do
                data = reader.ReadLine()
                If data = String.Empty Then Exit Do
                'Split this into comma
                Dim items = data.Split(",")
                'Remove all trailing and leading dbl quotes
                items(0) = items(0).Replace("""", "")
                items(1) = items(1).Replace("""", "")
                items(2) = items(2).Replace("""", "")

                'Some country have no populate, ignore them
                'Put this  item into the object
                Try
                    Dim obj = New Country()
                    With obj
                        .CountryName = items(0)
                        .CountryCode = items(1)
                        .Population = Integer.Parse(items(2))
                    End With

                    'Put object into the list
                    countries.Add(obj)
                Catch ex As Exception
                    'Ignore
                End Try
            Loop
        End Using

        'Show the data in the grid
        dgvCountry.DataSource = countries
        btnSave.Enabled = True
    End Sub

    Private Sub btnMethod2_Click(sender As Object, e As EventArgs) Handles btnMethod2.Click
        ProcessMethod2()
    End Sub

    Private Sub btnMethod3_Click(sender As Object, e As EventArgs) Handles btnMethod3.Click
        ProcessMethod3()
    End Sub
    Private Sub ProcessMethod3()
        Dim data As String = String.Empty

        'Open the file for processing
        Using reader As StreamReader = New StreamReader(filePath)
            'Read and ignore header or column reader
            reader.ReadLine()

            Do
                data = reader.ReadLine()
                If data <> String.Empty Then

                    'Split this into comma
                    Dim items = data.Split(",")
                    'Remove all trailing and leading dbl quotes
                    items(0) = items(0).Replace("""", "")
                    items(1) = items(1).Replace("""", "")
                    items(2) = items(2).Replace("""", "")

                    'Some country have no populate, ignore them
                    'Put this  item into the object
                    Try
                        Dim obj = New Country()
                        With obj
                            .CountryName = items(0)
                            .CountryCode = items(1)
                            .Population = Integer.Parse(items(2))
                        End With

                        'Put object into the list
                        countries.Add(obj)
                    Catch ex As Exception
                        'Ignore
                    End Try
                End If
            Loop While (data <> String.Empty)
        End Using

        'Show the data in the grid
        dgvCountry.DataSource = countries
        btnSave.Enabled = True
    End Sub

    Private Sub btnMethod_Click(sender As Object, e As EventArgs) Handles btnMethod4.Click
        ProcessMethod4()

    End Sub
    Private Sub ProcessMethod4()
        Dim data As String = String.Empty

        'Open the file for processing
        Using reader As StreamReader = New StreamReader(filePath)
            'Read and ignore header or column reader
            reader.ReadLine()

            Do
                data = reader.ReadLine()
                If data <> String.Empty Then

                    'Split this into comma
                    Dim items = data.Split(",")
                    'Remove all trailing and leading dbl quotes
                    items(0) = items(0).Replace("""", "")
                    items(1) = items(1).Replace("""", "")
                    items(2) = items(2).Replace("""", "")

                    'Some country have no populate, ignore them
                    'Put this  item into the object
                    Try
                        Dim obj = New Country()
                        With obj
                            .CountryName = items(0)
                            .CountryCode = items(1)
                            .Population = Integer.Parse(items(2))
                        End With

                        'Put object into the list
                        countries.Add(obj)
                    Catch ex As Exception
                        'Ignore
                    End Try
                End If
            Loop Until (data = String.Empty)
        End Using

        'Show the data in the grid
        dgvCountry.DataSource = countries
        btnSave.Enabled = True
    End Sub



    Private Sub btnMethod5_Click(sender As Object, e As EventArgs) Handles btnMethod5.Click
        ProcessMethod5()
    End Sub
    Private Sub ProcessMethod5()
        Dim destData As String
        Dim rawData = File.ReadAllLines(filePath).ToList
        Dim separator = New String() {",", "|", ";"}
        'Delete the first header row
        rawData.RemoveAt(0)


        Dim marks = "80,75,,,45,77,90,"
        Dim marksList = marks.Split(",")
        Dim marks1 = marks.Split(separator, StringSplitOptions.RemoveEmptyEntries)

        'Write data from 1963 to separate file
        Using wr = New StreamWriter(destFile)
            'Write the header line
            wr.WriteLine("Country Name,Country Code,1960,1961,1962,1963,9164,1965")
            For Each r In rawData
                'Split the line
                Dim items = r.Split(separator, StringSplitOptions.RemoveEmptyEntries)
                destData = $"{items(0)},{items(1)},{items(4)},{items(5)},{items(6)},{items(7)},{items(8)},{items(9)}"
                wr.WriteLine(destData)
            Next
        End Using
    End Sub

    Private Sub btnDestFile_Click(sender As Object, e As EventArgs) Handles btnDestFile.Click
        btnMethod5.Enabled = False
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            destFile = SaveFileDialog1.FileName
            btnMethod5.Enabled = True
            txtDest.Text = destFile
        End If

        'Array examples
        'Dim marks() As Integer = {1, 3, 5, 6, 8}
        'Dim names = New String() {"dc", "kc", "mc"}
        'Dim cities As String() = {"shimoga", "Mandta", "bdvt"}
        'Dim states() As String = {"Kar", "Del", "Tml"}

    End Sub

    Private Sub btnCars_Click(sender As Object, e As EventArgs) Handles btnCars.Click
        Dim rawData = File.ReadAllLines(filePath).ToList
        Dim separator = New String() {",", "|", ";"}
        'Delete the first header row
        rawData.RemoveAt(0)
        rawData.ForEach(Sub(B)
                            Dim items = B.Split(separator, StringSplitOptions.RemoveEmptyEntries)
                            Dim manfName As String = items(13)
                            If manfNames.Contains(manfName) = False Then
                                manfNames.Add(manfName)
                            End If
                        End Sub)
        dgvCountry.DataSource = manfNames
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim data As String = String.Empty
        Using reader As StreamReader = New StreamReader(filePath)
            'Read and ignore header or column reader
            reader.ReadLine()
            Do
                data = reader.ReadLine()
                'on EOF exit loop
                If data = String.Empty Then Exit Do

                'Split this into comma
                Dim items = data.Split(",")

                'Write to 1960 file
                Using sw As StreamWriter = File.AppendText("C:\Temp\1960.txt")
                    'CountryCode,CountryName,Population
                    sw.WriteLine($"{items(1)},{items(0)},{items(4)}")
                End Using
                'Write to 1961 file
                Using sw As StreamWriter = File.AppendText("C:\Temp\1961.txt")
                    'CountryCode,CountryName,Population
                    sw.WriteLine($"{items(1)},{items(0)},{items(5)}")
                End Using
                'Write to 1962 file
                Using sw As StreamWriter = File.AppendText("C:\Temp\1962.txt")
                    'CountryCode,CountryName,Population
                    sw.WriteLine($"{items(1)},{items(0)},{items(6)}")
                End Using
                'Write to 1963 file
                Using sw As StreamWriter = File.AppendText("C:\Temp\1963.txt")
                    'CountryCode,CountryName,Population
                    sw.WriteLine($"{items(1)},{items(0)},{items(7)}")
                End Using
            Loop
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim data As String = String.Empty
        Using reader As StreamReader = New StreamReader(filePath)
            'Read and ignore header or column reader
            reader.ReadLine()
            Do
                data = reader.ReadLine()
                'on EOF exit loop
                If data = String.Empty Then Exit Do

                'Split this into comma
                Dim items = data.Split(",")

                'Write to 1960 file
                AppendText(items, 4, "1960")
                AppendText(items, 5, "1961")
                AppendText(items, 6, "1962")
                AppendText(items, 7, "1963")
            Loop
        End Using
    End Sub
    Private Sub AppendText(ByVal values As String(), ByVal idx As Integer, ByVal fileName As String)
        Using sw As StreamWriter = File.AppendText($"C:\Temp\{fileName}.txt")
            'CountryCode,CountryName,Population
            sw.WriteLine($"{values(1)},{values(0)},{values(idx)}")
        End Using
    End Sub
End Class