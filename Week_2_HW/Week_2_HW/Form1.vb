Imports System.Text
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_start.Click
        Dim text_in As String = txt_in.Text
        Dim text_out As String = txt_out.Text
        
        txt_out.Text = StrConv(text_in, vbProperCase)


        'txt_out.Text = CalculateMD5Hash(text_in)
    End Sub

    'Public Function CalculateMD5Hash(ByVal input As String) As String
    '    'Calculating the encryption 

    '    Dim inputBytes() As Byte = System.Text.Encoding.ASCII.GetBytes(input)
    '    Dim hash() As Byte = System.Security.Cryptography.MD5.Create.ComputeHash(inputBytes)

    '    'The calculation only calculates byte so I have to convert that to a sting
    '    Dim sb As StringBuilder = New StringBuilder
    '    Dim J As Integer = 0
    '    Do While (J < hash.Length)
    '        sb.Append(hash(J).ToString("X2"))
    '        J = (J + 1)
    '    Loop

    '    Return sb.ToString

    'End Function
End Class
