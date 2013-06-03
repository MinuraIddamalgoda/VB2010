<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccount
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
        Me.lbl_tos = New System.Windows.Forms.LinkLabel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.chk_agree = New System.Windows.Forms.CheckBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chk_admin = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lbl_tos
        '
        Me.lbl_tos.AutoSize = True
        Me.lbl_tos.Location = New System.Drawing.Point(66, 151)
        Me.lbl_tos.Name = "lbl_tos"
        Me.lbl_tos.Size = New System.Drawing.Size(104, 13)
        Me.lbl_tos.TabIndex = 19
        Me.lbl_tos.TabStop = True
        Me.lbl_tos.Text = "terms and conditions"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(12, 202)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 18
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'chk_agree
        '
        Me.chk_agree.AutoSize = True
        Me.chk_agree.Location = New System.Drawing.Point(12, 150)
        Me.chk_agree.Name = "chk_agree"
        Me.chk_agree.Size = New System.Drawing.Size(71, 17)
        Me.chk_agree.TabIndex = 17
        Me.chk_agree.Text = "I agree to"
        Me.chk_agree.UseVisualStyleBackColor = True
        '
        'txt_pass
        '
        Me.txt_pass.ForeColor = System.Drawing.Color.Gray
        Me.txt_pass.Location = New System.Drawing.Point(12, 38)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(158, 20)
        Me.txt_pass.TabIndex = 16
        Me.txt_pass.Text = "Password"
        '
        'txt_user
        '
        Me.txt_user.ForeColor = System.Drawing.Color.Gray
        Me.txt_user.Location = New System.Drawing.Point(12, 12)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(158, 20)
        Me.txt_user.TabIndex = 15
        Me.txt_user.Text = "Username"
        '
        'btn_create
        '
        Me.btn_create.Enabled = False
        Me.btn_create.Location = New System.Drawing.Point(95, 202)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(75, 23)
        Me.btn_create.TabIndex = 14
        Me.btn_create.Text = "Create"
        Me.btn_create.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'chk_admin
        '
        Me.chk_admin.AutoSize = True
        Me.chk_admin.Location = New System.Drawing.Point(12, 173)
        Me.chk_admin.Name = "chk_admin"
        Me.chk_admin.Size = New System.Drawing.Size(61, 17)
        Me.chk_admin.TabIndex = 20
        Me.chk_admin.Text = "Admin?"
        Me.chk_admin.UseVisualStyleBackColor = True
        '
        'CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(183, 237)
        Me.ControlBox = False
        Me.Controls.Add(Me.chk_admin)
        Me.Controls.Add(Me.lbl_tos)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.chk_agree)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.btn_create)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CreateAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_tos As System.Windows.Forms.LinkLabel
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents chk_agree As System.Windows.Forms.CheckBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents txt_user As System.Windows.Forms.TextBox
    Friend WithEvents btn_create As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents chk_admin As System.Windows.Forms.CheckBox
End Class
