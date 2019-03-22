Public Class foNextSteps
    Dim CloseDialog As Boolean = False

    Private Sub foNextSteps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        foPictureBox.Image = My.Resources.ValidateCapture
        foImageLabel2.Visible = False
        foImageLabel1.Visible = True
    End Sub

    Private Sub foNextButton_Click(sender As Object, e As EventArgs) Handles foNextButton.Click
        'MsgBox("CloseDialog = " & CloseDialog)

        If CloseDialog = False Then
            foImageLabel1.Visible = False
            foImageLabel2.Visible = True
            foPictureBox.Image = My.Resources.SkipCapture
            foNextButton.Text = "Close"
            CloseDialog = True
        Else
            Me.Hide()
        End If

    End Sub
End Class