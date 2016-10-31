<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ziadanky_sprava
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ziadanky_sprava))
        Me.cb_TypUlohy = New System.Windows.Forms.ComboBox()
        Me.l_ZmenaNa = New System.Windows.Forms.Label()
        Me.cb_TypPoziadavky = New System.Windows.Forms.ComboBox()
        Me.cb_TypPrace = New System.Windows.Forms.ComboBox()
        Me.l_TypPoziadavky = New System.Windows.Forms.Label()
        Me.l_TypPrace = New System.Windows.Forms.Label()
        Me.l_Oddelenie = New System.Windows.Forms.Label()
        Me.l_Miestnost = New System.Windows.Forms.Label()
        Me.l_PopisPoziadavky = New System.Windows.Forms.Label()
        Me.l_PZadavatel = New System.Windows.Forms.Label()
        Me.l_Zadavatel = New System.Windows.Forms.Label()
        Me.rtb_PopisPoziadavky = New System.Windows.Forms.RichTextBox()
        Me.l_Spracuvava = New System.Windows.Forms.Label()
        Me.b_Ulozit = New System.Windows.Forms.Button()
        Me.cb_StavUlohy = New System.Windows.Forms.ComboBox()
        Me.l_Stav = New System.Windows.Forms.Label()
        Me.b_Tlac = New System.Windows.Forms.Button()
        Me.b_Hodiny = New System.Windows.Forms.Button()
        Me.b_Material = New System.Windows.Forms.Button()
        Me.l_UlohaCislo = New System.Windows.Forms.Label()
        Me.l_PUlohaCislo = New System.Windows.Forms.Label()
        Me.chb_Urgencia = New System.Windows.Forms.CheckBox()
        Me.l_Pomocny = New System.Windows.Forms.Label()
        Me.l_NahlaseneDna = New System.Windows.Forms.Label()
        Me.cb_ZOddelenia = New System.Windows.Forms.ComboBox()
        Me.tb_Miestnost = New System.Windows.Forms.TextBox()
        Me.b_Pridat = New System.Windows.Forms.Button()
        Me.ll_PridatOdd = New System.Windows.Forms.LinkLabel()
        Me.l_Vymazat = New System.Windows.Forms.Label()
        Me.chb_Zeny = New System.Windows.Forms.CheckBox()
        Me.chb_Muzi = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cb_TypUlohy
        '
        Me.cb_TypUlohy.Enabled = False
        Me.cb_TypUlohy.FormattingEnabled = True
        Me.cb_TypUlohy.Location = New System.Drawing.Point(348, 50)
        Me.cb_TypUlohy.Name = "cb_TypUlohy"
        Me.cb_TypUlohy.Size = New System.Drawing.Size(95, 21)
        Me.cb_TypUlohy.TabIndex = 1
        '
        'l_ZmenaNa
        '
        Me.l_ZmenaNa.AutoSize = True
        Me.l_ZmenaNa.Location = New System.Drawing.Point(287, 53)
        Me.l_ZmenaNa.Name = "l_ZmenaNa"
        Me.l_ZmenaNa.Size = New System.Drawing.Size(55, 13)
        Me.l_ZmenaNa.TabIndex = 2
        Me.l_ZmenaNa.Text = "Zmena na"
        '
        'cb_TypPoziadavky
        '
        Me.cb_TypPoziadavky.FormattingEnabled = True
        Me.cb_TypPoziadavky.Location = New System.Drawing.Point(102, 50)
        Me.cb_TypPoziadavky.Name = "cb_TypPoziadavky"
        Me.cb_TypPoziadavky.Size = New System.Drawing.Size(121, 21)
        Me.cb_TypPoziadavky.TabIndex = 3
        '
        'cb_TypPrace
        '
        Me.cb_TypPrace.FormattingEnabled = True
        Me.cb_TypPrace.Location = New System.Drawing.Point(102, 79)
        Me.cb_TypPrace.Name = "cb_TypPrace"
        Me.cb_TypPrace.Size = New System.Drawing.Size(121, 21)
        Me.cb_TypPrace.TabIndex = 4
        '
        'l_TypPoziadavky
        '
        Me.l_TypPoziadavky.AutoSize = True
        Me.l_TypPoziadavky.Location = New System.Drawing.Point(14, 54)
        Me.l_TypPoziadavky.Name = "l_TypPoziadavky"
        Me.l_TypPoziadavky.Size = New System.Drawing.Size(82, 13)
        Me.l_TypPoziadavky.TabIndex = 5
        Me.l_TypPoziadavky.Text = "Typ požiadavky"
        '
        'l_TypPrace
        '
        Me.l_TypPrace.AutoSize = True
        Me.l_TypPrace.Location = New System.Drawing.Point(41, 82)
        Me.l_TypPrace.Name = "l_TypPrace"
        Me.l_TypPrace.Size = New System.Drawing.Size(55, 13)
        Me.l_TypPrace.TabIndex = 6
        Me.l_TypPrace.Text = "Typ práce"
        '
        'l_Oddelenie
        '
        Me.l_Oddelenie.AutoSize = True
        Me.l_Oddelenie.Location = New System.Drawing.Point(41, 111)
        Me.l_Oddelenie.Name = "l_Oddelenie"
        Me.l_Oddelenie.Size = New System.Drawing.Size(55, 13)
        Me.l_Oddelenie.TabIndex = 7
        Me.l_Oddelenie.Text = "Oddelenie"
        '
        'l_Miestnost
        '
        Me.l_Miestnost.AutoSize = True
        Me.l_Miestnost.Location = New System.Drawing.Point(41, 138)
        Me.l_Miestnost.Name = "l_Miestnost"
        Me.l_Miestnost.Size = New System.Drawing.Size(53, 13)
        Me.l_Miestnost.TabIndex = 9
        Me.l_Miestnost.Text = "Miestnosť"
        '
        'l_PopisPoziadavky
        '
        Me.l_PopisPoziadavky.AutoSize = True
        Me.l_PopisPoziadavky.Location = New System.Drawing.Point(6, 178)
        Me.l_PopisPoziadavky.Name = "l_PopisPoziadavky"
        Me.l_PopisPoziadavky.Size = New System.Drawing.Size(90, 13)
        Me.l_PopisPoziadavky.TabIndex = 11
        Me.l_PopisPoziadavky.Text = "Popis požiadavky"
        '
        'l_PZadavatel
        '
        Me.l_PZadavatel.AllowDrop = True
        Me.l_PZadavatel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_PZadavatel.AutoSize = True
        Me.l_PZadavatel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_PZadavatel.Location = New System.Drawing.Point(101, 385)
        Me.l_PZadavatel.Name = "l_PZadavatel"
        Me.l_PZadavatel.Size = New System.Drawing.Size(76, 13)
        Me.l_PZadavatel.TabIndex = 14
        Me.l_PZadavatel.Text = "@Zadavatel"
        '
        'l_Zadavatel
        '
        Me.l_Zadavatel.AutoSize = True
        Me.l_Zadavatel.Location = New System.Drawing.Point(39, 385)
        Me.l_Zadavatel.Name = "l_Zadavatel"
        Me.l_Zadavatel.Size = New System.Drawing.Size(57, 13)
        Me.l_Zadavatel.TabIndex = 13
        Me.l_Zadavatel.Text = "Zadávateľ"
        '
        'rtb_PopisPoziadavky
        '
        Me.rtb_PopisPoziadavky.Location = New System.Drawing.Point(102, 178)
        Me.rtb_PopisPoziadavky.Name = "rtb_PopisPoziadavky"
        Me.rtb_PopisPoziadavky.Size = New System.Drawing.Size(367, 194)
        Me.rtb_PopisPoziadavky.TabIndex = 17
        Me.rtb_PopisPoziadavky.Text = ""
        '
        'l_Spracuvava
        '
        Me.l_Spracuvava.AutoSize = True
        Me.l_Spracuvava.Location = New System.Drawing.Point(277, 85)
        Me.l_Spracuvava.Name = "l_Spracuvava"
        Me.l_Spracuvava.Size = New System.Drawing.Size(65, 13)
        Me.l_Spracuvava.TabIndex = 19
        Me.l_Spracuvava.Text = "Spracuváva"
        '
        'b_Ulozit
        '
        Me.b_Ulozit.Location = New System.Drawing.Point(394, 419)
        Me.b_Ulozit.Name = "b_Ulozit"
        Me.b_Ulozit.Size = New System.Drawing.Size(75, 23)
        Me.b_Ulozit.TabIndex = 20
        Me.b_Ulozit.Text = "Uložiť"
        Me.b_Ulozit.UseVisualStyleBackColor = True
        '
        'cb_StavUlohy
        '
        Me.cb_StavUlohy.FormattingEnabled = True
        Me.cb_StavUlohy.Location = New System.Drawing.Point(348, 110)
        Me.cb_StavUlohy.Name = "cb_StavUlohy"
        Me.cb_StavUlohy.Size = New System.Drawing.Size(121, 21)
        Me.cb_StavUlohy.TabIndex = 21
        '
        'l_Stav
        '
        Me.l_Stav.AutoSize = True
        Me.l_Stav.Location = New System.Drawing.Point(313, 113)
        Me.l_Stav.Name = "l_Stav"
        Me.l_Stav.Size = New System.Drawing.Size(29, 13)
        Me.l_Stav.TabIndex = 22
        Me.l_Stav.Text = "Stav"
        '
        'b_Tlac
        '
        Me.b_Tlac.Enabled = False
        Me.b_Tlac.Location = New System.Drawing.Point(313, 419)
        Me.b_Tlac.Name = "b_Tlac"
        Me.b_Tlac.Size = New System.Drawing.Size(75, 23)
        Me.b_Tlac.TabIndex = 23
        Me.b_Tlac.Text = "Tlač"
        Me.b_Tlac.UseVisualStyleBackColor = True
        Me.b_Tlac.Visible = False
        '
        'b_Hodiny
        '
        Me.b_Hodiny.Enabled = False
        Me.b_Hodiny.Location = New System.Drawing.Point(92, 420)
        Me.b_Hodiny.Name = "b_Hodiny"
        Me.b_Hodiny.Size = New System.Drawing.Size(75, 23)
        Me.b_Hodiny.TabIndex = 24
        Me.b_Hodiny.Text = "Hodiny"
        Me.b_Hodiny.UseVisualStyleBackColor = True
        '
        'b_Material
        '
        Me.b_Material.Enabled = False
        Me.b_Material.Location = New System.Drawing.Point(11, 419)
        Me.b_Material.Name = "b_Material"
        Me.b_Material.Size = New System.Drawing.Size(75, 23)
        Me.b_Material.TabIndex = 25
        Me.b_Material.Text = "Materiál"
        Me.b_Material.UseVisualStyleBackColor = True
        '
        'l_UlohaCislo
        '
        Me.l_UlohaCislo.AutoSize = True
        Me.l_UlohaCislo.Location = New System.Drawing.Point(9, 13)
        Me.l_UlohaCislo.Name = "l_UlohaCislo"
        Me.l_UlohaCislo.Size = New System.Drawing.Size(79, 13)
        Me.l_UlohaCislo.TabIndex = 26
        Me.l_UlohaCislo.Text = "Číslo žiadanky:"
        '
        'l_PUlohaCislo
        '
        Me.l_PUlohaCislo.AutoSize = True
        Me.l_PUlohaCislo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_PUlohaCislo.Location = New System.Drawing.Point(94, 9)
        Me.l_PUlohaCislo.Name = "l_PUlohaCislo"
        Me.l_PUlohaCislo.Size = New System.Drawing.Size(115, 20)
        Me.l_PUlohaCislo.TabIndex = 27
        Me.l_PUlohaCislo.Text = "@Číslo Žiada"
        '
        'chb_Urgencia
        '
        Me.chb_Urgencia.AutoSize = True
        Me.chb_Urgencia.ForeColor = System.Drawing.Color.Red
        Me.chb_Urgencia.Location = New System.Drawing.Point(372, 13)
        Me.chb_Urgencia.Name = "chb_Urgencia"
        Me.chb_Urgencia.Size = New System.Drawing.Size(69, 17)
        Me.chb_Urgencia.TabIndex = 29
        Me.chb_Urgencia.Text = "Urgencia"
        Me.chb_Urgencia.UseVisualStyleBackColor = True
        '
        'l_Pomocny
        '
        Me.l_Pomocny.AutoSize = True
        Me.l_Pomocny.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_Pomocny.Location = New System.Drawing.Point(211, 11)
        Me.l_Pomocny.Name = "l_Pomocny"
        Me.l_Pomocny.Size = New System.Drawing.Size(12, 16)
        Me.l_Pomocny.TabIndex = 30
        Me.l_Pomocny.Text = "/"
        '
        'l_NahlaseneDna
        '
        Me.l_NahlaseneDna.AutoSize = True
        Me.l_NahlaseneDna.Location = New System.Drawing.Point(224, 15)
        Me.l_NahlaseneDna.Name = "l_NahlaseneDna"
        Me.l_NahlaseneDna.Size = New System.Drawing.Size(90, 13)
        Me.l_NahlaseneDna.TabIndex = 31
        Me.l_NahlaseneDna.Text = "@Nahlásené dňa"
        '
        'cb_ZOddelenia
        '
        Me.cb_ZOddelenia.FormattingEnabled = True
        Me.cb_ZOddelenia.Location = New System.Drawing.Point(102, 108)
        Me.cb_ZOddelenia.Name = "cb_ZOddelenia"
        Me.cb_ZOddelenia.Size = New System.Drawing.Size(121, 21)
        Me.cb_ZOddelenia.TabIndex = 32
        '
        'tb_Miestnost
        '
        Me.tb_Miestnost.Location = New System.Drawing.Point(102, 136)
        Me.tb_Miestnost.Name = "tb_Miestnost"
        Me.tb_Miestnost.Size = New System.Drawing.Size(121, 20)
        Me.tb_Miestnost.TabIndex = 33
        '
        'b_Pridat
        '
        Me.b_Pridat.Location = New System.Drawing.Point(348, 80)
        Me.b_Pridat.Name = "b_Pridat"
        Me.b_Pridat.Size = New System.Drawing.Size(75, 23)
        Me.b_Pridat.TabIndex = 34
        Me.b_Pridat.Text = "Pridať"
        Me.b_Pridat.UseVisualStyleBackColor = True
        Me.b_Pridat.Visible = False
        '
        'll_PridatOdd
        '
        Me.ll_PridatOdd.AutoSize = True
        Me.ll_PridatOdd.Location = New System.Drawing.Point(273, 116)
        Me.ll_PridatOdd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ll_PridatOdd.Name = "ll_PridatOdd"
        Me.ll_PridatOdd.Size = New System.Drawing.Size(35, 13)
        Me.ll_PridatOdd.TabIndex = 35
        Me.ll_PridatOdd.TabStop = True
        Me.ll_PridatOdd.Text = "Pridať"
        Me.ll_PridatOdd.Visible = False
        '
        'l_Vymazat
        '
        Me.l_Vymazat.AutoSize = True
        Me.l_Vymazat.Location = New System.Drawing.Point(419, 375)
        Me.l_Vymazat.Name = "l_Vymazat"
        Me.l_Vymazat.Size = New System.Drawing.Size(48, 13)
        Me.l_Vymazat.TabIndex = 36
        Me.l_Vymazat.Text = "Vymazať"
        Me.l_Vymazat.Visible = False
        '
        'chb_Zeny
        '
        Me.chb_Zeny.AutoSize = True
        Me.chb_Zeny.Location = New System.Drawing.Point(226, 115)
        Me.chb_Zeny.Name = "chb_Zeny"
        Me.chb_Zeny.Size = New System.Drawing.Size(50, 17)
        Me.chb_Zeny.TabIndex = 38
        Me.chb_Zeny.Text = "Ženy"
        Me.chb_Zeny.UseVisualStyleBackColor = True
        '
        'chb_Muzi
        '
        Me.chb_Muzi.AutoSize = True
        Me.chb_Muzi.Location = New System.Drawing.Point(226, 101)
        Me.chb_Muzi.Name = "chb_Muzi"
        Me.chb_Muzi.Size = New System.Drawing.Size(48, 17)
        Me.chb_Muzi.TabIndex = 37
        Me.chb_Muzi.Text = "Muži"
        Me.chb_Muzi.UseVisualStyleBackColor = True
        '
        'Ziadanky_sprava
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 463)
        Me.Controls.Add(Me.chb_Zeny)
        Me.Controls.Add(Me.chb_Muzi)
        Me.Controls.Add(Me.l_Vymazat)
        Me.Controls.Add(Me.ll_PridatOdd)
        Me.Controls.Add(Me.b_Pridat)
        Me.Controls.Add(Me.tb_Miestnost)
        Me.Controls.Add(Me.cb_ZOddelenia)
        Me.Controls.Add(Me.l_NahlaseneDna)
        Me.Controls.Add(Me.l_Pomocny)
        Me.Controls.Add(Me.chb_Urgencia)
        Me.Controls.Add(Me.l_PUlohaCislo)
        Me.Controls.Add(Me.l_UlohaCislo)
        Me.Controls.Add(Me.b_Material)
        Me.Controls.Add(Me.b_Hodiny)
        Me.Controls.Add(Me.b_Tlac)
        Me.Controls.Add(Me.l_Stav)
        Me.Controls.Add(Me.cb_StavUlohy)
        Me.Controls.Add(Me.b_Ulozit)
        Me.Controls.Add(Me.l_Spracuvava)
        Me.Controls.Add(Me.rtb_PopisPoziadavky)
        Me.Controls.Add(Me.l_PZadavatel)
        Me.Controls.Add(Me.l_Zadavatel)
        Me.Controls.Add(Me.l_PopisPoziadavky)
        Me.Controls.Add(Me.l_Miestnost)
        Me.Controls.Add(Me.l_Oddelenie)
        Me.Controls.Add(Me.l_TypPrace)
        Me.Controls.Add(Me.l_TypPoziadavky)
        Me.Controls.Add(Me.cb_TypPrace)
        Me.Controls.Add(Me.cb_TypPoziadavky)
        Me.Controls.Add(Me.l_ZmenaNa)
        Me.Controls.Add(Me.cb_TypUlohy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Ziadanky_sprava"
        Me.Text = "Žiadanky správa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cb_TypUlohy As ComboBox
    Friend WithEvents l_ZmenaNa As Label
    Friend WithEvents cb_TypPoziadavky As ComboBox
    Friend WithEvents cb_TypPrace As ComboBox
    Friend WithEvents l_TypPoziadavky As Label
    Friend WithEvents l_TypPrace As Label
    Friend WithEvents l_Oddelenie As Label
    Friend WithEvents l_Miestnost As Label
    Friend WithEvents l_PopisPoziadavky As Label
    Friend WithEvents l_PZadavatel As Label
    Friend WithEvents l_Zadavatel As Label
    Friend WithEvents rtb_PopisPoziadavky As RichTextBox
    Friend WithEvents l_Spracuvava As Label
    Friend WithEvents b_Ulozit As Button
    Friend WithEvents cb_StavUlohy As ComboBox
    Friend WithEvents l_Stav As Label
    Friend WithEvents b_Tlac As Button
    Friend WithEvents b_Hodiny As Button
    Friend WithEvents b_Material As Button
    Friend WithEvents l_UlohaCislo As Label
    Friend WithEvents l_PUlohaCislo As Label
    Friend WithEvents chb_Urgencia As CheckBox
    Friend WithEvents l_Pomocny As Label
    Friend WithEvents l_NahlaseneDna As Label
    Friend WithEvents cb_ZOddelenia As ComboBox
    Friend WithEvents tb_Miestnost As TextBox
    Friend WithEvents b_Pridat As Button
    Friend WithEvents ll_PridatOdd As LinkLabel
    Friend WithEvents l_Vymazat As Label
    Friend WithEvents chb_Zeny As CheckBox
    Friend WithEvents chb_Muzi As CheckBox
End Class
