Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie

Public Class Pripomienky
    Private Sub Pripomienky_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)
    End Sub

    Private Sub b_Odoslat_Click(sender As Object, e As EventArgs) Handles b_Odoslat.Click
        Dim QueryPC As String
        QueryPC = "INSERT INTO uloha(Nahlasil_ID_zamestanca, Nahlasene_dna, Druh_ulohy, Nazov_ulohy, Popis_ulohy, Vlozil_meno, Vlozil_dna) VALUES ( '" & Ponuka.id_uzivatela & "', now(), 99, 'ETECH '" & "'" & cb_DruhPripomienky.Text & "'" & "'" & "', '" & tb_Pripomienka.Text & "', '" & Ponuka.Meno_uzivatela & "', now());"
        con.Open()
        Dim sqlPC As MySqlCommand = New MySqlCommand(QueryPC, con)
        Try
            sqlPC.ExecuteNonQuery()
            MessageBox.Show("Pripomienka BOLA vložená!", "ETECH - Zápis pripomienky do databázy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Zápis pripomienky do databázy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        con.Close()

    End Sub
End Class