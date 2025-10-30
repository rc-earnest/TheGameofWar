<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WarGUIForm
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
        Me.StartGameButton = New System.Windows.Forms.Button()
        Me.EndRoundButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.P1CardsLabel = New System.Windows.Forms.Label()
        Me.P1CapLabel = New System.Windows.Forms.Label()
        Me.P2CardsLabel = New System.Windows.Forms.Label()
        Me.P2CapLabel = New System.Windows.Forms.Label()
        Me.RndWinLabel = New System.Windows.Forms.Label()
        Me.RndsPlayedLabel = New System.Windows.Forms.Label()
        Me.WarsPlayedLabel = New System.Windows.Forms.Label()
        Me.GameWinnerLabel = New System.Windows.Forms.Label()
        Me.P2Card5PictureBox = New System.Windows.Forms.PictureBox()
        Me.P1Card5PictureBox = New System.Windows.Forms.PictureBox()
        Me.P2Card4PictureBox = New System.Windows.Forms.PictureBox()
        Me.P2Card3PictureBox = New System.Windows.Forms.PictureBox()
        Me.P2Card2PictureBox = New System.Windows.Forms.PictureBox()
        Me.P2Card1PictureBox = New System.Windows.Forms.PictureBox()
        Me.P1Card4PictureBox = New System.Windows.Forms.PictureBox()
        Me.P1Card3PictureBox = New System.Windows.Forms.PictureBox()
        Me.P1Card2PictureBox = New System.Windows.Forms.PictureBox()
        Me.P1Card1PictureBox = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartRoundButton = New System.Windows.Forms.Button()
        CType(Me.P2Card5PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P1Card5PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P2Card4PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P2Card3PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P2Card2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P2Card1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P1Card4PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P1Card3PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P1Card2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P1Card1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartGameButton
        '
        Me.StartGameButton.Location = New System.Drawing.Point(16, 511)
        Me.StartGameButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.StartGameButton.Name = "StartGameButton"
        Me.StartGameButton.Size = New System.Drawing.Size(100, 28)
        Me.StartGameButton.TabIndex = 0
        Me.StartGameButton.Text = "&Start Game"
        Me.StartGameButton.UseVisualStyleBackColor = True
        '
        'EndRoundButton
        '
        Me.EndRoundButton.Location = New System.Drawing.Point(124, 511)
        Me.EndRoundButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EndRoundButton.Name = "EndRoundButton"
        Me.EndRoundButton.Size = New System.Drawing.Size(100, 28)
        Me.EndRoundButton.TabIndex = 1
        Me.EndRoundButton.Text = "&End Round"
        Me.EndRoundButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(951, 511)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(100, 28)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'P1CardsLabel
        '
        Me.P1CardsLabel.AutoSize = True
        Me.P1CardsLabel.Location = New System.Drawing.Point(67, 33)
        Me.P1CardsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P1CardsLabel.Name = "P1CardsLabel"
        Me.P1CardsLabel.Size = New System.Drawing.Size(95, 16)
        Me.P1CardsLabel.TabIndex = 3
        Me.P1CardsLabel.Text = "Player 1 Cards"
        '
        'P1CapLabel
        '
        Me.P1CapLabel.AutoSize = True
        Me.P1CapLabel.Location = New System.Drawing.Point(67, 49)
        Me.P1CapLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P1CapLabel.Name = "P1CapLabel"
        Me.P1CapLabel.Size = New System.Drawing.Size(153, 16)
        Me.P1CapLabel.TabIndex = 4
        Me.P1CapLabel.Text = "Player 1 Cards Captured"
        '
        'P2CardsLabel
        '
        Me.P2CardsLabel.AutoSize = True
        Me.P2CardsLabel.Location = New System.Drawing.Point(801, 30)
        Me.P2CardsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P2CardsLabel.Name = "P2CardsLabel"
        Me.P2CardsLabel.Size = New System.Drawing.Size(95, 16)
        Me.P2CardsLabel.TabIndex = 5
        Me.P2CardsLabel.Text = "Player 2 Cards"
        '
        'P2CapLabel
        '
        Me.P2CapLabel.AutoSize = True
        Me.P2CapLabel.Location = New System.Drawing.Point(801, 49)
        Me.P2CapLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P2CapLabel.Name = "P2CapLabel"
        Me.P2CapLabel.Size = New System.Drawing.Size(153, 16)
        Me.P2CapLabel.TabIndex = 6
        Me.P2CapLabel.Text = "Player 2 Cards Captured"
        '
        'RndWinLabel
        '
        Me.RndWinLabel.AutoSize = True
        Me.RndWinLabel.Location = New System.Drawing.Point(461, 74)
        Me.RndWinLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RndWinLabel.Name = "RndWinLabel"
        Me.RndWinLabel.Size = New System.Drawing.Size(92, 16)
        Me.RndWinLabel.TabIndex = 7
        Me.RndWinLabel.Text = "Round Winner"
        '
        'RndsPlayedLabel
        '
        Me.RndsPlayedLabel.AutoSize = True
        Me.RndsPlayedLabel.Location = New System.Drawing.Point(461, 90)
        Me.RndsPlayedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RndsPlayedLabel.Name = "RndsPlayedLabel"
        Me.RndsPlayedLabel.Size = New System.Drawing.Size(100, 16)
        Me.RndsPlayedLabel.TabIndex = 8
        Me.RndsPlayedLabel.Text = "Rounds Played"
        '
        'WarsPlayedLabel
        '
        Me.WarsPlayedLabel.AutoSize = True
        Me.WarsPlayedLabel.Location = New System.Drawing.Point(461, 106)
        Me.WarsPlayedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WarsPlayedLabel.Name = "WarsPlayedLabel"
        Me.WarsPlayedLabel.Size = New System.Drawing.Size(85, 16)
        Me.WarsPlayedLabel.TabIndex = 9
        Me.WarsPlayedLabel.Text = "Wars Played"
        '
        'GameWinnerLabel
        '
        Me.GameWinnerLabel.AutoSize = True
        Me.GameWinnerLabel.Location = New System.Drawing.Point(461, 33)
        Me.GameWinnerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GameWinnerLabel.Name = "GameWinnerLabel"
        Me.GameWinnerLabel.Size = New System.Drawing.Size(89, 16)
        Me.GameWinnerLabel.TabIndex = 10
        Me.GameWinnerLabel.Text = "Game Winner"
        '
        'P2Card5PictureBox
        '
        Me.P2Card5PictureBox.Location = New System.Drawing.Point(917, 186)
        Me.P2Card5PictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.P2Card5PictureBox.Name = "P2Card5PictureBox"
        Me.P2Card5PictureBox.Size = New System.Drawing.Size(133, 183)
        Me.P2Card5PictureBox.TabIndex = 20
        Me.P2Card5PictureBox.TabStop = False
        '
        'P1Card5PictureBox
        '
        Me.P1Card5PictureBox.Location = New System.Drawing.Point(16, 186)
        Me.P1Card5PictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.P1Card5PictureBox.Name = "P1Card5PictureBox"
        Me.P1Card5PictureBox.Size = New System.Drawing.Size(133, 183)
        Me.P1Card5PictureBox.TabIndex = 19
        Me.P1Card5PictureBox.TabStop = False
        '
        'P2Card4PictureBox
        '
        Me.P2Card4PictureBox.Location = New System.Drawing.Point(843, 186)
        Me.P2Card4PictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.P2Card4PictureBox.Name = "P2Card4PictureBox"
        Me.P2Card4PictureBox.Size = New System.Drawing.Size(133, 183)
        Me.P2Card4PictureBox.TabIndex = 18
        Me.P2Card4PictureBox.TabStop = False
        '
        'P2Card3PictureBox
        '
        Me.P2Card3PictureBox.Location = New System.Drawing.Point(776, 186)
        Me.P2Card3PictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.P2Card3PictureBox.Name = "P2Card3PictureBox"
        Me.P2Card3PictureBox.Size = New System.Drawing.Size(133, 183)
        Me.P2Card3PictureBox.TabIndex = 17
        Me.P2Card3PictureBox.TabStop = False
        '
        'P2Card2PictureBox
        '
        Me.P2Card2PictureBox.Location = New System.Drawing.Point(701, 186)
        Me.P2Card2PictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.P2Card2PictureBox.Name = "P2Card2PictureBox"
        Me.P2Card2PictureBox.Size = New System.Drawing.Size(133, 183)
        Me.P2Card2PictureBox.TabIndex = 16
        Me.P2Card2PictureBox.TabStop = False
        '
        'P2Card1PictureBox
        '
        Me.P2Card1PictureBox.Location = New System.Drawing.Point(635, 186)
        Me.P2Card1PictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.P2Card1PictureBox.Name = "P2Card1PictureBox"
        Me.P2Card1PictureBox.Size = New System.Drawing.Size(133, 183)
        Me.P2Card1PictureBox.TabIndex = 15
        Me.P2Card1PictureBox.TabStop = False
        '
        'P1Card4PictureBox
        '
        Me.P1Card4PictureBox.Location = New System.Drawing.Point(84, 186)
        Me.P1Card4PictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.P1Card4PictureBox.Name = "P1Card4PictureBox"
        Me.P1Card4PictureBox.Size = New System.Drawing.Size(133, 183)
        Me.P1Card4PictureBox.TabIndex = 14
        Me.P1Card4PictureBox.TabStop = False
        '
        'P1Card3PictureBox
        '
        Me.P1Card3PictureBox.Location = New System.Drawing.Point(157, 186)
        Me.P1Card3PictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.P1Card3PictureBox.Name = "P1Card3PictureBox"
        Me.P1Card3PictureBox.Size = New System.Drawing.Size(133, 183)
        Me.P1Card3PictureBox.TabIndex = 13
        Me.P1Card3PictureBox.TabStop = False
        '
        'P1Card2PictureBox
        '
        Me.P1Card2PictureBox.Location = New System.Drawing.Point(225, 186)
        Me.P1Card2PictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.P1Card2PictureBox.Name = "P1Card2PictureBox"
        Me.P1Card2PictureBox.Size = New System.Drawing.Size(133, 183)
        Me.P1Card2PictureBox.TabIndex = 12
        Me.P1Card2PictureBox.TabStop = False
        '
        'P1Card1PictureBox
        '
        Me.P1Card1PictureBox.Location = New System.Drawing.Point(299, 186)
        Me.P1Card1PictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.P1Card1PictureBox.Name = "P1Card1PictureBox"
        Me.P1Card1PictureBox.Size = New System.Drawing.Size(133, 183)
        Me.P1Card1PictureBox.TabIndex = 11
        Me.P1Card1PictureBox.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StartRoundButton
        '
        Me.StartRoundButton.Location = New System.Drawing.Point(474, 511)
        Me.StartRoundButton.Name = "StartRoundButton"
        Me.StartRoundButton.Size = New System.Drawing.Size(100, 28)
        Me.StartRoundButton.TabIndex = 2
        Me.StartRoundButton.Text = "Start &Round"
        Me.StartRoundButton.UseVisualStyleBackColor = True
        '
        'WarGUIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.StartRoundButton)
        Me.Controls.Add(Me.P2Card5PictureBox)
        Me.Controls.Add(Me.P1Card5PictureBox)
        Me.Controls.Add(Me.P2Card4PictureBox)
        Me.Controls.Add(Me.P2Card3PictureBox)
        Me.Controls.Add(Me.P2Card2PictureBox)
        Me.Controls.Add(Me.P2Card1PictureBox)
        Me.Controls.Add(Me.P1Card4PictureBox)
        Me.Controls.Add(Me.P1Card3PictureBox)
        Me.Controls.Add(Me.P1Card2PictureBox)
        Me.Controls.Add(Me.P1Card1PictureBox)
        Me.Controls.Add(Me.GameWinnerLabel)
        Me.Controls.Add(Me.WarsPlayedLabel)
        Me.Controls.Add(Me.RndsPlayedLabel)
        Me.Controls.Add(Me.RndWinLabel)
        Me.Controls.Add(Me.P2CapLabel)
        Me.Controls.Add(Me.P2CardsLabel)
        Me.Controls.Add(Me.P1CapLabel)
        Me.Controls.Add(Me.P1CardsLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.EndRoundButton)
        Me.Controls.Add(Me.StartGameButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "WarGUIForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.P2Card5PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P1Card5PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P2Card4PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P2Card3PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P2Card2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P2Card1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P1Card4PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P1Card3PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P1Card2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P1Card1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartGameButton As Button
    Friend WithEvents EndRoundButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents P1CardsLabel As Label
    Friend WithEvents P1CapLabel As Label
    Friend WithEvents P2CardsLabel As Label
    Friend WithEvents P2CapLabel As Label
    Friend WithEvents RndWinLabel As Label
    Friend WithEvents RndsPlayedLabel As Label
    Friend WithEvents WarsPlayedLabel As Label
    Friend WithEvents GameWinnerLabel As Label
    Friend WithEvents P1Card1PictureBox As PictureBox
    Friend WithEvents P1Card2PictureBox As PictureBox
    Friend WithEvents P1Card3PictureBox As PictureBox
    Friend WithEvents P1Card4PictureBox As PictureBox
    Friend WithEvents P2Card1PictureBox As PictureBox
    Friend WithEvents P2Card2PictureBox As PictureBox
    Friend WithEvents P2Card3PictureBox As PictureBox
    Friend WithEvents P2Card4PictureBox As PictureBox
    Friend WithEvents P1Card5PictureBox As PictureBox
    Friend WithEvents P2Card5PictureBox As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartRoundButton As Button
End Class
