Public Class Form1
    Public Shared UserNumber As Integer = 0
    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click

        If chk_john.Checked = True Then
            UserNumber = UserNumber + 1
            txt_john.Enabled = True
        End If
        If chk_steve.Checked = True Then
            UserNumber = UserNumber + 1
            txt_steve.Enabled = True
        End If
        If chk_gary.Checked = True Then
            UserNumber = UserNumber + 1
            txt_gary.Enabled = True
        End If
        If chk_ash.Checked = True Then
            UserNumber = UserNumber + 1
            txt_ash.Enabled = True
        End If
        If chk_kieran.Checked = True Then
            UserNumber = UserNumber + 1
            txt_kieran.Enabled = True
        End If

        Dim employee(UserNumber) As String

        employee(1) = "John Smith"
        employee(2) = "Gary Goodman"
        employee(3) = "Steven Parsonson"
        employee(4) = "Ashleigh Fay"
        employee(5) = "Kieran Edit"


        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub TaxCalc()

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub chk_john_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_john.CheckedChanged

    End Sub
End Class
