Imports Evidencia_techniky.Ziadanky_sprava
Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie

Public Class Poznamka
    Public Shared PPoznamka As String
    Public Sub Poznamka_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, UCase(Ponuka.Meno_uzivatela))

        con.Open()
        Dim sqlquery As String =
        "SELECT Poznamka
        FROM uloha u
        WHERE u.Uloha_cislo = '" & id_ulohy & "' and u.stav = 0"
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
                    PPoznamka = data("Poznamka").ToString
                End While
                data.Close()
            End If
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Poznámka", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        tb_Poznamka.Text = PPoznamka

        If Ponuka.ZiadankySprava > 1 Then
            b_Ulozit.Enabled = True
        End If
    End Sub

    Private Sub b_Ulozit_Click(sender As Object, e As EventArgs) Handles b_Ulozit.Click

        PPoznamka = tb_Poznamka.Text

        Dim PoznamkaUloha As String
        PoznamkaUloha = "UPDATE uloha SET Poznamka = '" & PPoznamka & "', Upravil_meno = '" & UCase(Ponuka.Meno_uzivatela) & "', Upravil_dna = now() WHERE id_ulohy = '" & id_ulohy & "';"
        con.Open()
        Dim sqlPoznamkaUloha As MySqlCommand = New MySqlCommand(PoznamkaUloha, con)
        Try
            sqlPoznamkaUloha.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Poznámka bola prepísaná!", "ETECH - Poznámka", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Poznámka", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
End Class