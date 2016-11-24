Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Public Class Software_priprad

    Dim id_programu As String
    Private Sub Software_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)

        Dim QueryPrace As String
        QueryPrace =
        "SELECT Evidencne_cislo FROM zariadenia
         WHERE id_zariadenia NOT IN (SELECT id_zariadenia FROM programy WHERE id_zariadenia > 0) ORDER BY 1 DESC"
        con.Open()
        Dim sqlPrace As MySqlCommand = New MySqlCommand(QueryPrace, con)
        Try
            Using odd As MySqlDataReader = sqlPrace.ExecuteReader()

                'Vytvorenie tabulky.
                Dim dtPrace As New DataTable("Prace")
                Dim ds2 As New DataSet()

                'Nacitanie dat
                dtPrace.Load(odd)

                'Pridanie dat do tabulky
                ds2.Tables.Add(dtPrace)

                Dim i As Integer = 0

                Do Until i = ds2.Tables(0).Rows.Count
                    cb_NazovZariadenia.Items.Add(ds2.Tables(0).Rows(i).Item(0))
                    i = i + 1
                Loop

            End Using
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Zoznam EČ zadiadenia", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub b_Vyhladaj_Click(sender As Object, e As EventArgs) Handles b_Vyhladaj.Click
        con.Open()
        Dim sqlquery As String = "Select id_programu, Cislo_licencie from programy where Cislo_licencie Like '" & "%" & tb_Vyhladaj.Text & "%" & "' or Poznamka Like '" & "%" & tb_Vyhladaj.Text & "%" & "';"
        Dim data As MySqlDataReader
        Dim adapter As New MySqlDataAdapter
        Dim command As New MySqlCommand
        command.CommandText = sqlquery
        command.Connection = con
        adapter.SelectCommand = command
        data = command.ExecuteReader
        If data.HasRows Then
            While data.Read()
                id_programu = data("id_programu").ToString()
                tb_CisloLicencie.Text = data("Cislo_licencie").ToString()
            End While
            data.Close()
            con.Close()
        Else
            MessageBox.Show("Dané číslo licencie sa nenašlo", "ETECH - Vyhľadanie čísla licenice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            con.Close()
        End If
    End Sub

    Private Sub b_Priradiť_Click(sender As Object, e As EventArgs) Handles b_Priradiť.Click
        Dim QueryPrace As String
        QueryPrace = "UPDATE programy SET id_zariadenia = '" & Cislo_zariadenia(cb_NazovZariadenia.Text) & "', Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() WHERE id_programu = '" & id_programu & "';"
        con.Open()
        Dim sqlPrace As MySqlCommand = New MySqlCommand(QueryPrace, con)
        Try
            sqlPrace.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Číslo licencie BOLO priradené!", "ETECH - Priradenia licencie", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "ETECH - Priradenia licencie", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
    Private Sub txtPassword_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles tb_Vyhladaj.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            b_Vyhladaj_Click(sender, e)
        End If
    End Sub
End Class