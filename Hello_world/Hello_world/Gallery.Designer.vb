<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gallery
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
        Me.imageFolderBrowserDlg = New System.Windows.Forms.FolderBrowserDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListButton = New System.Windows.Forms.Button()
        Me.GridButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(493, 18)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(657, 63)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "Gallery"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(-4, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1574, 573)
        Me.Panel1.TabIndex = 7
        '
        'ListButton
        '
        Me.ListButton.BackColor = System.Drawing.Color.White
        Me.ListButton.FlatAppearance.BorderSize = 0
        Me.ListButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ListButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ListButton.Image = Global.Hello_world.My.Resources.Resources.icons8_list_view_32
        Me.ListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ListButton.Location = New System.Drawing.Point(12, 12)
        Me.ListButton.MaximumSize = New System.Drawing.Size(233, 75)
        Me.ListButton.MinimumSize = New System.Drawing.Size(30, 10)
        Me.ListButton.Name = "ListButton"
        Me.ListButton.Size = New System.Drawing.Size(193, 54)
        Me.ListButton.TabIndex = 5
        Me.ListButton.Text = "List View"
        Me.ListButton.UseVisualStyleBackColor = False
        '
        'GridButton
        '
        Me.GridButton.BackColor = System.Drawing.Color.White
        Me.GridButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GridButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.GridButton.FlatAppearance.BorderSize = 0
        Me.GridButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GridButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridButton.Image = Global.Hello_world.My.Resources.Resources.icons8_grid_view_32
        Me.GridButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GridButton.Location = New System.Drawing.Point(238, 12)
        Me.GridButton.Margin = New System.Windows.Forms.Padding(4)
        Me.GridButton.MaximumSize = New System.Drawing.Size(255, 75)
        Me.GridButton.MinimumSize = New System.Drawing.Size(30, 10)
        Me.GridButton.Name = "GridButton"
        Me.GridButton.Size = New System.Drawing.Size(217, 54)
        Me.GridButton.TabIndex = 3
        Me.GridButton.Text = "Grid View"
        Me.GridButton.UseVisualStyleBackColor = False
        '
        'Gallery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1582, 753)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListButton)
        Me.Controls.Add(Me.GridButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1600, 800)
        Me.MinimumSize = New System.Drawing.Size(1600, 800)
        Me.Name = "Gallery"
        Me.Text = "Gallery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imageFolderBrowserDlg As FolderBrowserDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListButton As System.Windows.Forms.Button
    Friend WithEvents GridButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
