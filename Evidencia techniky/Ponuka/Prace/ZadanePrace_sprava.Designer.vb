<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZadanePrace_sprava
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ZadanePrace_sprava))
        Me.b_Ulozit = New System.Windows.Forms.Button()
        Me.l_PracaCislo = New System.Windows.Forms.Label()
        Me.l_PPracaCislo = New System.Windows.Forms.Label()
        Me.l_Priradene = New System.Windows.Forms.Label()
        Me.cb_Priradene = New System.Windows.Forms.ComboBox()
        Me.tb_PopisPrace = New System.Windows.Forms.TextBox()
        Me.l_PopisPrace = New System.Windows.Forms.Label()
        Me.cb_DruhPrace = New System.Windows.Forms.ComboBox()
        Me.l_DruhPrace = New System.Windows.Forms.Label()
        Me.l_PDatumZadania = New System.Windows.Forms.Label()
        Me.l_DatumZadania = New System.Windows.Forms.Label()
        Me.l_OdovzdatDo = New System.Windows.Forms.Label()
        Me.dtp_OdovzdatDo = New System.Windows.Forms.DateTimePicker()
        Me.cb_StavPrace = New System.Windows.Forms.ComboBox()
        Me.l_SpravPrace = New System.Windows.Forms.Label()
        Me.dtp_Spracovane = New System.Windows.Forms.DateTimePicker()
        Me.l_Spracovane = New System.Windows.Forms.Label()
        Me.b_Spracovane = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'b_Ulozit
        '
        Me.b_Ulozit.Location = New System.Drawing.Point(132, 313)
        Me.b_Ulozit.Name = "b_Ulozit"
        Me.b_Ulozit.Size = New System.Drawing.Size(75, 23)
        Me.b_Ulozit.TabIndex = 0
        Me.b_Ulozit.Text = "Uložiť"
        Me.b_Ulozit.UseVisualStyleBackColor = True
        '
        'l_PracaCislo
        '
        Me.l_PracaCislo.AutoSize = True
        Me.l_PracaCislo.Location = New System.Drawing.Point(51, 27)
        Me.l_PracaCislo.Name = "l_PracaCislo"
        Me.l_PracaCislo.Size = New System.Drawing.Size(61, 13)
        Me.l_PracaCislo.TabIndex = 3
        Me.l_PracaCislo.Text = "Práca číslo"
        '
        'l_PPracaCislo
        '
        Me.l_PPracaCislo.AutoSize = True
        Me.l_PPracaCislo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_PPracaCislo.Location = New System.Drawing.Point(128, 22)
        Me.l_PPracaCislo.Name = "l_PPracaCislo"
        Me.l_PPracaCislo.Size = New System.Drawing.Size(111, 20)
        Me.l_PPracaCislo.TabIndex = 4
        Me.l_PPracaCislo.Text = "@PracaCislo"
        '
        'l_Priradene
        '
        Me.l_Priradene.AutoSize = True
        Me.l_Priradene.Location = New System.Drawing.Point(60, 60)
        Me.l_Priradene.Name = "l_Priradene"
        Me.l_Priradene.Size = New System.Drawing.Size(52, 13)
        Me.l_Priradene.TabIndex = 5
        Me.l_Priradene.Text = "Priradené"
        '
        'cb_Priradene
        '
        Me.cb_Priradene.FormattingEnabled = True
        Me.cb_Priradene.Location = New System.Drawing.Point(132, 57)
        Me.cb_Priradene.Name = "cb_Priradene"
        Me.cb_Priradene.Size = New System.Drawing.Size(121, 21)
        Me.cb_Priradene.TabIndex = 6
        '
        'tb_PopisPrace
        '
        Me.tb_PopisPrace.Location = New System.Drawing.Point(132, 84)
        Me.tb_PopisPrace.Multiline = True
        Me.tb_PopisPrace.Name = "tb_PopisPrace"
        Me.tb_PopisPrace.Size = New System.Drawing.Size(242, 83)
        Me.tb_PopisPrace.TabIndex = 8
        '
        'l_PopisPrace
        '
        Me.l_PopisPrace.AutoSize = True
        Me.l_PopisPrace.Location = New System.Drawing.Point(49, 97)
        Me.l_PopisPrace.Name = "l_PopisPrace"
        Me.l_PopisPrace.Size = New System.Drawing.Size(63, 13)
        Me.l_PopisPrace.TabIndex = 7
        Me.l_PopisPrace.Text = "Popis práce"
        '
        'cb_DruhPrace
        '
        Me.cb_DruhPrace.FormattingEnabled = True
        Me.cb_DruhPrace.Location = New System.Drawing.Point(132, 173)
        Me.cb_DruhPrace.Name = "cb_DruhPrace"
        Me.cb_DruhPrace.Size = New System.Drawing.Size(121, 21)
        Me.cb_DruhPrace.TabIndex = 10
        '
        'l_DruhPrace
        '
        Me.l_DruhPrace.AutoSize = True
        Me.l_DruhPrace.Location = New System.Drawing.Point(52, 176)
        Me.l_DruhPrace.Name = "l_DruhPrace"
        Me.l_DruhPrace.Size = New System.Drawing.Size(60, 13)
        Me.l_DruhPrace.TabIndex = 9
        Me.l_DruhPrace.Text = "Druh práce"
        '
        'l_PDatumZadania
        '
        Me.l_PDatumZadania.AutoSize = True
        Me.l_PDatumZadania.Location = New System.Drawing.Point(129, 204)
        Me.l_PDatumZadania.Name = "l_PDatumZadania"
        Me.l_PDatumZadania.Size = New System.Drawing.Size(88, 13)
        Me.l_PDatumZadania.TabIndex = 12
        Me.l_PDatumZadania.Text = "@DatumZadania"
        '
        'l_DatumZadania
        '
        Me.l_DatumZadania.AutoSize = True
        Me.l_DatumZadania.Location = New System.Drawing.Point(34, 204)
        Me.l_DatumZadania.Name = "l_DatumZadania"
        Me.l_DatumZadania.Size = New System.Drawing.Size(78, 13)
        Me.l_DatumZadania.TabIndex = 11
        Me.l_DatumZadania.Text = "Dátum zadania"
        '
        'l_OdovzdatDo
        '
        Me.l_OdovzdatDo.AutoSize = True
        Me.l_OdovzdatDo.Location = New System.Drawing.Point(40, 238)
        Me.l_OdovzdatDo.Name = "l_OdovzdatDo"
        Me.l_OdovzdatDo.Size = New System.Drawing.Size(72, 13)
        Me.l_OdovzdatDo.TabIndex = 13
        Me.l_OdovzdatDo.Text = "Spracovať do"
        '
        'dtp_OdovzdatDo
        '
        Me.dtp_OdovzdatDo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_OdovzdatDo.Location = New System.Drawing.Point(132, 232)
        Me.dtp_OdovzdatDo.Name = "dtp_OdovzdatDo"
        Me.dtp_OdovzdatDo.Size = New System.Drawing.Size(89, 20)
        Me.dtp_OdovzdatDo.TabIndex = 14
        '
        'cb_StavPrace
        '
        Me.cb_StavPrace.FormattingEnabled = True
        Me.cb_StavPrace.Location = New System.Drawing.Point(132, 286)
        Me.cb_StavPrace.Name = "cb_StavPrace"
        Me.cb_StavPrace.Size = New System.Drawing.Size(121, 21)
        Me.cb_StavPrace.TabIndex = 18
        '
        'l_SpravPrace
        '
        Me.l_SpravPrace.AutoSize = True
        Me.l_SpravPrace.Location = New System.Drawing.Point(53, 289)
        Me.l_SpravPrace.Name = "l_SpravPrace"
        Me.l_SpravPrace.Size = New System.Drawing.Size(59, 13)
        Me.l_SpravPrace.TabIndex = 17
        Me.l_SpravPrace.Text = "Stav práce"
        '
        'dtp_Spracovane
        '
        Me.dtp_Spracovane.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Spracovane.Location = New System.Drawing.Point(132, 257)
        Me.dtp_Spracovane.Name = "dtp_Spracovane"
        Me.dtp_Spracovane.Size = New System.Drawing.Size(89, 20)
        Me.dtp_Spracovane.TabIndex = 20
        '
        'l_Spracovane
        '
        Me.l_Spracovane.AutoSize = True
        Me.l_Spracovane.Location = New System.Drawing.Point(18, 262)
        Me.l_Spracovane.Name = "l_Spracovane"
        Me.l_Spracovane.Size = New System.Drawing.Size(94, 13)
        Me.l_Spracovane.TabIndex = 19
        Me.l_Spracovane.Text = "Práca spracovaná"
        '
        'b_Spracovane
        '
        Me.b_Spracovane.Location = New System.Drawing.Point(132, 257)
        Me.b_Spracovane.Name = "b_Spracovane"
        Me.b_Spracovane.Size = New System.Drawing.Size(75, 23)
        Me.b_Spracovane.TabIndex = 21
        Me.b_Spracovane.Text = "Pridať"
        Me.b_Spracovane.UseVisualStyleBackColor = True
        Me.b_Spracovane.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(11, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 359)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'ZadanePrace_sprava
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 376)
        Me.Controls.Add(Me.b_Spracovane)
        Me.Controls.Add(Me.dtp_Spracovane)
        Me.Controls.Add(Me.l_Spracovane)
        Me.Controls.Add(Me.cb_StavPrace)
        Me.Controls.Add(Me.l_SpravPrace)
        Me.Controls.Add(Me.dtp_OdovzdatDo)
        Me.Controls.Add(Me.l_OdovzdatDo)
        Me.Controls.Add(Me.l_PDatumZadania)
        Me.Controls.Add(Me.l_DatumZadania)
        Me.Controls.Add(Me.cb_DruhPrace)
        Me.Controls.Add(Me.l_DruhPrace)
        Me.Controls.Add(Me.tb_PopisPrace)
        Me.Controls.Add(Me.l_PopisPrace)
        Me.Controls.Add(Me.cb_Priradene)
        Me.Controls.Add(Me.l_Priradene)
        Me.Controls.Add(Me.l_PPracaCislo)
        Me.Controls.Add(Me.l_PracaCislo)
        Me.Controls.Add(Me.b_Ulozit)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ZadanePrace_sprava"
        Me.Text = "Zadané práce správa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents b_Ulozit As Button
    Friend WithEvents l_PracaCislo As Label
    Friend WithEvents l_PPracaCislo As Label
    Friend WithEvents l_Priradene As Label
    Friend WithEvents cb_Priradene As ComboBox
    Friend WithEvents tb_PopisPrace As TextBox
    Friend WithEvents l_PopisPrace As Label
    Friend WithEvents cb_DruhPrace As ComboBox
    Friend WithEvents l_DruhPrace As Label
    Friend WithEvents l_PDatumZadania As Label
    Friend WithEvents l_DatumZadania As Label
    Friend WithEvents l_OdovzdatDo As Label
    Friend WithEvents dtp_OdovzdatDo As DateTimePicker
    Friend WithEvents cb_StavPrace As ComboBox
    Friend WithEvents l_SpravPrace As Label
    Friend WithEvents dtp_Spracovane As DateTimePicker
    Friend WithEvents l_Spracovane As Label
    Friend WithEvents b_Spracovane As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
