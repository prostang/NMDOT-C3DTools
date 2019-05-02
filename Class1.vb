Imports System
Imports System.Windows.Forms
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Drawing
Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.Civil.ApplicationServices



Public Class Class1
    <CommandMethod("ip")>
    Public Sub ip()
        Dim compName As String, compAddr As String
        compName = Net.Dns.GetHostName
#Disable Warning BC40000 ' Type or member is obsolete
        compAddr = Net.Dns.GetHostByName(compName).AddressList(0).ToString()
#Enable Warning BC40000 ' Type or member is obsolete

        MsgBox("Computer name: " & compName & vbCrLf & "Computer Address: " & compAddr)
    End Sub

    <CommandMethod("NMDOTCaddStandards")>
    Public Sub NMDOTCaddStandards()
        Dim fn As String
        fn = "S:\support\docs\NMDOT-CADD-Stds-2018.pdf"
        If My.Computer.FileSystem.FileExists(fn) Then
            System.Diagnostics.Process.Start(fn)
        Else
            MsgBox("CADD Standards not found." & vbCrLf & "Please contact CADD Support", vbOKOnly)
        End If
    End Sub

    <CommandMethod("NMDOTDesignStandards")>
    Public Sub NMDOTDesignStandards()
        Dim fn As String
        fn = "S:\support\docs\NMDOT-Design-Standards-2018.pdf"
        If My.Computer.FileSystem.FileExists(fn) Then
            System.Diagnostics.Process.Start(fn)
        Else
            MsgBox("Design Standards not found." & vbCrLf & "Please contact CADD Support", vbOKOnly)
        End If
    End Sub

    <CommandMethod("bug")>
    Public Sub bug()
        Dim fn As String
        fn = "S:\support\docs\NMDOTBridgeUserGuide.pdf"
        If My.Computer.FileSystem.FileExists(fn) Then
            System.Diagnostics.Process.Start(fn)
        Else
            MsgBox("Bridge User Guide not found." & vbCrLf & "Please contact CADD Support", vbOKOnly)
        End If
    End Sub

    <CommandMethod("NMDOTRequestForm")>
    Public Sub NMDOTRequestForm()
        Dim frm As TemplateRequest = New TemplateRequest
        Dim dr As DialogResult
        dr = Autodesk.AutoCAD.ApplicationServices.Application.ShowModalDialog(frm)
    End Sub

    <CommandMethod("NMDOTDataShortcuts")>
    Public Sub NMDOTDataShortcuts()
        Dim frm As DataShortcuts = New DataShortcuts
        Dim dr As DialogResult
        dr = Autodesk.AutoCAD.ApplicationServices.Application.ShowModalDialog(frm)
    End Sub

    '---------Bridge Palettes Section---------
    <CommandMethod("bd")>
    Public Sub bd()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\BridgeDynamic")
    End Sub

    <CommandMethod("bb")>
    Public Sub bb()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Core.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\BridgeBlocks")
    End Sub

    <CommandMethod("bt")>
    Public Sub bt()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\BridgeTools")
    End Sub
    '---------End of Bridge Palettes Section--------

    '---------Roadway Palettes Section----------
    <CommandMethod("rb")>
    Public Sub rb()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\RoadwayBlocks")
    End Sub

    <CommandMethod("rcom")>
    Public Sub rcom()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\RoadwayCommonSubs")
    End Sub

    <CommandMethod("rcus")>
    Public Sub rcus()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\NMDOTcustomSubs")
    End Sub

    '---------Standard Location for Palettes---------
    <CommandMethod("tps")>
    Public Sub tps()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        Dim defPath As String = "S:\Autodesk\Support\Palettes\Stock"
        ed.Command("*_ToolPalettePath", defPath)
    End Sub

    <CommandMethod("changeUnits")>
    Public Sub changeUnits()
        Dim frm As DWGUnits = New DWGUnits
        Dim dr As DialogResult
        dr = Autodesk.AutoCAD.ApplicationServices.Application.ShowModalDialog(frm)
    End Sub

    '----Traffic Palettes Section----
    <CommandMethod("tGS")>
    Public Sub tGS()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-GuideSigns")
    End Sub

    <CommandMethod("tOMS")>
    Public Sub tOMS()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-ObjectMarkersSigns")
    End Sub

    <CommandMethod("tPSign")>
    Public Sub tPSign()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-PermanentSigning")
    End Sub

    <CommandMethod("tPSt")>
    Public Sub tPSt()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-PermanentStriping")
    End Sub

    <CommandMethod("tRS")>
    Public Sub tRS()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-RegulatorySigns")
    End Sub

    <CommandMethod("tSS")>
    Public Sub tSS()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-SchoolSigns")
    End Sub

    <CommandMethod("traffic")>
    Public Sub traffic()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-Traffic")
    End Sub

    <CommandMethod("tCP")>
    Public Sub tCP()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-TrafficControlPlan")
    End Sub

    <CommandMethod("tCC")>
    Public Sub tCC()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-TrafficControlChannelization")
    End Sub

    <CommandMethod("tCS")>
    Public Sub tCS()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-TrafficControlSigns")
    End Sub

    <CommandMethod("tWS")>
    Public Sub tWS()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-WarningSigns")
    End Sub

    <CommandMethod("tW1")>
    Public Sub tW1()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W1")
    End Sub

    <CommandMethod("tW2W3")>
    Public Sub tW2W3()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W2-W3")
    End Sub

    <CommandMethod("tW4W5")>
    Public Sub tW4W5()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W4-W5")
    End Sub

    <CommandMethod("tW6W7")>
    Public Sub tW6W7()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W6-W7")
    End Sub

    <CommandMethod("tW8W9")>
    Public Sub tW8W9()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W8-W9")
    End Sub

    <CommandMethod("tW10")>
    Public Sub tW10()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W10")
    End Sub

    <CommandMethod("tW11W12")>
    Public Sub tW11W12()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W11-W12")
    End Sub

    <CommandMethod("tW13W15")>
    Public Sub tW13W15()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W13-W14-W15")
    End Sub

    <CommandMethod("tW16W18")>
    Public Sub tW16W18()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W16-W17-W18")
    End Sub

    <CommandMethod("tW20")>
    Public Sub tW20()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W20")
    End Sub

    <CommandMethod("tW21W23")>
    Public Sub tW21W23()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W21-W22-W23")
    End Sub

    <CommandMethod("tW24W25")>
    Public Sub tW24W25()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W24-W25")
    End Sub



    <CommandMethod("UserNotification")>
    Public Sub UserNotification()
        Dim ServerMessage As String = "\\eabrn1\cadd\support\docs\Civil3DMessage.txt"
        Dim ServerMessLog As String = "\\eabrn1\cadd\support\docs\CommunicationLog.txt"

        If My.Computer.FileSystem.FileExists(ServerMessage) Then
            'Get registry value for last message received by user
            Dim LastMessage As Object
            LastMessage = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Environment", "C3DlastMessage", Nothing)
            'Get last edit date from file on server
            Dim FDate = IO.File.GetLastWriteTime(ServerMessage).ToString("yyyy-MM-dd")
            'If dates match, exit
            If FDate = LastMessage Then Exit Sub

            'Call dialog to display message
            Dim cForm As Communication = New Communication
            Dim dr1 As DialogResult
            dr1 = Autodesk.AutoCAD.ApplicationServices.Application.ShowModalDialog(cForm)
        End If
    End Sub

End Class
