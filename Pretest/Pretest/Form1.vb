Public Class Form1
    Dim length, wide, perim, area, num_unit As String
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles lbl_ans.Click

    End Sub

    Private Sub btn_calc_Click(sender As System.Object, e As System.EventArgs) Handles btn_calc.Click
        length = Val(txt_length.Text)
        wide = Val(txt_width.Text)
        perim = (2 * length) + (2 * wide)
        area = length * wide
        num_unit = cb_unit.SelectedItem

        If length = wide Then
            lbl_ans.Text = "Your sqare has an perimeter of " & perim & " " & num_unit & " and an area of " & area & " " & num_unit & " sqaured"
            sqr.Visible = True
            rec.Visible = False
        Else
            lbl_ans.Text = "Your rectangle has an perimeter of " & perim & " " & num_unit & " and an area of " & area & " " & num_unit & " sqaured"
            sqr.Visible = False
            rec.Visible = True
        End If

    End Sub

    Private Sub btn_clr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clr.Click
        lbl_ans.Text = " "
        rec.Visible = False
        sqr.Visible = False
    End Sub

    Private Sub txt_width_Click(sender As Object, e As System.EventArgs) Handles txt_width.Click
        txt_width.ForeColor = Color.Black
        txt_width.Text = ""
    End Sub

    Private Sub txt_width_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_width.LostFocus
        
    End Sub

    Private Sub txt_width_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_width.TextChanged
        
    End Sub

    Private Sub cb_unit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_unit.SelectedIndexChanged
        cb_unit.ForeColor = Color.Black
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub txt_length_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_length.Click
        txt_length.ForeColor = Color.Black
        txt_length.Text = ""
    End Sub

    Private Sub txt_length_ClientSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_length.ClientSizeChanged

    End Sub

    Private Sub txt_length_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_length.TextChanged
        If txt_length.Text <> "Enter length" Then
            txt_length.ForeColor = Color.Black
        End If

    End Sub
End Class
