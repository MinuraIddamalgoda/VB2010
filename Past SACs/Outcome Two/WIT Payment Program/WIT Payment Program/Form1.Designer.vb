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
        Me.cm_sort = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FirstNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecensingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SurnameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssendingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssendingToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecendingToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssendingToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecendingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_end_no_save = New System.Windows.Forms.Button()
        Me.btn_end_save = New System.Windows.Forms.Button()
        Me.btn_commerce = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_cooking = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgv_course_display = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.cm_sort.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_course_display, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cm_sort
        '
        Me.cm_sort.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstNameToolStripMenuItem, Me.SurnameToolStripMenuItem, Me.PayStatusToolStripMenuItem, Me.IDNumberToolStripMenuItem})
        Me.cm_sort.Name = "cm_sort"
        Me.cm_sort.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.cm_sort.Size = New System.Drawing.Size(133, 92)
        Me.cm_sort.Text = "Sort By"
        '
        'FirstNameToolStripMenuItem
        '
        Me.FirstNameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssendingToolStripMenuItem, Me.DecensingToolStripMenuItem})
        Me.FirstNameToolStripMenuItem.Name = "FirstNameToolStripMenuItem"
        Me.FirstNameToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.FirstNameToolStripMenuItem.Text = "First Name"
        '
        'AssendingToolStripMenuItem
        '
        Me.AssendingToolStripMenuItem.Name = "AssendingToolStripMenuItem"
        Me.AssendingToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AssendingToolStripMenuItem.Text = "Ascending"
        '
        'DecensingToolStripMenuItem
        '
        Me.DecensingToolStripMenuItem.Name = "DecensingToolStripMenuItem"
        Me.DecensingToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.DecensingToolStripMenuItem.Text = "Descensing"
        '
        'SurnameToolStripMenuItem
        '
        Me.SurnameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssendingToolStripMenuItem1, Me.DecendingToolStripMenuItem})
        Me.SurnameToolStripMenuItem.Name = "SurnameToolStripMenuItem"
        Me.SurnameToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SurnameToolStripMenuItem.Text = "Surname"
        '
        'AssendingToolStripMenuItem1
        '
        Me.AssendingToolStripMenuItem1.Name = "AssendingToolStripMenuItem1"
        Me.AssendingToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.AssendingToolStripMenuItem1.Text = "Ascending"
        '
        'DecendingToolStripMenuItem
        '
        Me.DecendingToolStripMenuItem.Name = "DecendingToolStripMenuItem"
        Me.DecendingToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.DecendingToolStripMenuItem.Text = "Descending"
        '
        'PayStatusToolStripMenuItem
        '
        Me.PayStatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssendingToolStripMenuItem3, Me.DecendingToolStripMenuItem2})
        Me.PayStatusToolStripMenuItem.Name = "PayStatusToolStripMenuItem"
        Me.PayStatusToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.PayStatusToolStripMenuItem.Text = "Pay Status"
        '
        'AssendingToolStripMenuItem3
        '
        Me.AssendingToolStripMenuItem3.Name = "AssendingToolStripMenuItem3"
        Me.AssendingToolStripMenuItem3.Size = New System.Drawing.Size(136, 22)
        Me.AssendingToolStripMenuItem3.Text = "Ascending"
        '
        'DecendingToolStripMenuItem2
        '
        Me.DecendingToolStripMenuItem2.Name = "DecendingToolStripMenuItem2"
        Me.DecendingToolStripMenuItem2.Size = New System.Drawing.Size(136, 22)
        Me.DecendingToolStripMenuItem2.Text = "Descending"
        '
        'IDNumberToolStripMenuItem
        '
        Me.IDNumberToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssendingToolStripMenuItem2, Me.DecendingToolStripMenuItem1})
        Me.IDNumberToolStripMenuItem.Name = "IDNumberToolStripMenuItem"
        Me.IDNumberToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.IDNumberToolStripMenuItem.Text = "ID Number"
        '
        'AssendingToolStripMenuItem2
        '
        Me.AssendingToolStripMenuItem2.Name = "AssendingToolStripMenuItem2"
        Me.AssendingToolStripMenuItem2.Size = New System.Drawing.Size(136, 22)
        Me.AssendingToolStripMenuItem2.Text = "Ascending"
        '
        'DecendingToolStripMenuItem1
        '
        Me.DecendingToolStripMenuItem1.Name = "DecendingToolStripMenuItem1"
        Me.DecendingToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.DecendingToolStripMenuItem1.Text = "Descending"
        '
        'btn_end_no_save
        '
        Me.btn_end_no_save.Location = New System.Drawing.Point(493, 321)
        Me.btn_end_no_save.Name = "btn_end_no_save"
        Me.btn_end_no_save.Size = New System.Drawing.Size(120, 64)
        Me.btn_end_no_save.TabIndex = 4
        Me.btn_end_no_save.Text = "Exit without save"
        Me.btn_end_no_save.UseVisualStyleBackColor = True
        '
        'btn_end_save
        '
        Me.btn_end_save.Location = New System.Drawing.Point(367, 321)
        Me.btn_end_save.Name = "btn_end_save"
        Me.btn_end_save.Size = New System.Drawing.Size(120, 64)
        Me.btn_end_save.TabIndex = 5
        Me.btn_end_save.Text = "Save and exit"
        Me.btn_end_save.UseVisualStyleBackColor = True
        '
        'btn_commerce
        '
        Me.btn_commerce.Location = New System.Drawing.Point(10, 19)
        Me.btn_commerce.Name = "btn_commerce"
        Me.btn_commerce.Size = New System.Drawing.Size(120, 64)
        Me.btn_commerce.TabIndex = 6
        Me.btn_commerce.Text = "Commerce"
        Me.btn_commerce.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.btn_cooking)
        Me.GroupBox1.Controls.Add(Me.btn_commerce)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(139, 373)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select course"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(10, 159)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 64)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Placeholder"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btn_cooking
        '
        Me.btn_cooking.Location = New System.Drawing.Point(10, 89)
        Me.btn_cooking.Name = "btn_cooking"
        Me.btn_cooking.Size = New System.Drawing.Size(120, 64)
        Me.btn_cooking.TabIndex = 7
        Me.btn_cooking.Text = "Cooking"
        Me.btn_cooking.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(22, 311)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 64)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Placeholder"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(22, 241)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 64)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Placeholder"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgv_course_display
        '
        Me.dgv_course_display.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_course_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_course_display.ContextMenuStrip = Me.cm_sort
        Me.dgv_course_display.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_course_display.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_course_display.Location = New System.Drawing.Point(157, 12)
        Me.dgv_course_display.Name = "dgv_course_display"
        Me.dgv_course_display.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_course_display.Size = New System.Drawing.Size(456, 303)
        Me.dgv_course_display.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 392)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgv_course_display)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_end_no_save)
        Me.Controls.Add(Me.btn_end_save)
        Me.Name = "Form1"
        Me.Text = "WIT Payments"
        Me.cm_sort.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_course_display, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_end_no_save As System.Windows.Forms.Button
    Friend WithEvents btn_end_save As System.Windows.Forms.Button
    Friend WithEvents cm_sort As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FirstNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecensingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SurnameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssendingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IDNumberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssendingToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecendingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssendingToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecendingToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_commerce As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_cooking As System.Windows.Forms.Button
    Friend WithEvents dgv_course_display As System.Windows.Forms.DataGridView
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument

End Class
