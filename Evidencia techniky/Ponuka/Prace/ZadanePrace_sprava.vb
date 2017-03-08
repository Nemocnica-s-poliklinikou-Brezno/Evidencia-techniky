Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Imports Evidencia_techniky.Zoznam_zadanych_prac
Public Class ZadanePrace_sprava

    Public Shared id_prace
    Public Shared PPracaCislo As String

    Dim PPrijatedna As String
    Dim POdovzdatDo As String
    Dim PSpracovane As String
    Dim PTypPrace As String
    Dim PStavPrace As String
    Dim PPopisPrace As String
    Dim PPriradene As String
    Dim PPracaCislo2 As String

    Public Sub ZadanePrace_sprava_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, UCase(Ponuka.Meno_uzivatela))

        If Ponuka.PraceSprava = 4 Then
            cb_DruhPrace.Enabled = True
            cb_StavPrace.Enabled = True
            cb_Priradene.Enabled = True
            rtb_PopisPrace.Enabled = True
            dtp_Spracovane.Enabled = True
            b_Ulozit.Enabled = True
            b_Spracovane.Enabled = True
            b_Kopiruj.Visible = True
            l_Vymazat.Visible = True
        End If


        con.Open()
        Dim sqlquery As String =
        "SELECT p.ID_prace, CONCAT_WS('', cd2.Popis, p.Cislo_prace) as 'Cislo_prace', p.Cislo_prace as 'Cislo_prace2', date_format(p.Prijate, GET_FORMAT(DATE,'EUR')) as 'Datum zadania prace', date_format(p.Odovzdat_do, GET_FORMAT(DATE,'EUR')) as 'Odovzdat pracu do', date_format(p.Spracovane, GET_FORMAT(DATE,'EUR')) as 'Praca spracovana', cd2.Nazov_hodnoty as Typ_prace, cd4.Nazov_hodnoty as Stav_prace, p.Popis_prace, CONCAT_WS(' ', uz.Priezvisko, uz.meno) as 'Priradene'
        FROM prace p
        join ciselnik_data cd2 on p.Druh_prace = cd2.Hodnota and cd2.idciselnik = 9 and cd2.stav in (0, 1)
        join ciselnik_data cd4 on p.stav_prace = cd4.Hodnota and cd4.idciselnik = 11 and cd4.stav in (0, 1)
        left join prace_x_uzivatel pxu on p.ID_prace = pxu.id_prace
        left join uzivatelia uz on pxu.id_uzivatela = uz.id_uzivatela
        WHERE p.id_prace = '" & Zoznam_zadanych_prac.id_prace & "' and p.stav = 0"
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
                    id_prace = data("id_prace").ToString
                    PPracaCislo = data("Cislo_prace").ToString
                    PPracaCislo2 = data("Cislo_prace2").ToString
                    PPrijatedna = data("Datum zadania prace").ToString
                    POdovzdatDo = data("Odovzdat pracu do").ToString
                    PSpracovane = data("Praca spracovana").ToString
                    PTypPrace = data("Typ_prace").ToString
                    PStavPrace = data("Stav_prace").ToString
                    PPopisPrace = data("Popis_prace").ToString
                    PPriradene = data("Priradene").ToString

                    l_PPracaCislo.Text = PPracaCislo
                    l_PDatumZadania.Text = PPrijatedna
                    cb_DruhPrace.Text = PTypPrace
                    dtp_OdovzdatDo.Text = POdovzdatDo
                    cb_StavPrace.Text = PStavPrace
                    rtb_PopisPrace.Text = PPopisPrace
                    cb_Priradene.Text = PPriradene

                    If PSpracovane = "" Then
                        dtp_Spracovane.Visible = False
                        b_Spracovane.Visible = True
                    ElseIf PSpracovane <> "" Then
                        dtp_Spracovane.Text = PSpracovane
                    End If

                End While
                data.Close()
            End If
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Vytiahnutie údajov ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        'Vytiahnutie udajov z ciselnika -- TYP PRÁCE
        Dim QueryPrace As String
        QueryPrace =
        "SELECT cd.Nazov_hodnoty FROM uloha_x_uzivatel uxu
        join ciselnik_data cd on uxu.hodnota = cd.hodnota and uxu.idciselnik = cd.idciselnik and cd.stav in (0, 1)
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
                    cb_DruhPrace.Items.Add(ds2.Tables(0).Rows(i).Item(0))
                    i = i + 1
                Loop

            End Using
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Zistenie typov prác", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        'Vytiahnutie udajov z ciselnika -- STAV ULOHY
        Dim QueryStavUloh As String
        QueryStavUloh =
        "SELECT cd.Nazov_hodnoty FROM uloha_x_uzivatel uxu
        join ciselnik_data cd on uxu.hodnota = cd.hodnota and uxu.idciselnik = cd.idciselnik and cd.stav in (0, 1)
        where uxu.id_uzivatela = '" & Ponuka.id_uzivatela & "' and uxu.idciselnik = 11 and uxu.Hodnota in (0, 1, 2, 6) and uxu.stav = 0;"
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
                    cb_StavPrace.Items.Add(ds4.Tables(0).Rows(i).Item(0))
                    i = i + 1
                Loop

            End Using
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Zistenie stavov úloh", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        'Vytiahnutie pracovnikov na danu pracu
        Dim QueryPriradene As String
        QueryPriradene =
        "SELECT CONCAT_WS(' ', uz.Priezvisko, uz.Meno) FROM uzivatel_x_prace uxp
        join uzivatelia uz on uxp.id_uzivatela = uz.id_uzivatela and zablokovany = 0
        where uxp.id_prace = '" & ciselnik(1, 9, cb_DruhPrace.Text) & "' and uxp.id_uzivatela != '" & Ponuka.id_uzivatela & "' and uxp.stav = 0;"
        con.Open()
        Dim sqlPriradene As MySqlCommand = New MySqlCommand(QueryPriradene, con)
        Try
            Using odd As MySqlDataReader = sqlPriradene.ExecuteReader()

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

    Private Sub b_Ulozit_Click(sender As Object, e As EventArgs) Handles b_Ulozit.Click

        Dim QueryPrace As String
        QueryPrace = "UPDATE prace SET Odovzdat_do = '" & uprava_datumu(dtp_OdovzdatDo.Text) & "', Druh_prace = (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 9 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_DruhPrace.Text & "'), Popis_prace = '" & rtb_PopisPrace.Text & "', Stav_prace = (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 11 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_StavPrace.Text & "'), Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() WHERE id_prace = '" & Zoznam_zadanych_prac.id_prace & "';"
        con.Open()
        Dim sqlPrace As MySqlCommand = New MySqlCommand(QueryPrace, con)
        Try
            sqlPrace.ExecuteNonQuery()
            con.Close()
            logy(11, 1, "")
            MessageBox.Show("Údaje BOLI upravené!", "ETECH - Zmena údajov v prácach", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            con.Close()
            logy(11, 2, ex.Message)
            MessageBox.Show(ex.Message, "Zmena údajov v prácach", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        If PSpracovane <> "" Then
            Dim QuerySpracovane As String
            QuerySpracovane = "UPDATE prace SET Spracovane = '" & uprava_datumu(Now) & "', Upravil_dna = now() WHERE id_prace = '" & Zoznam_zadanych_prac.id_prace & "';"
            con.Open()
            Dim sqlSpracovane As MySqlCommand = New MySqlCommand(QuerySpracovane, con)
            Try
                sqlSpracovane.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                con.Close()
                logy(11, 2, ex.Message)
                MessageBox.Show(ex.Message, "Zmena údajov v prácach", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If

        Dim QueryUzivatel As String
        QueryUzivatel = "UPDATE prace_x_uzivatel SET id_uzivatela = '" & uzivatel(cb_Priradene.Text) & "', Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() WHERE id_prace = '" & Zoznam_zadanych_prac.id_prace & "' and id_uzivatela = '" & PPriradene & "';"
        con.Open()
        Dim sqlUzivatel As MySqlCommand = New MySqlCommand(QueryUzivatel, con)
        Try
            sqlUzivatel.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            con.Close()
            logy(11, 2, ex.Message)
            MessageBox.Show(ex.Message, "Zmena údajov v prace_x_uzivatel", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    Private Sub b_Spracovane_Click(sender As Object, e As EventArgs) Handles b_Spracovane.Click
        Dim QueryPrace As String
        QueryPrace = "UPDATE prace SET Spracovane = '" & uprava_datumu(Now) & "', Upravil_dna = now() WHERE id_prace = '" & Zoznam_zadanych_prac.id_prace & "';"
        con.Open()
        Dim sqlPrace As MySqlCommand = New MySqlCommand(QueryPrace, con)
        Try
            sqlPrace.ExecuteNonQuery()
            con.Close()
            logy(11, 1, "")
            MessageBox.Show("Práca BOLA spracovaná!", "ETECH - Zmena údajov v prácach", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            con.Close()
            logy(11, 2, ex.Message)
            MessageBox.Show(ex.Message, "Zmena údajov v prácach", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        b_Spracovane.Visible = False
        dtp_Spracovane.Visible = True
    End Sub

    Private Sub b_Kopiruj_Click(sender As Object, e As EventArgs) Handles b_Kopiruj.Click

        Dim QueryPriradenie As String
        QueryPriradenie = "INSERT INTO prace_x_uzivatel(id_prace, id_uzivatela, stav, Vlozil_meno, Vlozil_dna) VALUES ('" & Zoznam_zadanych_prac.id_prace & "','" & uzivatel(cb_Priradene.Text) & "', 0, '" & Ponuka.Meno_uzivatela & "', now());"
        con.Open()
        Dim sqlPriradenie As MySqlCommand = New MySqlCommand(QueryPriradenie, con)
        Try
            sqlPriradenie.ExecuteNonQuery()
            con.Close()
            logy(20, 1, "")
            MessageBox.Show("Práca BOLA skopírovaná!", "ETECH - Pridelenie užívateľa k práci", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            con.Close()
            logy(20, 2, ex.Message)
            MessageBox.Show(ex.Message, "Pridelenie užívateľa k práci", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub l_Vymazat_Click(sender As Object, e As EventArgs) Handles l_Vymazat.Click
        Select Case MessageBox.Show("Naozaj chceš vymazať prácu ?", "ETECH - Vymazanie práce", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Case MsgBoxResult.No
                MessageBox.Show("Nevadí nič sa nestalo.", "ETECH - Vymazanie práce", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Case MsgBoxResult.Yes
                Dim QueryMazanie As String
                QueryMazanie = "UPDATE prace SET stav = 2, Upravil_meno = '" & UCase(Ponuka.Meno_uzivatela) & "', Upravil_dna = now() WHERE ID_prace = '" & Zoznam_zadanych_prac.id_prace & "';"
                con.Open()
                Dim sqlMazanie As MySqlCommand = New MySqlCommand(QueryMazanie, con)
                Try
                    sqlMazanie.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Práca bola vymazaná!", "ETECH - Vymazanie práce", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    logy(22, 1, "")
                Catch ex As Exception
                    con.Close()
                    MessageBox.Show(ex.Message, "ETECH - Vymazanie práce", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    logy(22, 2, ex.Message)
                End Try
        End Select
    End Sub
End Class