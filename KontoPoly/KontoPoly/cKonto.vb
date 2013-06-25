Public Class cKonto
    Protected _knummer As String
    Protected _kstand As Double


    Public Sub New(knummer As String, kstand As Double)
        _knummer = knummer
        _kstand = kstand
    End Sub

    Public Sub buchen(betrag As Double)
        _kstand += betrag
    End Sub

    Public Overridable Function drucken() As String
        Return "Kontonummer: " & _knummer & vbNewLine & "Kontostand: " & _kstand
    End Function

End Class
