Imports System.Text.RegularExpressions
Public Class Form1
    Public amount As Integer = InputBox("How many numbers ya'll want?")

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim random As New Random
        Dim password As New System.Text.StringBuilder
        For i As Int32 = 1 To amount
            password.Append(Chr(random.Next(32, 127)))
        Next
        Label1.Text = password.ToString

    End Sub
End Class
