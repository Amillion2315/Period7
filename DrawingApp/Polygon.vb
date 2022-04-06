Public Class Polygon
    Public Property Pen As Pen
    Dim points(2) As Point
    Public Property color1 As Color
    Public Property color2 As Color
    Public Property w As Integer
    Public Property h As Integer

    Public Property fill As Boolean
    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point

    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a
        m_b = b
    End Sub
    Public Sub Draw()
        points(0) = New Point(m_a.X, m_a.Y)
        points(1) = New Point(m_a.X, m_a.Y + h)
        points(2) = New Point(m_a.X + w, m_a.Y)
        Using g As Graphics = Graphics.FromImage(m_image)
            If Fill Then
                Dim lingrbrush As Drawing.Drawing2D.LinearGradientBrush
                lingrbrush = New Drawing.Drawing2D.LinearGradientBrush(
                                    New Point(0, 10),
                                    New Point(200, 10),
                                    Color1,
                                    Color2)
                g.FillPolygon(lingrbrush, points)
            End If
            g.DrawPolygon(Pen, points)
        End Using

    End Sub

End Class
