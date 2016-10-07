Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Imports System.Deployment.Application
Public Class Prihlasenie

    Dim MyDataAdapter As New MySqlDataAdapter()
    Dim MyDataset As DataSet = New DataSet()

    Public Sub Prihlasenie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = Me.Text & " | " & Verzia_programu()
        pata_text.Text = pata_programu()

    End Sub

    Public Sub btPrihlasit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrihlasit.Click

        Dim Result As String

        MyDataAdapter.SelectCommand = New MySqlCommand()
        MyDataAdapter.SelectCommand.Connection = con
        MyDataAdapter.SelectCommand.CommandText = "Select * From uzivatelia WHERE (UzivatelMeno ='" & tb_Meno.Text & "' or OsobneCislo = '" & tb_Meno.Text & "') and Heslo ='" & HashPassword(tb_Heslo.Text) & "' and Zablokovany = 0"

        con.Open()
        Result = MyDataAdapter.SelectCommand.ExecuteScalar()
        con.Close()

        If Result > 0 Then
            Ponuka.Show()
            Me.Hide()
        Else
            MessageBox.Show("Nepoznám Vás, kontaktujte:" & vbCr & "Lašut Viktor, klapka: 242, email: etech@nspbr.sk", "ETECH - Prihlásnie", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ZabHeslo.LinkClicked
        Process.Start(String.Format("mailto: {0}", "etech@nspbr.sk" & "?subject=Žiadosť o reset hesla"))
    End Sub

    Private Sub tb_Meno_TextChanged(sender As Object, e As EventArgs) Handles tb_Meno.TextChanged
        tb_Meno.CharacterCasing = CharacterCasing.Upper
    End Sub
End Class