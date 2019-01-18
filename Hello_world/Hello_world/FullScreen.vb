Public Class FullScreen

    'Private Sub FullScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Dim PictureBox1 = New PictureBox
    'Location = New Point((Me.Width) / 4, Me.Height - 40 - (3 / 16) * (Me.Width - 20))
    'PictureBox1.Location = Location
    'PictureBox1.Size = New Size(3 * (Me.Width - 20) / 4, 3 * (Me.Width - 20) / 16)
    'PictureBox1.TabIndex = 0
    'PictureBox1.TabStop = False
    'PictureBox1.BorderStyle = BorderStyle.Fixed3D
    'PictureBox1.Anchor = AnchorStyles.Left And AnchorStyles.Right
    'Me.Controls.Add(PictureBox1)
    'PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage

    'End Sub

    Public Sub SetPictureBoxImage(image_path As String)
        resize_image(image_path)

    End Sub

    Private Sub resize_image(ByVal image_path As String)
        Dim fraction As Double
        Dim bmpTemp As Bitmap
        Dim bmp01 As Bitmap
        bmp01 = Image.FromFile(image_path)

        If bmp01.Width > 640 Or bmp01.Height > 480 Then
            
            If (bmp01.Width) / 4 >= (bmp01.Height) / 3 Then
                fraction = 1 / ((bmp01.Width) / 640)
            Else
                fraction = 1 / ((bmp01.Height) / 480)
            End If
            bmpTemp = New Bitmap(bmp01, bmp01.Width * fraction, bmp01.Height * fraction)
            bmpTemp.SetResolution(bmp01.HorizontalResolution, bmp01.VerticalResolution)
            bmp01 = bmpTemp
            PictureBox1.Image = bmp01
            Me.ShowDialog()
            bmp01.Dispose()
        Else
            PictureBox1.Image = bmp01
            Me.ShowDialog()
            bmp01.Dispose()
        End If



    End Sub

   
End Class