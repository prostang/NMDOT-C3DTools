Imports Microsoft.Win32
Public Class Communication
    Private Sub Communication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ServerMessage As String = "\\eabrn1\cadd\support\docs\Civil3DMessage.txt"
        Dim ServerMessLog As String = "\\eabrn1\cadd\support\docs\CommunicationLog.txt"
        Dim FDate = IO.File.GetLastWriteTime(ServerMessage).ToString("yyyy-MM-dd")

        'Set header to last edit date of ServerMessage file
        CommHeading.Text = FDate

        'Read message from file on server
        Dim uMessage As String
        uMessage = My.Computer.FileSystem.ReadAllText(ServerMessage)
        CommMessage.Text = uMessage

        'Read Log file on server and search for current modification date
        Dim lines As String = System.IO.File.ReadAllText(ServerMessLog)
        Dim index As Integer = lines.IndexOf(FDate)

        'Log the message and date if current date is not found.
        If index < 0 Then
            uMessage = uMessage & vbCrLf & FDate & vbCrLf & My.User.Name & vbCrLf
            My.Computer.FileSystem.WriteAllText(ServerMessLog, uMessage, True)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PermDismiss.Checked Then
            'Check if registry value exists for dismissing date
            Dim exists As Boolean = False
            Try
                If My.Computer.Registry.CurrentUser.OpenSubKey("Environment\C3DlastMessage") IsNot Nothing Then
                    exists = True
                    'Read registry value for dismissing date
                    Dim keyValue As Object
                    keyValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Environment", "C3DlastMessage", Nothing)

                    'Check if dates do not match, create C3D key
                    If Not keyValue.ToString = CommHeading.Text Then
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Environment", "C3DlastMessage", CommHeading.Text)
                    End If
                Else
                    'MsgBox("C3DlastMessage does not exist")
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Environment", "C3DlastMessage", CommHeading.Text)
                End If
            Finally
                My.Computer.Registry.CurrentUser.Close()
            End Try
        Else
            'MsgBox("PermDismiss not checked.")

        End If

        Me.Close()
    End Sub
End Class