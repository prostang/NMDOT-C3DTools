<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemplateRequest
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
        Me.foCategories = New System.Windows.Forms.ComboBox()
        Me.foSubCategories = New System.Windows.Forms.ComboBox()
        Me.foCategoryLabel = New System.Windows.Forms.Label()
        Me.foSubLabel = New System.Windows.Forms.Label()
        Me.foComments = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.foUsersEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.foStylesLabel = New System.Windows.Forms.Label()
        Me.foStylesListing = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'foCategories
        '
        Me.foCategories.FormattingEnabled = True
        Me.foCategories.Location = New System.Drawing.Point(67, 87)
        Me.foCategories.Name = "foCategories"
        Me.foCategories.Size = New System.Drawing.Size(150, 21)
        Me.foCategories.TabIndex = 0
        '
        'foSubCategories
        '
        Me.foSubCategories.FormattingEnabled = True
        Me.foSubCategories.Location = New System.Drawing.Point(67, 138)
        Me.foSubCategories.Name = "foSubCategories"
        Me.foSubCategories.Size = New System.Drawing.Size(150, 21)
        Me.foSubCategories.TabIndex = 1
        '
        'foCategoryLabel
        '
        Me.foCategoryLabel.AutoSize = True
        Me.foCategoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foCategoryLabel.Location = New System.Drawing.Point(64, 71)
        Me.foCategoryLabel.Name = "foCategoryLabel"
        Me.foCategoryLabel.Size = New System.Drawing.Size(92, 13)
        Me.foCategoryLabel.TabIndex = 2
        Me.foCategoryLabel.Text = "Main Category:"
        '
        'foSubLabel
        '
        Me.foSubLabel.AutoSize = True
        Me.foSubLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foSubLabel.Location = New System.Drawing.Point(67, 119)
        Me.foSubLabel.Name = "foSubLabel"
        Me.foSubLabel.Size = New System.Drawing.Size(87, 13)
        Me.foSubLabel.TabIndex = 3
        Me.foSubLabel.Text = "Sub Category:"
        '
        'foComments
        '
        Me.foComments.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.foComments.Location = New System.Drawing.Point(52, 177)
        Me.foComments.Multiline = True
        Me.foComments.Name = "foComments"
        Me.foComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.foComments.Size = New System.Drawing.Size(180, 80)
        Me.foComments.TabIndex = 4
        '
        'submit
        '
        Me.submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.submit.Location = New System.Drawing.Point(52, 273)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(75, 23)
        Me.submit.TabIndex = 5
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.Location = New System.Drawing.Point(157, 273)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 6
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'foUsersEmail
        '
        Me.foUsersEmail.Location = New System.Drawing.Point(67, 41)
        Me.foUsersEmail.Name = "foUsersEmail"
        Me.foUsersEmail.Size = New System.Drawing.Size(147, 20)
        Me.foUsersEmail.TabIndex = 7
        Me.foUsersEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Email Address:"
        '
        'foStylesLabel
        '
        Me.foStylesLabel.AutoSize = True
        Me.foStylesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foStylesLabel.Location = New System.Drawing.Point(70, 166)
        Me.foStylesLabel.Name = "foStylesLabel"
        Me.foStylesLabel.Size = New System.Drawing.Size(39, 13)
        Me.foStylesLabel.TabIndex = 10
        Me.foStylesLabel.Text = "Style:"
        Me.foStylesLabel.Visible = False
        '
        'foStylesListing
        '
        Me.foStylesListing.FormattingEnabled = True
        Me.foStylesListing.Location = New System.Drawing.Point(67, 185)
        Me.foStylesListing.Name = "foStylesListing"
        Me.foStylesListing.Size = New System.Drawing.Size(150, 21)
        Me.foStylesListing.TabIndex = 11
        Me.foStylesListing.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 326)
        Me.Controls.Add(Me.foStylesListing)
        Me.Controls.Add(Me.foStylesLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.foUsersEmail)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.foComments)
        Me.Controls.Add(Me.foSubLabel)
        Me.Controls.Add(Me.foCategoryLabel)
        Me.Controls.Add(Me.foSubCategories)
        Me.Controls.Add(Me.foCategories)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 400)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 365)
        Me.Name = "Form1"
        Me.Text = "NMDOT Template Request Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents foCategories As System.Windows.Forms.ComboBox
    Friend WithEvents foSubCategories As System.Windows.Forms.ComboBox
    Friend WithEvents foCategoryLabel As System.Windows.Forms.Label
    Friend WithEvents foSubLabel As System.Windows.Forms.Label
    Friend WithEvents foComments As System.Windows.Forms.TextBox
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents foUsersEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents foStylesLabel As System.Windows.Forms.Label
    Friend WithEvents foStylesListing As System.Windows.Forms.ComboBox
End Class
