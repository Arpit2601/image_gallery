Public Class FullScreen

    

    

    Public Sub SetPictureBoxImage(ByVal image_path As String)
        Dim fraction As Double
        Dim bmpTemp As Bitmap
        Dim bmp01 As Bitmap

        Try
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
        Catch ex As System.OutOfMemoryException
            MessageBox.Show("image cannot be loaded")
        End Try

    End Sub

   
End Class