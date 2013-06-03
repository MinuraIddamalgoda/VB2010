<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home_Form
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
        Me.btn_sac1 = New System.Windows.Forms.Button()
        Me.btn_sac2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_sac1
        '
        Me.btn_sac1.Location = New System.Drawing.Point(6, 23)
        Me.btn_sac1.Name = "btn_sac1"
        Me.btn_sac1.Size = New System.Drawing.Size(118, 35)
        Me.btn_sac1.TabIndex = 1
        Me.btn_sac1.Text = "Enter SAC 1 Marks"
        Me.btn_sac1.UseVisualStyleBackColor = True
        '
        'btn_sac2
        '
        Me.btn_sac2.Location = New System.Drawing.Point(6, 64)
        Me.btn_sac2.Name = "btn_sac2"
        Me.btn_sac2.Size = New System.Drawing.Size(118, 35)
        Me.btn_sac2.TabIndex = 2
        Me.btn_sac2.Text = "Enter SAC 2 Marks"
        Me.btn_sac2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(119, 144)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 24)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Continue"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_sac1)
        Me.GroupBox1.Controls.Add(Me.btn_sac2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 106)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter SAC results first"
        '
        'Home_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 180)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Name = "Home_Form"
        Me.Text = "SAC Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_sac1 As System.Windows.Forms.Button
    Friend WithEvents btn_sac2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
