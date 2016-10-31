Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Module UpravaDatumu_funk
    Public Function uprava_datumu(ByVal Hodnota As String) As String
        Dim Zmena_datumu As String = ""

        Try
            Zmena_datumu = Format(CDate(Hodnota), "yyyy-MM-dd")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - Chyba pri zmene datumu", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            End Try


        Return Zmena_datumu
    End Function
End Module
