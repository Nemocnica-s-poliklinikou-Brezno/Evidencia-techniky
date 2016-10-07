Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie

Module verzia_funk
    Public Function Verzia_programu() As String
        Dim PVerzia As String = ""

        Dim QueryVerzia As String
        QueryVerzia = "SELECT Hodnota FROM nastavenie where Nazov_hodnoty = 'Verzia programu' AND stav = 0 ;"
        con.Open()
        Dim sqlVerzia As MySqlCommand = New MySqlCommand(QueryVerzia, con)
        sqlVerzia.CommandTimeout = 1200
        Try
            PVerzia = sqlVerzia.ExecuteScalar()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Vytiahnutie verzie programu", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            con.Close()
        End Try

        Return PVerzia
    End Function
End Module
