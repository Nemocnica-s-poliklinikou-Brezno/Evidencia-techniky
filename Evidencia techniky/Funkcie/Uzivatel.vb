Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Module uzivatel_funk
    Public Function uzivatel(ByVal MenoUzivatela As String) As String
        Dim POddelenie As String = ""

        Dim QueryOddelenie As String
        QueryOddelenie = "SELECT id_uzivatela FROM uzivatelia WHERE Priezvisko like LEFT('" & MenoUzivatela & "', INSTR('" & MenoUzivatela & "', ' ')-1) and zablokovany = 0;"
        con.Open()
        Dim sqlOddelenie As MySqlCommand = New MySqlCommand(QueryOddelenie, con)
        sqlOddelenie.CommandTimeout = 1200
        Try
            POddelenie = sqlOddelenie.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Meno alebo číslo užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        con.Close()

        Return POddelenie
    End Function
End Module
