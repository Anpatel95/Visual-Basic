Public Class frmTraffic

  

    Private Sub txtOne_Leave(sender As System.Object, e As System.EventArgs) Handles txtOne.Leave
        txtOne.BackColor = Color.LightGreen 'txt one will be i green

        If txtOne.BackColor = Color.LightGreen Then
            txtTwo.BackColor = Color.Gray       'txt two will be in Gray
            txtThree.BackColor = Color.Gray     'txt three will be in fray
        End If
    End Sub




    Private Sub txtTwo_Leave(sender As System.Object, e As System.EventArgs) Handles txtTwo.Leave
        txtTwo.BackColor = Color.Orange             'txt two will be in Orange


        If txtTwo.BackColor = Color.Orange Then
            txtOne.BackColor = Color.Gray           'txt one will be in Gray
            txtThree.BackColor = Color.Gray         'txt three will be in Gray
        End If
    End Sub





    Private Sub txtThree_TextLeave(sender As System.Object, e As System.EventArgs) Handles txtThree.Leave

        txtThree.BackColor = Color.Red   'txt Three will be in Red

        If txtThree.BackColor = Color.Red Then
            txtTwo.BackColor = Color.Gray       'txt two will be in Gray
            txtOne.BackColor = Color.Gray       'txt one will be in Gray
        End If


    End Sub

    Private Sub frmTraffic_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        txtTwo.Select()      'It will first select TextBox 2 for orange color. 



    End Sub
End Class
