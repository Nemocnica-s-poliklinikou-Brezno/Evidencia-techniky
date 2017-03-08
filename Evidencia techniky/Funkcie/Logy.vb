Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Module Logy_funk
    Public Function logy(ByVal TypZaznamu As Integer, ByVal PopisZaznamu As Integer, ByVal TextChyby As String) As String
        Dim ErrorText As String = ""

        Dim QueryZAZNAM As String
        QueryZAZNAM = "INSERT INTO zaznamy(Popis_zaznam, Typ_zaznam, Text_chyby, Vlozil_meno, Vlozil_dna) values ('" & PopisZaznamu.ToString & "', '" & TypZaznamu.ToString & "', '" & Replace(TextChyby, "'", "") & "', '" & Ponuka.Meno_uzivatela & "', now());"
        con.Open()
        Dim sqlZAZNAM As MySqlCommand = New MySqlCommand(QueryZAZNAM, con)
        sqlZAZNAM.CommandTimeout = 1200
        Try
            sqlZAZNAM.ExecuteScalar()
            con.Close()
        Catch ex As Exception
            con.Close()
            ErrorText = MessageBox.Show(ex.Message, "ETECH - Zápis logov do databázy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        con.Close()

        Return ErrorText.ToString
    End Function
End Module
