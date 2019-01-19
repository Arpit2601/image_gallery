

Public Class Form1
    Private imageFiles() As String = Nothing
    Dim bmp01, bmp02, bmpTemp As Bitmap
    Dim picBox As New PictureBox
    Dim textBox As New TextBox

   
    Private Sub button1_click(sender As Object, e As EventArgs) Handles Button1.Click
        
        If imageFolderBrowserDlg.ShowDialog() = DialogResult.OK Then
            Me.imageFiles = GetFiles(Me.imageFolderBrowserDlg.SelectedPath, "*.jpg;*.jpeg;*.png;*.bmp;*.tif;*.tiff;*.gif;*.JPG;*JPEG 2000;*.GIF;*.BMP;*.BPG;*.BAT;*.HEIF;*.WebP;*.Exif;*.TIFF")
            If Me.imageFiles.Length = 0 Then
                MessageBox.Show("No image can be found")
            Else

                ' If new folder is selected then remove all the previous images and add new ones
                Panel1.Controls.Clear()
                ' Dim bm2 = New Bitmap(10, 10)
                Dim image_string1 As String

                Dim XLocation As Integer
                Dim i As Integer

                Dim YLocation As Integer
                XLocation = 70
               

                For Each image_string As String In imageFiles


                    image_string1 = image_string
                    DrawPictureBox(image_string, XLocation, YLocation, i)
                Next
            End If
        End If

    End Sub


    Public Sub DrawPictureBox(ByVal string_name As String, ByRef x As Integer, ByRef y As Integer, ByRef i As Integer)
        Dim picBox As New PictureBox
        Dim bmp01 As New Bitmap(150, 150)
        picBox.Location = New Point(x, y)
        Try

            bmp01 = Image.FromFile(string_name) ' add system.memorylimitexceeded exception
        Catch e As System.OutOfMemoryException
            Console.WriteLine("system out of memory")
          
        End Try
        Dim textBox As New TextBox
        textBox.Location = New Point(x, y + 155)
        x += 150
        'resize_image(bmp01)
        If x + 150 >= Panel1.Width Then
            x = 70
            y = y + 195
        End If

        Dim picture_name As String = System.IO.Path.GetFileName(string_name)
        textBox.Name = "TextBox" & i
        textBox.Size = New Size(150, 20)
        textBox.Text = picture_name
        textBox.BackColor = Color.Black
        textBox.BorderStyle = BorderStyle.None
        textBox.ReadOnly = True
        textBox.ForeColor = Color.FloralWhite
        
        Me.Panel1.Controls.Add(textBox)


        picBox.Name = "PictureBox" & i
        i += 1
        picBox.Size = New Size(150, 150)
        picBox.TabIndex = 0
        picBox.TabStop = False
        'picBox.Margin = New Padding(1, 1, 1, 1)
        picBox.BorderStyle = BorderStyle.None
        picBox.BackColor = Color.Black

        picBox.Tag = string_name
        picBox.ImageLocation = string_name
        picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        AddHandler picBox.MouseDoubleClick, AddressOf picBox_DoubleClick
        'AddHandler picBox.MouseHover, AddressOf picBox_MouseHover
        Me.Panel1.Controls.Add(picBox)
        bmp01.Dispose()

    End Sub

    Public Shared Function GetFiles(ByVal path As String, ByVal searchPattern As String) As String()
        Dim patterns() As String = searchPattern.Split(";"c)

        Dim files As New List(Of String)()
        For Each filter As String In patterns
            If Not IO.Directory.Exists(path) Then
                Throw New ArgumentException()
            End If          
            Try
                files.AddRange(IO.Directory.GetFiles(path, filter))
            Catch e3 As UnauthorizedAccessException
                Throw New UnauthorizedAccessException

            Catch e4 As IO.DirectoryNotFoundException
                Throw New ArgumentException()
            End Try

        Next filter

        Return files.ToArray()
    End Function

    Private Sub picBox_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim Form2Caller As New FullScreen
        Form2Caller.SetPictureBoxImage(sender.Tag)
    End Sub

    
   
End Class


'