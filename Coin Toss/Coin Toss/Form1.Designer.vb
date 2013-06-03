<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbo_coin = New System.Windows.Forms.ListBox()
        Me.btn_toss = New System.Windows.Forms.Button()
        Me.btn_clr = New System.Windows.Forms.Button()
        Me.lbl_heads = New System.Windows.Forms.Label()
        Me.lbl_tails = New System.Windows.Forms.Label()
        Me.btn_dice = New System.Windows.Forms.Button()
        Me.lbl_odds = New System.Windows.Forms.Label()
        Me.lbl_evens = New System.Windows.Forms.Label()
        Me.lbo_throw = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lbo_coin
        '
        Me.lbo_coin.FormattingEnabled = True
        Me.lbo_coin.Location = New System.Drawing.Point(12, 12)
        Me.lbo_coin.Name = "lbo_coin"
        Me.lbo_coin.Size = New System.Drawing.Size(95, 225)
        Me.lbo_coin.TabIndex = 0
        '
        'btn_toss
        '
        Me.btn_toss.Location = New System.Drawing.Point(353, 181)
        Me.btn_toss.Name = "btn_toss"
        Me.btn_toss.Size = New System.Drawing.Size(75, 23)
        Me.btn_toss.TabIndex = 1
        Me.btn_toss.Text = "Toss"
        Me.btn_toss.UseVisualStyleBackColor = True
        '
        'btn_clr
        '
        Me.btn_clr.Location = New System.Drawing.Point(353, 210)
        Me.btn_clr.Name = "btn_clr"
        Me.btn_clr.Size = New System.Drawing.Size(75, 23)
        Me.btn_clr.TabIndex = 2
        Me.btn_clr.Text = "Clear"
        Me.btn_clr.UseVisualStyleBackColor = True
        '
        'lbl_heads
        '
        Me.lbl_heads.AutoSize = True
        Me.lbl_heads.Location = New System.Drawing.Point(291, 80)
        Me.lbl_heads.Name = "lbl_heads"
        Me.lbl_heads.Size = New System.Drawing.Size(62, 13)
        Me.lbl_heads.TabIndex = 3
        Me.lbl_heads.Text = "stub_heads"
        Me.lbl_heads.Visible = False
        '
        'lbl_tails
        '
        Me.lbl_tails.AutoSize = True
        Me.lbl_tails.Location = New System.Drawing.Point(291, 109)
        Me.lbl_tails.Name = "lbl_tails"
        Me.lbl_tails.Size = New System.Drawing.Size(51, 13)
        Me.lbl_tails.TabIndex = 4
        Me.lbl_tails.Text = "stub_tails"
        Me.lbl_tails.Visible = False
        '
        'btn_dice
        '
        Me.btn_dice.Location = New System.Drawing.Point(353, 152)
        Me.btn_dice.Name = "btn_dice"
        Me.btn_dice.Size = New System.Drawing.Size(75, 23)
        Me.btn_dice.TabIndex = 5
        Me.btn_dice.Text = "Throw"
        Me.btn_dice.UseVisualStyleBackColor = True
        '
        'lbl_odds
        '
        Me.lbl_odds.AutoSize = True
        Me.lbl_odds.Location = New System.Drawing.Point(291, 279)
        Me.lbl_odds.Name = "lbl_odds"
        Me.lbl_odds.Size = New System.Drawing.Size(56, 13)
        Me.lbl_odds.TabIndex = 7
        Me.lbl_odds.Text = "stub_odds"
        Me.lbl_odds.Visible = False
        '
        'lbl_evens
        '
        Me.lbl_evens.AutoSize = True
        Me.lbl_evens.Location = New System.Drawing.Point(291, 250)
        Me.lbl_evens.Name = "lbl_evens"
        Me.lbl_evens.Size = New System.Drawing.Size(62, 13)
        Me.lbl_evens.TabIndex = 6
        Me.lbl_evens.Text = "stub_evens"
        Me.lbl_evens.Visible = False
        '
        'lbo_throw
        '
        Me.lbo_throw.FormattingEnabled = True
        Me.lbo_throw.Location = New System.Drawing.Point(113, 12)
        Me.lbo_throw.Name = "lbo_throw"
        Me.lbo_throw.Size = New System.Drawing.Size(95, 225)
        Me.lbo_throw.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 369)
        Me.Controls.Add(Me.lbo_throw)
        Me.Controls.Add(Me.lbl_odds)
        Me.Controls.Add(Me.lbl_evens)
        Me.Controls.Add(Me.btn_dice)
        Me.Controls.Add(Me.lbl_tails)
        Me.Controls.Add(Me.lbl_heads)
        Me.Controls.Add(Me.btn_clr)
        Me.Controls.Add(Me.btn_toss)
        Me.Controls.Add(Me.lbo_coin)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbo_coin As System.Windows.Forms.ListBox
    Friend WithEvents btn_toss As System.Windows.Forms.Button
    Friend WithEvents btn_clr As System.Windows.Forms.Button
    Friend WithEvents lbl_heads As System.Windows.Forms.Label
    Friend WithEvents lbl_tails As System.Windows.Forms.Label
    Friend WithEvents btn_dice As System.Windows.Forms.Button
    Friend WithEvents lbl_odds As System.Windows.Forms.Label
    Friend WithEvents lbl_evens As System.Windows.Forms.Label
    Friend WithEvents lbo_throw As System.Windows.Forms.ListBox

End Class
