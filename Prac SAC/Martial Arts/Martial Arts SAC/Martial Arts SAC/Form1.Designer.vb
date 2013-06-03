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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Monday = New System.Windows.Forms.TabPage()
        Me.Absence = New System.Windows.Forms.GroupBox()
        Me.btn_mark = New System.Windows.Forms.Button()
        Me.btn_show = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_wed = New System.Windows.Forms.Button()
        Me.btn_tue = New System.Windows.Forms.Button()
        Me.dgv_monday = New System.Windows.Forms.DataGridView()
        Me.Tuesday = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_wed2 = New System.Windows.Forms.Button()
        Me.btn_mon = New System.Windows.Forms.Button()
        Me.dgv_tuesday = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_tue2 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgv_wed = New System.Windows.Forms.DataGridView()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.TabControl1.SuspendLayout()
        Me.Monday.SuspendLayout()
        Me.Absence.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_monday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tuesday.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_tuesday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_wed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Monday)
        Me.TabControl1.Controls.Add(Me.Tuesday)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(782, 563)
        Me.TabControl1.TabIndex = 0
        '
        'Monday
        '
        Me.Monday.Controls.Add(Me.btn_print)
        Me.Monday.Controls.Add(Me.Absence)
        Me.Monday.Controls.Add(Me.GroupBox1)
        Me.Monday.Controls.Add(Me.dgv_monday)
        Me.Monday.Location = New System.Drawing.Point(4, 22)
        Me.Monday.Name = "Monday"
        Me.Monday.Padding = New System.Windows.Forms.Padding(3)
        Me.Monday.Size = New System.Drawing.Size(774, 537)
        Me.Monday.TabIndex = 0
        Me.Monday.Text = "Monday with Cloud"
        Me.Monday.UseVisualStyleBackColor = True
        '
        'Absence
        '
        Me.Absence.BackColor = System.Drawing.SystemColors.Control
        Me.Absence.Controls.Add(Me.btn_mark)
        Me.Absence.Controls.Add(Me.btn_show)
        Me.Absence.Location = New System.Drawing.Point(414, 152)
        Me.Absence.Name = "Absence"
        Me.Absence.Size = New System.Drawing.Size(143, 135)
        Me.Absence.TabIndex = 3
        Me.Absence.TabStop = False
        Me.Absence.Text = "Absence"
        '
        'btn_mark
        '
        Me.btn_mark.Location = New System.Drawing.Point(6, 76)
        Me.btn_mark.Name = "btn_mark"
        Me.btn_mark.Size = New System.Drawing.Size(130, 51)
        Me.btn_mark.TabIndex = 3
        Me.btn_mark.Text = "List selected as away"
        Me.btn_mark.UseVisualStyleBackColor = True
        '
        'btn_show
        '
        Me.btn_show.Location = New System.Drawing.Point(6, 19)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(130, 51)
        Me.btn_show.TabIndex = 2
        Me.btn_show.Text = "Show absent list"
        Me.btn_show.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.btn_wed)
        Me.GroupBox1.Controls.Add(Me.btn_tue)
        Me.GroupBox1.Location = New System.Drawing.Point(414, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 135)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Move student to"
        '
        'btn_wed
        '
        Me.btn_wed.Location = New System.Drawing.Point(6, 78)
        Me.btn_wed.Name = "btn_wed"
        Me.btn_wed.Size = New System.Drawing.Size(130, 51)
        Me.btn_wed.TabIndex = 1
        Me.btn_wed.Text = "Wednesday"
        Me.btn_wed.UseVisualStyleBackColor = True
        '
        'btn_tue
        '
        Me.btn_tue.Location = New System.Drawing.Point(6, 19)
        Me.btn_tue.Name = "btn_tue"
        Me.btn_tue.Size = New System.Drawing.Size(130, 51)
        Me.btn_tue.TabIndex = 0
        Me.btn_tue.Text = "Tuesday"
        Me.btn_tue.UseVisualStyleBackColor = True
        '
        'dgv_monday
        '
        Me.dgv_monday.AllowDrop = True
        Me.dgv_monday.AllowUserToOrderColumns = True
        Me.dgv_monday.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_monday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_monday.Location = New System.Drawing.Point(0, 0)
        Me.dgv_monday.Name = "dgv_monday"
        Me.dgv_monday.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_monday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_monday.Size = New System.Drawing.Size(569, 316)
        Me.dgv_monday.TabIndex = 0
        '
        'Tuesday
        '
        Me.Tuesday.Controls.Add(Me.GroupBox4)
        Me.Tuesday.Controls.Add(Me.GroupBox2)
        Me.Tuesday.Controls.Add(Me.dgv_tuesday)
        Me.Tuesday.Location = New System.Drawing.Point(4, 22)
        Me.Tuesday.Name = "Tuesday"
        Me.Tuesday.Size = New System.Drawing.Size(774, 537)
        Me.Tuesday.TabIndex = 1
        Me.Tuesday.Text = "Tuesday with Motoko"
        Me.Tuesday.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Location = New System.Drawing.Point(414, 152)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(143, 135)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Absence"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 51)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "List selected as away"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 51)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Show absent list"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.btn_wed2)
        Me.GroupBox2.Controls.Add(Me.btn_mon)
        Me.GroupBox2.Location = New System.Drawing.Point(414, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(143, 135)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Move student to"
        '
        'btn_wed2
        '
        Me.btn_wed2.Location = New System.Drawing.Point(6, 78)
        Me.btn_wed2.Name = "btn_wed2"
        Me.btn_wed2.Size = New System.Drawing.Size(130, 51)
        Me.btn_wed2.TabIndex = 1
        Me.btn_wed2.Text = "Wednesday"
        Me.btn_wed2.UseVisualStyleBackColor = True
        '
        'btn_mon
        '
        Me.btn_mon.Location = New System.Drawing.Point(6, 19)
        Me.btn_mon.Name = "btn_mon"
        Me.btn_mon.Size = New System.Drawing.Size(130, 51)
        Me.btn_mon.TabIndex = 0
        Me.btn_mon.Text = "Monday"
        Me.btn_mon.UseVisualStyleBackColor = True
        '
        'dgv_tuesday
        '
        Me.dgv_tuesday.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_tuesday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tuesday.Location = New System.Drawing.Point(0, 0)
        Me.dgv_tuesday.Name = "dgv_tuesday"
        Me.dgv_tuesday.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_tuesday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_tuesday.Size = New System.Drawing.Size(569, 316)
        Me.dgv_tuesday.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.dgv_wed)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(774, 537)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Wednesday with Jason"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Location = New System.Drawing.Point(414, 152)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(143, 135)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Absence"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 76)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(130, 51)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "List selected as away"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(130, 51)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Show absent list"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.btn_tue2)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(414, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(143, 135)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Move student to"
        '
        'btn_tue2
        '
        Me.btn_tue2.Location = New System.Drawing.Point(6, 78)
        Me.btn_tue2.Name = "btn_tue2"
        Me.btn_tue2.Size = New System.Drawing.Size(130, 51)
        Me.btn_tue2.TabIndex = 1
        Me.btn_tue2.Text = "Tuesday"
        Me.btn_tue2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 51)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Monday"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgv_wed
        '
        Me.dgv_wed.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_wed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_wed.Location = New System.Drawing.Point(0, 0)
        Me.dgv_wed.Name = "dgv_wed"
        Me.dgv_wed.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_wed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_wed.Size = New System.Drawing.Size(569, 316)
        Me.dgv_wed.TabIndex = 1
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(448, 285)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(75, 23)
        Me.btn_print.TabIndex = 4
        Me.btn_print.Text = "Button6"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 344)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TabControl1.ResumeLayout(False)
        Me.Monday.ResumeLayout(False)
        Me.Absence.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_monday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tuesday.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_tuesday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgv_wed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Monday As System.Windows.Forms.TabPage
    Friend WithEvents dgv_monday As System.Windows.Forms.DataGridView
    Friend WithEvents Tuesday As System.Windows.Forms.TabPage
    Friend WithEvents dgv_tuesday As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_wed As System.Windows.Forms.Button
    Friend WithEvents btn_tue As System.Windows.Forms.Button
    Friend WithEvents Absence As System.Windows.Forms.GroupBox
    Friend WithEvents btn_mark As System.Windows.Forms.Button
    Friend WithEvents btn_show As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_wed As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_wed2 As System.Windows.Forms.Button
    Friend WithEvents btn_mon As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_tue2 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog

End Class
