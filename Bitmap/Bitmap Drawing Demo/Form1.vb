Public Class Form1

    Public surface As Bitmap
    Public device As Graphics
    Public planet As Bitmap

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        REM set up the form
        Me.Text = "Bitmap Drawing Demo"
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False

        REM create graphics device
        surface = New Bitmap(Me.Size.Width, Me.Size.Height)
        PictureBox1.Image = surface
        device = Graphics.FromImage(surface)

        REM load the bitmap
        planet = New Bitmap("planet.bmp")

        REM draw the bitmap 
        device.DrawImage(planet, 10, 10)

    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.FormClosedEventArgs) _
        Handles Me.FormClosed
        device.Dispose()
        surface.Dispose()
        planet.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        planet.RotateFlip(RotateFlipType.Rotate180FlipNone)
        device.DrawImage(planet, 10, 10)
        PictureBox1.Image = surface
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        planet.RotateFlip(RotateFlipType.Rotate90FlipNone)
        device.DrawImage(planet, 10, 10)
        PictureBox1.Image = surface
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        planet.RotateFlip(RotateFlipType.Rotate270FlipNone)
        device.DrawImage(planet, 10, 10)
        PictureBox1.Image = surface
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        planet.RotateFlip(RotateFlipType.RotateNoneFlipX)
        device.DrawImage(planet, 10, 10)
        PictureBox1.Image = surface
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        planet.RotateFlip(RotateFlipType.RotateNoneFlipY)
        device.DrawImage(planet, 10, 10)
        PictureBox1.Image = surface
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        planet.RotateFlip(RotateFlipType.RotateNoneFlipXY)
        device.DrawImage(planet, 10, 10)
        PictureBox1.Image = surface
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        For x = 0 To planet.Width - 1 Step 2
            For y = 0 To planet.Height - 1 Step 2
                Dim newColor As Color = Color.FromArgb(0, 0, 0)
                planet.SetPixel(x, y, newColor)
            Next
        Next
        device.DrawImage(planet, 10, 10)
        PictureBox1.Image = surface
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        For x = 0 To planet.Width - 1
            For y = 0 To planet.Height - 1
                Dim pixelColor As Color = planet.GetPixel(x, y)
                Dim newColor As Color = Color.FromArgb(0, pixelColor.G, 0)
                planet.SetPixel(x, y, newColor)
            Next
        Next
        device.DrawImage(planet, 10, 10)
        PictureBox1.Image = surface
    End Sub
End Class
