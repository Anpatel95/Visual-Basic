Public Class Form1
    'this program is x-o game, which is programmed by An Patel


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click, Button3.Click,
        Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        sender.Text = Token
        sender.Enabled = False
        CheckWinner()

    End Sub
    Dim Token As Char
    Dim Player As Integer
    Dim Winner As Boolean
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RestartGame()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        REM restart button
        RestartGame()

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        REM quit button
        End
    End Sub
    Private Sub CheckWinner()
        REM chek rows
        TestThreeInARow(Button1, Button2, Button3)
        TestThreeInARow(Button4, Button5, Button6)
        TestThreeInARow(Button7, Button8, Button9)
        REM check colums
        TestThreeInARow(Button1, Button4, Button7)
        TestThreeInARow(Button2, Button5, Button8)
        TestThreeInARow(Button3, Button6, Button9)
        REM check diagonals
        TestThreeInARow(Button1, Button5, Button9)
        TestThreeInARow(Button3, Button5, Button7)
        If Not Winner Then
            NextPlayer()
        End If
    End Sub
    Private Sub TestThreeInARow(ByRef ONE As Button, ByRef TWO As Button, ByRef THREE As Button)
        If ONE.Text.Length + TWO.Text.Length + THREE.Text.Length > 0 And ONE.Text = TWO.Text And TWO.Text = THREE.Text Then
            ONE.BackColor = Color.Yellow
            TWO.BackColor = Color.Yellow
            THREE.BackColor = Color.Yellow
            Winner = True
            DisplayWinner()
        End If


    End Sub
    Private Sub NextPlayer()
        If Player = 1 Then
            Token = "X"
            Player = "2"
        ElseIf Player = 2 Then
            Token = "0"
            Player = 1
        End If
        lblOutput.Text = "Player " & Player & ":'" & Token & "'"

    End Sub
    Private Sub DisplayWinner()
        REM displaywinner message
        lblOutput.Text = "Player '" & Token & "' is the winner!"
        REM disable all the buttons
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False

    End Sub
    Private Sub RestartGame()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        REM clear the button labels
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        REM set the button background colors
        Button1.BackColor = Color.LimeGreen
        Button2.BackColor = Color.LimeGreen
        Button3.BackColor = Color.LimeGreen
        Button4.BackColor = Color.LimeGreen
        Button5.BackColor = Color.LimeGreen
        Button6.BackColor = Color.LimeGreen
        Button7.BackColor = Color.LimeGreen
        Button8.BackColor = Color.LimeGreen
        Button9.BackColor = Color.LimeGreen
        REM SET UP THE NEW GAME
        Winner = False
        Player = 2
        Token = "0"
        NextPlayer()

    End Sub
End Class
