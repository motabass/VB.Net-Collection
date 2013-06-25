Public Class Zylinder
    Inherits Kreis

    Private _hoehe As Double

    Public Sub New()
        _hoehe = 0
    End Sub

    Public Sub New(radius As Double, hoehe As Double)
        MyBase.Radius = radius
        _hoehe = hoehe
    End Sub

    Public Property Höhe As Double
        Get
            Return _hoehe
        End Get
        Set(value As Double)
            _hoehe = value
        End Set
    End Property

    Public Function getMantel() As Double
        Return MyBase.Umfang * _hoehe
    End Function

    Public Function getVolumen() As Double
        Return MyBase.Fläche * _hoehe
    End Function
End Class
