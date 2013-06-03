Public Class Form1

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
        
    End Sub

    Private Sub btn_start_Click(sender As System.Object, e As System.EventArgs) Handles btn_start.Click
        Dim name, street, town As String
        Dim pc As Short
        Name = txt_name.Text
        street = txt_street.Text
        town = txt_town.Text
        pc = Val(txt_pc.Text)
        If pc < 1000 Or pc > 9999 Then
            MsgBox("Error, that isn't a valid post code")
        End If
        MsgBox(name & vbCr & street & vbCr & town & vbCr & pc)
    End Sub

    Private Sub btn_clr_Click(sender As System.Object, e As System.EventArgs) Handles btn_clr.Click
        txt_name.Text = " "
        txt_pc.Text = " "
        txt_street.Text = " "
        txt_town.Text = " "
    End Sub
End Class
