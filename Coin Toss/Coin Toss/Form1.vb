Public Class Form1
    Dim coin, heads_count, tails_count As Integer
    Dim land_1, land_2, land_3, even_count, odds_count As Integer
    Private Sub btn_toss_Click(sender As System.Object, e As System.EventArgs) Handles btn_toss.Click
        'Toss 10 coins
        Randomize()
        heads_count = 0
        tails_count = 0
        For counter = 1 To 10
            coin = Int(Rnd() * 2)

            If coin = 0 Then
                lbo_coin.Items.Add("Heads")
                heads_count = heads_count + 1
            Else
                lbo_coin.Items.Add("Tails")
                tails_count = tails_count + 1
            End If
        Next

        lbl_heads.Visible = True
        lbl_tails.Visible = True
        lbl_heads.Text = "There are " & Str(heads_count) & " heads"
        lbl_tails.Text = "There are " & Str(tails_count) & " tails"
    End Sub
    Private Sub lbo_coin_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lbo_coin.SelectedIndexChanged

    End Sub
    Private Sub btn_clr_Click(sender As System.Object, e As System.EventArgs) Handles btn_clr.Click
        lbo_coin.Items.Clear()
    End Sub

    Public Sub btn_dice_Click(sender As System.Object, e As System.EventArgs) Handles btn_dice.Click
        Randomize()

        For counter = 1 To 10

            'If coin = 0 Then
            '    lbo_coin.Items.Add("Heads")
            '    heads_count = heads_count + 1
            'Else
            '    lbo_coin.Items.Add("Tails")
            '    tails_count = tails_count + 1
            'End If
        Next

        lbl_heads.Visible = True
        lbl_tails.Visible = True
        lbl_heads.Text = "There are " & Str(heads_count) & " heads"
        lbl_tails.Text = "There are " & Str(tails_count) & " tails"
    End Sub
    Public Sub Rand_dice()
        Int(Rnd() * 5)
    End Sub
End Class
