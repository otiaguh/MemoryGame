<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFinal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFinal))
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblResult = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.BtnRestart = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LblCredits = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.White
        Me.LblTitle.Location = New System.Drawing.Point(170, 36)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(285, 29)
        Me.LblTitle.TabIndex = 21
        Me.LblTitle.Text = "Football Memory Game"
        '
        'LblResult
        '
        Me.LblResult.AutoSize = True
        Me.LblResult.BackColor = System.Drawing.Color.Transparent
        Me.LblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResult.ForeColor = System.Drawing.Color.White
        Me.LblResult.Location = New System.Drawing.Point(240, 115)
        Me.LblResult.Name = "LblResult"
        Me.LblResult.Size = New System.Drawing.Size(144, 29)
        Me.LblResult.TabIndex = 22
        Me.LblResult.Text = "YOU WON!"
        Me.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.BackColor = System.Drawing.Color.Transparent
        Me.LblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.ForeColor = System.Drawing.Color.White
        Me.LblTime.Location = New System.Drawing.Point(249, 157)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(127, 20)
        Me.LblTime.TabIndex = 23
        Me.LblTime.Text = "In: 60 seconds"
        Me.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnRestart
        '
        Me.BtnRestart.BackColor = System.Drawing.Color.Blue
        Me.BtnRestart.BackgroundImage = Global.MemoryGame.My.Resources.Resources.button_background
        Me.BtnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestart.ForeColor = System.Drawing.Color.White
        Me.BtnRestart.Location = New System.Drawing.Point(175, 278)
        Me.BtnRestart.Name = "BtnRestart"
        Me.BtnRestart.Size = New System.Drawing.Size(246, 58)
        Me.BtnRestart.TabIndex = 24
        Me.BtnRestart.Text = "RESTART"
        Me.BtnRestart.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Blue
        Me.BtnExit.BackgroundImage = Global.MemoryGame.My.Resources.Resources.button_background
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Location = New System.Drawing.Point(175, 360)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(246, 58)
        Me.BtnExit.TabIndex = 25
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'LblCredits
        '
        Me.LblCredits.AutoSize = True
        Me.LblCredits.BackColor = System.Drawing.Color.Transparent
        Me.LblCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCredits.ForeColor = System.Drawing.Color.White
        Me.LblCredits.Location = New System.Drawing.Point(198, 618)
        Me.LblCredits.Name = "LblCredits"
        Me.LblCredits.Size = New System.Drawing.Size(181, 13)
        Me.LblCredits.TabIndex = 26
        Me.LblCredits.Text = "by Tiago Silva and Afonso Agostinho"
        '
        'FrmFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MemoryGame.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(599, 646)
        Me.Controls.Add(Me.LblCredits)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnRestart)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.LblResult)
        Me.Controls.Add(Me.LblTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(615, 685)
        Me.MinimumSize = New System.Drawing.Size(615, 685)
        Me.Name = "FrmFinal"
        Me.Text = "Football Memory Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LblResult As Label
    Friend WithEvents LblTime As Label
    Friend WithEvents BtnRestart As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents LblCredits As Label
End Class
