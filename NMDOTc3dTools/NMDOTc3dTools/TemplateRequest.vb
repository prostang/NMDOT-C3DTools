Imports System.Net.Mail
Imports Autodesk.AutoCAD.DatabaseServices

Public Class TemplateRequest
    Dim UserName As String = Environment.UserName
    'Dim myDomain As String = System.Security.Principal.WindowsIdentity.GetCurrent().Name
    Dim myDomain As String = Environment.UserDomainName
    Dim EText As String
    Dim SText As String

    Private Sub foForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        foCategories.Items.Add("Alignments")
        foCategories.Items.Add("Assemblies/Sub")
        foCategories.Items.Add("Corridors")
        foCategories.Items.Add("Layers")
        foCategories.Items.Add("Pipe Networks")
        foCategories.Items.Add("Points/Groups")
        foCategories.Items.Add("Profiles")
        foCategories.Items.Add("Profile Views")
        foCategories.Items.Add("Quantity Takeoff")
        foCategories.Items.Add("Sample Lines")
        foCategories.Items.Add("Sections")
        foCategories.Items.Add("Section Views")
        foCategories.Items.Add("Surfaces")
        foCategories.Items.Add("Survey")
        foCategories.Items.Add("View Frames")
        foCategories.Items.Add("General")
        foCategories.Items.Add("-Select-")
        foCategories.SelectedIndex = 16

        Me.Height = 365
        submit.Enabled = False

    End Sub

    Private Sub foCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles foCategories.SelectedIndexChanged
        Dim CategorySelect As String = foCategories.SelectedItem
        foStylesListing.Items.Clear()

        Select Case CategorySelect
            Case "Alignments"
                foSubLabel.Text = "Sub Category:"
                foSubCategories.Items.Clear()
                foSubCategories.Items.Add("Alignment Styles")
                foSubCategories.Items.Add("Alignment Design Checks")
                foSubCategories.Items.Add("Alignment Label Styles")
                foSubCategories.Items.Add("Alignment Table Styles")
                foSubCategories.Items.Add("Other")
                foSubCategories.Items.Add("Select")
                foSubCategories.SelectedIndex = 5
            Case "Assemblies/Sub"
                foSubLabel.Text = "Sub Category:"
                foSubCategories.Items.Clear()
                foSubCategories.Items.Add("Assembly Styles")
                foSubCategories.Items.Add("Other")
                foSubCategories.Items.Add("Select")
                foSubCategories.SelectedIndex = 2
            Case "Corridors"
                foSubLabel.Text = "Sub Category:"
                foSubCategories.Items.Clear()
                foSubCategories.Items.Add("Corridor Styles")
                foSubCategories.Items.Add("Other")
                foSubCategories.Items.Add("Select")
                foSubCategories.SelectedIndex = 2
            Case "Layers"
                foSubLabel.Text = "Layer Name:"
                Dim acDoc As Autodesk.AutoCAD.ApplicationServices.Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
                Dim acCurDb As Database = acDoc.Database

                Using trans As Transaction = HostApplicationServices.WorkingDatabase.TransactionManager.StartTransaction

                End Using
                Using acTrans As Transaction = acCurDb.TransactionManager.StartTransaction()
                    Dim acTable As LayerTable
                    acTable = acTrans.GetObject(acCurDb.LayerTableId, OpenMode.ForRead)

                    For Each id As ObjectId In acTable
                        Try
                            Dim LayerObj As LayerTableRecord
                            LayerObj = acTrans.GetObject(id, OpenMode.ForRead)
                            foSubCategories.Items.Add(LayerObj.Name)
                        Catch
                        End Try
                    Next
                End Using
            Case "Pipe Networks"
                foSubLabel.Text = "Sub Category:"
                foSubCategories.Items.Clear()
                foSubCategories.Items.Add("Interference Styles")
                foSubCategories.Items.Add("Pipe Styles")
                foSubCategories.Items.Add("Pipe Rule Sets")
                foSubCategories.Items.Add("Pipe Table Styles")
                foSubCategories.Items.Add("Structure Styles")
                foSubCategories.Items.Add("Structure Rule Sets")
                foSubCategories.Items.Add("Stucture Labels")
                foSubCategories.Items.Add("Structure Table Styles")
                foSubCategories.Items.Add("Parts Lists")
                foSubCategories.Items.Add("Other")
                foSubCategories.Items.Add("Select")
                foSubCategories.SelectedIndex = 10
            Case "Points/Groups"
                foSubLabel.Text = "Sub Category:"
                foSubCategories.Items.Clear()
                foSubCategories.Items.Add("Point Styles")
                foSubCategories.Items.Add("Point Labels")
                foSubCategories.Items.Add("Point File Formats")
                foSubCategories.Items.Add("Description Key Sets")
                foSubCategories.Items.Add("Table Styles")
                foSubCategories.Items.Add("Point Groups")
                foSubCategories.Items.Add("Other")
                foSubCategories.Items.Add("Select")
                foSubCategories.SelectedIndex = 7
            Case "Profiles"
                foSubLabel.Text = "Sub Category:"
                foSubCategories.Items.Clear()
                foSubCategories.Items.Add("Profile Styles")
                foSubCategories.Items.Add("Design Checks")
                foSubCategories.Items.Add("Labels")
                foSubCategories.Items.Add("Other")
                foSubCategories.Items.Add("Select")
                foSubCategories.SelectedIndex = 4
            Case "Profile Views"
                foSubLabel.Text = "Sub Category:"
                foSubCategories.Items.Clear()
                foSubCategories.Items.Add("Profile View Styles")
                foSubCategories.Items.Add("Labels")
                foSubCategories.Items.Add("Band Styles")
                foSubCategories.Items.Add("Other")
                foSubCategories.Items.Add("Select")
                foSubCategories.SelectedIndex = 4
            Case "Quantity Takeoff"
                foSubLabel.Text = "Sub Category:"
                foSubCategories.Items.Clear()
                foSubCategories.Items.Add("Criteria")
                foSubCategories.Items.Add("Table Styles")
                foSubCategories.Items.Add("Other")
                foSubCategories.Items.Add("Select")
                foSubCategories.SelectedIndex = 3
            Case "Sample Lines"
                foSubLabel.Text = "Sub Category:"
                foSubCategories.Items.Clear()
                foSubCategories.Items.Add("Sample Lines Styles")
                foSubCategories.Items.Add("Labels")
                foSubCategories.Items.Add("Other")
                foSubCategories.Items.Add("Select")
                foSubCategories.SelectedIndex = 3
            Case "Sections"
                foSubLabel.Text = "Sub Category:"
                foSubCategories.Items.Clear()
                foSubCategories.Items.Add("Section Styles")
                foSubCategories.Items.Add("Labels")
                foSubCategories.Items.Add("Other")
                foSubCategories.Items.Add("Select")
                foSubCategories.SelectedIndex = 3
            Case "Section Views"
                foSubLabel.Text = "Sub Category:"
                foSubCategories.Items.Clear()
                foSubCategories.Items.Add("Section View Styles")
                foSubCategories.Items.Add("Group Plot Styles")
                foSubCategories.Items.Add("Sheet Styles")
                foSubCategories.Items.Add("Labels")
                foSubCategories.Items.Add("Band Styles")
                foSubCategories.Items.Add("Table Styles")
                foSubCategories.Items.Add("Other")
                foSubCategories.Items.Add("Select")
                foSubCategories.SelectedIndex = 7
            Case "Surfaces"
                foSubLabel.Text = "Sub Category:"
                foSubCategories.Items.Clear()
                foSubCategories.Items.Add("Surface Styles")
                foSubCategories.Items.Add("Labels")
                foSubCategories.Items.Add("Table Styles")
                foSubCategories.Items.Add("Other")
                foSubCategories.Items.Add("Select")
                foSubCategories.SelectedIndex = 4
            Case "Survey"
                foSubLabel.Text = "Sub Category:"
                foSubCategories.Items.Clear()
                foSubCategories.Items.Add("Network Styles")
                foSubCategories.Items.Add("Figure Styles")
                foSubCategories.Items.Add("Labels")
                foSubCategories.Items.Add("Other")
                foSubCategories.Items.Add("Select")
                foSubCategories.SelectedIndex = 4
            Case "View Frames"
                foSubLabel.Text = "Sub Category:"
                foSubCategories.Items.Clear()
                foSubCategories.Items.Add("View Frame Styles")
                foSubCategories.Items.Add("Other")
                foSubCategories.Items.Add("Select")
                foSubCategories.SelectedIndex = 2
            Case "General"
                foSubLabel.Text = "Sub Category:"
                foSubCategories.Items.Add("Multipurpose Styles")
                foSubCategories.Items.Add("Labels")
                foSubCategories.Items.Add("Other")
                foSubCategories.Items.Add("Select")
                foSubCategories.SelectedIndex = 3
            Case Else
                foSubCategories.Items.Add("Null")
        End Select
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub foSubCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles foSubCategories.SelectedIndexChanged
        EText = foSubCategories.SelectedItem
        SText = Microsoft.VisualBasic.Right(foSubCategories.SelectedItem, 6)
        foStylesListing.Items.Clear()

        If SText = "Styles" Then
            foStylesListing.Visible = True
            foStylesLabel.Visible = True
            TemplateRequest.ActiveForm.Height = 400
            GetStyles()
        Else
            foStylesListing.Visible = False
            foStylesLabel.Visible = False
            TemplateRequest.ActiveForm.Height = 365
        End If
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles submit.Click

        'If Not UCase(myDomain) = "ASETDM" Then
        If Not UCase(myDomain) = "MJMCONSULTING" Then
            Try
                Dim Smtp_Server As New SmtpClient
                Dim e_mail As New MailMessage()
                Smtp_Server.UseDefaultCredentials = False
                Smtp_Server.Credentials = New Net.NetworkCredential("NMDOTforms@gmail.com", "NMD0T2016")
                'Smtp_Server.Port = 587
                Smtp_Server.Port = 25
                Smtp_Server.EnableSsl = True
                Smtp_Server.Host = "smtp.gmail.com"

                e_mail = New MailMessage()
                e_mail.From = New MailAddress("NMDOTforms@gmail.com")
                'e_mail.To.Add("cadd.support@state.nm.us")
                e_mail.To.Add("prostang1968@gmail.com")
                e_mail.CC.Add(foUsersEmail.Text)
                e_mail.Subject = "Template Change Request: " & foCategories.SelectedItem & ": " & foSubCategories.SelectedItem
                e_mail.IsBodyHtml = True
                e_mail.Body = myDomain & "\" & UserName & " submitted the following:  <BR/><font color=""red"">Category:</font>" & foCategories.SelectedItem & " - " & foSubCategories.SelectedItem & " - " & foStylesListing.SelectedItem &
                "<BR/>" & foComments.Text & "<BR><BR>Person may be contacted at: " & foUsersEmail.Text
                Smtp_Server.Send(e_mail)
                MsgBox("eMail Sent successfully.  Thank you for your submission.")

            Catch error_t As Exception
                MsgBox(error_t.ToString)
            End Try
        Else
            Dim oApp As Microsoft.Office.Interop.Outlook._Application
            oApp = New Microsoft.Office.Interop.Outlook.Application

            Dim oMsg As Microsoft.Office.Interop.Outlook._MailItem
            oMsg = oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)

            oMsg.Subject = "Template Change Request: " & foCategories.SelectedItem & ": " & foSubCategories.SelectedItem
            oMsg.Body = UserName & " submitted the following:  Category:" & foCategories.SelectedItem & " - " & foSubCategories.SelectedItem & " - " & foStylesListing.SelectedItem & vbCrLf & foComments.Text

            'oMsg.To = "cadd.support@state.nm.us"
            oMsg.To = "prostang1968@gmail.com"
            oMsg.CC = foUsersEmail.Text

            oMsg.Send()
        End If

        Me.Close()
    End Sub

    Public Sub GetStyles()
        Dim civDoc As Autodesk.Civil.ApplicationServices.CivilDocument
        civDoc = Autodesk.Civil.ApplicationServices.CivilApplication.ActiveDocument
        Dim aStyles As New List(Of Styles.BaseStyle)
        Dim aStyleObj As Styles.BaseStyle
        Using trans As Transaction = HostApplicationServices.WorkingDatabase.TransactionManager.StartTransaction

            Select Case EText
                Case "Alignment Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.AlignmentStyle
                    For Each id As ObjectId In civDoc.Styles.AlignmentStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Alignment Label Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.AlignmentLabelSetStyle
                    For Each id As ObjectId In civDoc.Styles.LabelSetStyles.AlignmentLabelSetStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Alignment Table Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.TableStyle
                    For Each id As ObjectId In civDoc.Styles.TableStyles.AlignmentSegmentTableStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Alignment Design Checks"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.AlignmentDesignCheckSet
                    For Each id As ObjectId In civDoc.Styles.AlignmentDesignCheckSets
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Surface Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.SurfaceStyle
                    For Each id As ObjectId In civDoc.Styles.SurfaceStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Point Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.PointStyle
                    For Each id As ObjectId In civDoc.Styles.PointStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Profile Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.ProfileStyle
                    For Each id As ObjectId In civDoc.Styles.ProfileStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Profile View Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.ProfileViewStyle
                    For Each id As ObjectId In civDoc.Styles.ProfileViewStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Profile View Band Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.ProfileViewBandSetStyle
                    For Each id As ObjectId In civDoc.Styles.ProfileViewBandSetStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Sample Lines Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.SampleLineStyle
                    For Each id As ObjectId In civDoc.Styles.SampleLineStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Section View Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.SectionViewStyle
                    For Each id As ObjectId In civDoc.Styles.SectionViewStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Section Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.SectionStyle
                    For Each id As ObjectId In civDoc.Styles.SectionStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Band Styles" 'Section View Band Styles
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.SectionViewBandSetStyle
                    For Each id As ObjectId In civDoc.Styles.SectionViewBandSetStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "View Frame Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.ViewFrameStyle
                    For Each id As ObjectId In civDoc.Styles.ViewFrameStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Assembly Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.AssemblyStyle
                    For Each id As ObjectId In civDoc.Styles.AssemblyStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Corridor Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.CorridorStyle
                    For Each id As ObjectId In civDoc.Styles.CorridorStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Pipe Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.PipeStyle
                    For Each id As ObjectId In civDoc.Styles.PipeStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Pipe Rule Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.PipeRuleSetStyle
                    For Each id As ObjectId In civDoc.Styles.PipeRuleSetStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Structure Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.StructureStyle
                    For Each id As ObjectId In civDoc.Styles.StructureStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Pipe Table Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.TableStyle
                    For Each id As ObjectId In civDoc.Styles.TableStyles.PipeTableStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Structure Rule Set Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.StructureRuleSetStyle
                    For Each id As ObjectId In civDoc.Styles.StructureRuleSetStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Structure Table Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.TableStyle
                    For Each id As ObjectId In civDoc.Styles.TableStyles.StructureTableStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Pipe Table Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.TableStyle
                    For Each id As ObjectId In civDoc.Styles.TableStyles.PointTableStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Sheet Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.SheetStyle
                    For Each id As ObjectId In civDoc.Styles.SheetStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
                Case "Figure Styles"
                    Dim aStyle As Autodesk.Civil.DatabaseServices.Styles.SurveyFigureStyle
                    For Each id As ObjectId In civDoc.Styles.SurveyFigureStyles
                        Try
                            aStyle = trans.GetObject(id, OpenMode.ForRead)
                            aStyleObj = New Styles.BaseStyle
                            aStyleObj.Id = aStyle.Id
                            aStyleObj.Name = aStyle.Name
                            aStyles.Add(aStyleObj)
                        Catch
                        End Try
                        foStylesListing.Items.Add(aStyleObj.Name)
                    Next
            End Select
        End Using
    End Sub

    Private Sub foUsersEmail_LostFocus(sender As Object, e As EventArgs) Handles foUsersEmail.LostFocus
        Dim str As String = foUsersEmail.Text
        If str.Contains("@") = True Then
            submit.Enabled = True
        Else
            MsgBox("Please enter a valid email address.")
        End If
    End Sub
End Class