<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Software_priprad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Software_priprad))
        Me.tb_Vyhladaj = New System.Windows.Forms.TextBox()
        Me.b_Vyhladaj = New System.Windows.Forms.Button()
        Me.cb_NazovZariadenia = New System.Windows.Forms.ComboBox()
        Me.l_NazovPocitaca = New System.Windows.Forms.Label()
        Me.l_licencia = New System.Windows.Forms.Label()
        Me.tb_CisloLicencie = New System.Windows.Forms.TextBox()
        Me.b_Priradiť = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_Vyhladaj
        '
        Me.tb_Vyhladaj.Location = New System.Drawing.Point(12, 12)
        Me.tb_Vyhladaj.Name = "tb_Vyhladaj"
        Me.tb_Vyhladaj.Size = New System.Drawing.Size(437, 20)
        Me.tb_Vyhladaj.TabIndex = 0
        '
        'b_Vyhladaj
        '
        Me.b_Vyhladaj.Location = New System.Drawing.Point(455, 10)
        Me.b_Vyhladaj.Name = "b_Vyhladaj"
        Me.b_Vyhladaj.Size = New System.Drawing.Size(75, 23)
        Me.b_Vyhladaj.TabIndex = 1
        Me.b_Vyhladaj.Text = "Vyhľadaj"
        Me.b_Vyhladaj.UseVisualStyleBackColor = True
        '
        'cb_NazovZariadenia
        '
        Me.cb_NazovZariadenia.FormattingEnabled = True
        Me.cb_NazovZariadenia.Location = New System.Drawing.Point(12, 58)
        Me.cb_NazovZariadenia.Name = "cb_NazovZariadenia"
        Me.cb_NazovZariadenia.Size = New System.Drawing.Size(121, 21)
        Me.cb_NazovZariadenia.TabIndex = 2
        '
        'l_NazovPocitaca
        '
        Me.l_NazovPocitaca.AutoSize = True
        Me.l_NazovPocitaca.Location = New System.Drawing.Point(9, 42)
        Me.l_NazovPocitaca.Name = "l_NazovPocitaca"
        Me.l_NazovPocitaca.Size = New System.Drawing.Size(84, 13)
        Me.l_NazovPocitaca.TabIndex = 3
        Me.l_NazovPocitaca.Text = "Názov počítača"
        '
        'l_licencia
        '
        Me.l_licencia.AutoSize = True
        Me.l_licencia.Location = New System.Drawing.Point(151, 42)
        Me.l_licencia.Name = "l_licencia"
        Me.l_licencia.Size = New System.Drawing.Size(70, 13)
        Me.l_licencia.TabIndex = 4
        Me.l_licencia.Text = "Číslo licencie"
        '
        'tb_CisloLicencie
        '
        Me.tb_CisloLicencie.Location = New System.Drawing.Point(154, 58)
        Me.tb_CisloLicencie.Name = "tb_CisloLicencie"
        Me.tb_CisloLicencie.Size = New System.Drawing.Size(295, 20)
        Me.tb_CisloLicencie.TabIndex = 5
        '
        'b_Priradiť
        '
        Me.b_Priradiť.Location = New System.Drawing.Point(455, 58)
        Me.b_Priradiť.Name = "b_Priradiť"
        Me.b_Priradiť.Size = New System.Drawing.Size(75, 23)
        Me.b_Priradiť.TabIndex = 6
        Me.b_Priradiť.Text = "Priradiť"
        Me.b_Priradiť.UseVisualStyleBackColor = True
        '
        'Software
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 93)
        Me.Controls.Add(Me.b_Priradiť)
        Me.Controls.Add(Me.tb_CisloLicencie)
        Me.Controls.Add(Me.l_licencia)
        Me.Controls.Add(Me.l_NazovPocitaca)
        Me.Controls.Add(Me.cb_NazovZariadenia)
        Me.Controls.Add(Me.b_Vyhladaj)
        Me.Controls.Add(Me.tb_Vyhladaj)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Software"
        Me.Text = "Software"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_Vyhladaj As TextBox
    Friend WithEvents b_Vyhladaj As Button
    Friend WithEvents cb_NazovZariadenia As ComboBox
    Friend WithEvents l_NazovPocitaca As Label
    Friend WithEvents l_licencia As Label
    Friend WithEvents tb_CisloLicencie As TextBox
    Friend WithEvents b_Priradiť As Button
End Class
