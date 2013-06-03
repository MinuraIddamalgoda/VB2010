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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lbl_upper = New System.Windows.Forms.Label()
        Me.lbl_lower = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 292)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 303)
        Me.ListBox1.TabIndex = 2
        '
        'lbl_upper
        '
        Me.lbl_upper.AutoSize = True
        Me.lbl_upper.Location = New System.Drawing.Point(194, 127)
        Me.lbl_upper.Name = "lbl_upper"
        Me.lbl_upper.Size = New System.Drawing.Size(39, 13)
        Me.lbl_upper.TabIndex = 3
        Me.lbl_upper.Text = "Label1"
        '
        'lbl_lower
        '
        Me.lbl_lower.AutoSize = True
        Me.lbl_lower.Location = New System.Drawing.Point(194, 155)
        Me.lbl_lower.Name = "lbl_lower"
        Me.lbl_lower.Size = New System.Drawing.Size(39, 13)
        Me.lbl_lower.TabIndex = 4
        Me.lbl_lower.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 331)
        Me.Controls.Add(Me.lbl_lower)
        Me.Controls.Add(Me.lbl_upper)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lbl_upper As System.Windows.Forms.Label
    Friend WithEvents lbl_lower As System.Windows.Forms.Label

End Class
