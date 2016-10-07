Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Module Vratenie_na_oddelenie_funk
    Public Function vratenie_na_oddelenie(ByVal cislo_ulohy As String, ByVal cislo_oddelenia As String, ByVal stav_ulohy As String, ByVal dovod_stavu As String) As String
        Dim ErrorText As String = ""

        Dim QueryZAZNAM As String
        QueryZAZNAM = "INSERT INTO uloha_x_stav(id_ulohy, id_oddelenie, stav_ulohy, dovod_stav, stav, Vlozil_meno, Vlozil_dna) values ('" & cislo_ulohy & "', '" & cislo_oddelenia & "', '" & stav_ulohy & "', '" & dovod_stavu & "', 0, '" & UCase(Ponuka.Meno_uzivatela) & "', now());"
        con.Open()
        Dim sqlZAZNAM As MySqlCommand = New MySqlCommand(QueryZAZNAM, con)
        sqlZAZNAM.CommandTimeout = 1200
        Try
            sqlZAZNAM.ExecuteScalar()
            con.Close()
        Catch ex As Exception
            ErrorText = MessageBox.Show(ex.Message, "ETECH - Vrátenie úlohy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            con.Close()
        End Try

        Dim QuerySTAV As String
        QuerySTAV = "UPDATE uloha SET Stav_ulohy = '" & stav_ulohy & "', Upravil_meno = '" & Prihlasenie.tb_Meno.Text & "', Upravil_dna = now() WHERE id_ulohy = '" & cislo_ulohy & "';"
        con.Open()
        Dim sqlSTAV As MySqlCommand = New MySqlCommand(QuerySTAV, con)
        sqlSTAV.CommandTimeout = 1200
        Try
            sqlSTAV.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            ErrorText = MessageBox.Show(ex.Message, "ETECH - Zmena stavu úlohy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            con.Close()
        End Try

        Return ErrorText.ToString
    End Function
End Module
