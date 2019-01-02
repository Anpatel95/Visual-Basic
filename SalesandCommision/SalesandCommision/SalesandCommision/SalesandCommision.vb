
Option Explicit On
'An PAtel
'CHp5 Sales and commision project 
'This program will calculate sales and commision

Public Class SalesandCommision


    'Constants
    Const QUOTA As Double = 1000
    Const COMM_RATE As Double = 0.15
    Const BASE_PAY As Double = 250
    Dim wsales As Double
    Dim strMessage As String

    Private Sub SalesandCommision_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Function CalculateCommission(ByVal seller As Seller) As Double

        'If the seller's weekly sales are bigger or equal to the quota, calculates and returns the commission
        'Else it returns 0
        If seller.WeeklySales >= QUOTA Then
            Dim commission As Double = seller.WeeklySales * COMM_RATE
            Return commission
        Else
            Return 0
        End If

    End Function



    Private Sub btnAddSeller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSeller.Click





        'If there is a seller name AND there is a valid weekly sales number, 
        'create a new seller, assign its Name and WeeklySales properties and add it to the listbox
        If txtSeller.Text <> "" AndAlso Double.TryParse(txtWeeklySales.Text, wsales) Then

            Dim newSeller As New Seller
            With newSeller
                .Name = txtSeller.Text
                .WeeklySales = wsales
            End With

            ListBox1.Items.Add(newSeller)

            txtSeller.Clear()
            txtWeeklySales.Clear()
            txtSeller.Select()

        Else
            MessageBox.Show("You must enter valid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End If





    End Sub



    Private Sub PayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayToolStripMenuItem.Click
        'This button displays the listbox selected seller's info on a Messagebox


        'If there is a selected item it proceeds, if not it shows an error message
        If ListBox1.SelectedIndex > -1 Then

            Dim currentSeller As Seller = DirectCast(ListBox1.SelectedItem, Seller)

            Dim commission As Double = CalculateCommission(currentSeller)

            If commission > 0 Then
                strMessage = "Seller's name: " & currentSeller.Name & vbCrLf &
                             "Weekly sales: " & currentSeller.WeeklySales.ToString & vbCrLf &
                             "Commission: " & commission.ToString("0.00") & vbCrLf &
                             "Total pay: " & (BASE_PAY + commission).ToString("0.00")
                MessageBox.Show(strMessage, currentSeller.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                strMessage = "Seller's name: " & currentSeller.Name & vbCrLf &
                             "Weekly sales: " & currentSeller.WeeklySales.ToString & vbCrLf &
                             "Total pay: " & BASE_PAY.ToString("0.00")
                MessageBox.Show(strMessage, currentSeller.Name, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Else
            MessageBox.Show("No seller selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End If
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        'Displays a MessageBox that holds total sales, total commissions and total pay for all salespersons. 
        'Displays the numbers with two decimal places and dollar signs.

        Dim totalSales, currSellerComm, totalCommissions, totalPay As Double

        For i As Integer = 0 To ListBox1.Items.Count - 1

            Dim currSeller As Seller = DirectCast(ListBox1.Items(i), Seller)

            totalSales += currSeller.WeeklySales

            currSellerComm = CalculateCommission(currSeller)

            If currSellerComm > 0 Then
                totalCommissions += currSellerComm
                totalPay += (BASE_PAY + currSellerComm)
            Else
                totalPay += BASE_PAY
            End If

        Next i

        Dim strSummary As String

        strSummary = "Total sales: " & totalSales.ToString & vbCrLf &
                     "Total commissions: " & totalCommissions.ToString("c") & vbCrLf &
                     "Total pay: " & totalPay.ToString("c")

        MessageBox.Show(strSummary, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        'Allow the user to select a new font for the total pay text box.

        With FontDialog1
            .Font = txtSeller.Font
            .ShowDialog()
            txtSeller.Font = .Font
        End With
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        'Allow the user to select a new color for the text of the total pay text box

        With ColorDialog1
            .ShowDialog()
            txtWeeklySales.ForeColor = .Color
        End With
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim MessageString As String
        MessageString = "Salary Calculator with commision" & vbCrLf & "Programmed by An Patel"
        MessageBox.Show(MessageString, "About Salary Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ClearToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem1.Click
        txtSeller.Text = ""
        txtWeeklySales.Text = ""
        txtSeller.Clear()
        txtWeeklySales.Clear()
        txtSeller.Select()
        ListBox1.Items.Clear()




    End Sub
End Class

Public Class Seller

    Public Property Name As String
    Public Property WeeklySales As Double



    Public Overrides Function ToString() As String

        Return Me.Name

    End Function

End Class





