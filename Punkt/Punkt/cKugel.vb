Public Class cKugel
    Inherits cPunkt3D

    Private _radius As Double

    Public Function getRadius() As Double
        Return _radius
    End Function

    Public Sub setKugel(x As Double, y As Double, z As Double, r As Double)
        _x = x
        _y = y
        _z = z
        _radius = r
    End Sub
End Class
