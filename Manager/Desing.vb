Module Desing
    Public Sub Redondear(ByRef xObj As Object)
        Dim Region As New Drawing2D.GraphicsPath()
        Region.StartFigure()
        Region.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        Region.AddLine(10, 0, Convert.ToInt32(xObj.ToString()) - 10, 0)
        Region.AddArc(New Rectangle(Convert.ToInt32(xObj.ToString()) - 10, 0, 10, 10), -90, 90)
        Region.AddLine(Convert.ToInt32(xObj.ToString()), 10, Convert.ToInt32(xObj.ToString()), Convert.ToInt32(xObj.ToString()) - 10)
        Region.AddArc(New Rectangle(Convert.ToInt32(xObj.ToString()) - 10, Convert.ToInt32(xObj.ToString()) - 10, 10, 10), 0, 90)
        Region.AddLine(Convert.ToInt32(xObj.ToString()) - 10, Convert.ToInt32(xObj.ToString()), 10, Convert.ToInt32(xObj.ToString()))
        Region.AddArc(New Rectangle(0, Convert.ToInt32(xObj.ToString()) - 10, 10, 10), 90, 90)
        Region.CloseFigure()
        TryCast(xObj, Control).Region = New Region(Region)
    End Sub

    Public Sub Redondear(ByRef xObj As Object, ByVal xPronunciacion As Integer)
        Dim Region As New Drawing2D.GraphicsPath()
        Region.StartFigure()
        Region.AddArc(New Rectangle(0, 0, xPronunciacion, xPronunciacion), 180, 90)
        Region.AddLine(10, 0, Convert.ToInt32(xObj.ToString()) - xPronunciacion, 0)
        Region.AddArc(New Rectangle(Convert.ToInt32(xObj.ToString()) - xPronunciacion, 0, xPronunciacion, xPronunciacion), -90, 90)
        Region.AddLine(Convert.ToInt32(xObj.ToString()), xPronunciacion, Convert.ToInt32(xObj.ToString()), Convert.ToInt32(xObj.ToString()) - xPronunciacion)
        Region.AddArc(New Rectangle(Convert.ToInt32(xObj.ToString()) - xPronunciacion, Convert.ToInt32(xObj.ToString()) - xPronunciacion, xPronunciacion, xPronunciacion), 0, 90)
        Region.AddLine(Convert.ToInt32(xObj.ToString()) - xPronunciacion, Convert.ToInt32(xObj.ToString()), xPronunciacion, Convert.ToInt32(xObj.ToString()))
        Region.AddArc(New Rectangle(0, Convert.ToInt32(xObj.ToString()) - xPronunciacion, xPronunciacion, xPronunciacion), 90, 90)
        Region.CloseFigure()
        TryCast(xObj, Control).Region = New Region(Region)
    End Sub
End Module
