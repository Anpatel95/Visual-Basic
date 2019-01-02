<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lblBLB
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
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Ball = New System.Windows.Forms.PictureBox()
        Me.Paddle = New System.Windows.Forms.PictureBox()
        Me.Block8 = New System.Windows.Forms.PictureBox()
        Me.Block7 = New System.Windows.Forms.PictureBox()
        Me.Block6 = New System.Windows.Forms.PictureBox()
        Me.Block4 = New System.Windows.Forms.PictureBox()
        Me.Block3 = New System.Windows.Forms.PictureBox()
        Me.Block2 = New System.Windows.Forms.PictureBox()
        Me.Block1 = New System.Windows.Forms.PictureBox()
        Me.Block9 = New System.Windows.Forms.PictureBox()
        Me.Block19 = New System.Windows.Forms.PictureBox()
        Me.Block18 = New System.Windows.Forms.PictureBox()
        Me.Block17 = New System.Windows.Forms.PictureBox()
        Me.Block16 = New System.Windows.Forms.PictureBox()
        Me.Block14 = New System.Windows.Forms.PictureBox()
        Me.Block13 = New System.Windows.Forms.PictureBox()
        Me.Block12 = New System.Windows.Forms.PictureBox()
        Me.Block11 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Block5 = New System.Windows.Forms.PictureBox()
        Me.Block10 = New System.Windows.Forms.PictureBox()
        Me.Block20 = New System.Windows.Forms.PictureBox()
        Me.Block15 = New System.Windows.Forms.PictureBox()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Paddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Block15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(12, 9)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(58, 18)
        Me.lblLevel.TabIndex = 0
        Me.lblLevel.Text = "LIVES:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(649, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(72, 18)
        Me.lblScore.TabIndex = 1
        Me.lblScore.Text = "SCORE:"
        '
        'Ball
        '
        Me.Ball.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Ball.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ball.Location = New System.Drawing.Point(363, 275)
        Me.Ball.Name = "Ball"
        Me.Ball.Size = New System.Drawing.Size(16, 16)
        Me.Ball.TabIndex = 2
        Me.Ball.TabStop = False
        '
        'Paddle
        '
        Me.Paddle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Paddle.Location = New System.Drawing.Point(321, 309)
        Me.Paddle.Name = "Paddle"
        Me.Paddle.Size = New System.Drawing.Size(96, 24)
        Me.Paddle.TabIndex = 3
        Me.Paddle.TabStop = False
        '
        'Block8
        '
        Me.Block8.BackColor = System.Drawing.Color.Yellow
        Me.Block8.Location = New System.Drawing.Point(321, 85)
        Me.Block8.Name = "Block8"
        Me.Block8.Size = New System.Drawing.Size(96, 24)
        Me.Block8.TabIndex = 4
        Me.Block8.TabStop = False
        '
        'Block7
        '
        Me.Block7.BackColor = System.Drawing.Color.Yellow
        Me.Block7.Location = New System.Drawing.Point(171, 85)
        Me.Block7.Name = "Block7"
        Me.Block7.Size = New System.Drawing.Size(96, 24)
        Me.Block7.TabIndex = 5
        Me.Block7.TabStop = False
        '
        'Block6
        '
        Me.Block6.BackColor = System.Drawing.Color.Yellow
        Me.Block6.Location = New System.Drawing.Point(12, 85)
        Me.Block6.Name = "Block6"
        Me.Block6.Size = New System.Drawing.Size(96, 24)
        Me.Block6.TabIndex = 6
        Me.Block6.TabStop = False
        '
        'Block4
        '
        Me.Block4.BackColor = System.Drawing.Color.Red
        Me.Block4.Location = New System.Drawing.Point(478, 55)
        Me.Block4.Name = "Block4"
        Me.Block4.Size = New System.Drawing.Size(96, 24)
        Me.Block4.TabIndex = 7
        Me.Block4.TabStop = False
        '
        'Block3
        '
        Me.Block3.BackColor = System.Drawing.Color.Red
        Me.Block3.Location = New System.Drawing.Point(321, 55)
        Me.Block3.Name = "Block3"
        Me.Block3.Size = New System.Drawing.Size(96, 24)
        Me.Block3.TabIndex = 8
        Me.Block3.TabStop = False
        '
        'Block2
        '
        Me.Block2.BackColor = System.Drawing.Color.Red
        Me.Block2.Location = New System.Drawing.Point(171, 55)
        Me.Block2.Name = "Block2"
        Me.Block2.Size = New System.Drawing.Size(96, 24)
        Me.Block2.TabIndex = 9
        Me.Block2.TabStop = False
        '
        'Block1
        '
        Me.Block1.BackColor = System.Drawing.Color.Red
        Me.Block1.Location = New System.Drawing.Point(12, 55)
        Me.Block1.Name = "Block1"
        Me.Block1.Size = New System.Drawing.Size(96, 24)
        Me.Block1.TabIndex = 10
        Me.Block1.TabStop = False
        '
        'Block9
        '
        Me.Block9.BackColor = System.Drawing.Color.Yellow
        Me.Block9.Location = New System.Drawing.Point(478, 85)
        Me.Block9.Name = "Block9"
        Me.Block9.Size = New System.Drawing.Size(96, 24)
        Me.Block9.TabIndex = 11
        Me.Block9.TabStop = False
        '
        'Block19
        '
        Me.Block19.BackColor = System.Drawing.Color.Blue
        Me.Block19.Location = New System.Drawing.Point(478, 145)
        Me.Block19.Name = "Block19"
        Me.Block19.Size = New System.Drawing.Size(96, 24)
        Me.Block19.TabIndex = 12
        Me.Block19.TabStop = False
        '
        'Block18
        '
        Me.Block18.BackColor = System.Drawing.Color.Blue
        Me.Block18.Location = New System.Drawing.Point(321, 145)
        Me.Block18.Name = "Block18"
        Me.Block18.Size = New System.Drawing.Size(96, 24)
        Me.Block18.TabIndex = 13
        Me.Block18.TabStop = False
        '
        'Block17
        '
        Me.Block17.BackColor = System.Drawing.Color.Blue
        Me.Block17.Location = New System.Drawing.Point(171, 145)
        Me.Block17.Name = "Block17"
        Me.Block17.Size = New System.Drawing.Size(96, 24)
        Me.Block17.TabIndex = 14
        Me.Block17.TabStop = False
        '
        'Block16
        '
        Me.Block16.BackColor = System.Drawing.Color.Blue
        Me.Block16.Location = New System.Drawing.Point(12, 145)
        Me.Block16.Name = "Block16"
        Me.Block16.Size = New System.Drawing.Size(96, 24)
        Me.Block16.TabIndex = 15
        Me.Block16.TabStop = False
        '
        'Block14
        '
        Me.Block14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Block14.Location = New System.Drawing.Point(478, 115)
        Me.Block14.Name = "Block14"
        Me.Block14.Size = New System.Drawing.Size(96, 24)
        Me.Block14.TabIndex = 16
        Me.Block14.TabStop = False
        '
        'Block13
        '
        Me.Block13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Block13.Location = New System.Drawing.Point(321, 115)
        Me.Block13.Name = "Block13"
        Me.Block13.Size = New System.Drawing.Size(96, 24)
        Me.Block13.TabIndex = 17
        Me.Block13.TabStop = False
        '
        'Block12
        '
        Me.Block12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Block12.Location = New System.Drawing.Point(171, 115)
        Me.Block12.Name = "Block12"
        Me.Block12.Size = New System.Drawing.Size(96, 24)
        Me.Block12.TabIndex = 18
        Me.Block12.TabStop = False
        '
        'Block11
        '
        Me.Block11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Block11.Location = New System.Drawing.Point(12, 115)
        Me.Block11.Name = "Block11"
        Me.Block11.Size = New System.Drawing.Size(96, 24)
        Me.Block11.TabIndex = 19
        Me.Block11.TabStop = False
        '
        'Timer1
        '
        '
        'Block5
        '
        Me.Block5.BackColor = System.Drawing.Color.Red
        Me.Block5.Location = New System.Drawing.Point(625, 55)
        Me.Block5.Name = "Block5"
        Me.Block5.Size = New System.Drawing.Size(96, 24)
        Me.Block5.TabIndex = 20
        Me.Block5.TabStop = False
        '
        'Block10
        '
        Me.Block10.BackColor = System.Drawing.Color.Yellow
        Me.Block10.Location = New System.Drawing.Point(625, 85)
        Me.Block10.Name = "Block10"
        Me.Block10.Size = New System.Drawing.Size(96, 24)
        Me.Block10.TabIndex = 21
        Me.Block10.TabStop = False
        '
        'Block20
        '
        Me.Block20.BackColor = System.Drawing.Color.Blue
        Me.Block20.Location = New System.Drawing.Point(625, 145)
        Me.Block20.Name = "Block20"
        Me.Block20.Size = New System.Drawing.Size(96, 24)
        Me.Block20.TabIndex = 22
        Me.Block20.TabStop = False
        '
        'Block15
        '
        Me.Block15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Block15.Location = New System.Drawing.Point(625, 115)
        Me.Block15.Name = "Block15"
        Me.Block15.Size = New System.Drawing.Size(96, 24)
        Me.Block15.TabIndex = 23
        Me.Block15.TabStop = False
        '
        'lblBLB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(764, 443)
        Me.Controls.Add(Me.Block15)
        Me.Controls.Add(Me.Block20)
        Me.Controls.Add(Me.Block10)
        Me.Controls.Add(Me.Block5)
        Me.Controls.Add(Me.Block11)
        Me.Controls.Add(Me.Block12)
        Me.Controls.Add(Me.Block13)
        Me.Controls.Add(Me.Block14)
        Me.Controls.Add(Me.Block16)
        Me.Controls.Add(Me.Block17)
        Me.Controls.Add(Me.Block18)
        Me.Controls.Add(Me.Block19)
        Me.Controls.Add(Me.Block9)
        Me.Controls.Add(Me.Block1)
        Me.Controls.Add(Me.Block2)
        Me.Controls.Add(Me.Block3)
        Me.Controls.Add(Me.Block4)
        Me.Controls.Add(Me.Block6)
        Me.Controls.Add(Me.Block7)
        Me.Controls.Add(Me.Block8)
        Me.Controls.Add(Me.Paddle)
        Me.Controls.Add(Me.Ball)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblLevel)
        Me.Name = "lblBLB"
        Me.Text = "Block Buster"
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Paddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Block15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents Ball As System.Windows.Forms.PictureBox
    Friend WithEvents Paddle As System.Windows.Forms.PictureBox
    Friend WithEvents Block8 As System.Windows.Forms.PictureBox
    Friend WithEvents Block7 As System.Windows.Forms.PictureBox
    Friend WithEvents Block6 As System.Windows.Forms.PictureBox
    Friend WithEvents Block4 As System.Windows.Forms.PictureBox
    Friend WithEvents Block3 As System.Windows.Forms.PictureBox
    Friend WithEvents Block2 As System.Windows.Forms.PictureBox
    Friend WithEvents Block1 As System.Windows.Forms.PictureBox
    Friend WithEvents Block9 As System.Windows.Forms.PictureBox
    Friend WithEvents Block19 As System.Windows.Forms.PictureBox
    Friend WithEvents Block18 As System.Windows.Forms.PictureBox
    Friend WithEvents Block17 As System.Windows.Forms.PictureBox
    Friend WithEvents Block16 As System.Windows.Forms.PictureBox
    Friend WithEvents Block14 As System.Windows.Forms.PictureBox
    Friend WithEvents Block13 As System.Windows.Forms.PictureBox
    Friend WithEvents Block12 As System.Windows.Forms.PictureBox
    Friend WithEvents Block11 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Block5 As System.Windows.Forms.PictureBox
    Friend WithEvents Block10 As System.Windows.Forms.PictureBox
    Friend WithEvents Block20 As System.Windows.Forms.PictureBox
    Friend WithEvents Block15 As System.Windows.Forms.PictureBox

End Class
