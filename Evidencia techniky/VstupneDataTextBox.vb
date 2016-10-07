Imports Evidencia_techniky.Ziadanky_sprava
Public Class VstupneDataTextBox

    Public Shared VstupneData As String
    Dim TextHlavicka As String
    Dim TextTelo As String
    Dim TextMSG As String

    Public Sub VstupneDataTextBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)

        If Ziadanky_sprava.cb_StavUlohy.Text = "Odložené" Then
            TextHlavicka = "odloženie"
            TextTelo = "odložená"
            TextMSG = "Odloženie"
        ElseIf Ziadanky_sprava.cb_TypUlohy.Text = "Investícia" Then
            TextHlavicka = "investíciu"
            TextTelo = "odložená"
            TextMSG = "Odloženie"
        Else
            TextHlavicka = "vrátenie"
            TextTelo = "vrátená"
            TextMSG = "Vrátenie"
        End If

        Nadpis.Text = "Dôvod na " & TextHlavicka & " žiadanky, prípadne poznámka"
    End Sub

    Public Sub Odoslat_Click(sender As Object, e As EventArgs) Handles Odoslat.Click
        Try
            vratenie_na_oddelenie(Ziadanky_sprava.id_ulohy, oddelenie(Ziadanky_sprava.cb_ZOddelenia.Text), ciselnik(1, 11, Ziadanky_sprava.cb_StavUlohy.Text), tb_VstupneData.Text)
            MessageBox.Show("Žiadanka bola " & TextTelo & "", "ETECH - " & TextMSG & " žiadanky", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ETECH - " & TextMSG & " žiadanky", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        Me.Close()
    End Sub
End Class