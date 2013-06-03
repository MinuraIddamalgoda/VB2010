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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_first = New System.Windows.Forms.TextBox()
        Me.txt_last = New System.Windows.Forms.TextBox()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.cbo_country = New System.Windows.Forms.ComboBox()
        Me.btn_sub = New System.Windows.Forms.Button()
        Me.btn_clr = New System.Windows.Forms.Button()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_con = New System.Windows.Forms.CheckBox()
        Me.rdo_child = New System.Windows.Forms.RadioButton()
        Me.rdo_adult = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tt_dob = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Given name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Family name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email address"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Country"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_first
        '
        Me.txt_first.Location = New System.Drawing.Point(126, 33)
        Me.txt_first.Name = "txt_first"
        Me.txt_first.Size = New System.Drawing.Size(184, 20)
        Me.txt_first.TabIndex = 4
        '
        'txt_last
        '
        Me.txt_last.Location = New System.Drawing.Point(126, 59)
        Me.txt_last.Name = "txt_last"
        Me.txt_last.Size = New System.Drawing.Size(184, 20)
        Me.txt_last.TabIndex = 5
        '
        'txt_mail
        '
        Me.txt_mail.Location = New System.Drawing.Point(126, 85)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(184, 20)
        Me.txt_mail.TabIndex = 6
        '
        'cbo_country
        '
        Me.cbo_country.ForeColor = System.Drawing.Color.Gray
        Me.cbo_country.FormattingEnabled = True
        Me.cbo_country.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan"})
        Me.cbo_country.Location = New System.Drawing.Point(126, 111)
        Me.cbo_country.Name = "cbo_country"
        Me.cbo_country.Size = New System.Drawing.Size(184, 21)
        Me.cbo_country.TabIndex = 7
        Me.cbo_country.Text = "Please select"
        '
        'btn_sub
        '
        Me.btn_sub.Location = New System.Drawing.Point(235, 228)
        Me.btn_sub.Name = "btn_sub"
        Me.btn_sub.Size = New System.Drawing.Size(75, 23)
        Me.btn_sub.TabIndex = 8
        Me.btn_sub.Text = "Submit"
        Me.btn_sub.UseVisualStyleBackColor = True
        '
        'btn_clr
        '
        Me.btn_clr.Location = New System.Drawing.Point(155, 228)
        Me.btn_clr.Name = "btn_clr"
        Me.btn_clr.Size = New System.Drawing.Size(75, 23)
        Me.btn_clr.TabIndex = 9
        Me.btn_clr.Text = "Clear"
        Me.btn_clr.UseVisualStyleBackColor = True
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(126, 138)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(184, 20)
        Me.dtp.TabIndex = 10
        Me.tt_dob.SetToolTip(Me.dtp, "DD/MM/YY")
        Me.dtp.Value = New Date(2012, 12, 11, 13, 54, 11, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Date of Birth"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_con
        '
        Me.chk_con.AutoSize = True
        Me.chk_con.Location = New System.Drawing.Point(15, 65)
        Me.chk_con.Name = "chk_con"
        Me.chk_con.Size = New System.Drawing.Size(80, 17)
        Me.chk_con.TabIndex = 12
        Me.chk_con.Text = "Consession"
        Me.chk_con.UseVisualStyleBackColor = True
        '
        'rdo_child
        '
        Me.rdo_child.AutoSize = True
        Me.rdo_child.Location = New System.Drawing.Point(15, 19)
        Me.rdo_child.Name = "rdo_child"
        Me.rdo_child.Size = New System.Drawing.Size(48, 17)
        Me.rdo_child.TabIndex = 13
        Me.rdo_child.TabStop = True
        Me.rdo_child.Text = "Child"
        Me.rdo_child.UseVisualStyleBackColor = True
        '
        'rdo_adult
        '
        Me.rdo_adult.AutoSize = True
        Me.rdo_adult.Location = New System.Drawing.Point(15, 42)
        Me.rdo_adult.Name = "rdo_adult"
        Me.rdo_adult.Size = New System.Drawing.Size(49, 17)
        Me.rdo_adult.TabIndex = 14
        Me.rdo_adult.TabStop = True
        Me.rdo_adult.Text = "Adult"
        Me.rdo_adult.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_con)
        Me.GroupBox1.Controls.Add(Me.rdo_adult)
        Me.GroupBox1.Controls.Add(Me.rdo_child)
        Me.GroupBox1.Location = New System.Drawing.Point(334, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(118, 92)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'tt_dob
        '
        Me.tt_dob.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tt_dob.ToolTipTitle = "Date of birth"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(103, 70)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 266)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.btn_clr)
        Me.Controls.Add(Me.btn_sub)
        Me.Controls.Add(Me.cbo_country)
        Me.Controls.Add(Me.txt_mail)
        Me.Controls.Add(Me.txt_last)
        Me.Controls.Add(Me.txt_first)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_first As System.Windows.Forms.TextBox
    Friend WithEvents txt_last As System.Windows.Forms.TextBox
    Friend WithEvents txt_mail As System.Windows.Forms.TextBox
    Friend WithEvents cbo_country As System.Windows.Forms.ComboBox
    Friend WithEvents btn_sub As System.Windows.Forms.Button
    Friend WithEvents btn_clr As System.Windows.Forms.Button
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chk_con As System.Windows.Forms.CheckBox
    Friend WithEvents rdo_child As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_adult As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tt_dob As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
