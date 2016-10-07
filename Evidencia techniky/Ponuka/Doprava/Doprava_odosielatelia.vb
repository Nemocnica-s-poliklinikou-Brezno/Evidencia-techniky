Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie

Public Class Doprava_odosielatelia
    Dim duplicity As String
    Dim PoslednyImport As String
    Dim i As String = 0

    Public Sub Skumavky_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)
        l_Import.Text = Import()

    End Sub

    Public Sub b_VstupneData_Click(sender As Object, e As EventArgs) Handles b_VstupneData.Click

        'Vyčistenie vyslednej tabulky
        DataGridView2.Rows.Clear()

        'Zakazanie tlacidla VYTLACIT
        b_Vytlacit.Enabled = False

        'Vynulovanie indikatoru pred naimportovanim dalsich dat
        ProgressBar1.Maximum = 0
        ProgressBar1.Value = 0

        'Popis okna
        OpenFileDialog1.Title = "Vyberte požadovaný súbor vo formáte TXT"
        OpenFileDialog1.FileName = ""

        'Otvorenie okna na nacitanie suboru
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.FilterIndex = 2

        Dim rowvalue As String
        Dim cellvalue(20) As String

        l_Import.Text = ""

        If OpenFileDialog1.FileName Like "*.txt" Then

            b_VstupneData.Enabled = False
            b_NacitatData.Enabled = False

            Dim streamReader As IO.StreamReader = New IO.StreamReader(OpenFileDialog1.FileName)
            'Vytvorenie hlavicky
            While streamReader.Peek() <> -1
                rowvalue = streamReader.ReadLine()
                cellvalue = rowvalue.Split(vbTab) 'Nastavenie oddelovaca
                DataGridView1.ColumnCount = 28
                DataGridView1.Columns(0).Name = "rok"
                DataGridView1.Columns(1).Name = "cislovyjazdu"
                DataGridView1.Columns(2).Name = "kododd"
                DataGridView1.Columns(3).Name = "rodcis"
                DataGridView1.Columns(4).Name = "stavpoistenca"
                DataGridView1.Columns(5).Name = "sprievodca"
                DataGridView1.Columns(6).Name = "meno"
                DataGridView1.Columns(7).Name = "priezvisko"
                DataGridView1.Columns(8).Name = "typprevozu"
                DataGridView1.Columns(9).Name = "kodpoist"
                DataGridView1.Columns(10).Name = "vzdialenost"
                DataGridView1.Columns(11).Name = "skutocnekm"
                DataGridView1.Columns(12).Name = "koddiagnozy"
                DataGridView1.Columns(13).Name = "casvyjazdu"
                DataGridView1.Columns(14).Name = "spz"
                DataGridView1.Columns(15).Name = "naz_m"
                DataGridView1.Columns(16).Name = "cast_m"
                DataGridView1.Columns(17).Name = "naz_m2"
                DataGridView1.Columns(18).Name = "cast_m2"
                DataGridView1.Columns(19).Name = "typodos"
                DataGridView1.Columns(20).Name = "kodpoistodos"
                DataGridView1.Columns(21).Name = "kododdodos"
                DataGridView1.Columns(22).Name = "evidcis"
                DataGridView1.Columns(23).Name = "status"
                DataGridView1.Columns(24).Name = "statuspoznamka"
                DataGridView1.Columns(25).Name = "oscis"
                DataGridView1.Columns(26).Name = "vodic"
                DataGridView1.Columns(27).Name = "porcisriadok"

                DataGridView1.Rows.Add(cellvalue)

                'Nastavovanie indikatora po kazdom spracovanom riadku
                ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                ProgressBar1.Value = ProgressBar1.Value + 1

                'Naplnenie si premennej DATA
                Dim data As String
                data = ""
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Not row.IsNewRow Then
                        data = "'" & row.Cells(0).Value.ToString & "', '" _
                            & row.Cells(1).Value.ToString & "', '" _
                            & row.Cells(2).Value.ToString & "', '" _
                            & row.Cells(3).Value.ToString & "', '" _
                            & row.Cells(4).Value.ToString & "', '" _
                            & row.Cells(5).Value.ToString & "', '" _
                            & row.Cells(6).Value.ToString & "', '" _
                            & row.Cells(7).Value.ToString & "', '" _
                            & row.Cells(8).Value.ToString & "', '" _
                            & row.Cells(9).Value.ToString & "', '" _
                            & row.Cells(10).Value.ToString & "', '" _
                            & row.Cells(11).Value.ToString & "', '" _
                            & row.Cells(12).Value.ToString & "', '" _
                            & row.Cells(13).Value.ToString & "', '" _
                            & row.Cells(14).Value.ToString & "', '" _
                            & row.Cells(15).Value.ToString & "', '" _
                            & row.Cells(16).Value.ToString & "', '" _
                            & row.Cells(17).Value.ToString & "', '" _
                            & row.Cells(18).Value.ToString & "', '" _
                            & row.Cells(19).Value.ToString & "', '" _
                            & row.Cells(20).Value.ToString & "', '" _
                            & row.Cells(21).Value.ToString & "', '" _
                            & row.Cells(22).Value.ToString & "', '" _
                            & row.Cells(23).Value.ToString & "', '" _
                            & row.Cells(24).Value.ToString & "', '" _
                            & row.Cells(25).Value.ToString & "', '" _
                            & row.Cells(26).Value.ToString & "', '" _
                            & row.Cells(27).Value.ToString & "'"
                    End If
                    ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1

                Next

                Dim QueryDUP As String
                QueryDUP = "SELECT id_doprava_data FROM doprava_data WHERE rok = '" & DataGridView1.Rows(i).Cells(0).Value.ToString & "' AND cislovyjazdu = '" & DataGridView1.Rows(i).Cells(1).Value.ToString & "' AND kododd = '" & DataGridView1.Rows(i).Cells(2).Value.ToString & "' AND rodcis = '" & DataGridView1.Rows(i).Cells(3).Value.ToString & "' AND stavpoistenca = '" & DataGridView1.Rows(i).Cells(4).Value.ToString & "' AND sprievodca = '" & DataGridView1.Rows(i).Cells(5).Value.ToString & "' AND typprevozu = '" & DataGridView1.Rows(i).Cells(8).Value.ToString & "' AND kodpoist = '" & DataGridView1.Rows(i).Cells(9).Value.ToString & "' AND vzdialenost = '" & DataGridView1.Rows(i).Cells(10).Value.ToString & "' AND skutocnekm = '" & DataGridView1.Rows(i).Cells(11).Value.ToString & "' AND koddiagnozy = '" & DataGridView1.Rows(i).Cells(12).Value.ToString & "' AND spz = '" & DataGridView1.Rows(i).Cells(14).Value.ToString & "' AND typodos = '" & DataGridView1.Rows(i).Cells(19).Value.ToString & "' AND kodpoistodos = '" & DataGridView1.Rows(i).Cells(20).Value.ToString & "' AND kododdodos = '" & DataGridView1.Rows(i).Cells(21).Value.ToString & "' AND evidcis = '" & DataGridView1.Rows(i).Cells(22).Value.ToString & "' AND status = '" & DataGridView1.Rows(i).Cells(23).Value.ToString & "' AND statuspoznamka = '" & DataGridView1.Rows(i).Cells(24).Value.ToString & "' AND oscis = '" & DataGridView1.Rows(i).Cells(25).Value.ToString & "' AND porcisriadok = '" & DataGridView1.Rows(i).Cells(27).Value.ToString & "' and rok = year(now());"
                con.Open()
                Dim sqlDUP As MySqlCommand = New MySqlCommand(QueryDUP, con)
                sqlDUP.CommandTimeout = 1200
                Try
                    duplicity = sqlDUP.ExecuteScalar()
                    con.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ETECH - Zápis dát Do databázy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    con.Close()
                End Try

                'Zapisanie dat do databazy
                Dim Query As String
                Query = "INSERT INTO doprava_data(rok, cislovyjazdu, kododd, rodcis, stavpoistenca, sprievodca, meno, priezvisko, typprevozu, kodpoist, vzdialenost, skutocnekm, koddiagnozy, casvyjazdu, spz, naz_m, cast_m, naz_m2, cast_m2, typodos, kodpoistodos, kododdodos, evidcis, status, statuspoznamka, oscis, vodic, porcisriadok, stav, Vlozil_meno, Vlozil_dna) values (" & data & ", 0, '" & Ponuka.Meno_uzivatela & "', now());"
                con.Open()
                Dim sql As MySqlCommand = New MySqlCommand(Query, con)
                sql.CommandTimeout = 1200
                Try
                    If duplicity > 0 Then
                        MessageBox.Show("Našla sa duplicita - číslo výjazdu: " & DataGridView1.Rows(i).Cells(1).Value.ToString, "ETECH - Zápis dát do databázy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        con.Close()
                    Else
                        sql.ExecuteNonQuery()
                        con.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ETECH - Zápis dát do databázy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    con.Close()
                End Try

                ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                ProgressBar1.Value = ProgressBar1.Value + 1
                i = i + 1
            End While

            'Uprava casu s varchar na datetime
            Dim QueryCAS As String
            QueryCAS = "UPDATE doprava_data SET casvyjazdu = STR_TO_DATE(casvyjazdu, ""%d.%m.%Y %H:%i:%s"") WHERE casvyjazdu Like ""%.%"";"
            con.Open()
            Dim sqlCAS As MySqlCommand = New MySqlCommand(QueryCAS, con)
            sqlCAS.CommandTimeout = 1200
            Try
                sqlCAS.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Úprava času na DATETIME", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                con.Close()
            End Try

            'Prehlad na ODOSIELATELOV
            Dim QueryODOS As String
            QueryODOS = "CREATE OR REPLACE View DOPRAVA_ODOSIELATELIA As Select odo.nazovzak, dd.kododdodos, dd.kodpoistodos, left(dd.kodpoist, 2), dd.skutocnekm FROM `doprava_data` dd join `odosielatelia` odo On (odo.kodlekara = dd.kododdodos and odo.kodpzs = dd.kodpoistodos) and odo.stav = 0 where dd.stav = 0 and month(casvyjazdu) = mid(casvyjazdu, 6, 2) and year(casvyjazdu) = year(now()) group by dd.kododdodos, dd.kodpoistodos, left(dd.kodpoist, 2) order by 1, 2, 3;"
            con.Open()
            Dim sqlODOS As MySqlCommand = New MySqlCommand(QueryODOS, con)
            sqlODOS.CommandTimeout = 1200
            Try
                sqlODOS.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Prehľad na ODOSIELATELOV", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                con.Close()
            End Try

            ProgressBar1.Maximum = ProgressBar1.Maximum + 1
            ProgressBar1.Value = ProgressBar1.Value + 1

            'Prehlad na POISTOVNI
            Dim QueryPOIS As String
            QueryPOIS = "CREATE OR REPLACE VIEW DOPRAVA_POISTOVNE AS select dl.Nazov_ZP, left(kodpoist, 2), sum(skutocnekm), dl.limity, (dl.limity - sum(skutocnekm)) from doprava_data dd join doprava_limityZP dl on left(dd.kodpoist, 2) = left(dl.Cislo_ZP, 2) and dl.stav = 0 where dd.stav = 0 and month(casvyjazdu) = MID(casvyjazdu,6,2) and year(casvyjazdu) = year(now()) and typprevozu in ('DZS', 'DZSD', 'DZSP', 'LIEK') and left(kodpoist, 2) = 24 union select dl2.Nazov_ZP, left(kodpoist, 2), sum(skutocnekm), dl2.limity, (dl2.limity - sum(skutocnekm)) from doprava_data dd2 join doprava_limityZP dl2 on left(dd2.kodpoist, 2) = left(dl2.Cislo_ZP, 2) and dl2.stav = 0 where dd2.stav = 0 and typprevozu in ('DZS', 'DZSD', 'DZSP', 'LIEK', 'DIAL') and left(kodpoist, 2) in (25, 27) and month(casvyjazdu) = MID(casvyjazdu,6,2) and year(casvyjazdu) = year(now()) group by left(kodpoist, 2);"
            con.Open()
            Dim sqlPOIS As MySqlCommand = New MySqlCommand(QueryPOIS, con)
            sqlPOIS.CommandTimeout = 1200
            Try
                sqlPOIS.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Prehľad na POISTOVNI", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                con.Close()
            End Try

            ProgressBar1.Maximum = ProgressBar1.Maximum + 1
            ProgressBar1.Value = ProgressBar1.Value + 1

            Using cmd As New MySqlCommand("Select * FROM DOPRAVA_ODOSIELATELIA;")
                cmd.Connection = con
                cmd.CommandTimeout = 1200
                con.Open()
                Using sdr As MySqlDataReader = cmd.ExecuteReader()

                    'Vytvorenie tabulky
                    Dim dtCustomers As New DataTable("Customers")
                    Dim ds As New DataSet()

                    'Nacitanie dat
                    dtCustomers.Load(sdr)

                    'Pridanie dat do tabulky
                    ds.Tables.Add(dtCustomers)

                    DataGridView2.ColumnCount = 5
                    DataGridView2.Columns(0).Name = "Odosielateľ"
                    DataGridView2.Columns(1).Name = "Kód lekára"
                    DataGridView2.Columns(2).Name = "Kód PZS"
                    DataGridView2.Columns(3).Name = "Číslo poistovne"
                    DataGridView2.Columns(4).Name = "KM"

                    ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1

                    Dim i As Integer = 0

                    Do Until i = ds.Tables(0).Rows.Count
                        DataGridView2.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString)
                        ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                        ProgressBar1.Value = ProgressBar1.Value + 1
                        i = i + 1
                    Loop

                End Using
                con.Close()
            End Using

            DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            ProgressBar1.Maximum = ProgressBar1.Maximum + 1
            ProgressBar1.Value = ProgressBar1.Value + 1

            'Aktivovanie tlacidla VYTLACIT
            'b_Vytlacit.Enabled = True

            Using cmd As New MySqlCommand("select * FROM DOPRAVA_POISTOVNE;")
                cmd.Connection = con
                cmd.CommandTimeout = 1200
                con.Open()
                Using sdr As MySqlDataReader = cmd.ExecuteReader()

                    'Vytvorenie tabulky
                    Dim dtCustomers As New DataTable("Customers")
                    Dim ds As New DataSet()

                    'Nacitanie dat
                    dtCustomers.Load(sdr)

                    'Pridanie dat do tabulky
                    ds.Tables.Add(dtCustomers)

                    MessageBox.Show(
                "Nazov ZP" & vbTab & "Kód ZP" & vbTab & "S.KM" & vbTab & "Limit" & vbTab & "Zostatok" & vbCrLf _
                & ds.Tables(0).Rows(0).Item(0) & vbTab & ds.Tables(0).Rows(0).Item(1) & vbTab & ds.Tables(0).Rows(0).Item(2) & vbTab & ds.Tables(0).Rows(0).Item(3) & vbTab & ds.Tables(0).Rows(0).Item(4) & vbCrLf _
                & ds.Tables(0).Rows(1).Item(0) & vbTab & ds.Tables(0).Rows(1).Item(1) & vbTab & ds.Tables(0).Rows(1).Item(2) & vbTab & ds.Tables(0).Rows(1).Item(3) & vbTab & ds.Tables(0).Rows(1).Item(4) & vbCrLf _
                & ds.Tables(0).Rows(2).Item(0) & vbTab & ds.Tables(0).Rows(2).Item(1) & vbTab & ds.Tables(0).Rows(2).Item(2) & vbTab & ds.Tables(0).Rows(2).Item(3) & vbTab & ds.Tables(0).Rows(2).Item(4),
                "ETECH - Prehľad odjazdených KM na poistovňu", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1
                End Using
                con.Close()
            End Using
        End If

        l_Import.Text = Import()
        b_NacitatData.Enabled = True
        b_VstupneData.Enabled = True
    End Sub

    Private Sub b_NacitatData_Click(sender As Object, e As EventArgs) Handles b_NacitatData.Click
        Spracovanie_dat.Show()
        Threading.Thread.Sleep(1000)

        Using cmd As New MySqlCommand("Select * FROM DOPRAVA_ODOSIELATELIA;")
            cmd.Connection = con
            cmd.CommandTimeout = 1200
            con.Open()
            Using sdr As MySqlDataReader = cmd.ExecuteReader()

                'Vytvorenie tabulky
                Dim dtCustomers As New DataTable("Customers")
                Dim ds As New DataSet()

                'Nacitanie dat
                dtCustomers.Load(sdr)

                'Pridanie dat do tabulky
                ds.Tables.Add(dtCustomers)

                DataGridView2.ColumnCount = 5
                DataGridView2.Columns(0).Name = "Odosielateľ"
                DataGridView2.Columns(1).Name = "Kód lekára"
                DataGridView2.Columns(2).Name = "Kód PZS"
                DataGridView2.Columns(3).Name = "Číslo poistovne"
                DataGridView2.Columns(4).Name = "KM"

                ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                ProgressBar1.Value = ProgressBar1.Value + 1

                Dim i As Integer = 0

                Do Until i = ds.Tables(0).Rows.Count
                    DataGridView2.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString)
                    ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    i = i + 1
                Loop

            End Using
            Spracovanie_dat.Close()
            con.Close()
        End Using

        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        ProgressBar1.Maximum = ProgressBar1.Maximum + 1
        ProgressBar1.Value = ProgressBar1.Value + 1

        'Aktivovanie tlacidla VYTLACIT
        'b_Vytlacit.Enabled = True

        Using cmd As New MySqlCommand("select * FROM DOPRAVA_POISTOVNE;")
            cmd.Connection = con
            cmd.CommandTimeout = 1200
            con.Open()
            Using sdr As MySqlDataReader = cmd.ExecuteReader()

                'Vytvorenie tabulky
                Dim dtCustomers As New DataTable("Customers")
                Dim ds As New DataSet()

                'Nacitanie dat
                dtCustomers.Load(sdr)

                'Pridanie dat do tabulky
                ds.Tables.Add(dtCustomers)

                MessageBox.Show(
                "Nazov ZP" & vbTab & "Kód ZP" & vbTab & "S.KM" & vbTab & "Limit" & vbTab & "Zostatok" & vbCrLf _
                & ds.Tables(0).Rows(0).Item(0) & vbTab & ds.Tables(0).Rows(0).Item(1) & vbTab & ds.Tables(0).Rows(0).Item(2) & vbTab & ds.Tables(0).Rows(0).Item(3) & vbTab & ds.Tables(0).Rows(0).Item(4) & vbCrLf _
                & ds.Tables(0).Rows(1).Item(0) & vbTab & ds.Tables(0).Rows(1).Item(1) & vbTab & ds.Tables(0).Rows(1).Item(2) & vbTab & ds.Tables(0).Rows(1).Item(3) & vbTab & ds.Tables(0).Rows(1).Item(4) & vbCrLf _
                & ds.Tables(0).Rows(2).Item(0) & vbTab & ds.Tables(0).Rows(2).Item(1) & vbTab & ds.Tables(0).Rows(2).Item(2) & vbTab & ds.Tables(0).Rows(2).Item(3) & vbTab & ds.Tables(0).Rows(2).Item(4),
                "ETECH - Prehľad odjazdených KM na poistovňu", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ProgressBar1.Maximum = ProgressBar1.Maximum + 1
                ProgressBar1.Value = ProgressBar1.Value + 1
            End Using
            con.Close()
        End Using
    End Sub

    Private Sub b_Vytlacit_Click_1(sender As Object, e As EventArgs) Handles b_Vytlacit.Click

        'Nastavenie orientacie dokumentu
        pd_DopravaOdosielatelia.DefaultPageSettings.Landscape = True

        ppd_DopravaOdosielatelia.Document = pd_DopravaOdosielatelia

        ppd_DopravaOdosielatelia.ShowDialog()

    End Sub

End Class