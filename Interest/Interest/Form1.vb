Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim rate, amount, interest, month As Single
        Dim month As Integer = 0

        interest = Int(txt_interest.Text)
        Print("Rate = 1%/month Amount = $1000")
        'set the interest rate and amount of money
        rate = 0.01
        amount = 1000
        month = 0
        Print "month"; Tab(10); "interest"; Tab(20); "amount" 
        While amount < 1200
            month = month + 1
            interest = amount * rate
            amount = amount + interest
Print Format(month, "###"); Tab(10);
Print Format(interest, "currency"); Tab(20);
            Print(Format(amount, "currency"))
        End While

    End Sub
End Class
