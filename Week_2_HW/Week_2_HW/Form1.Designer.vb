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
        Me.txt_in = New System.Windows.Forms.TextBox()
        Me.txt_out = New System.Windows.Forms.TextBox()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_in
        '
        Me.txt_in.Location = New System.Drawing.Point(12, 12)
        Me.txt_in.Multiline = True
        Me.txt_in.Name = "txt_in"
        Me.txt_in.Size = New System.Drawing.Size(100, 155)
        Me.txt_in.TabIndex = 0
        '
        'txt_out
        '
        Me.txt_out.Location = New System.Drawing.Point(172, 12)
        Me.txt_out.Multiline = True
        Me.txt_out.Name = "txt_out"
        Me.txt_out.Size = New System.Drawing.Size(100, 155)
        Me.txt_out.TabIndex = 1
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(106, 227)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(75, 23)
        Me.btn_start.TabIndex = 2
        Me.btn_start.Text = "Button1"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.txt_out)
        Me.Controls.Add(Me.txt_in)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_in As System.Windows.Forms.TextBox
    Friend WithEvents txt_out As System.Windows.Forms.TextBox
    Friend WithEvents btn_start As System.Windows.Forms.Button

End Class
