<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pripomienky
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pripomienky))
        Me.b_Odoslat = New System.Windows.Forms.Button()
        Me.cb_DruhPripomienky = New System.Windows.Forms.ComboBox()
        Me.l_DruhPripomienky = New System.Windows.Forms.Label()
        Me.tb_Pripomienka = New System.Windows.Forms.TextBox()
        Me.l_Pripomienka = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'b_Odoslat
        '
        Me.b_Odoslat.Location = New System.Drawing.Point(254, 244)
        Me.b_Odoslat.Name = "b_Odoslat"
        Me.b_Odoslat.Size = New System.Drawing.Size(75, 23)
        Me.b_Odoslat.TabIndex = 0
        Me.b_Odoslat.Text = "Odoslať"
        Me.b_Odoslat.UseVisualStyleBackColor = True
        '
        'cb_DruhPripomienky
        '
        Me.cb_DruhPripomienky.FormattingEnabled = True
        Me.cb_DruhPripomienky.Items.AddRange(New Object() {"Chyba v programe", "Nápad na vylepšenie", "Návrh mena pre náš program"})
        Me.cb_DruhPripomienky.Location = New System.Drawing.Point(108, 13)
        Me.cb_DruhPripomienky.Name = "cb_DruhPripomienky"
        Me.cb_DruhPripomienky.Size = New System.Drawing.Size(221, 21)
        Me.cb_DruhPripomienky.TabIndex = 1
        '
        'l_DruhPripomienky
        '
        Me.l_DruhPripomienky.AutoSize = True
        Me.l_DruhPripomienky.Location = New System.Drawing.Point(12, 16)
        Me.l_DruhPripomienky.Name = "l_DruhPripomienky"
        Me.l_DruhPripomienky.Size = New System.Drawing.Size(89, 13)
        Me.l_DruhPripomienky.TabIndex = 2
        Me.l_DruhPripomienky.Text = "Druh pripomienky"
        '
        'tb_Pripomienka
        '
        Me.tb_Pripomienka.Location = New System.Drawing.Point(108, 56)
        Me.tb_Pripomienka.Multiline = True
        Me.tb_Pripomienka.Name = "tb_Pripomienka"
        Me.tb_Pripomienka.Size = New System.Drawing.Size(221, 182)
        Me.tb_Pripomienka.TabIndex = 3
        '
        'l_Pripomienka
        '
        Me.l_Pripomienka.AutoSize = True
        Me.l_Pripomienka.Location = New System.Drawing.Point(12, 133)
        Me.l_Pripomienka.Name = "l_Pripomienka"
        Me.l_Pripomienka.Size = New System.Drawing.Size(65, 13)
        Me.l_Pripomienka.TabIndex = 4
        Me.l_Pripomienka.Text = "Pripomienka"
        '
        'Pripomienky
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 279)
        Me.Controls.Add(Me.l_Pripomienka)
        Me.Controls.Add(Me.tb_Pripomienka)
        Me.Controls.Add(Me.l_DruhPripomienky)
        Me.Controls.Add(Me.cb_DruhPripomienky)
        Me.Controls.Add(Me.b_Odoslat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Pripomienky"
        Me.Text = "Pripomienky"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents b_Odoslat As Button
    Friend WithEvents cb_DruhPripomienky As ComboBox
    Friend WithEvents l_DruhPripomienky As Label
    Friend WithEvents tb_Pripomienka As TextBox
    Friend WithEvents l_Pripomienka As Label
End Class
