Public Class Form2
    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btn_one_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_one.Click
        btn_one.Focus()
        Surprriiiiseeeee()
    End Sub

    Private Sub btn_one_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_one.GotFocus
        btn_one.Clear()
        btn_one.ForeColor = Color.Black
    End Sub

    Private Sub btn_one_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_one.LostFocus
        btn_one.Text = "Please enter text"
        btn_one.ForeColor = Color.Gray
    End Sub

    Private Sub btn_one_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_one.TextChanged

    End Sub

    Private Sub btn_two_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_two.GotFocus
        btn_two.Clear()
        btn_two.ForeColor = Color.Black
    End Sub

    Private Sub btn_two_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_two.LostFocus
        btn_two.Text = "Please enter text"
        btn_two.ForeColor = Color.Gray
    End Sub

    Private Sub btn_two_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_two.TextChanged
        btn_two.Focus()
    End Sub

    Private Sub btn_three_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_three.GotFocus

    End Sub

    Private Sub btn_three_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_three.TextChanged

    End Sub

    Private Sub Surprriiiiseeeee()
        MsgBox("Are you surprised?" & vbCr & vbCr & MessageBoxButtons.YesNo)
    End Sub
End Class
