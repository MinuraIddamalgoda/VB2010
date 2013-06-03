<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lbo_total = New System.Windows.Forms.ListBox()
        Me.lbo_tax = New System.Windows.Forms.ListBox()
        Me.lbo_gross = New System.Windows.Forms.ListBox()
        Me.lbo_name = New System.Windows.Forms.ListBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_end = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbo_total
        '
        Me.lbo_total.FormattingEnabled = True
        Me.lbo_total.Location = New System.Drawing.Point(291, 38)
        Me.lbo_total.Name = "lbo_total"
        Me.lbo_total.Size = New System.Drawing.Size(87, 160)
        Me.lbo_total.TabIndex = 27
        '
        'lbo_tax
        '
        Me.lbo_tax.FormattingEnabled = True
        Me.lbo_tax.Location = New System.Drawing.Point(198, 38)
        Me.lbo_tax.Name = "lbo_tax"
        Me.lbo_tax.Size = New System.Drawing.Size(87, 160)
        Me.lbo_tax.TabIndex = 26
        '
        'lbo_gross
        '
        Me.lbo_gross.FormattingEnabled = True
        Me.lbo_gross.Location = New System.Drawing.Point(105, 38)
        Me.lbo_gross.Name = "lbo_gross"
        Me.lbo_gross.Size = New System.Drawing.Size(87, 160)
        Me.lbo_gross.TabIndex = 25
        '
        'lbo_name
        '
        Me.lbo_name.FormattingEnabled = True
        Me.lbo_name.Location = New System.Drawing.Point(12, 38)
        Me.lbo_name.Name = "lbo_name"
        Me.lbo_name.Size = New System.Drawing.Size(87, 160)
        Me.lbo_name.TabIndex = 24
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(222, 212)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 28
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_end
        '
        Me.btn_end.Location = New System.Drawing.Point(303, 212)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(75, 23)
        Me.btn_end.TabIndex = 29
        Me.btn_end.Text = "Exit"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 247)
        Me.Controls.Add(Me.btn_end)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.lbo_total)
        Me.Controls.Add(Me.lbo_tax)
        Me.Controls.Add(Me.lbo_gross)
        Me.Controls.Add(Me.lbo_name)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbo_total As System.Windows.Forms.ListBox
    Friend WithEvents lbo_tax As System.Windows.Forms.ListBox
    Friend WithEvents lbo_gross As System.Windows.Forms.ListBox
    Friend WithEvents lbo_name As System.Windows.Forms.ListBox
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_end As System.Windows.Forms.Button
End Class
