

Public Class Gallery

    ' This class defines the main window of our gallery having two buttons, one each for grid and list view, imagefolderbrowser dialog and a panel.
    ' The grid view shows all the images, of the folder you selected, in a 150*150 size picture box. If you select any image it will take you to editing window 
    ' The list view only shows the names of the images, which on selection will take you to the editing window


    Private imageFiles() As String = Nothing    'imageFiles is an array of strings to store the paths of all the images present in a folder
    Dim bmp01, bmp02, bmpTemp As Bitmap
    Dim picBox As New PictureBox                ' picBox and textBox are used such that they can be dynamically made
    Dim textBox As New TextBox



    'Function to get all the files with searchPattern as their extensions in a folder with folderPath as its path
    Public Shared Function GetImages(ByVal folderPath As String, ByVal searchPattern As String) As String()
        ' First searchPattern is split with ; as its delimiters and stored in patterns array 
        Dim patterns() As String = searchPattern.Split(";"c)

        ' a new list of strings is defined to store all the image paths
        ' list is used instead of an array so that its easy to append file names 
        Dim files As New List(Of String)()
        For Each filter As String In patterns
            If Not IO.Directory.Exists(folderPath) Then
                Throw New ArgumentException()
            End If
            Try
                ' Add all the files from folderPath with filter as their extension in files list
                files.AddRange(IO.Directory.GetFiles(folderPath, filter))

                'Throw argument exception if user does not have permission to access the folder or directory is not found
            Catch e3 As UnauthorizedAccessException
                Throw New UnauthorizedAccessException

            Catch e4 As IO.DirectoryNotFoundException
                Throw New ArgumentException()
            End Try

        Next filter
        Return files.ToArray()
    End Function

    ' Main Function used to show images in grid view
    Private Sub GridButton_click(sender As Object, e As EventArgs) Handles GridButton.Click

        If imageFolderBrowserDlg.ShowDialog() = DialogResult.OK Then
            Me.imageFiles = GetImages(Me.imageFolderBrowserDlg.SelectedPath, "*.jpg;*.jpeg;*.png;*.bmp;*.tif;*.tiff;*.gif;*.JPG;*JPEG 2000;*.GIF;*.BMP;*.BPG;*.BAT;*.HEIF;*.WebP;*.Exif;*.TIFF")

            ' If there are no images in the folder it will pop up a message that no images were found 
            If Me.imageFiles.Length = 0 Then
                MessageBox.Show("No image can be found")
            Else

                ' If images are already represented in grid or list view and you want to select new folder then remove all the previous images 
                Panel1.Controls.Clear()

                Dim XLocation As Integer        ' Sets the x coordinate of top-left point of picture box  
                Dim YLocation As Integer        ' Sets the y coordinate of top-left point of picture box  
                Dim i As Integer                ' index i is used to name picture and text boxes uniquely 
                XLocation = 70
                YLocation = 0
                i = 0

                ' For each file call DrawPictureBox funciton to make a grid
                For Each image_string As String In imageFiles
                    DrawPictureBox(image_string, XLocation, YLocation, i)
                Next

            End If
        End If

    End Sub


    ' This function is used create picture boxes dynamically each time it is called
    ' The parameters of the function are string_name as the path of image , x and y coordinate and index of image
    Public Sub DrawPictureBox(ByVal string_name As String, ByRef x As Integer, ByRef y As Integer, ByRef i As Integer)
        Dim picBox As New PictureBox    ' picBox for holding image
        Dim textBox As New TextBox      ' textBox for holding name of image
        Dim picture_name As String = System.IO.Path.GetFileName(string_name)    ' holds the name of image

        Try
            bmp01 = Image.FromFile(string_name)
            ' If system goes out of memory it will not load the images just put a cross sign in its thumbnail
        Catch e As System.OutOfMemoryException
            Console.WriteLine("system out of memory")

        End Try

        'Assingning locations to picture boxes and text boxes
        picBox.Location = New Point(x, y)
        textBox.Location = New Point(x, y + 155)

        'Incrementing x coordinate for next image and checking if right end of image is going out of the panel. 
        'If yes then bring x back to left of panel
        x += 150
        If x + 150 >= Panel1.Width Then
            x = 70
            y = y + 195
        End If

        ' Assigning various properties to text box
        textBox.Name = "TextBox" & i
        textBox.Size = New Size(150, 20)
        textBox.Text = picture_name
        textBox.BackColor = Color.Black
        textBox.BorderStyle = BorderStyle.None
        textBox.ReadOnly = True
        textBox.ForeColor = Color.FloralWhite
        Me.Panel1.Controls.Add(textBox)

        ' Assigning various properties to picture boxe
        picBox.Name = "PictureBox" & i
        picBox.Size = New Size(150, 150)
        picBox.TabIndex = 0
        picBox.TabStop = False
        picBox.BorderStyle = BorderStyle.None
        picBox.Tag = string_name
        picBox.ImageLocation = string_name
        picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        AddHandler picBox.Click, AddressOf picBox_Click
        picBox.Cursor = Cursors.Hand
        Me.Panel1.Controls.Add(picBox)

        ' Changing index for next image
        i += 1

    End Sub


    ' This function is called whenever a picbox is clicked
    ' It will take you to editing window
    Private Sub picBox_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim Form2Caller As New Edit
        Form2Caller.SetPictureBoxImage(sender.Tag)
    End Sub


    ' Main Function used to show images in list view
    Private Sub ListButton_Click(sender As Object, e As EventArgs) Handles ListButton.Click

        If imageFolderBrowserDlg.ShowDialog() = DialogResult.OK Then
            Me.imageFiles = GetImages(Me.imageFolderBrowserDlg.SelectedPath, "*.jpg;*.jpeg;*.png;*.bmp;*.tif;*.tiff;*.gif;*.JPG;*JPEG 2000;*.GIF;*.BMP;*.BPG;*.BAT;*.HEIF;*.WebP;*.Exif;*.TIFF")

            ' If there are no images in the folder it will pop up a message that no images were found 
            If Me.imageFiles.Length = 0 Then
                MessageBox.Show("No image can be found")
            Else
                ' If images are already represented in grid or list view and you want to select new folder then remove all the previous images 
                Panel1.Controls.Clear()

                Dim XLocation As Integer        ' Sets the x coordinate of top-left point of text
                Dim YLocation As Integer        ' Sets the y coordinate of top-left point of text 
                Dim i As Integer                ' index i is used to name text boxes uniquely 
                XLocation = 30
                YLocation = 0
                i = 0

                ' For each file call DrawTextBox funciton to make a list
                For Each image_string As String In imageFiles
                    DrawTextBox(image_string, XLocation, YLocation, i)
                Next
            End If
        End If
    End Sub


    ' This function is used create text boxes dynamically each time it is called
    ' The parameters of the function are string_name as the path of image , x and y coordinate and index of image
    Public Sub DrawTextBox(ByVal string_name As String, ByRef x As Integer, ByRef y As Integer, ByRef i As Integer)
        Dim textBox As New TextBox      ' textBox for holding name of image
        Dim picture_name As String = System.IO.Path.GetFileName(string_name)    ' holds the name of image

        'Assingning locations to and text boxes
        textBox.Location = New Point(x, y + 20)

        'Incrementing x coordinate for next image name and checking if right end of image name is going out of the panel. 
        'If yes then bring x back to left of panel
        x += 200
        If x + 150 >= Me.Width Then
            x = 30
            y = y + 30
        End If

        ' Assigning various properties to text box
        textBox.Name = "TextBox" & i
        textBox.Size = New Size(150, 20)
        textBox.Text = picture_name
        textBox.BackColor = Color.Black

        textBox.BorderStyle = BorderStyle.None
        textBox.ReadOnly = True
        textBox.ForeColor = Color.FloralWhite
        textBox.Cursor = Cursors.Hand
        textBox.Tag = string_name
        Me.Panel1.Controls.Add(textBox)
        AddHandler textBox.Click, AddressOf textBox_Click

        ' Changing index for next image
        i += 1
    End Sub


    ' This function is called whenever an image name is clicked
    ' It will take you to editing window
    Private Sub textBox_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim Form2Caller As New Edit
        Form2Caller.SetPictureBoxImage(sender.Tag)
    End Sub


    ' Allow the user to drop any file on form at any page .
    ' If its a file then it will display on picture box otherwise a cross sign will come
    Private Sub Gallery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AllowDrop = True
        'Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub
   

    ' Handles the event of drag drop 
    ' It clears any previous images on panel then dynamically creates a picture box and then renders the image on it 
    ' it also has handller so that when clicked on image it takes us to editinig window
    Private Sub Gallery_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragDrop
        Me.Panel1.Controls.Clear()
        Dim picBox_drag As New PictureBox
        picBox_drag.Location = New Point(298, 33)
        picBox_drag.Size = New Size(640, 480)
        Me.Panel1.Controls.Add(picBox_drag)
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        Dim path As String = files(0)
        picBox_drag.SizeMode = PictureBoxSizeMode.StretchImage
        picBox_drag.Tag = path
        picBox_drag.ImageLocation = path
        picBox_drag.Cursor = Cursors.Hand
        AddHandler picBox_drag.Click, AddressOf picBox_drag_click
    End Sub


    ' Handles the even of drag enter
    Private Sub Gallery_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub


    ' when image is clicked it sends to next window
    Private Sub picBox_drag_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim Form2Caller As New Edit
        Form2Caller.SetPictureBoxImage(sender.Tag)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form3Caller As New own_gallery
        Form3Caller.ShowDialog()

    End Sub
End Class


