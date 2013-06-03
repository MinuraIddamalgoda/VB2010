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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.nud_people = New System.Windows.Forms.NumericUpDown()
        Me.rdo_gas = New System.Windows.Forms.RadioButton()
        Me.rdo_electric = New System.Windows.Forms.RadioButton()
        Me.txt_enter = New System.Windows.Forms.TextBox()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_clr = New System.Windows.Forms.Button()
        Me.pb_alone = New System.Windows.Forms.PictureBox()
        CType(Me.nud_people, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_alone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nud_people
        '
        Me.nud_people.Location = New System.Drawing.Point(6, 19)
        Me.nud_people.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nud_people.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_people.Name = "nud_people"
        Me.nud_people.Size = New System.Drawing.Size(145, 20)
        Me.nud_people.TabIndex = 1
        Me.nud_people.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rdo_gas
        '
        Me.rdo_gas.AutoSize = True
        Me.rdo_gas.Checked = True
        Me.rdo_gas.Location = New System.Drawing.Point(6, 17)
        Me.rdo_gas.Name = "rdo_gas"
        Me.rdo_gas.Size = New System.Drawing.Size(44, 17)
        Me.rdo_gas.TabIndex = 2
        Me.rdo_gas.TabStop = True
        Me.rdo_gas.Text = "Gas"
        Me.rdo_gas.UseVisualStyleBackColor = True
        '
        'rdo_electric
        '
        Me.rdo_electric.AutoSize = True
        Me.rdo_electric.Location = New System.Drawing.Point(6, 40)
        Me.rdo_electric.Name = "rdo_electric"
        Me.rdo_electric.Size = New System.Drawing.Size(60, 17)
        Me.rdo_electric.TabIndex = 3
        Me.rdo_electric.Text = "Electric"
        Me.rdo_electric.UseVisualStyleBackColor = True
        '
        'txt_enter
        '
        Me.txt_enter.ForeColor = System.Drawing.Color.Gray
        Me.txt_enter.Location = New System.Drawing.Point(18, 162)
        Me.txt_enter.Name = "txt_enter"
        Me.txt_enter.Size = New System.Drawing.Size(145, 20)
        Me.txt_enter.TabIndex = 4
        Me.txt_enter.Text = "Enter daily kWh"
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(5, 6)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(75, 23)
        Me.btn_start.TabIndex = 5
        Me.btn_start.Text = "Calculate"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nud_people)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 48)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter number of occupants"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdo_electric)
        Me.GroupBox2.Controls.Add(Me.rdo_gas)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(157, 66)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enter energy type"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_clr)
        Me.Panel1.Controls.Add(Me.btn_start)
        Me.Panel1.Location = New System.Drawing.Point(188, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(84, 78)
        Me.Panel1.TabIndex = 8
        '
        'btn_clr
        '
        Me.btn_clr.Location = New System.Drawing.Point(6, 44)
        Me.btn_clr.Name = "btn_clr"
        Me.btn_clr.Size = New System.Drawing.Size(75, 23)
        Me.btn_clr.TabIndex = 6
        Me.btn_clr.Text = "Clear"
        Me.btn_clr.UseVisualStyleBackColor = True
        '
        'pb_alone
        '
        Me.pb_alone.Image = CType(resources.GetObject("pb_alone.Image"), System.Drawing.Image)
        Me.pb_alone.Location = New System.Drawing.Point(175, 104)
        Me.pb_alone.Name = "pb_alone"
        Me.pb_alone.Size = New System.Drawing.Size(97, 78)
        Me.pb_alone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_alone.TabIndex = 9
        Me.pb_alone.TabStop = False
        Me.pb_alone.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 196)
        Me.Controls.Add(Me.pb_alone)
        Me.Controls.Add(Me.txt_enter)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nud_people, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb_alone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nud_people As System.Windows.Forms.NumericUpDown
    Friend WithEvents rdo_gas As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_electric As System.Windows.Forms.RadioButton
    Friend WithEvents txt_enter As System.Windows.Forms.TextBox
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_clr As System.Windows.Forms.Button
    Friend WithEvents pb_alone As System.Windows.Forms.PictureBox

End Class
