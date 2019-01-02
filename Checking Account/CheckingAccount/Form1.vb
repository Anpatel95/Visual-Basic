Public Class Form1

    'this program will have bank account summary, user can deposit or withdrawn money from the his account
    Dim bala As Integer
    Dim bala2 As Integer
    Dim Chek3 As Integer
    Dim Dipo3 As Integer
    Dim ser3 As Integer
    Dim numofdepo As Integer
    Dim numofchek As Integer
    Dim numofser As Integer





    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCal.Click


        'Depo
        If rdbDepo.Checked Then


            bala = Convert.ToInt16(txtInput.Text)

            lblBala.Text = bala
            bala2 += bala
            lblBala.Text = "$ " & "" & bala2

            Dipo3 = bala2
            Me.numofdepo = Me.numofdepo + 1




            ''Check
        ElseIf rdbCheck.Checked Then


            If txtInput.Text > bala2 Then

                MsgBox("Insufficent Fund:$ 10 Service Charge")
                bala2 -= 10
                lblBala.Text = "$ " & "" & bala2
                ''summy
                Me.numofser = Me.numofser + 1
                ser3 += 10

            ElseIf bala2 > bala Then




                bala = Convert.ToInt16(txtInput.Text)

                lblBala.Text = bala

                bala2 -= bala

                lblBala.Text = "$ " & "" & bala2

            ElseIf txtInput.Text = bala2 Then

                bala = Convert.ToInt16(txtInput.Text)

                lblBala.Text = bala

                bala2 -= bala

                lblBala.Text = "$ " & "" & bala2



            ElseIf bala2 > bala Then


                MsgBox("Insufficent Fund:$ 10 Service Charge")
                bala2 -= 10
                lblBala.Text = "$ " & "" & bala2
                ''Summy
                Me.numofser = Me.numofser + 1
                ser3 += 10
            End If





            Chek3 = bala + Chek3
            Me.numofchek = Me.numofchek + 1



            'Service charge
        ElseIf rdbser.Checked Then





            If bala2 > bala Then
                MsgBox("Insufficient Funds: $10.00 Service Charge")

                bala2 -= 10
                lblBala.Text = "$ " & "" & bala2

                ''Summy
                Me.numofser = Me.numofser + 1
                ser3 += 10

            ElseIf lblBala.Text = 0 And rdbser.Checked Then
                bala = Convert.ToInt16(txtInput.Text)

                lblBala.Text = bala
                bala2 += bala
                lblBala.Text = "$ " & "" & bala2
            Else
                bala = Convert.ToInt16(txtInput.Text)

                lblBala.Text = bala
                bala2 -= bala
                lblBala.Text = "$ " & "" & bala2

            End If
            ser3 = bala + ser3
            Me.numofser = Me.numofser + 1


            ''Msg Box


        Else

            MsgBox("Please Select Deposit, Check, or Service Charge")

        End If






    End Sub

    Private Sub btnSumm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumm.Click

        MsgBox("Total Number of Deposit :" & "" & numofdepo & vbCrLf & "Total Amount of Deposit:" & "" & Dipo3 & vbCrLf & "Total Number of Check:" & "" & numofchek & vbCrLf & "Total Amount of Check:" & "" & Chek3 & vbCrLf & "Total Number of Service Charge:" & "" & numofser & vbCrLf & "Total Amount of Service Charge:" & "" & ser3)


    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click


        txtInput.Text = ""
        lblBala.Text = ""

        bala = 0
        bala2 = 0

        Chek3 = 0
        Dipo3 = 0
        ser3 = 0
        numofdepo = 0
        numofchek = 0
        numofser = 0

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
