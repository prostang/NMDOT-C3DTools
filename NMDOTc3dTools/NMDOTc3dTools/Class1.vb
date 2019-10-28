Imports System.Drawing
Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.Civil.ApplicationServices
Imports System
Imports System.Windows.Forms
Imports System.IO


Public Class Class1
    <Autodesk.AutoCAD.Runtime.CommandMethod("ip")>
    Public Sub ip()
        Dim compName As String, compAddr As String
        compName = Net.Dns.GetHostName
#Disable Warning BC40000 ' Type or member is obsolete
        compAddr = Net.Dns.GetHostByName(compName).AddressList(0).ToString()
#Enable Warning BC40000 ' Type or member is obsolete

        MsgBox("Computer name: " & compName & vbCrLf & "Computer Address: " & compAddr)
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethod("NMDOTCaddStandards")>
    Public Sub NMDOTCaddStandards()
        Dim fn As String
        fn = "S:\support\docs\NMDOT-CADD-Stds-2018.pdf"
        If My.Computer.FileSystem.FileExists(fn) Then
            System.Diagnostics.Process.Start(fn)
        Else
            MsgBox("CADD Standards not found." & vbCrLf & "Please contact CADD Support", vbOKOnly)
        End If
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("NMDOTDesignStandards")>
    Public Sub NMDOTDesignStandards()
        Dim fn As String
        fn = "S:\support\docs\NMDOT-Design-Standards-2018.pdf"
        If My.Computer.FileSystem.FileExists(fn) Then
            System.Diagnostics.Process.Start(fn)
        Else
            MsgBox("Design Standards not found." & vbCrLf & "Please contact CADD Support", vbOKOnly)
        End If
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("bug")>
    Public Sub bug()
        Dim fn As String
        fn = "S:\support\docs\NMDOTBridgeUserGuide.pdf"
        If My.Computer.FileSystem.FileExists(fn) Then
            System.Diagnostics.Process.Start(fn)
        Else
            MsgBox("Bridge User Guide not found." & vbCrLf & "Please contact CADD Support", vbOKOnly)
        End If
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("NMDOTRequestForm")>
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
    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("bd")>
    Public Sub bd()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\BridgeDynamic")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("bb")>
    Public Sub bb()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Core.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\BridgeBlocks")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("bt")>
    Public Sub bt()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\BridgeTools")
    End Sub
    '---------End of Bridge Palettes Section--------

    '---------Roadway Palettes Section----------
    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("rb")>
    Public Sub rb()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\RoadwayBlocks")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("rcom")>
    Public Sub rcom()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\RoadwayCommonSubs")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("rcus")>
    Public Sub rcus()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\NMDOTcustomSubs")
    End Sub

    <CommandMethod("CivilMultiView")>
    Public Sub CivilMultiView()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\CivilMultiview")
    End Sub

    '---------Standard Location for Palettes---------
    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tps")>
    Public Sub tps()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        Dim defPath As String = "S:\Autodesk\Support\Palettes\Stock"
        ed.Command("*_ToolPalettePath", defPath)
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("changeUnits")>
    Public Sub changeUnits()
        Dim frm As DWGUnits = New DWGUnits
        Dim dr As DialogResult
        dr = Autodesk.AutoCAD.ApplicationServices.Application.ShowModalDialog(frm)
    End Sub

    '----Traffic Palettes Section----
    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tGS")>
    Public Sub tGS()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-GuideSigns")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tOMS")>
    Public Sub tOMS()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-ObjectMarkersSigns")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tPSign")>
    Public Sub tPSign()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-PermanentSigning")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tPSt")>
    Public Sub tPSt()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-PermanentStriping")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tRS")>
    Public Sub tRS()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-RegulatorySigns")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tSS")>
    Public Sub tSS()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-SchoolSigns")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("traffic")>
    Public Sub traffic()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-Traffic")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tCP")>
    Public Sub tCP()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-TrafficControlPlan")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tCC")>
    Public Sub tCC()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-TrafficControlChannelization")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tCS")>
    Public Sub tCS()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-TrafficControlSigns")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tWS")>
    Public Sub tWS()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-WarningSigns")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tW1")>
    Public Sub tW1()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W1")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tW2W3")>
    Public Sub tW2W3()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W2-W3")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tW4W5")>
    Public Sub tW4W5()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W4-W5")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tW6W7")>
    Public Sub tW6W7()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W6-W7")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tW8W9")>
    Public Sub tW8W9()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W8-W9")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tW10")>
    Public Sub tW10()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W10")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tW11W12")>
    Public Sub tW11W12()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W11-W12")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tW13W15")>
    Public Sub tW13W15()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W13-W14-W15")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tW16W18")>
    Public Sub tW16W18()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W16-W17-W18")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tW20")>
    Public Sub tW20()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W20")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tW21W23")>
    Public Sub tW21W23()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W21-W22-W23")
    End Sub

    <Autodesk.AutoCAD.Runtime.CommandMethodAttribute("tW24W25")>
    Public Sub tW24W25()
        Dim acDoc As Document = Core.Application.DocumentManager.MdiActiveDocument
        acDoc.SendStringToExecute("._Toolpalettes ", True, False, False)

        Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
        ed.Command("*_ToolPalettePath", "S:\Autodesk\Support\Palettes\Traffic\NMDOT-W24-W25")
    End Sub

    <CommandMethod("messageUser")>
    Public Sub messageUser()
        Dim ServerMessage As String = "\\eabrn1\cadd\support\docs\Civil3DMessage.txt"
        MsgBox(ServerMessage)
        If My.Computer.FileSystem.FileExists(ServerMessage) Then
            Dim LastMessage As Object
            LastMessage = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Environment", "C3DlastMessage", "Default Value")
            Dim FDate = IO.File.GetLastWriteTime(ServerMessage)
            MsgBox(FDate)
            MsgBox(LastMessage)

        End If

    End Sub

End Class
