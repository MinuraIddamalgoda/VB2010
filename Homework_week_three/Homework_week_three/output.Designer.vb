<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class output
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
        Me.btn_end = New System.Windows.Forms.Button()
        Me.lbo_name = New System.Windows.Forms.ListBox()
        Me.lbo_sac1 = New System.Windows.Forms.ListBox()
        Me.lbo_sac2 = New System.Windows.Forms.ListBox()
        Me.lbo_total = New System.Windows.Forms.ListBox()
        Me.lbl_avg_sac1 = New System.Windows.Forms.Label()
        Me.lbl_avg_sac2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_end
        '
        Me.btn_end.Location = New System.Drawing.Point(436, 291)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(75, 23)
        Me.btn_end.TabIndex = 0
        Me.btn_end.Text = "Exit"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'lbo_name
        '
        Me.lbo_name.FormattingEnabled = True
        Me.lbo_name.Location = New System.Drawing.Point(12, 36)
        Me.lbo_name.Name = "lbo_name"
        Me.lbo_name.Size = New System.Drawing.Size(102, 225)
        Me.lbo_name.TabIndex = 1
        '
        'lbo_sac1
        '
        Me.lbo_sac1.FormattingEnabled = True
        Me.lbo_sac1.Location = New System.Drawing.Point(144, 36)
        Me.lbo_sac1.Name = "lbo_sac1"
        Me.lbo_sac1.Size = New System.Drawing.Size(102, 225)
        Me.lbo_sac1.TabIndex = 2
        '
        'lbo_sac2
        '
        Me.lbo_sac2.FormattingEnabled = True
        Me.lbo_sac2.Location = New System.Drawing.Point(276, 36)
        Me.lbo_sac2.Name = "lbo_sac2"
        Me.lbo_sac2.Size = New System.Drawing.Size(102, 225)
        Me.lbo_sac2.TabIndex = 3
        '
        'lbo_total
        '
        Me.lbo_total.FormattingEnabled = True
        Me.lbo_total.Location = New System.Drawing.Point(408, 36)
        Me.lbo_total.Name = "lbo_total"
        Me.lbo_total.Size = New System.Drawing.Size(102, 225)
        Me.lbo_total.TabIndex = 4
        '
        'lbl_avg_sac1
        '
        Me.lbl_avg_sac1.AutoSize = True
        Me.lbl_avg_sac1.Location = New System.Drawing.Point(170, 264)
        Me.lbl_avg_sac1.Name = "lbl_avg_sac1"
        Me.lbl_avg_sac1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_avg_sac1.Size = New System.Drawing.Size(71, 13)
        Me.lbl_avg_sac1.TabIndex = 5
        Me.lbl_avg_sac1.Text = "Average: ___"
        '
        'lbl_avg_sac2
        '
        Me.lbl_avg_sac2.AutoSize = True
        Me.lbl_avg_sac2.Location = New System.Drawing.Point(302, 264)
        Me.lbl_avg_sac2.Name = "lbl_avg_sac2"
        Me.lbl_avg_sac2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_avg_sac2.Size = New System.Drawing.Size(71, 13)
        Me.lbl_avg_sac2.TabIndex = 6
        Me.lbl_avg_sac2.Text = "Average: ___"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Student name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(117, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "SAC 1 marks (/40)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(273, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "SAC 2 marks (/60)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(405, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Semester total"
        '
        'output
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 326)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_avg_sac2)
        Me.Controls.Add(Me.lbl_avg_sac1)
        Me.Controls.Add(Me.lbo_total)
        Me.Controls.Add(Me.lbo_sac2)
        Me.Controls.Add(Me.lbo_sac1)
        Me.Controls.Add(Me.lbo_name)
        Me.Controls.Add(Me.btn_end)
        Me.Name = "output"
        Me.Text = "Student Marks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_end As System.Windows.Forms.Button
    Friend WithEvents lbo_name As System.Windows.Forms.ListBox
    Friend WithEvents lbo_sac1 As System.Windows.Forms.ListBox
    Friend WithEvents lbo_sac2 As System.Windows.Forms.ListBox
    Friend WithEvents lbo_total As System.Windows.Forms.ListBox
    Friend WithEvents lbl_avg_sac1 As System.Windows.Forms.Label
    Friend WithEvents lbl_avg_sac2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
