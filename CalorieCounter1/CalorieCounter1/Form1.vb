Public Class Form1

    'this program will calulate calories in the food item using fat, carb, and protein
    Dim fat As Integer
    Dim Carb As Integer
    Dim Pro As Integer
    Dim total As Integer

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        Me.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        fat = txtGramOfF.Text * 9
        Carb = txtGramOfC.Text * 4
        Pro = txtGramOfProtien.Text * 4



        total = fat + Carb + Pro
        lblOutput.Text = total

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        lblOutput.Text = ""
        txtGramOfF.Text = ""
        txtGramOfC.Text = ""
        txtGramOfProtien.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
