Public Class Login_GUI
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub txt_log_MouseCaptureChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_log.MouseCaptureChanged
        txt_log.ForeColor = Color.Black
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_log.TextChanged
        'txt_log.ForeColor = Color.Black
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click
        
    End Sub

    Private Sub txt_pass_MouseCaptureChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_pass.MouseCaptureChanged
        txt_pass.ForeColor = Color.Black
    End Sub

    Private Sub txt_pass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pass.TextChanged
        'txt_pass.ForeColor = Color.Black
    End Sub
End Class
