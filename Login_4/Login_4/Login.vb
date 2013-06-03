Public Class Login
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        Dim INT As Integer = 1
        'If UsernameTextBox.Text = "Admin" Then
        '    INT = 2
        'End If
        If Not UsersTableAdapter1.Login(UsernameTextBox.Text, PasswordTextBox.Text, INT) = Nothing Then
            If UsersTableAdapter1.GetRank(UsernameTextBox.Text) = 1 Then
                MsgBox("Logged in as regular")
            Else
                MsgBox("Logged in as admin")
            End If
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Invalid username/password")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_create.Click
        CreateAccount.Show()
        Me.Enabled = False

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If UsernameTextBox.Text = "Username" Or UsernameTextBox.Text = "" Then
            UsernameTextBox.ForeColor = Color.Gray
            UsernameTextBox.Text = "Username"
            UsernameTextBox.SelectAll()
        End If

        If PasswordTextBox.Text = "Password" Or PasswordTextBox.Text = "" Then
            PasswordTextBox.ForeColor = Color.Gray
            PasswordTextBox.Text = "Password"
            PasswordTextBox.SelectAll()
        End If
    End Sub
    Private Sub UsernameTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged
        UsernameTextBox.ForeColor = Color.Black
    End Sub

    Private Sub PasswordTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged
        PasswordTextBox.ForeColor = Color.Black
    End Sub
End Class
