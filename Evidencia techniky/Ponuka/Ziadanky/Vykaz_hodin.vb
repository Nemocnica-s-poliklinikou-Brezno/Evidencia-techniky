Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Public Class Vykaz_hodin

    Dim id_ulohy As String

    Private Sub Vykaz_hodin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)

        'Vytiahnutie udajov z databazy k danej ziadanke
        con.Open()
        Dim sqlquery As String =
        "
        WHERE u.Uloha_cislo = '" & Ziadanky_sprava.id_ulohy & "' and u.stav = 0"
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
                    id_ulohy = data("id_ulohy").ToString

                    l_CIsloZiadanky.Text = id_ulohy

                End While
                data.Close()
            End If
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Údaje k žiadanke", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

End Class