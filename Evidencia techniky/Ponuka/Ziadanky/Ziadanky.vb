Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie

Public Class Ziadanky

    Public Sub Ziadanky_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)

        dtp_SpracovatDo.Text = Now

        Dim Query As String
        Query = "SELECT Nazov_hodnoty FROM ciselnik_data WHERE stav = 0 AND idciselnik = 8 ;"
        con.Open()
        Dim sql As MySqlCommand = New MySqlCommand(Query, con)
        Try
            Using odd As MySqlDataReader = sql.ExecuteReader()

                'Vytvorenie tabulky.
                Dim dtOddlenia As New DataTable("Oddelenia")
                Dim ds2 As New DataSet()

                'Nacitanie dat
                dtOddlenia.Load(odd)

                'Pridanie dat do tabulky
                ds2.Tables.Add(dtOddlenia)

                Dim i As Integer = 0
                Dim ii As Integer = 0

                Do Until i = ds2.Tables(0).Rows.Count
                    cb_TypPoziadavky.Items.Add(ds2.Tables(0).Rows(i).Item(0))
                    i = i + 1
                Loop

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Zistenie typu požiadavky", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        con.Close()

        Dim QueryPrace As String
        QueryPrace = "SELECT Nazov_hodnoty FROM ciselnik_data WHERE stav = 0 AND idciselnik = 9 ;"
        con.Open()
        Dim sqlPrace As MySqlCommand = New MySqlCommand(QueryPrace, con)
        Try
            Using odd As MySqlDataReader = sqlPrace.ExecuteReader()

                'Vytvorenie tabulky.
                Dim dtOddlenia As New DataTable("Oddelenia")
                Dim ds2 As New DataSet()

                'Nacitanie dat
                dtOddlenia.Load(odd)

                'Pridanie dat do tabulky
                ds2.Tables.Add(dtOddlenia)

                Dim i As Integer = 0
                Dim ii As Integer = 0

                Do Until i = ds2.Tables(0).Rows.Count
                    cb_TypPrace.Items.Add(ds2.Tables(0).Rows(i).Item(0))
                    i = i + 1
                Loop

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Zistenie typu prác", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        con.Close()

        Dim StrSql As String =
        "SELECT odd.Nazov_oddelenia FROM uzivatelia u 
        join uzivatel_x_oddelenie uxo on u.id_uzivatela = uxo.id_uzivatela and uxo.stav = 0
        join oddelenia odd on uxo.id_oddelenia = odd.id_oddelenia and odd.stav = 0
        where u.id_uzivatela = '" & Ponuka.id_uzivatela & "' and u.Zablokovany = 0"
        Dim cmd As New MySqlCommand(StrSql, con)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim dt As New DataTable("Oddelenia")

        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            cb_ZOddelenia.DataSource = dt
            cb_ZOddelenia.DisplayMember = "Nazov_oddelenia" 'What is displayed

        End If

    End Sub

    Private Sub ll_Zoznam_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_Zoznam.LinkClicked
        Ziadanky_zoznam.Show()
    End Sub

    Private Sub cb_Urgentne_Click(sender As Object, e As EventArgs) Handles chb_Urgentne.Click
        MessageBox.Show("Urgencia nie je záväná, iba informatívna", "ETECH - Zadávanie žiadanky", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub b_Zadat_Click(sender As Object, e As EventArgs) Handles b_Zadat.Click

        Dim Urgencia As String = ""
        If chb_Urgentne.Checked = True Then
            Urgencia = 1
        ElseIf chb_Urgentne.Checked = False Then
            Urgencia = 0
        End If

        Dim UlohaCislo As String = Uloha_Cislo() + 1
        If cb_TypPrace.Text <> "" Then
            If rtb_Popis.Text <> "" Then
                If cb_TypPoziadavky.Text <> "" And cb_TypPoziadavky.Text <> "Žiadanka na montáž" Then
                    Dim Query As String
                    Query = "INSERT INTO uloha(Nahlasil_ID_zamestanca, Uloha_cislo, Nahlasene_dna, Typ_poziadavky, Typ_prace, Popis_ulohy, Oddelenie, Miestnost, Odovzdat_do, Urgencia, Vlozil_meno, Vlozil_dna) values ('" & Ponuka.id_uzivatela & "', '" & UlohaCislo & "', now(), (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 8 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_TypPoziadavky.Text & "'), (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 9 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_TypPrace.Text & "'), '" & rtb_Popis.Text & "', '" & oddelenie(cb_ZOddelenia.Text) & "', '" & tb_Miestnost.Text & "', '" & uprava_datumu(dtp_SpracovatDo.Text) & "', '" & Urgencia & "', '" & Ponuka.Meno_uzivatela & "', now());"
                    con.Open()
                    Dim sql As MySqlCommand = New MySqlCommand(Query, con)
                    Try
                        sql.ExecuteNonQuery()
                        con.Close()
                        MessageBox.Show("Požiadavka bola pridaná do systému", "ETECH - Pridanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        logy(6, 1, "")
                        Notifikacia(0, "", 1)
                    Catch ex As Exception
                        con.Close()
                        MessageBox.Show(ex.Message, "ETECH - Pridanie žiadanky do systému", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        logy(6, 2, ex.Message)
                    End Try

                    cb_TypPoziadavky.Text = ""
                    cb_TypPrace.Text = ""
                    rtb_Popis.Text = ""
                    tb_Miestnost.Text = ""
                    chb_Urgentne.Checked = False
                ElseIf cb_TypPoziadavky.Text <> "" And cb_TypPoziadavky.Text = "Žiadanka na montáž" Then

                    Select Case MessageBox.Show("Je daný materiál na sklade ?" & vbCr & "Tel. č. na Sklad MTZ - 258", "ETECH - Materiál na sklade", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        Case MsgBoxResult.No
                            MessageBox.Show("Žiadanka nebola pridaná do systému", "ETECH - Pridanie žiadanky do systému", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case MsgBoxResult.Yes
                            Dim Query As String
                            Query = "INSERT INTO uloha(Nahlasil_ID_zamestanca, Uloha_cislo, Nahlasene_dna, Typ_poziadavky, Typ_prace, Popis_ulohy, Oddelenie, Miestnost, Odovzdat_do, Urgencia, Vlozil_meno, Vlozil_dna) values ('" & Ponuka.id_uzivatela & "', '" & UlohaCislo & "', now(), (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 8 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_TypPoziadavky.Text & "'), (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 9 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_TypPrace.Text & "'), '" & rtb_Popis.Text & "', '" & oddelenie(cb_ZOddelenia.Text) & "', '" & tb_Miestnost.Text & "', '" & dtp_SpracovatDo.Text & "', '" & Urgencia & "', '" & Ponuka.Meno_uzivatela & "', now());"
                            con.Open()
                            Dim sql As MySqlCommand = New MySqlCommand(Query, con)
                            Try
                                sql.ExecuteNonQuery()
                                con.Close()
                                MessageBox.Show("Žiadanka bola pridaná do systému", "ETECH - Pridanie žiadanky do systému", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                logy(6, 1, "")
                                Notifikacia(0, "", 1)
                            Catch ex As Exception
                                con.Close()
                                MessageBox.Show(ex.Message, "ETECH - Pridanie žiadanky do systému", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                logy(6, 2, ex.Message)
                            End Try


                            cb_TypPoziadavky.Text = ""
                            cb_TypPrace.Text = ""
                            rtb_Popis.Text = ""
                            tb_Miestnost.Text = ""
                            chb_Urgentne.Checked = False
                    End Select

                Else
                    MessageBox.Show("Nevyplnil si " & UCase(l_TypPoziadavky.Text), "ETECH - Pridanie žiadanky do systému", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                Else
                MessageBox.Show("Nevyplnil si " & UCase(l_PopisZiadanejPrace.Text), "ETECH - Pridanie žiadanky do systému", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            Else
            MessageBox.Show("Nevyplnil si " & UCase(l_TypPrace.Text), "ETECH - Pridanie žiadanky do systému", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class