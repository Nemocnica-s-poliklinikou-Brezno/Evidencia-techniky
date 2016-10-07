Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Imports Evidencia_techniky.Ponuka
Module prava_funk
    Public Function prava() As String
        Dim PPrava As String = ""

        Dim QueryPRAVA As String
        QueryPRAVA = "SELECT DopravaPoistovne FROM prava p join uzivatelia u on u.id_uzivatela = p.id_uzivatela WHERE u.id_uzivatela = '" & Ponuka.id_uzivatela & "' and zablokovany = 0 and u.Vymazal_dna is null;"
        con.Open()
        Dim sqlPRAVA As MySqlCommand = New MySqlCommand(QueryPRAVA, con)
        sqlPRAVA.CommandTimeout = 1200
        Try
            PPrava = sqlPRAVA.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Vytiahnutie práv", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        con.Close()

        Return PPrava
    End Function
End Module
