Option Explicit On
'An Patel
'CISC113
'This program will give the recommdation of food by AHA.
'(assingh assignment, page 161 #2)
Public Class Nutrition

    Dim Food As String
    Dim Calories As Integer
    Dim Fat As Integer
    Dim CalFat As Double
    Dim recommedeation As String



    Private Sub btnCalCalories_Click(sender As System.Object, e As System.EventArgs) Handles btnCalCalories.Click


        Food = txtFood.Text

        Try
            Calories = Integer.Parse(txtCalories.Text)
            Try
                Fat = Integer.Parse(txtGramofFat.Text)

                CalFat = ((Fat * 9) / Calories) 'calculate calories per fat


                If CalFat >= 0.3 Then 'gives recommendation of AHA

                    recommedeation = "which is exceeds AHA recommendation"
                Else
                    recommedeation = "which is under AHA recommendation:)"



                End If




                txttotalfat.Text = CalFat
                txttotalfat.Text = Food + " contains " + FormatPercent(CalFat, 2) + " calories from fats, " + recommedeation 'Display the recommendation


            Catch GramOfFat As FormatException 'display the error msg Box
                MessageBox.Show("You have to input numerics for gram of fat", "Total gram of fat Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Give message if there is no number in textbox
                With txtGramofFat ''give focuse and select where is the error
                    .Focus()
                    .SelectAll()


                End With

            End Try
        Catch Calo As FormatException 'display the error msg Box
            MessageBox.Show("You have to input numerics for Calories per Food", "Calories per serving", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Give message if there is no number in textbox
            With txtCalories ''give focuse where is the error
                .Focus()
                .SelectAll()


            End With


        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Food = 0
        CalFat = 0
        Calories = 0
        Fat = 0
        txtCalories.Text = ""
        txtFood.Text = ""
        txtGramofFat.Text = ""
        txttotalfat.Text = ""




    End Sub

    Private Sub Nutrition_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
