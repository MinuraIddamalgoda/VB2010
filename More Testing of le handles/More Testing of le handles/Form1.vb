Imports System.IO
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Show the openFileDialog. When Ok is pressed, read the file and copy its content into the textBox1.
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Label1.Text = OpenFileDialog1.FileName
            TextBox1.Text = File.ReadAllText(Label1.Text)
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Show the saveFileDialog. When Ok is pressed, save the content of the textBox1 into the chosen file.
        If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            File.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text)
        End If
    End Sub
End Class
