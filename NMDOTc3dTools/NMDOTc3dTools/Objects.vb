Namespace Styles
    Public Class BaseStyle
        Private objName As String = Nothing
        Public Property Name() As String
            Get
                Name = objName
            End Get
            Set(ByVal value As String)
                objName = value
            End Set
        End Property
        Private objId As Autodesk.AutoCAD.DatabaseServices.ObjectId = Nothing
        Public Property Id() As Autodesk.AutoCAD.DatabaseServices.ObjectId
            Get
                Id = objId
            End Get
            Set(ByVal value As Autodesk.AutoCAD.DatabaseServices.ObjectId)
                objId = value
            End Set
        End Property
    End Class
End Namespace
