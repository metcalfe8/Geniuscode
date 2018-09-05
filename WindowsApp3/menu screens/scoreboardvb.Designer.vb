<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scoreboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scoreboard))
        Me.Lblscore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lblscore
        '
        Me.Lblscore.AutoSize = True
        Me.Lblscore.BackColor = System.Drawing.Color.Transparent
        Me.Lblscore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblscore.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lblscore.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblscore.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Lblscore.Location = New System.Drawing.Point(0, 0)
        Me.Lblscore.Name = "Lblscore"
        Me.Lblscore.Size = New System.Drawing.Size(60, 20)
        Me.Lblscore.TabIndex = 0
        Me.Lblscore.Text = "Retults"
        '
        'scoreboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(278, 507)
        Me.Controls.Add(Me.Lblscore)
        Me.Name = "scoreboard"
        Me.Text = "SCORE BOARD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lblscore As Label
End Class
