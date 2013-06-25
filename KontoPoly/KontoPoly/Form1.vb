Public Class Form1

    Private Sub cmdGiro_Click(sender As Object, e As EventArgs) Handles cmdGiro.Click
        Dim neuKonto As cGirokonto

        neuKonto = New cGirokonto(InputBox("Kontonummer:"), 0, InputBox("Dispolimit:"))


        lstKonten.Items.Add(neuKonto)

        lstKonten.SetSelected(lstKonten.Items.Count - 1, True)

    End Sub

    Private Sub cmdSpar_Click(sender As Object, e As EventArgs) Handles cmdSpar.Click

        Dim neuKonto As cSparkonto

        neuKonto = New cSparkonto(InputBox("Kontonummer:"), 0, InputBox("Sperrfrist:"))


        lstKonten.Items.Add(neuKonto)

        lstKonten.SetSelected(lstKonten.Items.Count - 1, True)

    End Sub

    Private Sub lstKonten_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstKonten.SelectedIndexChanged

        Dim nowKonto As cKonto

        nowKonto = lstKonten.SelectedItem

        lbInfos.Text = nowKonto.drucken
    End Sub

    Private Sub cmdBuchen_Click(sender As Object, e As EventArgs) Handles cmdBuchen.Click
        Dim nowKonto As cKonto

        nowKonto = lstKonten.SelectedItem

        nowKonto.buchen(InputBox("Betrag Auf/Abbuchen:"))

        lstKonten.SelectedItem = nowKonto

        lbInfos.Text = nowKonto.drucken
    End Sub
End Class
