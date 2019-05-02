<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Communication
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
        Me.CommHeading = New System.Windows.Forms.Label()
        Me.CommMessage = New System.Windows.Forms.TextBox()
        Me.PermDismiss = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CommHeading
        '
        Me.CommHeading.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CommHeading.AutoSize = True
        Me.CommHeading.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommHeading.Location = New System.Drawing.Point(359, 9)
        Me.CommHeading.Name = "CommHeading"
        Me.CommHeading.Size = New System.Drawing.Size(83, 26)
        Me.CommHeading.TabIndex = 0
        Me.CommHeading.Text = "Label1"
        Me.CommHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CommMessage
        '
        Me.CommMessage.BackColor = System.Drawing.SystemColors.Control
        Me.CommMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CommMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommMessage.Location = New System.Drawing.Point(50, 64)
        Me.CommMessage.MaximumSize = New System.Drawing.Size(700, 360)
        Me.CommMessage.MinimumSize = New System.Drawing.Size(700, 60)
        Me.CommMessage.Multiline = True
        Me.CommMessage.Name = "CommMessage"
        Me.CommMessage.Size = New System.Drawing.Size(700, 144)
        Me.CommMessage.TabIndex = 1
        Me.CommMessage.TabStop = False
        Me.CommMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PermDismiss
        '
        Me.PermDismiss.AutoSize = True
        Me.PermDismiss.Location = New System.Drawing.Point(289, 360)
        Me.PermDismiss.Name = "PermDismiss"
        Me.PermDismiss.Size = New System.Drawing.Size(222, 17)
        Me.PermDismiss.TabIndex = 2
        Me.PermDismiss.Text = "I don't want to see this until next message"
        Me.PermDismiss.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleGreen
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(360, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Dismiss"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Communication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PermDismiss)
        Me.Controls.Add(Me.CommMessage)
        Me.Controls.Add(Me.CommHeading)
        Me.Name = "Communication"
        Me.Text = "Communication"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CommHeading As Windows.Forms.Label
    Friend WithEvents CommMessage As Windows.Forms.TextBox
    Friend WithEvents PermDismiss As Windows.Forms.CheckBox
    Friend WithEvents Button1 As Windows.Forms.Button
End Class
