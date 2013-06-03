Imports System.IO
Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Loading files into DataGridView
        Load_Files(My.Resources.part_time, dgv_PT)
        Load_Files(My.Resources.full_time, dgv_FT)

        'Setting out the DataGridView's sorting mechanisms
        sort_DGV(dgv_PT, "ID Number")
        sort_DGV(dgv_PT, "Firstname")
        sort_DGV(dgv_PT, "Surname")
        sort_DGV(dgv_PT, "Pay Status")

        sort_DGV(dgv_FT, "ID Number")
        sort_DGV(dgv_FT, "Firstname")
        sort_DGV(dgv_FT, "Surname")
        sort_DGV(dgv_FT, "Pay Status")
    End Sub
    Public Sub sort_DGV(ByVal DGV As DataGridView, ByVal column_name As String)
        DGV.Columns(column_name).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Public Sub Load_Files(ByVal TXT_course_type As String, ByVal DGV_course_type As DataGridView)
        Dim rowValue As String
        Dim cellValue() As String

        If System.IO.File.Exists(TXT_course_type) Then
            Dim streamReader As System.IO.StreamReader = New StreamReader(TXT_course_type)

            ' Reading header
            rowValue = streamReader.ReadLine
            cellValue = rowValue.Split(ControlChars.Tab)
            Dim i As Integer = 0
            Do While (i <= (cellValue.Count - 1))
                Dim column As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
                column.Name = cellValue(i)
                column.HeaderText = cellValue(i)
                DGV_course_type.Columns.Add(column)
                i = (i + 1)
            Loop

            ' Reading content
            While (streamReader.Peek <> -1)
                rowValue = streamReader.ReadLine
                cellValue = rowValue.Split(ControlChars.Tab)
                DGV_course_type.Rows.Add(cellValue)

            End While
            streamReader.Close()
        Else
            MessageBox.Show("No File is Selected")
        End If
    End Sub

    Private Sub cb_FT_TextChanged(sender As System.Object, e As System.EventArgs) Handles cb_FT.TextChanged
        cb_FT.ForeColor = Color.Black
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If cb_FT.Text = "Sort by..." Or cb_FT.Text = "" Then
            cb_FT.ForeColor = Color.Gray
        End If

        If cb_PT.Text = "Sort by..." Or cb_PT.Text = "" Then
            cb_PT.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub cb_PT_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cb_PT.SelectedIndexChanged
        cb_PT.ForeColor = Color.Black

        If cb_PT.Text = "ID Number" Then
            dgv_PT.Sort(dgv_PT.Columns("ID Number"), System.ComponentModel.ListSortDirection.Ascending)
        End If

        If cb_PT.Text = "Pay Status" Then
            dgv_PT.Sort(dgv_PT.Columns("Pay Status"), System.ComponentModel.ListSortDirection.Ascending)
        End If

        If cb_PT.Text = "Firstname" Then
            dgv_PT.Sort(dgv_PT.Columns("First Name"), System.ComponentModel.ListSortDirection.Ascending)
        End If

        If cb_PT.Text = "Surname" Then
            dgv_PT.Sort(dgv_PT.Columns("First Name"), System.ComponentModel.ListSortDirection.Ascending)
        End If
    End Sub

    Public Sub DGV_cell_clicked(ByVal dgv_day As DataGridView)
        Dim pay_amount As Decimal = Val(InputBox("Enter how much student is paying", "WIT Payment System", "Enter here"))
        Dim print_reciept As Boolean
        Dim pay_status As Integer = False


        If dgv_day.SelectedRows(0).Cells("Pay Status").Value.Equals("true") Then
            MsgBox("already paid")
        ElseIf dgv_day.SelectedRows(0).Cells("Pay Status").Value.Equals("false") Then
            If pay_amount > 0 Then
                MsgBox("Transaction completed")
                dgv_day.SelectedRows(0).Cells("Pay Status").Value = "true"
                MsgBox("D'you want a reciept?", vbYesNo, "Transaction completed")
                If vbYes Then
                    print_reciept = True
                End If
            End If
        End If

        If print_reciept = True Then

            Dim File As StreamWriter
            File = My.Computer.FileSystem.OpenTextFileWriter(My.Resources.reciept, False)
            File.WriteLine("WIT Payment System" & vbCr & _
                           "Payment from " & dgv_PT.SelectedRows(0).Cells("Firstname").Value.ToString() & _
                           " " & dgv_PT.SelectedRows(0).Cells("Surname").Value.ToString() & vbCr & _
                           "Total value of: $" & pay_amount)
            File.Close()

            PrintDocument1.DocumentName = My.Resources.reciept
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub cb_FT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_FT.SelectedIndexChanged
        cb_FT.ForeColor = Color.Black

        If cb_FT.Text = "ID Number" Then
            dgv_FT.Sort(dgv_FT.Columns("ID Number"), System.ComponentModel.ListSortDirection.Ascending)
        End If

        If cb_FT.Text = "Pay Status" Then
            dgv_FT.Sort(dgv_FT.Columns("Pay Status"), System.ComponentModel.ListSortDirection.Ascending)
        End If

        If cb_FT.Text = "Firstname" Then
            dgv_FT.Sort(dgv_FT.Columns("First Name"), System.ComponentModel.ListSortDirection.Ascending)
        End If

        If cb_FT.Text = "Surname" Then
            dgv_FT.Sort(dgv_FT.Columns("First Name"), System.ComponentModel.ListSortDirection.Ascending)
        End If
    End Sub
    Private Sub dgv_PT_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv_PT.DoubleClick
        DGV_cell_clicked(dgv_PT)
    End Sub

    Private Sub dgv_FT_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv_FT.DoubleClick
        DGV_cell_clicked(dgv_FT)
    End Sub
End Class
