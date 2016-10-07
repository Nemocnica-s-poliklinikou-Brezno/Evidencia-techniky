Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Imports System.Security.Cryptography
Imports System.Text
Public Class ZmenaHesla

    Private Sub zmenahesla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles tb_zmen.Click

        'Upozorni na To ze heslo nieje vyplnene
        If tb_NoveHeslo.Text Is "" Or tb_OpakovatHeslo.Text Is "" Then
            MessageBox.Show("Nevyplnili ste všetky údaje !", "ETECH - Zmena Hesla", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            'Zmeni sa heslo len v pripade ze je rovnake
        ElseIf tb_NoveHeslo.Text = tb_OpakovatHeslo.Text Then
            Dim cmd As New MySqlCommand

            con.Open()
            cmd.Connection = con
            cmd.CommandText = "UPDATE uzivatelia SET Heslo = '" & HashPassword(tb_NoveHeslo.Text) & "', Upravil_meno = '" & Ponuka.Meno_uzivatela & "', Upravil_dna = now() WHERE UzivatelMeno = '" & Ponuka.Meno_uzivatela & "';"
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Heslo bolo zmenené", "ETECH - Zmena Hesla", MessageBoxButtons.OK, MessageBoxIcon.Information)
                logy(1, 1, "Užívateľom")
                Me.Close()
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ETECH - Zmena Hesla", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                logy(1, 2, ex.Message)
                con.Close()
            End Try

        Else
            MessageBox.Show("Heslá sa nezhodujú !", "ETECH - Zmena Hesla", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub chb_zobraz_CheckedChanged(sender As Object, e As EventArgs) Handles chb_zobraz.CheckedChanged

        'Zobrazi sa heslo pokial bude box zakrtnuti
        If chb_zobraz.Checked Then
            tb_NoveHeslo.PasswordChar = ControlChars.NullChar
            tb_OpakovatHeslo.PasswordChar = ControlChars.NullChar

            'Heslo sa zakryje ked bude pole odskrtnute
        Else
            tb_NoveHeslo.PasswordChar = "*"
            tb_OpakovatHeslo.PasswordChar = "*"
        End If
    End Sub
End Class