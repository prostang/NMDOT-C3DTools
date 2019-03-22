<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DWGUnits
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
        Me.InsertionUnits = New System.Windows.Forms.Label()
        Me.LengthUnits = New System.Windows.Forms.Label()
        Me.foChangeUnits = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'InsertionUnits
        '
        Me.InsertionUnits.AutoSize = True
        Me.InsertionUnits.Location = New System.Drawing.Point(8, 22)
        Me.InsertionUnits.MinimumSize = New System.Drawing.Size(250, 0)
        Me.InsertionUnits.Name = "InsertionUnits"
        Me.InsertionUnits.Size = New System.Drawing.Size(250, 13)
        Me.InsertionUnits.TabIndex = 0
        Me.InsertionUnits.Text = "Label1"
        Me.InsertionUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LengthUnits
        '
        Me.LengthUnits.AutoSize = True
        Me.LengthUnits.Location = New System.Drawing.Point(21, 53)
        Me.LengthUnits.MinimumSize = New System.Drawing.Size(225, 0)
        Me.LengthUnits.Name = "LengthUnits"
        Me.LengthUnits.Size = New System.Drawing.Size(225, 13)
        Me.LengthUnits.TabIndex = 1
        Me.LengthUnits.Text = "Label1"
        Me.LengthUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'foChangeUnits
        '
        Me.foChangeUnits.Location = New System.Drawing.Point(87, 96)
        Me.foChangeUnits.Name = "foChangeUnits"
        Me.foChangeUnits.Size = New System.Drawing.Size(93, 23)
        Me.foChangeUnits.TabIndex = 2
        Me.foChangeUnits.Text = "Change Units"
        Me.foChangeUnits.UseVisualStyleBackColor = True
        '
        'DWGUnits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 131)
        Me.Controls.Add(Me.foChangeUnits)
        Me.Controls.Add(Me.LengthUnits)
        Me.Controls.Add(Me.InsertionUnits)
        Me.Name = "DWGUnits"
        Me.Text = "DWGUnits"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InsertionUnits As System.Windows.Forms.Label
    Friend WithEvents LengthUnits As System.Windows.Forms.Label
    Friend WithEvents foChangeUnits As System.Windows.Forms.Button
End Class
