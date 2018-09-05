<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mathquest1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optDno = New System.Windows.Forms.RadioButton()
        Me.optNo = New System.Windows.Forms.RadioButton()
        Me.optYes = New System.Windows.Forms.RadioButton()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optDno)
        Me.GroupBox1.Controls.Add(Me.optNo)
        Me.GroupBox1.Controls.Add(Me.optYes)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 168)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "submit 6x6"
        '
        'optDno
        '
        Me.optDno.AutoSize = True
        Me.optDno.Location = New System.Drawing.Point(25, 106)
        Me.optDno.Name = "optDno"
        Me.optDno.Size = New System.Drawing.Size(78, 17)
        Me.optDno.TabIndex = 2
        Me.optDno.TabStop = True
        Me.optDno.Text = "Dont Know"
        Me.optDno.UseVisualStyleBackColor = True
        '
        'optNo
        '
        Me.optNo.AutoSize = True
        Me.optNo.Location = New System.Drawing.Point(25, 69)
        Me.optNo.Name = "optNo"
        Me.optNo.Size = New System.Drawing.Size(37, 17)
        Me.optNo.TabIndex = 1
        Me.optNo.TabStop = True
        Me.optNo.Text = "76"
        Me.optNo.UseVisualStyleBackColor = True
        '
        'optYes
        '
        Me.optYes.AutoSize = True
        Me.optYes.Location = New System.Drawing.Point(25, 33)
        Me.optYes.Name = "optYes"
        Me.optYes.Size = New System.Drawing.Size(37, 17)
        Me.optYes.TabIndex = 0
        Me.optYes.TabStop = True
        Me.optYes.Text = "36"
        Me.optYes.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(147, 446)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(119, 23)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "Submit Answer"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Mathquest1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 507)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Mathquest1"
        Me.Text = "Question 1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optDno As RadioButton
    Friend WithEvents optNo As RadioButton
    Friend WithEvents optYes As RadioButton
    Friend WithEvents exitButton As Button

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click

        If optYes.Checked Then
            Score = Score + 1


        End If
        Me.Hide()
        scoreboard.Show()

    End Sub



End Class
