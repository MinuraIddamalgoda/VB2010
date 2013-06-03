Public Class Form1

    Dim past_scrores(12), averages_array(12), averages_final As Integer
    Private Sub btn_calc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calc.Click

        'Disabling/Enabling certain elements
        btn_clr.Enabled = True
        btn_calc.Enabled = False

        For counter = 1 To 12
            'Generates random number between 20 and 32 inclusive and stores it in the 1st listbox
            past_scrores(counter) = Int((32 - 20 + 1) * Rnd() + 20)
            'For future averages use
            averages_array(counter) = past_scrores(counter)
            'Adds numbers to first ListBox
            lbo_shots.Items.Add(past_scrores(counter))
            lbo_shots_sort.Items.Add(past_scrores(counter))
        Next
        lbo_shots_sort.Sorted = True
        'Calculating averages 
        Array.Sort(averages_array)
        For counter = 1 To 8
            averages_final = averages_array(counter) + averages_final
        Next
        averages_final = (averages_final / 8) / 0.93

        'Displaying averages in Label
        lbl_avg.Text = Math.Round(averages_final)

    End Sub
    Private Sub btn_clr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clr.Click

        'Disabling/Enabling certain elements
        btn_clr.Enabled = False
        btn_calc.Enabled = True

        'Clearing the ListBoxes
        lbo_shots.Items.Clear()
        lbo_shots_sort.Items.Clear()
    End Sub
End Class
