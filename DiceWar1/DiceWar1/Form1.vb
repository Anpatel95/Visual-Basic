Public Class frmDiceWar1
    'dice program will randomly throw dice for the player and decide who will win
    Dim Player As Integer = 1
    Dim Round As Integer = 1
    Dim Roll1 As Integer = 1
    Dim Roll2 As Integer = 3
    Dim Rolls As Integer
    Dim Score1 As Integer
    Dim Score2 As Integer
    Dim rand As Random

    Private Sub frmDiceWar1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM initializer the random number genrator
        rand = New Random()
        REM draw intial dice image


        pb1.Image = Die6.Image
        pb2.Image = Die6.Image
    End Sub
    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        REM this event handles Restart as well as Rol
        If btnRestart.Text = "Restart" Then
            RestartGame()
        Else
            REM disable the Roll button 
            btnRestart.Enabled = False
            REM start the rolling dice
            Timer1.Enabled = True



        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        REM roll both dice 
        RollDie1()
        RollDie2()
        REM increment the roll counter
        Rolls += 1
        REM stop after 30 rolls (3 seconds)
        If RollOver() Then
            REM reset roll counter
            Rolls = 0
            REM disable the rolling dice
            Timer1.Enabled = False
            REM disable the Roll button 
            btnRestart.Enabled = True
            REM display the dice roll for this player
            DisplayRoll(Player)
            REM check for game over
            If GameOver() Then
                btnRestart.Text = "Restart"
                ShowWinner()
            Else
                REM not end of game, go to the next round
                lblOutput5.Text = "Round " & Round
            End If
        End If
    End Sub

    Private Sub RestartGame()
        REM reset the game setting
        btnRestart.Text = "Player 1 - Roll"
        Score1 = 0
        Score2 = 0
        lblOutput4.Text = "SCORE: " & Score1
        lblOutput3.Text = "SCORE: " & Score2
        Round = 1
        lblOutput5.Text = "Round " & Round
        pb1.Image = Die6.Image
        pb2.Image = Die6.Image
    End Sub

    Private Sub RollDie1()
        REM GENRATE RANDOM ROLL FOR DIE 1
        Roll1 = rand.Next(1, 6)
        REM display the corresponding image (die 1 -6)
        Select Case Roll1
            Case 1
                pb1.Image = Die1.Image
            Case 2
                pb1.Image = Die2.Image
            Case 3
                pb1.Image = Die3.Image
            Case 4
                pb1.Image = Die4.Image
            Case 5
                pb1.Image = Die5.Image
            Case 6
                pb1.Image = Die6.Image

        End Select
    End Sub

    Private Sub RollDie2()
        REM genrate random roll for die 2
        Roll2 = rand.Next(1, 6)
        REM display the corresponding image (die 1-6)
        Select Case Roll2
            Case 1
                pb2.Image = Die1.Image
            Case 2
                pb2.Image = Die2.Image
            Case 3
                pb2.Image = Die3.Image
            Case 4
                pb2.Image = Die4.Image
            Case 5
                pb2.Image = Die5.Image
            Case 6
                pb2.Image = Die6.Image
        End Select
    End Sub

    Private Function RollOver() As Boolean
        If Rolls > 30 Then
            RollOver = True
        Else
            RollOver = False

        End If
    End Function

    Private Sub DisplayRoll(ByVal PlayerNum As Integer)
        REM dispaly total roll message depending on player
        Select Case PlayerNum
            Case 1
                REM give playe 1's score 
                MsgBox("Player 1, you rolled a " & CInt(Roll1 + Roll2) & ".")
                Score1 += Roll1 + Roll2
                lblOutput4.Text = "SCORE:" & Score1
                REM reset for player 2
                btnRestart.Text = "Player 2 - Roll"
                Player = 2
            Case 2
                REM give player 2's score
                MsgBox("Player 2, you rolled a " & CInt(Roll1 + Roll2) & ".")
                Score2 += Roll1 + Roll2
                lblOutput3.Text = "SCORE:" & Score2
                REM reset for palyer 1
                btnRestart.Text = "Player1 - Roll"
                Player = 1
                REM player 2 marks end of each round
                Round += 1
            Case Else
                MsgBox("PlayerNum is invalid")

        End Select
    End Sub



    Private Function GameOver() As Boolean
        If Round > 3 Then
            GameOver = True
        Else
            GameOver = False
        End If
    End Function
    Private Sub ShowWinner()
        REM display the winner message
        If Score1 = Score2 Then
            MsgBox("This game is dra!")
        ElseIf Score1 > Score2 Then
            MsgBox("Player 1 is the winner!")
        ElseIf Score1 < Score2 Then
            MsgBox("Player 2 is the winner!")
        End If
    End Sub



End Class





