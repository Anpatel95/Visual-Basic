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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkCom = New System.Windows.Forms.CheckBox()
        Me.chkLeather = New System.Windows.Forms.CheckBox()
        Me.chkStero = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbCust = New System.Windows.Forms.RadioButton()
        Me.rdbPear = New System.Windows.Forms.RadioButton()
        Me.rdbStd = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSale = New System.Windows.Forms.TextBox()
        Me.lblAcc = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblAmont = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTrade = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkCom)
        Me.GroupBox1.Controls.Add(Me.chkLeather)
        Me.GroupBox1.Controls.Add(Me.chkStero)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Accessories"
        '
        'chkCom
        '
        Me.chkCom.AutoSize = True
        Me.chkCom.Location = New System.Drawing.Point(7, 77)
        Me.chkCom.Name = "chkCom"
        Me.chkCom.Size = New System.Drawing.Size(125, 17)
        Me.chkCom.TabIndex = 2
        Me.chkCom.Text = "Computer Navigation"
        Me.chkCom.UseVisualStyleBackColor = True
        '
        'chkLeather
        '
        Me.chkLeather.AutoSize = True
        Me.chkLeather.Location = New System.Drawing.Point(7, 54)
        Me.chkLeather.Name = "chkLeather"
        Me.chkLeather.Size = New System.Drawing.Size(97, 17)
        Me.chkLeather.TabIndex = 1
        Me.chkLeather.Text = "Leather Interior"
        Me.chkLeather.UseVisualStyleBackColor = True
        '
        'chkStero
        '
        Me.chkStero.AutoSize = True
        Me.chkStero.Location = New System.Drawing.Point(7, 30)
        Me.chkStero.Name = "chkStero"
        Me.chkStero.Size = New System.Drawing.Size(94, 17)
        Me.chkStero.TabIndex = 0
        Me.chkStero.Text = "Stereo System"
        Me.chkStero.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbCust)
        Me.GroupBox2.Controls.Add(Me.rdbPear)
        Me.GroupBox2.Controls.Add(Me.rdbStd)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Exterior Finish"
        '
        'rdbCust
        '
        Me.rdbCust.AutoSize = True
        Me.rdbCust.Location = New System.Drawing.Point(7, 67)
        Me.rdbCust.Name = "rdbCust"
        Me.rdbCust.Size = New System.Drawing.Size(123, 17)
        Me.rdbCust.TabIndex = 2
        Me.rdbCust.TabStop = True
        Me.rdbCust.Text = "Customized Detailing"
        Me.rdbCust.UseVisualStyleBackColor = True
        '
        'rdbPear
        '
        Me.rdbPear.AutoSize = True
        Me.rdbPear.Location = New System.Drawing.Point(7, 44)
        Me.rdbPear.Name = "rdbPear"
        Me.rdbPear.Size = New System.Drawing.Size(68, 17)
        Me.rdbPear.TabIndex = 1
        Me.rdbPear.TabStop = True
        Me.rdbPear.Text = "Pearlized"
        Me.rdbPear.UseVisualStyleBackColor = True
        '
        'rdbStd
        '
        Me.rdbStd.AutoSize = True
        Me.rdbStd.Location = New System.Drawing.Point(7, 20)
        Me.rdbStd.Name = "rdbStd"
        Me.rdbStd.Size = New System.Drawing.Size(68, 17)
        Me.rdbStd.TabIndex = 0
        Me.rdbStd.TabStop = True
        Me.rdbStd.Text = "Standard"
        Me.rdbStd.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(198, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(305, 332)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(404, 331)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(505, 330)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(333, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Car Sales Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Accessories & Finish:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(366, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Subtotal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(338, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Sales Tax(6%):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(381, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(318, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Trade-in Alowance:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(346, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Amount Due:"
        '
        'txtSale
        '
        Me.txtSale.Location = New System.Drawing.Point(432, 47)
        Me.txtSale.Name = "txtSale"
        Me.txtSale.Size = New System.Drawing.Size(100, 20)
        Me.txtSale.TabIndex = 13
        '
        'lblAcc
        '
        Me.lblAcc.AutoSize = True
        Me.lblAcc.Location = New System.Drawing.Point(432, 84)
        Me.lblAcc.Name = "lblAcc"
        Me.lblAcc.Size = New System.Drawing.Size(10, 13)
        Me.lblAcc.TabIndex = 14
        Me.lblAcc.Text = "."
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(432, 117)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(10, 13)
        Me.lblSubtotal.TabIndex = 15
        Me.lblSubtotal.Text = "."
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(434, 151)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(10, 13)
        Me.lblTax.TabIndex = 16
        Me.lblTax.Text = "."
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(434, 186)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(10, 13)
        Me.lblTotal.TabIndex = 17
        Me.lblTotal.Text = "."
        '
        'lblAmont
        '
        Me.lblAmont.AutoSize = True
        Me.lblAmont.Location = New System.Drawing.Point(434, 255)
        Me.lblAmont.Name = "lblAmont"
        Me.lblAmont.Size = New System.Drawing.Size(10, 13)
        Me.lblAmont.TabIndex = 19
        Me.lblAmont.Text = "."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(72, 368)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Programmed by An Patel"
        '
        'txtTrade
        '
        Me.txtTrade.Location = New System.Drawing.Point(437, 210)
        Me.txtTrade.Name = "txtTrade"
        Me.txtTrade.Size = New System.Drawing.Size(100, 20)
        Me.txtTrade.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 393)
        Me.Controls.Add(Me.txtTrade)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblAmont)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lblAcc)
        Me.Controls.Add(Me.txtSale)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Auto Center"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCom As System.Windows.Forms.CheckBox
    Friend WithEvents chkLeather As System.Windows.Forms.CheckBox
    Friend WithEvents chkStero As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbCust As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPear As System.Windows.Forms.RadioButton
    Friend WithEvents rdbStd As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSale As System.Windows.Forms.TextBox
    Friend WithEvents lblAcc As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblAmont As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTrade As System.Windows.Forms.TextBox

End Class
