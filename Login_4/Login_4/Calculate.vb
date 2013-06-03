Imports System.Text
Module Calculate
    Public Class Generate
        Public Function CalculateHash(ByVal input As String) As String
            ' step 1, calculate MD5 hash from input
            Dim hash() As Byte = System.Security.Cryptography.MD5.Create.ComputeHash(System.Text.Encoding.ASCII.GetBytes(input))
            ' step 2, convert byte array to hex string
            Dim sb As StringBuilder = New StringBuilder
            Dim i As Integer = 0
            Do While (i < hash.Length)
                sb.Append(hash(i).ToString("X2"))
                i = (i + 1)
            Loop
            Return sb.ToString
        End Function
    End Class
End Module
