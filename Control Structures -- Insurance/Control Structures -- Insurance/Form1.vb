Public Class Form1
    'This program calculates the annual premium on life insurance 
    Dim ins_val, IP, loading As Decimal
    Dim Age As Integer
    Private Sub btn_start_Click(sender As System.Object, e As System.EventArgs) Handles btn_start.Click

        'Giving variables values
        ins_val = Val(txt_ins_value.Text)
        IP = 300
        Age = Val(cbo_age.Text)

        'Checks if user is a pensioner
        If chk_pen.Checked = True Then
            IP = IP * 0.9
            lbo_list.Items.Add("Pensioner --> -10% from premium")
            lbo_list.Items.Add("Premium: $" & IP)
            ins_val = ins_val + IP
            lbo_list.Items.Add("Sub total: $" & ins_val)
            lbo_list.Items.Add(" ")
        End If

        'Checks for gender loading
        If rdo_male.Checked = True Then
            loading = IP + (IP * 0.85)
            lbo_list.Items.Add("Male --> +15% to premium")
            lbo_list.Items.Add("Premium: $" & loading)
            ins_val = ins_val + loading
            lbo_list.Items.Add("Sub total: $" & ins_val)
            lbo_list.Items.Add(" ")
        Else
            loading = IP + (IP * 0.85)
            lbo_list.Items.Add("Female --> +10% to premium")
            lbo_list.Items.Add("Premium: $" & loading)
            ins_val = ins_val + loading
            lbo_list.Items.Add("Sub total: $" & ins_val)
            lbo_list.Items.Add(" ")
        End If

        'Checks for smoker status
        If chk_smoko.Checked = True Then
            IP = IP + (IP * 0.5)
            lbo_list.Items.Add("Smoker --> +50% to premium")
            lbo_list.Items.Add("Premium: $" & IP)
            ins_val = ins_val + IP
            lbo_list.Items.Add("Sub total: $" & ins_val)
            lbo_list.Items.Add(" ")
        End If

        'Disabling user input until ListBox is cleared
        txt_ins_value.Enabled = False
        cbo_age.Enabled = False
        rdo_male.Enabled = False
        rdo_female.Enabled = False
        btn_start.Enabled = False
        chk_pen.Checked = False
        chk_smoko.Enabled = False
        btn_clr.Enabled = True

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btn_clr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clr.Click
        txt_ins_value.Enabled = True
        cbo_age.Enabled = True
        rdo_male.Enabled = True
        rdo_female.Enabled = True
        btn_start.Enabled = True
        chk_pen.Checked = True
        chk_smoko.Enabled = True
        lbo_list.Items.Clear()
        btn_start.Enabled = True



    End Sub
End Class
