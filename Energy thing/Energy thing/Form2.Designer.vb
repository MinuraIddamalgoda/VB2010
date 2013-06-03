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
        Me.lbl_message = New System.Windows.Forms.Label()
        Me.lbo_name = New System.Windows.Forms.ListBox()
        Me.lbo_out = New System.Windows.Forms.ListBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_message
        '
        Me.lbl_message.AutoSize = True
        Me.lbl_message.Location = New System.Drawing.Point(12, 171)
        Me.lbl_message.Name = "lbl_message"
        Me.lbl_message.Size = New System.Drawing.Size(39, 13)
        Me.lbl_message.TabIndex = 0
        Me.lbl_message.Text = "Label1"
        '
        'lbo_name
        '
        Me.lbo_name.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbo_name.FormattingEnabled = True
        Me.lbo_name.Items.AddRange(New Object() {"Usage charge", "Supply charge", "", "Total charge"})
        Me.lbo_name.Location = New System.Drawing.Point(12, 12)
        Me.lbo_name.Name = "lbo_name"
        Me.lbo_name.Size = New System.Drawing.Size(120, 56)
        Me.lbo_name.TabIndex = 1
        '
        'lbo_out
        '
        Me.lbo_out.FormattingEnabled = True
        Me.lbo_out.Location = New System.Drawing.Point(140, 12)
        Me.lbo_out.Name = "lbo_out"
        Me.lbo_out.Size = New System.Drawing.Size(120, 56)
        Me.lbo_out.TabIndex = 2
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(185, 227)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 3
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 262)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.lbo_out)
        Me.Controls.Add(Me.lbo_name)
        Me.Controls.Add(Me.lbl_message)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_message As System.Windows.Forms.Label
    Friend WithEvents lbo_name As System.Windows.Forms.ListBox
    Friend WithEvents lbo_out As System.Windows.Forms.ListBox
    Friend WithEvents btn_back As System.Windows.Forms.Button
End Class
