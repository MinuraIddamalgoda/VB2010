Public NotInheritable Class SplashScreen1
    Dim dat(100) As String 'This array holds each item of data from the csv file
    Dim num, counter, Num_cars As Integer

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        prg_load.Increment(Int(Rnd() * (1)) + Int(Rnd() * (5)) + Int(Rnd() * (9)))
        If prg_load.Value = 100 Then
            LoginForm1.Show()
            Me.Hide()
            Timer1.Enabled = False
        End If

    End Sub

    Public Sub SplashScreen1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(My.Resources.users)
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
                        '   MsgBox(currentField)
                        dat(num) = currentField
                        ' MsgBox(dat(num), MsgBoxStyle.OkOnly)
                    Next
                    ' error reporting
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using

        ' break single dat array into two arrays
        For J = 1 To num Step 2
            Num_cars = Num_cars + 1
            Generate.users(Num_cars) = dat(J)
            Generate.pass(Num_cars) = dat(J + 1)
        Next
        'MsgBox(Num_cars)
        ' display cars and prices
        'For J = 1 To Num_cars
        '    'lbo_make.Items.Add((Generate.users(J)))
        '    'lbo_price.Items.Add(Generate.pass(J))
        'Next
    End Sub
End Class
