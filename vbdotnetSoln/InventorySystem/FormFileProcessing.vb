Imports System.IO

Public Class FormFileProcessing
    Private countries As New List(Of Country)
    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click
        'Get file path to process
        Dim filePath As String
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtFile.Text = OpenFileDialog1.FileName
            filePath = OpenFileDialog1.FileName
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

        End If
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
End Class