<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VstupneDataTextBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VstupneDataTextBox))
        Me.Odoslat = New System.Windows.Forms.Button()
        Me.tb_VstupneData = New System.Windows.Forms.TextBox()
        Me.Nadpis = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Odoslat
        '
        Me.Odoslat.Location = New System.Drawing.Point(572, 170)
        Me.Odoslat.Name = "Odoslat"
        Me.Odoslat.Size = New System.Drawing.Size(75, 23)
        Me.Odoslat.TabIndex = 0
        Me.Odoslat.Text = "Uložiť"
        Me.Odoslat.UseVisualStyleBackColor = True
        '
        'tb_VstupneData
        '
        Me.tb_VstupneData.Location = New System.Drawing.Point(13, 36)
        Me.tb_VstupneData.Multiline = True
        Me.tb_VstupneData.Name = "tb_VstupneData"
        Me.tb_VstupneData.Size = New System.Drawing.Size(634, 128)
        Me.tb_VstupneData.TabIndex = 1
        '
        'Nadpis
        '
        Me.Nadpis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Nadpis.AutoSize = True
        Me.Nadpis.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Nadpis.Location = New System.Drawing.Point(12, 9)
        Me.Nadpis.Name = "Nadpis"
        Me.Nadpis.Size = New System.Drawing.Size(75, 24)
        Me.Nadpis.TabIndex = 2
        Me.Nadpis.Text = "Nadpis"
        '
        'VstupneDataTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 205)
        Me.Controls.Add(Me.Nadpis)
        Me.Controls.Add(Me.tb_VstupneData)
        Me.Controls.Add(Me.Odoslat)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VstupneDataTextBox"
        Me.Text = "Vstupne dáta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Odoslat As Button
    Friend WithEvents tb_VstupneData As TextBox
    Friend WithEvents Nadpis As Label
End Class
