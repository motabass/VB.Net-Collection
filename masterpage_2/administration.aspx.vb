
Partial Class administration
    Inherits System.Web.UI.Page

    Protected Sub DetailsView1_ItemInserted(sender As Object, e As DetailsViewInsertedEventArgs) Handles DetailsView1.ItemInserted
        GridView1.DataBind()
        GridView1.SelectedIndex = GridView1.Rows.Count - 1

    End Sub

    Protected Sub DetailsView1_ItemUpdated(sender As Object, e As DetailsViewUpdatedEventArgs) Handles DetailsView1.ItemUpdated
        GridView1.DataBind()
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            GridView1.SelectedIndex = 0
        End If

        If Session("PWRichtig") = True Then
            auth()
        End If
    End Sub

    Protected Sub DetailsView1_ItemInserting(sender As Object, e As DetailsViewInsertEventArgs) Handles DetailsView1.ItemInserting
        If IsDate(e.Values("Anzeigen_bis")) Then
            lblWarnung.Text = ""
        Else
            e.Cancel = True
            lblWarnung.Text = "Achtung! Geben Sie ein gültiges Datum ein."
        End If
    End Sub

    Protected Sub DetailsView1_ItemUpdating(sender As Object, e As DetailsViewUpdateEventArgs) Handles DetailsView1.ItemUpdating
        If IsDate(e.NewValues("Anzeigen_bis")) Then
            lblWarnung.Text = ""
        Else
            e.Cancel = True
            lblWarnung.Text = "Achtung! Geben Sie ein gültiges Datum ein."
        End If
    End Sub

    Protected Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        If txtPW.Text = "geheim" Then
            Session("PWRichtig") = True
            Auth()
        End If
    End Sub

    Sub auth()
        GridView1.Visible = True
        DetailsView1.Visible = True
    End Sub
End Class
