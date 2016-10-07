Imports MySql.Data.MySqlClient
Public Class pripojenie
    Public Shared con As MySqlConnection = New MySqlConnection("Data Source=10.10.0.20;Port=3306;Database=etech;User ID=lasut;Password=Kirovv11;")

    Private Sub pripojenie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
