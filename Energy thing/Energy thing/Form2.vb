Public Class Form2

    Dim total_kwh As Decimal = Val(Form1.txt_enter.Text) * (91)
    Dim usage_charge As Decimal = 0
    Dim total_charge As Decimal = 0

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        lbo_out.Items.Clear()
        Me.Close()
        Form1.Enabled = True

    End Sub

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        usage_charge = (22.066 * total_kwh) + (22.594 * (total_kwh - 1000))
        print()

    End Sub
    Public Sub print()
        total_charge = usage_charge + 86.493

        lbo_out.Items.Add(usage_charge)
        lbo_out.Items.Add("$86.49")
        lbo_out.Items.Add(" ")
        lbo_out.Items.Add(total_charge)

    End Sub
End Class