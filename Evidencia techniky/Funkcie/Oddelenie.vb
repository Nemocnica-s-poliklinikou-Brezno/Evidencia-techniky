Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Module oddelenie_funk
    Public Function oddelenie(ByVal NazovOddelenia As String) As String
        Dim POddelenie As String = ""

        Dim QueryOddelenie As String
        QueryOddelenie = "SELECT id_oddelenia FROM oddelenia WHERE Nazov_oddelenia = '" & NazovOddelenia & "' and stav = 0;"
        con.Open()
        Dim sqlOddelenie As MySqlCommand = New MySqlCommand(QueryOddelenie, con)
        sqlOddelenie.CommandTimeout = 1200
        Try
            POddelenie = sqlOddelenie.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Názov oddelenia", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        con.Close()

        Return POddelenie
    End Function
End Module
