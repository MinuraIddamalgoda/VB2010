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
        Me.btn_cont = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_adults = New System.Windows.Forms.TextBox()
        Me.txt_child = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_cont
        '
        Me.btn_cont.Location = New System.Drawing.Point(340, 124)
        Me.btn_cont.Name = "btn_cont"
        Me.btn_cont.Size = New System.Drawing.Size(75, 23)
        Me.btn_cont.TabIndex = 0
        Me.btn_cont.Text = "Continue"
        Me.btn_cont.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "@ $15 each"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "@ $5 each"
        '
        'txt_adults
        '
        Me.txt_adults.ForeColor = System.Drawing.Color.DarkGray
        Me.txt_adults.Location = New System.Drawing.Point(34, 54)
        Me.txt_adults.Name = "txt_adults"
        Me.txt_adults.Size = New System.Drawing.Size(100, 20)
        Me.txt_adults.TabIndex = 3
        Me.txt_adults.Text = "Adult Tickets"
        '
        'txt_child
        '
        Me.txt_child.ForeColor = System.Drawing.Color.DarkGray
        Me.txt_child.Location = New System.Drawing.Point(34, 89)
        Me.txt_child.Name = "txt_child"
        Me.txt_child.Size = New System.Drawing.Size(100, 20)
        Me.txt_child.TabIndex = 4
        Me.txt_child.Text = "Child Tickets"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(403, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Please enter how many tickets you'd like to buy"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 162)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_child)
        Me.Controls.Add(Me.txt_adults)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cont)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Vendor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cont As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_adults As System.Windows.Forms.TextBox
    Friend WithEvents txt_child As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
