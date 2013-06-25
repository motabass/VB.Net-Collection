
Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub cmdBerechne_Click(sender As Object, e As EventArgs) Handles cmdBerechne.Click
        Dim kcal As Integer
        Select Case ddGeschlecht.SelectedIndex
            Case 0
                kcal = 65.5 + 9.5999999999999996 * CInt(txtGewicht.Text) + 1.8999999999999999 * CInt(txtGroesse.Text) - 4.7000000000000002 * CInt(txtAlter.Text)
            Case 1
                kcal = 66.5 + 13.800000000000001 * CInt(txtGewicht.Text) + 5 * CInt(txtGroesse.Text) - 6.7999999999999998 * CInt(txtAlter.Text)
        End Select

        Select Case rdlAktiv.SelectedIndex
            Case 1
                kcal *= 1.2
            Case 2
                kcal *= 1.45
            Case 3
                kcal *= 1.6499999999999999
            Case 4
                kcal *= 1.8500000000000001
            Case 5
                kcal *= 2.2000000000000002
        End Select

        lblKcal.Text = kcal
    End Sub

    Protected Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        ddGeschlecht.ClearSelection()
        txtAlter.Text = ""
        txtGewicht.Text = ""
        txtGroesse.Text = ""
        rdlAktiv.ClearSelection()
        lblKcal.Text = ""
    End Sub
End Class
