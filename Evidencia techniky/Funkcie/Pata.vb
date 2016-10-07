Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Module pata
    Public Function pata_programu() As String
        Dim myPataQuery As String = "SELECT Hodnota from nastavenie where Nazov_hodnoty = 'Päta programu' and stav = 0"
        Dim myPata As String = ""

        con.Open()
        Dim myPataSQL As MySqlCommand = New MySqlCommand(myPataQuery, con)
        Try
            myPata = myPataSQL.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Vytiahnutie päty", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        con.Close()

        Return myPata
    End Function
End Module
