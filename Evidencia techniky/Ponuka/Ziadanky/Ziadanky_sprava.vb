Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie

Public Class Ziadanky_sprava
    Public Shared id_ulohy
    Public Shared PUlohaCislo As String
    Dim PNahlaseneDna As String
    Dim PUrgencia As String
    Dim PTypPoziadavky As String
    Dim PTypPrace As String
    Dim PTypUlohy As String
    Dim PStavUlohy As String
    Dim PNazovOddelenia As String
    Dim PMiestnost As String
    Dim PPopisUlohy As String
    Dim PZadavatel As String

    Public Sub Ziadanky_sprava_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, UCase(Ponuka.Meno_uzivatela))

        Dim PZiadankySprava As String = ""
        con.Open()
        Dim sqlPrava As String = "SELECT ZiadankySprava FROM prava WHERE id_uzivatela = '" & Ponuka.id_uzivatela & "'"
        Dim dataPrava As MySqlDataReader
        Dim adapterPrava As New MySqlDataAdapter
        Dim commandPrava As New MySqlCommand
        commandPrava.CommandText = sqlPrava
        commandPrava.Connection = con
        adapterPrava.SelectCommand = commandPrava
        dataPrava = commandPrava.ExecuteReader
        If dataPrava.HasRows Then
            While dataPrava.Read()
                PZiadankySprava = dataPrava("ZiadankySprava").ToString()
            End While
            dataPrava.Close()
            con.Close()
        End If

        If PZiadankySprava = 1 Then
            cb_TypUlohy.Enabled = True
            cb_StavUlohy.Enabled = True
            b_Pridat.Visible = True
            b_Material.Visible = True
            b_Hodiny.Visible = True
            ll_PridatOdd.Visible = True
            l_Vymazat.Visible = True
        End If

        con.Open()
        Dim sqlquery As String =
        "SELECT u.id_ulohy, u.Uloha_cislo, date_format(u.Nahlasene_dna, GET_FORMAT(DATE,'EUR')) as 'Nasladene dna', u.Urgencia, cd1.Nazov_hodnoty as Typ_poziadavky, cd2.Nazov_hodnoty as Typ_prace, cd3.Nazov_hodnoty as Typ_ulohy, cd4.Nazov_hodnoty as Stav_ulohy, odd.Nazov_oddelenia, u.Miestnost, u.Popis_ulohy, CONCAT_WS(' ', uz.meno, uz.Priezvisko) as 'Zadavatel', uz.Telefon
        FROM uloha u
        join ciselnik_data cd1 on u.typ_poziadavky = cd1.Hodnota and cd1.idciselnik = 8 and cd1.stav = 0
        join ciselnik_data cd2 on u.typ_prace = cd2.Hodnota and cd2.idciselnik = 9 and cd2.stav = 0
        join ciselnik_data cd3 on u.typ_ulohy = cd3.Hodnota and cd3.idciselnik = 10 and cd3.stav = 0
        join ciselnik_data cd4 on u.stav_ulohy = cd4.Hodnota and cd4.idciselnik = 11 and cd4.stav = 0
        join uzivatelia uz on u.Nahlasil_ID_zamestanca = uz.id_uzivatela
        join oddelenia odd on u.oddelenie = odd.id_oddelenia and odd.stav = 0
        WHERE u.Uloha_cislo = '" & Ziadanky_zoznam.Poziadavka_cislo & "' and u.stav = 0"
        Dim data As MySqlDataReader
        Dim adapter As New MySqlDataAdapter
        Dim command As New MySqlCommand
        command.CommandText = sqlquery
        command.Connection = con
        adapter.SelectCommand = command
        data = command.ExecuteReader
        Try
            If data.HasRows Then
                While data.Read()
                    id_ulohy = data("id_ulohy").ToString
                    PUlohaCislo = data("Uloha_cislo").ToString
                    PNahlaseneDna = data("Nasladene dna").ToString
                    PUrgencia = data("Urgencia").ToString
                    PTypPoziadavky = data("Typ_poziadavky").ToString
                    PTypPrace = data("Typ_prace").ToString
                    PTypUlohy = data("Typ_ulohy").ToString
                    PStavUlohy = data("Stav_ulohy").ToString
                    PNazovOddelenia = data("Nazov_oddelenia").ToString
                    PMiestnost = data("Miestnost").ToString
                    PPopisUlohy = data("Popis_ulohy").ToString
                    PZadavatel = data("Zadavatel").ToString + " " + data("Telefon").ToString

                    l_PUlohaCislo.Text = PUlohaCislo
                    l_NahlaseneDna.Text = PNahlaseneDna
                    cb_TypPoziadavky.Text = PTypPoziadavky
                    cb_TypPrace.Text = PTypPrace
                    cb_TypUlohy.Text = PTypUlohy
                    cb_StavUlohy.Text = PStavUlohy
                    cb_ZOddelenia.Text = PNazovOddelenia
                    tb_Miestnost.Text = PMiestnost
                    rtb_PopisPoziadavky.Text = PPopisUlohy
                    l_PZadavatel.Text = PZadavatel


                    If PUrgencia = 1 Then
                        chb_Urgencia.Checked = True
                    Else
                        chb_Urgencia.Checked = False
                    End If

                End While
                data.Close()
            End If
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Vytiahnutie údajov ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        'Vytiahnutie udajov z ciselnika -- TYP POZIADAVKY
        Dim QueryPoziadavky As String
        QueryPoziadavky =
        "SELECT cd.Nazov_hodnoty FROM uloha_x_uzivatel uxu
        join ciselnik_data cd on uxu.hodnota = cd.hodnota and uxu.idciselnik = cd.idciselnik and cd.stav = 0
        where uxu.id_uzivatela = '" & Ponuka.id_uzivatela & "' and uxu.idciselnik = 8 and uxu.stav = 0;"
        con.Open()
        Dim sqlPoziadavky As MySqlCommand = New MySqlCommand(QueryPoziadavky, con)
        Try
            Using odd As MySqlDataReader = sqlPoziadavky.ExecuteReader()

                'Vytvorenie tabulky.
                Dim dtPoziadavky As New DataTable("Poziadavky")
                Dim ds1 As New DataSet()

                'Nacitanie dat
                dtPoziadavky.Load(odd)

                'Pridanie dat do tabulky
                ds1.Tables.Add(dtPoziadavky)

                Dim i As Integer = 0

                Do Until i = ds1.Tables(0).Rows.Count
                    cb_TypPoziadavky.Items.Add(ds1.Tables(0).Rows(i).Item(0))
                    i = i + 1
                Loop

            End Using
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Zistenie typov požiadaviek", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try


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

        'Vytiahnutie udajov z ciselnika -- TYP ÚLOHY
        Dim QueryTypyUloh As String
        QueryTypyUloh =
        "SELECT cd.Nazov_hodnoty FROM uloha_x_uzivatel uxu
        join ciselnik_data cd on uxu.hodnota = cd.hodnota and uxu.idciselnik = cd.idciselnik and cd.stav = 0
        where uxu.id_uzivatela = '" & Ponuka.id_uzivatela & "' and uxu.idciselnik = 10 and uxu.stav = 0;"
        con.Open()
        Dim sqlTypyUloh As MySqlCommand = New MySqlCommand(QueryTypyUloh, con)
        Try
            Using odd As MySqlDataReader = sqlTypyUloh.ExecuteReader()

                'Vytvorenie tabulky.
                Dim dtTypyUloh As New DataTable("TypyUloh")
                Dim ds3 As New DataSet()

                'Nacitanie dat
                dtTypyUloh.Load(odd)

                'Pridanie dat do tabulky
                ds3.Tables.Add(dtTypyUloh)

                Dim i As Integer = 0

                Do Until i = ds3.Tables(0).Rows.Count
                    cb_TypUlohy.Items.Add(ds3.Tables(0).Rows(i).Item(0))
                    i = i + 1
                Loop

            End Using
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Zistenie typov úloh", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        'Vytiahnutie udajov z ciselnika -- STAV ULOHY
        Dim QueryStavUloh As String
        QueryStavUloh =
        "SELECT cd.Nazov_hodnoty FROM uloha_x_uzivatel uxu
        join ciselnik_data cd on uxu.hodnota = cd.hodnota and uxu.idciselnik = cd.idciselnik and cd.stav = 0
        where uxu.id_uzivatela = '" & Ponuka.id_uzivatela & "' and uxu.idciselnik = 11 and uxu.stav = 0;"
        con.Open()
        Dim sqlStavUloh As MySqlCommand = New MySqlCommand(QueryStavUloh, con)
        Try
            Using odd As MySqlDataReader = sqlStavUloh.ExecuteReader()

                'Vytvorenie tabulky.
                Dim dtStavUloh As New DataTable("StavUloh")
                Dim ds4 As New DataSet()

                'Nacitanie dat
                dtStavUloh.Load(odd)

                'Pridanie dat do tabulky
                ds4.Tables.Add(dtStavUloh)

                Dim i As Integer = 0

                Do Until i = ds4.Tables(0).Rows.Count
                    cb_StavUlohy.Items.Add(ds4.Tables(0).Rows(i).Item(0))
                    i = i + 1
                Loop

            End Using
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Zistenie stavov úloh", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        Dim QueryOddelenia As String
        QueryOddelenia =
        "SELECT odd.Nazov_oddelenia FROM uzivatelia u 
        join uzivatel_x_oddelenie uxo on u.id_uzivatela = uxo.id_uzivatela and uxo.stav = 0
        join oddelenia odd on uxo.id_oddelenia = odd.id_oddelenia and odd.stav = 0
        where u.id_uzivatela = '" & Ponuka.id_uzivatela & "';"
        con.Open()
        Dim sqlOddelenia As MySqlCommand = New MySqlCommand(QueryOddelenia, con)
        Try
            Using odd As MySqlDataReader = sqlOddelenia.ExecuteReader()

                'Vytvorenie tabulky.
                Dim dtOddelenia As New DataTable("Oddelenia")
                Dim ds2 As New DataSet()

                'Nacitanie dat
                dtOddelenia.Load(odd)

                'Pridanie dat do tabulky
                ds2.Tables.Add(dtOddelenia)

                Dim i As Integer = 0

                Do Until i = ds2.Tables(0).Rows.Count
                    cb_ZOddelenia.Items.Add(ds2.Tables(0).Rows(i).Item(0))
                    i = i + 1
                Loop

            End Using

            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Zoznam oddelení ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub b_Pridat_Click(sender As Object, e As EventArgs) Handles b_Pridat.Click
        Prace_zadanie.Show()
    End Sub

    Private Sub b_Ulozit_Click(sender As Object, e As EventArgs) Handles b_Ulozit.Click

        Dim Urgencia As String = ""

        If chb_Urgencia.Checked = True Then
            Urgencia = 1
        ElseIf chb_Urgencia.Checked = False Then
            Urgencia = 0
        End If

        Dim QueryUloha As String
        QueryUloha = "UPDATE uloha SET Typ_poziadavky = (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 8 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_TypPoziadavky.Text & "'), Typ_prace = (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 9 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_TypPrace.Text & "'), Popis_ulohy = '" & rtb_PopisPoziadavky.Text & "', Oddelenie = (SELECT id_oddelenia FROM oddelenia WHERE Nazov_oddelenia = '" & cb_ZOddelenia.Text & "' and stav = 0), Miestnost = '" & tb_Miestnost.Text & "', Typ_ulohy = (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 10 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_TypUlohy.Text & "'), Stav_ulohy = (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 11 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_StavUlohy.Text & "'), Urgencia = '" & Urgencia & "', Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() WHERE Uloha_cislo = '" & l_PUlohaCislo.Text & "';"
        con.Open()
        Dim sqlUloha As MySqlCommand = New MySqlCommand(QueryUloha, con)
        Try
            sqlUloha.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Údaje BOLI upravené!", "ETECH - Zmena údajov v žiadanke", MessageBoxButtons.OK, MessageBoxIcon.Information)
            logy(10, 1, "")
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "Zmena údajov v žiadanke", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            logy(10, 2, ex.Message)
        End Try

    End Sub


    Private Sub cb_TypUlohy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_TypUlohy.SelectedIndexChanged
        If cb_TypUlohy.Text = "Investícia" Then
            VstupneDataTextBox.Show()
        End If
    End Sub

    Private Sub cb_StavUlohy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_StavUlohy.SelectedIndexChanged
        If cb_StavUlohy.Text = "Vrátená - zadávateľovi" Or cb_StavUlohy.Text = "Odložené" Then
            VstupneDataTextBox.Show()
        End If
    End Sub

    Private Sub b_Tlac_Click(sender As Object, e As EventArgs) Handles b_Tlac.Click
        Dim Path = "\\10.10.0.20\etech\doc\Ziadanka.xlsm"
        System.Diagnostics.Process.Start(Path)
    End Sub

    Private Sub ll_PridatOdd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_PridatOdd.LinkClicked
        Pridat_oddelenie.Show()
    End Sub

    Public Sub cb_ZOddelenia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_ZOddelenia.Click
        cb_ZOddelenia.Items.Clear()

        'Vytiahnutie pracovnikov na danu pracu
        Dim QueryOddelenia As String
        QueryOddelenia =
        "SELECT odd.Nazov_oddelenia FROM uzivatelia u 
        join uzivatel_x_oddelenie uxo on u.id_uzivatela = uxo.id_uzivatela and uxo.stav = 0
        join oddelenia odd on uxo.id_oddelenia = odd.id_oddelenia and odd.stav = 0
        where u.id_uzivatela = '" & Ponuka.id_uzivatela & "';"
        con.Open()
        Dim sqlOddelenia As MySqlCommand = New MySqlCommand(QueryOddelenia, con)
        Try
            Using odd As MySqlDataReader = sqlOddelenia.ExecuteReader()

                'Vytvorenie tabulky.
                Dim dtOddelenia As New DataTable("Oddelenia")
                Dim ds2 As New DataSet()

                'Nacitanie dat
                dtOddelenia.Load(odd)

                'Pridanie dat do tabulky
                ds2.Tables.Add(dtOddelenia)

                Dim i As Integer = 0

                Do Until i = ds2.Tables(0).Rows.Count
                    cb_ZOddelenia.Items.Add(ds2.Tables(0).Rows(i).Item(0))
                    i = i + 1
                Loop

            End Using

            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Zoznam oddelení ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub l_Vymazat_Click(sender As Object, e As EventArgs) Handles l_Vymazat.Click
        Dim QueryMazanie As String
        QueryMazanie = "UPDATE uloha SET stav = 1, Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() WHERE Uloha_cislo = '" & l_PUlohaCislo.Text & "';"
        con.Open()
        Dim sqlMazanie As MySqlCommand = New MySqlCommand(QueryMazanie, con)
        Try
            sqlMazanie.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Žiadanka bola vymazaná!", "ETECH - Vymazanie žiadanky", MessageBoxButtons.OK, MessageBoxIcon.Information)
            logy(14, 1, "")
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Vymazanie žiadanky", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            logy(14, 2, ex.Message)
        End Try
    End Sub

    Private Sub b_Hodiny_Click(sender As Object, e As EventArgs) Handles b_Hodiny.Click
        Vykaz_hodin.Show()
    End Sub
End Class
