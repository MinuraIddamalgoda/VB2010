Public Class SAC_1
    Public marks_1(5), avg_1 As Decimal
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cont.Click
        If Not IsNumeric(txt_one.Text) And IsNumeric(txt_two.Text) And IsNumeric(txt_three.Text) And IsNumeric(txt_four.Text) And IsNumeric(txt_five.Text) Then
            MsgBox("Please enter numbers only")
            Exit Sub
        Else
            'Putting in SAC marks
            marks_1(1) = Val(txt_one.Text)
            marks_1(2) = Val(txt_two.Text)
            marks_1(3) = Val(txt_three.Text)
            marks_1(4) = Val(txt_four.Text)
            marks_1(5) = Val(txt_five.Text)

            'Calculating averages
            avg_1 = (Val(txt_one.Text) + Val(txt_two.Text) + Val(txt_three.Text) + Val(txt_four.Text) + Val(txt_five.Text)) / 5

            Me.Hide()
            Home_Form.Enabled = True
            Home_Form.Focus()
        End If
    End Sub
    Private Sub txt_one_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_one.GotFocus
        txt_one.ForeColor = Color.Black
        txt_one.Clear()
    End Sub
    Private Sub txt_two_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_two.GotFocus
        txt_two.ForeColor = Color.Black
        txt_two.Clear()
    End Sub
    Private Sub txt_three_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_three.GotFocus
        txt_three.ForeColor = Color.Black
        txt_three.Clear()
    End Sub
    Private Sub txt_four_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_four.GotFocus
        txt_four.ForeColor = Color.Black
        txt_four.Clear()
    End Sub
    Private Sub txt_five_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_five.GotFocus
        txt_five.ForeColor = Color.Black
        txt_five.Clear()
    End Sub

    Private Sub SAC_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub
End Class
