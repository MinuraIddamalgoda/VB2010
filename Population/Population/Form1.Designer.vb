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
        Me.txt_male = New System.Windows.Forms.TextBox()
        Me.txt_female = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_clr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Male population "
        '
        'txt_male
        '
        Me.txt_male.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_male.Location = New System.Drawing.Point(16, 32)
        Me.txt_male.Name = "txt_male"
        Me.txt_male.Size = New System.Drawing.Size(143, 20)
        Me.txt_male.TabIndex = 1
        '
        'txt_female
        '
        Me.txt_female.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_female.Location = New System.Drawing.Point(231, 32)
        Me.txt_female.Name = "txt_female"
        Me.txt_female.Size = New System.Drawing.Size(143, 20)
        Me.txt_female.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(227, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Female population "
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(12, 66)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(0, 20)
        Me.lbl_total.TabIndex = 4
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(16, 99)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(80, 42)
        Me.btn_start.TabIndex = 5
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(291, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 42)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "End"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_clr
        '
        Me.btn_clr.Location = New System.Drawing.Point(102, 99)
        Me.btn_clr.Name = "btn_clr"
        Me.btn_clr.Size = New System.Drawing.Size(80, 42)
        Me.btn_clr.TabIndex = 7
        Me.btn_clr.Text = "Clear"
        Me.btn_clr.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 158)
        Me.Controls.Add(Me.btn_clr)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.txt_female)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_male)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_male As System.Windows.Forms.TextBox
    Friend WithEvents txt_female As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_clr As System.Windows.Forms.Button

End Class
