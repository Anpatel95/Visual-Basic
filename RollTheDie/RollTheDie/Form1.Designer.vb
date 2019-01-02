<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRollDie
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
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblOutput12 = New System.Windows.Forms.Label()
        Me.lblOutput13 = New System.Windows.Forms.Label()
        Me.lblOutput14 = New System.Windows.Forms.Label()
        Me.lblOutput15 = New System.Windows.Forms.Label()
        Me.lblOutput16 = New System.Windows.Forms.Label()
        Me.lblOutput17 = New System.Windows.Forms.Label()
        Me.lblOutput18 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.Die5 = New System.Windows.Forms.PictureBox()
        Me.Die6 = New System.Windows.Forms.PictureBox()
        Me.Die4 = New System.Windows.Forms.PictureBox()
        Me.Die3 = New System.Windows.Forms.PictureBox()
        Me.Die2 = New System.Windows.Forms.PictureBox()
        Me.Die1 = New System.Windows.Forms.PictureBox()
        Me.pb2 = New System.Windows.Forms.PictureBox()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Die5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Die6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Die4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Die3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Die2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Die1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(630, 143)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 0
        Me.btnRoll.Text = "Roll The Die"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(630, 186)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Roll the Die"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Current Value:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Results:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "3:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(77, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "4:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(77, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "5:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(77, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "6:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(68, 308)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Count:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(61, 373)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Programmed by: An patel"
        '
        'lblOutput12
        '
        Me.lblOutput12.AutoSize = True
        Me.lblOutput12.Location = New System.Drawing.Point(384, 96)
        Me.lblOutput12.Name = "lblOutput12"
        Me.lblOutput12.Size = New System.Drawing.Size(45, 13)
        Me.lblOutput12.TabIndex = 20
        Me.lblOutput12.Text = "Label12"
        '
        'lblOutput13
        '
        Me.lblOutput13.AutoSize = True
        Me.lblOutput13.Location = New System.Drawing.Point(122, 163)
        Me.lblOutput13.Name = "lblOutput13"
        Me.lblOutput13.Size = New System.Drawing.Size(45, 13)
        Me.lblOutput13.TabIndex = 21
        Me.lblOutput13.Text = "Label13"
        '
        'lblOutput14
        '
        Me.lblOutput14.AutoSize = True
        Me.lblOutput14.Location = New System.Drawing.Point(122, 186)
        Me.lblOutput14.Name = "lblOutput14"
        Me.lblOutput14.Size = New System.Drawing.Size(45, 13)
        Me.lblOutput14.TabIndex = 22
        Me.lblOutput14.Text = "Label14"
        '
        'lblOutput15
        '
        Me.lblOutput15.AutoSize = True
        Me.lblOutput15.Location = New System.Drawing.Point(122, 205)
        Me.lblOutput15.Name = "lblOutput15"
        Me.lblOutput15.Size = New System.Drawing.Size(45, 13)
        Me.lblOutput15.TabIndex = 23
        Me.lblOutput15.Text = "Label15"
        '
        'lblOutput16
        '
        Me.lblOutput16.AutoSize = True
        Me.lblOutput16.Location = New System.Drawing.Point(122, 227)
        Me.lblOutput16.Name = "lblOutput16"
        Me.lblOutput16.Size = New System.Drawing.Size(45, 13)
        Me.lblOutput16.TabIndex = 24
        Me.lblOutput16.Text = "Label16"
        '
        'lblOutput17
        '
        Me.lblOutput17.AutoSize = True
        Me.lblOutput17.Location = New System.Drawing.Point(122, 247)
        Me.lblOutput17.Name = "lblOutput17"
        Me.lblOutput17.Size = New System.Drawing.Size(45, 13)
        Me.lblOutput17.TabIndex = 25
        Me.lblOutput17.Text = "Label17"
        '
        'lblOutput18
        '
        Me.lblOutput18.AutoSize = True
        Me.lblOutput18.Location = New System.Drawing.Point(122, 271)
        Me.lblOutput18.Name = "lblOutput18"
        Me.lblOutput18.Size = New System.Drawing.Size(45, 13)
        Me.lblOutput18.TabIndex = 26
        Me.lblOutput18.Text = "Label18"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(112, 308)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(45, 13)
        Me.lblCount.TabIndex = 27
        Me.lblCount.Text = "Label19"
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(294, 180)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(60, 60)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1.TabIndex = 28
        Me.pb1.TabStop = False
        '
        'Die5
        '
        Me.Die5.Image = Global.RollTheDie.My.Resources.Resources.die5pic
        Me.Die5.Location = New System.Drawing.Point(369, 316)
        Me.Die5.Name = "Die5"
        Me.Die5.Size = New System.Drawing.Size(30, 30)
        Me.Die5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Die5.TabIndex = 34
        Me.Die5.TabStop = False
        '
        'Die6
        '
        Me.Die6.Image = Global.RollTheDie.My.Resources.Resources.die6pic
        Me.Die6.Location = New System.Drawing.Point(414, 316)
        Me.Die6.Name = "Die6"
        Me.Die6.Size = New System.Drawing.Size(30, 30)
        Me.Die6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Die6.TabIndex = 33
        Me.Die6.TabStop = False
        '
        'Die4
        '
        Me.Die4.Image = Global.RollTheDie.My.Resources.Resources.die4pic
        Me.Die4.Location = New System.Drawing.Point(324, 316)
        Me.Die4.Name = "Die4"
        Me.Die4.Size = New System.Drawing.Size(30, 30)
        Me.Die4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Die4.TabIndex = 32
        Me.Die4.TabStop = False
        '
        'Die3
        '
        Me.Die3.Image = Global.RollTheDie.My.Resources.Resources.die3pic
        Me.Die3.Location = New System.Drawing.Point(414, 280)
        Me.Die3.Name = "Die3"
        Me.Die3.Size = New System.Drawing.Size(30, 30)
        Me.Die3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Die3.TabIndex = 31
        Me.Die3.TabStop = False
        '
        'Die2
        '
        Me.Die2.Image = Global.RollTheDie.My.Resources.Resources.die2pic
        Me.Die2.Location = New System.Drawing.Point(369, 280)
        Me.Die2.Name = "Die2"
        Me.Die2.Size = New System.Drawing.Size(30, 30)
        Me.Die2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Die2.TabIndex = 30
        Me.Die2.TabStop = False
        '
        'Die1
        '
        Me.Die1.Image = Global.RollTheDie.My.Resources.Resources.die1pic
        Me.Die1.Location = New System.Drawing.Point(324, 280)
        Me.Die1.Name = "Die1"
        Me.Die1.Size = New System.Drawing.Size(30, 30)
        Me.Die1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Die1.TabIndex = 29
        Me.Die1.TabStop = False
        '
        'pb2
        '
        Me.pb2.Location = New System.Drawing.Point(414, 180)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(60, 60)
        Me.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb2.TabIndex = 35
        Me.pb2.TabStop = False
        '
        'frmRollDie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 403)
        Me.Controls.Add(Me.pb2)
        Me.Controls.Add(Me.Die5)
        Me.Controls.Add(Me.Die6)
        Me.Controls.Add(Me.Die4)
        Me.Controls.Add(Me.Die3)
        Me.Controls.Add(Me.Die2)
        Me.Controls.Add(Me.Die1)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblOutput18)
        Me.Controls.Add(Me.lblOutput17)
        Me.Controls.Add(Me.lblOutput16)
        Me.Controls.Add(Me.lblOutput15)
        Me.Controls.Add(Me.lblOutput14)
        Me.Controls.Add(Me.lblOutput13)
        Me.Controls.Add(Me.lblOutput12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRoll)
        Me.Name = "frmRollDie"
        Me.Text = "Roll the Die"
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Die5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Die6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Die4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Die3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Die2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Die1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblOutput12 As System.Windows.Forms.Label
    Friend WithEvents lblOutput13 As System.Windows.Forms.Label
    Friend WithEvents lblOutput14 As System.Windows.Forms.Label
    Friend WithEvents lblOutput15 As System.Windows.Forms.Label
    Friend WithEvents lblOutput16 As System.Windows.Forms.Label
    Friend WithEvents lblOutput17 As System.Windows.Forms.Label
    Friend WithEvents lblOutput18 As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents Die5 As System.Windows.Forms.PictureBox
    Friend WithEvents Die6 As System.Windows.Forms.PictureBox
    Friend WithEvents Die4 As System.Windows.Forms.PictureBox
    Friend WithEvents Die3 As System.Windows.Forms.PictureBox
    Friend WithEvents Die2 As System.Windows.Forms.PictureBox
    Friend WithEvents Die1 As System.Windows.Forms.PictureBox
    Friend WithEvents pb2 As System.Windows.Forms.PictureBox

End Class
