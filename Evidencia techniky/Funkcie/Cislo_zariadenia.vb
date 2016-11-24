Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Module Cislo_zariadenia_funk
    Public Function Cislo_zariadenia(ByVal EvidencneCislo) As String
        Dim Id_zariadenia As String = ""

        Dim IdZariadeniaQuery As String
        IdZariadeniaQuery = "SELECT id_zariadenia FROM zariadenia where Evidencne_cislo = '" & EvidencneCislo & "';"
        con.Open()
        Dim IdZariadeniaSQL As MySqlCommand = New MySqlCommand(IdZariadeniaQuery, con)
        IdZariadeniaSQL.CommandTimeout = 1200
        Try
            Id_zariadenia = IdZariadeniaSQL.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Vytiahnutie čísla zariadenia", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        con.Close()

        Return Id_zariadenia

    End Function
End Module
