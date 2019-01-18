

Public Class Form1
    Private imageFiles() As String = Nothing
    Dim bmp01, bmp02, bmpTemp As Bitmap
    Dim picBox As New PictureBox
    Dim textBox As New TextBox

    Private Sub resize_image(ByRef bmp01 As Bitmap)
        If bmp01.Width > 150 Or bmp01.Height > 150 Then
            bmpTemp = New Bitmap(bmp01, 150, 150)
            bmpTemp.SetResolution(bmp01.HorizontalResolution, bmp01.VerticalResolution)
            bmp01 = bmpTemp
        End If



    End Sub
    Private Sub button1_click(sender As Object, e As EventArgs) Handles Button1.Click
        If imageFolderBrowserDlg.ShowDialog() = DialogResult.OK Then
            Me.imageFiles = GetFiles(Me.imageFolderBrowserDlg.SelectedPath, "*.jpg;*.jpeg;*.png;*.bmp;*.tif;*.tiff;*.gif")
            If Me.imageFiles.Length = 0 Then
                MessageBox.Show("No image can be found")
            Else



                Dim bm2 = New Bitmap(10, 10)
                Dim image_string1 As String

                Dim XLocation As Integer
                Dim i As Integer

                Dim YLocation As Integer
                XLocation = 20
                YLocation = 185

                For Each image_string As String In imageFiles


                    image_string1 = image_string
                    DrawPictureBox(image_string, XLocation, YLocation, i)
                Next
            End If
        End If

    End Sub


    Public Sub DrawPictureBox(ByVal string_name As String, ByRef x As Integer, ByRef y As Integer, ByRef i As Integer)
        Dim picBox As New PictureBox
        picBox.Location = New Point(x, y)
        Try
            bmp01 = Image.FromFile(string_name) ' add system.memorylimitexceeded exception
        Catch e As System.OutOfMemoryException
            Console.WriteLine("out of memory")
        End Try


        Dim textBox As New TextBox
        textBox.Location = New Point(x, y + 155)
        x += 170
        resize_image(bmp01)
        If x + 150 >= Me.Width Then
            x = 30
            y = y + 195
        End If

        Dim picture_name As String = System.IO.Path.GetFileName(string_name)
        textBox.Name = "TextBox" & i
        textBox.Size = New Size(150, 20)
        textBox.Text = picture_name
        textBox.BackColor = Me.BackColor
        textBox.BorderStyle = BorderStyle.None
        textBox.ReadOnly = True
        textBox.Anchor = AnchorStyles.Left And AnchorStyles.Right
        Me.Controls.Add(textBox)


        picBox.Name = "PictureBox" & i
        i += 1
        picBox.Size = New Size(150, 150)
        picBox.TabIndex = 0
        picBox.TabStop = False
        picBox.BorderStyle = BorderStyle.Fixed3D
        picBox.Anchor = AnchorStyles.Left And AnchorStyles.Right
        picBox.Tag = string_name
        picBox.ImageLocation = string_name
        Me.Controls.Add(picBox)
        picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        AddHandler picBox.MouseDoubleClick, AddressOf picBox_DoubleClick


    End Sub

    Public Shared Function GetFiles(ByVal path As String, ByVal searchPattern As String) As String()
        Dim patterns() As String = searchPattern.Split(";"c)

        Dim files As New List(Of String)()
        For Each filter As String In patterns
            
            'Dim dirs As New Stack(Of String)(20)

            If Not IO.Directory.Exists(path) Then
                Throw New ArgumentException()
            End If
            'dirs.Push(path)

            'D() o While dirs.Count > 0
            'Dim currentDir As String = dirs.Pop()
            'Dim subDirs() As String
            'Try
            'subDirs = IO.Directory.GetDirectories(currentDir)

            'Catch e1 As UnauthorizedAccessException
            'Continue Do
            'Catch e2 As IO.DirectoryNotFoundException
            'Continue Do
            'End Try

            Try
                files.AddRange(IO.Directory.GetFiles(path, filter))
            Catch e3 As UnauthorizedAccessException
                Throw New UnauthorizedAccessException

            Catch e4 As IO.DirectoryNotFoundException
                Throw New ArgumentException()
            End Try

            ' Push the subdirectories onto the stack for traversal. 
            ' This could also be done before handing the files. 
            'For Each str As String In subDirs
            'dirs.Push(Str)
            'Next Str()
            'Loop
        Next filter

        Return files.ToArray()
    End Function

    Private Sub picBox_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim Form2Caller As New FullScreen
        Form2Caller.SetPictureBoxImage(sender.Tag)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VScrollBar1.Visible = True
    End Sub


    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        AutoScroll = True
    End Sub
End Class


'