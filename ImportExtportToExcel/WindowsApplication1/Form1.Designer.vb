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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbFilePath = New System.Windows.Forms.Label()
        Me.btnBrowser = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.dtgResult = New System.Windows.Forms.DataGridView()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.dtgResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbFilePath
        '
        Me.lbFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFilePath.Location = New System.Drawing.Point(29, 25)
        Me.lbFilePath.Name = "lbFilePath"
        Me.lbFilePath.Size = New System.Drawing.Size(276, 23)
        Me.lbFilePath.TabIndex = 0
        '
        'btnBrowser
        '
        Me.btnBrowser.Location = New System.Drawing.Point(311, 25)
        Me.btnBrowser.Name = "btnBrowser"
        Me.btnBrowser.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowser.TabIndex = 1
        Me.btnBrowser.Text = "Browse"
        Me.btnBrowser.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(12, 63)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(85, 23)
        Me.btnImport.TabIndex = 2
        Me.btnImport.Text = "Import to DB"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(114, 63)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(115, 23)
        Me.btnExport.TabIndex = 3
        Me.btnExport.Text = "Export to Excel"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'dtgResult
        '
        Me.dtgResult.AllowUserToAddRows = False
        Me.dtgResult.AllowUserToDeleteRows = False
        Me.dtgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgResult.Location = New System.Drawing.Point(12, 100)
        Me.dtgResult.Name = "dtgResult"
        Me.dtgResult.ReadOnly = True
        Me.dtgResult.Size = New System.Drawing.Size(374, 203)
        Me.dtgResult.TabIndex = 4
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 309)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(374, 23)
        Me.ProgressBar1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 344)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.dtgResult)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnBrowser)
        Me.Controls.Add(Me.lbFilePath)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dtgResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbFilePath As System.Windows.Forms.Label
    Friend WithEvents btnBrowser As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents dtgResult As System.Windows.Forms.DataGridView
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

End Class
