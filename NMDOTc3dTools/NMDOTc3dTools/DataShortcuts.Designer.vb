<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataShortcuts
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
        Me.foOffices = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.foProjectNo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.foOKbutton = New System.Windows.Forms.Button()
        Me.foCancelButton = New System.Windows.Forms.Button()
        Me.foDataBox = New System.Windows.Forms.CheckedListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.foHelpButton = New System.Windows.Forms.PictureBox()
        Me.mappedDrives = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.foHelpButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'foOffices
        '
        Me.foOffices.FormattingEnabled = True
        Me.foOffices.Items.AddRange(New Object() {"North Region", "Central Region", "South Region", "District 1", "District 2", "District 4", "District 5", "District 6"})
        Me.foOffices.Location = New System.Drawing.Point(80, 78)
        Me.foOffices.Name = "foOffices"
        Me.foOffices.Size = New System.Drawing.Size(121, 21)
        Me.foOffices.TabIndex = 3
        Me.foOffices.Text = "Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select Office Project Resides In:"
        '
        'foProjectNo
        '
        Me.foProjectNo.Enabled = False
        Me.foProjectNo.FormattingEnabled = True
        Me.foProjectNo.Location = New System.Drawing.Point(78, 130)
        Me.foProjectNo.Name = "foProjectNo"
        Me.foProjectNo.Size = New System.Drawing.Size(121, 21)
        Me.foProjectNo.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Select Project Number:"
        '
        'foOKbutton
        '
        Me.foOKbutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.foOKbutton.Location = New System.Drawing.Point(54, 299)
        Me.foOKbutton.Name = "foOKbutton"
        Me.foOKbutton.Size = New System.Drawing.Size(75, 23)
        Me.foOKbutton.TabIndex = 7
        Me.foOKbutton.Text = "OK"
        Me.foOKbutton.UseVisualStyleBackColor = True
        '
        'foCancelButton
        '
        Me.foCancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.foCancelButton.Location = New System.Drawing.Point(148, 299)
        Me.foCancelButton.Name = "foCancelButton"
        Me.foCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.foCancelButton.TabIndex = 8
        Me.foCancelButton.Text = "Cancel"
        Me.foCancelButton.UseVisualStyleBackColor = True
        '
        'foDataBox
        '
        Me.foDataBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.foDataBox.FormattingEnabled = True
        Me.foDataBox.Location = New System.Drawing.Point(79, 210)
        Me.foDataBox.Name = "foDataBox"
        Me.foDataBox.Size = New System.Drawing.Size(120, 79)
        Me.foDataBox.TabIndex = 11
        Me.foDataBox.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NMDOTc3dTools.My.Resources.Resources.Close1
        Me.PictureBox1.Location = New System.Drawing.Point(254, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "NMDOT Data Shortcut Application"
        '
        'foHelpButton
        '
        Me.foHelpButton.Image = Global.NMDOTc3dTools.My.Resources.Resources.Button_help_icon
        Me.foHelpButton.Location = New System.Drawing.Point(227, 11)
        Me.foHelpButton.Name = "foHelpButton"
        Me.foHelpButton.Size = New System.Drawing.Size(20, 20)
        Me.foHelpButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.foHelpButton.TabIndex = 19
        Me.foHelpButton.TabStop = False
        '
        'mappedDrives
        '
        Me.mappedDrives.FormattingEnabled = True
        Me.mappedDrives.Location = New System.Drawing.Point(77, 176)
        Me.mappedDrives.Name = "mappedDrives"
        Me.mappedDrives.Size = New System.Drawing.Size(122, 21)
        Me.mappedDrives.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Destination Office Mapped as:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataShortcuts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NMDOTc3dTools.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 344)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mappedDrives)
        Me.Controls.Add(Me.foHelpButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.foDataBox)
        Me.Controls.Add(Me.foCancelButton)
        Me.Controls.Add(Me.foOKbutton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.foProjectNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.foOffices)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DataShortcuts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Data Shortcuts Modifier"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.foHelpButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents foOffices As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents foProjectNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents foOKbutton As System.Windows.Forms.Button
    Friend WithEvents foCancelButton As System.Windows.Forms.Button
    Friend WithEvents foDataBox As System.Windows.Forms.CheckedListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents foHelpButton As System.Windows.Forms.PictureBox
    Friend WithEvents mappedDrives As Windows.Forms.ComboBox
    Friend WithEvents Label4 As Windows.Forms.Label
End Class
