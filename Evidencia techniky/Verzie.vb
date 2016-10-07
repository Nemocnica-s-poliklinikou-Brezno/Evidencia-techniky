Public Class Verzie

    Private Sub Verzia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Tento řádek načte data do tabulky 'EtechDataSet.verzie'. Můžete jej přesunout nebo jej odstranit podle potřeby.

    End Sub

    Private Sub dataGridView1_DefaultValuesNeeded(ByVal sender As Object,
    ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) _
    Handles DataGridView1.DefaultValuesNeeded

        e.Row.Cells("Vlozil_meno").Value = Prihlasenie.tb_Meno.Text
        e.Row.Cells("Vlozil_dna").Value = Now()

    End Sub

End Class