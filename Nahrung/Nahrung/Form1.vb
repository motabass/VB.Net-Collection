Public Class Form1



    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        Dim myNahrung As New Nahrungsmittel
        myNahrung.Name = InputBox("Name:")
        myNahrung.Kalorien = InputBox("Kalorien")

        lstNahrung.Items.Add(myNahrung)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstNahrung.SelectedIndexChanged
        Dim myNahrung As New Nahrungsmittel
        If lstNahrung.SelectedIndex >= 0 Then
            myNahrung = lstNahrung.SelectedItem
            lbName.Text = myNahrung.Name
            lbKkal.Text = myNahrung.Kalorien
            lbJoule.Text = myNahrung.Joule
        End If
    End Sub
End Class
