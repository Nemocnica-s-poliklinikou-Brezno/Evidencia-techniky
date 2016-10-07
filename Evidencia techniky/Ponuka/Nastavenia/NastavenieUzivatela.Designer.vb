<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NastavenieUzivatela
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NastavenieUzivatela))
        Me.b_Vytvorit = New System.Windows.Forms.Button()
        Me.b_Ulozit = New System.Windows.Forms.Button()
        Me.b_Vymazat = New System.Windows.Forms.Button()
        Me.tb_Hladaj = New System.Windows.Forms.TextBox()
        Me.b_Vyhladat = New System.Windows.Forms.Button()
        Me.l_Meno = New System.Windows.Forms.Label()
        Me.l_Priezvisko = New System.Windows.Forms.Label()
        Me.l_OsobCislo = New System.Windows.Forms.Label()
        Me.l_UzivatelMeno = New System.Windows.Forms.Label()
        Me.l_Heslo = New System.Windows.Forms.Label()
        Me.CHB_Zablokovany = New System.Windows.Forms.CheckBox()
        Me.CHB_Admin = New System.Windows.Forms.CheckBox()
        Me.tb_Meno = New System.Windows.Forms.TextBox()
        Me.tb_UzivatelMeno = New System.Windows.Forms.TextBox()
        Me.tb_Priezvisko = New System.Windows.Forms.TextBox()
        Me.tb_Heslo = New System.Windows.Forms.TextBox()
        Me.tb_OsobneCislo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_DopravaOdosielatelia = New System.Windows.Forms.ComboBox()
        Me.l_Doprava_Odosielatelia = New System.Windows.Forms.Label()
        Me.cb_Labaky = New System.Windows.Forms.ComboBox()
        Me.l_Labaky = New System.Windows.Forms.Label()
        Me.cb_Doprava = New System.Windows.Forms.ComboBox()
        Me.l_Doprava = New System.Windows.Forms.Label()
        Me.cb_Skumavky = New System.Windows.Forms.ComboBox()
        Me.cb_Pocitace = New System.Windows.Forms.ComboBox()
        Me.cb_Prace = New System.Windows.Forms.ComboBox()
        Me.cb_Ziadanky = New System.Windows.Forms.ComboBox()
        Me.l_Skumavky = New System.Windows.Forms.Label()
        Me.l_Pocitace = New System.Windows.Forms.Label()
        Me.l_Prace = New System.Windows.Forms.Label()
        Me.l_Ziadanky = New System.Windows.Forms.Label()
        Me.l_Email = New System.Windows.Forms.Label()
        Me.tb_Email = New System.Windows.Forms.TextBox()
        Me.tb_Tel = New System.Windows.Forms.TextBox()
        Me.l_Tel = New System.Windows.Forms.Label()
        Me.cb_Oddelenie = New System.Windows.Forms.ComboBox()
        Me.l_Oddelenie = New System.Windows.Forms.Label()
        Me.ll_Oddelenia = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'b_Vytvorit
        '
        Me.b_Vytvorit.Enabled = False
        Me.b_Vytvorit.Location = New System.Drawing.Point(886, 51)
        Me.b_Vytvorit.Name = "b_Vytvorit"
        Me.b_Vytvorit.Size = New System.Drawing.Size(75, 23)
        Me.b_Vytvorit.TabIndex = 18
        Me.b_Vytvorit.Text = "Vytvoriť"
        Me.b_Vytvorit.UseVisualStyleBackColor = True
        '
        'b_Ulozit
        '
        Me.b_Ulozit.Enabled = False
        Me.b_Ulozit.Location = New System.Drawing.Point(886, 81)
        Me.b_Ulozit.Name = "b_Ulozit"
        Me.b_Ulozit.Size = New System.Drawing.Size(75, 23)
        Me.b_Ulozit.TabIndex = 19
        Me.b_Ulozit.Text = "Uložiť"
        Me.b_Ulozit.UseVisualStyleBackColor = True
        '
        'b_Vymazat
        '
        Me.b_Vymazat.Enabled = False
        Me.b_Vymazat.Location = New System.Drawing.Point(886, 111)
        Me.b_Vymazat.Name = "b_Vymazat"
        Me.b_Vymazat.Size = New System.Drawing.Size(75, 23)
        Me.b_Vymazat.TabIndex = 20
        Me.b_Vymazat.Text = "Vymazať"
        Me.b_Vymazat.UseVisualStyleBackColor = True
        '
        'tb_Hladaj
        '
        Me.tb_Hladaj.Location = New System.Drawing.Point(16, 12)
        Me.tb_Hladaj.Name = "tb_Hladaj"
        Me.tb_Hladaj.Size = New System.Drawing.Size(339, 20)
        Me.tb_Hladaj.TabIndex = 1
        '
        'b_Vyhladat
        '
        Me.b_Vyhladat.Location = New System.Drawing.Point(361, 11)
        Me.b_Vyhladat.Name = "b_Vyhladat"
        Me.b_Vyhladat.Size = New System.Drawing.Size(75, 23)
        Me.b_Vyhladat.TabIndex = 2
        Me.b_Vyhladat.Text = "Vyhľadať"
        Me.b_Vyhladat.UseVisualStyleBackColor = True
        '
        'l_Meno
        '
        Me.l_Meno.AutoSize = True
        Me.l_Meno.Location = New System.Drawing.Point(13, 62)
        Me.l_Meno.Name = "l_Meno"
        Me.l_Meno.Size = New System.Drawing.Size(34, 13)
        Me.l_Meno.TabIndex = 5
        Me.l_Meno.Text = "Meno"
        '
        'l_Priezvisko
        '
        Me.l_Priezvisko.AutoSize = True
        Me.l_Priezvisko.Location = New System.Drawing.Point(173, 61)
        Me.l_Priezvisko.Name = "l_Priezvisko"
        Me.l_Priezvisko.Size = New System.Drawing.Size(55, 13)
        Me.l_Priezvisko.TabIndex = 6
        Me.l_Priezvisko.Text = "Priezvisko"
        '
        'l_OsobCislo
        '
        Me.l_OsobCislo.AutoSize = True
        Me.l_OsobCislo.Location = New System.Drawing.Point(408, 61)
        Me.l_OsobCislo.Name = "l_OsobCislo"
        Me.l_OsobCislo.Size = New System.Drawing.Size(70, 13)
        Me.l_OsobCislo.TabIndex = 7
        Me.l_OsobCislo.Text = "Osobné číslo"
        '
        'l_UzivatelMeno
        '
        Me.l_UzivatelMeno.AutoSize = True
        Me.l_UzivatelMeno.Location = New System.Drawing.Point(13, 103)
        Me.l_UzivatelMeno.Name = "l_UzivatelMeno"
        Me.l_UzivatelMeno.Size = New System.Drawing.Size(93, 13)
        Me.l_UzivatelMeno.TabIndex = 8
        Me.l_UzivatelMeno.Text = "Uživateľské meno"
        '
        'l_Heslo
        '
        Me.l_Heslo.AutoSize = True
        Me.l_Heslo.Location = New System.Drawing.Point(229, 103)
        Me.l_Heslo.Name = "l_Heslo"
        Me.l_Heslo.Size = New System.Drawing.Size(34, 13)
        Me.l_Heslo.TabIndex = 9
        Me.l_Heslo.Text = "Heslo"
        '
        'CHB_Zablokovany
        '
        Me.CHB_Zablokovany.AutoSize = True
        Me.CHB_Zablokovany.Location = New System.Drawing.Point(731, 103)
        Me.CHB_Zablokovany.Name = "CHB_Zablokovany"
        Me.CHB_Zablokovany.Size = New System.Drawing.Size(88, 17)
        Me.CHB_Zablokovany.TabIndex = 21
        Me.CHB_Zablokovany.Text = "Zablokovaný"
        Me.CHB_Zablokovany.UseVisualStyleBackColor = True
        '
        'CHB_Admin
        '
        Me.CHB_Admin.AutoSize = True
        Me.CHB_Admin.Location = New System.Drawing.Point(825, 103)
        Me.CHB_Admin.Name = "CHB_Admin"
        Me.CHB_Admin.Size = New System.Drawing.Size(55, 17)
        Me.CHB_Admin.TabIndex = 10
        Me.CHB_Admin.Text = "Admin"
        Me.CHB_Admin.UseVisualStyleBackColor = True
        '
        'tb_Meno
        '
        Me.tb_Meno.Location = New System.Drawing.Point(58, 60)
        Me.tb_Meno.Name = "tb_Meno"
        Me.tb_Meno.Size = New System.Drawing.Size(100, 20)
        Me.tb_Meno.TabIndex = 3
        '
        'tb_UzivatelMeno
        '
        Me.tb_UzivatelMeno.Location = New System.Drawing.Point(116, 100)
        Me.tb_UzivatelMeno.Name = "tb_UzivatelMeno"
        Me.tb_UzivatelMeno.Size = New System.Drawing.Size(100, 20)
        Me.tb_UzivatelMeno.TabIndex = 6
        '
        'tb_Priezvisko
        '
        Me.tb_Priezvisko.Location = New System.Drawing.Point(237, 59)
        Me.tb_Priezvisko.Name = "tb_Priezvisko"
        Me.tb_Priezvisko.Size = New System.Drawing.Size(156, 20)
        Me.tb_Priezvisko.TabIndex = 4
        '
        'tb_Heslo
        '
        Me.tb_Heslo.Location = New System.Drawing.Point(269, 100)
        Me.tb_Heslo.Name = "tb_Heslo"
        Me.tb_Heslo.Size = New System.Drawing.Size(100, 20)
        Me.tb_Heslo.TabIndex = 7
        Me.tb_Heslo.UseSystemPasswordChar = True
        '
        'tb_OsobneCislo
        '
        Me.tb_OsobneCislo.Location = New System.Drawing.Point(487, 59)
        Me.tb_OsobneCislo.Name = "tb_OsobneCislo"
        Me.tb_OsobneCislo.Size = New System.Drawing.Size(100, 20)
        Me.tb_OsobneCislo.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_DopravaOdosielatelia)
        Me.GroupBox1.Controls.Add(Me.l_Doprava_Odosielatelia)
        Me.GroupBox1.Controls.Add(Me.cb_Labaky)
        Me.GroupBox1.Controls.Add(Me.l_Labaky)
        Me.GroupBox1.Controls.Add(Me.cb_Doprava)
        Me.GroupBox1.Controls.Add(Me.l_Doprava)
        Me.GroupBox1.Controls.Add(Me.cb_Skumavky)
        Me.GroupBox1.Controls.Add(Me.cb_Pocitace)
        Me.GroupBox1.Controls.Add(Me.cb_Prace)
        Me.GroupBox1.Controls.Add(Me.cb_Ziadanky)
        Me.GroupBox1.Controls.Add(Me.l_Skumavky)
        Me.GroupBox1.Controls.Add(Me.l_Pocitace)
        Me.GroupBox1.Controls.Add(Me.l_Prace)
        Me.GroupBox1.Controls.Add(Me.l_Ziadanky)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(965, 119)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Práva užívateľa"
        '
        'cb_DopravaOdosielatelia
        '
        Me.cb_DopravaOdosielatelia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cb_DopravaOdosielatelia.FormattingEnabled = True
        Me.cb_DopravaOdosielatelia.Location = New System.Drawing.Point(658, 59)
        Me.cb_DopravaOdosielatelia.Name = "cb_DopravaOdosielatelia"
        Me.cb_DopravaOdosielatelia.Size = New System.Drawing.Size(109, 21)
        Me.cb_DopravaOdosielatelia.TabIndex = 15
        '
        'l_Doprava_Odosielatelia
        '
        Me.l_Doprava_Odosielatelia.AutoSize = True
        Me.l_Doprava_Odosielatelia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_Doprava_Odosielatelia.Location = New System.Drawing.Point(551, 62)
        Me.l_Doprava_Odosielatelia.Name = "l_Doprava_Odosielatelia"
        Me.l_Doprava_Odosielatelia.Size = New System.Drawing.Size(101, 13)
        Me.l_Doprava_Odosielatelia.TabIndex = 28
        Me.l_Doprava_Odosielatelia.Text = "Podľa odoselateľov"
        '
        'cb_Labaky
        '
        Me.cb_Labaky.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cb_Labaky.FormattingEnabled = True
        Me.cb_Labaky.Location = New System.Drawing.Point(836, 32)
        Me.cb_Labaky.Name = "cb_Labaky"
        Me.cb_Labaky.Size = New System.Drawing.Size(110, 21)
        Me.cb_Labaky.TabIndex = 16
        '
        'l_Labaky
        '
        Me.l_Labaky.AutoSize = True
        Me.l_Labaky.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_Labaky.Location = New System.Drawing.Point(773, 35)
        Me.l_Labaky.Name = "l_Labaky"
        Me.l_Labaky.Size = New System.Drawing.Size(42, 13)
        Me.l_Labaky.TabIndex = 26
        Me.l_Labaky.Text = "Labáky"
        '
        'cb_Doprava
        '
        Me.cb_Doprava.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cb_Doprava.FormattingEnabled = True
        Me.cb_Doprava.Location = New System.Drawing.Point(657, 32)
        Me.cb_Doprava.Name = "cb_Doprava"
        Me.cb_Doprava.Size = New System.Drawing.Size(110, 21)
        Me.cb_Doprava.TabIndex = 14
        '
        'l_Doprava
        '
        Me.l_Doprava.AutoSize = True
        Me.l_Doprava.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_Doprava.Location = New System.Drawing.Point(603, 35)
        Me.l_Doprava.Name = "l_Doprava"
        Me.l_Doprava.Size = New System.Drawing.Size(48, 13)
        Me.l_Doprava.TabIndex = 24
        Me.l_Doprava.Text = "Doprava"
        '
        'cb_Skumavky
        '
        Me.cb_Skumavky.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cb_Skumavky.FormattingEnabled = True
        Me.cb_Skumavky.Location = New System.Drawing.Point(836, 59)
        Me.cb_Skumavky.Name = "cb_Skumavky"
        Me.cb_Skumavky.Size = New System.Drawing.Size(110, 21)
        Me.cb_Skumavky.TabIndex = 17
        '
        'cb_Pocitace
        '
        Me.cb_Pocitace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cb_Pocitace.FormattingEnabled = True
        Me.cb_Pocitace.Location = New System.Drawing.Point(67, 32)
        Me.cb_Pocitace.Name = "cb_Pocitace"
        Me.cb_Pocitace.Size = New System.Drawing.Size(110, 21)
        Me.cb_Pocitace.TabIndex = 11
        '
        'cb_Prace
        '
        Me.cb_Prace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cb_Prace.FormattingEnabled = True
        Me.cb_Prace.Location = New System.Drawing.Point(230, 32)
        Me.cb_Prace.Name = "cb_Prace"
        Me.cb_Prace.Size = New System.Drawing.Size(110, 21)
        Me.cb_Prace.TabIndex = 12
        '
        'cb_Ziadanky
        '
        Me.cb_Ziadanky.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cb_Ziadanky.FormattingEnabled = True
        Me.cb_Ziadanky.Location = New System.Drawing.Point(408, 32)
        Me.cb_Ziadanky.Name = "cb_Ziadanky"
        Me.cb_Ziadanky.Size = New System.Drawing.Size(110, 21)
        Me.cb_Ziadanky.TabIndex = 13
        '
        'l_Skumavky
        '
        Me.l_Skumavky.AutoSize = True
        Me.l_Skumavky.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_Skumavky.Location = New System.Drawing.Point(773, 62)
        Me.l_Skumavky.Name = "l_Skumavky"
        Me.l_Skumavky.Size = New System.Drawing.Size(57, 13)
        Me.l_Skumavky.TabIndex = 19
        Me.l_Skumavky.Text = "Skumavky"
        '
        'l_Pocitace
        '
        Me.l_Pocitace.AutoSize = True
        Me.l_Pocitace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_Pocitace.Location = New System.Drawing.Point(10, 35)
        Me.l_Pocitace.Name = "l_Pocitace"
        Me.l_Pocitace.Size = New System.Drawing.Size(51, 13)
        Me.l_Pocitace.TabIndex = 10
        Me.l_Pocitace.Text = "Počítače"
        '
        'l_Prace
        '
        Me.l_Prace.AutoSize = True
        Me.l_Prace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_Prace.Location = New System.Drawing.Point(189, 35)
        Me.l_Prace.Name = "l_Prace"
        Me.l_Prace.Size = New System.Drawing.Size(35, 13)
        Me.l_Prace.TabIndex = 1
        Me.l_Prace.Text = "Práce"
        '
        'l_Ziadanky
        '
        Me.l_Ziadanky.AutoSize = True
        Me.l_Ziadanky.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_Ziadanky.Location = New System.Drawing.Point(351, 35)
        Me.l_Ziadanky.Name = "l_Ziadanky"
        Me.l_Ziadanky.Size = New System.Drawing.Size(51, 13)
        Me.l_Ziadanky.TabIndex = 0
        Me.l_Ziadanky.Text = "Žiadanky"
        '
        'l_Email
        '
        Me.l_Email.AutoSize = True
        Me.l_Email.Location = New System.Drawing.Point(384, 103)
        Me.l_Email.Name = "l_Email"
        Me.l_Email.Size = New System.Drawing.Size(32, 13)
        Me.l_Email.TabIndex = 14
        Me.l_Email.Text = "Email"
        '
        'tb_Email
        '
        Me.tb_Email.Location = New System.Drawing.Point(423, 100)
        Me.tb_Email.Name = "tb_Email"
        Me.tb_Email.Size = New System.Drawing.Size(157, 20)
        Me.tb_Email.TabIndex = 8
        '
        'tb_Tel
        '
        Me.tb_Tel.Location = New System.Drawing.Point(625, 100)
        Me.tb_Tel.Name = "tb_Tel"
        Me.tb_Tel.Size = New System.Drawing.Size(100, 20)
        Me.tb_Tel.TabIndex = 9
        '
        'l_Tel
        '
        Me.l_Tel.AutoSize = True
        Me.l_Tel.Location = New System.Drawing.Point(591, 103)
        Me.l_Tel.Name = "l_Tel"
        Me.l_Tel.Size = New System.Drawing.Size(28, 13)
        Me.l_Tel.TabIndex = 22
        Me.l_Tel.Text = "Tel.:"
        '
        'cb_Oddelenie
        '
        Me.cb_Oddelenie.FormattingEnabled = True
        Me.cb_Oddelenie.Location = New System.Drawing.Point(661, 58)
        Me.cb_Oddelenie.Name = "cb_Oddelenie"
        Me.cb_Oddelenie.Size = New System.Drawing.Size(149, 21)
        Me.cb_Oddelenie.TabIndex = 23
        '
        'l_Oddelenie
        '
        Me.l_Oddelenie.AutoSize = True
        Me.l_Oddelenie.Location = New System.Drawing.Point(599, 62)
        Me.l_Oddelenie.Name = "l_Oddelenie"
        Me.l_Oddelenie.Size = New System.Drawing.Size(55, 13)
        Me.l_Oddelenie.TabIndex = 24
        Me.l_Oddelenie.Text = "Oddelenie"
        '
        'll_Oddelenia
        '
        Me.ll_Oddelenia.AutoSize = True
        Me.ll_Oddelenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ll_Oddelenia.Location = New System.Drawing.Point(813, 62)
        Me.ll_Oddelenia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ll_Oddelenia.Name = "ll_Oddelenia"
        Me.ll_Oddelenia.Size = New System.Drawing.Size(49, 13)
        Me.ll_Oddelenia.TabIndex = 25
        Me.ll_Oddelenia.TabStop = True
        Me.ll_Oddelenia.Text = "Vedlajšie"
        Me.ll_Oddelenia.Visible = False
        '
        'NastavenieUzivatela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(992, 268)
        Me.Controls.Add(Me.ll_Oddelenia)
        Me.Controls.Add(Me.l_Oddelenie)
        Me.Controls.Add(Me.cb_Oddelenie)
        Me.Controls.Add(Me.tb_Tel)
        Me.Controls.Add(Me.l_Tel)
        Me.Controls.Add(Me.tb_Email)
        Me.Controls.Add(Me.l_Email)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tb_OsobneCislo)
        Me.Controls.Add(Me.tb_Heslo)
        Me.Controls.Add(Me.tb_Priezvisko)
        Me.Controls.Add(Me.tb_UzivatelMeno)
        Me.Controls.Add(Me.tb_Meno)
        Me.Controls.Add(Me.CHB_Admin)
        Me.Controls.Add(Me.CHB_Zablokovany)
        Me.Controls.Add(Me.l_Heslo)
        Me.Controls.Add(Me.l_UzivatelMeno)
        Me.Controls.Add(Me.l_OsobCislo)
        Me.Controls.Add(Me.l_Priezvisko)
        Me.Controls.Add(Me.l_Meno)
        Me.Controls.Add(Me.b_Vyhladat)
        Me.Controls.Add(Me.tb_Hladaj)
        Me.Controls.Add(Me.b_Vymazat)
        Me.Controls.Add(Me.b_Ulozit)
        Me.Controls.Add(Me.b_Vytvorit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "NastavenieUzivatela"
        Me.Text = "Nastavenie užívateľa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents b_Vytvorit As Button
    Friend WithEvents b_Ulozit As Button
    Friend WithEvents b_Vymazat As Button
    Friend WithEvents tb_Hladaj As TextBox
    Friend WithEvents b_Vyhladat As Button
    Friend WithEvents l_Meno As Label
    Friend WithEvents l_Priezvisko As Label
    Friend WithEvents l_OsobCislo As Label
    Friend WithEvents l_UzivatelMeno As Label
    Friend WithEvents l_Heslo As Label
    Friend WithEvents CHB_Zablokovany As CheckBox
    Friend WithEvents CHB_Admin As CheckBox
    Friend WithEvents tb_Meno As TextBox
    Friend WithEvents tb_UzivatelMeno As TextBox
    Friend WithEvents tb_Priezvisko As TextBox
    Friend WithEvents tb_Heslo As TextBox
    Friend WithEvents tb_OsobneCislo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents l_Skumavky As Label
    Friend WithEvents l_Pocitace As Label
    Friend WithEvents l_Prace As Label
    Friend WithEvents l_Ziadanky As Label
    Friend WithEvents cb_Skumavky As ComboBox
    Friend WithEvents cb_Pocitace As ComboBox
    Friend WithEvents cb_Prace As ComboBox
    Friend WithEvents cb_Ziadanky As ComboBox
    Friend WithEvents cb_Labaky As ComboBox
    Friend WithEvents l_Labaky As Label
    Friend WithEvents cb_Doprava As ComboBox
    Friend WithEvents l_Doprava As Label
    Friend WithEvents cb_DopravaOdosielatelia As ComboBox
    Friend WithEvents l_Doprava_Odosielatelia As Label
    Friend WithEvents l_Email As Label
    Friend WithEvents tb_Email As TextBox
    Friend WithEvents tb_Tel As TextBox
    Friend WithEvents l_Tel As Label
    Friend WithEvents cb_Oddelenie As ComboBox
    Friend WithEvents l_Oddelenie As Label
    Friend WithEvents ll_Oddelenia As LinkLabel
End Class
