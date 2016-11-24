<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZariadeniaServisVloz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ZariadeniaServisVloz))
        Me.b_Zapisat = New System.Windows.Forms.Button()
        Me.gb_Servis = New System.Windows.Forms.GroupBox()
        Me.tb_PopisChyby = New System.Windows.Forms.TextBox()
        Me.l_PopisChyby = New System.Windows.Forms.Label()
        Me.l_DruhOpravy = New System.Windows.Forms.Label()
        Me.cb_DruhOpravy = New System.Windows.Forms.ComboBox()
        Me.dtp_DatumVybavenia = New System.Windows.Forms.DateTimePicker()
        Me.l_DatumVybavenia = New System.Windows.Forms.Label()
        Me.gb_Servis.SuspendLayout()
        Me.SuspendLayout()
        '
        'b_Zapisat
        '
        Me.b_Zapisat.Location = New System.Drawing.Point(380, 384)
        Me.b_Zapisat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.b_Zapisat.Name = "b_Zapisat"
        Me.b_Zapisat.Size = New System.Drawing.Size(112, 35)
        Me.b_Zapisat.TabIndex = 0
        Me.b_Zapisat.Text = "Zapísať"
        Me.b_Zapisat.UseVisualStyleBackColor = True
        '
        'gb_Servis
        '
        Me.gb_Servis.Controls.Add(Me.dtp_DatumVybavenia)
        Me.gb_Servis.Controls.Add(Me.l_DatumVybavenia)
        Me.gb_Servis.Controls.Add(Me.tb_PopisChyby)
        Me.gb_Servis.Controls.Add(Me.l_PopisChyby)
        Me.gb_Servis.Controls.Add(Me.l_DruhOpravy)
        Me.gb_Servis.Controls.Add(Me.cb_DruhOpravy)
        Me.gb_Servis.Location = New System.Drawing.Point(20, 20)
        Me.gb_Servis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gb_Servis.Name = "gb_Servis"
        Me.gb_Servis.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gb_Servis.Size = New System.Drawing.Size(472, 354)
        Me.gb_Servis.TabIndex = 1
        Me.gb_Servis.TabStop = False
        Me.gb_Servis.Text = "Servis zariadenia"
        '
        'tb_PopisChyby
        '
        Me.tb_PopisChyby.Location = New System.Drawing.Point(120, 108)
        Me.tb_PopisChyby.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_PopisChyby.Multiline = True
        Me.tb_PopisChyby.Name = "tb_PopisChyby"
        Me.tb_PopisChyby.Size = New System.Drawing.Size(315, 227)
        Me.tb_PopisChyby.TabIndex = 3
        '
        'l_PopisChyby
        '
        Me.l_PopisChyby.AutoSize = True
        Me.l_PopisChyby.Location = New System.Drawing.Point(14, 112)
        Me.l_PopisChyby.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l_PopisChyby.Name = "l_PopisChyby"
        Me.l_PopisChyby.Size = New System.Drawing.Size(92, 20)
        Me.l_PopisChyby.TabIndex = 2
        Me.l_PopisChyby.Text = "Popis chyby"
        '
        'l_DruhOpravy
        '
        Me.l_DruhOpravy.AutoSize = True
        Me.l_DruhOpravy.Location = New System.Drawing.Point(14, 76)
        Me.l_DruhOpravy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l_DruhOpravy.Name = "l_DruhOpravy"
        Me.l_DruhOpravy.Size = New System.Drawing.Size(94, 20)
        Me.l_DruhOpravy.TabIndex = 1
        Me.l_DruhOpravy.Text = "Druh opravy"
        '
        'cb_DruhOpravy
        '
        Me.cb_DruhOpravy.FormattingEnabled = True
        Me.cb_DruhOpravy.Location = New System.Drawing.Point(171, 70)
        Me.cb_DruhOpravy.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cb_DruhOpravy.Name = "cb_DruhOpravy"
        Me.cb_DruhOpravy.Size = New System.Drawing.Size(264, 28)
        Me.cb_DruhOpravy.TabIndex = 0
        '
        'dtp_DatumVybavenia
        '
        Me.dtp_DatumVybavenia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_DatumVybavenia.Location = New System.Drawing.Point(171, 35)
        Me.dtp_DatumVybavenia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtp_DatumVybavenia.Name = "dtp_DatumVybavenia"
        Me.dtp_DatumVybavenia.Size = New System.Drawing.Size(264, 26)
        Me.dtp_DatumVybavenia.TabIndex = 7
        '
        'l_DatumVybavenia
        '
        Me.l_DatumVybavenia.AutoSize = True
        Me.l_DatumVybavenia.Location = New System.Drawing.Point(14, 38)
        Me.l_DatumVybavenia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l_DatumVybavenia.Name = "l_DatumVybavenia"
        Me.l_DatumVybavenia.Size = New System.Drawing.Size(130, 20)
        Me.l_DatumVybavenia.TabIndex = 6
        Me.l_DatumVybavenia.Text = "Dátum vybavenia"
        '
        'ZariadeniaServisVloz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 428)
        Me.Controls.Add(Me.gb_Servis)
        Me.Controls.Add(Me.b_Zapisat)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ZariadeniaServisVloz"
        Me.Text = "Servis zariadení"
        Me.gb_Servis.ResumeLayout(False)
        Me.gb_Servis.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents b_Zapisat As Button
    Friend WithEvents gb_Servis As GroupBox
    Friend WithEvents tb_PopisChyby As TextBox
    Friend WithEvents l_PopisChyby As Label
    Friend WithEvents l_DruhOpravy As Label
    Friend WithEvents cb_DruhOpravy As ComboBox
    Friend WithEvents dtp_DatumVybavenia As DateTimePicker
    Friend WithEvents l_DatumVybavenia As Label
End Class
