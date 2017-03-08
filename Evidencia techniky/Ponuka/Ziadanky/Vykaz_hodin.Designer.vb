<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vykaz_hodin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vykaz_hodin))
        Me.b_Ulozit = New System.Windows.Forms.Button()
        Me.tb_SumarHodin = New System.Windows.Forms.TextBox()
        Me.gb_VykazaneHodiny = New System.Windows.Forms.GroupBox()
        Me.cb_POddelenie = New System.Windows.Forms.ComboBox()
        Me.l_PSumarHodin = New System.Windows.Forms.Label()
        Me.l_CisloZiadanky = New System.Windows.Forms.Label()
        Me.l_PCisloZiadanky = New System.Windows.Forms.Label()
        Me.l_Sumar_hodín = New System.Windows.Forms.Label()
        Me.l_Oddelenie = New System.Windows.Forms.Label()
        Me.l_Datum = New System.Windows.Forms.Label()
        Me.l_PDatum = New System.Windows.Forms.Label()
        Me.b_Pridat = New System.Windows.Forms.Button()
        Me.gb_VykazaneHodiny.SuspendLayout()
        Me.SuspendLayout()
        '
        'b_Ulozit
        '
        Me.b_Ulozit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_Ulozit.Enabled = False
        Me.b_Ulozit.Location = New System.Drawing.Point(375, 106)
        Me.b_Ulozit.Name = "b_Ulozit"
        Me.b_Ulozit.Size = New System.Drawing.Size(75, 23)
        Me.b_Ulozit.TabIndex = 0
        Me.b_Ulozit.Text = "Uložiť"
        Me.b_Ulozit.UseVisualStyleBackColor = True
        '
        'tb_SumarHodin
        '
        Me.tb_SumarHodin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb_SumarHodin.Location = New System.Drawing.Point(314, 47)
        Me.tb_SumarHodin.Name = "tb_SumarHodin"
        Me.tb_SumarHodin.Size = New System.Drawing.Size(100, 26)
        Me.tb_SumarHodin.TabIndex = 1
        Me.tb_SumarHodin.Visible = False
        '
        'gb_VykazaneHodiny
        '
        Me.gb_VykazaneHodiny.Controls.Add(Me.cb_POddelenie)
        Me.gb_VykazaneHodiny.Controls.Add(Me.l_PSumarHodin)
        Me.gb_VykazaneHodiny.Controls.Add(Me.l_CisloZiadanky)
        Me.gb_VykazaneHodiny.Controls.Add(Me.l_PCisloZiadanky)
        Me.gb_VykazaneHodiny.Controls.Add(Me.l_Sumar_hodín)
        Me.gb_VykazaneHodiny.Controls.Add(Me.l_Oddelenie)
        Me.gb_VykazaneHodiny.Controls.Add(Me.l_Datum)
        Me.gb_VykazaneHodiny.Controls.Add(Me.l_PDatum)
        Me.gb_VykazaneHodiny.Controls.Add(Me.tb_SumarHodin)
        Me.gb_VykazaneHodiny.Location = New System.Drawing.Point(13, 13)
        Me.gb_VykazaneHodiny.Name = "gb_VykazaneHodiny"
        Me.gb_VykazaneHodiny.Size = New System.Drawing.Size(437, 91)
        Me.gb_VykazaneHodiny.TabIndex = 2
        Me.gb_VykazaneHodiny.TabStop = False
        Me.gb_VykazaneHodiny.Text = "Vykázané hodiny"
        '
        'cb_POddelenie
        '
        Me.cb_POddelenie.DropDownWidth = 200
        Me.cb_POddelenie.FormattingEnabled = True
        Me.cb_POddelenie.Location = New System.Drawing.Point(217, 50)
        Me.cb_POddelenie.Name = "cb_POddelenie"
        Me.cb_POddelenie.Size = New System.Drawing.Size(77, 21)
        Me.cb_POddelenie.TabIndex = 10
        '
        'l_PSumarHodin
        '
        Me.l_PSumarHodin.AutoSize = True
        Me.l_PSumarHodin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_PSumarHodin.Location = New System.Drawing.Point(312, 50)
        Me.l_PSumarHodin.Name = "l_PSumarHodin"
        Me.l_PSumarHodin.Size = New System.Drawing.Size(114, 20)
        Me.l_PSumarHodin.TabIndex = 9
        Me.l_PSumarHodin.Text = "@SumarHodin"
        Me.l_PSumarHodin.Visible = False
        '
        'l_CisloZiadanky
        '
        Me.l_CisloZiadanky.AutoSize = True
        Me.l_CisloZiadanky.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_CisloZiadanky.Location = New System.Drawing.Point(6, 21)
        Me.l_CisloZiadanky.Name = "l_CisloZiadanky"
        Me.l_CisloZiadanky.Size = New System.Drawing.Size(109, 20)
        Me.l_CisloZiadanky.TabIndex = 8
        Me.l_CisloZiadanky.Text = "Číslo žiadanky"
        '
        'l_PCisloZiadanky
        '
        Me.l_PCisloZiadanky.AutoSize = True
        Me.l_PCisloZiadanky.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_PCisloZiadanky.Location = New System.Drawing.Point(6, 50)
        Me.l_PCisloZiadanky.Name = "l_PCisloZiadanky"
        Me.l_PCisloZiadanky.Size = New System.Drawing.Size(105, 20)
        Me.l_PCisloZiadanky.TabIndex = 7
        Me.l_PCisloZiadanky.Text = "@Žiadanky č."
        '
        'l_Sumar_hodín
        '
        Me.l_Sumar_hodín.AutoSize = True
        Me.l_Sumar_hodín.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_Sumar_hodín.Location = New System.Drawing.Point(310, 21)
        Me.l_Sumar_hodín.Name = "l_Sumar_hodín"
        Me.l_Sumar_hodín.Size = New System.Drawing.Size(99, 20)
        Me.l_Sumar_hodín.TabIndex = 6
        Me.l_Sumar_hodín.Text = "Sumár hodín"
        '
        'l_Oddelenie
        '
        Me.l_Oddelenie.AutoSize = True
        Me.l_Oddelenie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_Oddelenie.Location = New System.Drawing.Point(213, 21)
        Me.l_Oddelenie.Name = "l_Oddelenie"
        Me.l_Oddelenie.Size = New System.Drawing.Size(81, 20)
        Me.l_Oddelenie.TabIndex = 5
        Me.l_Oddelenie.Text = "Oddelenie"
        '
        'l_Datum
        '
        Me.l_Datum.AutoSize = True
        Me.l_Datum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_Datum.Location = New System.Drawing.Point(120, 21)
        Me.l_Datum.Name = "l_Datum"
        Me.l_Datum.Size = New System.Drawing.Size(57, 20)
        Me.l_Datum.TabIndex = 4
        Me.l_Datum.Text = "Dátum"
        '
        'l_PDatum
        '
        Me.l_PDatum.AutoSize = True
        Me.l_PDatum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_PDatum.Location = New System.Drawing.Point(120, 50)
        Me.l_PDatum.Name = "l_PDatum"
        Me.l_PDatum.Size = New System.Drawing.Size(73, 20)
        Me.l_PDatum.TabIndex = 2
        Me.l_PDatum.Text = "@Dátum"
        '
        'b_Pridat
        '
        Me.b_Pridat.Enabled = False
        Me.b_Pridat.Location = New System.Drawing.Point(294, 106)
        Me.b_Pridat.Name = "b_Pridat"
        Me.b_Pridat.Size = New System.Drawing.Size(75, 23)
        Me.b_Pridat.TabIndex = 3
        Me.b_Pridat.Text = "Pridať"
        Me.b_Pridat.UseVisualStyleBackColor = True
        '
        'Vykaz_hodin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 141)
        Me.Controls.Add(Me.b_Pridat)
        Me.Controls.Add(Me.gb_VykazaneHodiny)
        Me.Controls.Add(Me.b_Ulozit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Vykaz_hodin"
        Me.Text = "Výkaz hodín prác"
        Me.gb_VykazaneHodiny.ResumeLayout(False)
        Me.gb_VykazaneHodiny.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents b_Ulozit As Button
    Friend WithEvents tb_SumarHodin As TextBox
    Friend WithEvents gb_VykazaneHodiny As GroupBox
    Friend WithEvents l_PDatum As Label
    Friend WithEvents l_Sumar_hodín As Label
    Friend WithEvents l_Oddelenie As Label
    Friend WithEvents l_Datum As Label
    Friend WithEvents l_CisloZiadanky As Label
    Friend WithEvents l_PCisloZiadanky As Label
    Friend WithEvents l_PSumarHodin As Label
    Friend WithEvents cb_POddelenie As ComboBox
    Friend WithEvents b_Pridat As Button
End Class
