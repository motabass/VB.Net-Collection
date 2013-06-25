Public Class Nahrungsmittel
    Private _name As String
    Private _kkal As Integer

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
    'Public Function GetName()
    '    Return _name
    'End Function

    'Public Sub SetName(name As String)
    '    _name = name
    'End Sub

    Public Property Kalorien As Integer
        Get
            Return _kkal
        End Get
        Set(value As Integer)
            _kkal = value
        End Set
    End Property
    'Public Function GetKalorien()
    '    Return _kkal
    'End Function

    'Public Sub SetKalorien(kalorien As Integer)
    '    _kkal = kalorien
    'End Sub

    Public ReadOnly Property Joule
        Get
            Return _kkal * 4.187
        End Get
    End Property
    'Public Function GetJoule()
    '    Return _kkal * 4.187
    'End Function

    Public Overrides Function ToString() As String
        Return _name & " / " & _kkal
    End Function
End Class
