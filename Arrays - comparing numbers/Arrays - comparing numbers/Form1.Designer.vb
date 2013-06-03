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
        Me.btn_end = New System.Windows.Forms.Button()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.lbo_num1 = New System.Windows.Forms.ListBox()
        Me.lbo_num2 = New System.Windows.Forms.ListBox()
        Me.lbo_compare = New System.Windows.Forms.ListBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_end
        '
        Me.btn_end.Location = New System.Drawing.Point(357, 225)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(75, 23)
        Me.btn_end.TabIndex = 0
        Me.btn_end.Text = "End"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(276, 225)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(75, 23)
        Me.btn_start.TabIndex = 1
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'lbo_num1
        '
        Me.lbo_num1.FormattingEnabled = True
        Me.lbo_num1.Location = New System.Drawing.Point(12, 22)
        Me.lbo_num1.Name = "lbo_num1"
        Me.lbo_num1.Size = New System.Drawing.Size(78, 199)
        Me.lbo_num1.TabIndex = 2
        '
        'lbo_num2
        '
        Me.lbo_num2.FormattingEnabled = True
        Me.lbo_num2.Location = New System.Drawing.Point(96, 22)
        Me.lbo_num2.Name = "lbo_num2"
        Me.lbo_num2.Size = New System.Drawing.Size(78, 199)
        Me.lbo_num2.TabIndex = 3
        '
        'lbo_compare
        '
        Me.lbo_compare.FormattingEnabled = True
        Me.lbo_compare.Location = New System.Drawing.Point(180, 22)
        Me.lbo_compare.Name = "lbo_compare"
        Me.lbo_compare.Size = New System.Drawing.Size(78, 199)
        Me.lbo_compare.TabIndex = 4
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(195, 225)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 5
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 260)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.lbo_compare)
        Me.Controls.Add(Me.lbo_num2)
        Me.Controls.Add(Me.lbo_num1)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.btn_end)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_end As System.Windows.Forms.Button
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents lbo_num1 As System.Windows.Forms.ListBox
    Friend WithEvents lbo_num2 As System.Windows.Forms.ListBox
    Friend WithEvents lbo_compare As System.Windows.Forms.ListBox
    Friend WithEvents btn_clear As System.Windows.Forms.Button

End Class
