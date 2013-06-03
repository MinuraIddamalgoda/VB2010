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
        Me.lbo_shots = New System.Windows.Forms.ListBox()
        Me.lbo_shots_sort = New System.Windows.Forms.ListBox()
        Me.btn_calc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_avg = New System.Windows.Forms.Label()
        Me.btn_clr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbo_shots
        '
        Me.lbo_shots.FormattingEnabled = True
        Me.lbo_shots.Location = New System.Drawing.Point(12, 39)
        Me.lbo_shots.Name = "lbo_shots"
        Me.lbo_shots.Size = New System.Drawing.Size(99, 160)
        Me.lbo_shots.TabIndex = 0
        '
        'lbo_shots_sort
        '
        Me.lbo_shots_sort.FormattingEnabled = True
        Me.lbo_shots_sort.Location = New System.Drawing.Point(117, 39)
        Me.lbo_shots_sort.Name = "lbo_shots_sort"
        Me.lbo_shots_sort.Size = New System.Drawing.Size(99, 160)
        Me.lbo_shots_sort.TabIndex = 1
        '
        'btn_calc
        '
        Me.btn_calc.Location = New System.Drawing.Point(141, 249)
        Me.btn_calc.Name = "btn_calc"
        Me.btn_calc.Size = New System.Drawing.Size(75, 23)
        Me.btn_calc.TabIndex = 2
        Me.btn_calc.Text = "Generate"
        Me.btn_calc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Your average is:"
        '
        'lbl_avg
        '
        Me.lbl_avg.AutoSize = True
        Me.lbl_avg.Location = New System.Drawing.Point(12, 231)
        Me.lbl_avg.Name = "lbl_avg"
        Me.lbl_avg.Size = New System.Drawing.Size(27, 13)
        Me.lbl_avg.TabIndex = 5
        Me.lbl_avg.Text = "stub"
        '
        'btn_clr
        '
        Me.btn_clr.Location = New System.Drawing.Point(60, 249)
        Me.btn_clr.Name = "btn_clr"
        Me.btn_clr.Size = New System.Drawing.Size(75, 23)
        Me.btn_clr.TabIndex = 6
        Me.btn_clr.Text = "Clear"
        Me.btn_clr.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 284)
        Me.Controls.Add(Me.btn_clr)
        Me.Controls.Add(Me.lbl_avg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_calc)
        Me.Controls.Add(Me.lbo_shots_sort)
        Me.Controls.Add(Me.lbo_shots)
        Me.Name = "Form1"
        Me.Text = "Golf Handicap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbo_shots As System.Windows.Forms.ListBox
    Friend WithEvents lbo_shots_sort As System.Windows.Forms.ListBox
    Friend WithEvents btn_calc As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_avg As System.Windows.Forms.Label
    Friend WithEvents btn_clr As System.Windows.Forms.Button

End Class
