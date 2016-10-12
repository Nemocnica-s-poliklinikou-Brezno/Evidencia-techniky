<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vykaz_hodin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vykaz_hodin))
        Me.b_Ulozit = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.gb_VykazaneHodiny = New System.Windows.Forms.GroupBox()
        Me.l_Sumar_hodín = New System.Windows.Forms.Label()
        Me.l_Oddelenie = New System.Windows.Forms.Label()
        Me.l_Datum = New System.Windows.Forms.Label()
        Me.l_POddelenie = New System.Windows.Forms.Label()
        Me.l_PDatum = New System.Windows.Forms.Label()
        Me.b_Export = New System.Windows.Forms.Button()
        Me.l_CIsloZiadanky = New System.Windows.Forms.Label()
        Me.l_PCisloZiadanky = New System.Windows.Forms.Label()
        Me.gb_VykazaneHodiny.SuspendLayout()
        Me.SuspendLayout()
        '
        'b_Ulozit
        '
        Me.b_Ulozit.Location = New System.Drawing.Point(384, 130)
        Me.b_Ulozit.Name = "b_Ulozit"
        Me.b_Ulozit.Size = New System.Drawing.Size(75, 23)
        Me.b_Ulozit.TabIndex = 0
        Me.b_Ulozit.Text = "Uložiť"
        Me.b_Ulozit.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(448, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(95, 26)
        Me.TextBox1.TabIndex = 1
        '
        'gb_VykazaneHodiny
        '
        Me.gb_VykazaneHodiny.Controls.Add(Me.l_CIsloZiadanky)
        Me.gb_VykazaneHodiny.Controls.Add(Me.l_PCisloZiadanky)
        Me.gb_VykazaneHodiny.Controls.Add(Me.l_Sumar_hodín)
        Me.gb_VykazaneHodiny.Controls.Add(Me.l_Oddelenie)
        Me.gb_VykazaneHodiny.Controls.Add(Me.l_Datum)
        Me.gb_VykazaneHodiny.Controls.Add(Me.l_POddelenie)
        Me.gb_VykazaneHodiny.Controls.Add(Me.l_PDatum)
        Me.gb_VykazaneHodiny.Controls.Add(Me.TextBox1)
        Me.gb_VykazaneHodiny.Location = New System.Drawing.Point(13, 13)
        Me.gb_VykazaneHodiny.Name = "gb_VykazaneHodiny"
        Me.gb_VykazaneHodiny.Size = New System.Drawing.Size(633, 101)
        Me.gb_VykazaneHodiny.TabIndex = 2
        Me.gb_VykazaneHodiny.TabStop = False
        Me.gb_VykazaneHodiny.Text = "Vykázané hodiny"
        '
        'l_Sumar_hodín
        '
        Me.l_Sumar_hodín.AutoSize = True
        Me.l_Sumar_hodín.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_Sumar_hodín.Location = New System.Drawing.Point(444, 18)
        Me.l_Sumar_hodín.Name = "l_Sumar_hodín"
        Me.l_Sumar_hodín.Size = New System.Drawing.Size(99, 20)
        Me.l_Sumar_hodín.TabIndex = 6
        Me.l_Sumar_hodín.Text = "Sumár hodín"
        '
        'l_Oddelenie
        '
        Me.l_Oddelenie.AutoSize = True
        Me.l_Oddelenie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_Oddelenie.Location = New System.Drawing.Point(268, 21)
        Me.l_Oddelenie.Name = "l_Oddelenie"
        Me.l_Oddelenie.Size = New System.Drawing.Size(81, 20)
        Me.l_Oddelenie.TabIndex = 5
        Me.l_Oddelenie.Text = "Oddelenie"
        '
        'l_Datum
        '
        Me.l_Datum.AutoSize = True
        Me.l_Datum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_Datum.Location = New System.Drawing.Point(147, 21)
        Me.l_Datum.Name = "l_Datum"
        Me.l_Datum.Size = New System.Drawing.Size(57, 20)
        Me.l_Datum.TabIndex = 4
        Me.l_Datum.Text = "Dátum"
        '
        'l_POddelenie
        '
        Me.l_POddelenie.AutoSize = True
        Me.l_POddelenie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_POddelenie.Location = New System.Drawing.Point(268, 50)
        Me.l_POddelenie.Name = "l_POddelenie"
        Me.l_POddelenie.Size = New System.Drawing.Size(97, 20)
        Me.l_POddelenie.TabIndex = 3
        Me.l_POddelenie.Text = "@Oddelenie"
        '
        'l_PDatum
        '
        Me.l_PDatum.AutoSize = True
        Me.l_PDatum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_PDatum.Location = New System.Drawing.Point(147, 50)
        Me.l_PDatum.Name = "l_PDatum"
        Me.l_PDatum.Size = New System.Drawing.Size(73, 20)
        Me.l_PDatum.TabIndex = 2
        Me.l_PDatum.Text = "@Dátum"
        '
        'b_Export
        '
        Me.b_Export.BackColor = System.Drawing.SystemColors.ControlLight
        Me.b_Export.Cursor = System.Windows.Forms.Cursors.Default
        Me.b_Export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_Export.Location = New System.Drawing.Point(303, 131)
        Me.b_Export.Name = "b_Export"
        Me.b_Export.Size = New System.Drawing.Size(75, 23)
        Me.b_Export.TabIndex = 3
        Me.b_Export.Text = "Export"
        Me.b_Export.UseVisualStyleBackColor = False
        '
        'l_CIsloZiadanky
        '
        Me.l_CIsloZiadanky.AutoSize = True
        Me.l_CIsloZiadanky.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_CIsloZiadanky.Location = New System.Drawing.Point(6, 21)
        Me.l_CIsloZiadanky.Name = "l_CIsloZiadanky"
        Me.l_CIsloZiadanky.Size = New System.Drawing.Size(109, 20)
        Me.l_CIsloZiadanky.TabIndex = 8
        Me.l_CIsloZiadanky.Text = "Číslo žiadanky"
        '
        'l_PCisloZiadanky
        '
        Me.l_PCisloZiadanky.AutoSize = True
        Me.l_PCisloZiadanky.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_PCisloZiadanky.Location = New System.Drawing.Point(6, 50)
        Me.l_PCisloZiadanky.Name = "l_PCisloZiadanky"
        Me.l_PCisloZiadanky.Size = New System.Drawing.Size(125, 20)
        Me.l_PCisloZiadanky.TabIndex = 7
        Me.l_PCisloZiadanky.Text = "@Číslo žiadanky"
        '
        'Vykaz_hodin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 159)
        Me.Controls.Add(Me.b_Export)
        Me.Controls.Add(Me.gb_VykazaneHodiny)
        Me.Controls.Add(Me.b_Ulozit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Vykaz_hodin"
        Me.Text = "Výkaz hodín prác"
        Me.gb_VykazaneHodiny.ResumeLayout(False)
        Me.gb_VykazaneHodiny.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents b_Ulozit As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents gb_VykazaneHodiny As GroupBox
    Friend WithEvents l_POddelenie As Label
    Friend WithEvents l_PDatum As Label
    Friend WithEvents b_Export As Button
    Friend WithEvents l_Sumar_hodín As Label
    Friend WithEvents l_Oddelenie As Label
    Friend WithEvents l_Datum As Label
    Friend WithEvents l_CIsloZiadanky As Label
    Friend WithEvents l_PCisloZiadanky As Label
End Class
