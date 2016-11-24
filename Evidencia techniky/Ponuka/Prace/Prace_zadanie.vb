Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Public Class Prace_zadanie
    Private Sub Prace_zadanie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)

        'generovat datum pridelenia ziadanky pracovnikovi
        l_ZiadankaCislo.Text = Ziadanky_sprava.PUlohaCislo
        l_OznacPraca.Text = ""

        'Vytiahnutie udajov z ciselnika -- TYP PRÁCE
        Dim QueryPrace As String
        QueryPrace =
        "SELECT cd.Nazov_hodnoty FROM uloha_x_uzivatel uxu
        join ciselnik_data cd on uxu.hodnota = cd.hodnota and uxu.idciselnik = cd.idciselnik and cd.stav = 0
        where uxu.id_uzivatela = '" & Ponuka.id_uzivatela & "' and uxu.idciselnik = 9 and uxu.stav = 0;"
        con.Open()
        Dim sqlPrace As MySqlCommand = New MySqlCommand(QueryPrace, con)
        Try
            Using odd As MySqlDataReader = sqlPrace.ExecuteReader()

                'Vytvorenie tabulky.
                Dim dtPrace As New DataTable("Prace")
                Dim ds2 As New DataSet()

                'Nacitanie dat
                dtPrace.Load(odd)

                'Pridanie dat do tabulky
                ds2.Tables.Add(dtPrace)

                Dim i As Integer = 0

                Do Until i = ds2.Tables(0).Rows.Count
                    cb_TypPrace.Items.Add(ds2.Tables(0).Rows(i).Item(0))
                    i = i + 1
                Loop

            End Using

            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Zistenie typov prác", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Public Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_TypPrace.SelectedIndexChanged
        tb_CisloPrace.Text = ""
        cb_Priradene.Items.Clear()

        tb_CisloPrace.Text = Praca_Cislo("Cislo", ciselnik(1, 9, cb_TypPrace.Text)) + 1
        l_OznacPraca.Text = ciselnik(2, 9, cb_TypPrace.Text)

        'Vytiahnutie pracovnikov na danu pracu
        Dim QueryPrace As String
        QueryPrace =
        "SELECT CONCAT_WS(' ', uz.Priezvisko, uz.Meno) FROM uzivatel_x_prace uxp
        join uzivatelia uz on uxp.id_uzivatela = uz.id_uzivatela and zablokovany = 0
        where uxp.id_prace = '" & ciselnik(1, 9, cb_TypPrace.Text) & "' and uxp.id_uzivatela != '" & Ponuka.id_uzivatela & "' and uxp.stav = 0;"
        con.Open()
        Dim sqlPrace As MySqlCommand = New MySqlCommand(QueryPrace, con)
        Try
            Using odd As MySqlDataReader = sqlPrace.ExecuteReader()

                'Vytvorenie tabulky.
                Dim dtPrace As New DataTable("Prace")
                Dim ds2 As New DataSet()

                'Nacitanie dat
                dtPrace.Load(odd)

                'Pridanie dat do tabulky
                ds2.Tables.Add(dtPrace)

                Dim i As Integer = 0

                Do Until i = ds2.Tables(0).Rows.Count
                    cb_Priradene.Items.Add(ds2.Tables(0).Rows(i).Item(0))
                    i = i + 1
                Loop

            End Using

            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Zistenie pracovnika prace", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    Private Sub B_Priradit_Click(sender As Object, e As EventArgs) Handles B_Priradit.Click

        Dim QueryPriradenie As String
        QueryPriradenie = "INSERT INTO prace(Cislo_prace, Druh_prace, Popis_prace, Odovzdat_do, Prijate, Vlozil_meno, Vlozil_dna) VALUES ('" & tb_CisloPrace.Text & "', '" & ciselnik(1, 9, cb_TypPrace.Text) & "', '" & rtb_PopisPrace.Text & "', '" & uprava_datumu(dtp_SpracovatDo.Text) & "', now(), '" & Ponuka.Meno_uzivatela & "', now());"
        con.Open()
        Dim sqlPriradenie As MySqlCommand = New MySqlCommand(QueryPriradenie, con)
        Try
            sqlPriradenie.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Práca BOLA pridelená!", "ETECH - Pridelenie práce pracovníkovi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            logy(7, 1, "")
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "Pridelenie práce pracovníkovi", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        Dim QueryPracaUzivatel As String
        QueryPracaUzivatel = "INSERT INTO prace_x_uzivatel(id_prace, id_uzivatela, stav, Vlozil_meno, Vlozil_dna) VALUES ('" & Praca_Cislo("ID", 0) & "', '" & uzivatel(cb_Priradene.Text) & "', 0, '" & Ponuka.Meno_uzivatela & "', now());"
        con.Open()
        Dim sqlPracaUzivatel As MySqlCommand = New MySqlCommand(QueryPracaUzivatel, con)
        Try
            sqlPracaUzivatel.ExecuteNonQuery()
            con.Close()
            logy(15, 1, "")
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "Pridelenie práce pracovníkovi", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            logy(15, 2, ex.Message)
        End Try

        Dim QueryUloha As String
        QueryUloha = "INSERT INTO uloha_x_prace(id_uloha, id_prace, Vlozil_meno, Vlozil_dna) VALUES ('" & Ziadanky_sprava.id_ulohy & "','" & Praca_Cislo("ID", 0) & "', '" & Ponuka.Meno_uzivatela & "', now());"
        con.Open()
        Dim sqluloha As MySqlCommand = New MySqlCommand(QueryUloha, con)
        Try
            sqluloha.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "Prepojenie úholy s prácou", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        l_OznacPraca.Text = ""
        tb_CisloPrace.Text = ""
        cb_Priradene.Text = ""
        cb_TypPrace.Text = ""
        rtb_PopisPrace.Text = ""
        cb_Priradene.Items.Clear()
    End Sub

    Private Sub ll_PridatKPRaci_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_PridatKPRaci.LinkClicked
        Pridat_k_praci.Show()
    End Sub

    Private Sub cb_Priradene_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Priradene.Click
        cb_Priradene.Items.Clear()
        'Vytiahnutie pracovnikov na danu pracu
        Dim QueryPrace As String
        QueryPrace =
        "SELECT CONCAT_WS(' ', uz.Priezvisko, uz.Meno) FROM uzivatel_x_prace uxp
        join uzivatelia uz on uxp.id_uzivatela = uz.id_uzivatela and zablokovany = 0
        where uxp.id_prace = '" & ciselnik(1, 9, cb_TypPrace.Text) & "' and uxp.id_uzivatela != '" & Ponuka.id_uzivatela & "' and uxp.stav = 0;"
        con.Open()
        Dim sqlPrace As MySqlCommand = New MySqlCommand(QueryPrace, con)
        Try
            Using odd As MySqlDataReader = sqlPrace.ExecuteReader()

                'Vytvorenie tabulky.
                Dim dtPrace As New DataTable("Prace")
                Dim ds2 As New DataSet()

                'Nacitanie dat
                dtPrace.Load(odd)

                'Pridanie dat do tabulky
                ds2.Tables.Add(dtPrace)

                Dim i As Integer = 0

                Do Until i = ds2.Tables(0).Rows.Count
                    cb_Priradene.Items.Add(ds2.Tables(0).Rows(i).Item(0))
                    i = i + 1
                Loop

            End Using

            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Zistenie pracovnika prace", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
End Class