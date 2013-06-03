Public Class Form1
    Dim dat(100) As String 'This array holds each item of data from the csv file
    Dim num, counter, Num_cars As Integer
    Public Sub btn_start_Click(sender As System.Object, e As System.EventArgs) Handles btn_start.Click

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("E:\I.T\Unit 3\Book1.csv")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()

            ' This section reads the text file into one array data()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        num = num + 1

                        If num Mod 2 Then
                            lbo_make.Items.Add(currentField)
                            dat(num) = currentField

                        Else
                            lbo_price.Items.Add(currentField)
                            'MsgBox(dat(num), MsgBoxStyle.OkOnly)
                        End If

                    Next
                    ' error reporting
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btn_new.Click

        ReDim dat(UBound(dat) + 1)
        dat(UBound(dat)) = lbo_make.Items.Add(InputBox("Enter make of car", "Enter manufacturer", "Here"))
        dat(UBound(dat)) = lbo_price.Items.Add(InputBox("Enter price of car", "Enter price", "Here"))
        Num_cars += 1

    End Sub

    Public Sub btn_save_Click(sender As System.Object, e As System.EventArgs) Handles btn_save.Click

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("E:\I.T\Unit 3\Book1.csv")
            MyReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            Dim currentRow As String()
            Dim file As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("E:\I.T\Unit 3\Book1.csv", False)

            While Not MyReader.EndOfData

                Try
                    currentRow = MyReader.ReadFields()

                    For J = 1 To Num_cars
                        If J Mod 2 = True Then
                            'file.WriteLine(dat(J))
                            file.WriteLine("Smoke me Reece")
                        ElseIf J Mod 2 = False Then
                            'file.WriteLine(dat(J))
                            file.WriteLine("Smoke me Reece price")
                        End If
                    Next

                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & " is invalid.  Skipping")
                End Try
            End While
        End Using

    End Sub
End Class
