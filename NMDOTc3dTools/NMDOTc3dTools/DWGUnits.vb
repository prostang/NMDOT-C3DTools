Imports System.Drawing
'Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.DatabaseServices
'Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.ApplicationServices
'Imports Autodesk.Civil.ApplicationServices


Public Class DWGUnits

    'Dim ed As Editor = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor
    Dim msg As String, archType As Boolean, engType As Boolean
    Dim L As Integer, I As Integer, Ltext As String, Itext As String


    Private Sub DWGUnits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UnitsCheck()
        InsertionUnits.Text = Itext
        LengthUnits.Text = Ltext
    End Sub


    Public Function UnitsCheck()
        L = Autodesk.AutoCAD.ApplicationServices.Application.GetSystemVariable("LUNITS")
        I = Autodesk.AutoCAD.ApplicationServices.Application.GetSystemVariable("INSUNITS")
        archType = False
        engType = False

        Select Case L
            Case 1
                Ltext = "Length Units = Scientific"
            Case 2
                Ltext = "Length Units = Decimal"
                engType = True
            Case 3
                Ltext = "Length Units = Engineering"
                engType = True
            Case 4
                Ltext = "Length Units = Architectural"
                archType = True
            Case 5
                Ltext = "Length Units = Fractional"
        End Select

        Select Case I
            Case 0
                Itext = "Insertion Units = Unspecified"
            Case 1
                Itext = "Insertion Units = Inches"
                archType = True
            Case 2
                Itext = "Insertion Units = Feet"
                engType = True
            Case 3
                Itext = "Insertion Units = Miles"
                engType = True
            Case 4
                Itext = "Insertion Units = Millimeters"
                engType = True
            Case 5
                Itext = "Insertion Units = Centimeters"
                engType = True
            Case 6
                Itext = "Insertion Units = Meters"
                engType = True
            Case 7
                Itext = "Insertion Units = Kilometers"
                engType = True
            Case 8
                Itext = "Insertion Units are not set to a Civil-friendly value"
        End Select
    End Function

    Private Sub foChangeUnits_Click(sender As Object, e As EventArgs) Handles foChangeUnits.Click
        If engType = True Then Autodesk.AutoCAD.ApplicationServices.Application.SetSystemVariable("LUNITS", 4)
        If engType = True Then Autodesk.AutoCAD.ApplicationServices.Application.SetSystemVariable("INSUNITS", 0)
        If archType = True Then Autodesk.AutoCAD.ApplicationServices.Application.SetSystemVariable("LUNITS", 2)
        If archType = True Then Autodesk.AutoCAD.ApplicationServices.Application.SetSystemVariable("INSUNITS", 0)

        Dim uc2 = UnitsCheck()

        InsertionUnits.Text = Itext
        LengthUnits.Text = Ltext
    End Sub
End Class