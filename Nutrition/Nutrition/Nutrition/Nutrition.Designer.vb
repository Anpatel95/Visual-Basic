<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nutrition
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
        Me.txtFood = New System.Windows.Forms.TextBox()
        Me.txtCalories = New System.Windows.Forms.TextBox()
        Me.txtGramofFat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalCalories = New System.Windows.Forms.Button()
        Me.txttotalfat = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFood
        '
        Me.txtFood.Location = New System.Drawing.Point(194, 60)
        Me.txtFood.Name = "txtFood"
        Me.txtFood.Size = New System.Drawing.Size(100, 20)
        Me.txtFood.TabIndex = 0
        '
        'txtCalories
        '
        Me.txtCalories.Location = New System.Drawing.Point(194, 94)
        Me.txtCalories.Name = "txtCalories"
        Me.txtCalories.Size = New System.Drawing.Size(100, 20)
        Me.txtCalories.TabIndex = 1
        '
        'txtGramofFat
        '
        Me.txtGramofFat.Location = New System.Drawing.Point(194, 131)
        Me.txtGramofFat.Name = "txtGramofFat"
        Me.txtGramofFat.Size = New System.Drawing.Size(100, 20)
        Me.txtGramofFat.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name of Food:-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Calories per serving:-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Grams of fat per serving:-"
        '
        'btnCalCalories
        '
        Me.btnCalCalories.Location = New System.Drawing.Point(82, 157)
        Me.btnCalCalories.Name = "btnCalCalories"
        Me.btnCalCalories.Size = New System.Drawing.Size(169, 57)
        Me.btnCalCalories.TabIndex = 6
        Me.btnCalCalories.Text = "Calculate % calories from fat"
        Me.btnCalCalories.UseVisualStyleBackColor = True
        '
        'txttotalfat
        '
        Me.txttotalfat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalfat.Location = New System.Drawing.Point(12, 220)
        Me.txttotalfat.Multiline = True
        Me.txttotalfat.Name = "txttotalfat"
        Me.txttotalfat.ReadOnly = True
        Me.txttotalfat.Size = New System.Drawing.Size(299, 45)
        Me.txttotalfat.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(257, 157)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(258, 187)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Nutrition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 303)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txttotalfat)
        Me.Controls.Add(Me.btnCalCalories)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGramofFat)
        Me.Controls.Add(Me.txtCalories)
        Me.Controls.Add(Me.txtFood)
        Me.Name = "Nutrition"
        Me.Text = "Nutrition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFood As System.Windows.Forms.TextBox
    Friend WithEvents txtCalories As System.Windows.Forms.TextBox
    Friend WithEvents txtGramofFat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCalCalories As System.Windows.Forms.Button
    Friend WithEvents txttotalfat As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
