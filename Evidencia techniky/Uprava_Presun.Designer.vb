<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Uprava_Presun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Uprava_Presun))
        Me.gb_OpravaPresunu = New System.Windows.Forms.GroupBox()
        Me.tb_Miestnost = New System.Windows.Forms.TextBox()
        Me.l_Oddelenie = New System.Windows.Forms.Label()
        Me.cb_Oddelenie = New System.Windows.Forms.ComboBox()
        Me.b_Ulozit = New System.Windows.Forms.Button()
        Me.l_Miestnost = New System.Windows.Forms.Label()
        Me.dtp_Presunute = New System.Windows.Forms.DateTimePicker()
        Me.gb_OpravaPresunu.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_OpravaPresunu
        '
        Me.gb_OpravaPresunu.Controls.Add(Me.dtp_Presunute)
        Me.gb_OpravaPresunu.Controls.Add(Me.l_Miestnost)
        Me.gb_OpravaPresunu.Controls.Add(Me.tb_Miestnost)
        Me.gb_OpravaPresunu.Controls.Add(Me.l_Oddelenie)
        Me.gb_OpravaPresunu.Controls.Add(Me.cb_Oddelenie)
        Me.gb_OpravaPresunu.Location = New System.Drawing.Point(13, 13)
        Me.gb_OpravaPresunu.Name = "gb_OpravaPresunu"
        Me.gb_OpravaPresunu.Size = New System.Drawing.Size(387, 82)
        Me.gb_OpravaPresunu.TabIndex = 0
        Me.gb_OpravaPresunu.TabStop = False
        Me.gb_OpravaPresunu.Text = "Oprava presunu"
        '
        'tb_Miestnost
        '
        Me.tb_Miestnost.Location = New System.Drawing.Point(133, 42)
        Me.tb_Miestnost.Name = "tb_Miestnost"
        Me.tb_Miestnost.Size = New System.Drawing.Size(142, 20)
        Me.tb_Miestnost.TabIndex = 2
        '
        'l_Oddelenie
        '
        Me.l_Oddelenie.AutoSize = True
        Me.l_Oddelenie.Location = New System.Drawing.Point(32, 25)
        Me.l_Oddelenie.Name = "l_Oddelenie"
        Me.l_Oddelenie.Size = New System.Drawing.Size(55, 13)
        Me.l_Oddelenie.TabIndex = 1
        Me.l_Oddelenie.Text = "Oddelenie"
        '
        'cb_Oddelenie
        '
        Me.cb_Oddelenie.FormattingEnabled = True
        Me.cb_Oddelenie.Location = New System.Drawing.Point(6, 41)
        Me.cb_Oddelenie.Name = "cb_Oddelenie"
        Me.cb_Oddelenie.Size = New System.Drawing.Size(121, 21)
        Me.cb_Oddelenie.TabIndex = 0
        '
        'b_Ulozit
        '
        Me.b_Ulozit.Enabled = False
        Me.b_Ulozit.Location = New System.Drawing.Point(325, 101)
        Me.b_Ulozit.Name = "b_Ulozit"
        Me.b_Ulozit.Size = New System.Drawing.Size(75, 23)
        Me.b_Ulozit.TabIndex = 1
        Me.b_Ulozit.Text = "Uložiť"
        Me.b_Ulozit.UseVisualStyleBackColor = True
        '
        'l_Miestnost
        '
        Me.l_Miestnost.AutoSize = True
        Me.l_Miestnost.Location = New System.Drawing.Point(173, 26)
        Me.l_Miestnost.Name = "l_Miestnost"
        Me.l_Miestnost.Size = New System.Drawing.Size(53, 13)
        Me.l_Miestnost.TabIndex = 3
        Me.l_Miestnost.Text = "Miestnosť"
        '
        'dtp_Presunute
        '
        Me.dtp_Presunute.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Presunute.Location = New System.Drawing.Point(281, 42)
        Me.dtp_Presunute.Name = "dtp_Presunute"
        Me.dtp_Presunute.Size = New System.Drawing.Size(91, 20)
        Me.dtp_Presunute.TabIndex = 4
        '
        'Uprava_Presun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 133)
        Me.Controls.Add(Me.b_Ulozit)
        Me.Controls.Add(Me.gb_OpravaPresunu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Uprava_Presun"
        Me.Text = "Uprava_Presun"
        Me.gb_OpravaPresunu.ResumeLayout(False)
        Me.gb_OpravaPresunu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_OpravaPresunu As GroupBox
    Friend WithEvents tb_Miestnost As TextBox
    Friend WithEvents l_Oddelenie As Label
    Friend WithEvents cb_Oddelenie As ComboBox
    Friend WithEvents b_Ulozit As Button
    Friend WithEvents dtp_Presunute As DateTimePicker
    Friend WithEvents l_Miestnost As Label
End Class
