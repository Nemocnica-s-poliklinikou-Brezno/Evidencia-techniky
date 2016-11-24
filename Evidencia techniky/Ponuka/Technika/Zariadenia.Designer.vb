<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Zariadenia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Zariadenia))
        Me.gb_ZakladneUdaje = New System.Windows.Forms.GroupBox()
        Me.cb_TypZariadenia = New System.Windows.Forms.ComboBox()
        Me.l_TypZariadenia = New System.Windows.Forms.Label()
        Me.cb_Vyrobca = New System.Windows.Forms.ComboBox()
        Me.l_p_Teamviewer = New System.Windows.Forms.Label()
        Me.l_Teamviewer = New System.Windows.Forms.Label()
        Me.tb_EvidencneCislo = New System.Windows.Forms.TextBox()
        Me.dtp_Vyradeny = New System.Windows.Forms.DateTimePicker()
        Me.tb_VyrobneCislo = New System.Windows.Forms.TextBox()
        Me.tb_SerioveCislo = New System.Windows.Forms.TextBox()
        Me.tb_Model = New System.Windows.Forms.TextBox()
        Me.l_Vyradeny = New System.Windows.Forms.Label()
        Me.l_EvidencneCislo = New System.Windows.Forms.Label()
        Me.l_VyrobneCislo = New System.Windows.Forms.Label()
        Me.l_SerioveCislo = New System.Windows.Forms.Label()
        Me.l_Model = New System.Windows.Forms.Label()
        Me.l_Vyrobca = New System.Windows.Forms.Label()
        Me.b_Vytvorit = New System.Windows.Forms.Button()
        Me.b_Zmenit = New System.Windows.Forms.Button()
        Me.tb_Vyhladat = New System.Windows.Forms.TextBox()
        Me.l_Vyhladat = New System.Windows.Forms.Label()
        Me.b_Vyhladat = New System.Windows.Forms.Button()
        Me.b_Fakturacne = New System.Windows.Forms.Button()
        Me.b_Software = New System.Windows.Forms.Button()
        Me.b_Hardware = New System.Windows.Forms.Button()
        Me.tp_HistoriaPresunov = New System.Windows.Forms.TabPage()
        Me.dgv_Presun = New System.Windows.Forms.DataGridView()
        Me.tp_HistoriaOprav = New System.Windows.Forms.TabPage()
        Me.dgv_Servis = New System.Windows.Forms.DataGridView()
        Me.tc_Historia = New System.Windows.Forms.TabControl()
        Me.b_Presun = New System.Windows.Forms.Button()
        Me.b_Servis = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmi_Upravit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_Vymazat = New System.Windows.Forms.ToolStripMenuItem()
        Me.gb_ZakladneUdaje.SuspendLayout()
        Me.tp_HistoriaPresunov.SuspendLayout()
        CType(Me.dgv_Presun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_HistoriaOprav.SuspendLayout()
        CType(Me.dgv_Servis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tc_Historia.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_ZakladneUdaje
        '
        Me.gb_ZakladneUdaje.Controls.Add(Me.cb_TypZariadenia)
        Me.gb_ZakladneUdaje.Controls.Add(Me.l_TypZariadenia)
        Me.gb_ZakladneUdaje.Controls.Add(Me.cb_Vyrobca)
        Me.gb_ZakladneUdaje.Controls.Add(Me.l_p_Teamviewer)
        Me.gb_ZakladneUdaje.Controls.Add(Me.l_Teamviewer)
        Me.gb_ZakladneUdaje.Controls.Add(Me.tb_EvidencneCislo)
        Me.gb_ZakladneUdaje.Controls.Add(Me.dtp_Vyradeny)
        Me.gb_ZakladneUdaje.Controls.Add(Me.tb_VyrobneCislo)
        Me.gb_ZakladneUdaje.Controls.Add(Me.tb_SerioveCislo)
        Me.gb_ZakladneUdaje.Controls.Add(Me.tb_Model)
        Me.gb_ZakladneUdaje.Controls.Add(Me.l_Vyradeny)
        Me.gb_ZakladneUdaje.Controls.Add(Me.l_EvidencneCislo)
        Me.gb_ZakladneUdaje.Controls.Add(Me.l_VyrobneCislo)
        Me.gb_ZakladneUdaje.Controls.Add(Me.l_SerioveCislo)
        Me.gb_ZakladneUdaje.Controls.Add(Me.l_Model)
        Me.gb_ZakladneUdaje.Controls.Add(Me.l_Vyrobca)
        Me.gb_ZakladneUdaje.Location = New System.Drawing.Point(12, 40)
        Me.gb_ZakladneUdaje.Name = "gb_ZakladneUdaje"
        Me.gb_ZakladneUdaje.Size = New System.Drawing.Size(474, 211)
        Me.gb_ZakladneUdaje.TabIndex = 18
        Me.gb_ZakladneUdaje.TabStop = False
        Me.gb_ZakladneUdaje.Text = "Základné údaje"
        '
        'cb_TypZariadenia
        '
        Me.cb_TypZariadenia.FormattingEnabled = True
        Me.cb_TypZariadenia.Location = New System.Drawing.Point(97, 149)
        Me.cb_TypZariadenia.Name = "cb_TypZariadenia"
        Me.cb_TypZariadenia.Size = New System.Drawing.Size(121, 21)
        Me.cb_TypZariadenia.TabIndex = 22
        '
        'l_TypZariadenia
        '
        Me.l_TypZariadenia.AutoSize = True
        Me.l_TypZariadenia.Location = New System.Drawing.Point(15, 152)
        Me.l_TypZariadenia.Name = "l_TypZariadenia"
        Me.l_TypZariadenia.Size = New System.Drawing.Size(76, 13)
        Me.l_TypZariadenia.TabIndex = 21
        Me.l_TypZariadenia.Text = "Typ zariadenia"
        '
        'cb_Vyrobca
        '
        Me.cb_Vyrobca.FormattingEnabled = True
        Me.cb_Vyrobca.Location = New System.Drawing.Point(97, 19)
        Me.cb_Vyrobca.Name = "cb_Vyrobca"
        Me.cb_Vyrobca.Size = New System.Drawing.Size(226, 21)
        Me.cb_Vyrobca.TabIndex = 20
        '
        'l_p_Teamviewer
        '
        Me.l_p_Teamviewer.AutoSize = True
        Me.l_p_Teamviewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_p_Teamviewer.Location = New System.Drawing.Point(357, 19)
        Me.l_p_Teamviewer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l_p_Teamviewer.Name = "l_p_Teamviewer"
        Me.l_p_Teamviewer.Size = New System.Drawing.Size(91, 13)
        Me.l_p_Teamviewer.TabIndex = 19
        Me.l_p_Teamviewer.Text = "@TEAMVIEWER"
        '
        'l_Teamviewer
        '
        Me.l_Teamviewer.AutoSize = True
        Me.l_Teamviewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_Teamviewer.Location = New System.Drawing.Point(327, 19)
        Me.l_Teamviewer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l_Teamviewer.Name = "l_Teamviewer"
        Me.l_Teamviewer.Size = New System.Drawing.Size(31, 13)
        Me.l_Teamviewer.TabIndex = 18
        Me.l_Teamviewer.Text = "TW:"
        Me.l_Teamviewer.Visible = False
        '
        'tb_EvidencneCislo
        '
        Me.tb_EvidencneCislo.Location = New System.Drawing.Point(97, 123)
        Me.tb_EvidencneCislo.Name = "tb_EvidencneCislo"
        Me.tb_EvidencneCislo.Size = New System.Drawing.Size(226, 20)
        Me.tb_EvidencneCislo.TabIndex = 6
        '
        'dtp_Vyradeny
        '
        Me.dtp_Vyradeny.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Vyradeny.Location = New System.Drawing.Point(392, 45)
        Me.dtp_Vyradeny.Name = "dtp_Vyradeny"
        Me.dtp_Vyradeny.Size = New System.Drawing.Size(76, 20)
        Me.dtp_Vyradeny.TabIndex = 17
        Me.dtp_Vyradeny.Visible = False
        '
        'tb_VyrobneCislo
        '
        Me.tb_VyrobneCislo.Location = New System.Drawing.Point(97, 97)
        Me.tb_VyrobneCislo.Name = "tb_VyrobneCislo"
        Me.tb_VyrobneCislo.Size = New System.Drawing.Size(226, 20)
        Me.tb_VyrobneCislo.TabIndex = 5
        '
        'tb_SerioveCislo
        '
        Me.tb_SerioveCislo.Location = New System.Drawing.Point(97, 71)
        Me.tb_SerioveCislo.Name = "tb_SerioveCislo"
        Me.tb_SerioveCislo.Size = New System.Drawing.Size(226, 20)
        Me.tb_SerioveCislo.TabIndex = 4
        '
        'tb_Model
        '
        Me.tb_Model.Location = New System.Drawing.Point(97, 45)
        Me.tb_Model.Name = "tb_Model"
        Me.tb_Model.Size = New System.Drawing.Size(226, 20)
        Me.tb_Model.TabIndex = 3
        '
        'l_Vyradeny
        '
        Me.l_Vyradeny.AutoSize = True
        Me.l_Vyradeny.Location = New System.Drawing.Point(335, 48)
        Me.l_Vyradeny.Name = "l_Vyradeny"
        Me.l_Vyradeny.Size = New System.Drawing.Size(51, 13)
        Me.l_Vyradeny.TabIndex = 6
        Me.l_Vyradeny.Text = "Vyradený"
        Me.l_Vyradeny.Visible = False
        '
        'l_EvidencneCislo
        '
        Me.l_EvidencneCislo.AutoSize = True
        Me.l_EvidencneCislo.Location = New System.Drawing.Point(7, 126)
        Me.l_EvidencneCislo.Name = "l_EvidencneCislo"
        Me.l_EvidencneCislo.Size = New System.Drawing.Size(84, 13)
        Me.l_EvidencneCislo.TabIndex = 4
        Me.l_EvidencneCislo.Text = "Evidenčné číslo"
        '
        'l_VyrobneCislo
        '
        Me.l_VyrobneCislo.AutoSize = True
        Me.l_VyrobneCislo.Location = New System.Drawing.Point(19, 100)
        Me.l_VyrobneCislo.Name = "l_VyrobneCislo"
        Me.l_VyrobneCislo.Size = New System.Drawing.Size(72, 13)
        Me.l_VyrobneCislo.TabIndex = 3
        Me.l_VyrobneCislo.Text = "Výrobné číslo"
        '
        'l_SerioveCislo
        '
        Me.l_SerioveCislo.AutoSize = True
        Me.l_SerioveCislo.Location = New System.Drawing.Point(22, 74)
        Me.l_SerioveCislo.Name = "l_SerioveCislo"
        Me.l_SerioveCislo.Size = New System.Drawing.Size(69, 13)
        Me.l_SerioveCislo.TabIndex = 2
        Me.l_SerioveCislo.Text = "Sériové číslo"
        '
        'l_Model
        '
        Me.l_Model.AutoSize = True
        Me.l_Model.Location = New System.Drawing.Point(55, 48)
        Me.l_Model.Name = "l_Model"
        Me.l_Model.Size = New System.Drawing.Size(36, 13)
        Me.l_Model.TabIndex = 1
        Me.l_Model.Text = "Model"
        '
        'l_Vyrobca
        '
        Me.l_Vyrobca.AutoSize = True
        Me.l_Vyrobca.Location = New System.Drawing.Point(45, 22)
        Me.l_Vyrobca.Name = "l_Vyrobca"
        Me.l_Vyrobca.Size = New System.Drawing.Size(46, 13)
        Me.l_Vyrobca.TabIndex = 0
        Me.l_Vyrobca.Text = "Výrobca"
        '
        'b_Vytvorit
        '
        Me.b_Vytvorit.Enabled = False
        Me.b_Vytvorit.Location = New System.Drawing.Point(791, 257)
        Me.b_Vytvorit.Name = "b_Vytvorit"
        Me.b_Vytvorit.Size = New System.Drawing.Size(75, 23)
        Me.b_Vytvorit.TabIndex = 16
        Me.b_Vytvorit.Text = "Vytvoriť"
        Me.b_Vytvorit.UseVisualStyleBackColor = True
        '
        'b_Zmenit
        '
        Me.b_Zmenit.Enabled = False
        Me.b_Zmenit.Location = New System.Drawing.Point(872, 257)
        Me.b_Zmenit.Name = "b_Zmenit"
        Me.b_Zmenit.Size = New System.Drawing.Size(75, 23)
        Me.b_Zmenit.TabIndex = 7
        Me.b_Zmenit.Text = "Zmeniť"
        Me.b_Zmenit.UseVisualStyleBackColor = True
        '
        'tb_Vyhladat
        '
        Me.tb_Vyhladat.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.tb_Vyhladat.Location = New System.Drawing.Point(71, 10)
        Me.tb_Vyhladat.Name = "tb_Vyhladat"
        Me.tb_Vyhladat.Size = New System.Drawing.Size(335, 20)
        Me.tb_Vyhladat.TabIndex = 0
        '
        'l_Vyhladat
        '
        Me.l_Vyhladat.AutoSize = True
        Me.l_Vyhladat.Location = New System.Drawing.Point(13, 13)
        Me.l_Vyhladat.Name = "l_Vyhladat"
        Me.l_Vyhladat.Size = New System.Drawing.Size(52, 13)
        Me.l_Vyhladat.TabIndex = 5
        Me.l_Vyhladat.Text = "Vyhladať:"
        '
        'b_Vyhladat
        '
        Me.b_Vyhladat.Location = New System.Drawing.Point(411, 7)
        Me.b_Vyhladat.Name = "b_Vyhladat"
        Me.b_Vyhladat.Size = New System.Drawing.Size(75, 23)
        Me.b_Vyhladat.TabIndex = 1
        Me.b_Vyhladat.Text = "Vyhľadať"
        Me.b_Vyhladat.UseVisualStyleBackColor = True
        '
        'b_Fakturacne
        '
        Me.b_Fakturacne.Enabled = False
        Me.b_Fakturacne.Location = New System.Drawing.Point(411, 257)
        Me.b_Fakturacne.Name = "b_Fakturacne"
        Me.b_Fakturacne.Size = New System.Drawing.Size(75, 23)
        Me.b_Fakturacne.TabIndex = 11
        Me.b_Fakturacne.Text = "Fakturačné"
        Me.b_Fakturacne.UseVisualStyleBackColor = True
        '
        'b_Software
        '
        Me.b_Software.Enabled = False
        Me.b_Software.Location = New System.Drawing.Point(330, 257)
        Me.b_Software.Name = "b_Software"
        Me.b_Software.Size = New System.Drawing.Size(75, 23)
        Me.b_Software.TabIndex = 12
        Me.b_Software.Text = "Software"
        Me.b_Software.UseVisualStyleBackColor = True
        '
        'b_Hardware
        '
        Me.b_Hardware.Enabled = False
        Me.b_Hardware.Location = New System.Drawing.Point(249, 257)
        Me.b_Hardware.Name = "b_Hardware"
        Me.b_Hardware.Size = New System.Drawing.Size(75, 23)
        Me.b_Hardware.TabIndex = 13
        Me.b_Hardware.Text = "Hardware"
        Me.b_Hardware.UseVisualStyleBackColor = True
        '
        'tp_HistoriaPresunov
        '
        Me.tp_HistoriaPresunov.Controls.Add(Me.dgv_Presun)
        Me.tp_HistoriaPresunov.Location = New System.Drawing.Point(4, 22)
        Me.tp_HistoriaPresunov.Name = "tp_HistoriaPresunov"
        Me.tp_HistoriaPresunov.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_HistoriaPresunov.Size = New System.Drawing.Size(456, 178)
        Me.tp_HistoriaPresunov.TabIndex = 1
        Me.tp_HistoriaPresunov.Text = "História presunov"
        Me.tp_HistoriaPresunov.UseVisualStyleBackColor = True
        '
        'dgv_Presun
        '
        Me.dgv_Presun.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Presun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Presun.Location = New System.Drawing.Point(6, 7)
        Me.dgv_Presun.Name = "dgv_Presun"
        Me.dgv_Presun.Size = New System.Drawing.Size(443, 164)
        Me.dgv_Presun.TabIndex = 9
        '
        'tp_HistoriaOprav
        '
        Me.tp_HistoriaOprav.Controls.Add(Me.dgv_Servis)
        Me.tp_HistoriaOprav.Location = New System.Drawing.Point(4, 22)
        Me.tp_HistoriaOprav.Name = "tp_HistoriaOprav"
        Me.tp_HistoriaOprav.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_HistoriaOprav.Size = New System.Drawing.Size(456, 178)
        Me.tp_HistoriaOprav.TabIndex = 0
        Me.tp_HistoriaOprav.Text = "Historia opráv"
        Me.tp_HistoriaOprav.UseVisualStyleBackColor = True
        '
        'dgv_Servis
        '
        Me.dgv_Servis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Servis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Servis.Location = New System.Drawing.Point(7, 8)
        Me.dgv_Servis.Name = "dgv_Servis"
        Me.dgv_Servis.Size = New System.Drawing.Size(473, 164)
        Me.dgv_Servis.TabIndex = 10
        '
        'tc_Historia
        '
        Me.tc_Historia.Controls.Add(Me.tp_HistoriaPresunov)
        Me.tc_Historia.Controls.Add(Me.tp_HistoriaOprav)
        Me.tc_Historia.Location = New System.Drawing.Point(494, 47)
        Me.tc_Historia.Name = "tc_Historia"
        Me.tc_Historia.SelectedIndex = 0
        Me.tc_Historia.Size = New System.Drawing.Size(464, 204)
        Me.tc_Historia.TabIndex = 8
        '
        'b_Presun
        '
        Me.b_Presun.Enabled = False
        Me.b_Presun.Location = New System.Drawing.Point(168, 256)
        Me.b_Presun.Name = "b_Presun"
        Me.b_Presun.Size = New System.Drawing.Size(75, 23)
        Me.b_Presun.TabIndex = 14
        Me.b_Presun.Text = "Presun"
        Me.b_Presun.UseVisualStyleBackColor = True
        '
        'b_Servis
        '
        Me.b_Servis.Enabled = False
        Me.b_Servis.Location = New System.Drawing.Point(88, 257)
        Me.b_Servis.Name = "b_Servis"
        Me.b_Servis.Size = New System.Drawing.Size(75, 23)
        Me.b_Servis.TabIndex = 15
        Me.b_Servis.Text = "Servis"
        Me.b_Servis.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Upravit, Me.tsmi_Vymazat})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(121, 48)
        '
        'tsmi_Upravit
        '
        Me.tsmi_Upravit.Name = "tsmi_Upravit"
        Me.tsmi_Upravit.Size = New System.Drawing.Size(120, 22)
        Me.tsmi_Upravit.Text = "Upraviť"
        '
        'tsmi_Vymazat
        '
        Me.tsmi_Vymazat.Name = "tsmi_Vymazat"
        Me.tsmi_Vymazat.Size = New System.Drawing.Size(120, 22)
        Me.tsmi_Vymazat.Text = "Vymazať"
        '
        'Zariadenia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(963, 292)
        Me.Controls.Add(Me.b_Servis)
        Me.Controls.Add(Me.b_Presun)
        Me.Controls.Add(Me.tc_Historia)
        Me.Controls.Add(Me.b_Hardware)
        Me.Controls.Add(Me.b_Software)
        Me.Controls.Add(Me.b_Fakturacne)
        Me.Controls.Add(Me.b_Vyhladat)
        Me.Controls.Add(Me.l_Vyhladat)
        Me.Controls.Add(Me.tb_Vyhladat)
        Me.Controls.Add(Me.b_Zmenit)
        Me.Controls.Add(Me.b_Vytvorit)
        Me.Controls.Add(Me.gb_ZakladneUdaje)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Zariadenia"
        Me.Text = "Prehľad údajov"
        Me.gb_ZakladneUdaje.ResumeLayout(False)
        Me.gb_ZakladneUdaje.PerformLayout()
        Me.tp_HistoriaPresunov.ResumeLayout(False)
        CType(Me.dgv_Presun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_HistoriaOprav.ResumeLayout(False)
        CType(Me.dgv_Servis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tc_Historia.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gb_ZakladneUdaje As GroupBox
    Friend WithEvents b_Vytvorit As Button
    Friend WithEvents b_Zmenit As Button
    Friend WithEvents l_Vyradeny As Label
    Friend WithEvents l_EvidencneCislo As Label
    Friend WithEvents l_VyrobneCislo As Label
    Friend WithEvents l_SerioveCislo As Label
    Friend WithEvents l_Model As Label
    Friend WithEvents l_Vyrobca As Label
    Friend WithEvents tb_Vyhladat As TextBox
    Friend WithEvents l_Vyhladat As Label
    Friend WithEvents b_Vyhladat As Button
    Friend WithEvents tb_EvidencneCislo As TextBox
    Friend WithEvents dtp_Vyradeny As DateTimePicker
    Friend WithEvents tb_VyrobneCislo As TextBox
    Friend WithEvents tb_SerioveCislo As TextBox
    Friend WithEvents tb_Model As TextBox
    Friend WithEvents b_Fakturacne As Button
    Friend WithEvents b_Software As Button
    Friend WithEvents b_Hardware As Button
    Friend WithEvents tp_HistoriaPresunov As TabPage
    Friend WithEvents tp_HistoriaOprav As TabPage
    Friend WithEvents tc_Historia As TabControl
    Friend WithEvents dgv_Servis As DataGridView
    Friend WithEvents dgv_Presun As DataGridView
    Friend WithEvents b_Presun As Button
    Friend WithEvents b_Servis As Button
    Friend WithEvents l_p_Teamviewer As Label
    Friend WithEvents l_Teamviewer As Label
    Friend WithEvents cb_Vyrobca As ComboBox
    Friend WithEvents cb_TypZariadenia As ComboBox
    Friend WithEvents l_TypZariadenia As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents tsmi_Upravit As ToolStripMenuItem
    Friend WithEvents tsmi_Vymazat As ToolStripMenuItem
End Class
