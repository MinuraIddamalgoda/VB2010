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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_days = New System.Windows.Forms.CheckBox()
        Me.chk_months = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdo_sub = New System.Windows.Forms.RadioButton()
        Me.rdo_add = New System.Windows.Forms.RadioButton()
        Me.dat_picker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date:"
        '
        'chk_days
        '
        Me.chk_days.AutoSize = True
        Me.chk_days.Location = New System.Drawing.Point(6, 19)
        Me.chk_days.Name = "chk_days"
        Me.chk_days.Size = New System.Drawing.Size(50, 17)
        Me.chk_days.TabIndex = 4
        Me.chk_days.Text = "Days"
        Me.chk_days.UseVisualStyleBackColor = True
        '
        'chk_months
        '
        Me.chk_months.AutoSize = True
        Me.chk_months.Location = New System.Drawing.Point(6, 45)
        Me.chk_months.Name = "chk_months"
        Me.chk_months.Size = New System.Drawing.Size(61, 17)
        Me.chk_months.TabIndex = 5
        Me.chk_months.Text = "Months"
        Me.chk_months.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdo_sub)
        Me.GroupBox1.Controls.Add(Me.rdo_add)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(90, 75)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select one"
        '
        'rdo_sub
        '
        Me.rdo_sub.AutoSize = True
        Me.rdo_sub.Location = New System.Drawing.Point(9, 44)
        Me.rdo_sub.Name = "rdo_sub"
        Me.rdo_sub.Size = New System.Drawing.Size(65, 17)
        Me.rdo_sub.TabIndex = 1
        Me.rdo_sub.TabStop = True
        Me.rdo_sub.Text = "Subtract"
        Me.rdo_sub.UseVisualStyleBackColor = True
        '
        'rdo_add
        '
        Me.rdo_add.AutoSize = True
        Me.rdo_add.Location = New System.Drawing.Point(9, 21)
        Me.rdo_add.Name = "rdo_add"
        Me.rdo_add.Size = New System.Drawing.Size(44, 17)
        Me.rdo_add.TabIndex = 0
        Me.rdo_add.TabStop = True
        Me.rdo_add.Text = "Add"
        Me.rdo_add.UseVisualStyleBackColor = True
        '
        'dat_picker
        '
        Me.dat_picker.Location = New System.Drawing.Point(51, 9)
        Me.dat_picker.Name = "dat_picker"
        Me.dat_picker.Size = New System.Drawing.Size(200, 20)
        Me.dat_picker.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_days)
        Me.GroupBox2.Controls.Add(Me.chk_months)
        Me.GroupBox2.Location = New System.Drawing.Point(161, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(90, 75)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select one"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(12, 140)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(81, 17)
        Me.lbl_date.TabIndex = 8
        Me.lbl_date.Text = "StubbyStub"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 169)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.dat_picker)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_days As System.Windows.Forms.CheckBox
    Friend WithEvents chk_months As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_sub As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_add As System.Windows.Forms.RadioButton
    Friend WithEvents dat_picker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_date As System.Windows.Forms.Label

End Class
