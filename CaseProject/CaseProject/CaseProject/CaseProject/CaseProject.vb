Option Explicit On
'An Patel
'Cp 4 SelectCase Project
'CISC 113
'


Public Class CaseProject
    'initialize variables
    Dim Name1 As String
    Dim Pieces As Integer
    Dim AmountEarn As String
    Dim AmountTDisp As Decimal
    Dim CountName As Double
    Dim CountPieces As Double
    Dim CountPay As Double


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click


        If txtName.Text = "" Then

            MessageBox.Show("You have to input Name", "Name Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)

            With txtName
                .Focus()
                .SelectAll()
            End With
        Else
            Name1 = CStr(txtName.Text)

            Try
                Pieces = Integer.Parse(txtNumOfPieces.Text)


                btnSummary.Enabled = True

                Select Case Pieces
                    Case <= 199

                        AmountTDisp = Pieces * 0.5


                    Case <= 400
                        AmountTDisp = Pieces * 0.55

                    Case >= 600
                        AmountTDisp = Pieces * 0.6

                End Select

                CountPay += AmountTDisp
                CountPieces += Pieces
                CountName += 1


                lstName.Items.Add(Name1)
                lstPieces.Items.Add(Pieces)
                lstAmtEarned.Items.Add(AmountTDisp)

                ''finding errors after it.

            Catch Pieces As FormatException
                MessageBox.Show("You have to input numerics for Pieces", "Pieces Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Give message if there is no number in textbox

                With txtNumOfPieces
                    .Focus()
                    .SelectAll()


                End With
            End Try


        End If





    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtNumOfPieces.Text = ""

        Pieces = 0
        AmountTDisp = 0



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        txtAverage.Text = (CountPay / CountName).ToString("C")


        txtTotalpieces.Text = (CountPieces).ToString
        txtTotalpay.Text = CountPay.ToString("C")



    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        txtTotalpay.Text = ""
        txtAverage.Text = ""
        txtName.Text = ""
        txtNumOfPieces.Text = ""
        txtTotalpieces.Text = ""


        Name1 = 0
        Pieces = 0
        AmountEarn = 0
        AmountTDisp = 0
        CountName = 0
        CountPieces = 0
        CountPay = 0


        lstName.Items.Clear()

        lstPieces.Items.Clear()
        lstAmtEarned.Items.Clear()

        btnSummary.Enabled = False

    End Sub

    Private Sub CaseProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnSummary.Enabled = False

    End Sub
End Class
