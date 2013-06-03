Public Class Form1
    Dim fm, m, total As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txt_male_GotFocus(sender As Object, e As System.EventArgs) Handles txt_male.GotFocus
        'txt_male.Text = " "
        'txt_male.ForeColor = Color.Black
    End Sub

    Private Sub txt_male_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_male.TextChanged
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub txt_female_GotFocus(sender As Object, e As System.EventArgs) Handles txt_female.GotFocus
        'txt_female.Text = " "
        'txt_female.ForeColor = Color.Black
    End Sub

    Private Sub txt_female_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_female.TextChanged

    End Sub

    Private Sub lbl_total_Click(sender As System.Object, e As System.EventArgs) Handles lbl_total.Click

    End Sub

    Private Sub btn_start_Click(sender As System.Object, e As System.EventArgs) Handles btn_start.Click
        'This program calculates the total population of the counrty
        fm = Val(txt_female.Text)
        m = Val(txt_male.Text)
        If m > 1000000000 Then
            MsgBox("Sorry, numbers more than one billion aren't allowed")
            Exit Sub

        End If
        total = fm + m
        If total = 1 Then
            lbl_total.Text = "The total population consists of " & total & " person"
        Else
            lbl_total.Text = "The total population consists of " & total & " people"
        End If
    End Sub

    Private Sub btn_clr_Click(sender As System.Object, e As System.EventArgs) Handles btn_clr.Click
        txt_female.Text = " "
        txt_male.Text = " "
        lbl_total.Text = " "
    End Sub
End Class
