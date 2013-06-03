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
        Me.lbo_make = New System.Windows.Forms.ListBox()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.lbo_price = New System.Windows.Forms.ListBox()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.array_price = New System.Windows.Forms.ListBox()
        Me.array_name = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lbo_make
        '
        Me.lbo_make.FormattingEnabled = True
        Me.lbo_make.Location = New System.Drawing.Point(12, 12)
        Me.lbo_make.Name = "lbo_make"
        Me.lbo_make.Size = New System.Drawing.Size(120, 95)
        Me.lbo_make.TabIndex = 1
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(221, 255)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(75, 23)
        Me.btn_start.TabIndex = 2
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'lbo_price
        '
        Me.lbo_price.FormattingEnabled = True
        Me.lbo_price.Location = New System.Drawing.Point(176, 12)
        Me.lbo_price.Name = "lbo_price"
        Me.lbo_price.Size = New System.Drawing.Size(120, 95)
        Me.lbo_price.TabIndex = 3
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(140, 255)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 23)
        Me.btn_new.TabIndex = 4
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(59, 255)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 5
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'array_price
        '
        Me.array_price.FormattingEnabled = True
        Me.array_price.Location = New System.Drawing.Point(176, 122)
        Me.array_price.Name = "array_price"
        Me.array_price.Size = New System.Drawing.Size(120, 95)
        Me.array_price.TabIndex = 7
        '
        'array_name
        '
        Me.array_name.FormattingEnabled = True
        Me.array_name.Location = New System.Drawing.Point(12, 122)
        Me.array_name.Name = "array_name"
        Me.array_name.Size = New System.Drawing.Size(120, 95)
        Me.array_name.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 292)
        Me.Controls.Add(Me.array_price)
        Me.Controls.Add(Me.array_name)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.lbo_price)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.lbo_make)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbo_make As System.Windows.Forms.ListBox
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents lbo_price As System.Windows.Forms.ListBox
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents array_price As System.Windows.Forms.ListBox
    Friend WithEvents array_name As System.Windows.Forms.ListBox

End Class
