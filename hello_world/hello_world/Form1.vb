

Public Class Form1
    Private imageFiles() As String = Nothing
    Dim bmp01, bmp02, bmpTemp As Bitmap
    Dim clr, clrTemp As Color
    Dim intR, intG, intB, intTemp As Integer
    Dim intResponse As Integer



    Dim fraction As Single
    ' Sub is subroutine and doen not return any value


    Private Sub resize_image(ByRef bmp01 As Bitmap)
        'OpenFileDialog1.Filter = "jpeg files|*.jpeg|bitmap files|*.bmp|jpg files|*.jpg|gif files|*.gif"

        'If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
        'bmp01 = New Bitmap(Image.FromFile(string_name))

        If bmp01.Width > 100 Or bmp01.Height > 100 Then
            'intResponse = MsgBox("image is larger than display area. do you want to resize image to fit?", vbYesNo + vbQuestion)
            'End If

            'If intResponse = vbNo Then
            'Exit Sub
            'End If

            'If intResponse = vbYes Then
            'If (bmp01.Width) / 4 >= (bmp01.Height) / 3 Then
            'fraction = 1 / ((bmp01.Width) / 640)
            'Else
            'fraction = 1 / ((bmp01.Height) / 480)
            'End If
            bmpTemp = New Bitmap(bmp01, 100, 100)
            bmpTemp.SetResolution(bmp01.HorizontalResolution, bmp01.VerticalResolution)
            bmp01 = bmpTemp
            'PictureBox1.Image = bmp01
        End If



    End Sub
    Private Sub button1_click(sender As Object, e As EventArgs) Handles Button1.Click
        If imageFolderBrowserDlg.ShowDialog() = DialogResult.OK Then
            Me.imageFiles = GetFiles(Me.imageFolderBrowserDlg.SelectedPath, "*.jpg;*.jpeg;*.png;*.bmp;*.tif;*.tiff;*.gif")
            If Me.imageFiles.Length = 0 Then
                MessageBox.Show("No image can be found")
            Else
                ' show images using graphics and bitmap
                Dim count As Integer

                Dim bm2 = New Bitmap(10, 10)
                Dim image_string1 As String

                Dim XLocation As Integer
                Dim i As Integer

                Dim YLocation As Integer
                XLocation = 365
                YLocation = 20

                For Each image_string As String In imageFiles
                    ' TextBox1.Text &= image_string & Environment.NewLine
                    count += 1
                    image_string1 = image_string
                    DrawPictureBox(image_string, XLocation, YLocation, i)



                Next




            End If
        End If

    End Sub


    Public Sub DrawPictureBox(ByVal string_name As String, ByRef x As Integer, ByRef y As Integer, ByRef i As Integer)
        Dim picBox As New PictureBox
        picBox.Location = New Point(x, y)
        bmp01 = New Bitmap(Image.FromFile(string_name))

        x += 120
        resize_image(bmp01)
        If x + 100 >= 1050 Then
            x = 365
            y = y + 120
        End If


        Dim a As Integer
        Dim b As Integer
        '(a,b) = bmp01.Size()
        a = bmp01.Width
        b = bmp01.Height

        ' Debug.Print(x, y)
        picBox.Name = "PictureBox" & i
        i += 1
        picBox.Size = New Size(100, 100)
        picBox.TabIndex = 0
        picBox.TabStop = False
        picBox.BorderStyle = BorderStyle.Fixed3D
        picBox.ImageLocation = string_name
        Me.Controls.Add(picBox)
        picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage

    End Sub

    Public Shared Function GetFiles(ByVal path As String, ByVal searchPattern As String) As String()
        Dim patterns() As String = searchPattern.Split(";"c)

        Dim files As New List(Of String)()
        For Each filter As String In patterns
            ' Iterate through the directory tree and ignore the  
            ' DirectoryNotFoundException or UnauthorizedAccessException  
            ' exceptions.  
            ' http://msdn.microsoft.com/en-us/library/bb513869.aspx 

            ' Data structure to hold names of subfolders to be 
            ' examined for files. 
            Dim dirs As New Stack(Of String)(20)

            If Not IO.Directory.Exists(path) Then
                Throw New ArgumentException()
            End If
            dirs.Push(path)

            Do While dirs.Count > 0
                Dim currentDir As String = dirs.Pop()
                Dim subDirs() As String
                Try
                    subDirs = IO.Directory.GetDirectories(currentDir)
                    ' An UnauthorizedAccessException exception will be thrown  
                    ' if we do not have discovery permission on a folder or  
                    ' file. It may or may not be acceptable to ignore the  
                    ' exception and continue enumerating the remaining files  
                    ' and folders. It is also possible (but unlikely) that a  
                    ' DirectoryNotFound exception will be raised. This will  
                    ' happen if currentDir has been deleted by another  
                    ' application or thread after our call to Directory.Exists.  
                    ' The choice of which exceptions to catch depends entirely  
                    ' on the specific task you are intending to perform and  
                    ' also on how much you know with certainty about the  
                    ' systems on which this code will run. 
                Catch e1 As UnauthorizedAccessException
                    Continue Do
                Catch e2 As IO.DirectoryNotFoundException
                    Continue Do
                End Try

                Try
                    files.AddRange(IO.Directory.GetFiles(currentDir, filter))
                Catch e3 As UnauthorizedAccessException
                    Continue Do
                Catch e4 As IO.DirectoryNotFoundException
                    Continue Do
                End Try

                ' Push the subdirectories onto the stack for traversal. 
                ' This could also be done before handing the files. 
                For Each str As String In subDirs
                    dirs.Push(str)
                Next str
            Loop
        Next filter

        Return files.ToArray()
    End Function

End Class


' Using g As Graphics = Graphics.FromImage(bm2)
'g.DrawImage(bm2, 0, 0, 10, 10)
'End Using
' PictureBox1.Image = bm

'Using g As Graphics = Graphics.FromImage(PictureBox1)

'End Using