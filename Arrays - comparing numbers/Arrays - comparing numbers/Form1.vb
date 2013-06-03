Public Class Form1
    
    Public Sub btn_start_Click(sender As System.Object, e As System.EventArgs) Handles btn_start.Click
        Dim quantity As Integer

        quantity = Int(InputBox("How many random numbers do you want?"))

        Dim num1(quantity), num2(quantity) As Integer
        Dim compare(quantity) As String

        Randomize()

        For counter = 1 To quantity
            num1(counter) = Int(Rnd() * 100 + 1)
            num2(counter) = Int(Rnd() * 100) + 1
            lbo_num1.Items.Add(num1(counter))
            lbo_num2.Items.Add(num2(counter))

            If num1(counter) > num2(counter) Then
                compare(counter) = num1(counter) - num2(counter)
                lbo_compare.Items.Add("The first number is higher than the second number")
            ElseIf num1(counter) < num2(counter) Then
                compare(counter) = num2(counter) - num1(counter)
                lbo_compare.Items.Add("The second number is higher than the first number")
            ElseIf num1(counter) = num2(counter) Then
                lbo_compare.Items.Add("The two numbers are the same")
            End If

        Next
    End Sub
    Private Sub btn_clear_Click(sender As System.Object, e As System.EventArgs) Handles btn_clear.Click
        lbo_compare.Items.Clear()
        lbo_num1.Items.Clear()
        lbo_num2.Items.Clear()
    End Sub

    Private Sub btn_end_Click(sender As System.Object, e As System.EventArgs) Handles btn_end.Click
        End
    End Sub

End Class
