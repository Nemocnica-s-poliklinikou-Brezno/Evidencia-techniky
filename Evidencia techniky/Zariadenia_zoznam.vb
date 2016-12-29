Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Public Class Zariadenia_zoznam

    Public Shared id_zariadenia As String
    Private Sub Zariadenia_zoznam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)

        Using cmd As New MySqlCommand("SELECT z.id_zariadenia, Evidencne_cislo, Seriove_cislo, Vyrobne_cislo, Vyrobca, Model from zariadenia z left join ciselnik_data c on z.Typ_zariadenia = c.Hodnota and c.idciselnik = 12 left join programy p on z.id_zariadenia = p.id_zariadenia and p.Nazov_programu = 'TEAMVIEWER' where (z.Evidencne_cislo like '" & "%" & Zariadenia.tb_Vyhladat.Text & "%" & "' or z.Seriove_cislo like '" & "%" & Zariadenia.tb_Vyhladat.Text & "%" & "' or z.Vyrobne_cislo like '" & "%" & Zariadenia.tb_Vyhladat.Text & "%" & "') and z.stav = 0" & Ponuka.PridajSQL)
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

                dgv_ZoznamZariadeni.ColumnCount = 6
                dgv_ZoznamZariadeni.Columns(0).Name = "id_zariadenia"
                dgv_ZoznamZariadeni.Columns(0).Visible = False
                dgv_ZoznamZariadeni.Columns(1).Name = "Evidencné čislo"
                dgv_ZoznamZariadeni.Columns(2).Name = "Seriové čislo"
                dgv_ZoznamZariadeni.Columns(3).Name = "Vyrobné čislo"
                dgv_ZoznamZariadeni.Columns(4).Name = "Výrobca"
                dgv_ZoznamZariadeni.Columns(5).Name = "Model"

                Dim i As Integer = 0

                Do Until i = ds.Tables(0).Rows.Count
                    dgv_ZoznamZariadeni.Rows.Add(ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString, ds.Tables(0).Rows(i).Item(3).ToString, ds.Tables(0).Rows(i).Item(4).ToString, ds.Tables(0).Rows(i).Item(5).ToString)
                    i = i + 1
                Loop

            End Using
            con.Close()
        End Using
    End Sub
    Public Sub selectedRowsButton_Click_Ukoncene(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_ZoznamZariadeni.Click
        id_zariadenia = dgv_ZoznamZariadeni.CurrentRow.Cells("id_zariadenia").Value
        Zariadenia.Show()
    End Sub

End Class