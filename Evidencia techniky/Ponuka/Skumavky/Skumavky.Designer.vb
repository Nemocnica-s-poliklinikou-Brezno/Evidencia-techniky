<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Skumavky
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Skumavky))
        Me.b_VstupneData = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ll_PridatLekaraVykon = New System.Windows.Forms.LinkLabel()
        Me.b_Vytlacit = New System.Windows.Forms.Button()
        Me.ppd_Skumavky = New System.Windows.Forms.PrintPreviewDialog()
        Me.pd_Skumavky = New System.Drawing.Printing.PrintDocument()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'b_VstupneData
        '
        Me.b_VstupneData.Location = New System.Drawing.Point(12, 12)
        Me.b_VstupneData.Name = "b_VstupneData"
        Me.b_VstupneData.Size = New System.Drawing.Size(94, 23)
        Me.b_VstupneData.TabIndex = 3
        Me.b_VstupneData.Text = "Vstupné dáta"
        Me.b_VstupneData.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 513)
        Me.ProgressBar1.Maximum = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(534, 23)
        Me.ProgressBar1.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(657, 456)
        Me.DataGridView1.TabIndex = 7
        '
        'll_PridatLekaraVykon
        '
        Me.ll_PridatLekaraVykon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ll_PridatLekaraVykon.AutoSize = True
        Me.ll_PridatLekaraVykon.Location = New System.Drawing.Point(635, 9)
        Me.ll_PridatLekaraVykon.Name = "ll_PridatLekaraVykon"
        Me.ll_PridatLekaraVykon.Size = New System.Drawing.Size(35, 13)
        Me.ll_PridatLekaraVykon.TabIndex = 8
        Me.ll_PridatLekaraVykon.TabStop = True
        Me.ll_PridatLekaraVykon.Text = "Pridať"
        Me.ll_PridatLekaraVykon.Visible = False
        '
        'b_Vytlacit
        '
        Me.b_Vytlacit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_Vytlacit.Enabled = False
        Me.b_Vytlacit.Location = New System.Drawing.Point(561, 513)
        Me.b_Vytlacit.Name = "b_Vytlacit"
        Me.b_Vytlacit.Size = New System.Drawing.Size(109, 23)
        Me.b_Vytlacit.TabIndex = 5
        Me.b_Vytlacit.Text = "Vytlačiť"
        Me.b_Vytlacit.UseVisualStyleBackColor = True
        '
        'ppd_Skumavky
        '
        Me.ppd_Skumavky.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppd_Skumavky.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppd_Skumavky.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppd_Skumavky.Document = Me.pd_Skumavky
        Me.ppd_Skumavky.Enabled = True
        Me.ppd_Skumavky.Icon = CType(resources.GetObject("ppd_Skumavky.Icon"), System.Drawing.Icon)
        Me.ppd_Skumavky.Name = "ppd_Skumavky"
        Me.ppd_Skumavky.Visible = False
        '
        'pd_Skumavky
        '
        Me.pd_Skumavky.DocumentName = "Prehľad skúmaviek"
        '
        'Skumavky
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 542)
        Me.Controls.Add(Me.b_Vytlacit)
        Me.Controls.Add(Me.ll_PridatLekaraVykon)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.b_VstupneData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Skumavky"
        Me.Text = "Skúmavky"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b_VstupneData As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ll_PridatLekaraVykon As LinkLabel
    Friend WithEvents b_Vytlacit As Button
    Friend WithEvents ppd_Skumavky As PrintPreviewDialog
    Friend WithEvents pd_Skumavky As Printing.PrintDocument
End Class
