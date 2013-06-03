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
        Me.txt_length = New System.Windows.Forms.TextBox()
        Me.txt_width = New System.Windows.Forms.TextBox()
        Me.lbl_ans = New System.Windows.Forms.Label()
        Me.btn_calc = New System.Windows.Forms.Button()
        Me.cb_unit = New System.Windows.Forms.ComboBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.sqr = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rec = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btn_clr = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_length
        '
        Me.txt_length.ForeColor = System.Drawing.Color.Gray
        Me.txt_length.Location = New System.Drawing.Point(337, 62)
        Me.txt_length.Name = "txt_length"
        Me.txt_length.Size = New System.Drawing.Size(100, 20)
        Me.txt_length.TabIndex = 1
        Me.txt_length.Text = "Enter length"
        '
        'txt_width
        '
        Me.txt_width.ForeColor = System.Drawing.Color.Gray
        Me.txt_width.Location = New System.Drawing.Point(337, 36)
        Me.txt_width.Name = "txt_width"
        Me.txt_width.Size = New System.Drawing.Size(100, 20)
        Me.txt_width.TabIndex = 2
        Me.txt_width.Text = "Enter width"
        '
        'lbl_ans
        '
        Me.lbl_ans.AutoSize = True
        Me.lbl_ans.Location = New System.Drawing.Point(13, 145)
        Me.lbl_ans.Name = "lbl_ans"
        Me.lbl_ans.Size = New System.Drawing.Size(0, 13)
        Me.lbl_ans.TabIndex = 3
        '
        'btn_calc
        '
        Me.btn_calc.Location = New System.Drawing.Point(16, 173)
        Me.btn_calc.Name = "btn_calc"
        Me.btn_calc.Size = New System.Drawing.Size(75, 23)
        Me.btn_calc.TabIndex = 6
        Me.btn_calc.Text = "Calculate"
        Me.btn_calc.UseVisualStyleBackColor = True
        '
        'cb_unit
        '
        Me.cb_unit.ForeColor = System.Drawing.Color.Gray
        Me.cb_unit.FormattingEnabled = True
        Me.cb_unit.Items.AddRange(New Object() {"mm", "cm", "m", "km"})
        Me.cb_unit.Location = New System.Drawing.Point(337, 88)
        Me.cb_unit.Name = "cb_unit"
        Me.cb_unit.Size = New System.Drawing.Size(100, 21)
        Me.cb_unit.TabIndex = 7
        Me.cb_unit.Text = "Select units"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.sqr, Me.rec})
        Me.ShapeContainer1.Size = New System.Drawing.Size(454, 202)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'sqr
        '
        Me.sqr.Location = New System.Drawing.Point(74, 18)
        Me.sqr.Name = "sqr"
        Me.sqr.Size = New System.Drawing.Size(116, 116)
        Me.sqr.Visible = False
        '
        'rec
        '
        Me.rec.Location = New System.Drawing.Point(16, 18)
        Me.rec.Name = "rec"
        Me.rec.Size = New System.Drawing.Size(232, 116)
        Me.rec.Visible = False
        '
        'btn_clr
        '
        Me.btn_clr.Location = New System.Drawing.Point(97, 173)
        Me.btn_clr.Name = "btn_clr"
        Me.btn_clr.Size = New System.Drawing.Size(75, 23)
        Me.btn_clr.TabIndex = 9
        Me.btn_clr.Text = "Clear"
        Me.btn_clr.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(287, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Width"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(279, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Length"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(291, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Units"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(362, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 202)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_clr)
        Me.Controls.Add(Me.cb_unit)
        Me.Controls.Add(Me.btn_calc)
        Me.Controls.Add(Me.lbl_ans)
        Me.Controls.Add(Me.txt_width)
        Me.Controls.Add(Me.txt_length)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_length As System.Windows.Forms.TextBox
    Friend WithEvents txt_width As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ans As System.Windows.Forms.Label
    Friend WithEvents btn_calc As System.Windows.Forms.Button
    Friend WithEvents cb_unit As System.Windows.Forms.ComboBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents sqr As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rec As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btn_clr As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
