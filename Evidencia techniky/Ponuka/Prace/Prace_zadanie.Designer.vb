<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prace_zadanie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prace_zadanie))
        Me.B_Priradit = New System.Windows.Forms.Button()
        Me.cb_TypPrace = New System.Windows.Forms.ComboBox()
        Me.tb_CisloPrace = New System.Windows.Forms.TextBox()
        Me.cb_Priradene = New System.Windows.Forms.ComboBox()
        Me.l_TypPrace = New System.Windows.Forms.Label()
        Me.l_CisloPrace = New System.Windows.Forms.Label()
        Me.l_Priradene = New System.Windows.Forms.Label()
        Me.l_ZiadankaCislo = New System.Windows.Forms.Label()
        Me.dtp_SpracovatDo = New System.Windows.Forms.DateTimePicker()
        Me.l_SpracovatDo = New System.Windows.Forms.Label()
        Me.rtb_PopisPrace = New System.Windows.Forms.RichTextBox()
        Me.l_PopisPrace = New System.Windows.Forms.Label()
        Me.l_OznacPraca = New System.Windows.Forms.Label()
        Me.ll_PridatKPRaci = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'B_Priradit
        '
        Me.B_Priradit.Location = New System.Drawing.Point(282, 296)
        Me.B_Priradit.Name = "B_Priradit"
        Me.B_Priradit.Size = New System.Drawing.Size(75, 23)
        Me.B_Priradit.TabIndex = 0
        Me.B_Priradit.Text = "Priradiť"
        Me.B_Priradit.UseVisualStyleBackColor = True
        '
        'cb_TypPrace
        '
        Me.cb_TypPrace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_TypPrace.FormattingEnabled = True
        Me.cb_TypPrace.Location = New System.Drawing.Point(91, 12)
        Me.cb_TypPrace.Name = "cb_TypPrace"
        Me.cb_TypPrace.Size = New System.Drawing.Size(121, 21)
        Me.cb_TypPrace.TabIndex = 1
        '
        'tb_CisloPrace
        '
        Me.tb_CisloPrace.Location = New System.Drawing.Point(115, 40)
        Me.tb_CisloPrace.Name = "tb_CisloPrace"
        Me.tb_CisloPrace.Size = New System.Drawing.Size(97, 20)
        Me.tb_CisloPrace.TabIndex = 2
        '
        'cb_Priradene
        '
        Me.cb_Priradene.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Priradene.FormattingEnabled = True
        Me.cb_Priradene.Location = New System.Drawing.Point(91, 67)
        Me.cb_Priradene.Name = "cb_Priradene"
        Me.cb_Priradene.Size = New System.Drawing.Size(121, 21)
        Me.cb_Priradene.TabIndex = 3
        '
        'l_TypPrace
        '
        Me.l_TypPrace.AutoSize = True
        Me.l_TypPrace.Location = New System.Drawing.Point(30, 15)
        Me.l_TypPrace.Name = "l_TypPrace"
        Me.l_TypPrace.Size = New System.Drawing.Size(55, 13)
        Me.l_TypPrace.TabIndex = 4
        Me.l_TypPrace.Text = "Typ práce"
        '
        'l_CisloPrace
        '
        Me.l_CisloPrace.AutoSize = True
        Me.l_CisloPrace.Location = New System.Drawing.Point(24, 43)
        Me.l_CisloPrace.Name = "l_CisloPrace"
        Me.l_CisloPrace.Size = New System.Drawing.Size(61, 13)
        Me.l_CisloPrace.TabIndex = 5
        Me.l_CisloPrace.Text = "Číslo práce"
        '
        'l_Priradene
        '
        Me.l_Priradene.AutoSize = True
        Me.l_Priradene.Location = New System.Drawing.Point(33, 70)
        Me.l_Priradene.Name = "l_Priradene"
        Me.l_Priradene.Size = New System.Drawing.Size(52, 13)
        Me.l_Priradene.TabIndex = 6
        Me.l_Priradene.Text = "Priradené"
        '
        'l_ZiadankaCislo
        '
        Me.l_ZiadankaCislo.AutoSize = True
        Me.l_ZiadankaCislo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_ZiadankaCislo.Location = New System.Drawing.Point(218, 10)
        Me.l_ZiadankaCislo.Name = "l_ZiadankaCislo"
        Me.l_ZiadankaCislo.Size = New System.Drawing.Size(139, 20)
        Me.l_ZiadankaCislo.TabIndex = 7
        Me.l_ZiadankaCislo.Text = "@ZiadankaCislo"
        '
        'dtp_SpracovatDo
        '
        Me.dtp_SpracovatDo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_SpracovatDo.Location = New System.Drawing.Point(91, 95)
        Me.dtp_SpracovatDo.Name = "dtp_SpracovatDo"
        Me.dtp_SpracovatDo.Size = New System.Drawing.Size(121, 20)
        Me.dtp_SpracovatDo.TabIndex = 8
        '
        'l_SpracovatDo
        '
        Me.l_SpracovatDo.AutoSize = True
        Me.l_SpracovatDo.Location = New System.Drawing.Point(13, 95)
        Me.l_SpracovatDo.Name = "l_SpracovatDo"
        Me.l_SpracovatDo.Size = New System.Drawing.Size(72, 13)
        Me.l_SpracovatDo.TabIndex = 9
        Me.l_SpracovatDo.Text = "Spracovať do"
        '
        'rtb_PopisPrace
        '
        Me.rtb_PopisPrace.Location = New System.Drawing.Point(91, 122)
        Me.rtb_PopisPrace.Name = "rtb_PopisPrace"
        Me.rtb_PopisPrace.Size = New System.Drawing.Size(200, 148)
        Me.rtb_PopisPrace.TabIndex = 10
        Me.rtb_PopisPrace.Text = ""
        '
        'l_PopisPrace
        '
        Me.l_PopisPrace.AutoSize = True
        Me.l_PopisPrace.Location = New System.Drawing.Point(22, 190)
        Me.l_PopisPrace.Name = "l_PopisPrace"
        Me.l_PopisPrace.Size = New System.Drawing.Size(63, 13)
        Me.l_PopisPrace.TabIndex = 11
        Me.l_PopisPrace.Text = "Popis práce"
        '
        'l_OznacPraca
        '
        Me.l_OznacPraca.AutoSize = True
        Me.l_OznacPraca.Location = New System.Drawing.Point(88, 43)
        Me.l_OznacPraca.Name = "l_OznacPraca"
        Me.l_OznacPraca.Size = New System.Drawing.Size(69, 13)
        Me.l_OznacPraca.TabIndex = 12
        Me.l_OznacPraca.Text = "Označ.Práca"
        Me.l_OznacPraca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'll_PridatKPRaci
        '
        Me.ll_PridatKPRaci.AutoSize = True
        Me.ll_PridatKPRaci.Location = New System.Drawing.Point(216, 70)
        Me.ll_PridatKPRaci.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ll_PridatKPRaci.Name = "ll_PridatKPRaci"
        Me.ll_PridatKPRaci.Size = New System.Drawing.Size(35, 13)
        Me.ll_PridatKPRaci.TabIndex = 13
        Me.ll_PridatKPRaci.TabStop = True
        Me.ll_PridatKPRaci.Text = "Pridať"
        '
        'Prace_zadanie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 331)
        Me.Controls.Add(Me.ll_PridatKPRaci)
        Me.Controls.Add(Me.l_OznacPraca)
        Me.Controls.Add(Me.l_PopisPrace)
        Me.Controls.Add(Me.rtb_PopisPrace)
        Me.Controls.Add(Me.l_SpracovatDo)
        Me.Controls.Add(Me.dtp_SpracovatDo)
        Me.Controls.Add(Me.l_ZiadankaCislo)
        Me.Controls.Add(Me.l_Priradene)
        Me.Controls.Add(Me.l_CisloPrace)
        Me.Controls.Add(Me.l_TypPrace)
        Me.Controls.Add(Me.cb_Priradene)
        Me.Controls.Add(Me.tb_CisloPrace)
        Me.Controls.Add(Me.cb_TypPrace)
        Me.Controls.Add(Me.B_Priradit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Prace_zadanie"
        Me.Text = "Zadanie práce"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B_Priradit As Button
    Friend WithEvents cb_TypPrace As ComboBox
    Friend WithEvents tb_CisloPrace As TextBox
    Friend WithEvents cb_Priradene As ComboBox
    Friend WithEvents l_TypPrace As Label
    Friend WithEvents l_CisloPrace As Label
    Friend WithEvents l_Priradene As Label
    Friend WithEvents l_ZiadankaCislo As Label
    Friend WithEvents dtp_SpracovatDo As DateTimePicker
    Friend WithEvents l_SpracovatDo As Label
    Friend WithEvents rtb_PopisPrace As RichTextBox
    Friend WithEvents l_PopisPrace As Label
    Friend WithEvents l_OznacPraca As Label
    Friend WithEvents ll_PridatKPRaci As LinkLabel
End Class
