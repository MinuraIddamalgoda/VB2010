Imports System.IO
Public Class Form1
    Public course_number As Int16
    Public course_type As String

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MsgBox("Double click on a student to make payments")
        MsgBox("Right click to sort")
    End Sub

    Public Sub Load_Info(ByRef course_name As String, ByVal DGV As DataGridView)
        'Values needed to pull .CSV files
        Dim rowValue As String
        Dim cellValue() As String

        'Reading the header
        If System.IO.File.Exists(course_name) Then
            Dim streamReader As System.IO.StreamReader = New StreamReader(course_name)
            rowValue = streamReader.ReadLine
            cellValue = rowValue.Split(Microsoft.VisualBasic.ChrW(44))
            cellValue = rowValue.Split(ControlChars.Tab)
            Dim i As Integer = 0
            Do While (i <= (cellValue.Count - 1))
                Dim column As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
                column.Name = cellValue(i)
                column.HeaderText = cellValue(i)
                DGV.Columns.Add(column)
                i = (i + 1)
            Loop

            'Reading the actual content
            While (streamReader.Peek <> -1)
                rowValue = streamReader.ReadLine
                cellValue = rowValue.Split(ControlChars.Tab)
                DGV.Rows.Add(cellValue)
            End While
            streamReader.Close()
        Else
            MessageBox.Show("No File is Selected")
        End If
    End Sub

    Private Sub btn_pay_Click(sender As System.Object, e As System.EventArgs) Handles btn_end_no_save.Click
        'Exit w/o save
        End
    End Sub

    Private Sub btn_end_save_Click(sender As System.Object, e As System.EventArgs) Handles btn_end_save.Click
        'Exit w/save
        If course_number = "100" Then
            Save_Info(My.Resources.commerce, dgv_course_display)
        ElseIf course_number = "200" Then
            Save_Info(My.Resources.cooking, dgv_course_display)
        End If
        End
    End Sub
    Public Sub Save_Info(ByVal course_type As String, ByVal DGV As DataGridView)
        'Saving the information in the DataGridView (if not, upon loading the program again, 
        'students who have paid now will have a pay status of false)
        Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(course_type, False)
        Dim strHeader As String = DGV.Columns(0).HeaderText
        Dim i As Integer = 1
        Do While (i < DGV.Columns.Count)
            strHeader = (strHeader + (ControlChars.Tab + DGV.Columns(i).HeaderText))
            i = (i + 1)
        Loop
        streamWriter.WriteLine(strHeader)
        Dim m As Integer = 0
        Do While (m < DGV.Rows.Count)
            Dim strRowValue As String = ""
            strRowValue = (strRowValue + DGV.Rows(m).Cells(0).Value)
            Dim n As Integer = 1
            Do While (n < DGV.Columns.Count)
                strRowValue = (strRowValue + (ControlChars.Tab + DGV.Rows(m).Cells(n).Value))
                n = (n + 1)
            Loop
            streamWriter.WriteLine(strRowValue)
            m = (m + 1)
        Loop
        streamWriter.Close()

    End Sub
    'Just setting out the right-click functionality
    Public Sub Sort_Assending(ByVal DGV As DataGridView, ByVal column_name As DataGridViewColumn)
        dgv_course_display.Sort(column_name, System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Public Sub Sort_Decending(ByVal DGV As DataGridView, ByVal column_name As DataGridViewColumn)
        dgv_course_display.Sort(column_name, System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub AssendingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AssendingToolStripMenuItem.Click
        Sort_Assending(dgv_course_display, dgv_course_display.Columns("First Name"))
    End Sub

    Private Sub DecensingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DecensingToolStripMenuItem.Click
        Sort_Decending(dgv_course_display, dgv_course_display.Columns("First Name"))
    End Sub

    Private Sub AssendingToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AssendingToolStripMenuItem1.Click
        Sort_Assending(dgv_course_display, dgv_course_display.Columns("Last Name"))
    End Sub

    Private Sub DecendingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DecendingToolStripMenuItem.Click
        Sort_Decending(dgv_course_display, dgv_course_display.Columns("Last Name"))
    End Sub

    Private Sub AssendingToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles AssendingToolStripMenuItem3.Click
        Sort_Assending(dgv_course_display, dgv_course_display.Columns("Has Paid?"))
    End Sub

    Private Sub DecendingToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles DecendingToolStripMenuItem2.Click
        Sort_Decending(dgv_course_display, dgv_course_display.Columns("Has Paid?"))
    End Sub

    Private Sub AssendingToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles AssendingToolStripMenuItem2.Click
        Sort_Assending(dgv_course_display, dgv_course_display.Columns("ID Number"))
    End Sub

    Private Sub DecendingToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DecendingToolStripMenuItem1.Click
        Sort_Decending(dgv_course_display, dgv_course_display.Columns("ID Number"))
    End Sub

    Public Sub Finalise_Payment(ByVal DGV As DataGridView, ByVal student_ID As Int16, _
                                course_ID As Int16, amount_paid As Integer)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(My.Resources.payments, True)

        file.WriteLine(student_ID & " paid " & _
                       "$" & amount_paid & _
                       " on " & Date.Now() & _
                       " for course no." & course_ID & _
                       ",")
        file.Close()
    End Sub

    Private Sub btn_commerce_Click(sender As System.Object, e As System.EventArgs) Handles btn_commerce.Click
        dgv_course_display.Rows.Clear()
        dgv_course_display.Columns.Clear()

        Load_Info(My.Resources.commerce, dgv_course_display)
        course_number = 100
        course_type = "FT"

        dgv_course_display.Columns("ID Number").SortMode.Equals(DataGridViewColumnSortMode.NotSortable)
        dgv_course_display.Columns("First Name").SortMode.Equals(DataGridViewColumnSortMode.NotSortable)
        dgv_course_display.Columns("Last Name").SortMode.Equals(DataGridViewColumnSortMode.NotSortable)
        dgv_course_display.Columns("Has paid?").SortMode.Equals(DataGridViewColumnSortMode.NotSortable)
    End Sub

    Private Sub btn_cooking_Click(sender As System.Object, e As System.EventArgs) Handles btn_cooking.Click
        dgv_course_display.Rows.Clear()
        dgv_course_display.Columns.Clear()

        Load_Info(My.Resources.cooking, dgv_course_display)
        course_number = 200
        course_type = "PT"

        dgv_course_display.Columns("ID Number").SortMode.Equals(DataGridViewColumnSortMode.NotSortable)
        dgv_course_display.Columns("First Name").SortMode.Equals(DataGridViewColumnSortMode.NotSortable)
        dgv_course_display.Columns("Last Name").SortMode.Equals(DataGridViewColumnSortMode.NotSortable)
        dgv_course_display.Columns("Has paid?").SortMode.Equals(DataGridViewColumnSortMode.NotSortable)
    End Sub

    Private Sub dgv_course_display_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles dgv_course_display.MouseDoubleClick
        'I used a heap of try-catch statements to make the program more robust
        If dgv_course_display.SelectedRows(0).Cells("Has paid?").Value = "false" Then
            Dim amount_paid As Integer = 0
            Dim amount_balance As Integer = 0

            Try
                amount_paid = Int(InputBox("How much has the student paid?", "WIT Payments", "Enter here"))
            Catch ex As Exception
            End Try
            'Calculating balances and whatnot
            Try
                If amount_paid = Calculate_Payment() Then
                    Finalise_Payment(dgv_course_display, _
                                                         dgv_course_display.SelectedRows(0).Cells("ID Number").Value.ToString(), _
                                                         course_number, _
                                                         Calculate_Payment())
                    'Setting their pay status to true
                    If dgv_course_display.SelectedRows(0).Cells("Has Paid?").Value = "false" Then
                        dgv_course_display.SelectedRows(0).Cells("Has Paid?").Value = "true"
                    Else

                    End If
                    'In case the student paid more than what was due
                ElseIf amount_paid > Calculate_Payment() Then
                    amount_balance = amount_paid - Calculate_Payment()
                    MsgBox("Student is owed $" & amount_balance)
                    Finalise_Payment(dgv_course_display, _
                                                         dgv_course_display.SelectedRows(0).Cells("ID Number").Value.ToString(), _
                                                         course_number, _
                                                         Calculate_Payment())
                    'Setting their pay status to true
                    If dgv_course_display.SelectedRows(0).Cells("Has Paid?").Value = "false" Then
                        dgv_course_display.SelectedRows(0).Cells("Has Paid?").Value = "true"
                    Else
                    End If

                ElseIf amount_paid < Calculate_Payment() Then
                    'Program won't set pay status as true unless full fees are paid
                    MsgBox("Student is $" & (Calculate_Payment() - amount_paid) & " out of balance")
                End If
            Catch ex As Exception
            End Try

            'Making the program more robust to bad input
        ElseIf dgv_course_display.SelectedRows(0).Cells("Has paid?").Value = "true" Then
            MsgBox("Student has already paid")
        End If

    End Sub
    Public Sub Print_Receipt(ByVal first_name As String, _
                              ByVal last_name As String, _
                              ByVal price As Decimal)
        PrintDocument1.DocumentName = My.Resources.payments
        PrintDocument1.Print()
    End Sub


    'I knew I'd be caluclating the payments a lot so it's more efficient to make a 
    'function for it
    Public Function Calculate_Payment()
        Dim amount_due As Integer
        If course_type = "FT" Then
            amount_due = 2500
        ElseIf course_type = "PT" Then
            amount_due = 1500
        ElseIf course_type = "OL" Then
            amount_due = 1000
        End If

        Return amount_due
    End Function
End Class