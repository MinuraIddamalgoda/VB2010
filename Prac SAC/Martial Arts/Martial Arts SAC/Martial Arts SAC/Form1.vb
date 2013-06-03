Imports System.IO
Imports System.Drawing.Printing

Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Loading txt file into program
        Monday_Load()
        Tuesday_Load()
        Wednesday_Load()

        'Sorting all DataGridViews
        Sort_DGV(dgv_monday)
        Sort_DGV(dgv_tuesday)
        Sort_DGV(dgv_wed)

    End Sub
    Public Sub Sort_DGV(ByVal day As DataGridView)
        day.Columns("").SortMode = DataGridViewColumnSortMode.NotSortable
        day.Columns("Firstname").SortMode = DataGridViewColumnSortMode.Automatic
        day.Columns("Surname").SortMode = DataGridViewColumnSortMode.Automatic
    End Sub
    'Loads Monday schedule into program
    Private Sub Monday_Load()
        Dim rowValue As String
        Dim cellValue() As String

        If System.IO.File.Exists(My.Resources.Monday) Then
            Dim streamReader As System.IO.StreamReader = New StreamReader(My.Resources.Monday)
            ' Reading header
            rowValue = streamReader.ReadLine
            cellValue = rowValue.Split(ControlChars.Tab)
            Dim i As Integer = 0
            Do While (i _
                        <= (cellValue.Count - 1))
                Dim column As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
                column.Name = cellValue(i)
                column.HeaderText = cellValue(i)
                dgv_monday.Columns.Add(column)
                i = (i + 1)
            Loop
            ' Reading content

            While (streamReader.Peek <> -1)
                rowValue = streamReader.ReadLine
                cellValue = rowValue.Split(ControlChars.Tab)
                dgv_monday.Rows.Add(cellValue)

            End While
            streamReader.Close()
        Else
            MessageBox.Show("No File is Selected")
        End If
    End Sub
    'Loads Tuesday schedule into program
    Private Sub Tuesday_Load()
        Dim rowValue As String
        Dim cellValue() As String

        If System.IO.File.Exists(My.Resources.Tuesday) Then
            Dim streamReader As System.IO.StreamReader = New StreamReader(My.Resources.Tuesday)
            ' Reading header
            rowValue = streamReader.ReadLine
            cellValue = rowValue.Split(ControlChars.Tab)
            Dim i As Integer = 0
            Do While (i _
                        <= (cellValue.Count - 1))
                Dim column As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
                column.Name = cellValue(i)
                column.HeaderText = cellValue(i)
                dgv_tuesday.Columns.Add(column)
                i = (i + 1)
            Loop
            ' Reading content

            While (streamReader.Peek <> -1)
                rowValue = streamReader.ReadLine
                cellValue = rowValue.Split(ControlChars.Tab)
                dgv_tuesday.Rows.Add(cellValue)

            End While
            streamReader.Close()
        Else
            MessageBox.Show("No File is Selected")
        End If
    End Sub
    'Loads Wednesday schedule into program
    Private Sub Wednesday_Load()
        Dim rowValue As String
        Dim cellValue() As String

        If System.IO.File.Exists(My.Resources.Wednesday) Then
            Dim streamReader As System.IO.StreamReader = New StreamReader(My.Resources.Wednesday)
            ' Reading header
            rowValue = streamReader.ReadLine
            cellValue = rowValue.Split(ControlChars.Tab)
            Dim i As Integer = 0
            Do While (i _
                        <= (cellValue.Count - 1))
                Dim column As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
                column.Name = cellValue(i)
                column.HeaderText = cellValue(i)
                dgv_wed.Columns.Add(column)
                i = (i + 1)
            Loop
            ' Reading content

            While (streamReader.Peek <> -1)
                rowValue = streamReader.ReadLine
                cellValue = rowValue.Split(ControlChars.Tab)
                dgv_wed.Rows.Add(cellValue)

            End While
            streamReader.Close()
        Else
            MessageBox.Show("No File is Selected")
        End If
    End Sub

    'Saves entered data into txt file
    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MsgBox("Do you want to save changes?", MsgBoxStyle.YesNo, "Save on close?")
        If DialogResult = vbYes Then
            Monday_Close()
            Tuesday_Close()
            Wednesday_Close()
        Else
            End
        End If

    End Sub
    Private Sub Monday_Close()
        Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(My.Resources.Monday)
        Dim strHeader As String = dgv_monday.Columns(0).HeaderText
        Dim i As Integer = 1
        Do While (i < dgv_monday.Columns.Count)
            strHeader = (strHeader + (ControlChars.Tab + dgv_monday.Columns(i).HeaderText))
            i = (i + 1)
        Loop
        streamWriter.WriteLine(strHeader)
        Dim m As Integer = 0
        Do While (m < dgv_monday.Rows.Count)
            Dim strRowValue As String = ""
            strRowValue = (strRowValue + dgv_monday.Rows(m).Cells(0).Value)
            Dim n As Integer = 1
            Do While (n < dgv_monday.Columns.Count)
                strRowValue = (strRowValue + (ControlChars.Tab + dgv_monday.Rows(m).Cells(n).Value))
                n = (n + 1)
            Loop
            streamWriter.WriteLine(strRowValue)
            m = (m + 1)
        Loop
        streamWriter.Close()
    End Sub
    Private Sub Tuesday_Close()
        Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(My.Resources.Tuesday)
        Dim strHeader As String = dgv_tuesday.Columns(0).HeaderText
        Dim i As Integer = 1
        Do While (i < dgv_tuesday.Columns.Count)
            strHeader = (strHeader + (ControlChars.Tab + dgv_tuesday.Columns(i).HeaderText))
            i = (i + 1)
        Loop
        streamWriter.WriteLine(strHeader)
        Dim m As Integer = 0
        Do While (m < dgv_tuesday.Rows.Count)
            Dim strRowValue As String = ""
            strRowValue = (strRowValue + dgv_tuesday.Rows(m).Cells(0).Value)
            Dim n As Integer = 1
            Do While (n < dgv_tuesday.Columns.Count)
                strRowValue = (strRowValue + (ControlChars.Tab + dgv_tuesday.Rows(m).Cells(n).Value))
                n = (n + 1)
            Loop
            streamWriter.WriteLine(strRowValue)
            m = (m + 1)
        Loop
        streamWriter.Close()
    End Sub
    Public Sub Wednesday_Close()
        Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(My.Resources.Wednesday)
        Dim strHeader As String = dgv_wed.Columns(0).HeaderText
        Dim i As Integer = 1
        Do While (i < dgv_wed.Columns.Count)
            strHeader = (strHeader + (ControlChars.Tab + dgv_wed.Columns(i).HeaderText))
            i = (i + 1)
        Loop
        streamWriter.WriteLine(strHeader)
        Dim m As Integer = 0
        Do While (m < dgv_wed.Rows.Count)
            Dim strRowValue As String = ""
            strRowValue = (strRowValue + dgv_wed.Rows(m).Cells(0).Value)
            Dim n As Integer = 1
            Do While (n < dgv_wed.Columns.Count)
                strRowValue = (strRowValue + (ControlChars.Tab + dgv_wed.Rows(m).Cells(n).Value))
                n = (n + 1)
            Loop
            streamWriter.WriteLine(strRowValue)
            m = (m + 1)
        Loop
        streamWriter.Close()
    End Sub

    Public Sub btn_tue_Click(sender As System.Object, e As System.EventArgs) Handles btn_tue.Click
        If dgv_tuesday.RowCount > 10 Then
            MsgBox("There's already 10 people there")
        Else
            Move_Rows(dgv_from:=dgv_monday, dgv_to:=dgv_tuesday)
        End If
    End Sub

    Public Sub Move_Rows(ByVal dgv_from As DataGridView, ByVal dgv_to As DataGridView)
        For Each sel_row As DataGridViewRow In dgv_from.SelectedRows
            dgv_from.Rows.Remove(sel_row)
            dgv_to.Rows.Add(sel_row)
        Next
    End Sub

    Private Sub btn_mark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mark.Click
        Mark_Absent(dgv_monday)
    End Sub

    Public Sub Mark_Absent(ByVal day As DataGridView)
        Dim absent_file As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(My.Resources.Absent, True)
        absent_file.WriteLine(day.SelectedRows(0).Cells("Firstname").Value & vbTab & day.SelectedRows(0).Cells("Surname").Value & vbTab & "--" & vbTab & Date.Now())
        absent_file.Close()

        Try
            day.Rows.Remove(day.Rows(day.SelectedCells.Item(0).RowIndex))
        Catch ex As Exception

        End Try




    End Sub

    ' Gets a list of the DataRow objects that are the datasources for a DataGridViews selected rows
    Public Shared Function GetSelectedDataRows(ByVal grid As DataGridView) As DataRow()
        Dim dRows() As DataRow = New DataRow((grid.SelectedRows.Count) - 1) {}
        Dim i As Integer = 0
        Do While (i < grid.SelectedRows.Count)
            dRows(i) = CType(grid.SelectedRows(i).DataBoundItem, DataRowView).Row
            i = (i + 1)
        Loop
        Return dRows
    End Function

    ' move row from one grid to another
    Public Sub MoveRows(ByVal src As DataTable, ByVal dest As DataTable, ByVal rows() As DataRow)
        For Each row As DataRow In rows
            ' add to dest
            dest.Rows.Add(row.ItemArray)
            ' remove from src
            src.Rows.Remove(row)
        Next
    End Sub

    Private Sub btn_wed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_wed.Click
        If dgv_wed.RowCount > 10 Then
            MsgBox("There's already 10 people there")
        Else
            Move_Rows(dgv_from:=dgv_monday, dgv_to:=dgv_wed)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mon.Click
        If dgv_monday.RowCount > 10 Then
            MsgBox("There's already 10 people there")
        Else
            Move_Rows(dgv_from:=dgv_tuesday, dgv_to:=dgv_monday)
        End If
    End Sub

    Private Sub btn_wed2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_wed2.Click
        If dgv_wed.RowCount > 10 Then
            MsgBox("There's already 10 people there")
        Else
            Move_Rows(dgv_from:=dgv_tuesday, dgv_to:=dgv_wed)
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If dgv_monday.RowCount > 10 Then
            MsgBox("There's already 10 people there")
        Else
            Move_Rows(dgv_from:=dgv_wed, dgv_to:=dgv_monday)
        End If
    End Sub

    Private Sub btn_tue2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tue2.Click
        If dgv_tuesday.RowCount > 10 Then
            MsgBox("There's already 10 people there")
        Else
            Move_Rows(dgv_from:=dgv_wed, dgv_to:=dgv_tuesday)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Mark_Absent(dgv_tuesday)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Mark_Absent(dgv_wed)
    End Sub

    Private Sub btn_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show.Click
        Absent_Viewr.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Absent_Viewr.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Absent_Viewr.Show()
    End Sub

    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click
        


    End Sub
End Class
