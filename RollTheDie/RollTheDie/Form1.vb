Public Class frmRollDie
    Dim rand As Random
    Dim roll1 As Integer
    Dim roll2 As Integer
    Dim count As Integer
    Dim count2 As Integer
    Dim R1 As Integer
    Dim R2 As Integer
    Dim R3 As Integer
    Dim R4 As Integer
    Dim R5 As Integer
    Dim R6 As Integer
    Dim R10 As Integer

    Private Sub frmRollDie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM initializer the random number genrator
        rand = New Random()
        REM draw intial dice image

    End Sub

    Private Sub btnRoll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoll.Click
        lblOutput12.Text = rand.Next(1, 7)
        roll1 = lblOutput12.Text

        Me.count = (Me.count + 1)
        lblCount.Text = Convert.ToString(Me.count)

        lblOutput12.Text = rand.Next(1, 7)
        roll2 = lblOutput12.Text

        lblOutput12.Text = roll1 + roll2

        REM display the corresponding image (die 1 -6)
        Select Case roll1
            Case 1
                pb1.Image = My.Resources.die1pic

                Me.R1 = (Me.R1 + 1)
                lblOutput13.Text = Convert.ToString(Me.R1)
            Case 2
                pb1.Image = My.Resources.die2pic
                Me.R2 = (Me.R2 + 1)
                lblOutput14.Text = Convert.ToString(Me.R2)
            Case 3
                pb1.Image = My.Resources.die3pic
                Me.R3 = (Me.R3 + 1)
                lblOutput15.Text = Convert.ToString(Me.R3)
            Case 4
                pb1.Image = My.Resources.die4pic
                Me.R4 = (Me.R4 + 1)
                lblOutput16.Text = Convert.ToString(Me.R4)
            Case 5
                pb1.Image = My.Resources.die5pic
                Me.R5 = (Me.R5 + 1)
                lblOutput17.Text = Convert.ToString(Me.R5)
            Case 6
                pb1.Image = My.Resources.die6pic
                Me.R6 = (Me.R6 + 1)
                lblOutput18.Text = Convert.ToString(Me.R6)
               

        End Select
        Select Case roll2
            Case 1
                pb2.Image = My.Resources.die1pic

                Me.R2 = (Me.R1 + 1)
                lblOutput13.Text = Convert.ToString(Me.R1)
            Case 2
                pb2.Image = My.Resources.die2pic
                Me.R2 = (Me.R2 + 1)
                lblOutput14.Text = Convert.ToString(Me.R2)
            Case 3
                pb2.Image = My.Resources.die3pic
                Me.R3 = (Me.R3 + 1)
                lblOutput15.Text = Convert.ToString(Me.R3)
            Case 4
                pb2.Image = My.Resources.die4pic
                Me.R4 = (Me.R4 + 1)
                lblOutput16.Text = Convert.ToString(Me.R4)
            Case 5
                pb2.Image = My.Resources.die5pic
                Me.R5 = (Me.R5 + 1)
                lblOutput17.Text = Convert.ToString(Me.R5)
            Case 6
                pb2.Image = My.Resources.die6pic
                Me.R6 = (Me.R6 + 1)
                lblOutput18.Text = Convert.ToString(Me.R6)
        End Select

        If pb1.Image Is pb2.Image Then
            Me.R10 = (Me.R10 + 1)
            lblOutput30.Text = Convert.ToString(Me.R10)
        End If

    End Sub

   






    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
