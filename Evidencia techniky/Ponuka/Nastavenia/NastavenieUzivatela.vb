Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie

Public Class NastavenieUzivatela

    Dim PIdUzivatela As String
    Dim PMeno As String
    Dim PPriezvisko As String
    Dim POsobneCislo As String
    Dim PUzivatelMeno As String
    Dim PHeslo As String
    Dim PEmail As String
    Dim PTel As String
    Dim POddelenie As String = ""

    Dim PPocitace As String
    Dim PPrace As String
    Dim PZiadanky As String
    Dim PDoprava As String
    Dim PDopravaOdosielatelia As String
    Dim PLabaky As String
    Dim PSkumavky As String

    Dim PZablokovany As String
    Dim PAdmin As String

    Private Sub NastavenieUzivatela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)

        Dim Query As String
        Query = "SELECT Nazov_hodnoty FROM ciselnik_data WHERE stav = 0 AND idciselnik = 1;"
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

                Do Until i = 2
                    cb_Pocitace.Items.Add(ds2.Tables(0).Rows(i).Item(0))
                    cb_Prace.Items.Add(ds2.Tables(0).Rows(i).Item(0))
                    cb_Ziadanky.Items.Add(ds2.Tables(0).Rows(i).Item(0))
                    cb_Doprava.Items.Add(ds2.Tables(0).Rows(i).Item(0))
                    cb_Labaky.Items.Add(ds2.Tables(0).Rows(i).Item(0))
                    i = i + 1
                Loop

                Do Until ii = ds2.Tables(0).Rows.Count
                    cb_DopravaOdosielatelia.Items.Add(ds2.Tables(0).Rows(ii).Item(0))
                    cb_Skumavky.Items.Add(ds2.Tables(0).Rows(ii).Item(0))
                    ii = ii + 1
                Loop

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Zistenie práv pre užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        con.Close()

        con.Open()
        Dim StrSql As String =
        "SELECT odd.Nazov_oddelenia FROM oddelenia odd WHERE stav = 0"
        Dim cmd As New MySqlCommand(StrSql, con)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim dt As New DataTable("Oddelenia")

        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            cb_Oddelenie.DataSource = dt
            cb_Oddelenie.DisplayMember = "Nazov_oddelenia" 'What is displayed

        End If
        con.Close()
    End Sub

    Public Sub b_Vyhladat_Click(sender As Object, e As EventArgs) Handles b_Vyhladat.Click

        If tb_Hladaj.Text = "" Then
            MessageBox.Show("Nezadal si žiadne parametre na vyhľadanie !", "ETECH - Vyhľadanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim username As Boolean = True
            con.Open()
            Dim sqlquery As String = "SELECT * FROM uzivatelia u
            join prava p on u.id_uzivatela = p.id_uzivatela 
            left join uzivatel_x_oddelenie uxo on u.id_uzivatela = uxo.id_uzivatela and uxo.hlavne = 1
            left join oddelenia odd on uxo.id_oddelenia = odd.id_oddelenia
            WHERE (u.UzivatelMeno = '" & tb_Hladaj.Text & "' or u.OsobneCislo = '" & tb_Hladaj.Text & "' or u.Meno = '" & tb_Hladaj.Text & "' or u.Priezvisko = '" & tb_Hladaj.Text & "' or u.Email = '" & tb_Hladaj.Text & "') and u.Vymazal_dna is null"
            Dim data As MySqlDataReader
            Dim adapter As New MySqlDataAdapter
            Dim command As New MySqlCommand
            command.CommandText = sqlquery
            command.Connection = con
            adapter.SelectCommand = command
            data = command.ExecuteReader
            If data.HasRows Then
                While data.Read()
                    PIdUzivatela = data("id_uzivatela").ToString
                    PMeno = data("Meno").ToString
                    PPriezvisko = data("Priezvisko").ToString
                    POsobneCislo = data("OsobneCislo").ToString
                    PUzivatelMeno = data("UzivatelMeno").ToString
                    PHeslo = data("Heslo").ToString
                    PEmail = data("Email").ToString
                    PTel = data("Telefon").ToString
                    POddelenie = data("Nazov_oddelenia").ToString
                    tb_Meno.Text = PMeno
                    tb_Priezvisko.Text = PPriezvisko
                    tb_OsobneCislo.Text = POsobneCislo
                    tb_UzivatelMeno.Text = PUzivatelMeno
                    tb_Heslo.Text = PHeslo
                    tb_Email.Text = PEmail
                    tb_Tel.Text = PTel
                    cb_Oddelenie.Text = POddelenie

                    PZablokovany = data("Zablokovany").ToString
                    PAdmin = data("Admin").ToString

                    If PZablokovany = 1 Then
                        CHB_Zablokovany.Checked = True
                    Else
                        CHB_Zablokovany.Checked = False
                    End If

                    If PAdmin = 1 Then
                        CHB_Admin.Checked = True
                    Else
                        CHB_Admin.Checked = False
                    End If

                    PPocitace = cb_Pocitace.Items(data("Pocitace").ToString)
                    PZiadanky = cb_Ziadanky.Items(data("Ziadanky").ToString)
                    PPrace = cb_Prace.Items(data("Prace").ToString)
                    PDoprava = cb_Doprava.Items(data("Doprava").ToString)
                    PDopravaOdosielatelia = cb_DopravaOdosielatelia.Items(data("DopravaOdosielatelia").ToString)
                    PLabaky = cb_Labaky.Items(data("Labaky").ToString)
                    PSkumavky = cb_Skumavky.Items(data("Skumavky").ToString)


                    cb_Pocitace.Text = PPocitace
                    cb_Ziadanky.Text = PZiadanky
                    cb_Prace.Text = PPrace
                    cb_Doprava.Text = PDoprava
                    cb_DopravaOdosielatelia.Text = PDopravaOdosielatelia
                    cb_Labaky.Text = PLabaky
                    cb_Skumavky.Text = PSkumavky

                End While
                data.Close()
                con.Close()
            Else
                MessageBox.Show("Neboli nájdené žiadne záznamy !", "ETECH - Vyhľadanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                con.Close()
            End If
        End If

        If tb_Hladaj.Text IsNot "" And tb_Meno.Text IsNot "" And tb_Priezvisko.Text IsNot "" And tb_UzivatelMeno.Text IsNot "" And tb_Heslo.Text IsNot "" And tb_Tel.Text IsNot "" And tb_OsobneCislo.Text IsNot "" And cb_Pocitace.Text IsNot "" And cb_Ziadanky.Text IsNot "" And cb_Doprava.Text IsNot "" And cb_DopravaOdosielatelia.Text IsNot "" And cb_Labaky.Text IsNot "" And cb_Skumavky.Text IsNot "" Then
            b_Ulozit.Enabled = True
            b_Vymazat.Enabled = True
            ll_Oddelenia.Visible = True
        End If
    End Sub

    Private Sub cb_Skumavky_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Skumavky.SelectedIndexChanged
        If tb_Hladaj.Text = "" Then
            b_Vytvorit.Enabled = True
        End If
    End Sub

    Private Sub b_Vytvorit_Click(sender As Object, e As EventArgs) Handles b_Vytvorit.Click

        If tb_Meno.Text <> "" Then
            If tb_Priezvisko.Text <> "" Then
                If tb_OsobneCislo.Text <> "" Then
                    If tb_UzivatelMeno.Text <> "" Then
                        If tb_Heslo.Text <> "" Then
                            If cb_Oddelenie.Text <> "" Then
                                If cb_Pocitace.Text <> "" Then
                                    If cb_Prace.Text <> "" Then
                                        If cb_Ziadanky.Text <> "" Then
                                            If cb_Doprava.Text <> "" Then
                                                If cb_DopravaOdosielatelia.Text <> "" Then
                                                    If cb_Labaky.Text <> "" Then
                                                        If cb_Skumavky.Text <> "" Then
                                                            Dim Query As String
                                                            Query = "INSERT INTO uzivatelia(OsobneCislo, Meno, Priezvisko, UzivatelMeno, Heslo, Email, Telefon, Zablokovany, Vlozil_meno, Vlozil_dna) values ('" & tb_OsobneCislo.Text & "', '" & tb_Meno.Text & "', '" & tb_Priezvisko.Text & "', '" & UCase(tb_UzivatelMeno.Text) & "', '" & HashPassword(tb_Heslo.Text) & "', '" & tb_Email.Text & "', '" & tb_Tel.Text & "', 0, '" & Ponuka.Meno_uzivatela & "', now());"
                                                            con.Open()
                                                            Dim sql As MySqlCommand = New MySqlCommand(Query, con)
                                                            Try
                                                                sql.ExecuteNonQuery()
                                                                MessageBox.Show("Užívateľ bol pridaný do systému", "ETECH - Pridanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                                con.Close()
                                                                logy(4, 1, "")
                                                                Notifikacia(1, tb_Email.Text, 2)
                                                            Catch ex As Exception
                                                                MessageBox.Show(ex.Message, "ETECH - Pridanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                                                con.Close()
                                                                logy(4, 2, ex.Message)
                                                            End Try

                                                            Dim Admin As String = ""
                                                            If CHB_Admin.Checked = True Then
                                                                Admin = 1
                                                            ElseIf CHB_Admin.Checked = False Then
                                                                Admin = 0
                                                            End If

                                                            Dim QueryINS As String
                                                            QueryINS = "INSERT INTO prava(id_uzivatela, Admin, Pocitace, Prace, Ziadanky, Doprava, DopravaOdosielatelia, Labaky, Skumavky, Vlozil_meno, Vlozil_dna) values ((Select id_uzivatela from uzivatelia where zablokovany = 0 order by 1 desc limit 1), '" & Admin & "', (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 1 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_Pocitace.Text & "'), (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 1 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_Prace.Text & "'), (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 1 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_Ziadanky.Text & "'), (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 1 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_Doprava.Text & "'), (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 1 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_DopravaOdosielatelia.Text & "'), (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 1 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_Labaky.Text & "'), (select Hodnota from ciselnik_data where stav = 0 and idciselnik = 1 and CONVERT(Nazov_hodnoty USING utf8) = '" & cb_Skumavky.Text & "'), '" & Ponuka.Meno_uzivatela & "', now());"
                                                            con.Open()
                                                            Dim sqlINT As MySqlCommand = New MySqlCommand(QueryINS, con)
                                                            Try
                                                                sqlINT.ExecuteNonQuery()
                                                                MessageBox.Show("Práva boli pridadené k užívateľovi", "ETECH - Pridanie práv", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                            Catch ex As Exception
                                                                MessageBox.Show(ex.Message, "ETECH - Pridanie práv", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                                            End Try
                                                            con.Close()

                                                            Dim QueryODD As String
                                                            QueryODD = "INSERT INTO uzivatel_x_oddelenie(id_uzivatela, id_oddelenia, hlavne, Vlozil_meno, Vlozil_dna) values ((Select id_uzivatela from uzivatelia where zablokovany = 0 order by 1 desc limit 1), '" & oddelenie(cb_Oddelenie.Text) & "', 1, '" & Ponuka.Meno_uzivatela & "', now());"
                                                            con.Open()
                                                            Dim sqlODD As MySqlCommand = New MySqlCommand(QueryODD, con)
                                                            Try
                                                                sqlODD.ExecuteNonQuery()
                                                                MessageBox.Show("Oddelenie bolo pridadené k užívateľovi", "ETECH - Pridanie oddelenia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                            Catch ex As Exception
                                                                MessageBox.Show(ex.Message, "ETECH - Pridanie oddelenia", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                                            End Try
                                                            con.Close()

                                                            tb_Hladaj.Text = ""
                                                            tb_UzivatelMeno.Text = ""
                                                            tb_Priezvisko.Text = ""
                                                            tb_Meno.Text = ""
                                                            tb_Heslo.Text = ""
                                                            tb_Email.Text = ""
                                                            tb_Tel.Text = ""
                                                            tb_OsobneCislo.Text = ""
                                                            cb_Oddelenie.Text = ""
                                                            cb_Pocitace.Text = ""
                                                            cb_Ziadanky.Text = ""
                                                            cb_Prace.Text = ""
                                                            cb_Doprava.Text = ""
                                                            cb_DopravaOdosielatelia.Text = ""
                                                            cb_Labaky.Text = ""
                                                            cb_Skumavky.Text = ""
                                                            CHB_Admin.Checked = False
                                                            CHB_Zablokovany.Checked = False
                                                            b_Vymazat.Enabled = False
                                                            b_Ulozit.Enabled = False
                                                            b_Vytvorit.Enabled = False

                                                        Else
                                                            MessageBox.Show("Nenastavil si práva k: " & UCase(l_Skumavky.Text), "ETECH - Pridanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                                        End If
                                                    Else
                                                        MessageBox.Show("Nenastavil si práva k: " & UCase(l_Labaky.Text), "ETECH - Pridanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                                    End If
                                                Else
                                                    MessageBox.Show("Nenastavil si práva k: " & UCase(l_Doprava_Odosielatelia.Text), "ETECH - Pridanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                                End If
                                            Else
                                                MessageBox.Show("Nenastavil si práva k: " & UCase(l_Doprava.Text), "ETECH - Pridanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                            End If
                                        Else
                                            MessageBox.Show("Nenastavil si práva k: " & UCase(l_Ziadanky.Text), "ETECH - Pridanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        End If
                                    Else
                                        MessageBox.Show("Nenastavil si práva k: " & UCase(l_Prace.Text), "ETECH - Pridanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    End If
                                Else
                                    MessageBox.Show("Nenastavil si práva k: " & UCase(l_Pocitace.Text), "ETECH - Pridanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            Else
                                MessageBox.Show("Nevyplnil si " & UCase(l_Oddelenie.Text), "ETECH - Pridanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        Else
                                MessageBox.Show("Nevyplnil si " & UCase(l_Heslo.Text), "ETECH - Pridanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show("Nevyplnil si " & UCase(l_UzivatelMeno.Text), "ETECH - Pridanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Nevyplnil si " & UCase(l_OsobCislo.Text), "ETECH - Pridanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Nevyplnil si " & UCase(l_Priezvisko.Text), "ETECH - Pridanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Nevyplnil si " & UCase(l_Meno.Text), "ETECH - Pridanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub tb_Hladaj_TextChanged(sender As Object, e As EventArgs) Handles tb_Hladaj.Click
        tb_Hladaj.Text = ""
        tb_UzivatelMeno.Text = ""
        tb_Priezvisko.Text = ""
        tb_Meno.Text = ""
        tb_Heslo.Text = ""
        tb_Email.Text = ""
        tb_Tel.Text = ""
        tb_OsobneCislo.Text = ""
        cb_Oddelenie.Text = ""
        cb_Pocitace.Text = ""
        cb_Ziadanky.Text = ""
        cb_Prace.Text = ""
        cb_Doprava.Text = ""
        cb_DopravaOdosielatelia.Text = ""
        cb_Labaky.Text = ""
        cb_Skumavky.Text = ""
        CHB_Admin.Checked = False
        CHB_Zablokovany.Checked = False
        b_Vymazat.Enabled = False
        b_Ulozit.Enabled = False
        b_Vytvorit.Enabled = False
    End Sub

    Public Sub b_Vymazat_Click(sender As Object, e As EventArgs) Handles b_Vymazat.Click

        Dim result As Integer = MessageBox.Show("Naozaj chceš vymazať užívateľa " & tb_UzivatelMeno.Text & "'?", "ETECH - Vymazanie užívateľa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then
            MessageBox.Show("Užívateľ NEBOL zmazaný", "ETECH - Vymazanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result = DialogResult.Yes Then
            Dim QueryDEL As String
            QueryDEL = "DELETE FROM uzivatelia WHERE id_uzivatela = '" & PIdUzivatela & "';"
            con.Open()
            Dim sqlDEL As MySqlCommand = New MySqlCommand(QueryDEL, con)
            Try
                sqlDEL.ExecuteNonQuery()
                MessageBox.Show("Užívateľa BOL vymazaný!", "ETECH - Vymazanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                logy(5, 1, "")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Vymazanie užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                logy(5, 2, ex.Message)
            End Try
            con.Close()

            tb_Hladaj.Text = ""
            tb_UzivatelMeno.Text = ""
            tb_Priezvisko.Text = ""
            tb_Meno.Text = ""
            tb_Heslo.Text = ""
            tb_Email.Text = ""
            tb_Tel.Text = ""
            tb_OsobneCislo.Text = ""
            cb_Oddelenie.Text = ""

        End If
    End Sub

    Private Sub tb_Heslo_TextChanged(sender As Object, e As EventArgs) Handles tb_Heslo.TextChanged
        If tb_Hladaj.Text Is "" And tb_Meno.Text IsNot "" And tb_Priezvisko.Text IsNot "" And tb_UzivatelMeno.Text IsNot "" And tb_Heslo.Text IsNot "" And tb_OsobneCislo.Text IsNot "" And cb_Pocitace.Text IsNot "" And cb_Ziadanky.Text IsNot "" And cb_Doprava.Text IsNot "" And cb_DopravaOdosielatelia.Text IsNot "" And cb_Labaky.Text IsNot "" And cb_Skumavky.Text IsNot "" Then
            b_Vytvorit.Enabled = True
        End If
    End Sub

    Private Sub b_Ulozit_Click(sender As Object, e As EventArgs) Handles b_Ulozit.Click

        Dim Zablokovany As String = ""
        If CHB_Zablokovany.Checked = True Then
            Zablokovany = 1
        ElseIf CHB_Zablokovany.Checked = False Then
            Zablokovany = 0
        End If

        Dim Admin As String = ""
        If CHB_Admin.Checked = True Then
            Admin = 1
        ElseIf CHB_Admin.Checked = False Then
            Admin = 0
        End If

        If tb_Meno.Text <> PMeno Or tb_Priezvisko.Text <> PPriezvisko Or tb_OsobneCislo.Text <> POsobneCislo Or tb_Heslo.Text <> PHeslo Or tb_UzivatelMeno.Text <> PUzivatelMeno Or cb_Oddelenie.Text <> POddelenie Or tb_Email.Text <> PEmail Or tb_Tel.Text <> PTel Or cb_Pocitace.Text <> PPocitace Or cb_Prace.Text <> PPrace Or cb_Ziadanky.Text <> PZiadanky Or cb_Doprava.Text <> PDoprava Or cb_DopravaOdosielatelia.Text <> PDopravaOdosielatelia Or cb_Labaky.Text <> PLabaky Or cb_Skumavky.Text <> PSkumavky Or Zablokovany <> PZablokovany Or Admin <> PAdmin Then

            If tb_Meno.Text <> PMeno Or tb_Priezvisko.Text <> PPriezvisko Or tb_OsobneCislo.Text <> POsobneCislo Or tb_Heslo.Text <> PHeslo Or tb_UzivatelMeno.Text <> PUzivatelMeno Or tb_Email.Text <> PEmail Or tb_Tel.Text <> PTel Or Zablokovany <> PZablokovany Then

                Dim QueryUZI As String
                QueryUZI = "UPDATE uzivatelia SET OsobneCislo = '" & tb_OsobneCislo.Text & "', Meno = '" & tb_Meno.Text & "', Priezvisko = '" & tb_Priezvisko.Text & "', UzivatelMeno = '" & UCase(tb_UzivatelMeno.Text) & "', Email = '" & tb_Email.Text & "', Telefon = '" & tb_Tel.Text & "', Zablokovany = '" & Zablokovany & "', Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() WHERE id_uzivatela = '" & PIdUzivatela & "';"
                con.Open()
                Dim sqlUZI As MySqlCommand = New MySqlCommand(QueryUZI, con)
                Try
                    sqlUZI.ExecuteNonQuery()
                    MessageBox.Show("Užívateľa BOL upravený!", "ETECH - Zmena v užívateľovi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    logy(12, 1, "")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Zmena v užívateľovi", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    logy(12, 2, ex.Message)
                End Try
                con.Close()
            Else
            End If

            If tb_Heslo.Text <> PHeslo Then
                Dim QueryHES As String
                QueryHES = "UPDATE uzivatelia SET Heslo = '" & HashPassword(tb_Heslo.Text) & "', Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() WHERE id_uzivatela = '" & PIdUzivatela & "';"
                con.Open()
                Dim sqlHES As MySqlCommand = New MySqlCommand(QueryHES, con)
                Try
                    sqlHES.ExecuteNonQuery()
                    logy(1, 1, "Administratorom")
                Catch ex As Exception
                    logy(1, 2, ex.Message)
                End Try
                con.Close()
            Else
            End If

            If cb_Pocitace.Text <> PPocitace Or cb_Prace.Text <> PPrace Or cb_Ziadanky.Text <> PZiadanky Or cb_Doprava.Text <> PDoprava Or cb_DopravaOdosielatelia.Text <> PDopravaOdosielatelia Or cb_Labaky.Text <> PLabaky Or cb_Skumavky.Text <> PSkumavky Or Admin <> PAdmin Then

                Dim QueryPRA As String
                QueryPRA = "UPDATE prava set Admin = '" & Admin & "', Pocitace = '" & cb_Pocitace.SelectedIndex & "', Prace = '" & cb_Prace.SelectedIndex & "', Ziadanky = '" & cb_Ziadanky.SelectedIndex & "', Doprava = '" & cb_Doprava.SelectedIndex & "', DopravaOdosielatelia = '" & cb_DopravaOdosielatelia.SelectedIndex & "', Labaky = '" & cb_Labaky.SelectedIndex & "', Skumavky = '" & cb_Skumavky.SelectedIndex & "', Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() WHERE id_uzivatela = '" & PIdUzivatela & "';"
                con.Open()
                Dim sqlPRA As MySqlCommand = New MySqlCommand(QueryPRA, con)
                Try
                    sqlPRA.ExecuteNonQuery()
                    MessageBox.Show("Práva BOLI upravené!", "ETECH - Zmena práv v užívateľovi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    logy(3, 1, "")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Zmena práv v užívateľovi", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    logy(3, 2, ex.Message)
                End Try
                con.Close()
            Else
            End If

            If cb_Oddelenie.Text <> POddelenie Then

                Dim QueryPRA As String
                QueryPRA = "UPDATE uzivatel_x_oddelenie set id_oddelenia = '" & oddelenie(cb_Oddelenie.Text) & "', Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() WHERE id_uzivatela = '" & PIdUzivatela & "';"
                con.Open()
                Dim sqlPRA As MySqlCommand = New MySqlCommand(QueryPRA, con)
                Try
                    sqlPRA.ExecuteNonQuery()
                    MessageBox.Show("Oddelenie BOLO zmenené!", "ETECH - Zmena oddelenia pri užívateľovi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    con.Close()
                    logy(13, 1, "Administratorom")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Zmena oddelenia pri užívateľovi", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    con.Close()
                    logy(13, 2, ex.Message)
                End Try
            Else
            End If
        Else
            MessageBox.Show("Nezmenil si žiadne údaje, nie je čo meniť!", "ETECH - Zmena údajov v užívateľovi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ll_Oddelenia_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ll_Oddelenia.LinkClicked
        Pridat_oddelenie.Show()
    End Sub
End Class