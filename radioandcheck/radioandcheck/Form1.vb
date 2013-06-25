Public Class Form1
    Function rechne_addition(zahl1 As Single, zahl2 As Single) As Single
        Return zahl1 + zahl2
    End Function

    Function rechne_subtraktion(zahl1 As Single, zahl2 As Single) As Single
        Return zahl1 - zahl2
    End Function

    Function rechne_division(zahl1 As Single, zahl2 As Single) As Single
        If zahl2 <> 0 Then
            Return zahl1 / zahl2
        Else
            Return False
        End If

    End Function

    Function rechne_multiplikation(zahl1 As Single, zahl2 As Single) As Single
        Return zahl1 * zahl2
    End Function

    Function rechne_modulo(zahl1 As Single, zahl2 As Single) As Single
        Return zahl1 Mod zahl2
    End Function

    Sub rechnen()
        Dim zahl1 As Single, zahl2 As Single

        zahl1 = Val(txtZahl1.Text)
        zahl2 = Val(txtZahl2.Text)

        If rdAddition.Checked = True Then
            lbErgebnis.Text = rechne_addition(zahl1, zahl2)
        ElseIf rdSubtraktion.Checked = True Then
            lbErgebnis.Text = rechne_subtraktion(zahl1, zahl2)
        ElseIf rdMultiplikation.Checked = True Then
            lbErgebnis.Text = rechne_multiplikation(zahl1, zahl2)
        ElseIf rdDivision.Checked = True Then
            lbErgebnis.Text = rechne_division(zahl1, zahl2)
        ElseIf rdModulo.Checked = True Then
            lbErgebnis.Text = rechne_modulo(zahl1, zahl2)
        End If

    End Sub

    Private Sub rdAddition_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdAddition.CheckedChanged, rdDivision.CheckedChanged, rdModulo.CheckedChanged, rdMultiplikation.CheckedChanged, rdSubtraktion.CheckedChanged
        rechnen()

    End Sub
End Class
