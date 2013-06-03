Imports System.IO
Public Class csv2dgv_direct

    Private Sub btn_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_load.Click
        LoadFile()

        Dim rowValue As String
        Dim cellValue() As String

        If System.IO.File.Exists(txt_path.Text) Then
            Dim streamReader As System.IO.StreamReader = New StreamReader(txt_path.Text)
            ' Reading header
            rowValue = streamReader.ReadLine
            'cellValue = rowValue.Split(Microsoft.VisualBasic.ChrW(44))
            cellValue = rowValue.Split(ControlChars.Tab)
            Dim i As Integer = 0
            Do While (i _
                        <= (cellValue.Count - 1))
                Dim column As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
                column.Name = cellValue(i)
                column.HeaderText = cellValue(i)
                DataGridView1.Columns.Add(column)
                i = (i + 1)
            Loop
            ' Reading content

            While (streamReader.Peek <> -1)
                rowValue = streamReader.ReadLine
                cellValue = rowValue.Split(ControlChars.Tab)
                DataGridView1.Rows.Add(cellValue)

            End While
            streamReader.Close()
        Else
            MessageBox.Show("No File is Selected")
        End If
    End Sub

    Public Sub LoadFile()
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txt_path.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

        Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(txt_path.Text)
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
End Class