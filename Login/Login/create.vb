Public Class create
    Dim user_hover As New Font("Sans Sherif", 8.25, FontStyle.Underline)
    Dim user_leave As New Font("Sans Sherif", 8.25, FontStyle.Regular)

    Private Sub lbl_create_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_create.MouseHover
        lbl_create.Font = user_hover
    End Sub

    Private Sub lbl_create_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_create.MouseLeave
        lbl_create.Font = user_leave
    End Sub

    Private Sub lbl_create_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_create.Click
        Me.Hide()
        login.Enabled = True
        login.Show()
    End Sub

    Private Sub txt_username_create_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_username_create.TextChanged
        txt_username_create.ForeColor = Color.Black
    End Sub

    Private Sub txt_pass_crate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pass_create.TextChanged
        txt_pass_create.ForeColor = Color.Black
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If txt_username_create.Text = "Enter new username" Or txt_username_create.Text = "" Then
            Me.ep_new_username.SetError(txt_username_create, "Please enter a username")
        End If
        If txt_pass_create.Text = "Enter new password" Or txt_pass_create.Text = "" Then
            Me.ep_new_pass.SetError(txt_pass_create, "Please enter a password")
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class