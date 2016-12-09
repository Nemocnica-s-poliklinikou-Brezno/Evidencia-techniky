Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports Evidencia_techniky.pripojenie
Module Notifikacia_funk

    Dim PEmail As String
    Dim PPredmet As String
    Dim PTelo_mailu As String
    Dim Cislo_ulohy As String = Uloha_Cislo() + 1

    Public Function Notifikacia(ByVal TypZaslania As String, ByVal Email As String, ByVal CisloNotifikacie As String) As String
        Dim ErrorText As String = ""

        con.Open()
        Dim sqlquery As String = "SELECT * FROM mail_notifikacia WHERE Cislo_notifikacie = '" & CisloNotifikacie & "' and stav = 0"
        Dim data As MySqlDataReader
        Dim adapter As New MySqlDataAdapter
        Dim command As New MySqlCommand
        command.CommandText = sqlquery
        command.Connection = con
        adapter.SelectCommand = command
        data = command.ExecuteReader
        If data.HasRows Then
            While data.Read()
                PEmail = data("Email").ToString()
                PPredmet = data("Predmet").ToString()
                PTelo_mailu = Replace(data("Telo_mailu").ToString(), "[Cislo_ziadanky]", Cislo_ulohy)
                PTelo_mailu = Replace(data("Telo_mailu").ToString(), "[U_Cislo_ziadanky]", Ziadanky_sprava.PUlohaCislo)
                PTelo_mailu = Replace(data("Telo_mailu").ToString(), "[V_Cislo_ziadanky]", Ziadanky_sprava.PUlohaCislo)
            End While
            data.Close()
            con.Close()
        Else
            MessageBox.Show("Daná šablóna nebola nájdená", "ETECH - Mailová notifikácia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            con.Close()
        End If

        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As MailMessage = New MailMessage
            Smtp_Server.UseDefaultCredentials = True
            Smtp_Server.Credentials = New Net.NetworkCredential("lasut@nspbr.sk", "Viktor789")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.websupport.sk"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("nep@nspbr.sk")
            If TypZaslania = 0 Then
                e_mail.To.Add(PEmail)
            ElseIf TypZaslania = 1 Then
                e_mail.To.Add(Email)
            End If
            e_mail.Subject = PPredmet
            e_mail.Body = PTelo_mailu
            e_mail.IsBodyHtml = True
            Smtp_Server.Send(e_mail)

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try

        Return ErrorText

    End Function
End Module
