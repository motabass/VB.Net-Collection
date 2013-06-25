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


        If rdAddition.Checked = True Then
            lbSymbol.Text = "+"
            lbErgebnis.Text = rechne_addition(Val(txtZahl1.Text), Val(txtZahl2.Text))
        ElseIf rdSubtraktion.Checked = True Then
            lbSymbol.Text = "-"
            lbErgebnis.Text = rechne_subtraktion(Val(txtZahl1.Text), Val(txtZahl2.Text))
        ElseIf rdMultiplikation.Checked = True Then
            lbSymbol.Text = "x"
            lbErgebnis.Text = rechne_multiplikation(Val(txtZahl1.Text), Val(txtZahl2.Text))
        ElseIf rdDivision.Checked = True Then
            lbSymbol.Text = ":"
            lbErgebnis.Text = rechne_division(Val(txtZahl1.Text), Val(txtZahl2.Text))
        ElseIf rdModulo.Checked = True Then
            lbSymbol.Text = "mod"
            lbErgebnis.Text = rechne_modulo(Val(txtZahl1.Text), Val(txtZahl2.Text))
        End If

    End Sub

    Private Sub rdAddition_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdAddition.CheckedChanged, rdDivision.CheckedChanged, rdModulo.CheckedChanged, rdMultiplikation.CheckedChanged, rdSubtraktion.CheckedChanged
        rechnen()

    End Sub

    Private Sub txtZahl1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtZahl1.KeyPress, txtZahl2.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            rechnen()
        End If
    End Sub
End Class
