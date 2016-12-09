Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Imports Evidencia_techniky.Zariadenia
Public Class ZariadeniaPresunVloz

    Public Sub Zariadenia_presun_vloz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)

        dtp_PresunutyDna.Text = Now()

        con.Open()
        Dim cmd As String = "SELECT o.Nazov_oddelenia, pxo.Miestnost from zariadenia_x_oddelenie pxo join oddelenia o On o.id_oddelenia = pxo.id_oddelenia where id_zariadenia = '" & id_zariadenia & "' and pxo.stav in (0, 1);"
        Dim data As MySqlDataReader
        Dim adapter As New MySqlDataAdapter
        Dim command As New MySqlCommand
        command.CommandText = cmd
        command.Connection = con
        adapter.SelectCommand = command
        data = command.ExecuteReader
        If data.HasRows Then
            While data.Read()

                tb_ZOddelenia.Text = data("Nazov_oddelenia").ToString
                tb_ZOddeleniaMiestnost.Text = data("Miestnost").ToString

            End While
            data.Close()
            con.Close()
        Else
            MessageBox.Show("Nebolo nájdené žiadne oddelenie !", "ETECH - Presun medzi oddeleniami", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            con.Close()
        End If

        Using cmdOdd As New MySqlCommand("SELECT Nazov_oddelenia from oddelenia where stav = 0 order by 1 asc;")
            cmdOdd.Connection = con
            cmdOdd.CommandTimeout = 1200
            con.Open()

            Using sdr As MySqlDataReader = cmdOdd.ExecuteReader()
                If sdr.HasRows Then
                    'Vytvorenie tabulky
                    Dim dtCustomers As New DataTable("Customers")
                    Dim ds As New DataSet()

                    'Nacitanie dat
                    dtCustomers.Load(sdr)

                    'Pridanie dat do tabulky
                    ds.Tables.Add(dtCustomers)

                    Dim i As Integer = 0

                    Do Until i = ds.Tables(0).Rows.Count
                        cb_NaOddelenie.Items.Add(ds.Tables(0).Rows(i).Item(0))
                        i = i + 1
                    Loop
                    con.Close()
                Else
                    MessageBox.Show("Neboli nájdené žiadne záznamy !", "ETECH - Vyhľadanie v databáze", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    con.Close()
                End If
            End Using
        End Using
    End Sub

    Private Sub cb_NaOddelenie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_NaOddelenie.SelectedIndexChanged
        b_Presun.Enabled = True
    End Sub

    Private Sub b_Presun_Click(sender As Object, e As EventArgs) Handles b_Presun.Click
        Dim PZapozicka As String = ""

        If Chlb_ZapozikaServisny.SelectedItem = "Zápožička" Then
            PZapozicka = 1
        End If

        Dim cmdDEL As String = "UPDATE zariadenia_x_oddelenie SET stav = 1, Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() WHERE id_zariadenia = " & id_zariadenia & " and stav = 0;"
        Dim cmdINT As String = "INSERT INTO zariadenia_x_oddelenie(id_zariadenia, id_oddelenia, Miestnost, Presunute_dna, Zapozicka, stav, Vlozil_meno, Vlozil_dna) values (" & id_zariadenia & ", '" & oddelenie(cb_NaOddelenie.Text) & "', '" & tb_NaOddelenieMiestnost.Text & "', '" & uprava_datumu(dtp_PresunutyDna.Text) & "', '" & PZapozicka & "', 0, '" & Ponuka.Meno_uzivatela & "', now());"

        con.Open()
        Dim sqlDEL As MySqlCommand = New MySqlCommand(cmdDEL, con)
        Dim sqlINT As MySqlCommand = New MySqlCommand(cmdINT, con)
        Try
            sqlDEL.ExecuteNonQuery()
            Try
                sqlINT.ExecuteNonQuery()
                con.Close()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Zápis nového oddelenia", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                con.Close()
            End Try
        Catch ex2 As Exception
            MessageBox.Show(ex2.Message, "ETECH - Deaktivácia oddelenia", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            con.Close()
        End Try
        MessageBox.Show("Presun na " & cb_NaOddelenie.Text & " bol úspešný", "ETECH - Deaktivácia oddelenia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
        logy(2, 1, "")
        Me.Close()
    End Sub
End Class