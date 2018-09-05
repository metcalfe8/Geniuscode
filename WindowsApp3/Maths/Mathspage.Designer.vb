<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mathspage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mathspage))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelMaths = New System.Windows.Forms.Label()
        Me.quest1button = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Main Menu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LabelMaths
        '
        Me.LabelMaths.AutoSize = True
        Me.LabelMaths.BackColor = System.Drawing.Color.Transparent
        Me.LabelMaths.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMaths.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelMaths.Location = New System.Drawing.Point(1, 26)
        Me.LabelMaths.Name = "LabelMaths"
        Me.LabelMaths.Size = New System.Drawing.Size(275, 45)
        Me.LabelMaths.TabIndex = 1
        Me.LabelMaths.Text = "MATHEMATICS"
        '
        'quest1button
        '
        Me.quest1button.BackColor = System.Drawing.Color.White
        Me.quest1button.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quest1button.Location = New System.Drawing.Point(91, 210)
        Me.quest1button.Name = "quest1button"
        Me.quest1button.Size = New System.Drawing.Size(94, 54)
        Me.quest1button.TabIndex = 2
        Me.quest1button.Text = "Hard"
        Me.quest1button.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(91, 92)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 50)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Easy"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(91, 148)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 56)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Medium"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Mathspage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(278, 507)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.quest1button)
        Me.Controls.Add(Me.LabelMaths)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Mathspage"
        Me.Text = "GENIUS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents LabelMaths As Label
    Friend WithEvents quest1button As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
