'Include gender to program. Use char. Stop them from typing "male" or "female"
Public Class Form1
    Dim first, last, country, mail As String
    Dim consession As Boolean = False
    Dim fee As Single = 51

    Private Sub bnt_sub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sub.Click
        first = txt_first.Text
        last = txt_last.Text
        mail = txt_mail.Text
        country = cbo_country.SelectedItem
        'Validates first name
        If txt_first.Text = "" Then
            btn_sub.Enabled = False
        Else
            btn_sub.Enabled = True
        End If
        'Validates last name
        If txt_last.Text = "" Then
            btn_sub.Enabled = False
        Else
            btn_sub.Enabled = True
        End If
        'Validates email address
        If InStr(mail, "@") = 0 Then
            MsgBox("Please enter a valid email address")
        End If
        'Validates existance of email address
        If txt_mail.Text = "" Then
            btn_sub.Enabled = False
        Else
            btn_sub.Enabled = True
        End If
        If cbo_country.Text = "Please select" Then
            btn_sub.Enabled = False
        Else
            btn_sub.Enabled = True
        End If
        'Child and adult
        If rdo_child.Checked Then
            fee = 0
            chk_con.Enabled = False
        Else
            fee = 0
            chk_con.Enabled = True
        End If
        If rdo_adult.Checked And chk_con.Checked = True Then
            fee = 45
        End If
        If rdo_adult.Checked And chk_con.Checked = False Then
            fee = 50
        End If
        If chk_con.Checked = True Then
            consession = True
            fee = fee - (fee * 0.1)
        End If
        If fee = 51 Then
            btn_sub.Enabled = False
        Else
            MsgBox("Your fee is $" & fee)
        End If

    End Sub
    Private Sub btn_clr_Click(sender As System.Object, e As System.EventArgs) Handles btn_clr.Click
        txt_first.Text = ""
        txt_last.Text = ""
        txt_mail.Text = ""
        cbo_country.ForeColor = Color.Gray
        cbo_country.Text = "Please select"
        fee = 50
        consession = False
    End Sub
    Private Sub cbo_country_GotFocus(sender As Object, e As System.EventArgs) Handles cbo_country.GotFocus
        cbo_country.ForeColor = Color.Black
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If rdo_child.Checked Then
            fee = 0
            chk_con.Enabled = False
        Else
            fee = 0
            chk_con.Enabled = True
        End If
    End Sub
End Class
