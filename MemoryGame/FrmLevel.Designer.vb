<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLevel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLevel))
        Me.BtnEasy = New System.Windows.Forms.Button()
        Me.BtnMedium = New System.Windows.Forms.Button()
        Me.BtnHard = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblCredits = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnEasy
        '
        Me.BtnEasy.BackColor = System.Drawing.Color.Blue
        Me.BtnEasy.BackgroundImage = Global.MemoryGame.My.Resources.Resources.button_background
        Me.BtnEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnEasy.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEasy.ForeColor = System.Drawing.Color.White
        Me.BtnEasy.Location = New System.Drawing.Point(173, 244)
        Me.BtnEasy.Name = "BtnEasy"
        Me.BtnEasy.Size = New System.Drawing.Size(246, 58)
        Me.BtnEasy.TabIndex = 2
        Me.BtnEasy.Tag = "1"
        Me.BtnEasy.Text = "EASY"
        Me.BtnEasy.UseVisualStyleBackColor = False
        '
        'BtnMedium
        '
        Me.BtnMedium.BackColor = System.Drawing.Color.Blue
        Me.BtnMedium.BackgroundImage = Global.MemoryGame.My.Resources.Resources.button_background
        Me.BtnMedium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnMedium.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMedium.ForeColor = System.Drawing.Color.White
        Me.BtnMedium.Location = New System.Drawing.Point(173, 330)
        Me.BtnMedium.Name = "BtnMedium"
        Me.BtnMedium.Size = New System.Drawing.Size(246, 58)
        Me.BtnMedium.TabIndex = 3
        Me.BtnMedium.Tag = "2"
        Me.BtnMedium.Text = "MEDIUM"
        Me.BtnMedium.UseVisualStyleBackColor = False
        '
        'BtnHard
        '
        Me.BtnHard.BackColor = System.Drawing.Color.Blue
        Me.BtnHard.BackgroundImage = Global.MemoryGame.My.Resources.Resources.button_background
        Me.BtnHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnHard.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnHard.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHard.ForeColor = System.Drawing.Color.White
        Me.BtnHard.Location = New System.Drawing.Point(173, 420)
        Me.BtnHard.Name = "BtnHard"
        Me.BtnHard.Size = New System.Drawing.Size(246, 58)
        Me.BtnHard.TabIndex = 4
        Me.BtnHard.Tag = "3"
        Me.BtnHard.Text = "HARD"
        Me.BtnHard.UseVisualStyleBackColor = False
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.White
        Me.LblTitle.Location = New System.Drawing.Point(145, 49)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(285, 29)
        Me.LblTitle.TabIndex = 5
        Me.LblTitle.Text = "Football Memory Game"
        '
        'LblCredits
        '
        Me.LblCredits.AutoSize = True
        Me.LblCredits.BackColor = System.Drawing.Color.Transparent
        Me.LblCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCredits.ForeColor = System.Drawing.Color.White
        Me.LblCredits.Location = New System.Drawing.Point(216, 206)
        Me.LblCredits.Name = "LblCredits"
        Me.LblCredits.Size = New System.Drawing.Size(143, 24)
        Me.LblCredits.TabIndex = 6
        Me.LblCredits.Text = "Chose a level:"
        '
        'FrmLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MemoryGame.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(599, 646)
        Me.Controls.Add(Me.LblCredits)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.BtnHard)
        Me.Controls.Add(Me.BtnMedium)
        Me.Controls.Add(Me.BtnEasy)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(615, 685)
        Me.MinimumSize = New System.Drawing.Size(615, 685)
        Me.Name = "FrmLevel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Football Memory Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEasy As Button
    Friend WithEvents BtnMedium As Button
    Friend WithEvents BtnHard As Button
    Friend WithEvents LblTitle As Label
    Friend WithEvents LblCredits As Label
End Class
