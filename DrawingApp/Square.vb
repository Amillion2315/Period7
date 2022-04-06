Public Class Square
    Public Property Pen As Pen
    Public Property color1 As Color
    Public Property color2 As Color
    Public Property w As Integer
    Public Property h As Integer
    Public Property xSpeed As Integer
    Public Property ySpeed As Integer

    Public Property fill As Boolean
    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point
    Dim xOffSet As Integer
    Dim yOffSet As Integer

    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a
        m_b = b
    End Sub
    Public Sub Draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            If fill Then
                Dim lingrbrush As Drawing.Drawing2D.LinearGradientBrush
                lingrbrush = New Drawing.Drawing2D.LinearGradientBrush(
                                    New Point(0, 10),
                                    New Point(200, 10),
                                    color1,
                                    color2)
                g.FillRectangle(lingrbrush, m_a.X, m_a.Y, w, h)
            End If
            g.DrawRectangle(Pen, m_a.X + xOffSet, m_a.Y + yOffSet, w, h)
        End Using

    End Sub

End Class
