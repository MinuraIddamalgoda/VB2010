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
        Me.btn_start = New System.Windows.Forms.Button()
        Me.lbo_list = New System.Windows.Forms.ListBox()
        Me.txt_ins_value = New System.Windows.Forms.TextBox()
        Me.rdo_male = New System.Windows.Forms.RadioButton()
        Me.rdo_female = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chk_smoko = New System.Windows.Forms.CheckBox()
        Me.chk_pen = New System.Windows.Forms.CheckBox()
        Me.cbo_age = New System.Windows.Forms.ComboBox()
        Me.btn_clr = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(294, 178)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(66, 21)
        Me.btn_start.TabIndex = 0
        Me.btn_start.Text = "Done"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'lbo_list
        '
        Me.lbo_list.FormattingEnabled = True
        Me.lbo_list.Location = New System.Drawing.Point(192, 12)
        Me.lbo_list.Name = "lbo_list"
        Me.lbo_list.Size = New System.Drawing.Size(168, 160)
        Me.lbo_list.TabIndex = 1
        '
        'txt_ins_value
        '
        Me.txt_ins_value.Location = New System.Drawing.Point(15, 25)
        Me.txt_ins_value.Name = "txt_ins_value"
        Me.txt_ins_value.Size = New System.Drawing.Size(132, 20)
        Me.txt_ins_value.TabIndex = 2
        '
        'rdo_male
        '
        Me.rdo_male.AutoSize = True
        Me.rdo_male.Location = New System.Drawing.Point(26, 113)
        Me.rdo_male.Name = "rdo_male"
        Me.rdo_male.Size = New System.Drawing.Size(48, 17)
        Me.rdo_male.TabIndex = 4
        Me.rdo_male.TabStop = True
        Me.rdo_male.Text = "Male"
        Me.rdo_male.UseVisualStyleBackColor = True
        '
        'rdo_female
        '
        Me.rdo_female.AutoSize = True
        Me.rdo_female.Location = New System.Drawing.Point(99, 16)
        Me.rdo_female.Name = "rdo_female"
        Me.rdo_female.Size = New System.Drawing.Size(59, 17)
        Me.rdo_female.TabIndex = 6
        Me.rdo_female.TabStop = True
        Me.rdo_female.Text = "Female"
        Me.rdo_female.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdo_female)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(171, 44)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Gender"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Enter Insurance Amount ($)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Enter Age"
        '
        'chk_smoko
        '
        Me.chk_smoko.AutoSize = True
        Me.chk_smoko.Location = New System.Drawing.Point(15, 149)
        Me.chk_smoko.Name = "chk_smoko"
        Me.chk_smoko.Size = New System.Drawing.Size(114, 17)
        Me.chk_smoko.TabIndex = 18
        Me.chk_smoko.Text = "Are you a smoker?"
        Me.chk_smoko.UseVisualStyleBackColor = True
        '
        'chk_pen
        '
        Me.chk_pen.AutoSize = True
        Me.chk_pen.Location = New System.Drawing.Point(15, 172)
        Me.chk_pen.Name = "chk_pen"
        Me.chk_pen.Size = New System.Drawing.Size(126, 17)
        Me.chk_pen.TabIndex = 19
        Me.chk_pen.Text = "Are you a pensioner?"
        Me.chk_pen.UseVisualStyleBackColor = True
        '
        'cbo_age
        '
        Me.cbo_age.FormattingEnabled = True
        Me.cbo_age.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.cbo_age.Location = New System.Drawing.Point(15, 68)
        Me.cbo_age.Name = "cbo_age"
        Me.cbo_age.Size = New System.Drawing.Size(133, 21)
        Me.cbo_age.TabIndex = 20
        '
        'btn_clr
        '
        Me.btn_clr.Enabled = False
        Me.btn_clr.Location = New System.Drawing.Point(222, 178)
        Me.btn_clr.Name = "btn_clr"
        Me.btn_clr.Size = New System.Drawing.Size(66, 21)
        Me.btn_clr.TabIndex = 21
        Me.btn_clr.Text = "Clear"
        Me.btn_clr.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(372, 208)
        Me.Controls.Add(Me.btn_clr)
        Me.Controls.Add(Me.cbo_age)
        Me.Controls.Add(Me.chk_pen)
        Me.Controls.Add(Me.chk_smoko)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rdo_male)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_ins_value)
        Me.Controls.Add(Me.lbo_list)
        Me.Controls.Add(Me.btn_start)
        Me.MinimumSize = New System.Drawing.Size(388, 246)
        Me.Name = "Form1"
        Me.Text = "Insurance Premium Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents lbo_list As System.Windows.Forms.ListBox
    Friend WithEvents txt_ins_value As System.Windows.Forms.TextBox
    Friend WithEvents rdo_male As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_female As System.Windows.Forms.RadioButton
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_smoko As System.Windows.Forms.CheckBox
    Friend WithEvents chk_pen As System.Windows.Forms.CheckBox
    Friend WithEvents cbo_age As System.Windows.Forms.ComboBox
    Friend WithEvents btn_clr As System.Windows.Forms.Button

End Class
