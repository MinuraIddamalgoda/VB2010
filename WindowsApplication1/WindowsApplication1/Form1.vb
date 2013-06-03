Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Array(10), Max, Min As Integer
        Max = 0
        Min = 10000

        Randomize()
        For counter = 1 To 10
            Array(counter) = Int(Rnd() * 100 + 1)
            ListBox1.Items.Add(Array(counter))
            For counter_2 = 1 To 10
                If Array(counter) > Max Then
                    Max = Array(counter)
                ElseIf Array(counter) < Min Then
                    Min = Array(counter)
                End If
            Next
        Next

        lbl_lower.Text = Min
        lbl_upper.Text = Max

    End Sub
End Class
