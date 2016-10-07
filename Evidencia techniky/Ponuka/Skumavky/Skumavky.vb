Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie

Public Class Skumavky
    Public Sub Skumavky_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)

        'Právo na pridavanie
        Dim QuerySEL As String
        Dim Result As String

        QuerySEL = "Select p.Skumavky From prava p join uzivatelia u on p.id_uzivatela = u.id_uzivatela WHERE u.Zablokovany = 0 and u.UzivatelMeno ='" & Ponuka.Meno_uzivatela & "'"
        con.Open()
        Dim sqlSEL As MySqlCommand = New MySqlCommand(QuerySEL, con)
        Try
            Result = sqlSEL.ExecuteScalar()
            If Result > 2 Then
                ll_PridatLekaraVykon.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Zistenie práv na vkladanie záznamov do databazy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        con.Close()
    End Sub

    Public Sub b_VstupneData_Click(sender As Object, e As EventArgs) Handles b_VstupneData.Click

        'Zakazanie tlacidla VYTLACIT
        b_Vytlacit.Enabled = False

        'Vynulovanie indikatoru pred naimportovanim dalsich dat
        ProgressBar1.Maximum = 0
        ProgressBar1.Value = 0

        'Oznacenie spracovanych dat STAV = 1
        Dim QueryUPD As String
        QueryUPD = "UPDATE skumavky_data set stav = 1, Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() where stav = 0;"
        con.Open()
        Dim sqlUPD As MySqlCommand = New MySqlCommand(QueryUPD, con)
        Try
            sqlUPD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Označenie spracovaných záznamov", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        con.Close()

        'Popis okna
        OpenFileDialog1.Title = "Vyberte požadovaný súbor"

        'Otvorenie okna na nacitanie suboru
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.FilterIndex = 2

        Dim rowvalue As String
        Dim cellvalue(20) As String

        If OpenFileDialog1.FileName Like "*.txt" Then

            Dim streamReader As IO.StreamReader = New IO.StreamReader(OpenFileDialog1.FileName)
            'Vytvorenie hlavicky
            While streamReader.Peek() <> -1
                rowvalue = streamReader.ReadLine()
                cellvalue = rowvalue.Split(vbTab) 'Nastavenie oddelovaca
                DataGridView1.ColumnCount = 37
                DataGridView1.Columns(0).Name = "datumuct"
                DataGridView1.Columns(1).Name = "koddiagnozy"
                DataGridView1.Columns(2).Name = "kodvykonu"
                DataGridView1.Columns(3).Name = "pocvykon"
                DataGridView1.Columns(4).Name = "body"
                DataGridView1.Columns(5).Name = "rozlisznak"
                DataGridView1.Columns(6).Name = "kodlieku"
                DataGridView1.Columns(7).Name = "mnozstvo"
                DataGridView1.Columns(8).Name = "cena"
                DataGridView1.Columns(9).Name = "kodnahr"
                DataGridView1.Columns(10).Name = "pohybpac"
                DataGridView1.Columns(11).Name = "kodpoist"
                DataGridView1.Columns(12).Name = "kododd"
                DataGridView1.Columns(13).Name = "kodlekara"
                DataGridView1.Columns(14).Name = "datzapisu"
                DataGridView1.Columns(15).Name = "rodcis"
                DataGridView1.Columns(16).Name = "porcispobyt"
                DataGridView1.Columns(17).Name = "evidcis"
                DataGridView1.Columns(18).Name = "oscis"
                DataGridView1.Columns(19).Name = "pom1"
                DataGridView1.Columns(20).Name = "typodos"
                DataGridView1.Columns(21).Name = "kodpoistodos"
                DataGridView1.Columns(22).Name = "kododdodos"
                DataGridView1.Columns(23).Name = "pom2"
                DataGridView1.Columns(24).Name = "pedostomat"
                DataGridView1.Columns(25).Name = "cudzinec"
                DataGridView1.Columns(26).Name = "stat"
                DataGridView1.Columns(27).Name = "cislo"
                DataGridView1.Columns(28).Name = "kodmakra"
                DataGridView1.Columns(29).Name = "zub"
                DataGridView1.Columns(30).Name = "skia"
                DataGridView1.Columns(31).Name = "cestovne"
                DataGridView1.Columns(32).Name = "kodvykonunahrada"
                DataGridView1.Columns(33).Name = "urobil"
                DataGridView1.Columns(34).Name = "vykonid"
                DataGridView1.Columns(35).Name = "compute_0036"
                DataGridView1.Columns(36).Name = "compute_0037"

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
                        & row.Cells(27).Value.ToString & "', '" _
                        & row.Cells(28).Value.ToString & "', '" _
                        & row.Cells(29).Value.ToString & "', '" _
                        & row.Cells(30).Value.ToString & "', '" _
                        & row.Cells(31).Value.ToString & "', '" _
                        & row.Cells(32).Value.ToString & "', '" _
                        & row.Cells(33).Value.ToString & "', '" _
                        & row.Cells(34).Value.ToString & "', '" _
                        & row.Cells(35).Value.ToString & "', '" _
                        & row.Cells(36).Value.ToString & "'"
                    End If
                Next

                'Zapisanie dat do databazy
                Dim Query As String
                Query = "INSERT INTO skumavky_data(datumuct, koddiagnozy, kodvykonu, pocvykon, body, rozlisznak, kodlieku, mnozstvo, cena, kodnahr, pohybpac, kodpoist, kododd, kodlekara, datzapisu, rodcis, porcispobyt, evidcis, oscis, pom1, typodos, kodpoistodos, kododdodos, pom2, pedostomat, cudzinec, stat, cislo, kodmakra, zub, skia, cestovne, kodvykonunahrada, urobil, vykonid, compute_0036, compute_0037, stav, vlozene, Vlozil_meno, Vlozil_dna) values (" & data & ", 0, now(), '" & Ponuka.Meno_uzivatela & "', now());"
                con.Open()
                Dim sql As MySqlCommand = New MySqlCommand(Query, con)
                Try
                    sql.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ETECH - Vloženie záznamov do databázy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End Try
                con.Close()
                DataGridView1.Rows.Remove(DataGridView1.Rows(0))

            End While

            'Vymazanie prveho riadku
            Dim QueryDEL As String
            QueryDEL = "DELETE FROM skumavky_data where stav = 0 limit 1;"
            con.Open()
            Dim sqlDEL As MySqlCommand = New MySqlCommand(QueryDEL, con)
            Try
                sqlDEL.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Vymazanie hlavičky dát z databázy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
            con.Close()

            'Aktivovanie tlacidla VYTLACIT
            b_Vytlacit.Enabled = True
        Else
            MessageBox.Show("Nevybrali ste textový súbor !", "ETECH - Vstupné dáta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Public Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_PridatLekaraVykon.LinkClicked
        Skumavky_pridat.Show()
    End Sub

    Private Sub b_Vytlacit_Click_1(sender As Object, e As EventArgs) Handles b_Vytlacit.Click
        ppd_Skumavky.Document = pd_Skumavky

        ppd_Skumavky.ShowDialog()

    End Sub

    Private Sub pd_Skumavky_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pd_Skumavky.PrintPage

        'Vytiahnutie si dat do hlavicky
        Dim QueryODD As String
        QueryODD = "SELECT distinct(right(kodlekara, 2)), min(left(replace(datumuct, ' ' , ''),10)), max(left(replace(datumuct, ' ', ''), 10)) FROM skumavky_data where stav = 0;"
        con.Open()
        Dim sqlODD As MySqlCommand = New MySqlCommand(QueryODD, con)

        Using odd As MySqlDataReader = sqlODD.ExecuteReader()

            'Vytvorenie tabulky.
            Dim dtOddlenia As New DataTable("Oddelenia")
            Dim ds2 As New DataSet()

            'Nacitanie dat
            dtOddlenia.Load(odd)

            'Pridanie dat do tabulky
            ds2.Tables.Add(dtOddlenia)

            Dim OddText As String = ""

            Select Case ds2.Tables(0).Rows(0).Item(0).ToString
                Case 31
                    OddText = "HTO"
                Case 24
                    OddText = "OKB"
                Case 34
                    OddText = "OKMi"
            End Select

            Dim ObdobieMin As String = ds2.Tables(0).Rows(0).Item(1).ToString
            Dim ObdobieMax As String = ds2.Tables(0).Rows(0).Item(2).ToString

            Dim pFont As Font
            pFont = New Font("Arial Bold", 20)
            e.Graphics.DrawString("Spotreba skumaviek pre vybraných lekárov " & vbCr & "na " & OddText.ToString, pFont, Brushes.Black, 0, 10)
            e.Graphics.DrawString(" za odbobie " & ObdobieMin.ToString & " - " & ObdobieMax.ToString, pFont, Brushes.Black, 20, 40)
        End Using
        con.Close()

        Using cmd As New MySqlCommand("Select sl.Meno_lekara, sl.kod_lekara, sd.kodvykonu, count(pocvykon) FROM `skumavky_data` sd join `skumavky_vykony` sv On sd.kodvykonu = sv.Cislo_vykonu and sv.stav = 0 join `skumavky_lekari` sl On ((sd.kododdodos = sl.Kod_lekara) and (sd.kodpoistodos = sl.Kod_pzs) and sl.stav = 0) where sd.stav = 0 group by sd.kodpoistodos, sd.kododdodos, sd.kodvykonu order by 1;")
            cmd.Connection = con
            con.Open()
            Using sdr As MySqlDataReader = cmd.ExecuteReader()

                'Vytvorenie tabulky
                Dim dtCustomers As New DataTable("Customers")
                Dim ds As New DataSet()

                'Nacitanie dat
                dtCustomers.Load(sdr)

                'Pridanie dat do tabulky
                ds.Tables.Add(dtCustomers)

                Dim i As Integer = 0
                Dim y As Integer = 150

                Dim pZoznam As Font
                pZoznam = New Font("Courier", 12)

                Do Until i = ds.Tables(0).Rows.Count
                    e.Graphics.DrawString(ds.Tables(0).Rows(i).Item(0).ToString, pZoznam, Brushes.Black, 50, y)
                    e.Graphics.DrawString(ds.Tables(0).Rows(i).Item(1).ToString, pZoznam, Brushes.Black, 250, y)
                    e.Graphics.DrawString(ds.Tables(0).Rows(i).Item(2).ToString, pZoznam, Brushes.Black, 400, y)
                    e.Graphics.DrawString(ds.Tables(0).Rows(i).Item(3).ToString, pZoznam, Brushes.Black, 500, y)

                    i = i + 1
                    y = y + 20
                Loop

            End Using
            con.Close()
        End Using
    End Sub
End Class