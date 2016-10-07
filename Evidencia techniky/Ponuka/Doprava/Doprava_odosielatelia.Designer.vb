<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Doprava_odosielatelia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Doprava_odosielatelia))
        Me.b_VstupneData = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.b_Vytlacit = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ppd_DopravaOdosielatelia = New System.Windows.Forms.PrintPreviewDialog()
        Me.pd_DopravaOdosielatelia = New System.Drawing.Printing.PrintDocument()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.b_NacitatData = New System.Windows.Forms.Button()
        Me.l_Import = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'b_VstupneData
        '
        Me.b_VstupneData.Location = New System.Drawing.Point(13, 13)
        Me.b_VstupneData.Name = "b_VstupneData"
        Me.b_VstupneData.Size = New System.Drawing.Size(90, 23)
        Me.b_VstupneData.TabIndex = 0
        Me.b_VstupneData.Text = "Vstupné dáta"
        Me.b_VstupneData.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(154, 93)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.Visible = False
        '
        'b_Vytlacit
        '
        Me.b_Vytlacit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_Vytlacit.Enabled = False
        Me.b_Vytlacit.Location = New System.Drawing.Point(875, 497)
        Me.b_Vytlacit.Name = "b_Vytlacit"
        Me.b_Vytlacit.Size = New System.Drawing.Size(96, 23)
        Me.b_Vytlacit.TabIndex = 2
        Me.b_Vytlacit.Text = "Vytlačiť"
        Me.b_Vytlacit.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(14, 497)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(856, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'ppd_DopravaOdosielatelia
        '
        Me.ppd_DopravaOdosielatelia.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppd_DopravaOdosielatelia.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppd_DopravaOdosielatelia.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppd_DopravaOdosielatelia.Document = Me.pd_DopravaOdosielatelia
        Me.ppd_DopravaOdosielatelia.Enabled = True
        Me.ppd_DopravaOdosielatelia.Icon = CType(resources.GetObject("ppd_DopravaOdosielatelia.Icon"), System.Drawing.Icon)
        Me.ppd_DopravaOdosielatelia.Name = "ppd_DopravaOdosielatelia"
        Me.ppd_DopravaOdosielatelia.Visible = False
        '
        'pd_DopravaOdosielatelia
        '
        Me.pd_DopravaOdosielatelia.DocumentName = "Doprava podľa odosielatelov"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(13, 43)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.Size = New System.Drawing.Size(958, 448)
        Me.DataGridView2.TabIndex = 4
        '
        'b_NacitatData
        '
        Me.b_NacitatData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_NacitatData.Location = New System.Drawing.Point(875, 13)
        Me.b_NacitatData.Name = "b_NacitatData"
        Me.b_NacitatData.Size = New System.Drawing.Size(96, 23)
        Me.b_NacitatData.TabIndex = 5
        Me.b_NacitatData.Text = "Načítať dáta"
        Me.b_NacitatData.UseVisualStyleBackColor = True
        '
        'l_Import
        '
        Me.l_Import.AutoSize = True
        Me.l_Import.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_Import.ForeColor = System.Drawing.Color.Black
        Me.l_Import.Location = New System.Drawing.Point(109, 16)
        Me.l_Import.Name = "l_Import"
        Me.l_Import.Size = New System.Drawing.Size(63, 16)
        Me.l_Import.TabIndex = 6
        Me.l_Import.Text = "l_Import"
        '
        'Doprava_odosielatelia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 532)
        Me.Controls.Add(Me.l_Import)
        Me.Controls.Add(Me.b_NacitatData)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.b_Vytlacit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.b_VstupneData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Doprava_odosielatelia"
        Me.Text = "Prehľad najazdených KM podľa odosielateľov"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents b_VstupneData As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents b_Vytlacit As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ppd_DopravaOdosielatelia As PrintPreviewDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pd_DopravaOdosielatelia As Printing.PrintDocument
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents b_NacitatData As Button
    Friend WithEvents l_Import As Label
End Class
