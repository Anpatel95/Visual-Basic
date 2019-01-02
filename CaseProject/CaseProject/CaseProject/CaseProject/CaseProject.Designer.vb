<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaseProject
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtNumOfPieces = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.txtTotalpay = New System.Windows.Forms.TextBox()
        Me.txtTotalpieces = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.lstName = New System.Windows.Forms.ListBox()
        Me.lstPieces = New System.Windows.Forms.ListBox()
        Me.lstAmtEarned = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(311, 30)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 0
        '
        'txtNumOfPieces
        '
        Me.txtNumOfPieces.Location = New System.Drawing.Point(311, 68)
        Me.txtNumOfPieces.Name = "txtNumOfPieces"
        Me.txtNumOfPieces.Size = New System.Drawing.Size(100, 20)
        Me.txtNumOfPieces.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(199, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name of the person:-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "The number of pieces submitted:-"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(447, 30)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnSummary
        '
        Me.btnSummary.Location = New System.Drawing.Point(447, 63)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(75, 23)
        Me.btnSummary.TabIndex = 5
        Me.btnSummary.Text = "Summary"
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(447, 92)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(447, 150)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAverage)
        Me.GroupBox1.Controls.Add(Me.txtTotalpay)
        Me.GroupBox1.Controls.Add(Me.txtTotalpieces)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 138)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Summary"
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(144, 96)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(100, 20)
        Me.txtAverage.TabIndex = 5
        '
        'txtTotalpay
        '
        Me.txtTotalpay.Location = New System.Drawing.Point(144, 67)
        Me.txtTotalpay.Name = "txtTotalpay"
        Me.txtTotalpay.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalpay.TabIndex = 4
        '
        'txtTotalpieces
        '
        Me.txtTotalpieces.Location = New System.Drawing.Point(144, 36)
        Me.txtTotalpieces.Name = "txtTotalpieces"
        Me.txtTotalpieces.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalpieces.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Average pay per person:-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "The Total pay:-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "The total number of pieces:-"
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(447, 121)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(75, 23)
        Me.btnClearAll.TabIndex = 9
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'lstName
        '
        Me.lstName.FormattingEnabled = True
        Me.lstName.Items.AddRange(New Object() {"Name", "---------------------------------------------------------------------------------" &
                "-------------------"})
        Me.lstName.Location = New System.Drawing.Point(296, 191)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(82, 147)
        Me.lstName.TabIndex = 10
        '
        'lstPieces
        '
        Me.lstPieces.FormattingEnabled = True
        Me.lstPieces.Items.AddRange(New Object() {"Pieces", "-------------------------------------------------------------------------"})
        Me.lstPieces.Location = New System.Drawing.Point(384, 191)
        Me.lstPieces.Name = "lstPieces"
        Me.lstPieces.Size = New System.Drawing.Size(57, 147)
        Me.lstPieces.TabIndex = 11
        '
        'lstAmtEarned
        '
        Me.lstAmtEarned.FormattingEnabled = True
        Me.lstAmtEarned.Items.AddRange(New Object() {"Amount Earned", "-----------------------------------------------------------------------"})
        Me.lstAmtEarned.Location = New System.Drawing.Point(447, 191)
        Me.lstAmtEarned.Name = "lstAmtEarned"
        Me.lstAmtEarned.Size = New System.Drawing.Size(82, 147)
        Me.lstAmtEarned.TabIndex = 12
        '
        'CaseProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 371)
        Me.Controls.Add(Me.lstAmtEarned)
        Me.Controls.Add(Me.lstPieces)
        Me.Controls.Add(Me.lstName)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSummary)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumOfPieces)
        Me.Controls.Add(Me.txtName)
        Me.Name = "CaseProject"
        Me.Text = "Case Project"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNumOfPieces As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnSummary As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents txtTotalpay As TextBox
    Friend WithEvents txtTotalpieces As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClearAll As Button
    Friend WithEvents lstName As ListBox
    Friend WithEvents lstPieces As ListBox
    Friend WithEvents lstAmtEarned As ListBox
End Class
