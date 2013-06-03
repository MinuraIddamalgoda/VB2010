Imports System.Text
Public Module Generate
    Public users(100) As String
    Public pass(100) As String
    Public Function Hash(ByVal input As String) As String

        'step 1, calculate MD5 hash from input
        Dim md5() As Byte = System.Security.Cryptography.MD5.Create.ComputeHash(System.Text.Encoding.ASCII.GetBytes(input))
        'step 2, convert byte array to hex string
        Dim sb As StringBuilder = New StringBuilder
        Dim i As Integer = 0
        Do While (i < md5.Length)
            sb.Append(md5(i).ToString("X2"))
            i = (i + 1)
        Loop
        Return sb.ToString
    End Function
End Module
