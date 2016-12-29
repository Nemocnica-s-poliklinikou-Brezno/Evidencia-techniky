<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zariadenia_zoznam
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Vyžadováno Návrhářem Windows Form
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
    'Může být upraveno pomocí Návrháře Windows Form.  
    'Neupravovat pomocí editoru kódu
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv_ZoznamZariadeni = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_ZoznamZariadeni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_ZoznamZariadeni
        '
        Me.dgv_ZoznamZariadeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ZoznamZariadeni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_ZoznamZariadeni.Location = New System.Drawing.Point(0, 0)
        Me.dgv_ZoznamZariadeni.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_ZoznamZariadeni.Name = "dgv_ZoznamZariadeni"
        Me.dgv_ZoznamZariadeni.ReadOnly = True
        Me.dgv_ZoznamZariadeni.RowTemplate.Height = 28
        Me.dgv_ZoznamZariadeni.Size = New System.Drawing.Size(526, 181)
        Me.dgv_ZoznamZariadeni.TabIndex = 0
        '
        'Zariadenia_zoznam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 181)
        Me.Controls.Add(Me.dgv_ZoznamZariadeni)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Zariadenia_zoznam"
        Me.Text = "Zoznam zariadení"
        CType(Me.dgv_ZoznamZariadeni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_ZoznamZariadeni As DataGridView
End Class
