Public Class Form1
    Public meinKonto As New cKonto(92171, 130, 0.8)

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MsgBox("Aktueller Kontostand: " & meinKonto.LeseKontostand & vbNewLine & "KontoNummer: " & meinKonto.LeseKontonummer & vbNewLine & "Zinssatz: " & meinKonto.GetZinssatz)
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        meinKonto.Einzahlen(InputBox("Betrag:"))
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim erg As Boolean

        erg = meinKonto.Abheben(InputBox("Betrag:"))

        If erg = False Then
            MsgBox("Kontostand zu niedrig!")
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        meinKonto.SetKontoNummer(InputBox("Kontonummer:"))
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        meinKonto.SetZinssatz(InputBox("Zinssatz:"))
    End Sub


    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        meinKonto.Verzinsen()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        meinKonto.Einzahlen(InputBox("Betrag:"), InputBox("Faktor:"))
    End Sub
End Class
