Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Module hlavicka
    Public Function hlavicka_programu(okno As String, Meno_uzivatel As String) As String
        Dim myHlavickaQuery As String = "SELECT Hodnota from nastavenie where idnastavenie = 3 and stav = 0"
        Dim myHlavicka As String = ""
        Dim myHlavicka_full As String = ""

        con.Open()
        Dim myHlavickaSQL As MySqlCommand = New MySqlCommand(myHlavickaQuery, con)
        Try
            myHlavicka = myHlavickaSQL.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Vytiahnutie hlavičky", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        con.Close()

        myHlavicka_full = myHlavicka & okno & " | Užívateľ: " & Meno_uzivatel & " " & My.Application.Info.Version.ToString()

        Return myHlavicka_full
    End Function
End Module
