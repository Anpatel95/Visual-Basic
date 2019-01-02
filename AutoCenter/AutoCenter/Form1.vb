Public Class Form1
    'this program will calculate price for the car with additional features in it
    Dim Total As Integer
    Dim Tax As Integer
    Dim Trade As Integer
    Dim Acc As Integer


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        txtSale.Text = FormatCurrency(txtSale.Text, 2)
        Total = FormatCurrency(Total, 2)
        Acc = FormatCurrency(Acc, 2)


        'loop for total
        If chkStero.Checked Then
            Total = Total + 425.76
            Acc = Acc + 425.76
        End If
        If chkLeather.Checked Then
            Total = Total + 987.41
            Acc = Acc + 987.41
        End If
        If chkCom.Checked Then
            Total = Total + 1747.23
            Acc = Acc + 1747.23
        End If

        If rdbPear.Checked = True Then
            Total = Total + 345.72

            Acc = Acc + 345.72
        End If
        If rdbCust.Checked = True Then
            Total = Total + 599.99
            Acc = Acc + 599.99
        End If



        lblSubtotal.Text = Total + txtSale.Text
        lblSubtotal.Text = FormatCurrency(lblSubtotal.Text, 2)


        Tax = lblSubtotal.Text * 0.06
        lblTax.Text = FormatCurrency(Tax, 2)



        lblAcc.Text = Acc
        lblAcc.Text = FormatCurrency(Acc, 2)





        lblTotal.Text = Tax + lblSubtotal.Text
        lblTotal.Text = FormatCurrency(lblTotal.Text, 2)



        If txtTrade.Text = "" Then
            lblAmont.Text = lblTotal.Text
            lblAmont.Text = FormatCurrency(lblAmont.Text, 2)
        Else
            lblAmont.Text = lblTotal.Text - txtTrade.Text
            lblAmont.Text = FormatCurrency(lblAmont.Text, 2)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'clear button will clear all labels and inputs
        'resets the variable
        lblAcc.Text = ""
        lblAmont.Text = ""
        lblSubtotal.Text = ""
        lblTax.Text = ""
        lblTotal.Text = ""

        txtSale.Text = ""
        txtTrade.Text = ""


        Total = 0
        Trade = 0
        Tax = 0
        Acc = 0

        chkCom.Checked = False
        chkLeather.Checked = False
        chkStero.Checked = False


        rdbCust.Checked = False
        rdbPear.Checked = False
        rdbStd.Checked = False


    End Sub
End Class
