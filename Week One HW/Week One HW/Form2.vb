Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num1(100), num2(100), c, q As Integer
        Dim compare(100) As String
        q = InputBox("How many numbers do you want?")
        For c = 1 To q
            num1(c) = Int(Rnd() * 100) + 1
            num2(c) = Int(Rnd() * 100) + 1
            If num1(c) > num2(c) Then
                compare(c) = "Larger"
            ElseIf num1(c) < num2(c) Then
                compare(c) = "Smaller"
            Else
                compare(c) = "Equal"
            End If
            lbocompare.Items.Add(num1(c) & num2(c) & compare(c))
        Next
    End Sub
End Class