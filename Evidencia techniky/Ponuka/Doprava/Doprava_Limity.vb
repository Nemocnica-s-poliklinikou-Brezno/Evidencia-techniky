Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie

Public Class Doprava_Limity

    Private Sub DopravaLimity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, UCase(Ponuka.Meno_uzivatela))

        Using cmd As New MySqlCommand("SELECT Cena, Suma, Limity from doprava_limityZP where stav = 0;")
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

                    tb_VSZP_ZaKM.Text = ds.Tables(0).Rows(0).Item(0).ToString
                    tb_VSZP_Suma.Text = ds.Tables(0).Rows(0).Item(1).ToString
                    tb_VSZP_KM.Text = ds.Tables(0).Rows(0).Item(2).ToString

                    tb_Union_ZaKM.Text = ds.Tables(0).Rows(1).Item(0).ToString
                    tb_Union_Suma.Text = ds.Tables(0).Rows(1).Item(1).ToString
                    tb_Union_KM.Text = ds.Tables(0).Rows(1).Item(2).ToString

                    tb_Dovera_ZaKM.Text = ds.Tables(0).Rows(2).Item(0).ToString
                    tb_Dovera_Suma.Text = ds.Tables(0).Rows(2).Item(1).ToString
                    tb_Dovera_KM.Text = ds.Tables(0).Rows(2).Item(2).ToString

                Else
                    MessageBox.Show("Neboli nájdené žiadne záznamy !", "ETECH - Vyhľadanie limitov ZP v databáze", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                con.Close()

            End Using
        End Using

    End Sub

    Private Sub b_Ulozit_Click(sender As Object, e As EventArgs) Handles b_Ulozit.Click
        If tb_VSZP_ZaKM.Text IsNot "" And tb_VSZP_Suma.Text IsNot "" And tb_VSZP_KM.Text IsNot "" And tb_Union_ZaKM.Text IsNot "" And tb_Union_Suma.Text IsNot "" And tb_Union_KM.Text IsNot "" And tb_Dovera_ZaKM.Text IsNot "" And tb_Dovera_Suma.Text IsNot "" And tb_Dovera_KM.Text IsNot "" Then
            Dim QueryVSZP As String
            Dim QueryUnion As String
            Dim QueryDovera As String

            QueryVSZP = "UPDATE doprava_limityZP set Cena = replace('" & tb_VSZP_ZaKM.Text & "', "","", "".""), Limity = '" & tb_VSZP_KM.Text & "', Suma = '" & tb_VSZP_Suma.Text & "', Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() where Cislo_ZP = 2500 and stav = 0"
            QueryUnion = "UPDATE doprava_limityZP set Cena = replace('" & tb_Union_ZaKM.Text & "', "","", "".""), Limity = '" & tb_Union_KM.Text & "', Suma = '" & tb_Union_Suma.Text & "', Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() where Cislo_ZP = 2700 and stav = 0"
            QueryDovera = "UPDATE doprava_limityZP set Cena = replace('" & tb_Dovera_ZaKM.Text & "', "","", "".""), Limity = '" & tb_Dovera_KM.Text & "', Suma = '" & tb_Dovera_Suma.Text & "', Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() where Cislo_ZP = 2400 and stav = 0"

            con.Open()
            Dim sqlVSZP As MySqlCommand = New MySqlCommand(QueryVSZP, con)
            Dim sqlUnion As MySqlCommand = New MySqlCommand(QueryUnion, con)
            Dim sqlDovera As MySqlCommand = New MySqlCommand(QueryDovera, con)
            Try
                sqlVSZP.ExecuteNonQuery()
                sqlUnion.ExecuteNonQuery()
                sqlDovera.ExecuteNonQuery()

                MessageBox.Show("Dáta boli zmenené", "ETECH - Úprava limitov ZP v databáze", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Úprava limitov ZP v databáze", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
            con.Close()
        Else
            MessageBox.Show("Neboli zmenené dáta", "ETECH - Úprava limitov ZP v databáze", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
End Class