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
        Me.components = New System.ComponentModel.Container()
        Me.StartRoundButton = New System.Windows.Forms.Button()
        Me.EndRoundButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.P1CardsLabel = New System.Windows.Forms.Label()
        Me.P1CapLabel = New System.Windows.Forms.Label()
        Me.P2CardsLabel = New System.Windows.Forms.Label()
        Me.P2CapLabel = New System.Windows.Forms.Label()
        Me.RndWinLabel = New System.Windows.Forms.Label()
        Me.RndsPlayedLabel = New System.Windows.Forms.Label()
        Me.WarsPlayedLabel = New System.Windows.Forms.Label()
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GameWinnerLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'StartRoundButton
        '
        Me.StartRoundButton.Location = New System.Drawing.Point(12, 415)
        Me.StartRoundButton.Name = "StartRoundButton"
        Me.StartRoundButton.Size = New System.Drawing.Size(75, 23)
        Me.StartRoundButton.TabIndex = 0
        Me.StartRoundButton.Text = "&Start Round"
        Me.StartRoundButton.UseVisualStyleBackColor = True
        '
        'EndRoundButton
        '
        Me.EndRoundButton.Location = New System.Drawing.Point(93, 415)
        Me.EndRoundButton.Name = "EndRoundButton"
        Me.EndRoundButton.Size = New System.Drawing.Size(75, 23)
        Me.EndRoundButton.TabIndex = 1
        Me.EndRoundButton.Text = "&End Round"
        Me.EndRoundButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(713, 415)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'P1CardsLabel
        '
        Me.P1CardsLabel.AutoSize = True
        Me.P1CardsLabel.Location = New System.Drawing.Point(50, 9)
        Me.P1CardsLabel.Name = "P1CardsLabel"
        Me.P1CardsLabel.Size = New System.Drawing.Size(75, 13)
        Me.P1CardsLabel.TabIndex = 3
        Me.P1CardsLabel.Text = "Player 1 Cards"
        '
        'P1CapLabel
        '
        Me.P1CapLabel.AutoSize = True
        Me.P1CapLabel.Location = New System.Drawing.Point(50, 22)
        Me.P1CapLabel.Name = "P1CapLabel"
        Me.P1CapLabel.Size = New System.Drawing.Size(121, 13)
        Me.P1CapLabel.TabIndex = 4
        Me.P1CapLabel.Text = "Player 1 Cards Captured"
        '
        'P2CardsLabel
        '
        Me.P2CardsLabel.AutoSize = True
        Me.P2CardsLabel.Location = New System.Drawing.Point(601, 9)
        Me.P2CardsLabel.Name = "P2CardsLabel"
        Me.P2CardsLabel.Size = New System.Drawing.Size(75, 13)
        Me.P2CardsLabel.TabIndex = 5
        Me.P2CardsLabel.Text = "Player 2 Cards"
        '
        'P2CapLabel
        '
        Me.P2CapLabel.AutoSize = True
        Me.P2CapLabel.Location = New System.Drawing.Point(601, 22)
        Me.P2CapLabel.Name = "P2CapLabel"
        Me.P2CapLabel.Size = New System.Drawing.Size(121, 13)
        Me.P2CapLabel.TabIndex = 6
        Me.P2CapLabel.Text = "Player 2 Cards Captured"
        '
        'RndWinLabel
        '
        Me.RndWinLabel.AutoSize = True
        Me.RndWinLabel.Location = New System.Drawing.Point(346, 60)
        Me.RndWinLabel.Name = "RndWinLabel"
        Me.RndWinLabel.Size = New System.Drawing.Size(76, 13)
        Me.RndWinLabel.TabIndex = 7
        Me.RndWinLabel.Text = "Round Winner"
        '
        'RndsPlayedLabel
        '
        Me.RndsPlayedLabel.AutoSize = True
        Me.RndsPlayedLabel.Location = New System.Drawing.Point(346, 73)
        Me.RndsPlayedLabel.Name = "RndsPlayedLabel"
        Me.RndsPlayedLabel.Size = New System.Drawing.Size(79, 13)
        Me.RndsPlayedLabel.TabIndex = 8
        Me.RndsPlayedLabel.Text = "Rounds Played"
        '
        'WarsPlayedLabel
        '
        Me.WarsPlayedLabel.AutoSize = True
        Me.WarsPlayedLabel.Location = New System.Drawing.Point(346, 86)
        Me.WarsPlayedLabel.Name = "WarsPlayedLabel"
        Me.WarsPlayedLabel.Size = New System.Drawing.Size(67, 13)
        Me.WarsPlayedLabel.TabIndex = 9
        Me.WarsPlayedLabel.Text = "Wars Played"
        '
        'GameTimer
        '
        Me.GameTimer.Interval = 2000
        '
        'GameWinnerLabel
        '
        Me.GameWinnerLabel.AutoSize = True
        Me.GameWinnerLabel.Location = New System.Drawing.Point(346, 9)
        Me.GameWinnerLabel.Name = "GameWinnerLabel"
        Me.GameWinnerLabel.Size = New System.Drawing.Size(72, 13)
        Me.GameWinnerLabel.TabIndex = 10
        Me.GameWinnerLabel.Text = "Game Winner"
        '
        'WarGUIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.Controls.Add(Me.StartRoundButton)
        Me.Name = "WarGUIForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartRoundButton As Button
    Friend WithEvents EndRoundButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents P1CardsLabel As Label
    Friend WithEvents P1CapLabel As Label
    Friend WithEvents P2CardsLabel As Label
    Friend WithEvents P2CapLabel As Label
    Friend WithEvents RndWinLabel As Label
    Friend WithEvents RndsPlayedLabel As Label
    Friend WithEvents WarsPlayedLabel As Label
    Friend WithEvents GameTimer As Timer
    Friend WithEvents GameWinnerLabel As Label
End Class
