Imports System.IO
Public Class Fisihing
    Public FilePath As String
    Public NameControlDesign() As String
    Public LocationControlDesign() As Point
    Public SizeControlDesign() As Size
    Public SizeFormDesign As Size

    Private Sub btn_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_load.Click
        LoadAs()
        LoadFileToDGV()
    End Sub
    Public Sub LoadFileToDGV()
        Dim rowValue As String
        Dim cellValue() As String

        If System.IO.File.Exists(FilePath) Then
            Dim streamReader As System.IO.StreamReader = New StreamReader(FilePath)
            ' Reading header
            rowValue = streamReader.ReadLine
            cellValue = rowValue.Split(Microsoft.VisualBasic.ChrW(44))
            Dim i As Integer = 0
            Do While (i <= (cellValue.Count - 1))
                Dim column As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
                column.Name = cellValue(i)
                column.HeaderText = cellValue(i)
                DataGridView1.Columns.Add(column)
                i = i + 1
            Loop
            ' Reading content
            While (streamReader.Peek <> -1)
                rowValue = streamReader.ReadLine
                cellValue = rowValue.Split(Microsoft.VisualBasic.ChrW(44))
                DataGridView1.Rows.Add(cellValue)

            End While
            streamReader.Close()
        Else
            MessageBox.Show("No File is Selected")
        End If
    End Sub
    Public Sub LoadAs()
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            FilePath = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Fisihing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReDim NameControlDesign(Me.Controls.Count)
        ReDim LocationControlDesign(Me.Controls.Count)
        ReDim SizeControlDesign(Me.Controls.Count)
        SizeFormDesign = Me.Size

        For i As Integer = 0 To Me.Controls.Count - 1
            NameControlDesign(i) = Me.Controls(i).Name
            LocationControlDesign(i) = Me.Controls(i).Location
            SizeControlDesign(i) = Me.Controls(i).Size
        Next i
    End Sub

    Private Sub Fisihing_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        For a As Integer = 0 To sender.Controls.Count - 1
            sender.Controls(a).Location = New Point(sender.Size.Width / SizeFormDesign.Width * LocationControlDesign(a).X, sender.Size.Height / SizeFormDesign.Height * LocationControlDesign(a).Y)
            sender.Controls(a).Size = New Size(sender.Size.Width / SizeFormDesign.Width * SizeControlDesign(a).Width, sender.Size.Height / SizeFormDesign.Height * SizeControlDesign(a).Height)
        Next a
    End Sub

    Private Sub StocktxtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StocktxtToolStripMenuItem.Click
        FilePath = My.Resources.stock
        LoadFileToDGV()
    End Sub

    Private Sub OtherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherToolStripMenuItem.Click
        LoadAs()
        LoadFileToDGV()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(FilePath)
        Dim strHeader As String = DataGridView1.Columns(0).HeaderText
        Dim i As Integer = 1
        Do While (i < DataGridView1.Columns.Count)
            strHeader = (strHeader + ("," + DataGridView1.Columns(i).HeaderText))
            i = (i + 1)
        Loop
        streamWriter.WriteLine(strHeader)
        Dim m As Integer = 0
        Do While (m < DataGridView1.Rows.Count)
            Dim strRowValue As String = ""
            strRowValue = (strRowValue + DataGridView1.Rows(m).Cells(0).Value)
            Dim n As Integer = 1
            Do While (n < DataGridView1.Columns.Count)
                strRowValue = (strRowValue + ("," + DataGridView1.Rows(m).Cells(n).Value))
                n = (n + 1)
            Loop
            streamWriter.WriteLine(strRowValue)
            m = (m + 1)
        Loop
        streamWriter.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Save_Click(sender As System.Object, e As System.EventArgs) Handles Save.Click

    End Sub
End Class