<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketSale
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayPriceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchasePriceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstSection = New System.Windows.Forms.ListBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPurchaseInfo = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TicketToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(629, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TicketSummaryToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'TicketSummaryToolStripMenuItem
        '
        Me.TicketSummaryToolStripMenuItem.Name = "TicketSummaryToolStripMenuItem"
        Me.TicketSummaryToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.TicketSummaryToolStripMenuItem.Text = "Ticket Summary"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(157, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TicketToolStripMenuItem
        '
        Me.TicketToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayPriceToolStripMenuItem, Me.PurchasePriceToolStripMenuItem1})
        Me.TicketToolStripMenuItem.Name = "TicketToolStripMenuItem"
        Me.TicketToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.TicketToolStripMenuItem.Text = "Ticket"
        '
        'DisplayPriceToolStripMenuItem
        '
        Me.DisplayPriceToolStripMenuItem.Name = "DisplayPriceToolStripMenuItem"
        Me.DisplayPriceToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DisplayPriceToolStripMenuItem.Text = "Display Price"
        '
        'PurchasePriceToolStripMenuItem1
        '
        Me.PurchasePriceToolStripMenuItem1.Name = "PurchasePriceToolStripMenuItem1"
        Me.PurchasePriceToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.PurchasePriceToolStripMenuItem1.Text = "Purchase Ticket"
        '
        'lstSection
        '
        Me.lstSection.FormattingEnabled = True
        Me.lstSection.Items.AddRange(New Object() {"Orchestra     $40.00" & Global.Microsoft.VisualBasic.ChrW(9), "Mezzanine      $27.50", "General           $15.00", "Balcony" & Global.Microsoft.VisualBasic.ChrW(9) & "      $10.00"})
        Me.lstSection.Location = New System.Drawing.Point(123, 78)
        Me.lstSection.Name = "lstSection"
        Me.lstSection.Size = New System.Drawing.Size(120, 95)
        Me.lstSection.TabIndex = 1
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(279, 95)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 20)
        Me.txtNum.TabIndex = 2
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(279, 185)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Club Concert"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Select section:-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Enter number of tickets:-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(279, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total Amount:-"
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(434, 159)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 9
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(434, 95)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(349, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(268, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Click purchase ticket from menubar after you enter data"
        '
        'lblPurchaseInfo
        '
        Me.lblPurchaseInfo.AutoSize = True
        Me.lblPurchaseInfo.Location = New System.Drawing.Point(276, 131)
        Me.lblPurchaseInfo.Name = "lblPurchaseInfo"
        Me.lblPurchaseInfo.Size = New System.Drawing.Size(17, 13)
        Me.lblPurchaseInfo.TabIndex = 12
        Me.lblPurchaseInfo.Text = """"""
        '
        'TicketSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 357)
        Me.Controls.Add(Me.lblPurchaseInfo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.lstSection)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "TicketSale"
        Me.Text = "Sale tickets"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TicketSummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TicketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayPriceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchasePriceToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents lstSection As ListBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnexit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPurchaseInfo As Label
End Class
