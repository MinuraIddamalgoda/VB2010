<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_GUI
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
        Me.txt_log = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.btn_enter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_log
        '
        Me.txt_log.ForeColor = System.Drawing.Color.Gray
        Me.txt_log.Location = New System.Drawing.Point(87, 77)
        Me.txt_log.Name = "txt_log"
        Me.txt_log.Size = New System.Drawing.Size(100, 20)
        Me.txt_log.TabIndex = 0
        Me.txt_log.Text = "Enter username"
        '
        'txt_pass
        '
        Me.txt_pass.ForeColor = System.Drawing.Color.Gray
        Me.txt_pass.Location = New System.Drawing.Point(87, 121)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(100, 20)
        Me.txt_pass.TabIndex = 1
        Me.txt_pass.Text = "Enter password"
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(197, 227)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(75, 23)
        Me.btn_enter.TabIndex = 3
        Me.btn_enter.Text = "Enter"
        Me.btn_enter.UseVisualStyleBackColor = True
        '
        'Login_GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btn_enter)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_log)
        Me.Name = "Login_GUI"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_log As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents btn_enter As System.Windows.Forms.Button

End Class
