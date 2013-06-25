Public Class cGrundstück

    Protected _ort As String
    Protected _flur As Integer
    Protected _flurStück As Integer
    Protected _flaeche As Double
    Protected _sachwert As Integer


    Public Sub New()
        _ort = "Unbekannt"
        _flur = 0
        _flurStück = 0
        _flaeche = 0
        _sachwert = 0
    End Sub

    Public Sub New(ort As String, flur As Integer, flurstück As Integer, flaeche As Double, sachwert As Integer)
        _ort = ort
        _flur = flur
        _flurStück = flurstück
        _flaeche = flaeche
        _sachwert = sachwert
    End Sub

    Public Sub setGrunddaten(ort As String, flur As Integer, flurStück As Integer, flaeche As Double)
        _ort = ort
        _flur = flur
        _flurStück = flurStück
        _flaeche = flaeche

        _sachwert = _flaeche * 80
    End Sub

    Public Function getGrunddaten() As String
        Return "Ort: " & _ort & vbNewLine & "Flur: " & _flur & vbNewLine & "Flür-Stück: " & _flurStück & vbNewLine & "Fläche: " & _flaeche & vbNewLine & "Sachwert: " & _sachwert
    End Function

End Class
