Public Class frmInstructor
    'just testing program for labels

    Private Sub frmInstructor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblDisplay.Text = "Enter your full name" 'ask you to write your full name

    End Sub



    Private Sub txtName_Leave(sender As System.Object, e As System.EventArgs) Handles txtName.Leave

        lblDisplay.Text = "Enter your phone number, including area code" 'It will ask you for phone number


    End Sub
End Class
