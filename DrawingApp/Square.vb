Public Class Square
    Public Property Pen As Pen
    Public Property w As Integer
    Public Property h As Integer
    Public Property xSpeed As Integer
    Public Property ySpeed As Integer

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
            g.DrawRectangle(Pen, m_a.X + xOffSet, m_a.Y + yOffSet, w, h)
        End Using

    End Sub

End Class
