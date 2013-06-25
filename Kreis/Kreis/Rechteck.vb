Public Class Rechteck
    Private hoehe_ As Double
    Private breite_ As Double
    Public Sub New()
        hoehe_ = 0
        breite_ = 0
    End Sub

    Public Sub New(hoehe As Double, breite As Double)
        hoehe_ = hoehe
        breite_ = breite
    End Sub
    Public Sub New(laenge As Double)
        hoehe_ = laenge
        breite_ = laenge
    End Sub


    Public Sub setData(hoehe As Double, breite As Double)
        hoehe_ = hoehe
        breite_ = breite
    End Sub

    Public Sub setData(laenge As Double)
        hoehe_ = laenge
        breite_ = laenge
    End Sub

    Public Function getFlaeche() As Double
        Return hoehe_ * breite_
    End Function
End Class
