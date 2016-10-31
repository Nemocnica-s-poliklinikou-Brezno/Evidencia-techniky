<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ziadanky_zoznam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ziadanky_zoznam))
        Me.b_NacitatData = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.tp_Investicie = New System.Windows.Forms.TabPage()
        Me.dgv_Investicie = New System.Windows.Forms.DataGridView()
        Me.tp_UkonceneUdrzba = New System.Windows.Forms.TabPage()
        Me.dgv_UkonceneUdrzba = New System.Windows.Forms.DataGridView()
        Me.tp_VrateneUdrzbe = New System.Windows.Forms.TabPage()
        Me.dgv_VrateneUdrzbe = New System.Windows.Forms.DataGridView()
        Me.tp_VrateneZadavatelovi = New System.Windows.Forms.TabPage()
        Me.dgv_VrateneZadavatelovi = New System.Windows.Forms.DataGridView()
        Me.tp_Odlozene = New System.Windows.Forms.TabPage()
        Me.dgv_Odlozene = New System.Windows.Forms.DataGridView()
        Me.tp_Rozpracovane = New System.Windows.Forms.TabPage()
        Me.dgv_Rozpracovane = New System.Windows.Forms.DataGridView()
        Me.tp_Nove = New System.Windows.Forms.TabPage()
        Me.dgv_Nove = New System.Windows.Forms.DataGridView()
        Me.tb_Ziadanky = New System.Windows.Forms.TabControl()
        Me.tp_UkoncenieZadavatelom = New System.Windows.Forms.TabPage()
        Me.dgv_UkoncenieZadavatelom = New System.Windows.Forms.DataGridView()
        Me.UlohaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tp_Investicie.SuspendLayout()
        CType(Me.dgv_Investicie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_UkonceneUdrzba.SuspendLayout()
        CType(Me.dgv_UkonceneUdrzba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_VrateneUdrzbe.SuspendLayout()
        CType(Me.dgv_VrateneUdrzbe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_VrateneZadavatelovi.SuspendLayout()
        CType(Me.dgv_VrateneZadavatelovi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_Odlozene.SuspendLayout()
        CType(Me.dgv_Odlozene, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_Rozpracovane.SuspendLayout()
        CType(Me.dgv_Rozpracovane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_Nove.SuspendLayout()
        CType(Me.dgv_Nove, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb_Ziadanky.SuspendLayout()
        Me.tp_UkoncenieZadavatelom.SuspendLayout()
        CType(Me.dgv_UkoncenieZadavatelom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UlohaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'b_NacitatData
        '
        Me.b_NacitatData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_NacitatData.Location = New System.Drawing.Point(934, 408)
        Me.b_NacitatData.Name = "b_NacitatData"
        Me.b_NacitatData.Size = New System.Drawing.Size(86, 23)
        Me.b_NacitatData.TabIndex = 8
        Me.b_NacitatData.Text = "Načítať dáta"
        Me.b_NacitatData.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 407)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(912, 23)
        Me.ProgressBar1.TabIndex = 9
        '
        'tp_Investicie
        '
        Me.tp_Investicie.Controls.Add(Me.dgv_Investicie)
        Me.tp_Investicie.Location = New System.Drawing.Point(4, 22)
        Me.tp_Investicie.Name = "tp_Investicie"
        Me.tp_Investicie.Size = New System.Drawing.Size(1000, 363)
        Me.tp_Investicie.TabIndex = 3
        Me.tp_Investicie.Text = "Investície"
        Me.tp_Investicie.UseVisualStyleBackColor = True
        '
        'dgv_Investicie
        '
        Me.dgv_Investicie.AllowUserToAddRows = False
        Me.dgv_Investicie.AllowUserToDeleteRows = False
        Me.dgv_Investicie.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Investicie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Investicie.Location = New System.Drawing.Point(6, 6)
        Me.dgv_Investicie.Name = "dgv_Investicie"
        Me.dgv_Investicie.ReadOnly = True
        Me.dgv_Investicie.Size = New System.Drawing.Size(988, 351)
        Me.dgv_Investicie.TabIndex = 15
        '
        'tp_UkonceneUdrzba
        '
        Me.tp_UkonceneUdrzba.Controls.Add(Me.dgv_UkonceneUdrzba)
        Me.tp_UkonceneUdrzba.Location = New System.Drawing.Point(4, 22)
        Me.tp_UkonceneUdrzba.Name = "tp_UkonceneUdrzba"
        Me.tp_UkonceneUdrzba.Size = New System.Drawing.Size(1000, 363)
        Me.tp_UkonceneUdrzba.TabIndex = 2
        Me.tp_UkonceneUdrzba.Text = "Ukončené - Údržba"
        Me.tp_UkonceneUdrzba.UseVisualStyleBackColor = True
        '
        'dgv_UkonceneUdrzba
        '
        Me.dgv_UkonceneUdrzba.AllowUserToAddRows = False
        Me.dgv_UkonceneUdrzba.AllowUserToDeleteRows = False
        Me.dgv_UkonceneUdrzba.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_UkonceneUdrzba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_UkonceneUdrzba.Location = New System.Drawing.Point(6, 6)
        Me.dgv_UkonceneUdrzba.Name = "dgv_UkonceneUdrzba"
        Me.dgv_UkonceneUdrzba.ReadOnly = True
        Me.dgv_UkonceneUdrzba.Size = New System.Drawing.Size(988, 351)
        Me.dgv_UkonceneUdrzba.TabIndex = 15
        '
        'tp_VrateneUdrzbe
        '
        Me.tp_VrateneUdrzbe.Controls.Add(Me.dgv_VrateneUdrzbe)
        Me.tp_VrateneUdrzbe.Location = New System.Drawing.Point(4, 22)
        Me.tp_VrateneUdrzbe.Name = "tp_VrateneUdrzbe"
        Me.tp_VrateneUdrzbe.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_VrateneUdrzbe.Size = New System.Drawing.Size(1000, 363)
        Me.tp_VrateneUdrzbe.TabIndex = 6
        Me.tp_VrateneUdrzbe.Text = "Vrátená - údržbe"
        Me.tp_VrateneUdrzbe.UseVisualStyleBackColor = True
        '
        'dgv_VrateneUdrzbe
        '
        Me.dgv_VrateneUdrzbe.AllowUserToAddRows = False
        Me.dgv_VrateneUdrzbe.AllowUserToDeleteRows = False
        Me.dgv_VrateneUdrzbe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_VrateneUdrzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_VrateneUdrzbe.Location = New System.Drawing.Point(6, 6)
        Me.dgv_VrateneUdrzbe.Name = "dgv_VrateneUdrzbe"
        Me.dgv_VrateneUdrzbe.ReadOnly = True
        Me.dgv_VrateneUdrzbe.Size = New System.Drawing.Size(988, 351)
        Me.dgv_VrateneUdrzbe.TabIndex = 18
        '
        'tp_VrateneZadavatelovi
        '
        Me.tp_VrateneZadavatelovi.Controls.Add(Me.dgv_VrateneZadavatelovi)
        Me.tp_VrateneZadavatelovi.Location = New System.Drawing.Point(4, 22)
        Me.tp_VrateneZadavatelovi.Name = "tp_VrateneZadavatelovi"
        Me.tp_VrateneZadavatelovi.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_VrateneZadavatelovi.Size = New System.Drawing.Size(1000, 363)
        Me.tp_VrateneZadavatelovi.TabIndex = 5
        Me.tp_VrateneZadavatelovi.Text = "Vrátená - zadávateľovi"
        Me.tp_VrateneZadavatelovi.UseVisualStyleBackColor = True
        '
        'dgv_VrateneZadavatelovi
        '
        Me.dgv_VrateneZadavatelovi.AllowUserToAddRows = False
        Me.dgv_VrateneZadavatelovi.AllowUserToDeleteRows = False
        Me.dgv_VrateneZadavatelovi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_VrateneZadavatelovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_VrateneZadavatelovi.Location = New System.Drawing.Point(6, 6)
        Me.dgv_VrateneZadavatelovi.Name = "dgv_VrateneZadavatelovi"
        Me.dgv_VrateneZadavatelovi.ReadOnly = True
        Me.dgv_VrateneZadavatelovi.Size = New System.Drawing.Size(988, 351)
        Me.dgv_VrateneZadavatelovi.TabIndex = 17
        '
        'tp_Odlozene
        '
        Me.tp_Odlozene.Controls.Add(Me.dgv_Odlozene)
        Me.tp_Odlozene.Location = New System.Drawing.Point(4, 22)
        Me.tp_Odlozene.Name = "tp_Odlozene"
        Me.tp_Odlozene.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_Odlozene.Size = New System.Drawing.Size(1000, 363)
        Me.tp_Odlozene.TabIndex = 4
        Me.tp_Odlozene.Text = "Odložené"
        Me.tp_Odlozene.UseVisualStyleBackColor = True
        '
        'dgv_Odlozene
        '
        Me.dgv_Odlozene.AllowUserToAddRows = False
        Me.dgv_Odlozene.AllowUserToDeleteRows = False
        Me.dgv_Odlozene.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Odlozene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Odlozene.Location = New System.Drawing.Point(6, 6)
        Me.dgv_Odlozene.Name = "dgv_Odlozene"
        Me.dgv_Odlozene.ReadOnly = True
        Me.dgv_Odlozene.Size = New System.Drawing.Size(988, 351)
        Me.dgv_Odlozene.TabIndex = 16
        '
        'tp_Rozpracovane
        '
        Me.tp_Rozpracovane.Controls.Add(Me.dgv_Rozpracovane)
        Me.tp_Rozpracovane.Location = New System.Drawing.Point(4, 22)
        Me.tp_Rozpracovane.Name = "tp_Rozpracovane"
        Me.tp_Rozpracovane.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_Rozpracovane.Size = New System.Drawing.Size(1000, 363)
        Me.tp_Rozpracovane.TabIndex = 1
        Me.tp_Rozpracovane.Text = "Rozpracované"
        Me.tp_Rozpracovane.UseVisualStyleBackColor = True
        '
        'dgv_Rozpracovane
        '
        Me.dgv_Rozpracovane.AllowUserToAddRows = False
        Me.dgv_Rozpracovane.AllowUserToDeleteRows = False
        Me.dgv_Rozpracovane.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Rozpracovane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Rozpracovane.Location = New System.Drawing.Point(6, 6)
        Me.dgv_Rozpracovane.Name = "dgv_Rozpracovane"
        Me.dgv_Rozpracovane.ReadOnly = True
        Me.dgv_Rozpracovane.Size = New System.Drawing.Size(988, 351)
        Me.dgv_Rozpracovane.TabIndex = 15
        '
        'tp_Nove
        '
        Me.tp_Nove.Controls.Add(Me.dgv_Nove)
        Me.tp_Nove.Location = New System.Drawing.Point(4, 22)
        Me.tp_Nove.Name = "tp_Nove"
        Me.tp_Nove.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_Nove.Size = New System.Drawing.Size(1000, 363)
        Me.tp_Nove.TabIndex = 0
        Me.tp_Nove.Text = "Nové"
        Me.tp_Nove.UseVisualStyleBackColor = True
        '
        'dgv_Nove
        '
        Me.dgv_Nove.AllowUserToAddRows = False
        Me.dgv_Nove.AllowUserToDeleteRows = False
        Me.dgv_Nove.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Nove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Nove.Location = New System.Drawing.Point(6, 6)
        Me.dgv_Nove.Name = "dgv_Nove"
        Me.dgv_Nove.ReadOnly = True
        Me.dgv_Nove.Size = New System.Drawing.Size(988, 351)
        Me.dgv_Nove.TabIndex = 14
        '
        'tb_Ziadanky
        '
        Me.tb_Ziadanky.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_Ziadanky.Controls.Add(Me.tp_Nove)
        Me.tb_Ziadanky.Controls.Add(Me.tp_Rozpracovane)
        Me.tb_Ziadanky.Controls.Add(Me.tp_Odlozene)
        Me.tb_Ziadanky.Controls.Add(Me.tp_VrateneZadavatelovi)
        Me.tb_Ziadanky.Controls.Add(Me.tp_VrateneUdrzbe)
        Me.tb_Ziadanky.Controls.Add(Me.tp_UkoncenieZadavatelom)
        Me.tb_Ziadanky.Controls.Add(Me.tp_UkonceneUdrzba)
        Me.tb_Ziadanky.Controls.Add(Me.tp_Investicie)
        Me.tb_Ziadanky.Location = New System.Drawing.Point(12, 12)
        Me.tb_Ziadanky.Name = "tb_Ziadanky"
        Me.tb_Ziadanky.SelectedIndex = 0
        Me.tb_Ziadanky.Size = New System.Drawing.Size(1008, 389)
        Me.tb_Ziadanky.TabIndex = 7
        '
        'tp_UkoncenieZadavatelom
        '
        Me.tp_UkoncenieZadavatelom.Controls.Add(Me.dgv_UkoncenieZadavatelom)
        Me.tp_UkoncenieZadavatelom.Location = New System.Drawing.Point(4, 22)
        Me.tp_UkoncenieZadavatelom.Name = "tp_UkoncenieZadavatelom"
        Me.tp_UkoncenieZadavatelom.Size = New System.Drawing.Size(1000, 363)
        Me.tp_UkoncenieZadavatelom.TabIndex = 7
        Me.tp_UkoncenieZadavatelom.Text = "Ukončenie zadávateľom"
        Me.tp_UkoncenieZadavatelom.UseVisualStyleBackColor = True
        '
        'dgv_UkoncenieZadavatelom
        '
        Me.dgv_UkoncenieZadavatelom.AllowUserToAddRows = False
        Me.dgv_UkoncenieZadavatelom.AllowUserToDeleteRows = False
        Me.dgv_UkoncenieZadavatelom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_UkoncenieZadavatelom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_UkoncenieZadavatelom.Location = New System.Drawing.Point(6, 6)
        Me.dgv_UkoncenieZadavatelom.Name = "dgv_UkoncenieZadavatelom"
        Me.dgv_UkoncenieZadavatelom.ReadOnly = True
        Me.dgv_UkoncenieZadavatelom.Size = New System.Drawing.Size(988, 351)
        Me.dgv_UkoncenieZadavatelom.TabIndex = 16
        '
        'Ziadanky_zoznam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1032, 443)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.b_NacitatData)
        Me.Controls.Add(Me.tb_Ziadanky)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ziadanky_zoznam"
        Me.Text = "Zoznam žiadaniek"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tp_Investicie.ResumeLayout(False)
        CType(Me.dgv_Investicie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_UkonceneUdrzba.ResumeLayout(False)
        CType(Me.dgv_UkonceneUdrzba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_VrateneUdrzbe.ResumeLayout(False)
        CType(Me.dgv_VrateneUdrzbe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_VrateneZadavatelovi.ResumeLayout(False)
        CType(Me.dgv_VrateneZadavatelovi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_Odlozene.ResumeLayout(False)
        CType(Me.dgv_Odlozene, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_Rozpracovane.ResumeLayout(False)
        CType(Me.dgv_Rozpracovane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_Nove.ResumeLayout(False)
        CType(Me.dgv_Nove, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb_Ziadanky.ResumeLayout(False)
        Me.tp_UkoncenieZadavatelom.ResumeLayout(False)
        CType(Me.dgv_UkoncenieZadavatelom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UlohaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UlohaBindingSource As BindingSource
    Friend WithEvents b_NacitatData As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents tp_Investicie As TabPage
    Friend WithEvents dgv_Investicie As DataGridView
    Friend WithEvents tp_UkonceneUdrzba As TabPage
    Friend WithEvents dgv_UkonceneUdrzba As DataGridView
    Friend WithEvents tp_VrateneUdrzbe As TabPage
    Friend WithEvents dgv_VrateneUdrzbe As DataGridView
    Friend WithEvents tp_VrateneZadavatelovi As TabPage
    Friend WithEvents dgv_VrateneZadavatelovi As DataGridView
    Friend WithEvents tp_Odlozene As TabPage
    Friend WithEvents dgv_Odlozene As DataGridView
    Friend WithEvents tp_Rozpracovane As TabPage
    Friend WithEvents dgv_Rozpracovane As DataGridView
    Friend WithEvents tp_Nove As TabPage
    Friend WithEvents dgv_Nove As DataGridView
    Friend WithEvents tb_Ziadanky As TabControl
    Friend WithEvents tp_UkoncenieZadavatelom As TabPage
    Friend WithEvents dgv_UkoncenieZadavatelom As DataGridView
End Class
