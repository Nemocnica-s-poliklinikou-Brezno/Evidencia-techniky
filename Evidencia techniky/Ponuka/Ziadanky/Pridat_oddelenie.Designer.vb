<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pridat_oddelenie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pridat_oddelenie))
        Me.cb_Oddelenia = New System.Windows.Forms.ComboBox()
        Me.b_Pridat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cb_Oddelenia
        '
        Me.cb_Oddelenia.FormattingEnabled = True
        Me.cb_Oddelenia.Location = New System.Drawing.Point(107, 6)
        Me.cb_Oddelenia.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_Oddelenia.Name = "cb_Oddelenia"
        Me.cb_Oddelenia.Size = New System.Drawing.Size(243, 21)
        Me.cb_Oddelenia.TabIndex = 0
        '
        'b_Pridat
        '
        Me.b_Pridat.Location = New System.Drawing.Point(354, 6)
        Me.b_Pridat.Margin = New System.Windows.Forms.Padding(2)
        Me.b_Pridat.Name = "b_Pridat"
        Me.b_Pridat.Size = New System.Drawing.Size(63, 21)
        Me.b_Pridat.TabIndex = 1
        Me.b_Pridat.Text = "Pridať"
        Me.b_Pridat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Názov oddelenia:"
        '
        'Pridat_oddelenie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 37)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.b_Pridat)
        Me.Controls.Add(Me.cb_Oddelenia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Pridat_oddelenie"
        Me.Text = "Pridať oddelenie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_Oddelenia As ComboBox
    Friend WithEvents b_Pridat As Button
    Friend WithEvents Label1 As Label
End Class
