Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Public Class Vykaz_materialu
    Private Sub Vykaz_materialu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, UCase(Ponuka.Meno_uzivatela))

        If Ponuka.ZiadankySprava = 1 Then
            b_Ulozit.Enabled = True
            b_Kopiruj.Visible = True
        End If

        Using cmd As New MySqlCommand("SELECT date_format(datum, GET_FORMAT(DATE,'EUR')) as 'Dátum', Cislo_ziadanky, Cislo_vydajky, Kusy, Nazov_materialu FROM vykazmaterialu WHERE Cislo_ziadanky = '" & Ziadanky_zoznam.Poziadavka_cislo & "';")
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

                Dim i As Integer = 0

                Do Until i = ds.Tables(0).Rows.Count
                    dgv_VykazMaterialu.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString)
                    i = i + 1
                Loop
            End Using
            Spracovanie_dat.Close()
            con.Close()
        End Using

        dgv_VykazMaterialu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        If dgv_VykazMaterialu.Rows.Count = 1 Then
            Dim n As Integer = dgv_VykazMaterialu.Rows.Add()
            dgv_VykazMaterialu.Rows.Item(n).Cells(0).Value = Now
            dgv_VykazMaterialu.Rows.Item(n).Cells(1).Value = Ziadanky_zoznam.Poziadavka_cislo
            dgv_VykazMaterialu.Rows.Item(n).Cells(2).Value = ""
            dgv_VykazMaterialu.Rows.Item(n).Cells(3).Value = ""
            dgv_VykazMaterialu.Rows.Item(n).Cells(4).Value = ""
        End If

        If dgv_VykazMaterialu.Rows.Item(0).Cells(4).Value <> "" Then
            b_Ulozit.Enabled = False
            b_Kopiruj.Enabled = False
            dgv_VykazMaterialu.ReadOnly = True
        End If
    End Sub

    Public Sub b_Ulozit_Click(sender As Object, e As EventArgs) Handles b_Ulozit.Click

        Dim i As Integer = 0
        Do
            Dim Query As String
            Query = "INSERT INTO vykazmaterialu(Datum, Cislo_ziadanky, Cislo_vydajky, Kusy, Nazov_materialu, stav, Vlozil_meno, Vlozil_dna) values ('" & uprava_datumu(dgv_VykazMaterialu.Rows(i).Cells(0).Value.ToString) & "', '" & dgv_VykazMaterialu.Rows(i).Cells(1).Value.ToString & "', '" & dgv_VykazMaterialu.Rows(i).Cells(2).Value.ToString & "', '" & dgv_VykazMaterialu.Rows(i).Cells(3).Value.ToString & "', '" & dgv_VykazMaterialu.Rows(i).Cells(4).Value.ToString & "', 0, '" & Ponuka.Meno_uzivatela & "', now());"
            con.Open()
            Dim sql As MySqlCommand = New MySqlCommand(Query, con)
            Try
                sql.ExecuteNonQuery()
                con.Close()
                logy(21, 1, "")
                MessageBox.Show("Materíal bol zapiísany do databázy !", "ETECH - Zápis materiálu do databázy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                con.Close()
                logy(21, 2, ex.Message)
                MessageBox.Show(ex.Message, "ETECH - Zápis materiálu do databázy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
            i = i + 1
        Loop While i < dgv_VykazMaterialu.RowCount - 1

    End Sub

    Private Sub b_Kopiruj_Click(sender As Object, e As EventArgs) Handles b_Kopiruj.Click
        dgv_VykazMaterialu.Rows.Add(dgv_VykazMaterialu.Rows.Item(0).Cells(0).Value, dgv_VykazMaterialu.Rows.Item(0).Cells(1).Value, dgv_VykazMaterialu.Rows.Item(0).Cells(2).Value, "", "")
    End Sub
End Class