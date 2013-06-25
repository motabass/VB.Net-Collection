Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Apotheke As New BauDenkmal("Graz", 1234, 26, 100, 430000, 1801, 65, "Fassade")

        MsgBox(Apotheke.getGrunddaten & vbNewLine & Apotheke.getHausdaten & vbNewLine & Apotheke.getDenkmaldaten)
    End Sub
End Class
