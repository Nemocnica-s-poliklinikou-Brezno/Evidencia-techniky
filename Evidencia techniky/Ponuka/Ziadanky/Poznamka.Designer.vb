<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Poznamka
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Poznamka))
        Me.tb_Poznamka = New System.Windows.Forms.TextBox()
        Me.b_Ulozit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_Poznamka
        '
        Me.tb_Poznamka.Location = New System.Drawing.Point(13, 13)
        Me.tb_Poznamka.Multiline = True
        Me.tb_Poznamka.Name = "tb_Poznamka"
        Me.tb_Poznamka.Size = New System.Drawing.Size(469, 77)
        Me.tb_Poznamka.TabIndex = 0
        '
        'b_Ulozit
        '
        Me.b_Ulozit.Enabled = False
        Me.b_Ulozit.Location = New System.Drawing.Point(407, 97)
        Me.b_Ulozit.Name = "b_Ulozit"
        Me.b_Ulozit.Size = New System.Drawing.Size(75, 23)
        Me.b_Ulozit.TabIndex = 1
        Me.b_Ulozit.Text = "Uložiť"
        Me.b_Ulozit.UseVisualStyleBackColor = True
        '
        'Poznamka
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 132)
        Me.Controls.Add(Me.b_Ulozit)
        Me.Controls.Add(Me.tb_Poznamka)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Poznamka"
        Me.Text = "Poznámka"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_Poznamka As TextBox
    Friend WithEvents b_Ulozit As Button
End Class
