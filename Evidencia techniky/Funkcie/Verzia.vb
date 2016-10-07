Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie

Module verzia_funk
    Public Function Verzia_programu() As String
        Dim PVerzia As String = ""

        con.Open()
        Dim QueryVerzia As String = "SELECT Hodnota FROM nastavenie where Nazov_hodnoty = 'Verzia programu' AND stav = 0 ;"
        Dim sqlVerzia As MySqlCommand = New MySqlCommand(QueryVerzia, con)
        sqlVerzia.CommandTimeout = 1200
        Try
            PVerzia = sqlVerzia.ExecuteScalar()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Vytiahnutie verzie programu", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            con.Close()
        End Try
        con.Close()

        Return PVerzia
    End Function
End Module
