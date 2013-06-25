Public Class cPunkt3D

    Inherits cPunkt2D

    Protected _z As Double

    Sub New()
        _z = 1
    End Sub

    Sub New(x As Double, y As Double, z As Double)
        MyBase.New(x, y)
        _z = z
    End Sub

    Public Property Z As Double
        Get
            Return _z
        End Get
        Set(value As Double)
            _z = value
        End Set
    End Property

    Public Overloads Sub setPunkt(x As Double, y As Double, z As Double)
        _x = x
        _y = y
        _z = z
    End Sub
End Class
