Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Module Praca_Cislo_funk

    Public Function Praca_Cislo(ByVal TypUlohy, ByVal Druh_prace) As String
        Dim PracaCislo As String = 0

        If TypUlohy = "Cislo" Then
            Dim PracaCisloQuery As String
            PracaCisloQuery = "SELECT max(Cislo_prace) FROM prace where Druh_prace = '" & Druh_prace & "'and stav = 0;"
            con.Open()
            Dim PracaCisloSQL As MySqlCommand = New MySqlCommand(PracaCisloQuery, con)
            PracaCisloSQL.CommandTimeout = 1200
            Try
                PracaCislo = PracaCisloSQL.ExecuteScalar()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Vytiahnutie čísla práce", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
            con.Close()
        ElseIf TypUlohy = "ID" Then
            Dim PracaCisloQuery As String
            PracaCisloQuery = "SELECT id_prace FROM prace where stav = 0 order by 1 desc limit 1;"
            con.Open()
            Dim PracaCisloSQL As MySqlCommand = New MySqlCommand(PracaCisloQuery, con)
            PracaCisloSQL.CommandTimeout = 1200
            Try
                PracaCislo = PracaCisloSQL.ExecuteScalar()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Vytiahnutie čísla práce", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
            con.Close()
        End If
        Return PracaCislo

    End Function
End Module
