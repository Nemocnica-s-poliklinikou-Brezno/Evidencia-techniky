<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZariadeniaPresunVloz
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ZariadeniaPresunVloz))
        Me.gb_Presun = New System.Windows.Forms.GroupBox()
        Me.Chlb_ZapozikaServisny = New System.Windows.Forms.CheckedListBox()
        Me.dtp_PresunutyDna = New System.Windows.Forms.DateTimePicker()
        Me.l_PresunutyDna = New System.Windows.Forms.Label()
        Me.tb_ZOddelenia = New System.Windows.Forms.TextBox()
        Me.l_Miestnost = New System.Windows.Forms.Label()
        Me.tb_NaOddelenieMiestnost = New System.Windows.Forms.TextBox()
        Me.tb_ZOddeleniaMiestnost = New System.Windows.Forms.TextBox()
        Me.cb_NaOddelenie = New System.Windows.Forms.ComboBox()
        Me.l_NaOddelenie = New System.Windows.Forms.Label()
        Me.l_ZOddelenia = New System.Windows.Forms.Label()
        Me.b_Presun = New System.Windows.Forms.Button()
        Me.gb_Presun.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_Presun
        '
        Me.gb_Presun.Controls.Add(Me.Chlb_ZapozikaServisny)
        Me.gb_Presun.Controls.Add(Me.dtp_PresunutyDna)
        Me.gb_Presun.Controls.Add(Me.l_PresunutyDna)
        Me.gb_Presun.Controls.Add(Me.tb_ZOddelenia)
        Me.gb_Presun.Controls.Add(Me.l_Miestnost)
        Me.gb_Presun.Controls.Add(Me.tb_NaOddelenieMiestnost)
        Me.gb_Presun.Controls.Add(Me.tb_ZOddeleniaMiestnost)
        Me.gb_Presun.Controls.Add(Me.cb_NaOddelenie)
        Me.gb_Presun.Controls.Add(Me.l_NaOddelenie)
        Me.gb_Presun.Controls.Add(Me.l_ZOddelenia)
        Me.gb_Presun.Location = New System.Drawing.Point(13, 13)
        Me.gb_Presun.Name = "gb_Presun"
        Me.gb_Presun.Size = New System.Drawing.Size(388, 144)
        Me.gb_Presun.TabIndex = 0
        Me.gb_Presun.TabStop = False
        Me.gb_Presun.Text = "Presun medzi oddeleniami"
        '
        'Chlb_ZapozikaServisny
        '
        Me.Chlb_ZapozikaServisny.FormattingEnabled = True
        Me.Chlb_ZapozikaServisny.Items.AddRange(New Object() {"Zápožička"})
        Me.Chlb_ZapozikaServisny.Location = New System.Drawing.Point(297, 103)
        Me.Chlb_ZapozikaServisny.Name = "Chlb_ZapozikaServisny"
        Me.Chlb_ZapozikaServisny.Size = New System.Drawing.Size(79, 19)
        Me.Chlb_ZapozikaServisny.TabIndex = 4
        '
        'dtp_PresunutyDna
        '
        Me.dtp_PresunutyDna.CustomFormat = ""
        Me.dtp_PresunutyDna.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_PresunutyDna.Location = New System.Drawing.Point(91, 103)
        Me.dtp_PresunutyDna.Name = "dtp_PresunutyDna"
        Me.dtp_PresunutyDna.Size = New System.Drawing.Size(200, 20)
        Me.dtp_PresunutyDna.TabIndex = 3
        Me.dtp_PresunutyDna.Value = New Date(2016, 3, 17, 0, 0, 0, 0)
        '
        'l_PresunutyDna
        '
        Me.l_PresunutyDna.AutoSize = True
        Me.l_PresunutyDna.Location = New System.Drawing.Point(10, 109)
        Me.l_PresunutyDna.Name = "l_PresunutyDna"
        Me.l_PresunutyDna.Size = New System.Drawing.Size(75, 13)
        Me.l_PresunutyDna.TabIndex = 8
        Me.l_PresunutyDna.Text = "Presunutý dňa"
        '
        'tb_ZOddelenia
        '
        Me.tb_ZOddelenia.Location = New System.Drawing.Point(82, 37)
        Me.tb_ZOddelenia.Name = "tb_ZOddelenia"
        Me.tb_ZOddelenia.ReadOnly = True
        Me.tb_ZOddelenia.Size = New System.Drawing.Size(121, 20)
        Me.tb_ZOddelenia.TabIndex = 6
        '
        'l_Miestnost
        '
        Me.l_Miestnost.AutoSize = True
        Me.l_Miestnost.Location = New System.Drawing.Point(238, 16)
        Me.l_Miestnost.Name = "l_Miestnost"
        Me.l_Miestnost.Size = New System.Drawing.Size(53, 13)
        Me.l_Miestnost.TabIndex = 6
        Me.l_Miestnost.Text = "Miestnosť"
        '
        'tb_NaOddelenieMiestnost
        '
        Me.tb_NaOddelenieMiestnost.Location = New System.Drawing.Point(209, 71)
        Me.tb_NaOddelenieMiestnost.Name = "tb_NaOddelenieMiestnost"
        Me.tb_NaOddelenieMiestnost.Size = New System.Drawing.Size(121, 20)
        Me.tb_NaOddelenieMiestnost.TabIndex = 2
        '
        'tb_ZOddeleniaMiestnost
        '
        Me.tb_ZOddeleniaMiestnost.Location = New System.Drawing.Point(209, 37)
        Me.tb_ZOddeleniaMiestnost.Name = "tb_ZOddeleniaMiestnost"
        Me.tb_ZOddeleniaMiestnost.ReadOnly = True
        Me.tb_ZOddeleniaMiestnost.Size = New System.Drawing.Size(121, 20)
        Me.tb_ZOddeleniaMiestnost.TabIndex = 7
        '
        'cb_NaOddelenie
        '
        Me.cb_NaOddelenie.FormattingEnabled = True
        Me.cb_NaOddelenie.Location = New System.Drawing.Point(82, 70)
        Me.cb_NaOddelenie.Name = "cb_NaOddelenie"
        Me.cb_NaOddelenie.Size = New System.Drawing.Size(121, 21)
        Me.cb_NaOddelenie.TabIndex = 1
        '
        'l_NaOddelenie
        '
        Me.l_NaOddelenie.AutoSize = True
        Me.l_NaOddelenie.Location = New System.Drawing.Point(6, 73)
        Me.l_NaOddelenie.Name = "l_NaOddelenie"
        Me.l_NaOddelenie.Size = New System.Drawing.Size(70, 13)
        Me.l_NaOddelenie.TabIndex = 1
        Me.l_NaOddelenie.Text = "Na oddelenie"
        '
        'l_ZOddelenia
        '
        Me.l_ZOddelenia.AutoSize = True
        Me.l_ZOddelenia.Location = New System.Drawing.Point(7, 39)
        Me.l_ZOddelenia.Name = "l_ZOddelenia"
        Me.l_ZOddelenia.Size = New System.Drawing.Size(63, 13)
        Me.l_ZOddelenia.TabIndex = 0
        Me.l_ZOddelenia.Text = "Z oddelenia"
        '
        'b_Presun
        '
        Me.b_Presun.Enabled = False
        Me.b_Presun.Location = New System.Drawing.Point(326, 163)
        Me.b_Presun.Name = "b_Presun"
        Me.b_Presun.Size = New System.Drawing.Size(75, 23)
        Me.b_Presun.TabIndex = 5
        Me.b_Presun.Text = "Presun"
        Me.b_Presun.UseVisualStyleBackColor = True
        '
        'ZariadeniaPresunVloz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 198)
        Me.Controls.Add(Me.b_Presun)
        Me.Controls.Add(Me.gb_Presun)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ZariadeniaPresunVloz"
        Me.Text = "Presun zariadení"
        Me.gb_Presun.ResumeLayout(False)
        Me.gb_Presun.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_Presun As GroupBox
    Friend WithEvents tb_NaOddelenieMiestnost As TextBox
    Friend WithEvents tb_ZOddeleniaMiestnost As TextBox
    Friend WithEvents cb_NaOddelenie As ComboBox
    Friend WithEvents l_NaOddelenie As Label
    Friend WithEvents l_ZOddelenia As Label
    Friend WithEvents l_Miestnost As Label
    Friend WithEvents b_Presun As Button
    Friend WithEvents tb_ZOddelenia As TextBox
    Friend WithEvents dtp_PresunutyDna As DateTimePicker
    Friend WithEvents l_PresunutyDna As Label
    Friend WithEvents Chlb_ZapozikaServisny As CheckedListBox
End Class
