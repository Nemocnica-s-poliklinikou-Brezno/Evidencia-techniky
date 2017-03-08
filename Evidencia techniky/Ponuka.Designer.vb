<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ponuka
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ponuka))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pata_text = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsm_Technika = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_Zostava = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_Pocitac = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_Monitor = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_Tlaciaren = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_Ostatne = New System.Windows.Forms.ToolStripMenuItem()
        Me.HardwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoftwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PridaťToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriradiťToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SkladToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DenníkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_Prace = New System.Windows.Forms.ToolStripMenuItem()
        Me.MojeNevybavenéPráceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_PraceSprava = New System.Windows.Forms.ToolStripMenuItem()
        Me.VýkazPráceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_Ziadanky = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsmi_Zadanie = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsmi_Evidencia = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_Doprava = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_PrehladPodlaOdosielatela = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_DopravaPoistovne = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_Labaky = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsm_Skumavky = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransfúzneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriestupkyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NahlásenieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EvidenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrehľadyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NastaveniaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZmenaHeslaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PripomienkyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADMINISTRÁCIAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NastaveniePrávToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerziaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ČíselníkyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OProgrameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TESTMAILToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OdlásiťToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pata_text})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 223)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(719, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'pata_text
        '
        Me.pata_text.Name = "pata_text"
        Me.pata_text.Size = New System.Drawing.Size(0, 17)
        Me.pata_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_Technika, Me.tsm_Prace, Me.tsm_Ziadanky, Me.tsm_Doprava, Me.tsm_Labaky, Me.PriestupkyToolStripMenuItem, Me.PrehľadyToolStripMenuItem, Me.NastaveniaToolStripMenuItem, Me.OdlásiťToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(719, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsm_Technika
        '
        Me.tsm_Technika.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_Zostava, Me.tsm_Pocitac, Me.tsm_Monitor, Me.tsm_Tlaciaren, Me.tsm_Ostatne, Me.HardwareToolStripMenuItem, Me.SoftwareToolStripMenuItem, Me.SkladToolStripMenuItem, Me.DenníkToolStripMenuItem})
        Me.tsm_Technika.Name = "tsm_Technika"
        Me.tsm_Technika.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.tsm_Technika.Size = New System.Drawing.Size(66, 20)
        Me.tsm_Technika.Text = "Technika"
        Me.tsm_Technika.Visible = False
        '
        'tsm_Zostava
        '
        Me.tsm_Zostava.Name = "tsm_Zostava"
        Me.tsm_Zostava.Size = New System.Drawing.Size(125, 22)
        Me.tsm_Zostava.Text = "Zostava"
        Me.tsm_Zostava.Visible = False
        '
        'tsm_Pocitac
        '
        Me.tsm_Pocitac.Name = "tsm_Pocitac"
        Me.tsm_Pocitac.Size = New System.Drawing.Size(125, 22)
        Me.tsm_Pocitac.Text = "Počítač"
        '
        'tsm_Monitor
        '
        Me.tsm_Monitor.Name = "tsm_Monitor"
        Me.tsm_Monitor.Size = New System.Drawing.Size(125, 22)
        Me.tsm_Monitor.Text = "Monitor"
        '
        'tsm_Tlaciaren
        '
        Me.tsm_Tlaciaren.Name = "tsm_Tlaciaren"
        Me.tsm_Tlaciaren.Size = New System.Drawing.Size(125, 22)
        Me.tsm_Tlaciaren.Text = "Tlačiareň"
        '
        'tsm_Ostatne
        '
        Me.tsm_Ostatne.Name = "tsm_Ostatne"
        Me.tsm_Ostatne.Size = New System.Drawing.Size(125, 22)
        Me.tsm_Ostatne.Text = "Ostatné"
        '
        'HardwareToolStripMenuItem
        '
        Me.HardwareToolStripMenuItem.Name = "HardwareToolStripMenuItem"
        Me.HardwareToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.HardwareToolStripMenuItem.Text = "Hardware"
        Me.HardwareToolStripMenuItem.Visible = False
        '
        'SoftwareToolStripMenuItem
        '
        Me.SoftwareToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PridaťToolStripMenuItem, Me.PriradiťToolStripMenuItem})
        Me.SoftwareToolStripMenuItem.Name = "SoftwareToolStripMenuItem"
        Me.SoftwareToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SoftwareToolStripMenuItem.Text = "Software"
        '
        'PridaťToolStripMenuItem
        '
        Me.PridaťToolStripMenuItem.Name = "PridaťToolStripMenuItem"
        Me.PridaťToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.PridaťToolStripMenuItem.Text = "Pridať"
        '
        'PriradiťToolStripMenuItem
        '
        Me.PriradiťToolStripMenuItem.Name = "PriradiťToolStripMenuItem"
        Me.PriradiťToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.PriradiťToolStripMenuItem.Text = "Priradiť"
        '
        'SkladToolStripMenuItem
        '
        Me.SkladToolStripMenuItem.Name = "SkladToolStripMenuItem"
        Me.SkladToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SkladToolStripMenuItem.Text = "Sklad"
        Me.SkladToolStripMenuItem.Visible = False
        '
        'DenníkToolStripMenuItem
        '
        Me.DenníkToolStripMenuItem.Name = "DenníkToolStripMenuItem"
        Me.DenníkToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.DenníkToolStripMenuItem.Text = "Denník"
        Me.DenníkToolStripMenuItem.Visible = False
        '
        'tsm_Prace
        '
        Me.tsm_Prace.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MojeNevybavenéPráceToolStripMenuItem, Me.tsm_PraceSprava, Me.VýkazPráceToolStripMenuItem})
        Me.tsm_Prace.Name = "tsm_Prace"
        Me.tsm_Prace.Size = New System.Drawing.Size(48, 20)
        Me.tsm_Prace.Text = "Práce"
        Me.tsm_Prace.Visible = False
        '
        'MojeNevybavenéPráceToolStripMenuItem
        '
        Me.MojeNevybavenéPráceToolStripMenuItem.Name = "MojeNevybavenéPráceToolStripMenuItem"
        Me.MojeNevybavenéPráceToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.MojeNevybavenéPráceToolStripMenuItem.Text = "Moje nevybavené práce"
        '
        'tsm_PraceSprava
        '
        Me.tsm_PraceSprava.Name = "tsm_PraceSprava"
        Me.tsm_PraceSprava.Size = New System.Drawing.Size(199, 22)
        Me.tsm_PraceSprava.Text = "Zadané práce"
        Me.tsm_PraceSprava.Visible = False
        '
        'VýkazPráceToolStripMenuItem
        '
        Me.VýkazPráceToolStripMenuItem.Enabled = False
        Me.VýkazPráceToolStripMenuItem.Name = "VýkazPráceToolStripMenuItem"
        Me.VýkazPráceToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.VýkazPráceToolStripMenuItem.Text = "Výkaz práce"
        '
        'tsm_Ziadanky
        '
        Me.tsm_Ziadanky.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsmi_Zadanie, Me.stsmi_Evidencia})
        Me.tsm_Ziadanky.Name = "tsm_Ziadanky"
        Me.tsm_Ziadanky.Size = New System.Drawing.Size(67, 20)
        Me.tsm_Ziadanky.Text = "Žiadanky"
        Me.tsm_Ziadanky.Visible = False
        '
        'stsmi_Zadanie
        '
        Me.stsmi_Zadanie.Name = "stsmi_Zadanie"
        Me.stsmi_Zadanie.Size = New System.Drawing.Size(152, 22)
        Me.stsmi_Zadanie.Text = "Zadanie"
        Me.stsmi_Zadanie.Visible = False
        '
        'stsmi_Evidencia
        '
        Me.stsmi_Evidencia.Name = "stsmi_Evidencia"
        Me.stsmi_Evidencia.Size = New System.Drawing.Size(152, 22)
        Me.stsmi_Evidencia.Text = "Evidencia"
        Me.stsmi_Evidencia.Visible = False
        '
        'tsm_Doprava
        '
        Me.tsm_Doprava.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_PrehladPodlaOdosielatela, Me.tsm_DopravaPoistovne})
        Me.tsm_Doprava.Name = "tsm_Doprava"
        Me.tsm_Doprava.Size = New System.Drawing.Size(63, 20)
        Me.tsm_Doprava.Text = "Doprava"
        Me.tsm_Doprava.Visible = False
        '
        'tsm_PrehladPodlaOdosielatela
        '
        Me.tsm_PrehladPodlaOdosielatela.Name = "tsm_PrehladPodlaOdosielatela"
        Me.tsm_PrehladPodlaOdosielatela.Size = New System.Drawing.Size(240, 22)
        Me.tsm_PrehladPodlaOdosielatela.Text = "Prehľad podľa odosielateľa"
        Me.tsm_PrehladPodlaOdosielatela.Visible = False
        '
        'tsm_DopravaPoistovne
        '
        Me.tsm_DopravaPoistovne.Name = "tsm_DopravaPoistovne"
        Me.tsm_DopravaPoistovne.Size = New System.Drawing.Size(240, 22)
        Me.tsm_DopravaPoistovne.Text = "Ročný prehľad podľa poistovne"
        Me.tsm_DopravaPoistovne.Visible = False
        '
        'tsm_Labaky
        '
        Me.tsm_Labaky.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsm_Skumavky, Me.TransfúzneToolStripMenuItem})
        Me.tsm_Labaky.Name = "tsm_Labaky"
        Me.tsm_Labaky.Size = New System.Drawing.Size(56, 20)
        Me.tsm_Labaky.Text = "Labáky"
        Me.tsm_Labaky.Visible = False
        '
        'tsm_Skumavky
        '
        Me.tsm_Skumavky.Name = "tsm_Skumavky"
        Me.tsm_Skumavky.Size = New System.Drawing.Size(131, 22)
        Me.tsm_Skumavky.Text = "Skúmavky"
        Me.tsm_Skumavky.Visible = False
        '
        'TransfúzneToolStripMenuItem
        '
        Me.TransfúzneToolStripMenuItem.Name = "TransfúzneToolStripMenuItem"
        Me.TransfúzneToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.TransfúzneToolStripMenuItem.Text = "Transfúzne"
        Me.TransfúzneToolStripMenuItem.Visible = False
        '
        'PriestupkyToolStripMenuItem
        '
        Me.PriestupkyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NahlásenieToolStripMenuItem, Me.EvidenciaToolStripMenuItem})
        Me.PriestupkyToolStripMenuItem.Name = "PriestupkyToolStripMenuItem"
        Me.PriestupkyToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.PriestupkyToolStripMenuItem.Text = "Priestupky"
        Me.PriestupkyToolStripMenuItem.Visible = False
        '
        'NahlásenieToolStripMenuItem
        '
        Me.NahlásenieToolStripMenuItem.Name = "NahlásenieToolStripMenuItem"
        Me.NahlásenieToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.NahlásenieToolStripMenuItem.Text = "Nahlásenie"
        '
        'EvidenciaToolStripMenuItem
        '
        Me.EvidenciaToolStripMenuItem.Name = "EvidenciaToolStripMenuItem"
        Me.EvidenciaToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EvidenciaToolStripMenuItem.Text = "Evidencia"
        '
        'PrehľadyToolStripMenuItem
        '
        Me.PrehľadyToolStripMenuItem.Name = "PrehľadyToolStripMenuItem"
        Me.PrehľadyToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PrehľadyToolStripMenuItem.Text = "Prehľady"
        Me.PrehľadyToolStripMenuItem.Visible = False
        '
        'NastaveniaToolStripMenuItem
        '
        Me.NastaveniaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZmenaHeslaToolStripMenuItem, Me.PripomienkyToolStripMenuItem, Me.ADMINISTRÁCIAToolStripMenuItem, Me.OProgrameToolStripMenuItem, Me.TESTMAILToolStripMenuItem})
        Me.NastaveniaToolStripMenuItem.Name = "NastaveniaToolStripMenuItem"
        Me.NastaveniaToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.NastaveniaToolStripMenuItem.Text = "Nastavenia"
        '
        'ZmenaHeslaToolStripMenuItem
        '
        Me.ZmenaHeslaToolStripMenuItem.Name = "ZmenaHeslaToolStripMenuItem"
        Me.ZmenaHeslaToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ZmenaHeslaToolStripMenuItem.Text = "Zmena hesla"
        '
        'PripomienkyToolStripMenuItem
        '
        Me.PripomienkyToolStripMenuItem.Name = "PripomienkyToolStripMenuItem"
        Me.PripomienkyToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.PripomienkyToolStripMenuItem.Text = "Pripomienky"
        '
        'ADMINISTRÁCIAToolStripMenuItem
        '
        Me.ADMINISTRÁCIAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NastaveniePrávToolStripMenuItem, Me.VerziaToolStripMenuItem, Me.ČíselníkyToolStripMenuItem})
        Me.ADMINISTRÁCIAToolStripMenuItem.Name = "ADMINISTRÁCIAToolStripMenuItem"
        Me.ADMINISTRÁCIAToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ADMINISTRÁCIAToolStripMenuItem.Text = "ADMINISTRÁCIA"
        Me.ADMINISTRÁCIAToolStripMenuItem.Visible = False
        '
        'NastaveniePrávToolStripMenuItem
        '
        Me.NastaveniePrávToolStripMenuItem.Name = "NastaveniePrávToolStripMenuItem"
        Me.NastaveniePrávToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.NastaveniePrávToolStripMenuItem.Text = "Nastavenie užívateľa"
        '
        'VerziaToolStripMenuItem
        '
        Me.VerziaToolStripMenuItem.Name = "VerziaToolStripMenuItem"
        Me.VerziaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.VerziaToolStripMenuItem.Text = "Verzia"
        Me.VerziaToolStripMenuItem.Visible = False
        '
        'ČíselníkyToolStripMenuItem
        '
        Me.ČíselníkyToolStripMenuItem.Name = "ČíselníkyToolStripMenuItem"
        Me.ČíselníkyToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ČíselníkyToolStripMenuItem.Text = "Číselníky"
        Me.ČíselníkyToolStripMenuItem.Visible = False
        '
        'OProgrameToolStripMenuItem
        '
        Me.OProgrameToolStripMenuItem.Name = "OProgrameToolStripMenuItem"
        Me.OProgrameToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.OProgrameToolStripMenuItem.Text = "O programe"
        '
        'TESTMAILToolStripMenuItem
        '
        Me.TESTMAILToolStripMenuItem.Name = "TESTMAILToolStripMenuItem"
        Me.TESTMAILToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.TESTMAILToolStripMenuItem.Text = "TEST MAIL"
        Me.TESTMAILToolStripMenuItem.Visible = False
        '
        'OdlásiťToolStripMenuItem
        '
        Me.OdlásiťToolStripMenuItem.Name = "OdlásiťToolStripMenuItem"
        Me.OdlásiťToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.OdlásiťToolStripMenuItem.Text = "Odhlásiť"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Evidencia_techniky.My.Resources.Resources.NsP_logo_3D_copy
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Ponuka
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(719, 245)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Ponuka"
        Me.Text = "Ponuka"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents pata_text As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsm_Technika As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_Pocitac As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_Tlaciaren As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HardwareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoftwareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SkladToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DenníkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_Prace As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MojeNevybavenéPráceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsm_PraceSprava As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VýkazPráceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NastaveniaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZmenaHeslaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADMINISTRÁCIAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NastaveniePrávToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OdlásiťToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tsm_Ziadanky As ToolStripMenuItem
    Friend WithEvents stsmi_Zadanie As ToolStripMenuItem
    Friend WithEvents stsmi_Evidencia As ToolStripMenuItem
    Friend WithEvents tsm_Labaky As ToolStripMenuItem
    Friend WithEvents tsm_Skumavky As ToolStripMenuItem
    Friend WithEvents TransfúzneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsm_Doprava As ToolStripMenuItem
    Friend WithEvents tsm_PrehladPodlaOdosielatela As ToolStripMenuItem
    Friend WithEvents tsm_DopravaPoistovne As ToolStripMenuItem
    Friend WithEvents tsm_Zostava As ToolStripMenuItem
    Friend WithEvents tsm_Monitor As ToolStripMenuItem
    Friend WithEvents PripomienkyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OProgrameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerziaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ČíselníkyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TESTMAILToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PriestupkyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NahlásenieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EvidenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsm_Ostatne As ToolStripMenuItem
    Friend WithEvents PridaťToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PriradiťToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrehľadyToolStripMenuItem As ToolStripMenuItem
End Class
