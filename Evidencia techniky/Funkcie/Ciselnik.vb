Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Module Ciselnik_funk
    Public Function ciselnik(ByVal typ_akcie As String, ByVal cislo_ciselniku As String, ByVal nazov_hodnoty As String) As String
        Dim PCiselnik As String = ""

        If typ_akcie = 0 Then
            Dim QueryCiselnik As String
            QueryCiselnik = "SELECT Nazov_hodnoty FROM ciselnik_data WHERE idciselnik = '" & cislo_ciselniku & "' and stav = 0;"
            con.Open()
            Dim sqlCiselnik As MySqlCommand = New MySqlCommand(QueryCiselnik, con)
            sqlCiselnik.CommandTimeout = 1200
            Try
                Using odd As MySqlDataReader = sqlCiselnik.ExecuteReader()

                    'Vytvorenie tabulky.
                    Dim dtOddlenia As New DataTable("Oddelenia")
                    Dim ds2 As New DataSet()

                    'Nacitanie dat
                    dtOddlenia.Load(odd)

                    'Pridanie dat do tabulky
                    ds2.Tables.Add(dtOddlenia)

                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Zistenie práv pre užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            End Try
            con.Close()

        ElseIf typ_akcie = 1 Then
            Dim QueryCiselnik As String
            QueryCiselnik = "SELECT Hodnota FROM ciselnik_data WHERE idciselnik = '" & cislo_ciselniku & "' and CONVERT(Nazov_hodnoty USING utf8) = '" & nazov_hodnoty & "' and stav = 0;"
            con.Open()
            Dim sqlCiselnik As MySqlCommand = New MySqlCommand(QueryCiselnik, con)
            sqlCiselnik.CommandTimeout = 1200
            Try
                PCiselnik = sqlCiselnik.ExecuteScalar()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Zistenie práv pre užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            End Try
            con.Close()

        ElseIf typ_akcie = 2 Then
            Dim QueryCiselnik As String
            QueryCiselnik = "SELECT Popis FROM ciselnik_data WHERE idciselnik = '" & cislo_ciselniku & "' and CONVERT(Nazov_hodnoty USING utf8) = '" & nazov_hodnoty & "' and stav = 0;"
            con.Open()
            Dim sqlCiselnik As MySqlCommand = New MySqlCommand(QueryCiselnik, con)
            sqlCiselnik.CommandTimeout = 1200
            Try
                PCiselnik = sqlCiselnik.ExecuteScalar()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Zistenie práv pre užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            End Try
            con.Close()
        End If

        Return PCiselnik
    End Function
End Module
