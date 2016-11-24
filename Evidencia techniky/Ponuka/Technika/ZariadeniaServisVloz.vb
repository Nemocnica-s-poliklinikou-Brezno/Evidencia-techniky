Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie

Public Class ZariadeniaServisVloz

    Private Sub Zariadenia_Servis_Vloz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)

        Dim Query As String
        Query = "SELECT Nazov_hodnoty FROM ciselnik_data WHERE stav = 0 AND idciselnik = 3;"
        con.Open()
        Dim sql As MySqlCommand = New MySqlCommand(Query, con)
        Try
            Using servis As MySqlDataReader = sql.ExecuteReader()

                'Vytvorenie tabulky.
                Dim dtServis As New DataTable("Servis")
                Dim ds As New DataSet()

                'Nacitanie dat
                dtServis.Load(servis)

                'Pridanie dat do tabulky
                ds.Tables.Add(dtServis)

                Dim i As Integer

                Do Until i = 2
                    cb_DruhOpravy.Items.Add(ds.Tables(0).Rows(i).Item(0))
                    i = i + 1
                Loop
                con.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Zistenie zoznamu druhu servisných prác", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            con.Close()
        End Try
    End Sub

    Private Sub b_Zapisat_Click(sender As Object, e As EventArgs) Handles b_Zapisat.Click
        Dim QueryPC As String
        QueryPC = "INSERT INTO zariadenia_servis(id_zariadenia, datum_vybavenia, popis_problemu, sposob_vyriesenia, stav, Vlozil_meno, Vlozil_dna) VALUES ('" & Zariadenia.id_zariadenia & "', '" & uprava_datumu(dtp_DatumVybavenia.Text) & "', '" & tb_PopisChyby.Text & "', '" & cb_DruhOpravy.Text & "', 0, '" & Ponuka.Meno_uzivatela & "', now());"
        con.Open()
        Dim sqlPC As MySqlCommand = New MySqlCommand(QueryPC, con)
        Try
            sqlPC.ExecuteNonQuery()
            MessageBox.Show("Údaje BOLI vložené!", "ETECH - Zápis servisu do databázy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Zápis servisu do databázy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            con.Close()
        End Try
    End Sub
End Class