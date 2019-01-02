<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.compScoreDraw = New System.Windows.Forms.Label()
        Me.plrScoreDraw = New System.Windows.Forms.Label()
        Me.paddleComputer = New System.Windows.Forms.PictureBox()
        Me.gameBall = New System.Windows.Forms.PictureBox()
        Me.paddlePlayer = New System.Windows.Forms.PictureBox()
        CType(Me.paddleComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gameBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paddlePlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gameTimer
        '
        Me.gameTimer.Enabled = True
        Me.gameTimer.Interval = 20
        '
        'compScoreDraw
        '
        Me.compScoreDraw.AutoSize = True
        Me.compScoreDraw.Location = New System.Drawing.Point(207, 33)
        Me.compScoreDraw.Name = "compScoreDraw"
        Me.compScoreDraw.Size = New System.Drawing.Size(39, 13)
        Me.compScoreDraw.TabIndex = 0
        Me.compScoreDraw.Text = "Label1"
        '
        'plrScoreDraw
        '
        Me.plrScoreDraw.AutoSize = True
        Me.plrScoreDraw.Location = New System.Drawing.Point(397, 33)
        Me.plrScoreDraw.Name = "plrScoreDraw"
        Me.plrScoreDraw.Size = New System.Drawing.Size(39, 13)
        Me.plrScoreDraw.TabIndex = 1
        Me.plrScoreDraw.Text = "Label2"
        '
        'paddleComputer
        '
        Me.paddleComputer.BackColor = System.Drawing.SystemColors.Control
        Me.paddleComputer.Location = New System.Drawing.Point(33, 135)
        Me.paddleComputer.Name = "paddleComputer"
        Me.paddleComputer.Size = New System.Drawing.Size(16, 128)
        Me.paddleComputer.TabIndex = 2
        Me.paddleComputer.TabStop = False
        '
        'gameBall
        '
        Me.gameBall.BackColor = System.Drawing.SystemColors.Control
        Me.gameBall.Image = Global.ForFun2.My.Resources.Resources.baller
        Me.gameBall.Location = New System.Drawing.Point(364, 215)
        Me.gameBall.Name = "gameBall"
        Me.gameBall.Size = New System.Drawing.Size(20, 20)
        Me.gameBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gameBall.TabIndex = 3
        Me.gameBall.TabStop = False
        '
        'paddlePlayer
        '
        Me.paddlePlayer.BackColor = System.Drawing.SystemColors.Control
        Me.paddlePlayer.Location = New System.Drawing.Point(649, 135)
        Me.paddlePlayer.Name = "paddlePlayer"
        Me.paddlePlayer.Size = New System.Drawing.Size(16, 128)
        Me.paddlePlayer.TabIndex = 4
        Me.paddlePlayer.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(722, 389)
        Me.Controls.Add(Me.paddlePlayer)
        Me.Controls.Add(Me.gameBall)
        Me.Controls.Add(Me.paddleComputer)
        Me.Controls.Add(Me.plrScoreDraw)
        Me.Controls.Add(Me.compScoreDraw)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.paddleComputer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gameBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paddlePlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gameTimer As System.Windows.Forms.Timer
    Friend WithEvents compScoreDraw As System.Windows.Forms.Label
    Friend WithEvents plrScoreDraw As System.Windows.Forms.Label
    Friend WithEvents paddleComputer As System.Windows.Forms.PictureBox
    Friend WithEvents gameBall As System.Windows.Forms.PictureBox
    Friend WithEvents paddlePlayer As System.Windows.Forms.PictureBox

End Class
