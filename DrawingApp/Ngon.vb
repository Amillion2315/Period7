Public Class Ngon
    Public Property Pen As Pen
    Public Property Sides As Integer
    Public Property Radius As Integer
    Public Property color1 As Color
    Public Property color2 As Color
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
        Dim points(Sides - 1) As Point

        For index = 0 To Sides - 1
            Dim x As Integer
            Dim y As Integer

            x = Math.Cos(index * 2 * Math.PI / Sides) * Radius
            y = Math.Sin(index * 2 * Math.PI / Sides) * Radius
            points(index) = New Point(m_a.X + x, m_a.Y + y)
        Next
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
