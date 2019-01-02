Public Class Form1
    'this program is for bob's deli store 
    'it makes the hoogie and shows the price for it

    Dim Price As Double
    Dim Display As String

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSmall.CheckedChanged
        If rdbSmall.Checked = True Then

            Me.Price = Me.Price + 2.5
            lblPrice.Text = FormatCurrency(Price, 2)
        Else
            Me.Price = Me.Price - 2.5
            lblPrice.Text = FormatCurrency(Price, 2)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbLarge.CheckedChanged

        If rdbLarge.Checked = True Then

            Me.Price = Me.Price + 4.0
            lblPrice.Text = FormatCurrency(Price, 2)

        Else
            Me.Price = Me.Price - 4.0
            lblPrice.Text = FormatCurrency(Price, 2)
        End If
       
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLettuce.CheckedChanged

        If chkLettuce.Checked Then
            Me.Price = Me.Price + 0.15
            lblPrice.Text = FormatCurrency(Price, 2)

        Else
            Me.Price = Me.Price - 0.15
            lblPrice.Text = FormatCurrency(Price, 2)
        End If
       
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOnions.CheckedChanged

        If chkOnions.Checked Then
            Me.Price = Me.Price + 0.1
            lblPrice.Text = FormatCurrency(Price, 2)

        Else
            Me.Price = Me.Price - 0.1
            lblPrice.Text = FormatCurrency(Price, 2)
        End If

       
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHot.CheckedChanged
        If chkHot.Checked Then
            Me.Price = Me.Price + 0.25
            lblPrice.Text = FormatCurrency(Price, 2)
        Else
            Me.Price = Me.Price - 0.25
            lblPrice.Text = FormatCurrency(Price, 2)
        End If
        
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTom.CheckedChanged

        Me.Price = Me.Price + 0.25
        lblPrice.Text = FormatCurrency(Price, 2)
    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChee.CheckedChanged
        Me.Price = Me.Price + 0.5
        lblPrice.Text = FormatCurrency(Price, 2)

    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSweet.CheckedChanged
        Me.Price = Me.Price + 0.25
        lblPrice.Text = FormatCurrency(Price, 2)
    End Sub


    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPickles.CheckedChanged
        Me.Price = Me.Price + 0.5
        lblPrice.Text = FormatCurrency(Price, 2)
    End Sub

    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChips.CheckedChanged
        Me.Price = Me.Price + 1.0
        lblPrice.Text = FormatCurrency(Price, 2)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        Display = "Your Order" & vbCrLf


        If rdbLarge.Checked = True Then
            Display = Display & vbCrLf & "Large Hoagie" & vbCrLf
        Else
            Display = Display & vbCrLf & "Small Hoagie" & vbCrLf

        End If
       

        If chkLettuce.Checked Then
            Display = Display & vbCrLf & "Lettuce"
        End If

        If chkOnions.Checked Then
            Display = Display & vbCrLf & "Onion"
        End If
        If chkHot.Checked Then
            Display = Display & vbCrLf & "Hot Pepper"

        End If
        If chkTom.Checked Then

            Display = Display & vbCrLf & "Tomato"
        End If

        If chkChee.Checked Then
            Display = Display & vbCrLf & "Hot Pepper"
        End If

        If chkSweet.Checked Then
            Display = Display & vbCrLf & "Sweet Pepper"
        End If
        If chkMustard.Checked Then
            Display = Display & vbCrLf & "Mustard"
        End If
        If ChkMayo.Checked Then
            Display = Display & vbCrLf & "Mayo"
        End If
        If chkVO.Checked Then
            Display = Display & vbCrLf & "Vineger and Oil"
        End If
        If chkKetch.Checked Then
            Display = Display & vbCrLf & "Ketch"
        End If
        If chkPickles.Checked Then
            Display = Display & vbCrLf & "Pickles"
        End If
        If chkChips.Checked Then
            Display = Display & vbCrLf & "Chips"
        End If
        rtbOrder.Text = Display

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Price = 0
        lblPrice.Text = 0



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
      



       
        rdbLarge.Checked = False
        rdbSmall.Checked = False


        chkLettuce.Checked = False
        chkOnions.Checked = False
        chkHot.Checked = False
        chkTom.Checked = False
        chkChee.Checked = False
        chkSweet.Checked = False
        chkMustard.Checked = False
        ChkMayo.Checked = False
        chkVO.Checked = False
        chkKetch.Checked = False
        chkPickles.Checked = False
        chkChips.Checked = False

        rtbOrder.Text = ""


        Price = 0
        lblPrice.Text = 0


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

    End Sub
End Class
