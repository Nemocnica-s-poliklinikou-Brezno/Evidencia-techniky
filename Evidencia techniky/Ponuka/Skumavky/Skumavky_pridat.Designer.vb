<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Skumavky_pridat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Skumavky_pridat))
        Me.gb_PridatLekara = New System.Windows.Forms.GroupBox()
        Me.l_KodPzs = New System.Windows.Forms.Label()
        Me.l_KodLekara = New System.Windows.Forms.Label()
        Me.l_MenoLekara = New System.Windows.Forms.Label()
        Me.tb_KodPzs = New System.Windows.Forms.TextBox()
        Me.l_Info = New System.Windows.Forms.Label()
        Me.tb_KodLekara = New System.Windows.Forms.TextBox()
        Me.tb_MenoLekara = New System.Windows.Forms.TextBox()
        Me.b_Zapisat = New System.Windows.Forms.Button()
        Me.tb_Vyhladat = New System.Windows.Forms.TextBox()
        Me.b_Vyhladat = New System.Windows.Forms.Button()
        Me.b_Zmenit = New System.Windows.Forms.Button()
        Me.b_Vymazat = New System.Windows.Forms.Button()
        Me.gb_PridatVykon = New System.Windows.Forms.GroupBox()
        Me.tb_CisloVykonu = New System.Windows.Forms.TextBox()
        Me.l_CisloVykonu = New System.Windows.Forms.Label()
        Me.gb_PridatLekara.SuspendLayout()
        Me.gb_PridatVykon.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_PridatLekara
        '
        Me.gb_PridatLekara.Controls.Add(Me.l_KodPzs)
        Me.gb_PridatLekara.Controls.Add(Me.l_KodLekara)
        Me.gb_PridatLekara.Controls.Add(Me.l_MenoLekara)
        Me.gb_PridatLekara.Controls.Add(Me.tb_KodPzs)
        Me.gb_PridatLekara.Controls.Add(Me.l_Info)
        Me.gb_PridatLekara.Controls.Add(Me.tb_KodLekara)
        Me.gb_PridatLekara.Controls.Add(Me.tb_MenoLekara)
        Me.gb_PridatLekara.Location = New System.Drawing.Point(12, 50)
        Me.gb_PridatLekara.Name = "gb_PridatLekara"
        Me.gb_PridatLekara.Size = New System.Drawing.Size(425, 149)
        Me.gb_PridatLekara.TabIndex = 0
        Me.gb_PridatLekara.TabStop = False
        Me.gb_PridatLekara.Text = "Pridať lekára"
        '
        'l_KodPzs
        '
        Me.l_KodPzs.AutoSize = True
        Me.l_KodPzs.Location = New System.Drawing.Point(31, 104)
        Me.l_KodPzs.Name = "l_KodPzs"
        Me.l_KodPzs.Size = New System.Drawing.Size(50, 13)
        Me.l_KodPzs.TabIndex = 5
        Me.l_KodPzs.Text = "Kód PZS"
        '
        'l_KodLekara
        '
        Me.l_KodLekara.AutoSize = True
        Me.l_KodLekara.Location = New System.Drawing.Point(23, 63)
        Me.l_KodLekara.Name = "l_KodLekara"
        Me.l_KodLekara.Size = New System.Drawing.Size(58, 13)
        Me.l_KodLekara.TabIndex = 4
        Me.l_KodLekara.Text = "Kód lekára"
        '
        'l_MenoLekara
        '
        Me.l_MenoLekara.AutoSize = True
        Me.l_MenoLekara.Location = New System.Drawing.Point(15, 24)
        Me.l_MenoLekara.Name = "l_MenoLekara"
        Me.l_MenoLekara.Size = New System.Drawing.Size(66, 13)
        Me.l_MenoLekara.TabIndex = 3
        Me.l_MenoLekara.Text = "Meno lekára"
        '
        'tb_KodPzs
        '
        Me.tb_KodPzs.Location = New System.Drawing.Point(87, 101)
        Me.tb_KodPzs.Name = "tb_KodPzs"
        Me.tb_KodPzs.Size = New System.Drawing.Size(321, 20)
        Me.tb_KodPzs.TabIndex = 2
        '
        'l_Info
        '
        Me.l_Info.AutoSize = True
        Me.l_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_Info.ForeColor = System.Drawing.Color.Red
        Me.l_Info.Location = New System.Drawing.Point(115, 124)
        Me.l_Info.Name = "l_Info"
        Me.l_Info.Size = New System.Drawing.Size(229, 13)
        Me.l_Info.TabIndex = 3
        Me.l_Info.Text = "Všetky údaje sú povinné pri lekárovi !!!"
        '
        'tb_KodLekara
        '
        Me.tb_KodLekara.Location = New System.Drawing.Point(87, 60)
        Me.tb_KodLekara.Name = "tb_KodLekara"
        Me.tb_KodLekara.Size = New System.Drawing.Size(321, 20)
        Me.tb_KodLekara.TabIndex = 1
        '
        'tb_MenoLekara
        '
        Me.tb_MenoLekara.Location = New System.Drawing.Point(87, 21)
        Me.tb_MenoLekara.Name = "tb_MenoLekara"
        Me.tb_MenoLekara.Size = New System.Drawing.Size(321, 20)
        Me.tb_MenoLekara.TabIndex = 0
        '
        'b_Zapisat
        '
        Me.b_Zapisat.Enabled = False
        Me.b_Zapisat.Location = New System.Drawing.Point(362, 265)
        Me.b_Zapisat.Name = "b_Zapisat"
        Me.b_Zapisat.Size = New System.Drawing.Size(75, 23)
        Me.b_Zapisat.TabIndex = 2
        Me.b_Zapisat.Text = "Vložiť"
        Me.b_Zapisat.UseVisualStyleBackColor = True
        '
        'tb_Vyhladat
        '
        Me.tb_Vyhladat.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.tb_Vyhladat.Location = New System.Drawing.Point(12, 13)
        Me.tb_Vyhladat.Name = "tb_Vyhladat"
        Me.tb_Vyhladat.Size = New System.Drawing.Size(349, 20)
        Me.tb_Vyhladat.TabIndex = 4
        Me.tb_Vyhladat.Text = "Zadajte údaje o lekárovi"
        '
        'b_Vyhladat
        '
        Me.b_Vyhladat.Location = New System.Drawing.Point(367, 11)
        Me.b_Vyhladat.Name = "b_Vyhladat"
        Me.b_Vyhladat.Size = New System.Drawing.Size(75, 23)
        Me.b_Vyhladat.TabIndex = 5
        Me.b_Vyhladat.Text = "Vyhľadať"
        Me.b_Vyhladat.UseVisualStyleBackColor = True
        '
        'b_Zmenit
        '
        Me.b_Zmenit.Enabled = False
        Me.b_Zmenit.Location = New System.Drawing.Point(281, 265)
        Me.b_Zmenit.Name = "b_Zmenit"
        Me.b_Zmenit.Size = New System.Drawing.Size(75, 23)
        Me.b_Zmenit.TabIndex = 6
        Me.b_Zmenit.Text = "Zmeniť"
        Me.b_Zmenit.UseVisualStyleBackColor = True
        '
        'b_Vymazat
        '
        Me.b_Vymazat.Enabled = False
        Me.b_Vymazat.Location = New System.Drawing.Point(200, 265)
        Me.b_Vymazat.Name = "b_Vymazat"
        Me.b_Vymazat.Size = New System.Drawing.Size(75, 23)
        Me.b_Vymazat.TabIndex = 7
        Me.b_Vymazat.Text = "Vymazať"
        Me.b_Vymazat.UseVisualStyleBackColor = True
        '
        'gb_PridatVykon
        '
        Me.gb_PridatVykon.Controls.Add(Me.tb_CisloVykonu)
        Me.gb_PridatVykon.Controls.Add(Me.l_CisloVykonu)
        Me.gb_PridatVykon.Location = New System.Drawing.Point(13, 206)
        Me.gb_PridatVykon.Name = "gb_PridatVykon"
        Me.gb_PridatVykon.Size = New System.Drawing.Size(424, 53)
        Me.gb_PridatVykon.TabIndex = 8
        Me.gb_PridatVykon.TabStop = False
        Me.gb_PridatVykon.Text = "Pridať výkon"
        '
        'tb_CisloVykonu
        '
        Me.tb_CisloVykonu.Location = New System.Drawing.Point(86, 20)
        Me.tb_CisloVykonu.Name = "tb_CisloVykonu"
        Me.tb_CisloVykonu.Size = New System.Drawing.Size(321, 20)
        Me.tb_CisloVykonu.TabIndex = 1
        '
        'l_CisloVykonu
        '
        Me.l_CisloVykonu.AutoSize = True
        Me.l_CisloVykonu.Location = New System.Drawing.Point(11, 23)
        Me.l_CisloVykonu.Name = "l_CisloVykonu"
        Me.l_CisloVykonu.Size = New System.Drawing.Size(69, 13)
        Me.l_CisloVykonu.TabIndex = 0
        Me.l_CisloVykonu.Text = "Číslo výkonu"
        '
        'Skumavky_pridat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 299)
        Me.Controls.Add(Me.gb_PridatVykon)
        Me.Controls.Add(Me.b_Vymazat)
        Me.Controls.Add(Me.b_Zmenit)
        Me.Controls.Add(Me.b_Vyhladat)
        Me.Controls.Add(Me.tb_Vyhladat)
        Me.Controls.Add(Me.b_Zapisat)
        Me.Controls.Add(Me.gb_PridatLekara)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Skumavky_pridat"
        Me.Text = "Skumavky pridať lekára alebo výkon"
        Me.gb_PridatLekara.ResumeLayout(False)
        Me.gb_PridatLekara.PerformLayout()
        Me.gb_PridatVykon.ResumeLayout(False)
        Me.gb_PridatVykon.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gb_PridatLekara As GroupBox
    Friend WithEvents b_Zapisat As Button
    Friend WithEvents l_KodPzs As Label
    Friend WithEvents l_KodLekara As Label
    Friend WithEvents l_MenoLekara As Label
    Friend WithEvents tb_KodPzs As TextBox
    Friend WithEvents tb_KodLekara As TextBox
    Friend WithEvents tb_MenoLekara As TextBox
    Friend WithEvents l_Info As Label
    Friend WithEvents tb_Vyhladat As TextBox
    Friend WithEvents b_Vyhladat As Button
    Friend WithEvents b_Zmenit As Button
    Friend WithEvents b_Vymazat As Button
    Friend WithEvents tb_CisloVykonu As TextBox
    Friend WithEvents l_CisloVykonu As Label
    Friend WithEvents gb_PridatVykon As GroupBox
End Class
