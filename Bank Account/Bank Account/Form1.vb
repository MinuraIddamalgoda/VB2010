Public Class Form1
    Dim array_num(0) As String
    Dim OB, WD, DEP, CB, ClosingB As Decimal

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        System.Security.Cryptography.SHA256.Create(Str(CB))

        My.Computer.FileSystem.WriteAllText("closing_balance.txt", CB, False)


    End Sub
    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbo_trans.Focus()
        ReDim array_num(UBound(array_num) + 1)
        OB = Val(InputBox("Make initial deposit to open account", "Opening Bank Account", "Please enter amount here"))
        CB = OB
        array_num(UBound(array_num)) = "$ " & OB & " - OB"
        lbo_trans.Items.Add(array_num(UBound(array_num)))
    End Sub
    Private Sub txt_trans_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_trans.GotFocus
        txt_trans.Clear()
        txt_trans.ForeColor = Color.Black
    End Sub
    Private Sub btn_dep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dep.Click
        ReDim array_num(UBound(array_num) + 1)
        DEP = Val(txt_trans.Text)
        CB = CB + DEP
        array_num(UBound(array_num)) = "$ " & DEP & " - DEP"
        lbo_trans.Items.Add(array_num(UBound(array_num)))
        txt_trans.Focus()
    End Sub

    Private Sub btn_wd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_wd.Click
        WD = Val(txt_trans.Text)

        If CB < WD Then
            MsgBox("Insufficient Funds")
            Exit Sub
        Else
            ReDim array_num(UBound(array_num) + 1)
            CB = CB - WD
            array_num(UBound(array_num)) = "$ " & WD & " - WD"
            lbo_trans.Items.Add(array_num(UBound(array_num)))
        End If

        txt_trans.Focus()
    End Sub
    Private Sub tm_balance_Tick(sender As System.Object, e As System.EventArgs) Handles tm_balance.Tick
        lbl_balance.Text = "$ " & CB
    End Sub
End Class