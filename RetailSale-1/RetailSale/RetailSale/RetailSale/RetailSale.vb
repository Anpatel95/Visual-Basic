
Option Explicit On
Public Class RetailSale
    'Analkumar Patel
    'Ch4 Project
    'CSIC113
    'This program allows the user to enter the beginning inventory, the ending inventory and the cost of goods sold.


    Dim Average As Integer
    Dim Turnover As Decimal
    Dim Cost As Integer
    Dim BegInventory As Integer
    Dim endInventory As Integer

    Private Sub btnCalc_Click(sender As System.Object, e As System.EventArgs) Handles btnCalc.Click

        Try

            BegInventory = Integer.Parse(txtBeginning.Text)
            Try
                endInventory = Integer.Parse(txtEnding.Text)
                Try
                    Cost = Integer.Parse(txtCost.Text)
                    Average = (BegInventory + endInventory) / 2 'Getting average
                    If Average = 0 Then
                        MsgBox("You can't have zero for your average", MsgBoxStyle.OkCancel) 'Message box if average equals to zero
                    Else
                        Turnover = Cost / Average 'Get the turnover 
                    End If
                    txtAverage.Text = Average
                    txtAverage.Text = FormatCurrency(Average) 'Format to currency
                    txtTurnover.Text = Turnover
                    txtTurnover.Text = FormatNumber(Turnover, 1) 'Format to one decimal




                Catch Cost As FormatException
                    MessageBox.Show("You have to input numerics for cost", "Cost Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Give message if there is no number in textbox
                    With txtCost
                        .Focus()
                        .SelectAll()


                    End With
                End Try
            Catch Ending As FormatException
                MessageBox.Show("You have to input numerics for Ending inventory", "Ending inventory Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Give message if there is no number in textbox
                With txtEnding
                    .Focus()
                    .SelectAll()


                End With

            End Try
        Catch beg As FormatException
            MessageBox.Show("You have to input numerics for Begenning Inventory", "Begenning Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Give message if there is no number in textbox
            With txtBeginning
                .Focus()
                .SelectAll()


            End With


        End Try

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        'Exit the program
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        'Below codes will clear textbox's and set all varabable to zero, so you can start again to do Inventory

        txtBeginning.Text = ""
        txtEnding.Text = ""
        txtCost.Text = ""
        txtAverage.Text = ""
        txtTurnover.Text = ""

        Turnover = 0
        Average = 0
        Cost = 0
        BegInventory = 0
        endInventory = 0



    End Sub




    Private Sub RetailSale_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
