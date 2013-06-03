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
        Me.components = New System.ComponentModel.Container()
        Me.dgv_PT = New System.Windows.Forms.DataGridView()
        Me.dgv_FT = New System.Windows.Forms.DataGridView()
        Me.cb_PT = New System.Windows.Forms.ComboBox()
        Me.cb_FT = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgv_PT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_FT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_PT
        '
        Me.dgv_PT.AllowDrop = True
        Me.dgv_PT.AllowUserToResizeColumns = False
        Me.dgv_PT.AllowUserToResizeRows = False
        Me.dgv_PT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_PT.Location = New System.Drawing.Point(12, 12)
        Me.dgv_PT.Name = "dgv_PT"
        Me.dgv_PT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_PT.Size = New System.Drawing.Size(319, 294)
        Me.dgv_PT.TabIndex = 0
        '
        'dgv_FT
        '
        Me.dgv_FT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_FT.Location = New System.Drawing.Point(337, 12)
        Me.dgv_FT.Name = "dgv_FT"
        Me.dgv_FT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_FT.Size = New System.Drawing.Size(323, 294)
        Me.dgv_FT.TabIndex = 1
        '
        'cb_PT
        '
        Me.cb_PT.ForeColor = System.Drawing.Color.Gray
        Me.cb_PT.FormattingEnabled = True
        Me.cb_PT.Items.AddRange(New Object() {"ID Number", "Pay Status", "First Name", "Last Name"})
        Me.cb_PT.Location = New System.Drawing.Point(210, 312)
        Me.cb_PT.Name = "cb_PT"
        Me.cb_PT.Size = New System.Drawing.Size(121, 21)
        Me.cb_PT.TabIndex = 2
        Me.cb_PT.Text = "Sort by..."
        '
        'cb_FT
        '
        Me.cb_FT.ForeColor = System.Drawing.Color.Gray
        Me.cb_FT.FormattingEnabled = True
        Me.cb_FT.Items.AddRange(New Object() {"ID Number", "Pay Status", "First Name", "Last Name"})
        Me.cb_FT.Location = New System.Drawing.Point(539, 312)
        Me.cb_FT.Name = "cb_FT"
        Me.cb_FT.Size = New System.Drawing.Size(121, 21)
        Me.cb_FT.TabIndex = 3
        Me.cb_FT.Text = "Sort by..."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 344)
        Me.Controls.Add(Me.cb_FT)
        Me.Controls.Add(Me.cb_PT)
        Me.Controls.Add(Me.dgv_FT)
        Me.Controls.Add(Me.dgv_PT)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgv_PT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_FT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_PT As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_FT As System.Windows.Forms.DataGridView
    Friend WithEvents cb_PT As System.Windows.Forms.ComboBox
    Friend WithEvents cb_FT As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument

End Class
