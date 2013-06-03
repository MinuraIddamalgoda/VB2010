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
        Me.components = New System.ComponentModel.Container()
        Me.lbo_trans = New System.Windows.Forms.ListBox()
        Me.txt_trans = New System.Windows.Forms.TextBox()
        Me.btn_dep = New System.Windows.Forms.Button()
        Me.btn_wd = New System.Windows.Forms.Button()
        Me.tm_balance = New System.Windows.Forms.Timer(Me.components)
        Me.lable1 = New System.Windows.Forms.Label()
        Me.lbl_balance = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbo_trans
        '
        Me.lbo_trans.FormattingEnabled = True
        Me.lbo_trans.Items.AddRange(New Object() {"Transactions appear here"})
        Me.lbo_trans.Location = New System.Drawing.Point(12, 67)
        Me.lbo_trans.Name = "lbo_trans"
        Me.lbo_trans.Size = New System.Drawing.Size(156, 160)
        Me.lbo_trans.TabIndex = 0
        '
        'txt_trans
        '
        Me.txt_trans.ForeColor = System.Drawing.Color.Gray
        Me.txt_trans.Location = New System.Drawing.Point(12, 12)
        Me.txt_trans.Name = "txt_trans"
        Me.txt_trans.Size = New System.Drawing.Size(156, 20)
        Me.txt_trans.TabIndex = 1
        Me.txt_trans.Text = "Enter transaction amount here"
        '
        'btn_dep
        '
        Me.btn_dep.Location = New System.Drawing.Point(12, 38)
        Me.btn_dep.Name = "btn_dep"
        Me.btn_dep.Size = New System.Drawing.Size(75, 23)
        Me.btn_dep.TabIndex = 2
        Me.btn_dep.Text = "Deposit"
        Me.btn_dep.UseVisualStyleBackColor = True
        '
        'btn_wd
        '
        Me.btn_wd.Location = New System.Drawing.Point(93, 38)
        Me.btn_wd.Name = "btn_wd"
        Me.btn_wd.Size = New System.Drawing.Size(75, 23)
        Me.btn_wd.TabIndex = 3
        Me.btn_wd.Text = "Withdraw"
        Me.btn_wd.UseVisualStyleBackColor = True
        '
        'tm_balance
        '
        Me.tm_balance.Enabled = True
        '
        'lable1
        '
        Me.lable1.AutoSize = True
        Me.lable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lable1.Location = New System.Drawing.Point(13, 230)
        Me.lable1.Name = "lable1"
        Me.lable1.Size = New System.Drawing.Size(114, 17)
        Me.lable1.TabIndex = 0
        Me.lable1.Text = "Current Balance:"
        '
        'lbl_balance
        '
        Me.lbl_balance.AutoSize = True
        Me.lbl_balance.Location = New System.Drawing.Point(13, 249)
        Me.lbl_balance.Name = "lbl_balance"
        Me.lbl_balance.Size = New System.Drawing.Size(39, 13)
        Me.lbl_balance.TabIndex = 0
        Me.lbl_balance.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(181, 269)
        Me.Controls.Add(Me.lbl_balance)
        Me.Controls.Add(Me.lable1)
        Me.Controls.Add(Me.btn_wd)
        Me.Controls.Add(Me.btn_dep)
        Me.Controls.Add(Me.txt_trans)
        Me.Controls.Add(Me.lbo_trans)
        Me.Name = "Form1"
        Me.Text = "Banking app"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbo_trans As System.Windows.Forms.ListBox
    Friend WithEvents txt_trans As System.Windows.Forms.TextBox
    Friend WithEvents btn_dep As System.Windows.Forms.Button
    Friend WithEvents btn_wd As System.Windows.Forms.Button
    Friend WithEvents tm_balance As System.Windows.Forms.Timer
    Friend WithEvents lable1 As System.Windows.Forms.Label
    Friend WithEvents lbl_balance As System.Windows.Forms.Label

End Class
