Public Class Form1
    Dim gas(6), elec(6) As Decimal
    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_start.Click

        'Me.Enabled = False
        'Form2.Show()

        'If nud_people.Value = 1 Then
        '    pb_alone.Visible = True
        'End If

        'gas(1) = 10.6
        'gas(2) = 13.9
        'gas(3) = 15.8
        'gas(4) = 18.6
        'gas(5) = 20.6
        'gas(6) = 22.8

        'elec(1) = 13.1
        'elec(2) = 16.3
        'elec(3) = 18.3
        'elec(4) = 21
        'elec(5) = 23.1
        'elec(6) = 25.3

        Dim data(18) As String 'This array holds each item of data from the csv file
        Dim num, counter, Num_cars As Integer
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("E:\I.T\Unit 3\Docs\Outcome 2\Energy.csv")
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
                        MsgBox(currentField)
                        data(num) = currentField
                        ' MsgBox(dat(num), MsgBoxStyle.OkOnly)
                    Next
                    ' error reporting
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using

        '  MsgBox("num =" & Str(num))
        ' put data into arrays
        Dim cars(5) As String
        Dim price(5) As Integer
        Num_cars = 0
        ' break single dat array into two arrays
        For counter = 1 To num Step 2
            Num_cars = Num_cars + 1
            cars(Num_cars) = data(counter)
            price(Num_cars) = data(counter + 1)
        Next

        ' display cars and prices
        For counter = 1 To Num_cars
            MsgBox(cars(counter) & "  $" & price(counter))
        Next

        If rdo_gas.Checked = True Then
            If gas(Val(nud_people.Text)) > Val(txt_enter.Text) Then
                Form2.lbl_message.Text = "Congratulations!"
            ElseIf Val(txt_enter.Text) - gas(nud_people.Value) < 1 Then
                Form2.lbl_message.Text = "Perhaps consider insulating?"
            ElseIf Val(txt_enter.Text) - gas(nud_people.Value) > 1 Then
                Form2.lbl_message.Text = "Perhaps consider insulating turning off the second fridge?"
            End If
        End If

        If rdo_electric.Checked = True Then
            If elec(Val(nud_people.Text)) > Val(txt_enter.Text) Then
                Form2.lbl_message.Text = "Congratulations!"
            ElseIf Val(txt_enter.Text) - elec(nud_people.Value) < 1 Then
                Form2.lbl_message.Text = "Perhaps consider insulating?"
            ElseIf Val(txt_enter.Text) - elec(nud_people.Value) > 1 Then
                Form2.lbl_message.Text = "Perhaps consider insulating and turning off the second fridge?"
            End If
        End If



    End Sub

    Private Sub btn_clr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clr.Click

        nud_people.Value = 1
        txt_enter.Clear()
        txt_enter.Text = "Enter daily kWh"
        txt_enter.ForeColor = Color.Gray
        nud_people.Focus()
        Form2.lbl_message.Text = ""
        pb_alone.Visible = False
        txt_enter.SelectAll()

    End Sub

    Private Sub txt_enter_GotFocus(sender As Object, e As System.EventArgs) Handles txt_enter.GotFocus
        txt_enter.SelectAll()
    End Sub

    Private Sub txt_enter_TextChanged(sender As Object, e As System.EventArgs) Handles txt_enter.TextChanged
        txt_enter.ForeColor = Color.Black
    End Sub

End Class
