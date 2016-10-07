Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Public Class Pridat_k_praci
    Private Sub Pridat_k_praci_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)

        'Vytiahnutie udajov z ciselnika -- TYP PRÁCE
        Using cmdOdd As New MySqlCommand("SELECT cd.Nazov_hodnoty FROM ciselnik_data cd where cd.idciselnik = 9 and cd.stav = 0;")
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
                        cb_Prace.Items.Add(ds.Tables(0).Rows(i).Item(0))
                        i = i + 1
                    Loop
                    con.Close()
                Else
                    MessageBox.Show("Neboli nájdené žiadne záznamy !", "ETECH - Vyhľadanie oddelení v databáze", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    con.Close()
                End If
            End Using
        End Using

        'Vytiahnutie udajov z tabulky oddelenia
        Using cmdOdd As New MySqlCommand("SELECT CONCAT_WS(' ', uz.Priezvisko, uz.Meno) FROM uzivatel_x_oddelenie uxo
        join uzivatelia uz on uz.id_uzivatela = uxo.id_uzivatela and uz.zablokovany = 0
        where uxo.id_oddelenia = (select id_oddelenia from uzivatel_x_oddelenie uxo where uxo.id_uzivatela = '" & Ponuka.id_uzivatela & "' and hlavne = 1 and uxo.stav = 0) and uxo.id_uzivatela != '" & Ponuka.id_uzivatela & "' and uxo.stav = 0;")
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
                        cb_Uzivatelia.Items.Add(ds.Tables(0).Rows(i).Item(0))
                        i = i + 1
                    Loop
                    con.Close()
                Else
                    MessageBox.Show("Neboli nájdené žiadne záznamy !", "ETECH - Vyhľadanie užívateľov v databáze", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    con.Close()
                End If
            End Using
        End Using

    End Sub

    Private Sub b_Priradit_Click(sender As Object, e As EventArgs) Handles b_Priradit.Click
        Dim cmdINT As String = "INSERT INTO uzivatel_x_prace(id_uzivatela, id_prace, stav, Vlozil_meno, Vlozil_dna) values ('" & uzivatel(cb_Uzivatelia.Text) & "', '" & ciselnik(1, 9, cb_Prace.Text) & "', 0, '" & Ponuka.Meno_uzivatela & "', now());"

        con.Open()
        Dim sqlINT As MySqlCommand = New MySqlCommand(cmdINT, con)
        Try
            sqlINT.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Bola pridaná práca k užívateľovi", "ETECH - Pridanie práce k užívateľovi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            logy(9, 1, "")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Pridanie práce k užívateľovi", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            con.Close()
            logy(9, 2, ex.Message)
        End Try
        con.Close()

    End Sub
End Class