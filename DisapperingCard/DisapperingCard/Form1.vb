Public Class Form1

    'this program will disappear any one card that user have selected

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblresult.Visible = False
        pb1.Visible = False
        pb2.Visible = False
        pb3.Visible = False
        pb4.Visible = False
        pb5.Visible = False
        pb6.Visible = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lblIns.Visible = False
        pb1.Visible = True
        pb2.Visible = True
        pb3.Visible = True
        pb4.Visible = True
        pb5.Visible = True
        pb6.Visible = True


        REM for disapper

        pbD1.Visible = False
        pbD2.Visible = False
        pbD3.Visible = False
        pbD4.Visible = False
        pbD5.Visible = False





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        lblresult.Visible = True
        pbD1.Visible = True
        pbD2.Visible = True
        pbD3.Visible = True
        pbD4.Visible = True
        pbD5.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class
