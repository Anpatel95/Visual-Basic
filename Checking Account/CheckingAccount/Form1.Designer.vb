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
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSumm = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBala = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdbDepo = New System.Windows.Forms.RadioButton()
        Me.rdbCheck = New System.Windows.Forms.RadioButton()
        Me.rdbser = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(252, 120)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(75, 23)
        Me.btnCal.TabIndex = 0
        Me.btnCal.Text = "Calculate"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(252, 149)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSumm
        '
        Me.btnSumm.Location = New System.Drawing.Point(252, 178)
        Me.btnSumm.Name = "btnSumm"
        Me.btnSumm.Size = New System.Drawing.Size(75, 23)
        Me.btnSumm.TabIndex = 2
        Me.btnSumm.Text = "Summary"
        Me.btnSumm.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(252, 225)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(246, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Account Balance:"
        '
        'lblBala
        '
        Me.lblBala.AutoSize = True
        Me.lblBala.Location = New System.Drawing.Point(246, 64)
        Me.lblBala.Name = "lblBala"
        Me.lblBala.Size = New System.Drawing.Size(39, 13)
        Me.lblBala.TabIndex = 6
        Me.lblBala.Text = "Label3"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(43, 64)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Transaction Type"
        '
        'rdbDepo
        '
        Me.rdbDepo.AutoSize = True
        Me.rdbDepo.Location = New System.Drawing.Point(43, 129)
        Me.rdbDepo.Name = "rdbDepo"
        Me.rdbDepo.Size = New System.Drawing.Size(61, 17)
        Me.rdbDepo.TabIndex = 9
        Me.rdbDepo.TabStop = True
        Me.rdbDepo.Text = "Deposit"
        Me.rdbDepo.UseVisualStyleBackColor = True
        '
        'rdbCheck
        '
        Me.rdbCheck.AutoSize = True
        Me.rdbCheck.Location = New System.Drawing.Point(43, 149)
        Me.rdbCheck.Name = "rdbCheck"
        Me.rdbCheck.Size = New System.Drawing.Size(56, 17)
        Me.rdbCheck.TabIndex = 10
        Me.rdbCheck.TabStop = True
        Me.rdbCheck.Text = "Check"
        Me.rdbCheck.UseVisualStyleBackColor = True
        '
        'rdbser
        '
        Me.rdbser.AutoSize = True
        Me.rdbser.Location = New System.Drawing.Point(43, 172)
        Me.rdbser.Name = "rdbser"
        Me.rdbser.Size = New System.Drawing.Size(98, 17)
        Me.rdbser.TabIndex = 11
        Me.rdbser.TabStop = True
        Me.rdbser.Text = "Service Charge"
        Me.rdbser.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Programmed by An Patel"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 278)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rdbser)
        Me.Controls.Add(Me.rdbCheck)
        Me.Controls.Add(Me.rdbDepo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblBala)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSumm)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCal)
        Me.Name = "Form1"
        Me.Text = "Checking Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCal As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSumm As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblBala As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdbDepo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCheck As System.Windows.Forms.RadioButton
    Friend WithEvents rdbser As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
