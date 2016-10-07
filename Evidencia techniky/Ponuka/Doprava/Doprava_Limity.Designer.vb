<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doprava_Limity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Doprava_Limity))
        Me.b_Ulozit = New System.Windows.Forms.Button()
        Me.l_VSZP = New System.Windows.Forms.Label()
        Me.l_Union = New System.Windows.Forms.Label()
        Me.l_Dovera = New System.Windows.Forms.Label()
        Me.tb_VSZP_ZaKM = New System.Windows.Forms.TextBox()
        Me.tb_VSZP_Suma = New System.Windows.Forms.TextBox()
        Me.tb_VSZP_KM = New System.Windows.Forms.TextBox()
        Me.tb_Union_KM = New System.Windows.Forms.TextBox()
        Me.tb_Union_Suma = New System.Windows.Forms.TextBox()
        Me.tb_Union_ZaKM = New System.Windows.Forms.TextBox()
        Me.tb_Dovera_KM = New System.Windows.Forms.TextBox()
        Me.tb_Dovera_Suma = New System.Windows.Forms.TextBox()
        Me.tb_Dovera_ZaKM = New System.Windows.Forms.TextBox()
        Me.l_CenaZaKM = New System.Windows.Forms.Label()
        Me.l_LimitSuma = New System.Windows.Forms.Label()
        Me.l_LimitKM = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'b_Ulozit
        '
        Me.b_Ulozit.Location = New System.Drawing.Point(296, 126)
        Me.b_Ulozit.Name = "b_Ulozit"
        Me.b_Ulozit.Size = New System.Drawing.Size(75, 23)
        Me.b_Ulozit.TabIndex = 0
        Me.b_Ulozit.Text = "Uložiť"
        Me.b_Ulozit.UseVisualStyleBackColor = True
        '
        'l_VSZP
        '
        Me.l_VSZP.AutoSize = True
        Me.l_VSZP.Location = New System.Drawing.Point(19, 39)
        Me.l_VSZP.Name = "l_VSZP"
        Me.l_VSZP.Size = New System.Drawing.Size(33, 13)
        Me.l_VSZP.TabIndex = 1
        Me.l_VSZP.Text = "VšZP"
        '
        'l_Union
        '
        Me.l_Union.AutoSize = True
        Me.l_Union.Location = New System.Drawing.Point(17, 64)
        Me.l_Union.Name = "l_Union"
        Me.l_Union.Size = New System.Drawing.Size(35, 13)
        Me.l_Union.TabIndex = 2
        Me.l_Union.Text = "Union"
        '
        'l_Dovera
        '
        Me.l_Dovera.AutoSize = True
        Me.l_Dovera.Location = New System.Drawing.Point(10, 90)
        Me.l_Dovera.Name = "l_Dovera"
        Me.l_Dovera.Size = New System.Drawing.Size(42, 13)
        Me.l_Dovera.TabIndex = 3
        Me.l_Dovera.Text = "Dôvera"
        '
        'tb_VSZP_ZaKM
        '
        Me.tb_VSZP_ZaKM.Location = New System.Drawing.Point(58, 35)
        Me.tb_VSZP_ZaKM.Name = "tb_VSZP_ZaKM"
        Me.tb_VSZP_ZaKM.Size = New System.Drawing.Size(100, 20)
        Me.tb_VSZP_ZaKM.TabIndex = 4
        '
        'tb_VSZP_Suma
        '
        Me.tb_VSZP_Suma.Location = New System.Drawing.Point(164, 35)
        Me.tb_VSZP_Suma.Name = "tb_VSZP_Suma"
        Me.tb_VSZP_Suma.Size = New System.Drawing.Size(100, 20)
        Me.tb_VSZP_Suma.TabIndex = 5
        '
        'tb_VSZP_KM
        '
        Me.tb_VSZP_KM.Location = New System.Drawing.Point(270, 35)
        Me.tb_VSZP_KM.Name = "tb_VSZP_KM"
        Me.tb_VSZP_KM.Size = New System.Drawing.Size(100, 20)
        Me.tb_VSZP_KM.TabIndex = 6
        '
        'tb_Union_KM
        '
        Me.tb_Union_KM.Location = New System.Drawing.Point(270, 61)
        Me.tb_Union_KM.Name = "tb_Union_KM"
        Me.tb_Union_KM.Size = New System.Drawing.Size(100, 20)
        Me.tb_Union_KM.TabIndex = 9
        '
        'tb_Union_Suma
        '
        Me.tb_Union_Suma.Location = New System.Drawing.Point(164, 61)
        Me.tb_Union_Suma.Name = "tb_Union_Suma"
        Me.tb_Union_Suma.Size = New System.Drawing.Size(100, 20)
        Me.tb_Union_Suma.TabIndex = 8
        '
        'tb_Union_ZaKM
        '
        Me.tb_Union_ZaKM.Location = New System.Drawing.Point(58, 61)
        Me.tb_Union_ZaKM.Name = "tb_Union_ZaKM"
        Me.tb_Union_ZaKM.Size = New System.Drawing.Size(100, 20)
        Me.tb_Union_ZaKM.TabIndex = 7
        '
        'tb_Dovera_KM
        '
        Me.tb_Dovera_KM.Location = New System.Drawing.Point(270, 87)
        Me.tb_Dovera_KM.Name = "tb_Dovera_KM"
        Me.tb_Dovera_KM.Size = New System.Drawing.Size(100, 20)
        Me.tb_Dovera_KM.TabIndex = 12
        '
        'tb_Dovera_Suma
        '
        Me.tb_Dovera_Suma.Location = New System.Drawing.Point(164, 87)
        Me.tb_Dovera_Suma.Name = "tb_Dovera_Suma"
        Me.tb_Dovera_Suma.Size = New System.Drawing.Size(100, 20)
        Me.tb_Dovera_Suma.TabIndex = 11
        '
        'tb_Dovera_ZaKM
        '
        Me.tb_Dovera_ZaKM.Location = New System.Drawing.Point(58, 87)
        Me.tb_Dovera_ZaKM.Name = "tb_Dovera_ZaKM"
        Me.tb_Dovera_ZaKM.Size = New System.Drawing.Size(100, 20)
        Me.tb_Dovera_ZaKM.TabIndex = 10
        '
        'l_CenaZaKM
        '
        Me.l_CenaZaKM.AutoSize = True
        Me.l_CenaZaKM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_CenaZaKM.Location = New System.Drawing.Point(67, 19)
        Me.l_CenaZaKM.Name = "l_CenaZaKM"
        Me.l_CenaZaKM.Size = New System.Drawing.Size(75, 13)
        Me.l_CenaZaKM.TabIndex = 13
        Me.l_CenaZaKM.Text = "Cena za KM"
        '
        'l_LimitSuma
        '
        Me.l_LimitSuma.AutoSize = True
        Me.l_LimitSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_LimitSuma.Location = New System.Drawing.Point(182, 19)
        Me.l_LimitSuma.Name = "l_LimitSuma"
        Me.l_LimitSuma.Size = New System.Drawing.Size(66, 13)
        Me.l_LimitSuma.TabIndex = 14
        Me.l_LimitSuma.Text = "Limit suma"
        '
        'l_LimitKM
        '
        Me.l_LimitKM.AutoSize = True
        Me.l_LimitKM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_LimitKM.Location = New System.Drawing.Point(293, 19)
        Me.l_LimitKM.Name = "l_LimitKM"
        Me.l_LimitKM.Size = New System.Drawing.Size(55, 13)
        Me.l_LimitKM.TabIndex = 15
        Me.l_LimitKM.Text = "Limit KM"
        '
        'Doprava_Limity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 158)
        Me.Controls.Add(Me.l_LimitKM)
        Me.Controls.Add(Me.l_LimitSuma)
        Me.Controls.Add(Me.l_CenaZaKM)
        Me.Controls.Add(Me.tb_Dovera_KM)
        Me.Controls.Add(Me.tb_Dovera_Suma)
        Me.Controls.Add(Me.tb_Dovera_ZaKM)
        Me.Controls.Add(Me.tb_Union_KM)
        Me.Controls.Add(Me.tb_Union_Suma)
        Me.Controls.Add(Me.tb_Union_ZaKM)
        Me.Controls.Add(Me.tb_VSZP_KM)
        Me.Controls.Add(Me.tb_VSZP_Suma)
        Me.Controls.Add(Me.tb_VSZP_ZaKM)
        Me.Controls.Add(Me.l_Dovera)
        Me.Controls.Add(Me.l_Union)
        Me.Controls.Add(Me.l_VSZP)
        Me.Controls.Add(Me.b_Ulozit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Doprava_Limity"
        Me.Text = "Nastavenie limitov"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents b_Ulozit As Button
    Friend WithEvents l_VSZP As Label
    Friend WithEvents l_Union As Label
    Friend WithEvents l_Dovera As Label
    Friend WithEvents tb_VSZP_ZaKM As TextBox
    Friend WithEvents tb_VSZP_Suma As TextBox
    Friend WithEvents tb_VSZP_KM As TextBox
    Friend WithEvents tb_Union_KM As TextBox
    Friend WithEvents tb_Union_Suma As TextBox
    Friend WithEvents tb_Union_ZaKM As TextBox
    Friend WithEvents tb_Dovera_KM As TextBox
    Friend WithEvents tb_Dovera_Suma As TextBox
    Friend WithEvents tb_Dovera_ZaKM As TextBox
    Friend WithEvents l_CenaZaKM As Label
    Friend WithEvents l_LimitSuma As Label
    Friend WithEvents l_LimitKM As Label
End Class
