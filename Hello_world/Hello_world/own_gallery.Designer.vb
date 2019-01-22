<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class own_gallery
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_xyR = New System.Windows.Forms.Label()
        Me.lbl_xyB = New System.Windows.Forms.Label()
        Me.lbl_xyG = New System.Windows.Forms.Label()
        Me.lblR = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblG = New System.Windows.Forms.Label()
        Me.cmdRotate180 = New System.Windows.Forms.Button()
        Me.cmdMirror = New System.Windows.Forms.Button()
        Me.cmdFlip = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.trkBrightness = New System.Windows.Forms.TrackBar()
        Me.cmdRed = New System.Windows.Forms.Button()
        Me.cmdGreen = New System.Windows.Forms.Button()
        Me.cmdBlue = New System.Windows.Forms.Button()
        Me.cmdSepia = New System.Windows.Forms.Button()
        Me.cmdMono = New System.Windows.Forms.Button()
        Me.cmdGrey = New System.Windows.Forms.Button()
        Me.cmdNeg = New System.Windows.Forms.Button()
        Me.picDisplay = New System.Windows.Forms.PictureBox()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.cmdRestore = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.ofdLoadImage = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSaveImage = New System.Windows.Forms.SaveFileDialog()
        CType(Me.trkBrightness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_xyR
        '
        Me.lbl_xyR.BackColor = System.Drawing.Color.White
        Me.lbl_xyR.Location = New System.Drawing.Point(1210, 38)
        Me.lbl_xyR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_xyR.Name = "lbl_xyR"
        Me.lbl_xyR.Size = New System.Drawing.Size(27, 18)
        Me.lbl_xyR.TabIndex = 17
        '
        'lbl_xyB
        '
        Me.lbl_xyB.BackColor = System.Drawing.Color.White
        Me.lbl_xyB.Location = New System.Drawing.Point(1266, 38)
        Me.lbl_xyB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_xyB.Name = "lbl_xyB"
        Me.lbl_xyB.Size = New System.Drawing.Size(27, 18)
        Me.lbl_xyB.TabIndex = 18
        '
        'lbl_xyG
        '
        Me.lbl_xyG.BackColor = System.Drawing.Color.White
        Me.lbl_xyG.Location = New System.Drawing.Point(1322, 38)
        Me.lbl_xyG.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_xyG.Name = "lbl_xyG"
        Me.lbl_xyG.Size = New System.Drawing.Size(27, 18)
        Me.lbl_xyG.TabIndex = 19
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.BackColor = System.Drawing.Color.Red
        Me.lblR.ForeColor = System.Drawing.Color.White
        Me.lblR.Location = New System.Drawing.Point(1210, 86)
        Me.lblR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(18, 17)
        Me.lblR.TabIndex = 20
        Me.lblR.Text = "R"
        Me.lblR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblB.ForeColor = System.Drawing.Color.White
        Me.lblB.Location = New System.Drawing.Point(1266, 86)
        Me.lblB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(17, 17)
        Me.lblB.TabIndex = 23
        Me.lblB.Text = "B"
        '
        'lblG
        '
        Me.lblG.AutoSize = True
        Me.lblG.BackColor = System.Drawing.Color.Green
        Me.lblG.ForeColor = System.Drawing.Color.White
        Me.lblG.Location = New System.Drawing.Point(1322, 86)
        Me.lblG.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(19, 17)
        Me.lblG.TabIndex = 24
        Me.lblG.Text = "G"
        '
        'cmdRotate180
        '
        Me.cmdRotate180.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdRotate180.Location = New System.Drawing.Point(1213, 173)
        Me.cmdRotate180.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdRotate180.Name = "cmdRotate180"
        Me.cmdRotate180.Size = New System.Drawing.Size(100, 35)
        Me.cmdRotate180.TabIndex = 25
        Me.cmdRotate180.Text = "Rotate"
        Me.cmdRotate180.UseVisualStyleBackColor = False
        '
        'cmdMirror
        '
        Me.cmdMirror.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdMirror.Location = New System.Drawing.Point(1213, 253)
        Me.cmdMirror.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdMirror.Name = "cmdMirror"
        Me.cmdMirror.Size = New System.Drawing.Size(100, 35)
        Me.cmdMirror.TabIndex = 26
        Me.cmdMirror.Text = "Mirror"
        Me.cmdMirror.UseVisualStyleBackColor = False
        '
        'cmdFlip
        '
        Me.cmdFlip.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdFlip.Location = New System.Drawing.Point(1213, 339)
        Me.cmdFlip.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdFlip.Name = "cmdFlip"
        Me.cmdFlip.Size = New System.Drawing.Size(100, 35)
        Me.cmdFlip.TabIndex = 27
        Me.cmdFlip.Text = "Flip"
        Me.cmdFlip.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdExit.Location = New System.Drawing.Point(1213, 433)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(100, 35)
        Me.cmdExit.TabIndex = 28
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'trkBrightness
        '
        Me.trkBrightness.Location = New System.Drawing.Point(1092, 38)
        Me.trkBrightness.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.trkBrightness.Maximum = 20
        Me.trkBrightness.Name = "trkBrightness"
        Me.trkBrightness.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkBrightness.Size = New System.Drawing.Size(56, 621)
        Me.trkBrightness.TabIndex = 29
        Me.trkBrightness.Value = 10
        '
        'cmdRed
        '
        Me.cmdRed.BackColor = System.Drawing.Color.White
        Me.cmdRed.ForeColor = System.Drawing.Color.Red
        Me.cmdRed.Location = New System.Drawing.Point(948, 29)
        Me.cmdRed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdRed.Name = "cmdRed"
        Me.cmdRed.Size = New System.Drawing.Size(100, 35)
        Me.cmdRed.TabIndex = 30
        Me.cmdRed.Text = "Red"
        Me.cmdRed.UseVisualStyleBackColor = False
        '
        'cmdGreen
        '
        Me.cmdGreen.BackColor = System.Drawing.Color.White
        Me.cmdGreen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdGreen.Location = New System.Drawing.Point(948, 132)
        Me.cmdGreen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdGreen.Name = "cmdGreen"
        Me.cmdGreen.Size = New System.Drawing.Size(100, 35)
        Me.cmdGreen.TabIndex = 31
        Me.cmdGreen.Text = "Green"
        Me.cmdGreen.UseVisualStyleBackColor = False
        '
        'cmdBlue
        '
        Me.cmdBlue.BackColor = System.Drawing.Color.White
        Me.cmdBlue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdBlue.Location = New System.Drawing.Point(948, 234)
        Me.cmdBlue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdBlue.Name = "cmdBlue"
        Me.cmdBlue.Size = New System.Drawing.Size(100, 35)
        Me.cmdBlue.TabIndex = 32
        Me.cmdBlue.Text = "Blue"
        Me.cmdBlue.UseVisualStyleBackColor = False
        '
        'cmdSepia
        '
        Me.cmdSepia.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdSepia.ForeColor = System.Drawing.Color.Maroon
        Me.cmdSepia.Location = New System.Drawing.Point(948, 313)
        Me.cmdSepia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdSepia.Name = "cmdSepia"
        Me.cmdSepia.Size = New System.Drawing.Size(100, 35)
        Me.cmdSepia.TabIndex = 33
        Me.cmdSepia.Text = "Sepia"
        Me.cmdSepia.UseVisualStyleBackColor = False
        '
        'cmdMono
        '
        Me.cmdMono.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdMono.ForeColor = System.Drawing.Color.Cyan
        Me.cmdMono.Location = New System.Drawing.Point(948, 406)
        Me.cmdMono.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdMono.Name = "cmdMono"
        Me.cmdMono.Size = New System.Drawing.Size(100, 35)
        Me.cmdMono.TabIndex = 34
        Me.cmdMono.Text = "Mono"
        Me.cmdMono.UseVisualStyleBackColor = False
        '
        'cmdGrey
        '
        Me.cmdGrey.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdGrey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdGrey.Location = New System.Drawing.Point(948, 496)
        Me.cmdGrey.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdGrey.Name = "cmdGrey"
        Me.cmdGrey.Size = New System.Drawing.Size(100, 35)
        Me.cmdGrey.TabIndex = 35
        Me.cmdGrey.Text = "Grey"
        Me.cmdGrey.UseVisualStyleBackColor = False
        '
        'cmdNeg
        '
        Me.cmdNeg.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdNeg.Location = New System.Drawing.Point(948, 588)
        Me.cmdNeg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdNeg.Name = "cmdNeg"
        Me.cmdNeg.Size = New System.Drawing.Size(100, 35)
        Me.cmdNeg.TabIndex = 36
        Me.cmdNeg.Text = "Negative"
        Me.cmdNeg.UseVisualStyleBackColor = False
        '
        'picDisplay
        '
        Me.picDisplay.BackColor = System.Drawing.Color.White
        Me.picDisplay.Location = New System.Drawing.Point(268, 38)
        Me.picDisplay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picDisplay.Name = "picDisplay"
        Me.picDisplay.Size = New System.Drawing.Size(640, 480)
        Me.picDisplay.TabIndex = 37
        Me.picDisplay.TabStop = False
        '
        'cmdLoad
        '
        Me.cmdLoad.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdLoad.Location = New System.Drawing.Point(57, 77)
        Me.cmdLoad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(100, 35)
        Me.cmdLoad.TabIndex = 38
        Me.cmdLoad.Text = "Load Image"
        Me.cmdLoad.UseVisualStyleBackColor = False
        '
        'cmdRestore
        '
        Me.cmdRestore.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdRestore.Location = New System.Drawing.Point(57, 215)
        Me.cmdRestore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdRestore.Name = "cmdRestore"
        Me.cmdRestore.Size = New System.Drawing.Size(100, 35)
        Me.cmdRestore.TabIndex = 39
        Me.cmdRestore.Text = "Restore"
        Me.cmdRestore.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdSave.Location = New System.Drawing.Point(57, 370)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 35)
        Me.cmdSave.TabIndex = 40
        Me.cmdSave.Text = "Save Image"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'ofdLoadImage
        '
        Me.ofdLoadImage.FileName = "ofdLoadImage"
        '
        'sfdSaveImage
        '
        Me.sfdSaveImage.FileName = "sfdSaveImage"
        '
        'own_gallery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1376, 736)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdRestore)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.picDisplay)
        Me.Controls.Add(Me.cmdNeg)
        Me.Controls.Add(Me.cmdGrey)
        Me.Controls.Add(Me.cmdMono)
        Me.Controls.Add(Me.cmdSepia)
        Me.Controls.Add(Me.cmdBlue)
        Me.Controls.Add(Me.cmdGreen)
        Me.Controls.Add(Me.cmdRed)
        Me.Controls.Add(Me.trkBrightness)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdFlip)
        Me.Controls.Add(Me.cmdMirror)
        Me.Controls.Add(Me.cmdRotate180)
        Me.Controls.Add(Me.lblG)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblR)
        Me.Controls.Add(Me.lbl_xyG)
        Me.Controls.Add(Me.lbl_xyB)
        Me.Controls.Add(Me.lbl_xyR)
        Me.Name = "own_gallery"
        Me.Text = "own_gallery"
        CType(Me.trkBrightness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_xyR As System.Windows.Forms.Label
    Friend WithEvents lbl_xyB As System.Windows.Forms.Label
    Friend WithEvents lbl_xyG As System.Windows.Forms.Label
    Friend WithEvents lblR As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblG As System.Windows.Forms.Label
    Friend WithEvents cmdRotate180 As System.Windows.Forms.Button
    Friend WithEvents cmdMirror As System.Windows.Forms.Button
    Friend WithEvents cmdFlip As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents trkBrightness As System.Windows.Forms.TrackBar
    Friend WithEvents cmdRed As System.Windows.Forms.Button
    Friend WithEvents cmdGreen As System.Windows.Forms.Button
    Friend WithEvents cmdBlue As System.Windows.Forms.Button
    Friend WithEvents cmdSepia As System.Windows.Forms.Button
    Friend WithEvents cmdMono As System.Windows.Forms.Button
    Friend WithEvents cmdGrey As System.Windows.Forms.Button
    Friend WithEvents cmdNeg As System.Windows.Forms.Button
    Friend WithEvents picDisplay As System.Windows.Forms.PictureBox
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents cmdRestore As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents ofdLoadImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdSaveImage As System.Windows.Forms.SaveFileDialog
End Class
