<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class foNextSteps
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
        Me.foPictureBox = New System.Windows.Forms.PictureBox()
        Me.foImageLabel1 = New System.Windows.Forms.Label()
        Me.foNextButton = New System.Windows.Forms.Button()
        Me.foImageLabel2 = New System.Windows.Forms.Label()
        CType(Me.foPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'foPictureBox
        '
        Me.foPictureBox.Location = New System.Drawing.Point(13, 56)
        Me.foPictureBox.Name = "foPictureBox"
        Me.foPictureBox.Size = New System.Drawing.Size(420, 280)
        Me.foPictureBox.TabIndex = 0
        Me.foPictureBox.TabStop = False
        '
        'foImageLabel1
        '
        Me.foImageLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foImageLabel1.Location = New System.Drawing.Point(94, 13)
        Me.foImageLabel1.Name = "foImageLabel1"
        Me.foImageLabel1.Size = New System.Drawing.Size(259, 40)
        Me.foImageLabel1.TabIndex = 1
        Me.foImageLabel1.Text = "The next step is to right-click on the Data Shortcuts folder and select Validate " &
    "Data Shortcuts"
        Me.foImageLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'foNextButton
        '
        Me.foNextButton.Location = New System.Drawing.Point(148, 344)
        Me.foNextButton.Name = "foNextButton"
        Me.foNextButton.Size = New System.Drawing.Size(151, 23)
        Me.foNextButton.TabIndex = 2
        Me.foNextButton.Text = "Next"
        Me.foNextButton.UseVisualStyleBackColor = True
        '
        'foImageLabel2
        '
        Me.foImageLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.foImageLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foImageLabel2.Location = New System.Drawing.Point(13, 13)
        Me.foImageLabel2.Name = "foImageLabel2"
        Me.foImageLabel2.Size = New System.Drawing.Size(422, 40)
        Me.foImageLabel2.TabIndex = 3
        Me.foImageLabel2.Text = "After Civil 3D validates the shortcuts, you will be prompted to  rename files.  T" &
    "oggle default selection and click on Skip this data shortcut."
        Me.foImageLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'foNextSteps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 395)
        Me.Controls.Add(Me.foImageLabel2)
        Me.Controls.Add(Me.foNextButton)
        Me.Controls.Add(Me.foImageLabel1)
        Me.Controls.Add(Me.foPictureBox)
        Me.Name = "foNextSteps"
        Me.Text = "Next Steps"
        CType(Me.foPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents foPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents foImageLabel1 As System.Windows.Forms.Label
    Friend WithEvents foNextButton As System.Windows.Forms.Button
    Friend WithEvents foImageLabel2 As System.Windows.Forms.Label
End Class
