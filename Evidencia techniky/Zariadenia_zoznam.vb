Public Class Zariadenia_zoznam
    Private Sub Zariadenia_zoznam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = hlavicka_programu(Me.Text, Ponuka.Meno_uzivatela)

        DataGridView1.ColumnCount = 5
        DataGridView1.Columns(0).Name = "Evidencné čislo"
        DataGridView1.Columns(1).Name = "Seriové čislo"
        DataGridView1.Columns(2).Name = "Vyrobné čislo"
        DataGridView1.Columns(3).Name = "Výrobca"
        DataGridView1.Columns(4).Name = "Model"


    End Sub
End Class