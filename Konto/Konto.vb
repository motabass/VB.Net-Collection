Public Class cKonto

    Private kontoNummer As Long
    Private kontoStand As Double

    Public Sub LeseKontonummer()
        Return kontonummer
    End Sub

    Public Sub LeseKontostand()
        Return kontoStand
    End Sub

    Public Sub SetKontoNummer(nummer As Long)
        Kontonummer = nummer
    End Sub

    Public Sub Einzahlen(betrag As Integer)
        kontoStand += betrag
    End Sub

    Public Sub Abheben(betrag As Integer)
        kontoStand -= betrag
    End Sub
End Class
