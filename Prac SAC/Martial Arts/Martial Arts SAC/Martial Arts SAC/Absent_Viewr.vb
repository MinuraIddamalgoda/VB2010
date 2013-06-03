Imports System.IO
Public Class Absent_Viewr
    Public file As StreamReader = My.Computer.FileSystem.OpenTextFileReader(My.Resources.Absent)

    Private Sub Absent_Viewr_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        file.Close()
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Absent_Viewr_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub
    Private Sub Absent_Viewr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.Text = file.ReadToEnd
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Show()

        PrintDocument1.DocumentName.Equals("Absent_Viewr")
        PrintDocument1.Print()
    End Sub
End Class