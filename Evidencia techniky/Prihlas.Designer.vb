<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prihlasenie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prihlasenie))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btPrihlasit = New System.Windows.Forms.Button()
        Me.tb_Meno = New System.Windows.Forms.TextBox()
        Me.tb_Heslo = New System.Windows.Forms.TextBox()
        Me.ZabHeslo = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pata_text = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Meno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(219, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Heslo"
        '
        'btPrihlasit
        '
        Me.btPrihlasit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btPrihlasit.Location = New System.Drawing.Point(287, 128)
        Me.btPrihlasit.Name = "btPrihlasit"
        Me.btPrihlasit.Size = New System.Drawing.Size(120, 35)
        Me.btPrihlasit.TabIndex = 3
        Me.btPrihlasit.Text = "Prihlásiť"
        Me.btPrihlasit.UseVisualStyleBackColor = True
        '
        'tb_Meno
        '
        Me.tb_Meno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_Meno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb_Meno.Location = New System.Drawing.Point(287, 24)
        Me.tb_Meno.Name = "tb_Meno"
        Me.tb_Meno.Size = New System.Drawing.Size(120, 30)
        Me.tb_Meno.TabIndex = 1
        '
        'tb_Heslo
        '
        Me.tb_Heslo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb_Heslo.Location = New System.Drawing.Point(287, 77)
        Me.tb_Heslo.Name = "tb_Heslo"
        Me.tb_Heslo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_Heslo.Size = New System.Drawing.Size(120, 30)
        Me.tb_Heslo.TabIndex = 2
        Me.tb_Heslo.UseSystemPasswordChar = True
        '
        'ZabHeslo
        '
        Me.ZabHeslo.AutoSize = True
        Me.ZabHeslo.Location = New System.Drawing.Point(299, 182)
        Me.ZabHeslo.Name = "ZabHeslo"
        Me.ZabHeslo.Size = New System.Drawing.Size(96, 13)
        Me.ZabHeslo.TabIndex = 4
        Me.ZabHeslo.TabStop = True
        Me.ZabHeslo.Text = "Zabudol som heslo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Evidencia_techniky.My.Resources.Resources.NsP_logo_3D_copy
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 187)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pata_text})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 207)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(423, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'pata_text
        '
        Me.pata_text.Name = "pata_text"
        Me.pata_text.Size = New System.Drawing.Size(0, 17)
        '
        'Prihlasenie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 229)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ZabHeslo)
        Me.Controls.Add(Me.tb_Heslo)
        Me.Controls.Add(Me.tb_Meno)
        Me.Controls.Add(Me.btPrihlasit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Prihlasenie"
        Me.Text = "ETECH - Prihlásenie"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btPrihlasit As System.Windows.Forms.Button
    Friend WithEvents tb_Meno As System.Windows.Forms.TextBox
    Friend WithEvents tb_Heslo As System.Windows.Forms.TextBox
    Friend WithEvents ZabHeslo As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents pata_text As System.Windows.Forms.ToolStripStatusLabel

End Class
