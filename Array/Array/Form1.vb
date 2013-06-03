Public Class Form1
    'This program produces a list of students
    Private Sub btn_start_Click(sender As System.Object, e As System.EventArgs) Handles btn_enter.Click
        Dim students(20) As String
        Dim counter, max, mark(20) As Integer

        'Failsafes

        'Input section

        max = Val(InputBox("How many students do you have in your class?"))

        For counter = 1 To max
            Do Until DialogResult.Cancel = True
                students(counter) = InputBox("Please enter student number" & Str(counter))
                students(counter) = InputBox("Please enter student number" & Str(counter) & "'s mark")
                counter = counter + 1
            Loop
        Next

        'Output section
        For counter = 1 To max
            lbo_students.Items.Add(Str(counter) & " " & students(counter))
        Next

    End Sub
End Class
