Public Class own_gallery
    Dim bmp01, bmp02, bmpTemp As Bitmap
    Dim clr, clrTemp As Color
    Dim intR, intG, intB, intTemp As Integer

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles cmdMirror.Click
        If picDisplay.Image Is Nothing Then
            Exit Sub
        End If
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
        picDisplay.Image = bmp02
        trkBrightness.Value = 10
    End Sub

    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click
        Dim intResponse As Integer
        Dim sngMul As Single

        ofdLoadImage.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png|BMP|*.bmp|TIF|*.tif|TIFF|*.tiff|GIF|*.gif|GIF|*.GIF"
        If ofdLoadImage.ShowDialog = DialogResult.OK Then
            bmp01 = New Bitmap(Image.FromFile(ofdLoadImage.FileName))
            If bmp01.Width > 919 Or bmp01.Height > 459 Then
                intResponse = MsgBox _
            ("Image is larger than display area. Do you want to resize image to fit?", _
            vbYesNo + vbQuestion)
            End If
            If intResponse = vbNo Then
                Exit Sub
            ElseIf intResponse = vbYes Then
                If (bmp01.Width / 4) >= (bmp01.Height / 3) Then
                    sngMul = 1 / (bmp01.Width / 640)
                Else
                    sngMul = 1 / (bmp01.Height / 480)
                End If
                bmpTemp = New Bitmap(bmp01, (bmp01.Width * sngMul), (bmp01.Height * sngMul))
                bmpTemp.SetResolution(bmp01.HorizontalResolution, bmp01.VerticalResolution)
                bmp01 = bmpTemp
            End If
            bmp02 = New Bitmap(bmp01)
            bmpTemp = New Bitmap(bmp01)
            picDisplay.Image = bmp01
            Me.Text = "ImageStudio(" & ofdLoadImage.FileName & ")"
        End If
    End Sub

    Private Sub cmdRestore_Click(sender As Object, e As EventArgs) Handles cmdRestore.Click
        picDisplay.Image = bmp01
        bmp02 = New Bitmap(bmp01)
        bmpTemp = New Bitmap(bmp01)
        trkBrightness.Value = 10
    End Sub
    Private Sub picOriginal_MouseMove(sender As Object, e As  _
    Windows.Forms.MouseEventArgs) Handles picDisplay.MouseMove
        If picDisplay.Image Is Nothing Then
            Exit Sub
        End If
        If e.X < bmp02.Width And e.Y < bmp02.Height Then
            clr = bmp02.GetPixel(e.X, e.Y)
            lbl_xyR.Text = clr.R
            lbl_xyB.Text = clr.G
            lbl_xyB.Text = clr.B
        Else
            lbl_xyR.Text = ""
            lbl_xyB.Text = ""
            lbl_xyB.Text = ""
        End If
    End Sub
    Private Sub picOriginal_MouseLeave(sender As Object, e As EventArgs) _
    Handles picDisplay.MouseLeave
        lbl_xyR.Text = ""
        lbl_xyB.Text = ""
        lbl_xyB.Text = ""
    End Sub

    Private Sub cmdRed_Click(sender As Object, e As EventArgs) Handles cmdRed.Click
        If picDisplay.Image Is Nothing Then
            Exit Sub
        End If
        For x = 0 To bmp02.Width - 1
            For y = 0 To bmp02.Height - 1
                clr = bmp02.GetPixel(x, y)
                clrTemp = Color.FromArgb(clr.R, 0, 0)
                bmp02.SetPixel(x, y, clrTemp)
                bmpTemp.SetPixel(x, y, clrTemp)
            Next
        Next
        picDisplay.Image = bmp02
        trkBrightness.Value = 10
    End Sub

    Private Sub cmdGreen_Click(sender As Object, e As EventArgs) Handles cmdGreen.Click
        If picDisplay.Image Is Nothing Then
            Exit Sub
        End If
        For x = 0 To bmp02.Width - 1
            For y = 0 To bmp02.Height - 1
                clr = bmp02.GetPixel(x, y)
                clrTemp = Color.FromArgb(0, clr.G, 0)
                bmp02.SetPixel(x, y, clrTemp)
                bmpTemp.SetPixel(x, y, clrTemp)
            Next
        Next
        picDisplay.Image = bmp02
        trkBrightness.Value = 10
    End Sub

    Private Sub cmdBlue_Click(sender As Object, e As EventArgs) Handles cmdBlue.Click
        If picDisplay.Image Is Nothing Then
            Exit Sub
        End If
        For x = 0 To bmp02.Width - 1
            For y = 0 To bmp02.Height - 1
                clr = bmp02.GetPixel(x, y)
                clrTemp = Color.FromArgb(0, 0, clr.B)
                bmp02.SetPixel(x, y, clrTemp)
                bmpTemp.SetPixel(x, y, clrTemp)
            Next
        Next
        picDisplay.Image = bmp02
        trkBrightness.Value = 10
    End Sub

    Private Sub cmdGrey_Click(sender As Object, e As EventArgs) Handles cmdGrey.Click
        If picDisplay.Image Is Nothing Then
            Exit Sub
        End If
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
        picDisplay.Image = bmp02
        trkBrightness.Value = 10
    End Sub

    Private Sub cmdNeg_Click(sender As Object, e As EventArgs) Handles cmdNeg.Click
        If picDisplay.Image Is Nothing Then
            Exit Sub
        End If
        For x = 0 To bmp02.Width - 1
            For y = 0 To bmp02.Height - 1
                clr = bmp02.GetPixel(x, y)
                clrTemp = Color.FromArgb(255 - clr.R, 255 - clr.G, 255 - clr.B)
                bmp02.SetPixel(x, y, clrTemp)
                bmpTemp.SetPixel(x, y, clrTemp)
            Next
        Next
        picDisplay.Image = bmp02
        trkBrightness.Value = 10
    End Sub

    Private Sub cmdSepia_Click(sender As Object, e As EventArgs) Handles cmdSepia.Click
        If picDisplay.Image Is Nothing Then
            Exit Sub
        End If
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
        picDisplay.Image = bmp02
        trkBrightness.Value = 10
    End Sub

    Private Sub cmdMono_Click(sender As Object, e As EventArgs) Handles cmdMono.Click
        If picDisplay.Image Is Nothing Then
            Exit Sub
        End If
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
        picDisplay.Image = bmp02
        trkBrightness.Value = 10
    End Sub

    Private Sub cmdFlip_Click(sender As Object, e As EventArgs) Handles cmdFlip.Click
        If picDisplay.Image Is Nothing Then
            Exit Sub
        End If
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
        picDisplay.Image = bmp02
        trkBrightness.Value = 10
    End Sub

    Private Sub cmdRotate180_Click(sender As Object, e As EventArgs) Handles cmdRotate180.Click
        If picDisplay.Image Is Nothing Then
            Exit Sub
        End If
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
        picDisplay.Image = bmp02
        trkBrightness.Value = 10
    End Sub

    Private Sub trkBrightness_Scroll(sender As Object, e As EventArgs) Handles trkBrightness.Scroll
        If picDisplay.Image Is Nothing Then
            Exit Sub
        End If
        intTemp = trkBrightness.Value * 10
        For x = 0 To bmpTemp.Width - 1
            For y = 0 To bmpTemp.Height - 1
                clr = bmpTemp.GetPixel(x, y)
                intR = clr.R * intTemp / 100
                intG = clr.G * intTemp / 100
                intB = clr.B * intTemp / 100
                If intR > 255 Then intR = 255
                If intG > 255 Then intG = 255
                If intB > 255 Then intB = 255
                If intR < 0 Then intR = 0
                If intG < 0 Then intG = 0
                If intB < 0 Then intB = 0
                clrTemp = Color.FromArgb(Int(intR), Int(intG), Int(intB))
                bmp02.SetPixel(x, y, clrTemp)
            Next
        Next
        picDisplay.Image = bmp02
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        sfdSaveImage.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png|BMP|*.bmp|TIF|*.tif|TIFF|*.tiff|GIF|*.gif|GIF|*.GIF"
        If sfdSaveImage.ShowDialog = DialogResult.OK Then
            If sfdSaveImage.FilterIndex = 1 Then
                picDisplay.Image.Save(sfdSaveImage.FileName, _
                  Drawing.Imaging.ImageFormat.Bmp)
            ElseIf sfdSaveImage.FilterIndex = 2 Then
                picDisplay.Image.Save(sfdSaveImage.FileName, _
                  Drawing.Imaging.ImageFormat.Jpeg)
            ElseIf sfdSaveImage.FilterIndex = 3 Then
                picDisplay.Image.Save(sfdSaveImage.FileName, _
                  Drawing.Imaging.ImageFormat.Gif)
            End If
            MessageBox.Show("Image Saved")
        End If
    
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        End
    End Sub

    

End Class
