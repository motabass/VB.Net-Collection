
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub cmdAnmeldung_Click(sender As Object, e As EventArgs) Handles cmdAnmeldung.Click
        DetailsView1.Visible = True
    End Sub

    Protected Sub DetailsView1_ItemInserted(sender As Object, e As DetailsViewInsertedEventArgs) Handles DetailsView1.ItemInserted
        Server.Transfer("danke.aspx")
    End Sub

    Protected Sub DetailsView1_ItemCommand(sender As Object, e As DetailsViewCommandEventArgs) Handles DetailsView1.ItemCommand
        If e.CommandName = "Cancel" Then
            Server.Transfer("Default.aspx")
        End If
    End Sub

    Protected Sub DetailsView1_ItemInserting(sender As Object, e As DetailsViewInsertEventArgs) Handles DetailsView1.ItemInserting
        lblWarnung.Text = ""

        If e.Values("Vorname") = "" Then
            e.Cancel = True
            lblWarnung.Text &= "Geben Sie einen Vornamen ein!" & vbNewLine
        End If

        If e.Values("Nachname") = "" Then
            e.Cancel = True
            lblWarnung.Text &= "Geben Sie einen Nachnamen ein!" & vbNewLine
        End If

        If e.Values("Email") = "" Then
            e.Cancel = True
            lblWarnung.Text &= "Geben Sie eine E-Mail-Adresse ein!" & vbNewLine
        End If
    End Sub

End Class
