Public Class Home_Form
    Public Students(5) As String
    Public avg_1, avg_2 As String
    Public total(5), avg_total As Decimal
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sac1.Click
        Me.Enabled.GetType()
        If Me.Enabled = True Then
            Me.Enabled = False
        End If
        SAC_1.Show()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sac2.Click
        Me.Enabled = False
        SAC_2.Show()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Enabled = False
        output.Show()

        Students(1) = "Adrian"
        Students(2) = "Brian"
        Students(3) = "Charlie"
        Students(4) = "Dustin"
        Students(5) = "Edward"

        For counter = 1 To 5
            output.lbo_name.Items.Add(Students(counter))
            output.lbo_sac1.Items.Add(SAC_1.marks_1(counter))
            output.lbo_sac2.Items.Add(SAC_2.marks_2(counter))
            total(counter) = (Val(SAC_1.marks_1(counter)) + Val(SAC_2.marks_2(counter)))
            output.lbo_total.Items.Add(total(counter))
        Next

        output.lbl_avg_sac1.Text = "Average: " & SAC_1.avg_1
        output.lbl_avg_sac2.Text = "Average: " & SAC_2.avg_2

    End Sub
End Class