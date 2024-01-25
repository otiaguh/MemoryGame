<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMemoryGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMemoryGame))
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.LblCredits = New System.Windows.Forms.Label()
        Me.BtnLeaderboard = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.White
        Me.LblTitle.Location = New System.Drawing.Point(154, 46)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(285, 29)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Football Memory Game"
        '
        'BtnStart
        '
        Me.BtnStart.BackColor = System.Drawing.Color.Blue
        Me.BtnStart.BackgroundImage = Global.MemoryGame.My.Resources.Resources.button_background
        Me.BtnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.ForeColor = System.Drawing.Color.White
        Me.BtnStart.Location = New System.Drawing.Point(173, 203)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(246, 58)
        Me.BtnStart.TabIndex = 1
        Me.BtnStart.Text = "START"
        Me.BtnStart.UseVisualStyleBackColor = False
        '
        'LblCredits
        '
        Me.LblCredits.AutoSize = True
        Me.LblCredits.BackColor = System.Drawing.Color.Transparent
        Me.LblCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCredits.ForeColor = System.Drawing.Color.White
        Me.LblCredits.Location = New System.Drawing.Point(206, 77)
        Me.LblCredits.Name = "LblCredits"
        Me.LblCredits.Size = New System.Drawing.Size(181, 13)
        Me.LblCredits.TabIndex = 2
        Me.LblCredits.Text = "by Tiago Silva and Afonso Agostinho"
        '
        'BtnLeaderboard
        '
        Me.BtnLeaderboard.BackColor = System.Drawing.Color.Blue
        Me.BtnLeaderboard.BackgroundImage = Global.MemoryGame.My.Resources.Resources.button_background
        Me.BtnLeaderboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnLeaderboard.Cursor = System.Windows.Forms.Cursors.No
        Me.BtnLeaderboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLeaderboard.ForeColor = System.Drawing.Color.White
        Me.BtnLeaderboard.Location = New System.Drawing.Point(173, 293)
        Me.BtnLeaderboard.Name = "BtnLeaderboard"
        Me.BtnLeaderboard.Size = New System.Drawing.Size(246, 58)
        Me.BtnLeaderboard.TabIndex = 3
        Me.BtnLeaderboard.Text = "LEADERBOARD"
        Me.BtnLeaderboard.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Blue
        Me.BtnExit.BackgroundImage = Global.MemoryGame.My.Resources.Resources.button_background
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Location = New System.Drawing.Point(173, 385)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(246, 58)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'FrmMemoryGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MemoryGame.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(599, 646)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnLeaderboard)
        Me.Controls.Add(Me.LblCredits)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.LblTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(615, 685)
        Me.MinimumSize = New System.Drawing.Size(615, 685)
        Me.Name = "FrmMemoryGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Football Memory Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnStart As Button
    Friend WithEvents LblCredits As Label
    Friend WithEvents BtnLeaderboard As Button
    Friend WithEvents BtnExit As Button
End Class
