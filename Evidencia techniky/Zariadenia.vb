Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenieTest
Public Class Zariadenia

    Public Shared id_zariadenia As String
    Dim PVyrobca As String
    Dim PModel As String
    Dim PSerioveCislo As String
    Dim PVyrobneCislo As String
    Dim PEvidencneCislo As String

    Public Sub Zariadenia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)

        l_p_Teamviewer.Text = ""

    End Sub

    Private Sub tb_Vyhladaj_Click(sender As Object, e As EventArgs) Handles tb_Vyhladat.Click

        tb_Vyhladat.Text = ""

        tb_Vyrobca.Text = ""
        tb_Model.Text = ""
        tb_SerioveCislo.Text = ""
        tb_VyrobneCislo.Text = ""
        tb_EvidencneCislo.Text = ""
        l_p_Teamviewer.Text = ""
        DataGridView2.Rows.Clear()

        dtp_Vyradeny.Visible = False

        b_Fakturacne.Enabled = False
        b_Hardware.Enabled = False
        b_Presun.Enabled = False
        b_Servis.Enabled = False
        b_Software.Enabled = False
        b_Zmenit.Enabled = False

    End Sub

    Public Sub b_Vyhladat_Click(sender As Object, e As EventArgs) Handles b_Vyhladat.Click
        b_Zmenit.Enabled = False
        b_Vytvorit.Enabled = False

        If tb_Vyhladat.Text = "" Then
            MessageBox.Show("Neboli zadané žiadne parametre na vyhľadanie !", "ETECH - Vyhľadanie v databáze", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            con.Close()
        Else
            id_zariadenia = 0
            Dim sqlquery As String = "SELECT * from ZARIADENIA where (Evidencne_cislo like '" & "%" & tb_Vyhladat.Text & "%" & "' or Seriove_cislo like '" & "%" & tb_Vyhladat.Text & "%" & "' or Vyrobne_cislo like '" & "%" & tb_Vyhladat.Text & "%" & "') and stav = 0"
            Dim data As MySqlDataReader
            Dim adapter As New MySqlDataAdapter
            Dim command As New MySqlCommand

            command.CommandText = sqlquery
            command.Connection = con
            adapter.SelectCommand = command

            con.Open()
            data = command.ExecuteReader

            If data.HasRows Then
                While data.Read()

                    PVyrobca = data("Vyrobca").ToString
                    PModel = data("Model").ToString
                    PSerioveCislo = data("Seriove_cislo").ToString
                    PVyrobneCislo = data("Vyrobne_cislo").ToString
                    PEvidencneCislo = data("Evidencne_cislo").ToString
                    If data("Vyradeny_dna").ToString <> "" Then
                        dtp_Vyradeny.Visible = True
                        dtp_Vyradeny.Text = data("Vyradeny_dna").ToString
                    End If

                    id_zariadenia = data("id_zariadenia").ToString
                    tb_Vyrobca.Text = PVyrobca
                    tb_Model.Text = PModel
                    tb_SerioveCislo.Text = PSerioveCislo
                    tb_VyrobneCislo.Text = PVyrobneCislo
                    tb_EvidencneCislo.Text = PEvidencneCislo
                    If data("Vyradeny_dna").ToString <> "" Then
                        dtp_Vyradeny.Visible = True
                        dtp_Vyradeny.Text = data("Vyradeny_dna").ToString
                    End If

                End While
                con.Close()
            End If

            data.Close()
            con.Close()


            Using cmd As New MySqlCommand("SELECT pxo.Presunute_dna, o.Nazov_oddelenia, pxo.Miestnost from zariadenia_x_oddelenie pxo join oddelenia o on o.id_oddelenia = pxo.id_oddelenia where id_zariadenia = " & id_zariadenia & " and pxo.stav in (0, 1) order by pxo.Vlozil_dna desc limit 5;")

                cmd.Connection = con
                cmd.CommandTimeout = 1200

                con.Open()
                Using sdr As MySqlDataReader = cmd.ExecuteReader()

                    If sdr.HasRows Then

                        'Vytvorenie tabulky
                        Dim dtCustomers As New DataTable("Customers")
                        Dim ds As New DataSet()

                        'Nacitanie dat
                        dtCustomers.Load(sdr)

                        'Pridanie dat do tabulky
                        ds.Tables.Add(dtCustomers)

                        Dim i As Integer = 0

                        Do Until i = ds.Tables(0).Rows.Count
                            DataGridView2.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString)
                            i = i + 1
                        Loop

                        b_Servis.Enabled = True
                        b_Presun.Enabled = True
                        con.Close()
                    Else
                        MessageBox.Show("Neboli nájdené žiadne záznamy !", "ETECH - Vyhľadanie v databáze", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        con.Close()
                    End If
                End Using
            End Using
        End If

        b_Zmenit.Enabled = True

    End Sub

    Public Sub b_Presun_Click(sender As Object, e As EventArgs) Handles b_Presun.Click
        ZariadeniaPresunVloz.Show()
    End Sub

    Private Sub b_Servis_Click(sender As Object, e As EventArgs) Handles b_Servis.Click
        ZariadeniaServisVloz.Show()
    End Sub

    Private Sub b_Zmenit_Click(sender As Object, e As EventArgs) Handles b_Zmenit.Click
        If PVyrobca <> tb_Vyrobca.Text Or PModel <> tb_Model.Text Or PSerioveCislo <> tb_SerioveCislo.Text Or PVyrobneCislo <> tb_VyrobneCislo.Text Or PEvidencneCislo <> tb_EvidencneCislo.Text Then
            Dim QueryPC As String
            QueryPC = "UPDATE ZARIADENIA SET Evidencne_cislo = '" & tb_EvidencneCislo.Text & "', Seriove_cislo = '" & tb_SerioveCislo.Text & "', Vyrobne_cislo = '" & tb_VyrobneCislo.Text & "', Vyrobca = '" & tb_Vyrobca.Text & "', Model = '" & tb_Model.Text & "', Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() WHERE id_zariadenia = '" & id_zariadenia & "';"
            con.Open()
            Dim sqlPC As MySqlCommand = New MySqlCommand(QueryPC, con)
            Try
                sqlPC.ExecuteNonQuery()
                MessageBox.Show("Údaje BOLI upravené!", "ETECH - Zmena údajov", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Zmena údajov", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                con.Close()
            End Try
        Else
            MessageBox.Show("Nezmenil si žiadne údaje, nie je čo meniť!", "ETECH - Zmena údajov", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
        End If
    End Sub

    Private Sub b_Vytvorit_Click(sender As Object, e As EventArgs) Handles b_Vytvorit.Click
        Dim QueryPC As String
        QueryPC = "INSERT INTO ZARIADENIA(Evidencne_cislo, Seriove_cislo, Vyrobne_cislo, Vyrobca, Model, Vlozil_meno, Vlozil_dna) VALUES ('" & tb_EvidencneCislo.Text & "', '" & tb_SerioveCislo.Text & "', '" & tb_VyrobneCislo.Text & "', '" & tb_Vyrobca.Text & "', '" & tb_Model.Text & "', '" & Ponuka.Meno_uzivatela & "', now());"
        con.Open()
        Dim sqlPC As MySqlCommand = New MySqlCommand(QueryPC, con)
        Try
            sqlPC.ExecuteNonQuery()
            MessageBox.Show("Údaje BOLI vložené!", "ETECH - Zápis do databázy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Zápis do databázy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            con.Close()
        End Try
    End Sub

    Private Sub tb_EvidencneCislo_TextChanged(sender As Object, e As EventArgs) Handles tb_EvidencneCislo.TextChanged
        If tb_Vyhladat.Text = "" Then
            b_Vytvorit.Enabled = True
        End If
    End Sub

End Class