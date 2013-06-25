Public Class BauDenkmal
    Inherits cBaugrund

    Private _schutz As String

    Public Sub New()
        _schutz = "Unbekannt"
    End Sub

    Public Sub New(ort As String, flur As Integer, flurstück As Integer, flaeche As Double, sachwert As Integer, baujahr As Integer, flaechehaus As Double, schutz As String)
        _ort = ort
        _flur = flur
        _flurStück = flurstück
        _flaeche = flaeche
        _sachwert = sachwert
        _baujahr = baujahr
        _flaecheHaus = flaechehaus
        _schutz = schutz
    End Sub

    Public Property Schutz As String
        Get
            Return _schutz
        End Get
        Set(value As String)
            _schutz = value
        End Set
    End Property

    Public Function getDenkmaldaten() As String
        Return "Geschützter Gebäudeteil: " & _schutz
    End Function
End Class
