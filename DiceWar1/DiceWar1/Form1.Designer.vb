<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiceWar1
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblOutput1 = New System.Windows.Forms.Label()
        Me.lblOutput2 = New System.Windows.Forms.Label()
        Me.lblOutput3 = New System.Windows.Forms.Label()
        Me.lblOutput4 = New System.Windows.Forms.Label()
        Me.lblOutput5 = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.pb2 = New System.Windows.Forms.PictureBox()
        Me.Die1 = New System.Windows.Forms.PictureBox()
        Me.Die2 = New System.Windows.Forms.PictureBox()
        Me.Die3 = New System.Windows.Forms.PictureBox()
        Me.Die4 = New System.Windows.Forms.PictureBox()
        Me.Die5 = New System.Windows.Forms.PictureBox()
        Me.Die6 = New System.Windows.Forms.PictureBox()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Die1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Die2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Die3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Die4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Die5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Die6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'lblOutput1
        '
        Me.lblOutput1.AutoSize = True
        Me.lblOutput1.Location = New System.Drawing.Point(33, 24)
        Me.lblOutput1.Name = "lblOutput1"
        Me.lblOutput1.Size = New System.Drawing.Size(45, 13)
        Me.lblOutput1.TabIndex = 0
        Me.lblOutput1.Text = "Player 1"
        '
        'lblOutput2
        '
        Me.lblOutput2.AutoSize = True
        Me.lblOutput2.Location = New System.Drawing.Point(650, 22)
        Me.lblOutput2.Name = "lblOutput2"
        Me.lblOutput2.Size = New System.Drawing.Size(45, 13)
        Me.lblOutput2.TabIndex = 1
        Me.lblOutput2.Text = "Player 2"
        '
        'lblOutput3
        '
        Me.lblOutput3.AutoSize = True
        Me.lblOutput3.Location = New System.Drawing.Point(650, 52)
        Me.lblOutput3.Name = "lblOutput3"
        Me.lblOutput3.Size = New System.Drawing.Size(39, 13)
        Me.lblOutput3.TabIndex = 2
        Me.lblOutput3.Text = "Label3"
        '
        'lblOutput4
        '
        Me.lblOutput4.AutoSize = True
        Me.lblOutput4.Location = New System.Drawing.Point(33, 52)
        Me.lblOutput4.Name = "lblOutput4"
        Me.lblOutput4.Size = New System.Drawing.Size(39, 13)
        Me.lblOutput4.TabIndex = 3
        Me.lblOutput4.Text = "Label4"
        '
        'lblOutput5
        '
        Me.lblOutput5.AutoSize = True
        Me.lblOutput5.Location = New System.Drawing.Point(335, 22)
        Me.lblOutput5.Name = "lblOutput5"
        Me.lblOutput5.Size = New System.Drawing.Size(39, 13)
        Me.lblOutput5.TabIndex = 4
        Me.lblOutput5.Text = "Label5"
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(323, 131)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(75, 23)
        Me.btnRestart.TabIndex = 5
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(153, 131)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(60, 60)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1.TabIndex = 6
        Me.pb1.TabStop = False
        '
        'pb2
        '
        Me.pb2.Location = New System.Drawing.Point(482, 131)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(60, 60)
        Me.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb2.TabIndex = 7
        Me.pb2.TabStop = False
        '
        'Die1
        '
        Me.Die1.Image = Global.DiceWar1.My.Resources.Resources.die1
        Me.Die1.Location = New System.Drawing.Point(69, 244)
        Me.Die1.Name = "Die1"
        Me.Die1.Size = New System.Drawing.Size(70, 70)
        Me.Die1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Die1.TabIndex = 8
        Me.Die1.TabStop = False
        '
        'Die2
        '
        Me.Die2.Image = Global.DiceWar1.My.Resources.Resources.die2
        Me.Die2.Location = New System.Drawing.Point(173, 244)
        Me.Die2.Name = "Die2"
        Me.Die2.Size = New System.Drawing.Size(70, 70)
        Me.Die2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Die2.TabIndex = 9
        Me.Die2.TabStop = False
        '
        'Die3
        '
        Me.Die3.Image = Global.DiceWar1.My.Resources.Resources.die3
        Me.Die3.Location = New System.Drawing.Point(280, 244)
        Me.Die3.Name = "Die3"
        Me.Die3.Size = New System.Drawing.Size(70, 70)
        Me.Die3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Die3.TabIndex = 10
        Me.Die3.TabStop = False
        '
        'Die4
        '
        Me.Die4.Image = Global.DiceWar1.My.Resources.Resources.die4
        Me.Die4.Location = New System.Drawing.Point(380, 244)
        Me.Die4.Name = "Die4"
        Me.Die4.Size = New System.Drawing.Size(70, 70)
        Me.Die4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Die4.TabIndex = 11
        Me.Die4.TabStop = False
        '
        'Die5
        '
        Me.Die5.Image = Global.DiceWar1.My.Resources.Resources.die5
        Me.Die5.Location = New System.Drawing.Point(493, 244)
        Me.Die5.Name = "Die5"
        Me.Die5.Size = New System.Drawing.Size(70, 70)
        Me.Die5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Die5.TabIndex = 12
        Me.Die5.TabStop = False
        '
        'Die6
        '
        Me.Die6.Image = Global.DiceWar1.My.Resources.Resources.die6
        Me.Die6.Location = New System.Drawing.Point(590, 244)
        Me.Die6.Name = "Die6"
        Me.Die6.Size = New System.Drawing.Size(70, 70)
        Me.Die6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Die6.TabIndex = 13
        Me.Die6.TabStop = False
        '
        'frmDiceWar1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 374)
        Me.Controls.Add(Me.Die6)
        Me.Controls.Add(Me.Die5)
        Me.Controls.Add(Me.Die4)
        Me.Controls.Add(Me.Die3)
        Me.Controls.Add(Me.Die2)
        Me.Controls.Add(Me.Die1)
        Me.Controls.Add(Me.pb2)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.lblOutput5)
        Me.Controls.Add(Me.lblOutput4)
        Me.Controls.Add(Me.lblOutput3)
        Me.Controls.Add(Me.lblOutput2)
        Me.Controls.Add(Me.lblOutput1)
        Me.Name = "frmDiceWar1"
        Me.Text = "Dice War"
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Die1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Die2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Die3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Die4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Die5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Die6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblOutput1 As System.Windows.Forms.Label
    Friend WithEvents lblOutput2 As System.Windows.Forms.Label
    Friend WithEvents lblOutput3 As System.Windows.Forms.Label
    Friend WithEvents lblOutput4 As System.Windows.Forms.Label
    Friend WithEvents lblOutput5 As System.Windows.Forms.Label
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents pb2 As System.Windows.Forms.PictureBox
    Friend WithEvents Die1 As System.Windows.Forms.PictureBox
    Friend WithEvents Die2 As System.Windows.Forms.PictureBox
    Friend WithEvents Die3 As System.Windows.Forms.PictureBox
    Friend WithEvents Die4 As System.Windows.Forms.PictureBox
    Friend WithEvents Die5 As System.Windows.Forms.PictureBox
    Friend WithEvents Die6 As System.Windows.Forms.PictureBox

End Class
