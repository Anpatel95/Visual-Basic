Option Explicit On
Public Class frmChange

    'An Patel
    'CISC 110
    'program of change
    'page 102 #3
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim Qut As Double   'Quater
        Dim Nickels As Integer ' Nickels
        Dim Dime As Integer 'Dimes
        Dim cents As Integer ' Cents
        Dim IntPennys As String 'pennys that you have

        Dim RemainingCoins1, RemainingCoins2, RemainingCoins3 As Integer 'Remaining pennys after calculating quaters, dimes, and nickel


        IntPennys = txtIntChange.Text   'set varliabel to inputed pennies



        Qut = IntPennys \ 25
        RemainingCoins1 = IntPennys Mod 25 'Remaining Coins

        Dime = RemainingCoins1 \ 10
        RemainingCoins2 = RemainingCoins1 Mod 10 'Remaining Coins

        Nickels = RemainingCoins2 \ 5
        RemainingCoins3 = RemainingCoins2 Mod 5  'Remaining Coins

        cents = RemainingCoins3 Mod 5 'Remaining Coins

        txtQut.Text = Qut  'Display Qutars
        txtDimes.Text = Dime  'Display Dimes
        txtNickels.Text = Nickels 'Display Nickels
        txtCents.Text = cents 'Display Pennys

    End Sub

    Private Sub frmChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
