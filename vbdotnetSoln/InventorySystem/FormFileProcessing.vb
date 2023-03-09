Imports System.IO

Public Class FormFileProcessing
    Private countries As New List(Of Country)
    Private filePath As String

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
End Class