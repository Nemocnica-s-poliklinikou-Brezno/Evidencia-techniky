Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Module PocetUloha
    Public Function Pocet_uloha(ByVal typ_ulohy As String, ByVal stav_ulohy As String) As String
        Dim PocetUloha As String = ""

        Dim QueryCiselnik As String
        QueryCiselnik = "Select count(*) FROM uloha u WHERE Typ_ulohy = '" & typ_ulohy & "' and Stav_ulohy = '" & stav_ulohy & "' and (u.Nahlasil_ID_zamestanca = '" & Ponuka.id_uzivatela & "' or '" & Ponuka.ZiadankySprava & "' = 1) and u.stav = 0;"
        con.Open()
        Dim sqlCiselnik As MySqlCommand = New MySqlCommand(QueryCiselnik, con)

        Try
            PocetUloha = sqlCiselnik.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Vytiahnutie počtu úloh pri určitom stave", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        con.Close()

        Return PocetUloha

    End Function
End Module