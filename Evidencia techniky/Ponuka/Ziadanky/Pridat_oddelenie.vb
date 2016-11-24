Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Public Class Pridat_oddelenie
    Private Sub Pridat_oddelenie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)

        'Vytiahnutie udajov z tabulky oddelenia
        Using cmdOdd As New MySqlCommand("SELECT Nazov_oddelenia from oddelenia where stav = 0;")
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
                        cb_Oddelenia.Items.Add(ds.Tables(0).Rows(i).Item(0))
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

    Private Sub b_Pridat_Click(sender As Object, e As EventArgs) Handles b_Pridat.Click
        Dim cmdINT As String = "INSERT INTO uzivatel_x_oddelenie(id_uzivatela, id_oddelenia, Hlavne, stav, Vlozil_meno, Vlozil_dna) values ('" & Ponuka.Id_uzivatelaOdd & "', '" & oddelenie(cb_Oddelenia.Text) & "', 0, 0, '" & Ponuka.Meno_uzivatela & "', now());"

        con.Open()
        Dim sqlINT As MySqlCommand = New MySqlCommand(cmdINT, con)
        Try
            sqlINT.ExecuteNonQuery()
            MessageBox.Show("Bolo pridané vedlajšie oddelenie", "ETECH - Zápis nového vedlajšieho oddelenia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            logy(8, 1, "")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Zápis nového oddelenia", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            con.Close()
            logy(8, 2, ex.Message)
        End Try

    End Sub
End Class