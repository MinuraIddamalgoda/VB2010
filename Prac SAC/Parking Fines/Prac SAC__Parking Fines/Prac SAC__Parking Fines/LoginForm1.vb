Imports System.Text
Public Class LoginForm1
    Dim pass_validate, user_validate As Boolean
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Generate.users.Contains(Generate.Hash(txt_user.Text)) Then
            user_validate = True
        Else
            user_validate = False
            ErrorProvider1.SetError(txt_user, "Incorrect username")
        End If
        If Generate.pass.Contains(Generate.Hash(txt_pass.Text)) Then
            pass_validate = True
        Else
            pass_validate = False
            ErrorProvider1.SetError(txt_pass, "Incorrect password")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_text.Tick
        If txt_user.Text = "Username" Or txt_user.Text = "" Then
            txt_user.ForeColor = Color.Gray
            txt_user.Text = "Username"
            txt_user.SelectAll()
        End If

        If txt_pass.Text = "Password" Or txt_pass.Text = "" Then
            txt_pass.ForeColor = Color.Gray
            txt_pass.Text = "Password"
            txt_pass.SelectAll()
        End If

    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_user.TextChanged
        txt_user.ForeColor = Color.Black
    End Sub

    Private Sub PasswordTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_pass.TextChanged
        txt_pass.ForeColor = Color.Black
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Create.Show()
        Me.Enabled = False
    End Sub
    Public Function CalculateHash(ByVal input As String) As String
        Dim hash As String = System.Security.Cryptography.MD5.Create(input).ToString()
        Return hash
    End Function

    Private Sub Timer_login_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_login.Tick
        If user_validate = True And pass_validate = True Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class
