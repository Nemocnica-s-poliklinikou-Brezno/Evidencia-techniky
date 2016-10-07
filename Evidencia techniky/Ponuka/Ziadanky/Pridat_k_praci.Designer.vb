<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pridat_k_praci
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pridat_k_praci))
        Me.cb_Prace = New System.Windows.Forms.ComboBox()
        Me.cb_Uzivatelia = New System.Windows.Forms.ComboBox()
        Me.l_Praca = New System.Windows.Forms.Label()
        Me.l_Uzivatel = New System.Windows.Forms.Label()
        Me.b_Priradit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cb_Prace
        '
        Me.cb_Prace.FormattingEnabled = True
        Me.cb_Prace.Location = New System.Drawing.Point(57, 5)
        Me.cb_Prace.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_Prace.Name = "cb_Prace"
        Me.cb_Prace.Size = New System.Drawing.Size(186, 21)
        Me.cb_Prace.TabIndex = 0
        '
        'cb_Uzivatelia
        '
        Me.cb_Uzivatelia.FormattingEnabled = True
        Me.cb_Uzivatelia.Location = New System.Drawing.Point(57, 27)
        Me.cb_Uzivatelia.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_Uzivatelia.Name = "cb_Uzivatelia"
        Me.cb_Uzivatelia.Size = New System.Drawing.Size(186, 21)
        Me.cb_Uzivatelia.TabIndex = 1
        '
        'l_Praca
        '
        Me.l_Praca.AutoSize = True
        Me.l_Praca.Location = New System.Drawing.Point(19, 6)
        Me.l_Praca.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l_Praca.Name = "l_Praca"
        Me.l_Praca.Size = New System.Drawing.Size(35, 13)
        Me.l_Praca.TabIndex = 2
        Me.l_Praca.Text = "Práca"
        '
        'l_Uzivatel
        '
        Me.l_Uzivatel.AutoSize = True
        Me.l_Uzivatel.Location = New System.Drawing.Point(8, 29)
        Me.l_Uzivatel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l_Uzivatel.Name = "l_Uzivatel"
        Me.l_Uzivatel.Size = New System.Drawing.Size(49, 13)
        Me.l_Uzivatel.TabIndex = 3
        Me.l_Uzivatel.Text = "Užívateľ"
        '
        'b_Priradit
        '
        Me.b_Priradit.Location = New System.Drawing.Point(247, 27)
        Me.b_Priradit.Margin = New System.Windows.Forms.Padding(2)
        Me.b_Priradit.Name = "b_Priradit"
        Me.b_Priradit.Size = New System.Drawing.Size(50, 21)
        Me.b_Priradit.TabIndex = 4
        Me.b_Priradit.Text = "Priradiť"
        Me.b_Priradit.UseVisualStyleBackColor = True
        '
        'Pridat_k_praci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 56)
        Me.Controls.Add(Me.b_Priradit)
        Me.Controls.Add(Me.l_Uzivatel)
        Me.Controls.Add(Me.l_Praca)
        Me.Controls.Add(Me.cb_Uzivatelia)
        Me.Controls.Add(Me.cb_Prace)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Pridat_k_praci"
        Me.Text = "Pridať užívateľa k práci"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_Prace As ComboBox
    Friend WithEvents cb_Uzivatelia As ComboBox
    Friend WithEvents l_Praca As Label
    Friend WithEvents l_Uzivatel As Label
    Friend WithEvents b_Priradit As Button
End Class
