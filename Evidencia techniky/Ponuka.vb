Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie

Public Class Ponuka

    Public Shared id_uzivatela As String
    Public Shared Id_uzivatelaOdd As String
    Public Shared PridajSQL As String
    Public Shared PridajSQLP As String
    Public Shared Druh_zariadenia As String
    Public Shared Meno_uzivatela As String
    Public Shared HladajV As String
    Public Shared HladajCo As String
    Public Shared Zariadenie As String
    Public Shared PZiadanky As String
    Public Shared ZiadankySprava As String
    Public Shared PraceSprava As String
    Public Shared Email As String

    Dim MyDataAdapter As New MySqlDataAdapter()
    Dim MyDataset As DataSet = New DataSet()

    Public Sub Ponuka_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            Ponuka_Load(sender, e)
        End If
    End Sub

    Public Sub Ponuka_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        pata_text.Text = pata_programu()

        con.Open()
        Dim sqlquery As String = "SELECT * FROM uzivatelia u join prava p on u.id_uzivatela = p.id_uzivatela WHERE (UzivatelMeno = '" & Prihlasenie.tb_Meno.Text & "' or OsobneCislo = '" & Prihlasenie.tb_Meno.Text & "') and zablokovany = 0 and u.Vymazal_dna is null"
        Dim data As MySqlDataReader
        Dim adapter As New MySqlDataAdapter
        Dim command As New MySqlCommand
        command.CommandText = sqlquery
        command.Connection = con
        adapter.SelectCommand = command
        data = command.ExecuteReader
        If data.HasRows Then
            While data.Read()
                id_uzivatela = data("id_uzivatela").ToString()
                Id_uzivatelaOdd = id_uzivatela
                Meno_uzivatela = data("UzivatelMeno").ToString()
                Email = data("Email").ToString()
                PZiadanky = data("Ziadanky").ToString()
                ZiadankySprava = data("ZiadankySprava").ToString()
                PraceSprava = data("PraceSprava").ToString()

                If data("Admin").ToString = 1 Then 'Admin
                    ADMINISTRÁCIAToolStripMenuItem.Visible = True
                End If

                If data("Pocitace").ToString > 0 Then 'Technika
                    tsm_Technika.Visible = True
                Else
                    tsm_Technika.Visible = False
                End If

                If data("Prace").ToString > 0 Then 'Práce
                    tsm_Prace.Visible = True
                End If

                If data("PraceSprava").ToString > 1 Then 'Práce správa
                    tsm_PraceSprava.Visible = True
                End If

                If data("Ziadanky").ToString > 0 Then 'Ziadanky
                    tsm_Ziadanky.Visible = True
                    stsmi_Zadanie.Visible = True
                End If

                If data("ZiadankySprava").ToString > 0 Then 'Ziadanky správa
                    tsm_Ziadanky.Visible = True
                    stsmi_Evidencia.Visible = True
                End If

                If data("Doprava").ToString > 0 Then 'Doprava
                    tsm_Doprava.Visible = True
                End If

                If data("DopravaOdosielatelia").ToString > 0 Then 'Doprava podľa odosielatelov
                    tsm_PrehladPodlaOdosielatela.Visible = True
                End If

                If data("DopravaPoistovne").ToString > 0 Then 'Ročný prehľad podla poistovni
                    tsm_DopravaPoistovne.Visible = True
                End If

                If data("Labaky").ToString > 0 Then 'Labaky
                    tsm_Labaky.Visible = True
                End If

                If data("Skumavky").ToString > 0 Then 'Skumavky
                    tsm_Skumavky.Visible = True
                End If

                If data("id_uzivatela").ToString = 2 Then
                    TESTMAILToolStripMenuItem.Visible = True
                End If
            End While
            data.Close()
            con.Close()
        Else
            MessageBox.Show("Nemáte práva k ničomu !", "ETECH - Práva užívateľa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Me.Text = hlavicka_programu("Ponuka", Ponuka.Meno_uzivatela)
    End Sub

    Private Sub ZmenaHeslaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZmenaHeslaToolStripMenuItem.Click
        ZmenaHesla.Show()
    End Sub

    Private Sub NastaveniePrávToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NastaveniePrávToolStripMenuItem.Click
        NastavenieUzivatela.Show()
    End Sub

    Private Sub tsm_Skumavky_Click(sender As Object, e As EventArgs) Handles tsm_Skumavky.Click
        Skumavky.Show()
    End Sub

    Private Sub TransfúzneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransfúzneToolStripMenuItem.Click
    End Sub

    Private Sub tsm_PrehladPodlaOdosielatela_Click(sender As Object, e As EventArgs) Handles tsm_PrehladPodlaOdosielatela.Click
        Doprava_odosielatelia.Show()
    End Sub

    Private Sub tsm_DopravaPoistovne_Click(sender As Object, e As EventArgs) Handles tsm_DopravaPoistovne.Click
    End Sub

    Public Sub tsm_Pocitac_Click(sender As Object, e As EventArgs) Handles tsm_Pocitac.Click
        PridajSQL = " and z.Typ_zariadenia = 1"
        Zariadenia.Show()
    End Sub

    Public Sub tsm_Monitor_Click(sender As Object, e As EventArgs) Handles tsm_Monitor.Click
        PridajSQL = " and z.Typ_zariadenia = 2"
        Zariadenia.Show()
    End Sub

    Public Sub tsm_Tlaciaren_Click(sender As Object, e As EventArgs) Handles tsm_Tlaciaren.Click
        PridajSQL = " and z.Typ_zariadenia = 3"
        Zariadenia.Show()
    End Sub

    Public Sub tsm_Ostatne_Click(sender As Object, e As EventArgs) Handles tsm_Ostatne.Click
        PridajSQL = ""
        Zariadenia.Show()
    End Sub

    Private Sub HardwareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HardwareToolStripMenuItem.Click
    End Sub

    Private Sub OdlásiťToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OdlásiťToolStripMenuItem.Click
        MessageBox.Show("Boli ste odhlásený !", "ETECH - Odhlásenie", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Application.Exit()
        logy(16, 1, "")
    End Sub

    Private Sub PripomienkyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PripomienkyToolStripMenuItem.Click
        Pripomienky.Show()
    End Sub

    Private Sub OProgrameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OProgrameToolStripMenuItem.Click
        Dim webAddress As String = "file://10.10.0.20/Etech/verzie.htm/"
        Process.Start(webAddress)
    End Sub

    Private Sub VerziaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerziaToolStripMenuItem.Click
        Verzie.Show()
    End Sub

    Private Sub ZadanieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles stsmi_Zadanie.Click
        Ziadanky.Show()
    End Sub

    Private Sub SprávaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles stsmi_Evidencia.Click
        Ziadanky_zoznam.Show()
    End Sub

    Private Sub KrátkodobéToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub TESTMAILToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TESTMAILToolStripMenuItem.Click
        Notifikacia(1, "lasut@nspbr.sk", 1)
    End Sub

    Private Sub ZadanePraceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsm_PraceSprava.Click
        PridajSQLP = " and '" & Ponuka.PraceSprava & "' = 4"
        Zoznam_zadanych_prac.Show()
    End Sub

    Private Sub MojeNevybavenéPráceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MojeNevybavenéPráceToolStripMenuItem.Click
        PridajSQLP = " and pxu.id_uzivatela = '" & Ponuka.id_uzivatela & "'"
        Zoznam_zadanych_prac.Show()
    End Sub

    Private Sub PriradiťToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PriradiťToolStripMenuItem.Click
        Software_priprad.Show()
    End Sub
End Class