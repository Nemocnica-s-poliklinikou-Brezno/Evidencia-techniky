<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Spracovanie_dat
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
        Me.l_SpracovanieDat = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'l_SpracovanieDat
        '
        Me.l_SpracovanieDat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_SpracovanieDat.AutoSize = True
        Me.l_SpracovanieDat.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.l_SpracovanieDat.Location = New System.Drawing.Point(12, 9)
        Me.l_SpracovanieDat.Name = "l_SpracovanieDat"
        Me.l_SpracovanieDat.Size = New System.Drawing.Size(366, 39)
        Me.l_SpracovanieDat.TabIndex = 0
        Me.l_SpracovanieDat.Text = "Spracuvávam dáta ..."
        '
        'Spracovanie_dat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 61)
        Me.ControlBox = False
        Me.Controls.Add(Me.l_SpracovanieDat)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Spracovanie_dat"
        Me.Text = "ETECH - Spracovanie dát"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents l_SpracovanieDat As Label
End Class
