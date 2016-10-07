<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZmenaHesla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ZmenaHesla))
        Me.tb_zmen = New System.Windows.Forms.Button()
        Me.l_NoveHeslo = New System.Windows.Forms.Label()
        Me.l_OpakovatHeslo = New System.Windows.Forms.Label()
        Me.tb_NoveHeslo = New System.Windows.Forms.TextBox()
        Me.tb_OpakovatHeslo = New System.Windows.Forms.TextBox()
        Me.chb_zobraz = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'tb_zmen
        '
        Me.tb_zmen.Location = New System.Drawing.Point(116, 61)
        Me.tb_zmen.Name = "tb_zmen"
        Me.tb_zmen.Size = New System.Drawing.Size(75, 23)
        Me.tb_zmen.TabIndex = 3
        Me.tb_zmen.Text = "Zmeň"
        Me.tb_zmen.UseVisualStyleBackColor = True
        '
        'l_NoveHeslo
        '
        Me.l_NoveHeslo.AutoSize = True
        Me.l_NoveHeslo.Location = New System.Drawing.Point(34, 16)
        Me.l_NoveHeslo.Name = "l_NoveHeslo"
        Me.l_NoveHeslo.Size = New System.Drawing.Size(64, 13)
        Me.l_NoveHeslo.TabIndex = 1
        Me.l_NoveHeslo.Text = "Nové heslo:"
        '
        'l_OpakovatHeslo
        '
        Me.l_OpakovatHeslo.AutoSize = True
        Me.l_OpakovatHeslo.Location = New System.Drawing.Point(12, 39)
        Me.l_OpakovatHeslo.Name = "l_OpakovatHeslo"
        Me.l_OpakovatHeslo.Size = New System.Drawing.Size(86, 13)
        Me.l_OpakovatHeslo.TabIndex = 2
        Me.l_OpakovatHeslo.Text = "Opakovať heslo:"
        '
        'tb_NoveHeslo
        '
        Me.tb_NoveHeslo.Location = New System.Drawing.Point(104, 12)
        Me.tb_NoveHeslo.Name = "tb_NoveHeslo"
        Me.tb_NoveHeslo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_NoveHeslo.Size = New System.Drawing.Size(100, 20)
        Me.tb_NoveHeslo.TabIndex = 1
        '
        'tb_OpakovatHeslo
        '
        Me.tb_OpakovatHeslo.Location = New System.Drawing.Point(104, 36)
        Me.tb_OpakovatHeslo.Name = "tb_OpakovatHeslo"
        Me.tb_OpakovatHeslo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_OpakovatHeslo.Size = New System.Drawing.Size(100, 20)
        Me.tb_OpakovatHeslo.TabIndex = 2
        '
        'chb_zobraz
        '
        Me.chb_zobraz.AutoSize = True
        Me.chb_zobraz.Location = New System.Drawing.Point(9, 65)
        Me.chb_zobraz.Name = "chb_zobraz"
        Me.chb_zobraz.Size = New System.Drawing.Size(93, 17)
        Me.chb_zobraz.TabIndex = 4
        Me.chb_zobraz.Text = "Zobraziť heslo"
        Me.chb_zobraz.UseVisualStyleBackColor = True
        '
        'ZmenaHesla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 94)
        Me.Controls.Add(Me.chb_zobraz)
        Me.Controls.Add(Me.tb_OpakovatHeslo)
        Me.Controls.Add(Me.tb_NoveHeslo)
        Me.Controls.Add(Me.l_OpakovatHeslo)
        Me.Controls.Add(Me.l_NoveHeslo)
        Me.Controls.Add(Me.tb_zmen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ZmenaHesla"
        Me.Text = "Zmena hesla"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_zmen As Button
    Friend WithEvents l_NoveHeslo As Label
    Friend WithEvents l_OpakovatHeslo As Label
    Friend WithEvents tb_NoveHeslo As TextBox
    Friend WithEvents tb_OpakovatHeslo As TextBox
    Friend WithEvents chb_zobraz As CheckBox
End Class
