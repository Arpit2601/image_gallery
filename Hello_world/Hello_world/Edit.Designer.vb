<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Edit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmdRestore = New System.Windows.Forms.Button()
        Me.cmdRed = New System.Windows.Forms.Button()
        Me.cmdGreen = New System.Windows.Forms.Button()
        Me.cmdNegative = New System.Windows.Forms.Button()
        Me.cmdBlue = New System.Windows.Forms.Button()
        Me.cmdMono = New System.Windows.Forms.Button()
        Me.cmdSepia = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cmdGrey = New System.Windows.Forms.Button()
        Me.cmdMirror = New System.Windows.Forms.Button()
        Me.cmdRotate = New System.Windows.Forms.Button()
        Me.cmdFlip = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdRestore
        '
        Me.cmdRestore.Location = New System.Drawing.Point(216, 629)
        Me.cmdRestore.Name = "cmdRestore"
        Me.cmdRestore.Size = New System.Drawing.Size(109, 40)
        Me.cmdRestore.TabIndex = 1
        Me.cmdRestore.Text = "Restore"
        Me.cmdRestore.UseVisualStyleBackColor = True
        '
        'cmdRed
        '
        Me.cmdRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRed.ForeColor = System.Drawing.Color.Red
        Me.cmdRed.Location = New System.Drawing.Point(1164, 269)
        Me.cmdRed.Name = "cmdRed"
        Me.cmdRed.Size = New System.Drawing.Size(120, 40)
        Me.cmdRed.TabIndex = 5
        Me.cmdRed.Text = "Red"
        Me.cmdRed.UseVisualStyleBackColor = True
        '
        'cmdGreen
        '
        Me.cmdGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGreen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdGreen.Location = New System.Drawing.Point(1164, 348)
        Me.cmdGreen.Name = "cmdGreen"
        Me.cmdGreen.Size = New System.Drawing.Size(120, 40)
        Me.cmdGreen.TabIndex = 6
        Me.cmdGreen.Text = "Green"
        Me.cmdGreen.UseVisualStyleBackColor = True
        '
        'cmdNegative
        '
        Me.cmdNegative.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNegative.Location = New System.Drawing.Point(1164, 201)
        Me.cmdNegative.Name = "cmdNegative"
        Me.cmdNegative.Size = New System.Drawing.Size(135, 40)
        Me.cmdNegative.TabIndex = 7
        Me.cmdNegative.Text = "Negative"
        Me.cmdNegative.UseVisualStyleBackColor = True
        '
        'cmdBlue
        '
        Me.cmdBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBlue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdBlue.Location = New System.Drawing.Point(1164, 418)
        Me.cmdBlue.Name = "cmdBlue"
        Me.cmdBlue.Size = New System.Drawing.Size(120, 40)
        Me.cmdBlue.TabIndex = 8
        Me.cmdBlue.Text = "Blue"
        Me.cmdBlue.UseVisualStyleBackColor = True
        '
        'cmdMono
        '
        Me.cmdMono.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMono.Location = New System.Drawing.Point(1164, 142)
        Me.cmdMono.Name = "cmdMono"
        Me.cmdMono.Size = New System.Drawing.Size(120, 40)
        Me.cmdMono.TabIndex = 9
        Me.cmdMono.Text = "Mono"
        Me.cmdMono.UseVisualStyleBackColor = True
        '
        'cmdSepia
        '
        Me.cmdSepia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSepia.Location = New System.Drawing.Point(1164, 79)
        Me.cmdSepia.Name = "cmdSepia"
        Me.cmdSepia.Size = New System.Drawing.Size(120, 40)
        Me.cmdSepia.TabIndex = 10
        Me.cmdSepia.Text = "Sepia"
        Me.cmdSepia.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(1164, 28)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(206, 31)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "Filters"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(72, 28)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 31)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.Text = "Adjust"
        '
        'cmdGrey
        '
        Me.cmdGrey.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGrey.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cmdGrey.Location = New System.Drawing.Point(1164, 486)
        Me.cmdGrey.Name = "cmdGrey"
        Me.cmdGrey.Size = New System.Drawing.Size(120, 40)
        Me.cmdGrey.TabIndex = 16
        Me.cmdGrey.Text = "Grey"
        Me.cmdGrey.UseVisualStyleBackColor = True
        '
        'cmdMirror
        '
        Me.cmdMirror.Image = Global.Hello_world.My.Resources.Resources.icons8_flip_horizontal_32
        Me.cmdMirror.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdMirror.Location = New System.Drawing.Point(53, 269)
        Me.cmdMirror.Name = "cmdMirror"
        Me.cmdMirror.Size = New System.Drawing.Size(139, 40)
        Me.cmdMirror.TabIndex = 15
        Me.cmdMirror.Text = "Mirror"
        Me.cmdMirror.UseVisualStyleBackColor = True
        '
        'cmdRotate
        '
        Me.cmdRotate.Image = Global.Hello_world.My.Resources.Resources.icons8_rotate_32
        Me.cmdRotate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRotate.Location = New System.Drawing.Point(53, 342)
        Me.cmdRotate.Name = "cmdRotate"
        Me.cmdRotate.Size = New System.Drawing.Size(139, 46)
        Me.cmdRotate.TabIndex = 14
        Me.cmdRotate.Text = "Rotate "
        Me.cmdRotate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdRotate.UseVisualStyleBackColor = True
        '
        'cmdFlip
        '
        Me.cmdFlip.Image = Global.Hello_world.My.Resources.Resources.icons8_flip_vertical_32
        Me.cmdFlip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFlip.Location = New System.Drawing.Point(53, 201)
        Me.cmdFlip.Name = "cmdFlip"
        Me.cmdFlip.Size = New System.Drawing.Size(139, 40)
        Me.cmdFlip.TabIndex = 13
        Me.cmdFlip.Text = "Flip"
        Me.cmdFlip.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.Image = Global.Hello_world.My.Resources.Resources.icons8_save_32
        Me.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.saveButton.Location = New System.Drawing.Point(1030, 629)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(105, 40)
        Me.saveButton.TabIndex = 2
        Me.saveButton.Text = "Save"
        Me.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(216, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(919, 549)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1368, 698)
        Me.Controls.Add(Me.cmdGrey)
        Me.Controls.Add(Me.cmdMirror)
        Me.Controls.Add(Me.cmdRotate)
        Me.Controls.Add(Me.cmdFlip)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmdSepia)
        Me.Controls.Add(Me.cmdMono)
        Me.Controls.Add(Me.cmdBlue)
        Me.Controls.Add(Me.cmdNegative)
        Me.Controls.Add(Me.cmdGreen)
        Me.Controls.Add(Me.cmdRed)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.cmdRestore)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximumSize = New System.Drawing.Size(1390, 749)
        Me.MinimumSize = New System.Drawing.Size(1390, 749)
        Me.Name = "Edit"
        Me.Text = "Edit"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdRestore As System.Windows.Forms.Button
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents cmdRed As System.Windows.Forms.Button
    Friend WithEvents cmdGreen As System.Windows.Forms.Button
    Friend WithEvents cmdNegative As System.Windows.Forms.Button
    Friend WithEvents cmdBlue As System.Windows.Forms.Button
    Friend WithEvents cmdMono As System.Windows.Forms.Button
    Friend WithEvents cmdSepia As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents cmdFlip As System.Windows.Forms.Button
    Friend WithEvents cmdRotate As System.Windows.Forms.Button
    Friend WithEvents cmdMirror As System.Windows.Forms.Button
    Friend WithEvents cmdGrey As System.Windows.Forms.Button

End Class
