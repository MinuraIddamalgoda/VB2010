<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class create
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
        Me.lbl_create = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.txt_pass_create = New System.Windows.Forms.TextBox()
        Me.txt_username_create = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ep_new_username = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ep_new_pass = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ep_new_username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ep_new_pass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_create
        '
        Me.lbl_create.AutoSize = True
        Me.lbl_create.Location = New System.Drawing.Point(9, 119)
        Me.lbl_create.Name = "lbl_create"
        Me.lbl_create.Size = New System.Drawing.Size(33, 13)
        Me.lbl_create.TabIndex = 9
        Me.lbl_create.Text = "Login"
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(134, 114)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(75, 23)
        Me.btn_login.TabIndex = 8
        Me.btn_login.Text = "Create"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'txt_pass_create
        '
        Me.txt_pass_create.ForeColor = System.Drawing.Color.Gray
        Me.txt_pass_create.Location = New System.Drawing.Point(12, 78)
        Me.txt_pass_create.Name = "txt_pass_create"
        Me.txt_pass_create.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass_create.Size = New System.Drawing.Size(197, 20)
        Me.txt_pass_create.TabIndex = 7
        Me.txt_pass_create.Text = "Enter new password"
        '
        'txt_username_create
        '
        Me.txt_username_create.ForeColor = System.Drawing.Color.Gray
        Me.txt_username_create.Location = New System.Drawing.Point(12, 52)
        Me.txt_username_create.Name = "txt_username_create"
        Me.txt_username_create.Size = New System.Drawing.Size(197, 20)
        Me.txt_username_create.TabIndex = 6
        Me.txt_username_create.Text = "Enter new username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Create new"
        '
        'ep_new_username
        '
        Me.ep_new_username.ContainerControl = Me
        '
        'ep_new_pass
        '
        Me.ep_new_pass.ContainerControl = Me
        '
        'create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(221, 155)
        Me.Controls.Add(Me.lbl_create)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_pass_create)
        Me.Controls.Add(Me.txt_username_create)
        Me.Controls.Add(Me.Label1)
        Me.Name = "create"
        Me.Text = "Create account"
        CType(Me.ep_new_username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ep_new_pass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_create As System.Windows.Forms.Label
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents txt_pass_create As System.Windows.Forms.TextBox
    Friend WithEvents txt_username_create As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ep_new_username As System.Windows.Forms.ErrorProvider
    Friend WithEvents ep_new_pass As System.Windows.Forms.ErrorProvider
End Class
