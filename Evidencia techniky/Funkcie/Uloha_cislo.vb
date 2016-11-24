Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Module Uloha_Cislo_funk

    Public Function Uloha_Cislo() As String
        Dim CisloUloha As String = ""

        Dim CisloUlohaQuery As String
        CisloUlohaQuery = "SELECT max(Uloha_cislo) FROM uloha where stav = 0;"
        con.Open()
        Dim CisloUlohaSQL As MySqlCommand = New MySqlCommand(CisloUlohaQuery, con)
        CisloUlohaSQL.CommandTimeout = 1200
        Try
            CisloUloha = CisloUlohaSQL.ExecuteScalar()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Vytiahnutie čísla úlohy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            con.Close()
        End Try

        Return CisloUloha

    End Function
End Module
