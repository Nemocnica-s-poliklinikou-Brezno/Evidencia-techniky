Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Public Class Uprava_Presun
    Private Sub Uprava_Presun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)

        Dim sqlquery As String = "SELECT pxo.Presunute_dna, o.Nazov_oddelenia, pxo.Miestnost from zariadenia_x_oddelenie pxo join oddelenia o on o.id_oddelenia = pxo.id_oddelenia where id_zariadenia_x_oddelenie = " & Zariadenia.id_zariadenia_x_oddelenie & " and pxo.stav in (0, 1);"
        con.Open()
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
                    cb_Oddelenie.Text = data("Nazov_oddelenia").ToString
                    tb_Miestnost.Text = data("Miestnost").ToString
                    dtp_Presunute.Text = data("Presunute_dna").ToString
                End While
                data.Close()
            End If
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Vytiahnutie údajov ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        Using cmdOdd As New MySqlCommand("SELECT Nazov_oddelenia from oddelenia where stav = 0;")
            cmdOdd.Connection = con
            cmdOdd.CommandTimeout = 1200
            con.Open()

            Using sdr As MySqlDataReader = cmdOdd.ExecuteReader()
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
                        cb_Oddelenie.Items.Add(ds.Tables(0).Rows(i).Item(0))
                        i = i + 1
                    Loop
                    con.Close()
                Else
                    MessageBox.Show("Neboli nájdené žiadne záznamy !", "ETECH - Vyhľadanie v databáze", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    con.Close()
                End If
            End Using
        End Using
    End Sub

    Private Sub b_Ulozit_Click(sender As Object, e As EventArgs) Handles b_Ulozit.Click
        Dim QueryPC As String
        QueryPC = "UPDATE zariadenia_x_oddelenie SET Presunute_dna = '" & uprava_datumu(dtp_Presunute.Text) & "', id_oddelenia = '" & oddelenie(cb_Oddelenie.Text) & "', Miestnost = '" & tb_Miestnost.Text & "', Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() WHERE id_zariadenia_x_oddelenie = " & Zariadenia.id_zariadenia_x_oddelenie & ";"
        con.Open()
        Dim sqlPC As MySqlCommand = New MySqlCommand(QueryPC, con)
        Try
            sqlPC.ExecuteNonQuery()
            con.Close()
            logy(17, 1, "")
            MessageBox.Show("Údaje BOLI upravené!", "ETECH - Zmena údajov v presune", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            con.Close()
            logy(17, 2, ex.Message)
            MessageBox.Show(ex.Message, "ETECH - Zmena údajov v presune", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub cb_Oddelenie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Oddelenie.SelectedIndexChanged
        b_Ulozit.Enabled = True
    End Sub

    Private Sub tb_Miestnost_TextChanged(sender As Object, e As EventArgs) Handles tb_Miestnost.TextChanged
        b_Ulozit.Enabled = True
    End Sub

    Private Sub dtp_Presunute_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Presunute.ValueChanged
        b_Ulozit.Enabled = True
    End Sub
End Class