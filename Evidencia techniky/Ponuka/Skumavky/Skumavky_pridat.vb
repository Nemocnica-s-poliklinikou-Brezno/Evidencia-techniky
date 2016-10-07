Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie

Public Class Skumavky_pridat
    Dim id_lekar As String

    Private Sub Skumavky_pridat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)

    End Sub

    Private Sub b_Zapisat_Click(sender As Object, e As EventArgs) Handles b_Zapisat.Click
        If tb_KodLekara.Text IsNot "" And tb_MenoLekara.Text IsNot "" And tb_KodPzs.Text IsNot "" Then
            Dim Query As String
            Query = "INSERT INTO skumavky_lekari(Meno_lekara, Kod_lekara, Kod_pzs, Vlozil_meno, Vlozil_dna) values ('" & tb_MenoLekara.Text & "', '" & tb_KodLekara.Text & "', '" & tb_KodPzs.Text & "', '" & Ponuka.Meno_uzivatela & "', now());"
            con.Open()
            Dim sql As MySqlCommand = New MySqlCommand(Query, con)
            Try
                sql.ExecuteNonQuery()
                MessageBox.Show("Dáta boli uložené", "ETECH - Pridanie lekára do databázy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Pridanie lekára do databázy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
            con.Close()
        ElseIf tb_CisloVykonu.Text IsNot "" Then
            Dim Query As String
            Query = "INSERT INTO skumavky_vykony(Cislo_Vykonu, Vlozil_meno, Vlozil_dna) values ('" & tb_CisloVykonu.Text & "', '" & Ponuka.Meno_uzivatela & "', now());"
            con.Open()
            Dim sql As MySqlCommand = New MySqlCommand(Query, con)
            Try
                sql.ExecuteNonQuery()
                MessageBox.Show("Dáta boli uložené", "ETECH - Pridanie výkonu do databázy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Pridanie výkonu do databázy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
            con.Close()
        Else
            MessageBox.Show("Neboli zapísané žiadne dáta", "ETECH - Pridanie lekára alebo výkonu do databázy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Public Sub tb_Vyhladat_Click(sender As Object, e As EventArgs) Handles b_Vyhladat.Click
        tb_KodLekara.Text = ""
        tb_MenoLekara.Text = ""
        tb_KodPzs.Text = ""

        b_Zmenit.Enabled = False
        b_Vymazat.Enabled = False
        b_Zapisat.Enabled = False

        If tb_Vyhladat.Text = "" Then
            MessageBox.Show("Neboli zadané žiadne parametre na vyhľadanie !", "ETECH - Vyhľadanie v databáze", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim username As Boolean = True
            con.Open()
            Dim sqlquery As String = "SELECT * from skumavky_lekari where (Meno_lekara like '" & "%" & tb_Vyhladat.Text & "%" & "' or Kod_lekara like '" & "%" & tb_Vyhladat.Text & "%" & "' or Kod_pzs like '" & "%" & tb_Vyhladat.Text & "%" & "') and stav = 0"
            Dim data As MySqlDataReader
            Dim adapter As New MySqlDataAdapter
            Dim command As New MySqlCommand
            command.CommandText = sqlquery
            command.Connection = con
            adapter.SelectCommand = command
            data = command.ExecuteReader
            If data.HasRows Then

                While data.Read()
                    id_lekar = data("id_lekar").ToString
                    tb_MenoLekara.Text = data("Meno_lekara").ToString
                    tb_KodLekara.Text = data("Kod_lekara").ToString
                    tb_KodPzs.Text = data("Kod_pzs").ToString
                End While
                data.Close()
                con.Close()

                b_Zmenit.Enabled = True
                b_Vymazat.Enabled = True
                b_Zapisat.Enabled = False
            Else
                MessageBox.Show("Neboli nájdené žiadne záznamy !", "ETECH - Vyhľadanie v databáze", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

    End Sub

    Private Sub tb_MenoLekara_TextChanged(sender As Object, e As EventArgs) Handles tb_MenoLekara.TextChanged
        b_Zapisat.Enabled = True
    End Sub

    Private Sub tb_KodLekara_TextChanged(sender As Object, e As EventArgs) Handles tb_KodLekara.TextChanged
        b_Zapisat.Enabled = True
    End Sub

    Private Sub tb_KodPzs_TextChanged(sender As Object, e As EventArgs) Handles tb_KodPzs.TextChanged
        b_Zapisat.Enabled = True
    End Sub

    Private Sub tb_CisloVykonu_TextChanged(sender As Object, e As EventArgs) Handles tb_CisloVykonu.TextChanged
        b_Zapisat.Enabled = True
    End Sub

    Private Sub b_Zmenit_Click(sender As Object, e As EventArgs) Handles b_Zmenit.Click
        If tb_KodLekara.Text IsNot "" And tb_MenoLekara.Text IsNot "" And tb_KodPzs.Text IsNot "" Then
            Dim Query As String
            Query = "UPDATE skumavky_lekari set Meno_lekara = '" & tb_MenoLekara.Text & "', Kod_lekara = '" & tb_KodLekara.Text & "', Kod_pzs = '" & tb_KodPzs.Text & "', Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() where id_lekar = '" & id_lekar & "' and stav = 0"
            con.Open()
            Dim sql As MySqlCommand = New MySqlCommand(Query, con)
            Try
                sql.ExecuteNonQuery()
                MessageBox.Show("Dáta boli zmenené", "ETECH - Úprava záznamu lekára v databáze", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Úprava záznamu lekára v databáze", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
            con.Close()
        Else
            MessageBox.Show("Neboli zmenené dáta", "ETECH - Úprava záznamu lekára v databáze", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub b_Vymazat_Click(sender As Object, e As EventArgs) Handles b_Vymazat.Click
        If tb_KodLekara.Text IsNot "" And tb_MenoLekara.Text IsNot "" And tb_KodPzs.Text IsNot "" Then
            Dim Query As String
            Query = "UPDATE skumavky_lekari set stav = 2, Vymazal_meno = '" & Ponuka.Meno_uzivatela & "', Vymazal_dna = now() where id_lekar = '" & id_lekar & "'"
            con.Open()
            Dim sql As MySqlCommand = New MySqlCommand(Query, con)
            Try
                sql.ExecuteNonQuery()
                MessageBox.Show("Dáta boli vymazané", "ETECH - Vymazanie lekára z databázy", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Vymazanie lekára z databázy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
            con.Close()
        Else
            MessageBox.Show("Neboli vymazané dáta", "ETECH - Vymazanie lekára z databázy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub tb_Vyhladat_TextChanged(sender As Object, e As EventArgs) Handles tb_Vyhladat.Click
        tb_Vyhladat.Text = ""
    End Sub
End Class