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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.chk_john = New System.Windows.Forms.CheckBox()
        Me.chk_gary = New System.Windows.Forms.CheckBox()
        Me.chk_steve = New System.Windows.Forms.CheckBox()
        Me.chk_ash = New System.Windows.Forms.CheckBox()
        Me.chk_kieran = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_john = New System.Windows.Forms.TextBox()
        Me.txt_gary = New System.Windows.Forms.TextBox()
        Me.txt_steve = New System.Windows.Forms.TextBox()
        Me.txt_ash = New System.Windows.Forms.TextBox()
        Me.txt_kieran = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Names of emloyees"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_next
        '
        Me.btn_next.Location = New System.Drawing.Point(259, 176)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(75, 23)
        Me.btn_next.TabIndex = 2
        Me.btn_next.Text = "Next"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'chk_john
        '
        Me.chk_john.AutoSize = True
        Me.chk_john.Location = New System.Drawing.Point(155, 39)
        Me.chk_john.Name = "chk_john"
        Me.chk_john.Size = New System.Drawing.Size(78, 17)
        Me.chk_john.TabIndex = 3
        Me.chk_john.Text = "John Smith"
        Me.chk_john.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_john.UseVisualStyleBackColor = True
        '
        'chk_gary
        '
        Me.chk_gary.AutoSize = True
        Me.chk_gary.Location = New System.Drawing.Point(155, 66)
        Me.chk_gary.Name = "chk_gary"
        Me.chk_gary.Size = New System.Drawing.Size(97, 17)
        Me.chk_gary.TabIndex = 4
        Me.chk_gary.Text = "Gary Goodman"
        Me.chk_gary.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_gary.UseVisualStyleBackColor = True
        '
        'chk_steve
        '
        Me.chk_steve.AutoSize = True
        Me.chk_steve.Location = New System.Drawing.Point(155, 92)
        Me.chk_steve.Name = "chk_steve"
        Me.chk_steve.Size = New System.Drawing.Size(113, 17)
        Me.chk_steve.TabIndex = 5
        Me.chk_steve.Text = "Steven Personson"
        Me.chk_steve.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_steve.UseVisualStyleBackColor = True
        '
        'chk_ash
        '
        Me.chk_ash.AutoSize = True
        Me.chk_ash.Location = New System.Drawing.Point(155, 118)
        Me.chk_ash.Name = "chk_ash"
        Me.chk_ash.Size = New System.Drawing.Size(86, 17)
        Me.chk_ash.TabIndex = 6
        Me.chk_ash.Text = "Ashleigh Fay"
        Me.chk_ash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_ash.UseVisualStyleBackColor = True
        '
        'chk_kieran
        '
        Me.chk_kieran.AutoSize = True
        Me.chk_kieran.Location = New System.Drawing.Point(155, 144)
        Me.chk_kieran.Name = "chk_kieran"
        Me.chk_kieran.Size = New System.Drawing.Size(77, 17)
        Me.chk_kieran.TabIndex = 7
        Me.chk_kieran.Text = "Kieran Edit"
        Me.chk_kieran.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_kieran.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Hours worked"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_john
        '
        Me.txt_john.Location = New System.Drawing.Point(35, 37)
        Me.txt_john.Name = "txt_john"
        Me.txt_john.Size = New System.Drawing.Size(100, 20)
        Me.txt_john.TabIndex = 15
        '
        'txt_gary
        '
        Me.txt_gary.Location = New System.Drawing.Point(35, 64)
        Me.txt_gary.Name = "txt_gary"
        Me.txt_gary.Size = New System.Drawing.Size(100, 20)
        Me.txt_gary.TabIndex = 16
        '
        'txt_steve
        '
        Me.txt_steve.Location = New System.Drawing.Point(35, 90)
        Me.txt_steve.Name = "txt_steve"
        Me.txt_steve.Size = New System.Drawing.Size(100, 20)
        Me.txt_steve.TabIndex = 17
        '
        'txt_ash
        '
        Me.txt_ash.Location = New System.Drawing.Point(35, 116)
        Me.txt_ash.Name = "txt_ash"
        Me.txt_ash.Size = New System.Drawing.Size(100, 20)
        Me.txt_ash.TabIndex = 18
        '
        'txt_kieran
        '
        Me.txt_kieran.Location = New System.Drawing.Point(35, 142)
        Me.txt_kieran.Name = "txt_kieran"
        Me.txt_kieran.Size = New System.Drawing.Size(100, 20)
        Me.txt_kieran.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 210)
        Me.Controls.Add(Me.txt_kieran)
        Me.Controls.Add(Me.txt_ash)
        Me.Controls.Add(Me.txt_steve)
        Me.Controls.Add(Me.txt_gary)
        Me.Controls.Add(Me.txt_john)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chk_kieran)
        Me.Controls.Add(Me.chk_ash)
        Me.Controls.Add(Me.chk_steve)
        Me.Controls.Add(Me.chk_gary)
        Me.Controls.Add(Me.chk_john)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents chk_john As System.Windows.Forms.CheckBox
    Friend WithEvents chk_gary As System.Windows.Forms.CheckBox
    Friend WithEvents chk_steve As System.Windows.Forms.CheckBox
    Friend WithEvents chk_ash As System.Windows.Forms.CheckBox
    Friend WithEvents chk_kieran As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_john As System.Windows.Forms.TextBox
    Friend WithEvents txt_gary As System.Windows.Forms.TextBox
    Friend WithEvents txt_steve As System.Windows.Forms.TextBox
    Friend WithEvents txt_ash As System.Windows.Forms.TextBox
    Friend WithEvents txt_kieran As System.Windows.Forms.TextBox

End Class
