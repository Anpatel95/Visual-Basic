Public Class Form1

#Region "Globals"
    Dim speed As Single = 10 ' Ball Speed
    Dim rndInst As New Random() ' Random instance
    Dim xVel As Single = Math.Cos(rndInst.Next(5, 10)) * speed
    Dim yVel As Single = Math.Sin(rndInst.Next(5, 10)) * speed
    ' The player's scores.
    Dim compScore As Integer = 0
    Dim plrScore As Integer = 0


#End Region



#Region "Move the paddle according to the mouse"
    ' Move the paddle according to the mouse position.
    Private Sub pongMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If e.Y > 5 And e.Y < Me.Height - 40 - paddlePlayer.Height Then _
        paddlePlayer.Location = New Point(paddlePlayer.Location.X, e.Y)

    End Sub
#End Region

#Region "Main Timer"
    Private Sub gameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gameTimer.Tick
        'Set the computer player to move according to the ball's position."
        If gameBall.Location.Y > 5 And gameBall.Location.Y < Me.Height - 40 _
        - paddlePlayer.Height Then _
        paddleComputer.Location = New Point(paddleComputer.Location.X, gameBall.Location.Y)

        ' Move the game ball.
        gameBall.Location = New Point(gameBall.Location.X + xVel, gameBall.Location.Y + yVel)


        ' Check for top wall.
        If gameBall.Location.Y < 0 Then
            gameBall.Location = New Point(gameBall.Location.X, 0)
            yVel = -yVel
        End If

        ' Check for bottom wall.
        If gameBall.Location.Y > Me.Height - gameBall.Size.Height - 45 Then
            gameBall.Location = New Point(gameBall.Location.X, Me.Height - gameBall.Size.Height - 45)
            yVel = -yVel
        End If

        ' Check for left wall.so he can score
        If gameBall.Location.X < 0 Then
            plrScore += 1
            gameBall.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
            plrScoreDraw.Text = Convert.ToString(plrScore)
        End If

        ' Check for right wall. so he can score
        If gameBall.Location.X > Me.Width - gameBall.Size.Width - paddlePlayer.Width Then
            compScore += 1
            gameBall.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
            compScoreDraw.Text = Convert.ToString(compScore)
        End If





        ' Check for player paddle.
        If gameBall.Bounds.IntersectsWith(paddlePlayer.Bounds) Then
            gameBall.Location = New Point(paddlePlayer.Location.X - gameBall.Size.Width, _
            gameBall.Location.Y)
            xVel = -xVel
        End If

        ' Check for computer paddle.
        If gameBall.Bounds.IntersectsWith(paddleComputer.Bounds) Then
            gameBall.Location = New Point(paddleComputer.Location.X + paddleComputer.Size.Width + 1, _
            gameBall.Location.Y)
            xVel = -xVel
        End If







    End Sub
#End Region

    'Keep the paddle and score labels in the correct position when the form is resized."
    Private Sub pongMain_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        paddlePlayer.Location = New Point(Me.Width - 44, paddlePlayer.Location.Y)

    End Sub





    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Windows.Forms.Cursor.Hide()
    End Sub
End Class
