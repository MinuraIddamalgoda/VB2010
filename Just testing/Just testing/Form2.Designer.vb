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
        Me.btn_one = New System.Windows.Forms.TextBox()
        Me.btn_two = New System.Windows.Forms.TextBox()
        Me.btn_three = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_one
        '
        Me.btn_one.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.btn_one.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories
        Me.btn_one.ForeColor = System.Drawing.Color.Gray
        Me.btn_one.Location = New System.Drawing.Point(78, 49)
        Me.btn_one.Name = "btn_one"
        Me.btn_one.Size = New System.Drawing.Size(100, 20)
        Me.btn_one.TabIndex = 0
        Me.btn_one.Text = "Please enter text"
        '
        'btn_two
        '
        Me.btn_two.ForeColor = System.Drawing.Color.Gray
        Me.btn_two.Location = New System.Drawing.Point(78, 111)
        Me.btn_two.Name = "btn_two"
        Me.btn_two.Size = New System.Drawing.Size(100, 20)
        Me.btn_two.TabIndex = 1
        Me.btn_two.Text = "Please enter text"
        '
        'btn_three
        '
        Me.btn_three.ForeColor = System.Drawing.Color.Gray
        Me.btn_three.Location = New System.Drawing.Point(78, 173)
        Me.btn_three.Name = "btn_three"
        Me.btn_three.Size = New System.Drawing.Size(100, 20)
        Me.btn_three.TabIndex = 2
        Me.btn_three.Text = "Please enter text"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btn_three)
        Me.Controls.Add(Me.btn_two)
        Me.Controls.Add(Me.btn_one)
        Me.Name = "Form2"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_one As System.Windows.Forms.TextBox
    Friend WithEvents btn_two As System.Windows.Forms.TextBox
    Friend WithEvents btn_three As System.Windows.Forms.TextBox

End Class
