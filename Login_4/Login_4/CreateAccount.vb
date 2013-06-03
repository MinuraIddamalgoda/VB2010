
Public Class CreateAccount
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Login.Enabled = True
        Login.Show()

        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
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

    Private Sub btn_create_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_create.Click
        Timer1.Enabled = False

        If Login.UsersTableAdapter1.CheckUsername(txt_user.Text) = Nothing Then
            Dim INT As Integer = 1
            If chk_admin.Checked = True Then
                INT = 2
            End If
            Login.UsersTableAdapter1.CreateAccount(txt_user.Text, txt_pass.Text, INT)
            If Login.UsersTableAdapter1.GetRank(txt_user.Text) = 1 Then
                MsgBox("Regular account created")
            Else
                MsgBox("Created Admin")
            End If
            MsgBox("Already taken")
        End If

    End Sub
    Private Sub txt_user_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_user.TextChanged
        txt_user.ForeColor = Color.Black
    End Sub

    Private Sub txt_pass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pass.TextChanged
        txt_pass.ForeColor = Color.Black
    End Sub

End Class