Public Class Form2
    'Dim UserNumber As Integer
    Private Sub lbo_net_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub lbo_gross_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub lbo_hours_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub lbo_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'UserNumber = Form1.UserNumber
    End Sub

    Private Sub btn_end_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_end.Click
        End
    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click

    End Sub
    Private Sub ClearLists()
        lbo_name.Items.Clear()
        lbo_gross.Items.Clear()
        lbo_tax.Items.Clear()
        lbo_total.Items.Clear()
    End Sub
End Class