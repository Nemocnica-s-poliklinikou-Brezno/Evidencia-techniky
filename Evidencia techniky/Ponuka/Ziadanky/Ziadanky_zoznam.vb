Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.Ponuka
Imports Evidencia_techniky.pripojenie

Public Class Ziadanky_zoznam
    Public Shared Poziadavka_cislo As String

    Private Sub Ziadanky_sprava_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)
        b_NacitatData_Click(sender, e)
    End Sub
    Public Sub b_NacitatData_Click(sender As Object, e As EventArgs) Handles b_NacitatData.Click
        ProgressBar1.Maximum = 0
        Spracovanie_dat.Show()

        'Načítanie počtu žiadanie do hlavičky záložky
        tp_Nove.Text = "Nové ( " & Pocet_uloha(0, 0) & " )"
        tp_Rozpracovane.Text = "Rozpracovane ( " & Pocet_uloha(0, 1) & " )"
        tp_Odlozene.Text = "Odlozene ( " & Pocet_uloha(0, 2) & " )"
        tp_VrateneZadavatelovi.Text = "Vrátené zadávateľovi ( " & Pocet_uloha(0, 3) & " )"
        tp_VrateneUdrzbe.Text = "Vrátené údržbe ( " & Pocet_uloha(0, 4) & " )"
        tp_VeduciUkoncenie.Text = "Vedúci ukončenie ( " & Pocet_uloha(0, 7) & " )"
        tp_UkoncenieZadavatelom.Text = "Ukončenie zadávateľom ( " & Pocet_uloha(0, 5) & " )"
        tp_UkonceneUdrzba.Text = "Ukončené ( " & Pocet_uloha(0, 6) & " )"
        tp_Investicie.Text = "Investície ( " & Pocet_uloha(1, 0) & " )"
        tp_Mesacna.Text = "Mesačná ( " & Pocet_uloha(2, 0) & " )"
        tp_MesacnaUkoncena.Text = "Mesačná ukončená ( " & Pocet_uloha(2, 6) & " )"
        tp_Pohotovost.Text = "Pohotovosť ( " & Pocet_uloha(3, 0) & " )"
        tp_PohotovostUkoncena.Text = "Pohotovosť ukončená ( " & Pocet_uloha(3, 6) & " )"

        If Ponuka.ZiadankySprava < 2 Then
            tb_Ziadanky.TabPages.Remove(tp_VeduciUkoncenie)
            tb_Ziadanky.TabPages.Remove(tp_Mesacna)
            tb_Ziadanky.TabPages.Remove(tp_MesacnaUkoncena)
            tb_Ziadanky.TabPages.Remove(tp_Pohotovost)
            tb_Ziadanky.TabPages.Remove(tp_PohotovostUkoncena)
        End If

        'Vyčistenie vyslednej tabuliek
        dgv_Nove.Rows.Clear()
        dgv_Rozpracovane.Rows.Clear()
        dgv_Odlozene.Rows.Clear()
        dgv_VrateneZadavatelovi.Rows.Clear()
        dgv_VrateneUdrzbe.Rows.Clear()
        dgv_VeduciUkoncenie.Rows.Clear()
        dgv_UkoncenieZadavatelom.Rows.Clear()
        dgv_UkonceneUdrzba.Rows.Clear()
        dgv_Investicie.Rows.Clear()
        dgv_Mesacna.Rows.Clear()
        dgv_MesacnaUkoncena.Rows.Clear()
        dgv_Pohotovost.Rows.Clear()
        dgv_PohotovostUkoncena.Rows.Clear()

        'Data pre naplnenie tabulky NOVE
        Using cmd As New MySqlCommand("Select
                Uloha_cislo as 'Žiadanka číslo',
                cd_poziadavka.Nazov_hodnoty as 'Typ požiadavky', 
	            cd_prace.Nazov_hodnoty as 'Typ práce', 
	            date_format(u.Nahlasene_dna, GET_FORMAT(DATE,'EUR')) as 'Dátum', 
                case 
	            when Urgencia = 0 then 'Nie' 
	            Else 'Áno' 
                        End As 'Urgencia', 
	            CONCAT_WS(' - ', oddelenia.Nazov_oddelenia, u.Cast) as 'Oddelenie',
	            CONCAT_WS(' ', uzivatelia.meno, uzivatelia.Priezvisko) as 'Zadávateľ' 
            From uloha u
            left join ciselnik_data cd_poziadavka on u.Typ_poziadavky = cd_poziadavka.Hodnota And cd_poziadavka.idciselnik = 8 and cd_poziadavka.stav in (0, 1)
            left join ciselnik_data cd_prace on u.Typ_prace = cd_prace.Hodnota And cd_prace.idciselnik = 9 and cd_prace.stav in (0, 1)
            left join oddelenia On u.oddelenie = oddelenia.id_oddelenia and oddelenia.stav in (0, 1)
            left join uzivatelia On u.Nahlasil_ID_zamestanca = uzivatelia.id_uzivatela
            WHERE
            Typ_ulohy = 0 and Stav_ulohy = 0 and u.stav = 0 and (u.Nahlasil_ID_zamestanca = '" & Ponuka.id_uzivatela & "' or '" & Ponuka.ZiadankySprava & "' = 4)
            ;")
            cmd.Connection = con
            cmd.CommandTimeout = 1200
            con.Open()
            Using sdr As MySqlDataReader = cmd.ExecuteReader()

                'Vytvorenie tabulky
                Dim dtCustomers As New DataTable("Poziadavky")
                Dim ds As New DataSet()

                'Nacitanie dat
                dtCustomers.Load(sdr)

                'Pridanie dat do tabulky
                ds.Tables.Add(dtCustomers)

                dgv_Nove.ColumnCount = 7
                dgv_Nove.Columns(0).Name = "Požiadavka číslo"
                dgv_Nove.Columns(1).Name = "Typ požiadavky"
                dgv_Nove.Columns(2).Name = "Typ práce"
                dgv_Nove.Columns(3).Name = "Dátum"
                dgv_Nove.Columns(4).Name = "Urgencia"
                dgv_Nove.Columns(5).Name = "Oddelenie"
                dgv_Nove.Columns(6).Name = "Zadávateľ"

                ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                ProgressBar1.Value = ProgressBar1.Value + 1

                Dim i As Integer = 0

                Do Until i = ds.Tables(0).Rows.Count
                    dgv_Nove.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString, ds.Tables(0).Rows(i).Item(6).ToString)
                    ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    i = i + 1
                Loop
            End Using
            Spracovanie_dat.Close()
            con.Close()

            'Zvyraznenie riadku pri splneni podmienky
            For i = 0 To dgv_Nove.Rows.Count - 1
                If dgv_Nove.Rows(i).Cells("Urgencia").Value = "Áno" Then
                    dgv_Nove.Rows(i).DefaultCellStyle.BackColor = Color.LightSkyBlue
                End If
            Next

        End Using
        con.Close()

        'Data pre naplnenie tabulky ROZPRACOVANE
        Using cmd As New MySqlCommand("Select
	            Uloha_cislo as 'Žiadanka číslo',
                cd_poziadavka.Nazov_hodnoty as 'Typ požiadavky', 
	            cd_prace.Nazov_hodnoty as 'Typ práce', 
	            date_format(u.Nahlasene_dna, GET_FORMAT(DATE,'EUR')) as 'Dátum', 
                case 
	            when Urgencia = 0 then 'Nie' 
	            Else 'Áno' 
                        End As 'Urgencia', 
	            CONCAT_WS(' - ', oddelenia.Nazov_oddelenia, u.Cast) as 'Oddelenie',
	            CONCAT_WS(' ', uzivatelia.meno, uzivatelia.Priezvisko) as 'Zadávateľ',
                '|' as '|',
                CONCAT_WS('', cd_prace.Popis, p.Cislo_prace) as 'Číslo práce',
				date_format(p.Prijate, GET_FORMAT(DATE,'EUR')) as 'Zadané', 
                CONCAT_WS(' ', up.meno, up.Priezvisko) as 'Priradené'
            From uloha u
            left join uloha_x_prace uxp on u.id_ulohy = uxp.id_uloha and uxp.stav = 0
            left join prace p on uxp.id_prace = p.id_prace and p.stav in (0, 1)
            left join prace_x_uzivatel pxu on p.id_prace = pxu.id_prace and pxu.stav in (0, 1)
            left join ciselnik_data cd_poziadavka on u.Typ_poziadavky = cd_poziadavka.Hodnota And cd_poziadavka.idciselnik = 8 and cd_poziadavka.stav in (0, 1)
            left join ciselnik_data cd_prace on u.Typ_prace = cd_prace.Hodnota And cd_prace.idciselnik = 9 and cd_prace.stav in (0, 1)
            left join oddelenia On u.oddelenie = oddelenia.id_oddelenia and oddelenia.stav = 0 and oddelenia.stav in (0, 1)
            left join uzivatelia up on pxu.id_uzivatela = up.id_uzivatela
            left join uzivatelia On u.Nahlasil_ID_zamestanca = uzivatelia.id_uzivatela
            WHERE
            Typ_ulohy = 0 and Stav_ulohy = 1 and u.stav = 0 and (pxu.id_uzivatela = '" & Ponuka.id_uzivatela & "' or u.Nahlasil_ID_zamestanca = '" & Ponuka.id_uzivatela & "' or '" & Ponuka.ZiadankySprava & "' = 4)
            order by 11 desc
            ;")
            cmd.Connection = con
            cmd.CommandTimeout = 1200
            con.Open()
            Using sdr As MySqlDataReader = cmd.ExecuteReader()

                'Vytvorenie tabulky
                Dim dtCustomers As New DataTable("Poziadavky")
                Dim ds As New DataSet()

                'Nacitanie dat
                dtCustomers.Load(sdr)

                'Pridanie dat do tabulky
                ds.Tables.Add(dtCustomers)

                dgv_Rozpracovane.ColumnCount = 11
                dgv_Rozpracovane.Columns(0).Name = "Požiadavka číslo"
                dgv_Rozpracovane.Columns(1).Name = "Typ požiadavky"
                dgv_Rozpracovane.Columns(2).Name = "Typ práce"
                dgv_Rozpracovane.Columns(3).Name = "Dátum"
                dgv_Rozpracovane.Columns(4).Name = "Urgencia"
                dgv_Rozpracovane.Columns(5).Name = "Oddelenie"
                dgv_Rozpracovane.Columns(6).Name = "Zadávateľ"
                dgv_Rozpracovane.Columns(7).Name = "|"
                dgv_Rozpracovane.Columns(8).Name = "Číslo práce"
                dgv_Rozpracovane.Columns(9).Name = "Zadané"
                dgv_Rozpracovane.Columns(10).Name = "Priradené"

                ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                ProgressBar1.Value = ProgressBar1.Value + 1

                Dim i As Integer = 0

                Do Until i = ds.Tables(0).Rows.Count
                    dgv_Rozpracovane.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString, ds.Tables(0).Rows(i).Item(6).ToString, ds.Tables(0).Rows(i).Item(7).ToString, ds.Tables(0).Rows(i).Item(8).ToString, ds.Tables(0).Rows(i).Item(9).ToString, ds.Tables(0).Rows(i).Item(10).ToString)
                    ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    i = i + 1
                Loop

            End Using
            Spracovanie_dat.Close()
            con.Close()

            'Zvyraznenie riadku pri splneni podmienky
            For i = 0 To dgv_Rozpracovane.Rows.Count - 1
                If dgv_Rozpracovane.Rows(i).Cells("Urgencia").Value = "Áno" Then
                    dgv_Rozpracovane.Rows(i).DefaultCellStyle.BackColor = Color.LightSkyBlue
                End If
            Next

        End Using
        con.Close()

        'Data pre naplnenie tabulky ODLOZENE
        Using cmd As New MySqlCommand("Select
	            Uloha_cislo as 'Žiadanka číslo',
                cd_poziadavka.Nazov_hodnoty as 'Typ požiadavky', 
	            cd_prace.Nazov_hodnoty as 'Typ práce', 
	            date_format(u.Nahlasene_dna, GET_FORMAT(DATE,'EUR')) as 'Dátum', 
                case 
	            when Urgencia = 0 then 'Nie' 
	            Else 'Áno' 
                        End As 'Urgencia', 
	            CONCAT_WS(' - ', oddelenia.Nazov_oddelenia, u.Cast) as 'Oddelenie',
	            CONCAT_WS(' ', uzivatelia.meno, uzivatelia.Priezvisko) as 'Zadávateľ',
                (select dovod_stav from uloha_x_stav uxs where u.id_ulohy = uxs.id_ulohy and stav = 0 order by 1 desc limit 1) as 'Stav'
            From uloha u
            left join uloha_x_prace uxp on u.id_ulohy = uxp.id_uloha and uxp.stav = 0
            left join prace p on uxp.id_prace = p.id_prace and p.stav in (0, 1)
            left join prace_x_uzivatel pxu on p.id_prace = pxu.id_prace and pxu.stav in (0, 1)
            left join ciselnik_data cd_poziadavka on u.Typ_poziadavky = cd_poziadavka.Hodnota And cd_poziadavka.idciselnik = 8 and cd_poziadavka.stav in (0, 1)
            left join ciselnik_data cd_prace on u.Typ_prace = cd_prace.Hodnota And cd_prace.idciselnik = 9 and cd_prace.stav in (0, 1)
            left join oddelenia On u.oddelenie = oddelenia.id_oddelenia and oddelenia.stav in (0, 1)
            left join uzivatelia On u.Nahlasil_ID_zamestanca = uzivatelia.id_uzivatela
            WHERE
            Typ_ulohy = 0 and Stav_ulohy = 2 and u.stav = 0 and (pxu.id_uzivatela = '" & Ponuka.id_uzivatela & "' or u.Nahlasil_ID_zamestanca = '" & Ponuka.id_uzivatela & "' or '" & Ponuka.ZiadankySprava & "' = 4)
            ;")
            cmd.Connection = con
            cmd.CommandTimeout = 1200
            con.Open()
            Using sdr As MySqlDataReader = cmd.ExecuteReader()

                'Vytvorenie tabulky
                Dim dtCustomers As New DataTable("Poziadavky")
                Dim ds As New DataSet()

                'Nacitanie dat
                dtCustomers.Load(sdr)

                'Pridanie dat do tabulky
                ds.Tables.Add(dtCustomers)

                dgv_Odlozene.ColumnCount = 8
                dgv_Odlozene.Columns(0).Name = "Požiadavka číslo"
                dgv_Odlozene.Columns(1).Name = "Typ požiadavky"
                dgv_Odlozene.Columns(2).Name = "Typ práce"
                dgv_Odlozene.Columns(3).Name = "Dátum"
                dgv_Odlozene.Columns(4).Name = "Urgencia"
                dgv_Odlozene.Columns(5).Name = "Oddelenie"
                dgv_Odlozene.Columns(6).Name = "Zadávateľ"
                dgv_Odlozene.Columns(7).Name = "Stav"

                ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                ProgressBar1.Value = ProgressBar1.Value + 1

                Dim i As Integer = 0

                Do Until i = ds.Tables(0).Rows.Count
                    dgv_Odlozene.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString, ds.Tables(0).Rows(i).Item(6).ToString, ds.Tables(0).Rows(i).Item(7).ToString)
                    ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    i = i + 1
                Loop

            End Using
            Spracovanie_dat.Close()
            con.Close()

            'Zvyraznenie riadku pri splneni podmienky
            For i = 0 To dgv_Odlozene.Rows.Count - 1
                If dgv_Odlozene.Rows(i).Cells("Urgencia").Value = "Áno" Then
                    dgv_Odlozene.Rows(i).DefaultCellStyle.BackColor = Color.LightSkyBlue
                End If
            Next

        End Using
        con.Close()

        'Data pre naplnenie tabulky VRATENA ZADAVATELA
        Using cmd As New MySqlCommand("Select
	            Uloha_cislo as 'Žiadanka číslo',
                cd_poziadavka.Nazov_hodnoty as 'Typ požiadavky', 
	            cd_prace.Nazov_hodnoty as 'Typ práce', 
	            date_format(u.Nahlasene_dna, GET_FORMAT(DATE,'EUR')) as 'Dátum', 
                case 
	            when Urgencia = 0 then 'Nie' 
	            Else 'Áno' 
                        End As 'Urgencia', 
	            CONCAT_WS(' - ', oddelenia.Nazov_oddelenia, u.Cast) as 'Oddelenie', 
	            CONCAT_WS(' ', uzivatelia.meno, uzivatelia.Priezvisko) as 'Zadávateľ',
                (select dovod_stav from uloha_x_stav uxs where u.id_ulohy = uxs.id_ulohy and stav = 0 order by 1 desc limit 1) as 'Dôvod vrátenia'
            From uloha u
            left join uloha_x_prace uxp on u.id_ulohy = uxp.id_uloha and uxp.stav = 0
            left join prace p on uxp.id_prace = p.id_prace and p.stav in (0, 1)
            left join prace_x_uzivatel pxu on p.id_prace = pxu.id_prace and pxu.stav in (0, 1)
            left join ciselnik_data cd_poziadavka on u.Typ_poziadavky = cd_poziadavka.Hodnota And cd_poziadavka.idciselnik = 8 and cd_poziadavka.stav in (0, 1)
            left join ciselnik_data cd_prace on u.Typ_prace = cd_prace.Hodnota And cd_prace.idciselnik = 9 and cd_prace.stav in (0, 1)
            left join oddelenia On u.oddelenie = oddelenia.id_oddelenia and oddelenia.stav in (0, 1)
            left join uzivatelia On u.Nahlasil_ID_zamestanca = uzivatelia.id_uzivatela
            WHERE
            Typ_ulohy = 0 and u.Stav_ulohy = 3 and u.stav = 0 and (pxu.id_uzivatela = '" & Ponuka.id_uzivatela & "' or u.Nahlasil_ID_zamestanca = '" & Ponuka.id_uzivatela & "' or '" & Ponuka.ZiadankySprava & "' = 4)
            ;")
            cmd.Connection = con
            cmd.CommandTimeout = 1200
            con.Open()
            Using sdr As MySqlDataReader = cmd.ExecuteReader()

                'Vytvorenie tabulky
                Dim dtCustomers As New DataTable("Poziadavky")
                Dim ds As New DataSet()

                'Nacitanie dat
                dtCustomers.Load(sdr)

                'Pridanie dat do tabulky
                ds.Tables.Add(dtCustomers)

                dgv_VrateneZadavatelovi.ColumnCount = 8
                dgv_VrateneZadavatelovi.Columns(0).Name = "Požiadavka číslo"
                dgv_VrateneZadavatelovi.Columns(1).Name = "Typ požiadavky"
                dgv_VrateneZadavatelovi.Columns(2).Name = "Typ práce"
                dgv_VrateneZadavatelovi.Columns(3).Name = "Dátum"
                dgv_VrateneZadavatelovi.Columns(4).Name = "Urgencia"
                dgv_VrateneZadavatelovi.Columns(5).Name = "Oddelenie"
                dgv_VrateneZadavatelovi.Columns(6).Name = "Zadávateľ"
                dgv_VrateneZadavatelovi.Columns(7).Name = "Dôvod vrátenia"

                ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                ProgressBar1.Value = ProgressBar1.Value + 1

                Dim i As Integer = 0

                Do Until i = ds.Tables(0).Rows.Count
                    dgv_VrateneZadavatelovi.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString, ds.Tables(0).Rows(i).Item(6).ToString, ds.Tables(0).Rows(i).Item(7).ToString)
                    ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    i = i + 1
                Loop

            End Using
            Spracovanie_dat.Close()
            con.Close()

            'Zvyraznenie riadku pri splneni podmienky
            For i = 0 To dgv_VrateneZadavatelovi.Rows.Count - 1
                If dgv_VrateneZadavatelovi.Rows(i).Cells("Urgencia").Value = "Áno" Then
                    dgv_VrateneZadavatelovi.Rows(i).DefaultCellStyle.BackColor = Color.LightSkyBlue
                End If
            Next

        End Using
        con.Close()

        'Data pre naplnenie tabulky VRATENE UDRZBA
        Using cmd As New MySqlCommand("Select
	            Uloha_cislo as 'Žiadanka číslo',
                cd_poziadavka.Nazov_hodnoty as 'Typ požiadavky', 
	            cd_prace.Nazov_hodnoty as 'Typ práce', 
	            date_format(u.Nahlasene_dna, GET_FORMAT(DATE,'EUR')) as 'Dátum', 
                case 
	            when Urgencia = 0 then 'Nie' 
	            Else 'Áno' 
                        End As 'Urgencia', 
	            CONCAT_WS(' - ', oddelenia.Nazov_oddelenia, u.Cast) as 'Oddelenie',
	            CONCAT_WS(' ', uzivatelia.meno, uzivatelia.Priezvisko) as 'Zadávateľ',
                (select dovod_stav from uloha_x_stav uxs where u.id_ulohy = uxs.id_ulohy and stav = 0 order by 1 desc limit 1) as 'Dôvod vrátenia'
            From uloha u
            left join uloha_x_prace uxp on u.id_ulohy = uxp.id_uloha and uxp.stav = 0
            left join prace p on uxp.id_prace = p.id_prace and p.stav in (0, 1)
            left join prace_x_uzivatel pxu on p.id_prace = pxu.id_prace and pxu.stav in (0, 1)
            left join ciselnik_data cd_poziadavka on u.Typ_poziadavky = cd_poziadavka.Hodnota And cd_poziadavka.idciselnik = 8 and cd_poziadavka.stav in (0, 1)
            left join ciselnik_data cd_prace on u.Typ_prace = cd_prace.Hodnota And cd_prace.idciselnik = 9 and cd_prace.stav in (0, 1)
            left join oddelenia On u.oddelenie = oddelenia.id_oddelenia and oddelenia.stav in (0, 1)
            left join uzivatelia On u.Nahlasil_ID_zamestanca = uzivatelia.id_uzivatela
            WHERE
            Typ_ulohy = 0 and Stav_ulohy = 4 and u.stav = 0 and (pxu.id_uzivatela = '" & Ponuka.id_uzivatela & "' or u.Nahlasil_ID_zamestanca = '" & Ponuka.id_uzivatela & "' or '" & Ponuka.ZiadankySprava & "' = 4)
            ;")
            cmd.Connection = con
            cmd.CommandTimeout = 1200
            con.Open()
            Using sdr As MySqlDataReader = cmd.ExecuteReader()

                'Vytvorenie tabulky
                Dim dtCustomers As New DataTable("Poziadavky")
                Dim ds As New DataSet()

                'Nacitanie dat
                dtCustomers.Load(sdr)

                'Pridanie dat do tabulky
                ds.Tables.Add(dtCustomers)

                dgv_VrateneUdrzbe.ColumnCount = 8
                dgv_VrateneUdrzbe.Columns(0).Name = "Požiadavka číslo"
                dgv_VrateneUdrzbe.Columns(1).Name = "Typ požiadavky"
                dgv_VrateneUdrzbe.Columns(2).Name = "Typ práce"
                dgv_VrateneUdrzbe.Columns(3).Name = "Dátum"
                dgv_VrateneUdrzbe.Columns(4).Name = "Urgencia"
                dgv_VrateneUdrzbe.Columns(5).Name = "Oddelenie"
                dgv_VrateneUdrzbe.Columns(6).Name = "Zadávateľ"
                dgv_VrateneUdrzbe.Columns(7).Name = "Dôvod vrátenia"

                ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                ProgressBar1.Value = ProgressBar1.Value + 1

                Dim i As Integer = 0

                Do Until i = ds.Tables(0).Rows.Count
                    dgv_VrateneUdrzbe.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString, ds.Tables(0).Rows(i).Item(6).ToString, ds.Tables(0).Rows(i).Item(7).ToString)
                    ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    i = i + 1
                Loop

            End Using
            Spracovanie_dat.Close()
            con.Close()

            'Zvyraznenie riadku pri splneni podmienky
            For i = 0 To dgv_VrateneUdrzbe.Rows.Count - 1
                If dgv_VrateneUdrzbe.Rows(i).Cells("Urgencia").Value = "Áno" Then
                    dgv_VrateneUdrzbe.Rows(i).DefaultCellStyle.BackColor = Color.LightSkyBlue
                End If
            Next

        End Using
        con.Close()

        'Data pre naplnenie tabulky VEDUCI UKONCENIE
        Using cmd As New MySqlCommand("Select
	            Uloha_cislo as 'Žiadanka číslo',
                cd_poziadavka.Nazov_hodnoty as 'Typ požiadavky', 
	            cd_prace.Nazov_hodnoty as 'Typ práce', 
	            date_format(u.Nahlasene_dna, GET_FORMAT(DATE,'EUR')) as 'Dátum', 
                case 
	            when Urgencia = 0 then 'Nie' 
	            Else 'Áno' 
                        End As 'Urgencia', 
	            CONCAT_WS(' - ', oddelenia.Nazov_oddelenia, u.Cast) as 'Oddelenie',
	            CONCAT_WS(' ', uzivatelia.meno, uzivatelia.Priezvisko) as 'Zadávateľ',
                (select dovod_stav from uloha_x_stav uxs where u.id_ulohy = uxs.id_ulohy and stav = 0 order by 1 desc limit 1) as 'Dôvod vrátenia'
            From uloha u
            left join uloha_x_prace uxp on u.id_ulohy = uxp.id_uloha and uxp.stav = 0
            left join prace p on uxp.id_prace = p.id_prace and p.stav in (0, 1)
            left join prace_x_uzivatel pxu on p.id_prace = pxu.id_prace and pxu.stav in (0, 1)
            left join ciselnik_data cd_poziadavka on u.Typ_poziadavky = cd_poziadavka.Hodnota And cd_poziadavka.idciselnik = 8 and cd_poziadavka.stav in (0, 1)
            left join ciselnik_data cd_prace on u.Typ_prace = cd_prace.Hodnota And cd_prace.idciselnik = 9 and cd_prace.stav in (0, 1)
            left join oddelenia On u.oddelenie = oddelenia.id_oddelenia and oddelenia.stav in (0, 1)
            left join uzivatelia On u.Nahlasil_ID_zamestanca = uzivatelia.id_uzivatela
            WHERE
            Typ_ulohy = 0 and Stav_ulohy = 4 and u.stav = 0 and (pxu.id_uzivatela = '" & Ponuka.id_uzivatela & "' or u.Nahlasil_ID_zamestanca = '" & Ponuka.id_uzivatela & "' or '" & Ponuka.ZiadankySprava & "' = 4)
            ;")
            cmd.Connection = con
            cmd.CommandTimeout = 1200
            con.Open()
            Using sdr As MySqlDataReader = cmd.ExecuteReader()

                'Vytvorenie tabulky
                Dim dtCustomers As New DataTable("Poziadavky")
                Dim ds As New DataSet()

                'Nacitanie dat
                dtCustomers.Load(sdr)

                'Pridanie dat do tabulky
                ds.Tables.Add(dtCustomers)

                dgv_VeduciUkoncenie.ColumnCount = 8
                dgv_VeduciUkoncenie.Columns(0).Name = "Požiadavka číslo"
                dgv_VeduciUkoncenie.Columns(1).Name = "Typ požiadavky"
                dgv_VeduciUkoncenie.Columns(2).Name = "Typ práce"
                dgv_VeduciUkoncenie.Columns(3).Name = "Dátum"
                dgv_VeduciUkoncenie.Columns(4).Name = "Urgencia"
                dgv_VeduciUkoncenie.Columns(5).Name = "Oddelenie"
                dgv_VeduciUkoncenie.Columns(6).Name = "Zadávateľ"
                dgv_VeduciUkoncenie.Columns(7).Name = "Dôvod vrátenia"

                ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                ProgressBar1.Value = ProgressBar1.Value + 1

                Dim i As Integer = 0

                Do Until i = ds.Tables(0).Rows.Count
                    dgv_VeduciUkoncenie.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString, ds.Tables(0).Rows(i).Item(6).ToString)
                    ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    i = i + 1
                Loop

            End Using
            Spracovanie_dat.Close()
            con.Close()

            'Zvyraznenie riadku pri splneni podmienky
            For i = 0 To dgv_VrateneUdrzbe.Rows.Count - 1
                If dgv_VeduciUkoncenie.Rows(i).Cells("Urgencia").Value = "Áno" Then
                    dgv_VeduciUkoncenie.Rows(i).DefaultCellStyle.BackColor = Color.LightSkyBlue
                End If
            Next

        End Using
        con.Close()

        'Data pre naplnenie tabulky UKONCENIE ZADAVATELOM
        Using cmd As New MySqlCommand("Select
	            Uloha_cislo as 'Žiadanka číslo',
                cd_poziadavka.Nazov_hodnoty as 'Typ požiadavky', 
	            cd_prace.Nazov_hodnoty as 'Typ práce', 
	            date_format(u.Nahlasene_dna, GET_FORMAT(DATE,'EUR')) as 'Dátum', 
                case 
	            when Urgencia = 0 then 'Nie' 
	            Else 'Áno' 
                        End As 'Urgencia', 
	            CONCAT_WS(' - ', oddelenia.Nazov_oddelenia, u.Cast) as 'Oddelenie',
	            CONCAT_WS(' ', uzivatelia.meno, uzivatelia.Priezvisko) as 'Zadávateľ' 
            From uloha u
            left join uloha_x_prace uxp on u.id_ulohy = uxp.id_uloha and uxp.stav = 0
            left join prace p on uxp.id_prace = p.id_prace and p.stav in (0, 1)
            left join prace_x_uzivatel pxu on p.id_prace = pxu.id_prace and pxu.stav in (0, 1)
            left join ciselnik_data cd_poziadavka on u.Typ_poziadavky = cd_poziadavka.Hodnota And cd_poziadavka.idciselnik = 8 and cd_poziadavka.stav in (0, 1)
            left join ciselnik_data cd_prace on u.Typ_prace = cd_prace.Hodnota And cd_prace.idciselnik = 9 and cd_prace.stav in (0, 1)
            left join oddelenia On u.oddelenie = oddelenia.id_oddelenia and oddelenia.stav in (0, 1)
            left join uzivatelia On u.Nahlasil_ID_zamestanca = uzivatelia.id_uzivatela
            WHERE
            Typ_ulohy = 0 and Stav_ulohy = 5 and u.stav = 0 and (pxu.id_uzivatela = '" & Ponuka.id_uzivatela & "' or u.Nahlasil_ID_zamestanca = '" & Ponuka.id_uzivatela & "' or '" & Ponuka.ZiadankySprava & "' = 4)
            ;")
            cmd.Connection = con
            cmd.CommandTimeout = 1200
            con.Open()
            Using sdr As MySqlDataReader = cmd.ExecuteReader()

                'Vytvorenie tabulky
                Dim dtCustomers As New DataTable("Poziadavky")
                Dim ds As New DataSet()

                'Nacitanie dat
                dtCustomers.Load(sdr)

                'Pridanie dat do tabulky
                ds.Tables.Add(dtCustomers)

                dgv_UkoncenieZadavatelom.ColumnCount = 7
                dgv_UkoncenieZadavatelom.Columns(0).Name = "Požiadavka číslo"
                dgv_UkoncenieZadavatelom.Columns(1).Name = "Typ požiadavky"
                dgv_UkoncenieZadavatelom.Columns(2).Name = "Typ práce"
                dgv_UkoncenieZadavatelom.Columns(3).Name = "Dátum"
                dgv_UkoncenieZadavatelom.Columns(4).Name = "Urgencia"
                dgv_UkoncenieZadavatelom.Columns(5).Name = "Oddelenie"
                dgv_UkoncenieZadavatelom.Columns(6).Name = "Zadávateľ"

                ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                ProgressBar1.Value = ProgressBar1.Value + 1

                Dim i As Integer = 0

                Do Until i = ds.Tables(0).Rows.Count
                    dgv_UkoncenieZadavatelom.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString, ds.Tables(0).Rows(i).Item(6).ToString)
                    ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    i = i + 1
                Loop

            End Using
            Spracovanie_dat.Close()
            con.Close()

            'Zvyraznenie riadku pri splneni podmienky
            For i = 0 To dgv_UkoncenieZadavatelom.Rows.Count - 1
                If dgv_UkoncenieZadavatelom.Rows(i).Cells("Urgencia").Value = "Áno" Then
                    dgv_UkoncenieZadavatelom.Rows(i).DefaultCellStyle.BackColor = Color.LightSkyBlue
                End If
            Next

        End Using
        con.Close()

        'Data pre naplnenie tabulky UKONCENE UDRZBA
        Using cmd As New MySqlCommand("Select
                Uloha_cislo as 'Žiadanka číslo',
                cd_poziadavka.Nazov_hodnoty as 'Typ požiadavky', 
	            cd_prace.Nazov_hodnoty as 'Typ práce', 
	            date_format(u.Nahlasene_dna, GET_FORMAT(DATE,'EUR')) as 'Dátum', 
                case 
	            when Urgencia = 0 then 'Nie' 
	            Else 'Áno' 
                        End As 'Urgencia', 
	            CONCAT_WS(' - ', oddelenia.Nazov_oddelenia, u.Cast) as 'Oddelenie',
	            CONCAT_WS(' ', uzivatelia.meno, uzivatelia.Priezvisko) as 'Zadávateľ' 
            From uloha u
            left join uloha_x_prace uxp on u.id_ulohy = uxp.id_uloha and uxp.stav = 0
            left join prace p on uxp.id_prace = p.id_prace and p.stav in (0, 1)
            left join prace_x_uzivatel pxu on p.id_prace = pxu.id_prace and pxu.stav in (0, 1)
            left join ciselnik_data cd_poziadavka on u.Typ_poziadavky = cd_poziadavka.Hodnota And cd_poziadavka.idciselnik = 8 and cd_poziadavka.stav in (0, 1)
            left join ciselnik_data cd_prace on u.Typ_prace = cd_prace.Hodnota And cd_prace.idciselnik = 9 and cd_prace.stav in (0, 1)
            left join oddelenia On u.oddelenie = oddelenia.id_oddelenia and oddelenia.stav in (0, 1)
            left join uzivatelia On u.Nahlasil_ID_zamestanca = uzivatelia.id_uzivatela
            WHERE
            Typ_ulohy = 0 and Stav_ulohy = 6 and u.stav = 0 and (pxu.id_uzivatela = '" & Ponuka.id_uzivatela & "' or u.Nahlasil_ID_zamestanca = '" & Ponuka.id_uzivatela & "' or '" & Ponuka.ZiadankySprava & "' = 4)
            ;")
            cmd.Connection = con
            cmd.CommandTimeout = 1200
            con.Open()
            Using sdr As MySqlDataReader = cmd.ExecuteReader()

                'Vytvorenie tabulky
                Dim dtCustomers As New DataTable("Poziadavky")
                Dim ds As New DataSet()

                'Nacitanie dat
                dtCustomers.Load(sdr)

                'Pridanie dat do tabulky
                ds.Tables.Add(dtCustomers)

                dgv_UkonceneUdrzba.ColumnCount = 7
                dgv_UkonceneUdrzba.Columns(0).Name = "Požiadavka číslo"
                dgv_UkonceneUdrzba.Columns(1).Name = "Typ požiadavky"
                dgv_UkonceneUdrzba.Columns(2).Name = "Typ práce"
                dgv_UkonceneUdrzba.Columns(3).Name = "Dátum"
                dgv_UkonceneUdrzba.Columns(4).Name = "Urgencia"
                dgv_UkonceneUdrzba.Columns(5).Name = "Oddelenie"
                dgv_UkonceneUdrzba.Columns(6).Name = "Zadávateľ"

                ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                ProgressBar1.Value = ProgressBar1.Value + 1

                Dim i As Integer = 0

                Do Until i = ds.Tables(0).Rows.Count
                    dgv_UkonceneUdrzba.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString, ds.Tables(0).Rows(i).Item(6).ToString)
                    ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    i = i + 1
                Loop

            End Using
            Spracovanie_dat.Close()
            con.Close()

            'Zvyraznenie riadku pri splneni podmienky
            For i = 0 To dgv_UkonceneUdrzba.Rows.Count - 1
                If dgv_UkonceneUdrzba.Rows(i).Cells("Urgencia").Value = "Áno" Then
                    dgv_UkonceneUdrzba.Rows(i).DefaultCellStyle.BackColor = Color.LightSkyBlue
                End If
            Next

        End Using
        con.Close()

        'Data pre naplnenie tabulky INVESTICIA
        Using cmd As New MySqlCommand("Select
	            Uloha_cislo as 'Žiadanka číslo',
                cd_poziadavka.Nazov_hodnoty as 'Typ požiadavky', 
	            cd_prace.Nazov_hodnoty as 'Typ práce', 
	            date_format(u.Nahlasene_dna, GET_FORMAT(DATE,'EUR')) as 'Dátum', 
                case 
	            when Urgencia = 0 then 'Nie' 
	            Else 'Áno' 
                        End As 'Urgencia', 
	            CONCAT_WS(' - ', oddelenia.Nazov_oddelenia, u.Cast) as 'Oddelenie',
	            CONCAT_WS(' ', uzivatelia.meno, uzivatelia.Priezvisko) as 'Zadávateľ' 
            From uloha u
            left join uloha_x_prace uxp on u.id_ulohy = uxp.id_uloha and uxp.stav = 0
            left join prace p on uxp.id_prace = p.id_prace and p.stav in (0, 1)
            left join prace_x_uzivatel pxu on p.id_prace = pxu.id_prace and pxu.stav in (0, 1)
            left join ciselnik_data cd_poziadavka on u.Typ_poziadavky = cd_poziadavka.Hodnota And cd_poziadavka.idciselnik = 8 and cd_poziadavka.stav in (0, 1)
            left join ciselnik_data cd_prace on u.Typ_prace = cd_prace.Hodnota And cd_prace.idciselnik = 9 and cd_prace.stav in (0, 1)
            left join oddelenia On u.oddelenie = oddelenia.id_oddelenia and oddelenia.stav in (0, 1)
            left join uzivatelia On u.Nahlasil_ID_zamestanca = uzivatelia.id_uzivatela
            WHERE
            Typ_ulohy = 1 and u.stav = 0 and (pxu.id_uzivatela = '" & Ponuka.id_uzivatela & "' or u.Nahlasil_ID_zamestanca = '" & Ponuka.id_uzivatela & "' or '" & Ponuka.ZiadankySprava & "' = 4)
            ;")
            cmd.Connection = con
            cmd.CommandTimeout = 1200
            con.Open()
            Using sdr As MySqlDataReader = cmd.ExecuteReader()

                'Vytvorenie tabulky
                Dim dtCustomers As New DataTable("Poziadavky")
                Dim ds As New DataSet()

                'Nacitanie dat
                dtCustomers.Load(sdr)

                'Pridanie dat do tabulky
                ds.Tables.Add(dtCustomers)

                dgv_Investicie.ColumnCount = 7
                dgv_Investicie.Columns(0).Name = "Požiadavka číslo"
                dgv_Investicie.Columns(1).Name = "Typ požiadavky"
                dgv_Investicie.Columns(2).Name = "Typ práce"
                dgv_Investicie.Columns(3).Name = "Dátum"
                dgv_Investicie.Columns(4).Name = "Urgencia"
                dgv_Investicie.Columns(5).Name = "Oddelenie"
                dgv_Investicie.Columns(6).Name = "Zadávateľ"

                ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                ProgressBar1.Value = ProgressBar1.Value + 1

                Dim i As Integer = 0

                Do Until i = ds.Tables(0).Rows.Count
                    dgv_Investicie.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString, ds.Tables(0).Rows(i).Item(6).ToString)
                    ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    i = i + 1
                Loop

            End Using
            Spracovanie_dat.Close()
            con.Close()

            'Zvyraznenie riadku pri splneni podmienky
            For i = 0 To dgv_Investicie.Rows.Count - 1
                If dgv_Investicie.Rows(i).Cells("Urgencia").Value = "Áno" Then
                    dgv_Investicie.Rows(i).DefaultCellStyle.BackColor = Color.LightSkyBlue
                End If
            Next

        End Using
        con.Close()

        'Data pre naplnenie tabulky MESACNA
        Using cmd As New MySqlCommand("Select
	            Uloha_cislo as 'Žiadanka číslo',
                cd_poziadavka.Nazov_hodnoty as 'Typ požiadavky', 
	            cd_prace.Nazov_hodnoty as 'Typ práce', 
	            date_format(u.Nahlasene_dna, GET_FORMAT(DATE,'EUR')) as 'Dátum', 
                case 
	            when Urgencia = 0 then 'Nie' 
	            Else 'Áno' 
                        End As 'Urgencia', 
	            CONCAT_WS(' - ', oddelenia.Nazov_oddelenia, u.Cast) as 'Oddelenie',
	            CONCAT_WS(' ', uzivatelia.meno, uzivatelia.Priezvisko) as 'Zadávateľ' 
            From uloha u
            left join uloha_x_prace uxp on u.id_ulohy = uxp.id_uloha and uxp.stav = 0
            left join prace p on uxp.id_prace = p.id_prace and p.stav in (0, 1)
            left join prace_x_uzivatel    pxu on p.id_prace = pxu.id_prace and pxu.stav in (0, 1)
            left join ciselnik_data cd_poziadavka on u.Typ_poziadavky = cd_poziadavka.Hodnota And cd_poziadavka.idciselnik = 8 and cd_poziadavka.stav in (0, 1)
            left join ciselnik_data cd_prace on u.Typ_prace = cd_prace.Hodnota And cd_prace.idciselnik = 9 and cd_prace.stav in (0, 1)
            left join oddelenia On u.oddelenie = oddelenia.id_oddelenia and oddelenia.stav in (0, 1)
            left join uzivatelia On u.Nahlasil_ID_zamestanca = uzivatelia.id_uzivatela
            WHERE
            Typ_ulohy = 2 and u.stav = 0 and (pxu.id_uzivatela = '" & Ponuka.id_uzivatela & "' or u.Nahlasil_ID_zamestanca = '" & Ponuka.id_uzivatela & "' or '" & Ponuka.ZiadankySprava & "' = 4)
            ;")
            cmd.Connection = con
            cmd.CommandTimeout = 1200
            con.Open()
            Using sdr As MySqlDataReader = cmd.ExecuteReader()

                'Vytvorenie tabulky
                Dim dtCustomers As New DataTable("Poziadavky")
                Dim ds As New DataSet()

                'Nacitanie dat
                dtCustomers.Load(sdr)

                'Pridanie dat do tabulky
                ds.Tables.Add(dtCustomers)

                dgv_Mesacna.ColumnCount = 7
                dgv_Mesacna.Columns(0).Name = "Požiadavka číslo"
                dgv_Mesacna.Columns(1).Name = "Typ požiadavky"
                dgv_Mesacna.Columns(2).Name = "Typ práce"
                dgv_Mesacna.Columns(3).Name = "Dátum"
                dgv_Mesacna.Columns(4).Name = "Urgencia"
                dgv_Mesacna.Columns(5).Name = "Oddelenie"
                dgv_Mesacna.Columns(6).Name = "Zadávateľ"

                ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                ProgressBar1.Value = ProgressBar1.Value + 1

                Dim i As Integer = 0

                Do Until i = ds.Tables(0).Rows.Count
                    dgv_Mesacna.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString, ds.Tables(0).Rows(i).Item(6).ToString)
                    ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    i = i + 1
                Loop

            End Using
            Spracovanie_dat.Close()
            con.Close()

            'Zvyraznenie riadku pri splneni podmienky
            For i = 0 To dgv_Investicie.Rows.Count - 1
                If dgv_Mesacna.Rows(i).Cells("Urgencia").Value = "Áno" Then
                    dgv_Mesacna.Rows(i).DefaultCellStyle.BackColor = Color.LightSkyBlue
                End If
            Next

        End Using
        con.Close()

        'Data pre naplnenie tabulky MESACNA UKONCENA
        Using cmd As New MySqlCommand("Select
	            Uloha_cislo as 'Žiadanka číslo',
                cd_poziadavka.Nazov_hodnoty as 'Typ požiadavky', 
	            cd_prace.Nazov_hodnoty as 'Typ práce', 
	            date_format(u.Nahlasene_dna, GET_FORMAT(DATE,'EUR')) as 'Dátum', 
                case 
	            when Urgencia = 0 then 'Nie' 
	            Else 'Áno' 
                        End As 'Urgencia', 
	            CONCAT_WS(' - ', oddelenia.Nazov_oddelenia, u.Cast) as 'Oddelenie',
	            CONCAT_WS(' ', uzivatelia.meno, uzivatelia.Priezvisko) as 'Zadávateľ' 
            From uloha u
            left join uloha_x_prace uxp on u.id_ulohy = uxp.id_uloha and uxp.stav = 0
            left join prace p on uxp.id_prace = p.id_prace and p.stav in (0, 1)
            left join prace_x_uzivatel    pxu on p.id_prace = pxu.id_prace and pxu.stav in (0, 1)
            left join ciselnik_data cd_poziadavka on u.Typ_poziadavky = cd_poziadavka.Hodnota And cd_poziadavka.idciselnik = 8 and cd_poziadavka.stav in (0, 1)
            left join ciselnik_data cd_prace on u.Typ_prace = cd_prace.Hodnota And cd_prace.idciselnik = 9 and cd_prace.stav in (0, 1)
            left join oddelenia On u.oddelenie = oddelenia.id_oddelenia and oddelenia.stav in (0, 1)
            left join uzivatelia On u.Nahlasil_ID_zamestanca = uzivatelia.id_uzivatela
            WHERE
            Typ_ulohy = 2 and u.stav = 6 and (pxu.id_uzivatela = '" & Ponuka.id_uzivatela & "' or u.Nahlasil_ID_zamestanca = '" & Ponuka.id_uzivatela & "' or '" & Ponuka.ZiadankySprava & "' = 4)
            ;")
            cmd.Connection = con
            cmd.CommandTimeout = 1200
            con.Open()
            Using sdr As MySqlDataReader = cmd.ExecuteReader()

                'Vytvorenie tabulky
                Dim dtCustomers As New DataTable("Poziadavky")
                Dim ds As New DataSet()

                'Nacitanie dat
                dtCustomers.Load(sdr)

                'Pridanie dat do tabulky
                ds.Tables.Add(dtCustomers)

                dgv_MesacnaUkoncena.ColumnCount = 7
                dgv_MesacnaUkoncena.Columns(0).Name = "Požiadavka číslo"
                dgv_MesacnaUkoncena.Columns(1).Name = "Typ požiadavky"
                dgv_MesacnaUkoncena.Columns(2).Name = "Typ práce"
                dgv_MesacnaUkoncena.Columns(3).Name = "Dátum"
                dgv_MesacnaUkoncena.Columns(4).Name = "Urgencia"
                dgv_MesacnaUkoncena.Columns(5).Name = "Oddelenie"
                dgv_MesacnaUkoncena.Columns(6).Name = "Zadávateľ"

                ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                ProgressBar1.Value = ProgressBar1.Value + 1

                Dim i As Integer = 0

                Do Until i = ds.Tables(0).Rows.Count
                    dgv_MesacnaUkoncena.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString, ds.Tables(0).Rows(i).Item(6).ToString)
                    ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    i = i + 1
                Loop

            End Using
            Spracovanie_dat.Close()
            con.Close()

            'Zvyraznenie riadku pri splneni podmienky
            For i = 0 To dgv_Investicie.Rows.Count - 1
                If dgv_MesacnaUkoncena.Rows(i).Cells("Urgencia").Value = "Áno" Then
                    dgv_MesacnaUkoncena.Rows(i).DefaultCellStyle.BackColor = Color.LightSkyBlue
                End If
            Next

        End Using
        con.Close()

        'Data pre naplnenie tabulky POHOTOVOST
        Using cmd As New MySqlCommand("Select
	            Uloha_cislo as 'Žiadanka číslo',
                cd_poziadavka.Nazov_hodnoty as 'Typ požiadavky', 
	            cd_prace.Nazov_hodnoty as 'Typ práce', 
	            date_format(u.Nahlasene_dna, GET_FORMAT(DATE,'EUR')) as 'Dátum', 
                case 
	            when Urgencia = 0 then 'Nie' 
	            Else 'Áno' 
                        End As 'Urgencia', 
	            CONCAT_WS(' - ', oddelenia.Nazov_oddelenia, u.Cast) as 'Oddelenie',
	            CONCAT_WS(' ', uzivatelia.meno, uzivatelia.Priezvisko) as 'Zadávateľ' 
            From uloha u
            left join uloha_x_prace uxp on u.id_ulohy = uxp.id_uloha and uxp.stav = 0
            left join prace p on uxp.id_prace = p.id_prace and p.stav in (0, 1)
            left join prace_x_uzivatel    pxu on p.id_prace = pxu.id_prace and pxu.stav in (0, 1)
            left join ciselnik_data cd_poziadavka on u.Typ_poziadavky = cd_poziadavka.Hodnota And cd_poziadavka.idciselnik = 8 and cd_poziadavka.stav in (0, 1)
            left join ciselnik_data cd_prace on u.Typ_prace = cd_prace.Hodnota And cd_prace.idciselnik = 9 and cd_prace.stav in (0, 1)
            left join oddelenia On u.oddelenie = oddelenia.id_oddelenia and oddelenia.stav in (0, 1)
            left join uzivatelia On u.Nahlasil_ID_zamestanca = uzivatelia.id_uzivatela
            WHERE
            Typ_ulohy = 3 and u.stav = 0 and (pxu.id_uzivatela = '" & Ponuka.id_uzivatela & "' or u.Nahlasil_ID_zamestanca = '" & Ponuka.id_uzivatela & "' or '" & Ponuka.ZiadankySprava & "' = 4)
            ;")
            cmd.Connection = con
            cmd.CommandTimeout = 1200
            con.Open()
            Using sdr As MySqlDataReader = cmd.ExecuteReader()

                'Vytvorenie tabulky
                Dim dtCustomers As New DataTable("Poziadavky")
                Dim ds As New DataSet()

                'Nacitanie dat
                dtCustomers.Load(sdr)

                'Pridanie dat do tabulky
                ds.Tables.Add(dtCustomers)

                dgv_Pohotovost.ColumnCount = 7
                dgv_Pohotovost.Columns(0).Name = "Požiadavka číslo"
                dgv_Pohotovost.Columns(1).Name = "Typ požiadavky"
                dgv_Pohotovost.Columns(2).Name = "Typ práce"
                dgv_Pohotovost.Columns(3).Name = "Dátum"
                dgv_Pohotovost.Columns(4).Name = "Urgencia"
                dgv_Pohotovost.Columns(5).Name = "Oddelenie"
                dgv_Pohotovost.Columns(6).Name = "Zadávateľ"

                ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                ProgressBar1.Value = ProgressBar1.Value + 1

                Dim i As Integer = 0

                Do Until i = ds.Tables(0).Rows.Count
                    dgv_Pohotovost.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString, ds.Tables(0).Rows(i).Item(6).ToString)
                    ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    i = i + 1
                Loop

            End Using
            Spracovanie_dat.Close()
            con.Close()

        End Using
        con.Close()

        'Data pre naplnenie tabulky POHOTOVOST UKONCENA
        Using cmd As New MySqlCommand("Select
	            Uloha_cislo as 'Žiadanka číslo',
                cd_poziadavka.Nazov_hodnoty as 'Typ požiadavky', 
	            cd_prace.Nazov_hodnoty as 'Typ práce', 
	            date_format(u.Nahlasene_dna, GET_FORMAT(DATE,'EUR')) as 'Dátum', 
                case 
	            when Urgencia = 0 then 'Nie' 
	            Else 'Áno' 
                        End As 'Urgencia', 
	            CONCAT_WS(' - ', oddelenia.Nazov_oddelenia, u.Cast) as 'Oddelenie',
	            CONCAT_WS(' ', uzivatelia.meno, uzivatelia.Priezvisko) as 'Zadávateľ' 
            From uloha u
            left join uloha_x_prace uxp on u.id_ulohy = uxp.id_uloha and uxp.stav = 0
            left join prace p on uxp.id_prace = p.id_prace and p.stav in (0, 1)
            left join prace_x_uzivatel    pxu on p.id_prace = pxu.id_prace and pxu.stav in (0, 1)
            left join ciselnik_data cd_poziadavka on u.Typ_poziadavky = cd_poziadavka.Hodnota And cd_poziadavka.idciselnik = 8 and cd_poziadavka.stav in (0, 1)
            left join ciselnik_data cd_prace on u.Typ_prace = cd_prace.Hodnota And cd_prace.idciselnik = 9 and cd_prace.stav in (0, 1)
            left join oddelenia On u.oddelenie = oddelenia.id_oddelenia and oddelenia.stav in (0, 1)
            left join uzivatelia On u.Nahlasil_ID_zamestanca = uzivatelia.id_uzivatela
            WHERE
            Typ_ulohy = 3 and u.stav = 6 and (pxu.id_uzivatela = '" & Ponuka.id_uzivatela & "' or u.Nahlasil_ID_zamestanca = '" & Ponuka.id_uzivatela & "' or '" & Ponuka.ZiadankySprava & "' = 4)
            ;")
            cmd.Connection = con
            cmd.CommandTimeout = 1200
            con.Open()
            Using sdr As MySqlDataReader = cmd.ExecuteReader()

                'Vytvorenie tabulky
                Dim dtCustomers As New DataTable("Poziadavky")
                Dim ds As New DataSet()

                'Nacitanie dat
                dtCustomers.Load(sdr)

                'Pridanie dat do tabulky
                ds.Tables.Add(dtCustomers)

                dgv_PohotovostUkoncena.ColumnCount = 7
                dgv_PohotovostUkoncena.Columns(0).Name = "Požiadavka číslo"
                dgv_PohotovostUkoncena.Columns(1).Name = "Typ požiadavky"
                dgv_PohotovostUkoncena.Columns(2).Name = "Typ práce"
                dgv_PohotovostUkoncena.Columns(3).Name = "Dátum"
                dgv_PohotovostUkoncena.Columns(4).Name = "Urgencia"
                dgv_PohotovostUkoncena.Columns(5).Name = "Oddelenie"
                dgv_PohotovostUkoncena.Columns(6).Name = "Zadávateľ"

                ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                ProgressBar1.Value = ProgressBar1.Value + 1

                Dim i As Integer = 0

                Do Until i = ds.Tables(0).Rows.Count
                    dgv_PohotovostUkoncena.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString, ds.Tables(0).Rows(i).Item(6).ToString)
                    ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    i = i + 1
                Loop

            End Using
            Spracovanie_dat.Close()
            con.Close()

        End Using
        con.Close()

        'Nastavenia velkosti stlpcov
        dgv_Nove.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_Rozpracovane.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_Odlozene.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_VrateneUdrzbe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_VeduciUkoncenie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_VrateneZadavatelovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_UkoncenieZadavatelom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_UkonceneUdrzba.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_Investicie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_Mesacna.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_MesacnaUkoncena.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_Pohotovost.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_PohotovostUkoncena.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        ProgressBar1.Maximum = ProgressBar1.Maximum + 1
        ProgressBar1.Value = ProgressBar1.Value + 1

    End Sub

    Public Sub selectedRowsButton_Click_Nove(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_Nove.Click
        Poziadavka_cislo = dgv_Nove.CurrentRow.Cells("Požiadavka číslo").Value
        Ziadanky_sprava.Show()
    End Sub

    Public Sub selectedRowsButton_Click_Rozpracovane(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_Rozpracovane.Click
        Poziadavka_cislo = dgv_Rozpracovane.CurrentRow.Cells("Požiadavka číslo").Value
        Ziadanky_sprava.Show()
    End Sub

    Public Sub selectedRowsButton_Click_Odlozene(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_Odlozene.Click
        Poziadavka_cislo = dgv_Odlozene.CurrentRow.Cells("Požiadavka číslo").Value
        Ziadanky_sprava.Show()
    End Sub

    Public Sub selectedRowsButton_Click_VrateneZadavatelovi(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_VrateneZadavatelovi.Click
        Poziadavka_cislo = dgv_VrateneZadavatelovi.CurrentRow.Cells("Požiadavka číslo").Value
        Ziadanky_sprava.Show()
    End Sub

    Public Sub selectedRowsButton_Click_VrateneUdrzba(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_VrateneUdrzbe.Click
        Poziadavka_cislo = dgv_VrateneUdrzbe.CurrentRow.Cells("Požiadavka číslo").Value
        Ziadanky_sprava.Show()
    End Sub
    Public Sub selectedRowsButton_Click_VeduciUkoncenie(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_VeduciUkoncenie.Click
        Poziadavka_cislo = dgv_VeduciUkoncenie.CurrentRow.Cells("Požiadavka číslo").Value
        Ziadanky_sprava.Show()
    End Sub
    Public Sub selectedRowsButton_Click_UkoncenieZadavatelom(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_UkoncenieZadavatelom.Click
        Poziadavka_cislo = dgv_UkoncenieZadavatelom.CurrentRow.Cells("Požiadavka číslo").Value
        Ziadanky_sprava.Show()
    End Sub

    Public Sub selectedRowsButton_Click_UkonceneUdrzba(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_UkonceneUdrzba.Click
        Poziadavka_cislo = dgv_UkonceneUdrzba.CurrentRow.Cells("Požiadavka číslo").Value
        Ziadanky_sprava.Show()
    End Sub

    Public Sub selectedRowsButton_Click_Investicie(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_Investicie.Click
        Poziadavka_cislo = dgv_Investicie.CurrentRow.Cells("Požiadavka číslo").Value
        Ziadanky_sprava.Show()
    End Sub

    Public Sub selectedRowsButton_Click_Mesacna(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_Mesacna.Click
        Poziadavka_cislo = dgv_Mesacna.CurrentRow.Cells("Požiadavka číslo").Value
        Ziadanky_sprava.Show()
    End Sub

    Public Sub selectedRowsButton_Click_MesacnaUkoncena(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_MesacnaUkoncena.Click
        Poziadavka_cislo = dgv_MesacnaUkoncena.CurrentRow.Cells("Požiadavka číslo").Value
        Ziadanky_sprava.Show()
    End Sub

    Public Sub selectedRowsButton_Click_Pohotovost(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_Pohotovost.Click
        Poziadavka_cislo = dgv_Pohotovost.CurrentRow.Cells("Požiadavka číslo").Value
        Ziadanky_sprava.Show()
    End Sub

    Public Sub selectedRowsButton_Click_PohotovostUkoncena(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_PohotovostUkoncena.Click
        Poziadavka_cislo = dgv_PohotovostUkoncena.CurrentRow.Cells("Požiadavka číslo").Value
        Ziadanky_sprava.Show()
    End Sub
End Class