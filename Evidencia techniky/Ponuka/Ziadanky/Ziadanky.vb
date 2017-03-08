﻿Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie

Public Class Ziadanky
    Public Shared UlohaCislo As String
    Public Sub Ziadanky_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, UCase(Ponuka.Meno_uzivatela))

        cb_TypPoziadavky.Text = ""
        cb_TypPrace.Text = ""
        rtb_Popis.Text = ""
        tb_Miestnost.Text = ""
        chb_Urgentne.Checked = False
        chb_Zeny.Checked = False
        chb_Muzi.Checked = False

        dtp_SpracovatDo.Text = Now

        If Ponuka.ZiadankySprava = 4 Then
            ll_PridatOdd.Visible = True
            cb_TypUlohy.Visible = True
            l_TypUlohy.Visible = True
        End If

        cb_TypPoziadavky.Items.Clear()

        Dim Query As String
        Query = "SELECT Nazov_hodnoty FROM ciselnik_data WHERE stav = 0 AND idciselnik = 8;"
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

        cb_TypPrace.Items.Clear()

        Dim QueryPrace As String
        QueryPrace = "SELECT Nazov_hodnoty FROM ciselnik_data WHERE stav = 0 AND idciselnik = 9;"
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

        cb_TypUlohy.Items.Clear()

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

        cb_TypUlohy.SelectedIndex = 0
    End Sub

    Private Sub ll_Zoznam_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_Zoznam.LinkClicked
        Ziadanky_zoznam.Show()
    End Sub

    Private Sub cb_Urgentne_Click(sender As Object, e As EventArgs) Handles chb_Urgentne.Click
        MessageBox.Show("Urgencia nie je záväná, iba informatívna", "ETECH - Zadávanie žiadanky", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub b_Zadat_Click(sender As Object, e As EventArgs) Handles b_Zadat.Click

        Dim Urgencia As String = ""
        If chb_Urgentne.Checked = True Then
            Urgencia = 1
        ElseIf chb_Urgentne.Checked = False Then
            Urgencia = 0
        End If

        Dim Cast As String = ""
        If chb_Zeny.Checked = True And chb_Muzi.Checked = True Then
            Cast = "Muži, Ženy"
        ElseIf chb_Zeny.Checked = True And chb_Muzi.Checked = False Then
            Cast = "Ženy"
        ElseIf chb_Muzi.Checked = True And chb_Zeny.Checked = False Then
            Cast = "Muži"
        End If

        Dim UlohaCislo As String = Uloha_Cislo(cb_TypUlohy.SelectedIndex.ToString) + 1
        If cb_TypPrace.Text <> "" Then
            If rtb_Popis.Text <> "" Then
                If cb_TypPoziadavky.Text <> "" And cb_TypPoziadavky.Text <> "Žiadanka na montáž" Then
                    Dim Query As String
                    Query = "INSERT INTO uloha(Nahlasil_ID_zamestanca, Uloha_cislo, Nahlasene_dna, Typ_poziadavky, Typ_prace, Popis_ulohy, Oddelenie, Cast, Miestnost, Odovzdat_do, Typ_ulohy, Urgencia, Vlozil_meno, Vlozil_dna) values ('" & Ponuka.id_uzivatela & "', '" & UlohaCislo & "', now(), (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 8 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_TypPoziadavky.Text & "'), (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 9 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_TypPrace.Text & "'), '" & rtb_Popis.Text & "', '" & oddelenie(cb_ZOddelenia.Text) & "', '" & Cast & "', '" & tb_Miestnost.Text & "', '" & uprava_datumu(dtp_SpracovatDo.Text) & "', (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 10 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_TypUlohy.Text & "'), '" & Urgencia & "', '" & UCase(Ponuka.Meno_uzivatela) & "', now());"
                    con.Open()
                    Dim sql As MySqlCommand = New MySqlCommand(Query, con)
                    Try
                        sql.ExecuteNonQuery()
                        con.Close()
                        MessageBox.Show("Požiadavka bola pridaná do systému", "ETECH - Pridanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        logy(6, 1, "")
                        con.Close()
                        Notifikacia(0, "", 1)
                        con.Close()
                    Catch ex As Exception
                        con.Close()
                        MessageBox.Show(ex.Message, "ETECH - Pridanie žiadanky do systému", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        logy(6, 2, ex.Message)
                        con.Close()
                    End Try
                    con.Close()

                    cb_TypPoziadavky.Text = ""
                    cb_TypPrace.Text = ""
                    rtb_Popis.Text = ""
                    tb_Miestnost.Text = ""
                    chb_Urgentne.Checked = False
                    chb_Zeny.Checked = False
                    chb_Muzi.Checked = False
                ElseIf cb_TypPoziadavky.Text <> "" And cb_TypPoziadavky.Text = "Žiadanka na montáž" Then

                    Select Case MessageBox.Show("Je daný materiál na sklade ?" & vbCr & "Tel. č. na Sklad MTZ - 258", "ETECH - Materiál na sklade", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        Case MsgBoxResult.No
                            MessageBox.Show("Žiadanka nebola pridaná do systému", "ETECH - Pridanie žiadanky do systému", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case MsgBoxResult.Yes
                            Dim Query As String
                            Query = "INSERT INTO uloha(Nahlasil_ID_zamestanca, Uloha_cislo, Nahlasene_dna, Typ_poziadavky, Typ_prace, Popis_ulohy, Oddelenie, Miestnost, Odovzdat_do, Typ_ulohy, Urgencia, Vlozil_meno, Vlozil_dna) values ('" & Ponuka.id_uzivatela & "', '" & UlohaCislo & "', now(), (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 8 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_TypPoziadavky.Text & "'), (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 9 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_TypPrace.Text & "'), '" & rtb_Popis.Text & "', '" & oddelenie(cb_ZOddelenia.Text) & "', '" & tb_Miestnost.Text & "', '" & dtp_SpracovatDo.Text & "', (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 10 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_TypUlohy.Text & "'), '" & Urgencia & "', '" & UCase(Ponuka.Meno_uzivatela) & "', now());"
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
                                con.Close()
                            End Try
                            con.Close()

                            cb_TypPoziadavky.Text = ""
                            cb_TypPrace.Text = ""
                            rtb_Popis.Text = ""
                            tb_Miestnost.Text = ""
                            chb_Urgentne.Checked = False
                            chb_Zeny.Checked = False
                            chb_Muzi.Checked = False

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

    Private Sub ll_PridatOdd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_PridatOdd.LinkClicked
        Pridat_oddelenie.Show()
    End Sub

    Private Sub Ziadanky_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            Ziadanky_Load(sender, e)
        End If
    End Sub

End Class