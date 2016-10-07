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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.l_DatumOpravy = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.l_PopisOpravy = New System.Windows.Forms.Label()
        Me.l_DruhOpravy = New System.Windows.Forms.Label()
        Me.cb_DruhOpravy = New System.Windows.Forms.ComboBox()
        Me.gb_Servis.SuspendLayout()
        Me.SuspendLayout()
        '
        'b_Zapisat
        '
        Me.b_Zapisat.Location = New System.Drawing.Point(253, 246)
        Me.b_Zapisat.Name = "b_Zapisat"
        Me.b_Zapisat.Size = New System.Drawing.Size(75, 23)
        Me.b_Zapisat.TabIndex = 0
        Me.b_Zapisat.Text = "Zapísať"
        Me.b_Zapisat.UseVisualStyleBackColor = True
        '
        'gb_Servis
        '
        Me.gb_Servis.Controls.Add(Me.DateTimePicker1)
        Me.gb_Servis.Controls.Add(Me.l_DatumOpravy)
        Me.gb_Servis.Controls.Add(Me.TextBox1)
        Me.gb_Servis.Controls.Add(Me.l_PopisOpravy)
        Me.gb_Servis.Controls.Add(Me.l_DruhOpravy)
        Me.gb_Servis.Controls.Add(Me.cb_DruhOpravy)
        Me.gb_Servis.Location = New System.Drawing.Point(13, 13)
        Me.gb_Servis.Name = "gb_Servis"
        Me.gb_Servis.Size = New System.Drawing.Size(315, 227)
        Me.gb_Servis.TabIndex = 1
        Me.gb_Servis.TabStop = False
        Me.gb_Servis.Text = "Servis počítača"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(88, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'l_DatumOpravy
        '
        Me.l_DatumOpravy.AutoSize = True
        Me.l_DatumOpravy.Location = New System.Drawing.Point(6, 21)
        Me.l_DatumOpravy.Name = "l_DatumOpravy"
        Me.l_DatumOpravy.Size = New System.Drawing.Size(73, 13)
        Me.l_DatumOpravy.TabIndex = 4
        Me.l_DatumOpravy.Text = "Dátum opravy"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 72)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 149)
        Me.TextBox1.TabIndex = 3
        '
        'l_PopisOpravy
        '
        Me.l_PopisOpravy.AutoSize = True
        Me.l_PopisOpravy.Location = New System.Drawing.Point(6, 75)
        Me.l_PopisOpravy.Name = "l_PopisOpravy"
        Me.l_PopisOpravy.Size = New System.Drawing.Size(68, 13)
        Me.l_PopisOpravy.TabIndex = 2
        Me.l_PopisOpravy.Text = "Popis opravy"
        '
        'l_DruhOpravy
        '
        Me.l_DruhOpravy.AutoSize = True
        Me.l_DruhOpravy.Location = New System.Drawing.Point(6, 49)
        Me.l_DruhOpravy.Name = "l_DruhOpravy"
        Me.l_DruhOpravy.Size = New System.Drawing.Size(65, 13)
        Me.l_DruhOpravy.TabIndex = 1
        Me.l_DruhOpravy.Text = "Druh opravy"
        '
        'cb_DruhOpravy
        '
        Me.cb_DruhOpravy.FormattingEnabled = True
        Me.cb_DruhOpravy.Location = New System.Drawing.Point(88, 45)
        Me.cb_DruhOpravy.Name = "cb_DruhOpravy"
        Me.cb_DruhOpravy.Size = New System.Drawing.Size(200, 21)
        Me.cb_DruhOpravy.TabIndex = 0
        '
        'ZariadeniaServisVloz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 281)
        Me.Controls.Add(Me.gb_Servis)
        Me.Controls.Add(Me.b_Zapisat)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents l_DatumOpravy As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents l_PopisOpravy As Label
    Friend WithEvents l_DruhOpravy As Label
    Friend WithEvents cb_DruhOpravy As ComboBox
End Class
