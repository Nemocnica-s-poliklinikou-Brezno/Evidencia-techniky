<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zoznam_zadanych_prac
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Zoznam_zadanych_prac))
        Me.tp_ZadanePrace = New System.Windows.Forms.TabPage()
        Me.dgv_ZadanePrace = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tp_UkoncenePrace = New System.Windows.Forms.TabPage()
        Me.dgv_UkoncenePrace = New System.Windows.Forms.DataGridView()
        Me.b_NacitatUdaje = New System.Windows.Forms.Button()
        Me.tp_ZadanePrace.SuspendLayout()
        CType(Me.dgv_ZadanePrace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tp_UkoncenePrace.SuspendLayout()
        CType(Me.dgv_UkoncenePrace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tp_ZadanePrace
        '
        Me.tp_ZadanePrace.Controls.Add(Me.dgv_ZadanePrace)
        Me.tp_ZadanePrace.Location = New System.Drawing.Point(4, 22)
        Me.tp_ZadanePrace.Name = "tp_ZadanePrace"
        Me.tp_ZadanePrace.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_ZadanePrace.Size = New System.Drawing.Size(1004, 273)
        Me.tp_ZadanePrace.TabIndex = 0
        Me.tp_ZadanePrace.Text = "Zadané práce"
        Me.tp_ZadanePrace.UseVisualStyleBackColor = True
        '
        'dgv_ZadanePrace
        '
        Me.dgv_ZadanePrace.AllowUserToAddRows = False
        Me.dgv_ZadanePrace.AllowUserToDeleteRows = False
        Me.dgv_ZadanePrace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_ZadanePrace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ZadanePrace.Location = New System.Drawing.Point(3, 3)
        Me.dgv_ZadanePrace.Name = "dgv_ZadanePrace"
        Me.dgv_ZadanePrace.ReadOnly = True
        Me.dgv_ZadanePrace.Size = New System.Drawing.Size(998, 267)
        Me.dgv_ZadanePrace.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tp_ZadanePrace)
        Me.TabControl1.Controls.Add(Me.tp_UkoncenePrace)
        Me.TabControl1.Location = New System.Drawing.Point(12, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1012, 299)
        Me.TabControl1.TabIndex = 0
        '
        'tp_UkoncenePrace
        '
        Me.tp_UkoncenePrace.Controls.Add(Me.dgv_UkoncenePrace)
        Me.tp_UkoncenePrace.Location = New System.Drawing.Point(4, 22)
        Me.tp_UkoncenePrace.Name = "tp_UkoncenePrace"
        Me.tp_UkoncenePrace.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_UkoncenePrace.Size = New System.Drawing.Size(1004, 273)
        Me.tp_UkoncenePrace.TabIndex = 1
        Me.tp_UkoncenePrace.Text = "Ukončené práce"
        Me.tp_UkoncenePrace.UseVisualStyleBackColor = True
        '
        'dgv_UkoncenePrace
        '
        Me.dgv_UkoncenePrace.AllowUserToAddRows = False
        Me.dgv_UkoncenePrace.AllowUserToDeleteRows = False
        Me.dgv_UkoncenePrace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_UkoncenePrace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_UkoncenePrace.Location = New System.Drawing.Point(3, 3)
        Me.dgv_UkoncenePrace.Name = "dgv_UkoncenePrace"
        Me.dgv_UkoncenePrace.ReadOnly = True
        Me.dgv_UkoncenePrace.Size = New System.Drawing.Size(998, 267)
        Me.dgv_UkoncenePrace.TabIndex = 1
        '
        'b_NacitatUdaje
        '
        Me.b_NacitatUdaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_NacitatUdaje.Location = New System.Drawing.Point(931, 319)
        Me.b_NacitatUdaje.Name = "b_NacitatUdaje"
        Me.b_NacitatUdaje.Size = New System.Drawing.Size(86, 23)
        Me.b_NacitatUdaje.TabIndex = 1
        Me.b_NacitatUdaje.Text = "Načítať údaje"
        Me.b_NacitatUdaje.UseVisualStyleBackColor = True
        '
        'Zoznam_zadanych_prac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 354)
        Me.Controls.Add(Me.b_NacitatUdaje)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Zoznam_zadanych_prac"
        Me.Text = "Zadané práce"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tp_ZadanePrace.ResumeLayout(False)
        CType(Me.dgv_ZadanePrace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tp_UkoncenePrace.ResumeLayout(False)
        CType(Me.dgv_UkoncenePrace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tp_ZadanePrace As TabPage
    Friend WithEvents dgv_ZadanePrace As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents b_NacitatUdaje As Button
    Friend WithEvents tp_UkoncenePrace As TabPage
    Friend WithEvents dgv_UkoncenePrace As DataGridView
End Class
