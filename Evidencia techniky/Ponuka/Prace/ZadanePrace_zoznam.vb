Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Public Class Zoznam_zadanych_prac
    Public Shared id_prace As String
    Private Sub Sprava_prac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)
    End Sub

    Private Sub b_NacitatUdaje_Click(sender As Object, e As EventArgs) Handles b_NacitatUdaje.Click
        Spracovanie_dat.Show()

        'Vyčistenie vyslednej tabuliek
        dgv_ZadanePrace.Rows.Clear()
        dgv_UkoncenePrace.Rows.Clear()

        'Data pre naplnenie tabulky ZADANÉ PRÁCE
        Using cmd As New MySqlCommand("Select
                id_prace,
	            Cislo_prace as 'Čislo práce',
                CONCAT_WS(' ', uzivatelia.meno, uzivatelia.Priezvisko) as 'Priradené',
                p.Popis_prace as 'Popis práce',
                cd_prace.Nazov_Hodnoty as 'Druh práce',
                p.Prijate as 'Dátum zadania práce',
                DATE_FORMAT(p.Odovzdat_do, '%d.%m.%Y') as 'Odovzdať do',
                DATE_FORMAT(p.Spracovane, '%d.%m.%Y') as 'Spracované',
                cd_stav.Nazov_hodnoty as 'Stav práce'
            From prace p
            Join ciselnik_data cd_prace on p.Druh_prace = cd_prace.Hodnota And cd_prace.idciselnik = 9 and cd_prace.stav = 0
            Join ciselnik_data cd_stav on p.Stav_prace = cd_stav.Hodnota And cd_stav.idciselnik = 11 and cd_stav.stav = 0
            Join uzivatelia On p.id_uzivatela = uzivatelia.id_uzivatela
            WHERE
            p.Stav_prace != 5 and p.stav = 0 and (p.id_uzivatela = '" & Ponuka.id_uzivatela & "' or '" & Ponuka.id_uzivatela & "' IN (7,2))
            order by 3 desc            
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

                dgv_ZadanePrace.ColumnCount = 9
                dgv_ZadanePrace.Columns(0).Name = "id_prace"
                dgv_ZadanePrace.Columns(0).Visible = False
                dgv_ZadanePrace.Columns(1).Name = "Číslo práce"
                dgv_ZadanePrace.Columns(2).Name = "Priradené"
                dgv_ZadanePrace.Columns(3).Name = "Popis práce"
                dgv_ZadanePrace.Columns(4).Name = "Druh práce"
                dgv_ZadanePrace.Columns(5).Name = "Dátum zadania práce"
                dgv_ZadanePrace.Columns(6).Name = "Odovzdať prácu do"
                dgv_ZadanePrace.Columns(7).Name = "Práca spracovaná"
                dgv_ZadanePrace.Columns(8).Name = "Stav práce"

                Dim i As Integer = 0

                Do Until i = ds.Tables(0).Rows.Count
                    dgv_ZadanePrace.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString, ds.Tables(0).Rows(i).Item(6).ToString, ds.Tables(0).Rows(i).Item(7).ToString, ds.Tables(0).Rows(i).Item(8).ToString)
                    i = i + 1
                Loop
            End Using
            con.Close()
        End Using
        con.Close()

        'Data pre naplnenie tabulky UKONČENÉ PRÁCE
        Using cmd As New MySqlCommand("Select
                id_prace,
	            Cislo_prace as 'Čislo práce',
                CONCAT_WS(' ', uzivatelia.meno, uzivatelia.Priezvisko) as 'Priradené',
                p.Popis_prace as 'Popis práce',
                cd_prace.Nazov_Hodnoty as 'Druh práce',
                p.Prijate as 'Dátum zadania práce',
                DATE_FORMAT(p.Odovzdat_do, '%d.%m.%Y') as 'Odovzdať do',
                DATE_FORMAT(p.Spracovane, '%d.%m.%Y') as 'Spracované',
                cd_stav.Nazov_hodnoty as 'Stav práce'
            From prace p
            Join ciselnik_data cd_prace on p.Druh_prace = cd_prace.Hodnota And cd_prace.idciselnik = 9 and cd_prace.stav = 0
            Join ciselnik_data cd_stav on p.Stav_prace = cd_stav.Hodnota And cd_stav.idciselnik = 11 and cd_stav.stav = 0
            Join uzivatelia On p.id_uzivatela = uzivatelia.id_uzivatela
            WHERE
            p.Stav_prace = 5 and p.stav = 0 and (p.id_uzivatela = '" & Ponuka.id_uzivatela & "' or '" & Ponuka.id_uzivatela & "' IN (7,2))
            order by 3 desc            
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

                dgv_UkoncenePrace.ColumnCount = 9
                dgv_UkoncenePrace.Columns(0).Name = "id_prace"
                dgv_UkoncenePrace.Columns(0).Visible = False
                dgv_UkoncenePrace.Columns(1).Name = "Číslo práce"
                dgv_UkoncenePrace.Columns(2).Name = "Priradené"
                dgv_UkoncenePrace.Columns(3).Name = "Popis práce"
                dgv_UkoncenePrace.Columns(4).Name = "Druh práce"
                dgv_UkoncenePrace.Columns(5).Name = "Dátum zadania práce"
                dgv_UkoncenePrace.Columns(6).Name = "Odovzdať prácu do"
                dgv_UkoncenePrace.Columns(7).Name = "Práca spracovaná"
                dgv_UkoncenePrace.Columns(8).Name = "Stav práce"

                Dim i As Integer = 0

                Do Until i = ds.Tables(0).Rows.Count
                    dgv_UkoncenePrace.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString, ds.Tables(0).Rows(i).Item(6).ToString, ds.Tables(0).Rows(i).Item(7).ToString, ds.Tables(0).Rows(i).Item(8).ToString)
                    i = i + 1
                Loop
            End Using
            Spracovanie_dat.Close()
            con.Close()
        End Using
        con.Close()

        'Nastavenie šírky stĺpcov
        dgv_ZadanePrace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_UkoncenePrace.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    End Sub
    Public Sub selectedRowsButton_Click_Zadane(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_ZadanePrace.Click
        id_prace = dgv_ZadanePrace.CurrentRow.Cells("id_prace").Value
        ZadanePrace_sprava.Show()
    End Sub

    Public Sub selectedRowsButton_Click_Ukoncene(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_UkoncenePrace.Click
        id_prace = dgv_UkoncenePrace.CurrentRow.Cells("id_prace").Value
        ZadanePrace_sprava.Show()
    End Sub
End Class