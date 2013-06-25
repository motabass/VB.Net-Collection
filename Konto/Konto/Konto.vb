Public Class cKonto

    Private kontoNummer As Long
    Private kontoStand As Double
    Private zinssatz As Single

    Public Sub New()
        kontoStand = 1
        zinssatz = 0.85
    End Sub
    ''' <summary>
    ''' Erzeugt Konto mit Startwerten
    ''' </summary>
    ''' <param name="knummer">Kontonummer</param>
    ''' <param name="kstand">Kontostand</param>
    ''' <param name="zins">Zinssatz</param>
    ''' <remarks></remarks>
    Public Sub New(knummer As Long, kstand As Double, zins As Single)
        kontoNummer = knummer
        kontoStand = kstand
        zinssatz = zins
    End Sub

    Public Function LeseKontonummer()
        Return kontoNummer
    End Function

    Public Function LeseKontostand()
        Return Math.Round(kontoStand, 2)
    End Function

    Public Sub SetKontoNummer(nummer As Long)
        kontoNummer = nummer
    End Sub

    Public Sub Einzahlen(betrag As Double)
        kontoStand += betrag
    End Sub
    ''' <summary>
    ''' Zahlt aufs Konto ein
    ''' </summary>
    ''' <param name="betrag">Geldbetrag</param>
    ''' <param name="umrechner">Umrechnungsfaktor</param>
    ''' <remarks></remarks>
    Public Sub Einzahlen(betrag As Double, umrechner As Double)
        kontoStand += betrag * umrechner
    End Sub

    Public Function Abheben(betrag As Double) As Boolean
        If kontoStand >= betrag Then
            kontoStand -= betrag
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub SetZinssatz(zinssatz As Single)
        Me.zinssatz = zinssatz
    End Sub

    Public Function GetZinssatz()
        Return zinssatz
    End Function


    Public Sub Verzinsen()
        Dim zinsbetrag As Double

        zinsbetrag = kontoStand * zinssatz / 100
        kontoStand = kontoStand + zinsbetrag
    End Sub
End Class
