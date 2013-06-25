Public Class Kreis

    Private radius_ As Double

    Public Sub New()
        radius_ = 0
    End Sub
    Public Sub New(radius As Double)
        radius_ = radius
    End Sub
    Public Property Radius
        Get
            Return radius_
        End Get
        Set(value)
            If value >= 0 Then
                radius_ = value
            Else
                radius_ = 0
                MsgBox("Radius muss größer/gleich 0 sein!" & vbNewLine & "Radius wurde auf 0 gestetzt.")
            End If
        End Set
    End Property


    'Public Function getRadius() As Double
    '    Return radius_
    'End Function
    'Public Function setRadius(radius As Double) As Boolean
    '    If radius >= 0 Then
    '        radius_ = radius
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function
    Public Property Fläche
        Get
            Return radius_ ^ 2 * Math.PI
        End Get
        Set(value)
            If value >= 0 Then
                radius_ = Math.Sqrt(value / Math.PI)
            Else
                radius_ = 0
                MsgBox("Fläche muss größer/gleich 0 sein!" & vbNewLine & "Fläche wurde auf 0 gestetzt.")
            End If

        End Set
    End Property

    Public Property Umfang
        Get
            Return 2 * radius_ * Math.PI
        End Get
        Set(value)
            If value >= 0 Then
                radius_ = value / (2 * Math.PI)
            Else
                radius_ = 0
                MsgBox("Umfang muss größer/gleich 0 sein!" & vbNewLine & "Umfang wurde auf 0 gestetzt.")
            End If

        End Set
    End Property
    'Public Function getFlaeche() As Double
    '    Return radius_ ^ 2 * Math.PI
    'End Function

    'Public Function getUmfang() As Double
    '    Return 2 * radius_ * Math.PI
    'End Function
End Class
