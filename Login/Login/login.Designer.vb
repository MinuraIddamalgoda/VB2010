<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.ep_username = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ep_pass = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_login = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LogInAsRootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateNewAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersTableAdapter1 = New Global.Login.databaseDataSetTableAdapters.usersTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ep_username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ep_pass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'txt_username
        '
        Me.txt_username.ForeColor = System.Drawing.Color.Gray
        Me.txt_username.Location = New System.Drawing.Point(12, 52)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(208, 20)
        Me.txt_username.TabIndex = 1
        Me.txt_username.Text = "Enter username"
        '
        'txt_pass
        '
        Me.txt_pass.ForeColor = System.Drawing.Color.Gray
        Me.txt_pass.Location = New System.Drawing.Point(12, 78)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(208, 20)
        Me.txt_pass.TabIndex = 2
        Me.txt_pass.Text = "Enter password"
        '
        'ep_username
        '
        Me.ep_username.ContainerControl = Me
        '
        'ep_pass
        '
        Me.ep_pass.ContainerControl = Me
        '
        'btn_login
        '
        Me.btn_login.ContextMenuStrip = Me.ContextMenuStrip1
        Me.btn_login.Location = New System.Drawing.Point(130, 124)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(90, 25)
        Me.btn_login.TabIndex = 5
        Me.btn_login.Text = "Login"
        Me.ToolTip1.SetToolTip(Me.btn_login, "Right click for further options")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogInAsRootToolStripMenuItem, Me.CreateNewAccountToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(180, 48)
        '
        'LogInAsRootToolStripMenuItem
        '
        Me.LogInAsRootToolStripMenuItem.Name = "LogInAsRootToolStripMenuItem"
        Me.LogInAsRootToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.LogInAsRootToolStripMenuItem.Text = "Log in as root"
        '
        'CreateNewAccountToolStripMenuItem
        '
        Me.CreateNewAccountToolStripMenuItem.Name = "CreateNewAccountToolStripMenuItem"
        Me.CreateNewAccountToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CreateNewAccountToolStripMenuItem.Text = "Create new account"
        '
        'UsersTableAdapter1
        '
        Me.UsersTableAdapter1.ClearBeforeFill = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 100
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 161)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label1)
        Me.Name = "login"
        Me.Text = "Form1"
        CType(Me.ep_username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ep_pass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents ep_username As System.Windows.Forms.ErrorProvider
    Friend WithEvents ep_pass As System.Windows.Forms.ErrorProvider
    Friend WithEvents UsersTableAdapter1 As Global.Login.databaseDataSetTableAdapters.usersTableAdapter
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LogInAsRootToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateNewAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
