Imports System.Windows.Forms
Public Class TOS

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Form1.Enabled = True
        Me.Close()
    End Sub
End Class
