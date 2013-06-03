Public Class Create

    Private Sub lbl_tos_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbl_tos.LinkClicked
        TOS.Show()
    End Sub

    Private Sub btn_create_Click(sender As System.Object, e As System.EventArgs) Handles btn_create.Click

        Dim new_user As String = Generate.Hash(txt_user.Text)
        Dim new_pass As String = Generate.Hash(txt_pass.Text)

        ' write information in arrays back to the text file
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(My.Resources.users, True)
        file.WriteLine(new_user & "," & new_pass & vbCr)
        file.Close()

        Generate.users(UBound(Generate.users)) = new_user
        Generate.pass(UBound(Generate.pass)) = new_pass

        MsgBox(Generate.users(UBound(Generate.users)))


        LoginForm1.Enabled = True
        LoginForm1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        LoginForm1.Enabled = True
        LoginForm1.Show()

        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If txt_user.Text = "Username" Or txt_user.Text = "" Then
            txt_user.ForeColor = Color.Gray
            txt_user.Text = "Username"
            txt_user.SelectAll()
        End If

        If txt_pass.Text = "********" Or txt_pass.Text = "" Then
            txt_pass.ForeColor = Color.Gray
            txt_pass.Text = "Password"
            txt_pass.SelectAll()
        End If

        If chk_agree.Checked = True Then
            btn_create.Enabled = True
        End If

    End Sub

    Private Sub txt_user_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_user.TextChanged
        txt_user.ForeColor = Color.Black
    End Sub

    Private Sub txt_pass_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_pass.TextChanged
        txt_pass.ForeColor = Color.Black
    End Sub
End Class