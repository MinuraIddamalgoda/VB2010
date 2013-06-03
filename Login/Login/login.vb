Public Class login
    Dim user_hover As New Font("Sans Sherif", 8.25, FontStyle.Underline)
    Dim user_leave As New Font("Sans Sherif", 8.25, FontStyle.Regular)
    Private Sub lbl_create_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub lbl_create_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub lbl_create_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub txt_username_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_username.GotFocus
        txt_username.ForeColor = Color.Black
    End Sub
    Private Sub txt_pass_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_pass.GotFocus
        txt_pass.ForeColor = Color.Black
    End Sub

    Private Sub fake_laod()
        Me.Enabled = False
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If UsersTableAdapter1.Login(txt_username.Text, txt_pass.Text) = True Then
            Me.Hide()
            Form2.Show()
        Else
            MessageBox.Show("You have entered the incorrect username or password" & vbCr & vbCr & "Would you like to create a new account?", "Incorrect credentials!", MessageBoxButtons.OKCancel)
            If DialogResult.OK Then
                Me.Enabled = False
                create.Show()
                create.Enabled = True
            ElseIf DialogResult.Retry Then
                Me.Enabled = True
                Me.Show()
            End If
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
End Class
