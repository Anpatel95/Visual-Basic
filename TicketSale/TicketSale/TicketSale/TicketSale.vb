
'Programmed by An PAtel
'using this program you can by concert tickets
'using Arrays last project, club ticket counts

Option Explicit On
Public Class TicketSale

    Private Price() As Decimal = {40D, 27.5D, 15D, 10D}
    Private TotalSales As Decimal
    Private Number As Integer
    Private Section As Integer
    Private TotalTicketsSold As Integer
    Private Sects() As String = {"Orchestra", "Mezzanine", "General", "Balcony"}








    Private Sub PurchasePriceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurchasePriceToolStripMenuItem1.Click


        If lstSection.SelectedIndex <> -1 Then

            Section = lstSection.SelectedIndex

            If txtNum.Text <> "" Then

                Try

                    Number = Integer.Parse(txtNum.Text)


                    TotalTicketsSold = Price(Section) + Number


                    txtTotal.Text = (Price(Section) * Number).ToString("C")


                    Price(Section) += Number

                    lblPurchaseInfo.Text = ("You have purchased " & Number & " tickets at " & (Price(Section) - Number).ToString("C") & " per ticket. ")



                    TotalSales = TotalTicketsSold * Price(Section)

                Catch NumberException As FormatException
                    MessageBox.Show("Number of tickets must be numeric", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    With txtNum
                        .Focus()
                        .SelectAll()
                    End With

                End Try

            Else
                MessageBox.Show("Enter number of tickets you wish to purchase.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

        Else
            MessageBox.Show("Make a selection from the Section List.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub
    Private Sub DisplayPriceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayPriceToolStripMenuItem.Click

        For i = 0 To 1
            PrizeSchForm.PriceListBox.Items.Add(Sects(i) & vbTab & Price(i).ToString("C"))
        Next

        For i = 2 To 3
            PrizeSchForm.PriceListBox.Items.Add(Sects(i) & vbTab & vbTab & Price(i).ToString("C"))
        Next


        PrizeSchForm.ShowDialog()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtNum.Clear()
        lblPurchaseInfo.Text = ""
        txtTotal.Clear()
        With lstSection
            .SelectedIndex = -1
            .Focus()
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub TicketSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
