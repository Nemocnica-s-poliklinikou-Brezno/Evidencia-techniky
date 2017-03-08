<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vykaz_materialu
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vykaz_materialu))
        Me.b_Ulozit = New System.Windows.Forms.Button()
        Me.dgv_VykazMaterialu = New System.Windows.Forms.DataGridView()
        Me.b_Kopiruj = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmi_Vymazat = New System.Windows.Forms.ToolStripMenuItem()
        Me.idvykazmaterialu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Datum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cislo_ziadanky = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cislo_vydajky = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kusy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nazov_materialu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_VykazMaterialu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'b_Ulozit
        '
        Me.b_Ulozit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_Ulozit.Enabled = False
        Me.b_Ulozit.Location = New System.Drawing.Point(662, 198)
        Me.b_Ulozit.Name = "b_Ulozit"
        Me.b_Ulozit.Size = New System.Drawing.Size(75, 23)
        Me.b_Ulozit.TabIndex = 0
        Me.b_Ulozit.Text = "Uložiť"
        Me.b_Ulozit.UseVisualStyleBackColor = True
        '
        'dgv_VykazMaterialu
        '
        Me.dgv_VykazMaterialu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_VykazMaterialu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_VykazMaterialu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idvykazmaterialu, Me.Datum, Me.Cislo_ziadanky, Me.Cislo_vydajky, Me.Kusy, Me.Nazov_materialu})
        Me.dgv_VykazMaterialu.Location = New System.Drawing.Point(13, 13)
        Me.dgv_VykazMaterialu.Name = "dgv_VykazMaterialu"
        Me.dgv_VykazMaterialu.Size = New System.Drawing.Size(724, 179)
        Me.dgv_VykazMaterialu.TabIndex = 1
        '
        'b_Kopiruj
        '
        Me.b_Kopiruj.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_Kopiruj.Location = New System.Drawing.Point(579, 198)
        Me.b_Kopiruj.Name = "b_Kopiruj"
        Me.b_Kopiruj.Size = New System.Drawing.Size(75, 23)
        Me.b_Kopiruj.TabIndex = 2
        Me.b_Kopiruj.Text = "Kopíruj"
        Me.b_Kopiruj.UseVisualStyleBackColor = True
        Me.b_Kopiruj.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Vymazat})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        'tsmi_Vymazat
        '
        Me.tsmi_Vymazat.Name = "tsmi_Vymazat"
        Me.tsmi_Vymazat.Size = New System.Drawing.Size(152, 22)
        Me.tsmi_Vymazat.Text = "Vymazať"
        Me.tsmi_Vymazat.Visible = False
        '
        'idvykazmaterialu
        '
        Me.idvykazmaterialu.HeaderText = "idvykazmaterialu"
        Me.idvykazmaterialu.Name = "idvykazmaterialu"
        Me.idvykazmaterialu.Visible = False
        '
        'Datum
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Datum.DefaultCellStyle = DataGridViewCellStyle2
        Me.Datum.HeaderText = "Dátum"
        Me.Datum.Name = "Datum"
        '
        'Cislo_ziadanky
        '
        Me.Cislo_ziadanky.HeaderText = "Číslo žiadanky"
        Me.Cislo_ziadanky.Name = "Cislo_ziadanky"
        '
        'Cislo_vydajky
        '
        Me.Cislo_vydajky.HeaderText = "Číslo výdajky"
        Me.Cislo_vydajky.Name = "Cislo_vydajky"
        '
        'Kusy
        '
        Me.Kusy.HeaderText = "Kusy"
        Me.Kusy.Name = "Kusy"
        '
        'Nazov_materialu
        '
        Me.Nazov_materialu.HeaderText = "Názov materiálu"
        Me.Nazov_materialu.Name = "Nazov_materialu"
        '
        'Vykaz_materialu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 233)
        Me.Controls.Add(Me.b_Kopiruj)
        Me.Controls.Add(Me.dgv_VykazMaterialu)
        Me.Controls.Add(Me.b_Ulozit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Vykaz_materialu"
        Me.Text = "Výkaz materiálu"
        CType(Me.dgv_VykazMaterialu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents b_Ulozit As Button
    Friend WithEvents dgv_VykazMaterialu As DataGridView
    Friend WithEvents b_Kopiruj As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents tsmi_Vymazat As ToolStripMenuItem
    Friend WithEvents idvykazmaterialu As DataGridViewTextBoxColumn
    Friend WithEvents Datum As DataGridViewTextBoxColumn
    Friend WithEvents Cislo_ziadanky As DataGridViewTextBoxColumn
    Friend WithEvents Cislo_vydajky As DataGridViewTextBoxColumn
    Friend WithEvents Kusy As DataGridViewTextBoxColumn
    Friend WithEvents Nazov_materialu As DataGridViewTextBoxColumn
End Class
