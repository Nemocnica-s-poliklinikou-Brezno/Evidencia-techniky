Module Hashed_password
    Public Function HashPassword(ByVal Password As String) As String

        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(Password)

        bs = x.ComputeHash(bs)

        Dim s As New System.Text.StringBuilder()

        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next

        Return s.ToString()

    End Function
End Module
