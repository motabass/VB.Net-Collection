Public Class cPunkt2D
    Protected _x, _y As Double

    Sub New()
        _x = 1
        _y = 1
    End Sub

    Sub New(x As Double, y As Double)
        _x = x
        _y = y
    End Sub

    Public Property X As Double
        Get
            Return _x
        End Get
        Set(value As Double)
            _x = value
        End Set
    End Property

    Public Property Y As Double
        Get
            Return _y
        End Get
        Set(value As Double)
            _y = value
        End Set
    End Property


    Public Overridable Sub setPunkt(x As Double, y As Double)
        _x = x
        _y = y
    End Sub
End Class
