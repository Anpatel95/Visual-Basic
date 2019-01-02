<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrizeSchForm
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
        Me.PriceListBox = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PriceListBox
        '
        Me.PriceListBox.FormattingEnabled = True
        Me.PriceListBox.Location = New System.Drawing.Point(48, 20)
        Me.PriceListBox.Name = "PriceListBox"
        Me.PriceListBox.Size = New System.Drawing.Size(295, 134)
        Me.PriceListBox.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(158, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrizeSchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PriceListBox)
        Me.Name = "PrizeSchForm"
        Me.Text = "Price Schedule Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PriceListBox As ListBox
    Friend WithEvents Button1 As Button
End Class
