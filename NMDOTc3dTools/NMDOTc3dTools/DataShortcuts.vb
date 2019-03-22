Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Public Class DataShortcuts
    'Dim ProjectsShare As String = "\NMDOT-Projects\"
    Dim ProjectsShare As String = "\Projects\"
    Dim NRDloc As String, CRDloc As String, SRDloc As String, D1loc As String, D2loc As String, D4loc As String, D5loc As String, D6loc As String
    Dim ProjectShortcuts As String, ProjectsLocation As String, CheckedFile As String
    Dim LocationSever As String, DriveLetter As String, MessageMe As String, DuplicateFile As Boolean

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Image = My.Resources.Close2
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub foHelpButton_MouseHover(sender As Object, e As EventArgs) Handles foHelpButton.MouseHover
        foHelpButton.Image = My.Resources.Button_help_inverted
    End Sub

    Private Sub foHelpButton_MouseLeave(sender As Object, e As EventArgs) Handles foHelpButton.MouseLeave
        foHelpButton.Image = My.Resources.Button_help_icon
    End Sub

    Private Sub foHelpButton_Click(sender As Object, e As EventArgs) Handles foHelpButton.Click
        Dim frm As AboutBox1 = New AboutBox1
        Dim dr As DialogResult
        dr = Autodesk.AutoCAD.ApplicationServices.Application.ShowModalDialog(frm)
    End Sub

    Private Sub DataShortcuts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Height = 285
        foDataBox.Visible = False

        Dim driveNames As New List(Of String)
        For Each drive As DriveInfo In My.Computer.FileSystem.Drives
            driveNames.Add(drive.Name)
        Next

        For Each item In driveNames
            mappedDrives.Items.Add(item)
        Next

    End Sub



    Private Sub foOffices_DropDownClosed(sender As Object, e As EventArgs) Handles foOffices.DropDownClosed
        Dim ProjectOffice As String = foOffices.SelectedItem
        foProjectNo.Items.Clear()

        Select Case ProjectOffice
            Case "North Region"
                LocationSever = "EABRN1"
                'LocationSever = "MJMSV01"
            Case "Central Region"
                LocationSever = "CRDVNXESVR01"
            Case "South Region"
                LocationSever = "SolanoVNXESVR01"
            Case "District 1"
                LocationSever = "D1VNXESVR01"
            Case "District 2"
                LocationSever = "D2VNXESVR01"
            Case "District 4"
                LocationSever = "D4VNXESVR01"
            Case "District 5"
                LocationSever = "D5VNXESVR01"
            Case "District 6"
                LocationSever = "D6VNXESVR01"
            Case Else
                LocationSever = "Null"
        End Select
        ProjectsLocation = "\\" & LocationSever & ProjectsShare

        If My.Computer.FileSystem.DirectoryExists(ProjectsLocation) Then
            Dim di As New IO.DirectoryInfo(ProjectsLocation)
            Dim ProjectsListing = di.GetDirectories

            For Each subdi In ProjectsListing
                foProjectNo.Items.Add(subdi)
            Next
            foProjectNo.Items.Add("-Select-")
            foProjectNo.SelectedIndex = foProjectNo.Items.Count - 1

            foProjectNo.Enabled = True
        Else
            If ProjectOffice = "Select" Then
                MsgBox("Please select an office.")
            Else
                MsgBox("The office selected is not responding.  Please contact EAB.")
            End If
            foOffices.Focus()
        End If

    End Sub

    Private Sub foProjectNo_DropDownClosed(sender As Object, e As EventArgs) Handles foProjectNo.DropDownClosed

        If Not foProjectNo.SelectedValue = "-Select-" Then
            foDataBox.Items.Clear()
            Me.Height = 360
            foDataBox.Visible = True

            If foProjectNo.SelectedItem.ToString IsNot Nothing Then
                ProjectShortcuts = ProjectsLocation & foProjectNo.SelectedItem.ToString & "\_data\_shortcuts\"

            Else
                MsgBox("Please select a different project.  The data shortcuts folder was not found.")
            End If

            Dim alg As String = ProjectShortcuts & "Alignments"
            If My.Computer.FileSystem.DirectoryExists(alg) Then
                Dim algs() As System.IO.FileInfo = New IO.DirectoryInfo(alg).GetFiles()

                If algs.Count > 0 Then
                    foDataBox.Items.Add("Alignments")
                End If
            End If

            Dim dtm As String = ProjectShortcuts & "Surfaces"
            If My.Computer.FileSystem.DirectoryExists(dtm) Then
                Dim dtms() As System.IO.FileInfo = New IO.DirectoryInfo(dtm).GetFiles()

                If dtms.Count > 0 Then
                    foDataBox.Items.Add("Surfaces")
                End If
            End If

            Dim prof As String = ProjectShortcuts & "Profiles"
            If My.Computer.FileSystem.DirectoryExists(prof) Then
                Dim profs() As System.IO.FileInfo = New IO.DirectoryInfo(prof).GetFiles()

                If profs.Count > 0 Then
                    foDataBox.Items.Add("Profiles")
                End If
            End If

            Dim pipe As String = ProjectShortcuts & "PipeNetworks"
            If My.Computer.FileSystem.DirectoryExists(pipe) Then
                Dim pipes() As System.IO.FileInfo = New IO.DirectoryInfo(pipe).GetFiles()

                If pipes.Count > 0 Then
                    foDataBox.Items.Add("Pipe Networks")
                End If
            End If

            Dim vf As String = ProjectShortcuts & "ViewFrameGroups"
            If My.Computer.FileSystem.DirectoryExists(vf) Then
                Dim vfs() As System.IO.FileInfo = New IO.DirectoryInfo(vf).GetFiles()

                If vfs.Count > 0 Then
                    foDataBox.Items.Add("View Frame Groups")
                End If
            End If

            foDataBox.Sorted = True

        End If
    End Sub

    Private Sub foOKbutton_Click(sender As Object, e As EventArgs) Handles foOKbutton.Click
        Dim AlignmentsCkd As Boolean, SurfacesCkd As Boolean, PipeNetworksCkd As Boolean, ViewFramesCkd As Boolean, ProfilesCkd As Boolean
        Dim FileExtPlus As String

        DriveLetter = mappedDrives.SelectedItem

        For x = 0 To foDataBox.CheckedItems.Count - 1
            Select Case foDataBox.CheckedItems(x).ToString
                Case "Alignments"
                    AlignmentsCkd = True
                    Dim alg As String = ProjectShortcuts & "Alignments"
                    Dim algs() As System.IO.FileInfo = New IO.DirectoryInfo(alg).GetFiles()
                    Dim i As Integer

                    For i = 0 To algs.Count - 1
                        'Get name of last 6 characters to see if -Q.xml is present
                        FileExtPlus = algs(i).Name.Substring(algs(i).Name.LastIndexOf(".") - 2, 6)

                        If Not FileExtPlus = "-Q.xml" Then ExistingFileCheck(algs(i).Name, "Alignments")
                        If DuplicateFile = False Then CopyShortcuts(algs(i).Name, "Alignments")
                    Next

                Case "Pipe Networks"
                    PipeNetworksCkd = True
                    Dim pipe As String = ProjectShortcuts & "PipeNetworks"
                    Dim pipes() As System.IO.FileInfo = New IO.DirectoryInfo(pipe).GetFiles()
                    Dim i As Integer

                    For i = 0 To pipes.Count - 1
                        'Get name of last 6 characters to see if -Q.xml is present
                        FileExtPlus = pipes(i).Name.Substring(pipes(i).Name.LastIndexOf(".") - 2, 6)

                        If Not FileExtPlus = "-Q.xml" Then ExistingFileCheck(pipes(i).Name, "PipeNetworks")
                        If DuplicateFile = False Then CopyShortcuts(pipes(i).Name, "PipeNetworks")
                    Next

                Case "Profiles"
                    ProfilesCkd = True
                    Dim prof As String = ProjectShortcuts & "Profiles"
                    Dim profs() As System.IO.FileInfo = New IO.DirectoryInfo(prof).GetFiles()
                    Dim i As Integer

                    For i = 0 To profs.Count - 1
                        'Get name of last 6 characters to see if -Q.xml is present
                        FileExtPlus = profs(i).Name.Substring(profs(i).Name.LastIndexOf(".") - 2, 6)

                        If Not FileExtPlus = "-Q.xml" Then ExistingFileCheck(profs(i).Name, "Profiles")
                        If DuplicateFile = False Then CopyShortcuts(profs(i).Name, "Profiles")
                    Next

                Case "Surfaces"
                    SurfacesCkd = True
                    Dim surf As String = ProjectShortcuts & "Surfaces"
                    Dim surfs() As System.IO.FileInfo = New IO.DirectoryInfo(surf).GetFiles()
                    Dim i As Integer

                    For i = 0 To surfs.Count - 1
                        'Get name of last 6 characters to see if -Q.xml is present
                        FileExtPlus = surfs(i).Name.Substring(surfs(i).Name.LastIndexOf(".") - 2, 6)

                        If Not FileExtPlus = "-Q.xml" Then ExistingFileCheck(surfs(i).Name, "Surfaces")
                        If DuplicateFile = False Then CopyShortcuts(surfs(i).Name, "Surfaces")
                    Next

                Case "View Frame Groups"
                    ViewFramesCkd = True
                    Dim vf As String = ProjectShortcuts & "ViewFrameGroups"
                    Dim vfs() As System.IO.FileInfo = New IO.DirectoryInfo(vf).GetFiles()
                    Dim i As Integer

                    For i = 0 To vfs.Count - 1
                        'Get name of last 6 characters to see if -Q.xml is present
                        FileExtPlus = vfs(i).Name.Substring(vfs(i).Name.LastIndexOf(".") - 2, 6)

                        If Not FileExtPlus = "-Q.xml" Then ExistingFileCheck(vfs(i).Name, "ViewFrameGroups")
                        If DuplicateFile = False Then CopyShortcuts(vfs(i).Name, "ViewFrameGroups")
                    Next

            End Select
        Next

        Dim frm As foNextSteps = New foNextSteps
        Dim dr As DialogResult
        dr = Autodesk.AutoCAD.ApplicationServices.Application.ShowModalDialog(frm)

        MsgBox("Task is complete.")
        Me.Close()
    End Sub

    Private Sub ExistingFileCheck(FileName As String, objType As String)
        Dim objName As String, File1Q As String, File2 As String

        'Get object name by removing 32 digit serial number and extension (36 count)
        objName = FileName.Substring(0, FileName.LastIndexOf(".") - 2)
        'Set the -Q file name for testing against all other files
        File1Q = objName & "-Q.xml"
        'MsgBox("objName = " & objName & vbCrLf & "File1Q = " & File1Q)

        Dim alg As String = ProjectShortcuts & objType
        Dim checkFiles() As System.IO.FileInfo = New IO.DirectoryInfo(alg).GetFiles()
        Dim b As Integer

        'Loop to process file names to check against original file
        For b = 0 To checkFiles.Count - 1
            File2 = checkFiles(b).Name

            If Not File1Q.Substring(0, File1Q.Length - 6) = FileName.Substring(0, FileName.Length - 6) Then DuplicateFile = False
            'Copy shortcut if file names do not match
            'If Not File1Q = File2 Then CopyShortcuts(FileName, objType)
        Next
    End Sub

    Private Sub CopyShortcuts(FileName As String, objType As String)
        Dim objName As String, fileContents As String, objSerial As String

        'Get object name by removing 32 digit serial number and extension (36 count)
        objName = FileName.Substring(0, FileName.LastIndexOf("_"))
        objSerial = FileName.Substring(FileName.LastIndexOf("_") + 1, 30)

        'MsgBox("object Name = " & objName & vbCrLf & "object Serial num = " & objSerial)

        'Read contents of XML file and replace Pdrive references with desired drive letter
        fileContents = My.Computer.FileSystem.ReadAllText(ProjectShortcuts & objType & "\" & FileName)
        fileContents = fileContents.Replace("P:\", DriveLetter & ":\")
        fileContents = fileContents.Replace(objName, objName & "-" & DriveLetter)



        'Create new data shortcut file
        If Not My.Computer.FileSystem.FileExists(ProjectShortcuts & objType & "\" & objName & "_" & objSerial & "-" & DriveLetter & ".xml") Then _
            My.Computer.FileSystem.WriteAllText(ProjectShortcuts & objType & "\" & objName & "_" & objSerial & "-" & DriveLetter & ".xml", fileContents, True)

    End Sub

End Class