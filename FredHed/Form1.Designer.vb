<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fredForm
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
        Me.components = New System.ComponentModel.Container()
        Me.fredBox = New System.Windows.Forms.TextBox()
        Me.fredContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.fredTimer = New System.Windows.Forms.Timer(Me.components)
        Me.fredLabel = New System.Windows.Forms.Label()
        Me.fredScoreLabel = New System.Windows.Forms.Label()
        Me.exitBut = New System.Windows.Forms.Button()
        Me.versionLabel = New System.Windows.Forms.Label()
        Me.lowScoreLabel = New System.Windows.Forms.Label()
        Me.bestScoreLabel = New System.Windows.Forms.Label()
        Me.fredSpellLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'fredBox
        '
        Me.fredBox.ContextMenuStrip = Me.fredContext
        Me.fredBox.Location = New System.Drawing.Point(116, 46)
        Me.fredBox.MaxLength = 4
        Me.fredBox.Name = "fredBox"
        Me.fredBox.Size = New System.Drawing.Size(100, 20)
        Me.fredBox.TabIndex = 0
        '
        'fredContext
        '
        Me.fredContext.Name = "fredContext"
        Me.fredContext.Size = New System.Drawing.Size(61, 4)
        '
        'fredTimer
        '
        '
        'fredLabel
        '
        Me.fredLabel.AutoSize = True
        Me.fredLabel.Location = New System.Drawing.Point(160, 80)
        Me.fredLabel.Name = "fredLabel"
        Me.fredLabel.Size = New System.Drawing.Size(13, 13)
        Me.fredLabel.TabIndex = 1
        Me.fredLabel.Text = "0"
        '
        'fredScoreLabel
        '
        Me.fredScoreLabel.AutoSize = True
        Me.fredScoreLabel.Location = New System.Drawing.Point(160, 14)
        Me.fredScoreLabel.Name = "fredScoreLabel"
        Me.fredScoreLabel.Size = New System.Drawing.Size(13, 13)
        Me.fredScoreLabel.TabIndex = 2
        Me.fredScoreLabel.Text = "0"
        '
        'exitBut
        '
        Me.exitBut.Location = New System.Drawing.Point(129, 107)
        Me.exitBut.Name = "exitBut"
        Me.exitBut.Size = New System.Drawing.Size(75, 23)
        Me.exitBut.TabIndex = 3
        Me.exitBut.Text = "Exit"
        Me.exitBut.UseVisualStyleBackColor = True
        '
        'versionLabel
        '
        Me.versionLabel.AutoSize = True
        Me.versionLabel.Location = New System.Drawing.Point(2, 139)
        Me.versionLabel.Name = "versionLabel"
        Me.versionLabel.Size = New System.Drawing.Size(35, 13)
        Me.versionLabel.TabIndex = 4
        Me.versionLabel.Text = "V1.12"
        '
        'lowScoreLabel
        '
        Me.lowScoreLabel.AutoSize = True
        Me.lowScoreLabel.Location = New System.Drawing.Point(12, 14)
        Me.lowScoreLabel.Name = "lowScoreLabel"
        Me.lowScoreLabel.Size = New System.Drawing.Size(93, 13)
        Me.lowScoreLabel.TabIndex = 5
        Me.lowScoreLabel.Text = "Your lowest Score"
        '
        'bestScoreLabel
        '
        Me.bestScoreLabel.AutoSize = True
        Me.bestScoreLabel.Location = New System.Drawing.Point(36, 46)
        Me.bestScoreLabel.Name = "bestScoreLabel"
        Me.bestScoreLabel.Size = New System.Drawing.Size(0, 13)
        Me.bestScoreLabel.TabIndex = 6
        '
        'fredSpellLabel
        '
        Me.fredSpellLabel.AutoSize = True
        Me.fredSpellLabel.Location = New System.Drawing.Point(125, 14)
        Me.fredSpellLabel.Name = "fredSpellLabel"
        Me.fredSpellLabel.Size = New System.Drawing.Size(79, 13)
        Me.fredSpellLabel.TabIndex = 7
        Me.fredSpellLabel.Text = "Learn To Spell!"
        Me.fredSpellLabel.Visible = False
        '
        'fredForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 152)
        Me.Controls.Add(Me.fredSpellLabel)
        Me.Controls.Add(Me.bestScoreLabel)
        Me.Controls.Add(Me.lowScoreLabel)
        Me.Controls.Add(Me.versionLabel)
        Me.Controls.Add(Me.exitBut)
        Me.Controls.Add(Me.fredScoreLabel)
        Me.Controls.Add(Me.fredLabel)
        Me.Controls.Add(Me.fredBox)
        Me.MaximumSize = New System.Drawing.Size(258, 191)
        Me.MinimumSize = New System.Drawing.Size(258, 191)
        Me.Name = "fredForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FredHed"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fredBox As TextBox
    Friend WithEvents fredTimer As Timer
    Friend WithEvents fredLabel As Label
    Friend WithEvents fredScoreLabel As Label
    Friend WithEvents exitBut As Button
    Friend WithEvents versionLabel As Label
    Friend WithEvents lowScoreLabel As Label
    Friend WithEvents bestScoreLabel As Label
    Friend WithEvents fredContext As ContextMenuStrip
    Friend WithEvents fredSpellLabel As Label
End Class
