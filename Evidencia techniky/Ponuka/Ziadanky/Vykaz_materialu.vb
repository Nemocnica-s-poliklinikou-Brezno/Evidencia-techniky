Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Public Class Vykaz_materialu
    Private Sub Vykaz_materialu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, UCase(Ponuka.Meno_uzivatela))

        If Ponuka.ZiadankySprava = 2 Then
            b_Ulozit.Enabled = True
            b_Kopiruj.Visible = True
        End If

        If Ponuka.ZiadankySprava = 4 Then
            b_Ulozit.Enabled = True
            b_Kopiruj.Visible = True
            tsmi_Vymazat.Visible = True
        End If

        Using cmd As New MySqlCommand("SELECT idvykazmaterialu, date_format(datum, GET_FORMAT(DATE,'EUR')) as 'Dátum', Cislo_ziadanky, Cislo_vydajky, Kusy, Nazov_materialu FROM vykazmaterialu WHERE Cislo_ziadanky = '" & Ziadanky_zoznam.Poziadavka_cislo & "';")
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
                    dgv_VykazMaterialu.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString)
                    i = i + 1
                Loop
            End Using
            Spracovanie_dat.Close()
            con.Close()
        End Using

        dgv_VykazMaterialu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        If dgv_VykazMaterialu.Rows.Count = 1 Then
            Dim n As Integer = dgv_VykazMaterialu.Rows.Add()
            dgv_VykazMaterialu.Rows.Item(n).Cells(0).Value = ""
            dgv_VykazMaterialu.Rows.Item(n).Cells(1).Value = Now
            dgv_VykazMaterialu.Rows.Item(n).Cells(2).Value = Ziadanky_zoznam.Poziadavka_cislo
            dgv_VykazMaterialu.Rows.Item(n).Cells(3).Value = ""
            dgv_VykazMaterialu.Rows.Item(n).Cells(4).Value = ""
            dgv_VykazMaterialu.Rows.Item(n).Cells(5).Value = ""
        End If
    End Sub

    Public Sub b_Ulozit_Click(sender As Object, e As EventArgs) Handles b_Ulozit.Click

        Dim i As Integer = dgv_VykazMaterialu.Rows.Count - 2
        Do
            Dim Query As String
            Query = "INSERT INTO vykazmaterialu(Datum, Cislo_ziadanky, Cislo_vydajky, Kusy, Nazov_materialu, stav, Vlozil_meno, Vlozil_dna) values ('" & uprava_datumu(dgv_VykazMaterialu.Rows(i).Cells(1).Value.ToString) & "', '" & dgv_VykazMaterialu.Rows(i).Cells(2).Value.ToString & "', '" & dgv_VykazMaterialu.Rows(i).Cells(3).Value.ToString & "', '" & dgv_VykazMaterialu.Rows(i).Cells(4).Value.ToString & "', '" & dgv_VykazMaterialu.Rows(i).Cells(5).Value.ToString & "', 0, '" & Ponuka.Meno_uzivatela & "', now());"
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

    Private Sub DgvDelays_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv_VykazMaterialu.CellMouseDown
        Dim rowClicked As DataGridView.HitTestInfo = dgv_VykazMaterialu.HitTest(e.X, e.Y)
        'Select Right Clicked Row if its not the header row
        If e.Button = Windows.Forms.MouseButtons.Right AndAlso e.RowIndex > -1 Then
            'Clear any currently sellected rows
            dgv_VykazMaterialu.ClearSelection()
            Me.dgv_VykazMaterialu.Rows(e.RowIndex).Selected = True
            If dgv_VykazMaterialu.RowCount > 1 Then
                Me.dgv_VykazMaterialu.ContextMenuStrip = ContextMenuStrip1
                'Add functionality for ToolStripMenuItem2 (Exit) click
                AddHandler tsmi_Vymazat.Click, AddressOf menuItem1_Click
            End If
        End If
    End Sub
    Private Sub menuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim QueryPriradenie As String
        QueryPriradenie = "UPDATE vykazmaterialu SET stav = 2, Vymazal_meno = '" & Ponuka.Meno_uzivatela & "', Vymazal_dna = now() WHERE idvykazmaterialu = '" & dgv_VykazMaterialu.CurrentRow.Cells("idvykazmaterialu").Value & "' and stav = 0;"
        con.Open()
        Dim sqlPriradenie As MySqlCommand = New MySqlCommand(QueryPriradenie, con)
        Try
            sqlPriradenie.ExecuteNonQuery()
            con.Close()
            logy(16, 1, "")
            MessageBox.Show("Materiál BOL vymazaný!", "ETECH - Vymazanie presunu zariadenia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            con.Close()
            logy(16, 2, ex.Message)
            MessageBox.Show(ex.Message, "ETECH - Vymazanie materiálu", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
End Class