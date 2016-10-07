Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Module Import_funk

    Public Function Import() As String
        Dim PoslednyImport As String = ""

        Dim QueryIMP As String
        QueryIMP = "SELECT DATE_FORMAT(max(casvyjazdu), ""%d.%m.%Y"") FROM doprava_data;"
        con.Open()
        Dim sqlIMP As MySqlCommand = New MySqlCommand(QueryIMP, con)
        sqlIMP.CommandTimeout = 1200
        Try
            PoslednyImport = sqlIMP.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Select posledný import", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        con.Close()

        Return PoslednyImport
    End Function
End Module
