Imports System.Data.OleDb
Public Class Form1
    Dim dtStudentGrade As DataTable
    Dim dtExcelData As DataTable

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim x As String

        dt.Columns.Add("col1")

        Dim drow As DataRow = dt.NewRow

        drow(0) = "test"
        dt.Rows.Add(drow)
        x = dt.Rows(0)(0)
        'x = dt.Rows(0)(1)

        Dim field() As String
        field(0) = ""
        field(1) = ""
        field(2) = ""
        field(3) = ""
        field(4) = ""
        field(5) = ""
        field(6) = ""
        field(7) = ""
        field(8) = ""
        field(9) = ""
        field(10) = ""
        field(11) = ""
        field(12) = ""
        field(13) = ""

    End Sub

    Private Sub btnBrowser_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowser.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Excel files (*.xls)|*.xls|Excel(2007) files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        lbFilePath.Text = OpenFileDialog1.FileName
    End Sub

    Function ReadExcelFile()
        'Use OleDbDataAdapter  to provide communication between the DataTable and the OleDb Data Sources
        Dim da As New OleDbDataAdapter

        'Use DataTable as storage of data from excel
        Dim dt As New DataTable

        'Use OleDbCommand to execute our SQL statement
        Dim cmd As New OleDbCommand

        'Use OleDbConnection that will be used by OleDbCommand to connect to excel file
        Dim xlsConn As OleDbConnection

        Dim sPath As String = String.Empty

        sPath = Me.lbFilePath.Text

        'Create a new instance of connection and set the datasource value to excel's path
        xlsConn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & sPath & ";Extended Properties=Excel 12.0")

        'Use try catch block to handle some or all possible errors that may occur in a 
        'given block of code, while still running code.

        Try
            'Open the connection
            xlsConn.Open()

            'Set the command connection to opened connection
            cmd.Connection = xlsConn

            'Set the command type to CommandType.Text in order to use SQL statment constructed here 
            'in code editor
            cmd.CommandType = CommandType.Text

            'Assigned the command text to query the excel as shown below
            cmd.CommandText = ("select * from [Sheet1$]")

            'Assign the cmd to dataadapter
            da.SelectCommand = cmd

            'Fill the datatable with data from excel file using DataAdapter
            da.Fill(dt)

        Catch
            'This block Handle the exception.
            MsgBox(ErrorToString)
        Finally
            'We need to close the connection and set to nothing. This code will still execute even the code raised an error
            xlsConn.Close()
            xlsConn = Nothing
        End Try
        Return dt
    End Function


    Public Sub SaveToDB(ByVal iRowIndex As Long)
        Dim conn As New OleDbConnection
        Dim sConnString As String
        Dim cmd As New OleDbCommand
        Dim sSQL As String = String.Empty

        Try
            'Check if the path has a backslash in the end of string
            If Microsoft.VisualBasic.Right(Application.StartupPath, 1) = "\" Then
                sConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "dbexport.accdb;Persist Security Info=False;"
            Else
                sConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\dbexport.accdb;Persist Security Info=False;"
            End If

            'create a new instance of connection
            conn = New OleDbConnection(sConnString)

            'open the connection to be used by command object
            conn.Open()

            'Set the command's connection to our opened connection
            cmd.Connection = conn

            'Set the command type to CommandType.Text in order to use SQL statment constructed here 
            'in code editor
            cmd.CommandType = CommandType.Text

            'Set the comment text to insert the data to database
            cmd.CommandText = "INSERT INTO students_grade ( student_no, student_name, grade ) VALUES(@student_no, @student_name, @grade)"

            'Add parameters in order to set the values in the query
            cmd.Parameters.Add("@student_no", OleDbType.VarChar).Value = dtExcelData.Rows(iRowIndex)(0)
            cmd.Parameters.Add("@student_name", OleDbType.VarChar).Value = dtExcelData.Rows(iRowIndex)(1)
            'This is just a sample of how to check if the field is null.
            cmd.Parameters.Add("@grade", OleDbType.Numeric).Value = IIf(Not IsDBNull(dtExcelData.Rows(iRowIndex)(2)), dtExcelData.Rows(iRowIndex)(2), Nothing)
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub Load_Data()
        Dim conn As New OleDbConnection
        Dim sConnString As String
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter

        Try
            'create a new instance of dtStudentGrade, this datatable will be used to export 
            'data from database to excel
            dtStudentGrade = New DataTable

            'Check if the path has a backslash in the end of string
            If Microsoft.VisualBasic.Right(Application.StartupPath, 1) = "\" Then
                sConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "dbexport.accdb;Persist Security Info=False;"
            Else
                sConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\dbexport.accdb;Persist Security Info=False;"
            End If

            'create a new instance of connection
            conn = New OleDbConnection(sConnString)

            'open the connection to be used by command object
            conn.Open()

            'Set the command's connection to our opened connection
            cmd.Connection = conn

            'Set the command type to CommandType.Text in order to use SQL statment constructed here 
            'in code editor			
            cmd.CommandType = CommandType.Text

            'Set the comment text to load the data from database
            cmd.CommandText = "select * from students_grade"

            'assign the cmd object to dataadapter selectcommand property in order to use it to fill the dtStudentGrade
            da.SelectCommand = cmd

            'Populate the dtStudentGrade with the data from database
            da.Fill(dtStudentGrade)

            'Set the datagridview datasource to dtStudentGrade in order to dispaly the data to user
            dtgResult.DataSource = dtStudentGrade

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub ImportToDB()
        'Create a new instance of dtExcelData datatable
        dtExcelData = New DataTable

        'Set the cursor to wait cursor
        Windows.Forms.Cursor.Current = Cursors.WaitCursor

        'Call ReadExcelFile function to get the data from excel
        dtExcelData = ReadExcelFile()

        'Reset the progressbar
        Me.ProgressBar1.Value = 0

        'Get the DataTable row count to set the progressbar maximum value
        Me.ProgressBar1.Maximum = dtExcelData.Rows.Count
        Me.ProgressBar1.Visible = True

        'Use looping to read the value of field in each row in DataTable
        For i = 0 To dtExcelData.Rows.Count - 1
            'Check if the student number has a value
            If Not IsDBNull(dtExcelData.Rows(i)(0)) Then

                'call save procedure and pass the row varialble i(row index) as parameter to save each the value of each field
                SaveToDB(i)

                'Increase the value of progressbar to inform the user.
                Me.ProgressBar1.Value = Me.ProgressBar1.Value + 1

            End If

        Next

        dtExcelData = Nothing

        'Call the Load_Data procedure that will load the data and display it to DataGrid
        Load_Data()

        'Inform the user that the importing of data has been finished
        MsgBox("Data has successfully imported.", MsgBoxStyle.OkOnly, "Import Export Demo")

    End Sub

    Private Sub btnImport_Click(sender As System.Object, e As System.EventArgs) Handles btnImport.Click
        'Check if there's a selected excel file to be imported
        If Len(Trim(Me.lbFilePath.Text)) > 0 Then
            ImportToDB()
        Else
            'Inform the user if no selected excel file.
            MsgBox("Please select a file.", MsgBoxStyle.OkOnly, "Import Export Demo")
        End If
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            'Call the release object function to release the object before disposing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            'Call the Garbage collector to free the resources consumed by created instances
            GC.Collect()
        End Try
    End Sub

    Private Sub ExportExcel()
        'Create excel objects
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim oValue As Object = System.Reflection.Missing.Value

        Dim sPath As String = String.Empty

        'cereate new object SaveFileDialog that will be use to save the file
        Dim dlgSave As New SaveFileDialog

        'Create a new instance of databale, this will server as container of data
        Dim dt As New DataTable

        'We need to set the default extension to xls so the SaveFileDialog will save the file
        'as excel file
        dlgSave.DefaultExt = "xls"

        'Set the filter for SaveFileDialog
        dlgSave.Filter = "Microsoft Excel|*.xls"

        'set the initial path, you may set a different path if you like
        dlgSave.InitialDirectory = Application.StartupPath

        'Export the data if the user click the ok button of SaveFileDialog
        If dlgSave.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                'Create a new instance of excel application
                xlApp = New Microsoft.Office.Interop.Excel.Application

                'Create an excel workbook
                xlBook = xlApp.Workbooks.Add(oValue)

                'Create an excel sheet named sheet1
                xlSheet = xlBook.Worksheets("sheet1")


                Dim xlRow As Long = 2
                Dim xlCol As Short = 1

                'To create a column for excel we need to loop through DataTable(dtStudentGrade)
                For Each col As DataColumn In dtStudentGrade.Columns

                    'Get the column name and assigned it to excel sheet cells
                    'to assign value to each cell we need to specify the row and column xlSheet.Cells(row, column)
                    xlSheet.Cells(1, xlCol) = col.ColumnName

                    'Increment the xlCol so we can set another column
                    xlCol += 1

                Next

                'reset the progressbar
                Me.ProgressBar1.Visible = True
                Me.ProgressBar1.Minimum = 0
                Me.ProgressBar1.Maximum = dtStudentGrade.Rows.Count

                'Loop through dtStudentGrade to get the value of each field in a row
                For Each row As DataRow In dtStudentGrade.Rows
                    'Reset xlCol's value to 1 
                    xlCol = 1

                    'Loop through dtStudentGrade and set the value of each excel sheet cells
                    For Each col As DataColumn In dtStudentGrade.Columns

                        'Assign the value of each field to selected excel sheet cell
                        xlSheet.Cells(xlRow, xlCol) = row(xlCol - 1)

                        'Increment the xlCol so we can set another the the value of another cell
                        xlCol += 1
                    Next

                    'Increment the xlCol
                    xlRow += 1

                    'Set the value of progressbar
                    If Me.ProgressBar1.Maximum > Me.ProgressBar1.Value + 1 Then
                        Me.ProgressBar1.Value = Me.ProgressBar1.Value + 1
                    End If

                Next

                'Set the filename and set the filename to xlx to save the file as excel 2003
                'You may remove the Replace function and save the file with xlsx(excel 2007) extension
                Dim sFileName As String = Replace(dlgSave.FileName, ".xlsx", "xlx")

                'save the file
                xlSheet.SaveAs(sFileName)

                'close the workbook
                xlBook.Close()

                'Quit the application using this code
                xlApp.Quit()

                'Release the objects used by excell application by calling our procedure releaseObject
                releaseObject(xlApp)
                releaseObject(xlBook)
                releaseObject(xlSheet)

                'Reset the progressbar
                Me.ProgressBar1.Value = 0
                Me.ProgressBar1.Visible = False

                'inform the user if successfull
                MsgBox("Data successfully exported.", MsgBoxStyle.Information, "PRMS/SOB Date Tagging")
            Catch
                MsgBox(ErrorToString)
            Finally

            End Try
        End If

    End Sub

    Private Sub btnExport_Click(sender As System.Object, e As System.EventArgs) Handles btnExport.Click
        ExportExcel()
    End Sub
End Class
