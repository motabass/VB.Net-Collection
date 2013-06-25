Public Class Werkzeug

    Public Enum Modus
        stift = 0
        rechteck = 1
        ellipse = 2
        text = 3
        radierer = 4
        rechteckVoll = 5
        ellipseVoll = 6
    End Enum


    Private farbe_ As Color
    Private brushfarbe_ As SolidBrush
    Private stift_ As Pen
    Private schriftart_ As String
    Private schrift_ As Font
    Private mousepos_ As Point
    Private punkte_ As New List(Of Point)
    Private mode_ As Modus
    Private staerke_ As Integer
    Private fontsize_ As Integer

    Public Property Farbe
        Get
            Return farbe_
        End Get
        Set(value)
            farbe_ = value
            brushfarbe_ = New SolidBrush(farbe_)
            stift_ = New Pen(brushfarbe_, staerke_)
        End Set
    End Property

    Public ReadOnly Property BrushFarbe
        Get
            Return brushfarbe_
        End Get
    End Property

    Public ReadOnly Property Stift
        Get
            Return stift_
        End Get
    End Property

    Public Property Stärke
        Get
            Return staerke_
        End Get
        Set(value)
            staerke_ = value
            stift_ = New Pen(brushfarbe_, staerke_)
        End Set
    End Property

    Public Property Mode
        Get
            Return mode_
        End Get
        Set(value)
            mode_ = value
        End Set
    End Property

    Public Property Punkte
        Get
            Return punkte_
        End Get
        Set(value)
            punkte_.Add(value)
        End Set
    End Property

    Public ReadOnly Property AnzahlPunkte
        Get
            Return punkte_.Count
        End Get
    End Property

    Public Property MausPosition
        Get
            Return mousepos_
        End Get
        Set(value)
            mousepos_ = value
        End Set
    End Property


    Public ReadOnly Property Schrift
        Get
            Return schrift_
        End Get
    End Property

    Public Property Schriftart
        Get
            Return schriftart_
        End Get
        Set(value)
            schriftart_ = value
            schrift_ = New Font(schriftart_, fontsize_)
        End Set
    End Property

    Public Property Schriftgröße
        Get
            Return fontsize_
        End Get
        Set(value)
            fontsize_ = value
            schrift_ = New Font(schriftart_, fontsize_)
        End Set
    End Property
    Sub New()
        farbe_ = Color.Black
        staerke_ = 1
        brushfarbe_ = New SolidBrush(farbe_)
        stift_ = New Pen(brushfarbe_, staerke_)

        schriftart_ = "Arial"
        fontsize_ = 12
        schrift_ = New Font(schriftart_, fontsize_)

        mode_ = 0
    End Sub


    Sub New(col As Color, sta As Integer, fon As String,fonsize As Integer)
        farbe_ = col
        staerke_=sta
        brushfarbe_ = New SolidBrush(farbe_)
        stift_ = New Pen(brushfarbe_, staerke_)

        schriftart_ = fon
        fontsize_=fonsize
        schrift_ = New Font(schriftart_, fontsize_)

        mode_ = 0
    End Sub

End Class
