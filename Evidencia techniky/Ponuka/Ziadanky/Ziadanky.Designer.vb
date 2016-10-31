<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ziadanky
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ziadanky))
        Me.cb_ZOddelenia = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gb_Zadavatel = New System.Windows.Forms.GroupBox()
        Me.chb_Zeny = New System.Windows.Forms.CheckBox()
        Me.chb_Muzi = New System.Windows.Forms.CheckBox()
        Me.l_TypPrace = New System.Windows.Forms.Label()
        Me.cb_TypPrace = New System.Windows.Forms.ComboBox()
        Me.l_TypPoziadavky = New System.Windows.Forms.Label()
        Me.cb_TypPoziadavky = New System.Windows.Forms.ComboBox()
        Me.ll_Zoznam = New System.Windows.Forms.LinkLabel()
        Me.tb_Miestnost = New System.Windows.Forms.TextBox()
        Me.l_Miestnost = New System.Windows.Forms.Label()
        Me.rtb_Popis = New System.Windows.Forms.RichTextBox()
        Me.l_PopisZiadanejPrace = New System.Windows.Forms.Label()
        Me.l_SpracovatDo = New System.Windows.Forms.Label()
        Me.dtp_SpracovatDo = New System.Windows.Forms.DateTimePicker()
        Me.b_Zadat = New System.Windows.Forms.Button()
        Me.chb_Urgentne = New System.Windows.Forms.CheckBox()
        Me.MessageQueue1 = New System.Messaging.MessageQueue()
        Me.ll_PridatOdd = New System.Windows.Forms.LinkLabel()
        Me.gb_Zadavatel.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_ZOddelenia
        '
        Me.cb_ZOddelenia.FormattingEnabled = True
        Me.cb_ZOddelenia.Location = New System.Drawing.Point(85, 235)
        Me.cb_ZOddelenia.Name = "cb_ZOddelenia"
        Me.cb_ZOddelenia.Size = New System.Drawing.Size(216, 21)
        Me.cb_ZOddelenia.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Z oddelenia"
        '
        'gb_Zadavatel
        '
        Me.gb_Zadavatel.Controls.Add(Me.ll_PridatOdd)
        Me.gb_Zadavatel.Controls.Add(Me.chb_Zeny)
        Me.gb_Zadavatel.Controls.Add(Me.chb_Muzi)
        Me.gb_Zadavatel.Controls.Add(Me.l_TypPrace)
        Me.gb_Zadavatel.Controls.Add(Me.cb_TypPrace)
        Me.gb_Zadavatel.Controls.Add(Me.l_TypPoziadavky)
        Me.gb_Zadavatel.Controls.Add(Me.cb_TypPoziadavky)
        Me.gb_Zadavatel.Controls.Add(Me.ll_Zoznam)
        Me.gb_Zadavatel.Controls.Add(Me.tb_Miestnost)
        Me.gb_Zadavatel.Controls.Add(Me.l_Miestnost)
        Me.gb_Zadavatel.Controls.Add(Me.rtb_Popis)
        Me.gb_Zadavatel.Controls.Add(Me.l_PopisZiadanejPrace)
        Me.gb_Zadavatel.Controls.Add(Me.l_SpracovatDo)
        Me.gb_Zadavatel.Controls.Add(Me.dtp_SpracovatDo)
        Me.gb_Zadavatel.Controls.Add(Me.b_Zadat)
        Me.gb_Zadavatel.Controls.Add(Me.chb_Urgentne)
        Me.gb_Zadavatel.Controls.Add(Me.cb_ZOddelenia)
        Me.gb_Zadavatel.Controls.Add(Me.Label1)
        Me.gb_Zadavatel.Location = New System.Drawing.Point(12, 10)
        Me.gb_Zadavatel.Name = "gb_Zadavatel"
        Me.gb_Zadavatel.Size = New System.Drawing.Size(420, 371)
        Me.gb_Zadavatel.TabIndex = 2
        Me.gb_Zadavatel.TabStop = False
        Me.gb_Zadavatel.Text = "Zadávateľ"
        '
        'chb_Zeny
        '
        Me.chb_Zeny.AutoSize = True
        Me.chb_Zeny.Location = New System.Drawing.Point(362, 238)
        Me.chb_Zeny.Name = "chb_Zeny"
        Me.chb_Zeny.Size = New System.Drawing.Size(50, 17)
        Me.chb_Zeny.TabIndex = 16
        Me.chb_Zeny.Text = "Ženy"
        Me.chb_Zeny.UseVisualStyleBackColor = True
        '
        'chb_Muzi
        '
        Me.chb_Muzi.AutoSize = True
        Me.chb_Muzi.Location = New System.Drawing.Point(308, 238)
        Me.chb_Muzi.Name = "chb_Muzi"
        Me.chb_Muzi.Size = New System.Drawing.Size(48, 17)
        Me.chb_Muzi.TabIndex = 15
        Me.chb_Muzi.Text = "Muži"
        Me.chb_Muzi.UseVisualStyleBackColor = True
        '
        'l_TypPrace
        '
        Me.l_TypPrace.AutoSize = True
        Me.l_TypPrace.Location = New System.Drawing.Point(11, 53)
        Me.l_TypPrace.Name = "l_TypPrace"
        Me.l_TypPrace.Size = New System.Drawing.Size(55, 13)
        Me.l_TypPrace.TabIndex = 14
        Me.l_TypPrace.Text = "Typ práce"
        '
        'cb_TypPrace
        '
        Me.cb_TypPrace.FormattingEnabled = True
        Me.cb_TypPrace.Location = New System.Drawing.Point(96, 53)
        Me.cb_TypPrace.Name = "cb_TypPrace"
        Me.cb_TypPrace.Size = New System.Drawing.Size(202, 21)
        Me.cb_TypPrace.TabIndex = 13
        '
        'l_TypPoziadavky
        '
        Me.l_TypPoziadavky.AutoSize = True
        Me.l_TypPoziadavky.Location = New System.Drawing.Point(8, 28)
        Me.l_TypPoziadavky.Name = "l_TypPoziadavky"
        Me.l_TypPoziadavky.Size = New System.Drawing.Size(82, 13)
        Me.l_TypPoziadavky.TabIndex = 12
        Me.l_TypPoziadavky.Text = "Typ požiadavky"
        '
        'cb_TypPoziadavky
        '
        Me.cb_TypPoziadavky.FormattingEnabled = True
        Me.cb_TypPoziadavky.Location = New System.Drawing.Point(96, 25)
        Me.cb_TypPoziadavky.Name = "cb_TypPoziadavky"
        Me.cb_TypPoziadavky.Size = New System.Drawing.Size(202, 21)
        Me.cb_TypPoziadavky.TabIndex = 11
        '
        'll_Zoznam
        '
        Me.ll_Zoznam.AutoSize = True
        Me.ll_Zoznam.Location = New System.Drawing.Point(359, 311)
        Me.ll_Zoznam.Name = "ll_Zoznam"
        Me.ll_Zoznam.Size = New System.Drawing.Size(45, 13)
        Me.ll_Zoznam.TabIndex = 10
        Me.ll_Zoznam.TabStop = True
        Me.ll_Zoznam.Text = "Zoznam"
        Me.ll_Zoznam.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'tb_Miestnost
        '
        Me.tb_Miestnost.AccessibleName = "Zadajte miestnosť"
        Me.tb_Miestnost.Location = New System.Drawing.Point(85, 272)
        Me.tb_Miestnost.Name = "tb_Miestnost"
        Me.tb_Miestnost.Size = New System.Drawing.Size(216, 20)
        Me.tb_Miestnost.TabIndex = 9
        Me.tb_Miestnost.Tag = ""
        '
        'l_Miestnost
        '
        Me.l_Miestnost.AutoSize = True
        Me.l_Miestnost.Location = New System.Drawing.Point(11, 272)
        Me.l_Miestnost.Name = "l_Miestnost"
        Me.l_Miestnost.Size = New System.Drawing.Size(53, 13)
        Me.l_Miestnost.TabIndex = 8
        Me.l_Miestnost.Text = "Miestnosť"
        '
        'rtb_Popis
        '
        Me.rtb_Popis.Location = New System.Drawing.Point(11, 102)
        Me.rtb_Popis.Name = "rtb_Popis"
        Me.rtb_Popis.Size = New System.Drawing.Size(393, 116)
        Me.rtb_Popis.TabIndex = 7
        Me.rtb_Popis.Text = ""
        '
        'l_PopisZiadanejPrace
        '
        Me.l_PopisZiadanejPrace.AutoSize = True
        Me.l_PopisZiadanejPrace.Location = New System.Drawing.Point(11, 86)
        Me.l_PopisZiadanejPrace.Name = "l_PopisZiadanejPrace"
        Me.l_PopisZiadanejPrace.Size = New System.Drawing.Size(105, 13)
        Me.l_PopisZiadanejPrace.TabIndex = 6
        Me.l_PopisZiadanejPrace.Text = "Popis žiadanej práce"
        '
        'l_SpracovatDo
        '
        Me.l_SpracovatDo.AutoSize = True
        Me.l_SpracovatDo.Location = New System.Drawing.Point(11, 311)
        Me.l_SpracovatDo.Name = "l_SpracovatDo"
        Me.l_SpracovatDo.Size = New System.Drawing.Size(72, 13)
        Me.l_SpracovatDo.TabIndex = 5
        Me.l_SpracovatDo.Text = "Spracovať do"
        '
        'dtp_SpracovatDo
        '
        Me.dtp_SpracovatDo.CustomFormat = ""
        Me.dtp_SpracovatDo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_SpracovatDo.Location = New System.Drawing.Point(85, 308)
        Me.dtp_SpracovatDo.Name = "dtp_SpracovatDo"
        Me.dtp_SpracovatDo.Size = New System.Drawing.Size(91, 20)
        Me.dtp_SpracovatDo.TabIndex = 4
        Me.dtp_SpracovatDo.Value = New Date(2016, 5, 19, 0, 0, 0, 0)
        '
        'b_Zadat
        '
        Me.b_Zadat.Location = New System.Drawing.Point(176, 334)
        Me.b_Zadat.Name = "b_Zadat"
        Me.b_Zadat.Size = New System.Drawing.Size(75, 23)
        Me.b_Zadat.TabIndex = 3
        Me.b_Zadat.Text = "Zadať"
        Me.b_Zadat.UseVisualStyleBackColor = True
        '
        'chb_Urgentne
        '
        Me.chb_Urgentne.AutoSize = True
        Me.chb_Urgentne.ForeColor = System.Drawing.Color.Red
        Me.chb_Urgentne.Location = New System.Drawing.Point(308, 274)
        Me.chb_Urgentne.Name = "chb_Urgentne"
        Me.chb_Urgentne.Size = New System.Drawing.Size(70, 17)
        Me.chb_Urgentne.TabIndex = 2
        Me.chb_Urgentne.Text = "Urgentné"
        Me.chb_Urgentne.UseVisualStyleBackColor = True
        '
        'MessageQueue1
        '
        Me.MessageQueue1.MessageReadPropertyFilter.LookupId = True
        Me.MessageQueue1.SynchronizingObject = Me
        '
        'll_PridatOdd
        '
        Me.ll_PridatOdd.AutoSize = True
        Me.ll_PridatOdd.Location = New System.Drawing.Point(332, 222)
        Me.ll_PridatOdd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ll_PridatOdd.Name = "ll_PridatOdd"
        Me.ll_PridatOdd.Size = New System.Drawing.Size(35, 13)
        Me.ll_PridatOdd.TabIndex = 36
        Me.ll_PridatOdd.TabStop = True
        Me.ll_PridatOdd.Text = "Pridať"
        Me.ll_PridatOdd.Visible = False
        '
        'Ziadanky
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 393)
        Me.Controls.Add(Me.gb_Zadavatel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Ziadanky"
        Me.Text = "Zadanie žiadanky"
        Me.gb_Zadavatel.ResumeLayout(False)
        Me.gb_Zadavatel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cb_ZOddelenia As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gb_Zadavatel As GroupBox
    Friend WithEvents rtb_Popis As RichTextBox
    Friend WithEvents l_PopisZiadanejPrace As Label
    Friend WithEvents l_SpracovatDo As Label
    Friend WithEvents dtp_SpracovatDo As DateTimePicker
    Friend WithEvents b_Zadat As Button
    Friend WithEvents chb_Urgentne As CheckBox
    Friend WithEvents l_Miestnost As Label
    Friend WithEvents tb_Miestnost As TextBox
    Friend WithEvents ll_Zoznam As LinkLabel
    Friend WithEvents l_TypPoziadavky As Label
    Friend WithEvents cb_TypPoziadavky As ComboBox
    Friend WithEvents l_TypPrace As Label
    Friend WithEvents cb_TypPrace As ComboBox
    Friend WithEvents MessageQueue1 As Messaging.MessageQueue
    Friend WithEvents chb_Zeny As CheckBox
    Friend WithEvents chb_Muzi As CheckBox
    Friend WithEvents ll_PridatOdd As LinkLabel
End Class
