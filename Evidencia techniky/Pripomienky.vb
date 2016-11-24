Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie

Public Class Pripomienky
    Public Shared Druh_Pripomienky As String
    Private Sub Pripomienky_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)
    End Sub

    Private Sub b_Odoslat_Click(sender As Object, e As EventArgs) Handles b_Odoslat.Click
        Dim QueryPC As String
        QueryPC = "INSERT INTO zaznamy(Popis_zaznam, Typ_zaznam, Text_chyby, Vlozil_meno, Vlozil_dna) VALUES (1, 99, '" & cb_DruhPripomienky.Text & " - " & tb_Pripomienka.Text & "', '" & Ponuka.Meno_uzivatela & "', now());"
        con.Open()
        Dim sqlPC As MySqlCommand = New MySqlCommand(QueryPC, con)
        Try
            sqlPC.ExecuteNonQuery()
            con.Close()
            Druh_Pripomienky = cb_DruhPripomienky.Text
            Notifikacia(0, "", 5)
            MessageBox.Show("Pripomienka BOLA vložená!", "ETECH - Zápis pripomienky do databázy", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "Zápis pripomienky do databázy", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub
End Class