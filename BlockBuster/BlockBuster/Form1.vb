Public Class lblBLB

    Dim intSpeedX As Integer = 2
    Dim intSpeedy As Integer = -2
    Dim intScore As Integer
    Dim intLives As Integer = 3
    Dim intAllGone As Integer

    Private Sub lblBLB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 20
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        AllGone = 0
        CheckCollisions()
        If AllGone = 1 Then
            Timer1.Enabled = False
            MsgBox("You finished the game!", , "CONGRATULATIONS")
        End If
        BallX += SpeedX
        If BallX < 3 Or BallX + Ball.Width > Me.Width - 5 Then
            SpeedX = -SpeedX

        End If
        BallY += Speedy
        If BallY < 3 Then
            Speedy = -Speedy
        End If
        If BallY + Ball.Height > Me.Height - 5 Then
            Timer1.Enabled = False
            UpdateLives()
            BallX = 232
            BallY = 376
            SpeedX = 2
            Speedy = -2
            If Lives < 1 Then
                MsgBox("You have lost the game", , "OH NO")
            Else
                MsgBox("You missed!", , "OH NO")
                Timer1.Enabled = True
            End If

        End If
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        Paddle.Left = e.X - Paddle.Width \ 2
    End Sub
    Private Sub CheckCollisions()
        CheckCollision(Paddle, False)
        CheckCollision(Block1)
        CheckCollision(Block2)
        CheckCollision(Block3)
        CheckCollision(Block4)
        CheckCollision(Block5)
        CheckCollision(Block6)
        CheckCollision(Block7)
        CheckCollision(Block8)
        CheckCollision(Block9)
        CheckCollision(Block10)
        CheckCollision(Block11)
        CheckCollision(Block12)
        CheckCollision(Block13)
        CheckCollision(Block14)
        CheckCollision(Block15)
        CheckCollision(Block16)
        CheckCollision(Block17)
        CheckCollision(Block18)
        CheckCollision(Block19)
        CheckCollision(Block20)

    End Sub
    Public Sub CheckCollision(ByRef src As PictureBox, ByVal Hide As Boolean)
        If src.Visible = True Then



            If BallX > src.Location.X And _
                BallX < src.Location.X + src.Size.Width And _
                    Ball.Location.Y > src.Location.Y And _
                    Ball.Location.Y < src.Location.Y + src.Size.Height Then
                SpeedY = -SpeedY
                UpdateScore()
                If Hide Then
                    src.Visible = False

                End If
            End If
            AllGone += 1
        End If

    End Sub
    REM declare the overloaded vesion of CheckCollision
    Public Sub CheckCollision(ByVal src As PictureBox)
        REM call the original version
        CheckCollision(src, True)

    End Sub
    Public Sub UpdateScore()
        Score += 10
        lblScore.Text = "SCORE:" & Score
    End Sub
    Public Sub UpdateLives()
        Lives -= 1
        lblLevel.Text = "LIVES:" & Lives

    End Sub
    Public Property BallX() As Integer
        Get
            Return Ball.Left
        End Get
        Set(ByVal value As Integer)
            Ball.Left = value
        End Set
    End Property
    Public Property BallY() As Integer
        Get
            Return Ball.Top
        End Get
        Set(ByVal Value As Integer)
            Ball.Top = Value
        End Set
    End Property
    Public Property Lives() As Integer
        Get
            Return intLives
        End Get
        Set(ByVal Value As Integer)
            intLives = Value

        End Set
    End Property
    Public Property SpeedX() As Integer
        Get
            Return intSpeedX

        End Get
        Set(ByVal Value As Integer)
            intSpeedX = Value

        End Set
    End Property

    Public Property SpeedY() As Integer
        Get
            Return intSpeedy
        End Get
        Set(ByVal value As Integer)
            intSpeedy = value
        End Set
    End Property
    Public Property Score() As Integer
        Get
            Return intScore
        End Get
        Set(ByVal value As Integer)
            intScore = value
        End Set
    End Property

    Public Property AllGone() As Integer
        Get
            Return intAllGone

        End Get
        Set(ByVal value As Integer)
            intAllGone = value
        End Set
    End Property




End Class



