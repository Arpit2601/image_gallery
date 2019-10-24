Public Class Edit

    Dim bmp01, bmp02, bmpTemp, bmp1 As Bitmap
    Dim clr, clrTemp As Color
    Dim intR, intG, intB, intTemp As Integer
    Dim RestoreBitmap As Bitmap
    Dim image_path1 As String

    'This functuion is called when a picture is double clicked in grid view or its name is selected in list view.
    'It loads the image in A Bitmap then checks its size and rescale it in such a way that its aspect ratio is maintained to 4:3
    'It gets path of the image ,which you selected, as its argument

    Public Sub SetPictureBoxImage(ByVal image_path As String)
        Dim fraction As Double          ' fraction is the rescaling factor
        Dim bmpTemp As Bitmap           ' temporary bitmap to store rescaled image
        
        ' getting the image path
        image_path1 = image_path
        Try
            bmp1 = Image.FromFile(image_path)      ' loading the image in bitmap
            'If any dimension is larger then rescale the image
            If bmp1.Width > 640 Or bmp1.Height > 480 Then

                If (bmp1.Width) / 4 >= (bmp1.Height) / 3 Then
                    fraction = 1 / ((bmp1.Width) / 640)
                Else
                    fraction = 1 / ((bmp1.Height) / 480)
                End If
                bmpTemp = New Bitmap(bmp1, bmp1.Width * fraction, bmp1.Height * fraction)
                bmpTemp.SetResolution(bmp1.HorizontalResolution, bmp1.VerticalResolution)
                bmp1 = bmpTemp
                PictureBox1.Image = bmp1
                
                RestoreBitmap = PictureBox1.Image
                Me.ShowDialog()     'Show the edit window after loading the image
                bmp1.Dispose()
            Else
                PictureBox1.Image = bmp1
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                RestoreBitmap = PictureBox1.Image
                Me.ShowDialog()
                bmp1.Dispose()
            End If

            'If the system ran out of memory then message will pop up that "the image can't be loaded"
        Catch ex As System.OutOfMemoryException
            MessageBox.Show("image cannot be loaded")
        Catch ex1 As System.InvalidCastException
            MessageBox.Show("image cannot be saved")
        End Try

    End Sub

    

    'add rotate 90 option also


    ' the mirror image option it changes the flip the image about vertical axis

   
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles cmdMirror.Click
        If PictureBox1.Image Is Nothing Then
            Exit Sub
        End If
        bmp02 = PictureBox1.Image
        bmpTemp = PictureBox1.Image
        For x = 0 To (bmp02.Width / 2) - 1
            For y = 0 To bmp02.Height - 1
                clrTemp = bmp02.GetPixel(x, y)
                clr = bmp02.GetPixel((bmp02.Width - x) - 1, y)
                bmp02.SetPixel(x, y, clr)
                bmp02.SetPixel((bmp02.Width - x) - 1, y, clrTemp)
                bmpTemp.SetPixel(x, y, clr)
                bmpTemp.SetPixel((bmp02.Width - x) - 1, y, clrTemp)
            Next
        Next
        PictureBox1.Image = bmp02
        'trkBrightness.Value = 10
    End Sub

    

    ' this button restores the image as it was


    Private Sub cmdRestore_Click(sender As Object, e As EventArgs) Handles cmdRestore.Click
        Dim fraction As Double          ' fraction is the rescaling factor
        Dim bmpTemp As Bitmap
        Try
            bmp1 = Image.FromFile(image_path1)      ' loading the image in bitmap
            'If any dimension is larger then rescale the image
            If bmp1.Width > 640 Or bmp1.Height > 480 Then

                If (bmp1.Width) / 4 >= (bmp1.Height) / 3 Then
                    fraction = 1 / ((bmp1.Width) / 640)
                Else
                    fraction = 1 / ((bmp1.Height) / 480)
                End If
                bmpTemp = New Bitmap(bmp1, bmp1.Width * fraction, bmp1.Height * fraction)
                bmpTemp.SetResolution(bmp1.HorizontalResolution, bmp1.VerticalResolution)
                bmp1 = bmpTemp
                PictureBox1.Image = bmp1

            Else
                PictureBox1.Image = bmp1

            End If

            'If the system ran out of memory then message will pop up that "the image can't be loaded"
        Catch ex As System.OutOfMemoryException
            MessageBox.Show("image cannot be loaded")
        End Try
    End Sub


    ' this button increases red color quantity of the image

    Private Sub cmdRed_Click(sender As Object, e As EventArgs) Handles cmdRed.Click
        If PictureBox1.Image Is Nothing Then
            Exit Sub
        End If
        bmp02 = PictureBox1.Image
        bmpTemp = PictureBox1.Image
        For x = 0 To bmp02.Width - 1
            For y = 0 To bmp02.Height - 1
                clr = bmp02.GetPixel(x, y)
                clrTemp = Color.FromArgb(clr.R, 0, 0)
                bmp02.SetPixel(x, y, clrTemp)
                bmpTemp.SetPixel(x, y, clrTemp)
            Next
        Next
        PictureBox1.Image = bmp02
        'trkBrightness.Value = 10
    End Sub


    ' this button increases green color quantity of the image

    Private Sub cmdGreen_Click(sender As Object, e As EventArgs) Handles cmdGreen.Click
        If PictureBox1.Image Is Nothing Then
            Exit Sub
        End If
        bmp02 = PictureBox1.Image
        bmpTemp = PictureBox1.Image
        For x = 0 To bmp02.Width - 1
            For y = 0 To bmp02.Height - 1
                clr = bmp02.GetPixel(x, y)
                clrTemp = Color.FromArgb(0, clr.G, 0)
                bmp02.SetPixel(x, y, clrTemp)
                bmpTemp.SetPixel(x, y, clrTemp)
            Next
        Next
        PictureBox1.Image = bmp02
        'trkBrightness.Value = 10
    End Sub


    ' this button increases blue color quantity of the image

    Private Sub cmdBlue_Click(sender As Object, e As EventArgs) Handles cmdBlue.Click
        If PictureBox1.Image Is Nothing Then
            Exit Sub
        End If
        bmp02 = PictureBox1.Image
        bmpTemp = PictureBox1.Image
        For x = 0 To bmp02.Width - 1
            For y = 0 To bmp02.Height - 1
                clr = bmp02.GetPixel(x, y)
                clrTemp = Color.FromArgb(0, 0, clr.B)
                bmp02.SetPixel(x, y, clrTemp)
                bmpTemp.SetPixel(x, y, clrTemp)
            Next
        Next
        PictureBox1.Image = bmp02
        'trkBrightness.Value = 10
    End Sub


    ' this button increases grey color quantity of the image

    Private Sub cmdGrey_Click(sender As Object, e As EventArgs) Handles cmdGrey.Click
        If PictureBox1.Image Is Nothing Then
            Exit Sub
        End If
        bmp02 = PictureBox1.Image
        bmpTemp = PictureBox1.Image
        For x = 0 To bmp02.Width - 1
            For y = 0 To bmp02.Height - 1
                clr = bmp02.GetPixel(x, y)
                intR = clr.R
                intG = clr.G
                intB = clr.B
                intTemp = (intR + intG + intB) / 3
                clrTemp = Color.FromArgb(intTemp, intTemp, intTemp)
                bmp02.SetPixel(x, y, clrTemp)
                bmpTemp.SetPixel(x, y, clrTemp)
            Next
        Next
        PictureBox1.Image = bmp02
        'trkBrightness.Value = 10
    End Sub


    ' this button turns image into negative

    Private Sub cmdNeg_Click(sender As Object, e As EventArgs) Handles cmdNegative.Click
        If PictureBox1.Image Is Nothing Then
            Exit Sub
        End If
        bmp02 = PictureBox1.Image
        bmpTemp = PictureBox1.Image
        For x = 0 To bmp02.Width - 1
            For y = 0 To bmp02.Height - 1
                clr = bmp02.GetPixel(x, y)
                clrTemp = Color.FromArgb(255 - clr.R, 255 - clr.G, 255 - clr.B)
                bmp02.SetPixel(x, y, clrTemp)
                bmpTemp.SetPixel(x, y, clrTemp)
            Next
        Next
        PictureBox1.Image = bmp02
        'trkBrightness.Value = 10
    End Sub

    ' this button increases sepia color quantity of the image

    Private Sub cmdSepia_Click(sender As Object, e As EventArgs) Handles cmdSepia.Click
        If PictureBox1.Image Is Nothing Then
            Exit Sub
        End If
        bmp02 = PictureBox1.Image
        bmpTemp = PictureBox1.Image
        For x = 0 To bmp02.Width - 1
            For y = 0 To bmp02.Height - 1
                clr = bmp02.GetPixel(x, y)
                intR = (clr.R * 0.393) + (clr.G * 0.769) + (clr.B * 0.189)
                intG = (clr.R * 0.349) + (clr.G * 0.686) + (clr.B * 0.168)
                intB = (clr.R * 0.272) + (clr.G * 0.534) + (clr.B * 0.131)
                If intR > 255.0 Then intR = 255.0
                If intG > 255.0 Then intG = 255.0
                If intB > 255.0 Then intB = 255.0
                clrTemp = Color.FromArgb(Int(intR), Int(intG), Int(intB))
                bmp02.SetPixel(x, y, clrTemp)
                bmpTemp.SetPixel(x, y, clrTemp)
            Next
        Next
        PictureBox1.Image = bmp02
        'trkBrightness.Value = 10
    End Sub


    ' this button turns image into mono

    Private Sub cmdMono_Click(sender As Object, e As EventArgs) Handles cmdMono.Click
        If PictureBox1.Image Is Nothing Then
            Exit Sub
        End If
        bmp02 = PictureBox1.Image
        bmpTemp = PictureBox1.Image
        For x = 0 To bmp02.Width - 1
            For y = 0 To bmp02.Height - 1
                clr = bmp02.GetPixel(x, y)
                intR = clr.R
                intG = clr.G
                intB = clr.B
                intTemp = (intR + intG + intB) / 3
                If intTemp < 64 Then
                    clrTemp = Color.Black
                    bmp02.SetPixel(x, y, clrTemp)
                    bmpTemp.SetPixel(x, y, clrTemp)
                Else
                    clrTemp = Color.White
                    bmp02.SetPixel(x, y, clrTemp)
                    bmpTemp.SetPixel(x, y, clrTemp)
                End If
            Next
        Next
        PictureBox1.Image = bmp02
        'trkBrightness.Value = 10
    End Sub

    Private Sub cmdFlip_Click(sender As Object, e As EventArgs) Handles cmdFlip.Click
        If PictureBox1.Image Is Nothing Then
            Exit Sub
        End If
        bmp02 = PictureBox1.Image
        bmpTemp = PictureBox1.Image
        For x = 0 To bmp02.Width - 1
            For y = 0 To (bmp02.Height / 2) - 1
                clrTemp = bmp02.GetPixel(x, y)
                clr = bmp02.GetPixel(x, (bmp02.Height - y) - 1)
                bmp02.SetPixel(x, y, clr)
                bmp02.SetPixel(x, (bmp02.Height - y) - 1, clrTemp)
                bmpTemp.SetPixel(x, y, clr)
                bmpTemp.SetPixel(x, (bmp02.Height - y) - 1, clrTemp)
            Next
        Next
        PictureBox1.Image = bmp02
        'trkBrightness.Value = 10
    End Sub

    Private Sub cmdRotate180_Click(sender As Object, e As EventArgs) Handles cmdRotate.Click
        If PictureBox1.Image Is Nothing Then
            Exit Sub
        End If
        bmp02 = PictureBox1.Image
        bmpTemp = PictureBox1.Image
        For x = 0 To bmp02.Width - 1
            For y = 0 To (bmp02.Height / 2) - 1
                clrTemp = bmp02.GetPixel(x, y)
                clr = bmp02.GetPixel((bmp02.Width - x) - 1, (bmp02.Height - y) - 1)
                bmp02.SetPixel(x, y, clr)
                bmp02.SetPixel((bmp02.Width - x) - 1, (bmp02.Height - y) - 1, clrTemp)
                bmpTemp.SetPixel(x, y, clr)
                bmpTemp.SetPixel((bmp02.Width - x) - 1, (bmp02.Height - y) - 1, clrTemp)
            Next
        Next
        PictureBox1.Image = bmp02

    End Sub


    'Private Sub saveButton_click(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles saveButton.Click
    '    SaveFileDialog1.Filter = "Bitmap Files|*.bmp|JPEG Files|*.jpg|GIF Files|*.gif|PNG Files|*.png"
    '    MessageBox.Show("Sfd")
    '    If SaveFileDialog1.ShowDialog = DialogResult.OK Then
    '        If SaveFileDialog1.FilterIndex = 1 Then
    '            PictureBox1.Image.Save(SaveFileDialog1.FileName, _
    '              Drawing.Imaging.ImageFormat.Bmp)
    '        ElseIf SaveFileDialog1.FilterIndex = 2 Then
    '            PictureBox1.Image.Save(SaveFileDialog1.FileName, _
    '              Drawing.Imaging.ImageFormat.Jpeg)
    '        ElseIf SaveFileDialog1.FilterIndex = 3 Then
    '            PictureBox1.Image.Save(SaveFileDialog1.FileName, _
    '              Drawing.Imaging.ImageFormat.Gif)
    '        ElseIf SaveFileDialog1.FilterIndex = 4 Then
    '            PictureBox1.Image.Save(SaveFileDialog1.FileName, _
    '              Drawing.Imaging.ImageFormat.Png)
    '        End If
    '    End If
    'End Sub

End Class
