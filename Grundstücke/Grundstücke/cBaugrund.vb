Public Class cBaugrund
    Inherits cGrundstück

    Protected _baujahr As Integer
    Protected _flaecheHaus As Double

    Public Sub New()
        _baujahr = 1900
        _flaecheHaus = 0
    End Sub

    Public Sub New(ort As String, flur As Integer, flurstück As Integer, flaeche As Double, sachwert As Integer, baujahr As Integer, flaechehaus As Double)
        _ort = ort
        _flur = flur
        _flurStück = flurstück
        _flaeche = flaeche
        _sachwert = sachwert
        _baujahr = baujahr
        _flaecheHaus = flaechehaus
    End Sub

    Public Sub setHausdaten(baujahr As Integer, flaecheHaus As Double)
        _baujahr = baujahr
        _flaecheHaus = flaecheHaus

        _sachwert += _flaecheHaus * 5000
    End Sub

    Public Function getHausdaten() As String
        Return "Baujahr: " & _baujahr & vbNewLine & "Wohnfläche: " & _flaecheHaus
    End Function
End Class
