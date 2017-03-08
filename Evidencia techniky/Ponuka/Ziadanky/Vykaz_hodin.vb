Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Public Class Vykaz_hodin

    Dim Uloha_Cislo As String
    Dim Spracovane As String
    Dim Nazov_oddelenia As String
    Dim PSumarHodin As String
    Private Sub Vykaz_hodin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)

        'Vytiahnutie udajov z databazy k danej ziadanke
        con.Open()
        Dim sqlquery As String =
        "SELECT u.Uloha_cislo, date_format(p.Spracovane, GET_FORMAT(DATE,'EUR')) as Spracovane, odd.Nazov_oddelenia, vh.SumarHodin as 'Sumar Hodin'
        FROM uloha u
        join uloha_x_prace uxp on uxp.id_uloha = u.id_ulohy and uxp.stav = 0
        join prace p on uxp.id_prace = p.ID_prace and p.stav = 0
        left join vykazhodin vh on vh.id_ulohy = u.id_ulohy and vh.stav = 0
        join oddelenia odd on odd.id_oddelenia = u.Oddelenie and odd.stav = 0
        WHERE u.id_ulohy = '" & Ziadanky_sprava.id_ulohy & "' and u.stav = 0"
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
                    Uloha_Cislo = data("Uloha_cislo").ToString
                    Spracovane = data("Spracovane").ToString
                    Nazov_oddelenia = data("Nazov_oddelenia").ToString
                    PSumarHodin = data("Sumar Hodin").ToString
                    If PSumarHodin <> "" Then
                        l_PSumarHodin.Visible = True
                        tb_SumarHodin.Visible = False
                        l_PSumarHodin.Text = PSumarHodin
                        tb_SumarHodin.Text = PSumarHodin
                    End If
                    l_PCisloZiadanky.Text = Uloha_Cislo
                    l_PDatum.Text = Spracovane
                    cb_POddelenie.Text = Nazov_oddelenia

                End While
                data.Close()
            End If
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Údaje k žiadanke", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        Dim QueryOddelenia As String
        QueryOddelenia =
        "SELECT odd.Nazov_oddelenia FROM uzivatelia u 
        left join uzivatel_x_oddelenie uxo on u.id_uzivatela = uxo.id_uzivatela and uxo.stav = 0
        left join oddelenia odd on uxo.id_oddelenia = odd.id_oddelenia and odd.stav = 0
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
                    cb_POddelenie.Items.Add(ds2.Tables(0).Rows(i).Item(0))
                    i = i + 1
                Loop

            End Using

            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Zoznam oddelení ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        If Ponuka.ZiadankySprava = 2 Then
            b_Pridat.Visible = True
            b_Ulozit.Enabled = True
            tb_SumarHodin.Visible = True
            l_PSumarHodin.Visible = False
        Else
        End If

        If Ponuka.ZiadankySprava = 4 Then
            b_Pridat.Visible = True
            b_Ulozit.Enabled = True
            tb_SumarHodin.Visible = True
            l_PSumarHodin.Visible = False
            cb_POddelenie.Enabled = True
        Else
        End If

        Dim g As System.Drawing.Graphics = cb_POddelenie.CreateGraphics
        Dim maxWidth As Double = 0.0F
        For Each o As Object In cb_POddelenie.Items
            Dim w As Double = g.MeasureString(o.ToString(), cb_POddelenie.Font).Width
            If (w > maxWidth) Then
                maxWidth = w
            End If
        Next

        g.Dispose()
        cb_POddelenie.DropDownWidth = maxWidth
        cb_POddelenie.Width = cb_POddelenie.CreateGraphics.MeasureString(cb_POddelenie.Text.ToString(), cb_POddelenie.Font).Width + 15

        If cb_POddelenie.Location.X + cb_POddelenie.Size.Width > 297 Then
            tb_SumarHodin.Location = New Size(cb_POddelenie.Location.X + cb_POddelenie.Size.Width + 20, tb_SumarHodin.Location.Y)
            l_PSumarHodin.Location = New Size(cb_POddelenie.Location.X + cb_POddelenie.Size.Width + 20, l_PSumarHodin.Location.Y)
            l_Sumar_hodín.Location = New Size(cb_POddelenie.Location.X + cb_POddelenie.Size.Width + 20, l_Sumar_hodín.Location.Y)
        End If

        If tb_SumarHodin.Visible = True Then
            gb_VykazaneHodiny.Size = New Size(l_Sumar_hodín.Location.X + l_Sumar_hodín.Size.Width + 20, gb_VykazaneHodiny.Size.Height)
            Me.Size = New Size(gb_VykazaneHodiny.Location.X + gb_VykazaneHodiny.Size.Width + 30, Me.Size.Height)
        End If

    End Sub

    Private Sub b_Ulozit_Click(sender As Object, e As EventArgs) Handles b_Ulozit.Click

        If tb_SumarHodin.Text <> PSumarHodin And PSumarHodin = "" Then
            'Zapis vykazanych hodin do databazy
            Dim QueryPC As String
            QueryPC = "INSERT INTO vykazhodin(id_ulohy, id_oddelenie, SumarHodin, Vlozil_meno, Vlozil_dna) VALUES ('" & Ziadanky_sprava.id_ulohy & "', '" & oddelenie(cb_POddelenie.Text) & "', '" & tb_SumarHodin.Text & "', '" & Ponuka.Meno_uzivatela & "', now());"
            con.Open()
            Dim sqlPC As MySqlCommand = New MySqlCommand(QueryPC, con)
            Try
                sqlPC.ExecuteNonQuery()
                MessageBox.Show("Hodiny BOLI vložené!", "ETECH - Zápis vykazaných hodín do databázy", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Zápis vykazaných hodín do databázy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                con.Close()
            End Try
        ElseIf tb_SumarHodin.Text <> PSumarHodin And PSumarHodin <> "" Then
            Dim QueryPC As String
            QueryPC = "UPDATE vykazhodin SET SumarHodin = '" & tb_SumarHodin.Text & "', Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() WHERE id_ulohy = '" & Ziadanky_sprava.id_ulohy & "';"
            con.Open()
            Dim sqlPC As MySqlCommand = New MySqlCommand(QueryPC, con)
            Try
                sqlPC.ExecuteNonQuery()
                MessageBox.Show("Hodiny BOLI upravené!", "ETECH - Úprava vykazaných hodín do databázy", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Úprava vykazaných hodín do databázy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                con.Close()
            End Try
        Else
            MessageBox.Show("Nič sa nezmenilo!", "ETECH - Zmena vykazaných hodín do databázy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub b_Pridat_Click(sender As Object, e As EventArgs) Handles b_Pridat.Click
        Dim QueryPC As String
        QueryPC = "INSERT INTO vykazhodin(id_ulohy, id_oddelenie, SumarHodin, Vlozil_meno, Vlozil_dna) VALUES ('" & Ziadanky_sprava.id_ulohy & "', '" & oddelenie(cb_POddelenie.Text) & "', '" & tb_SumarHodin.Text & "', '" & Ponuka.Meno_uzivatela & "', now());"
        con.Open()
        Dim sqlPC As MySqlCommand = New MySqlCommand(QueryPC, con)
        Try
            sqlPC.ExecuteNonQuery()
            MessageBox.Show("Hodiny BOLI vložené!", "ETECH - Zápis vykazaných hodín do databázy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Zápis vykazaných hodín do databázy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            con.Close()
        End Try
    End Sub
End Class