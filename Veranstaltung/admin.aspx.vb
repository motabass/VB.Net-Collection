
Partial Class admin
    Inherits System.Web.UI.Page

    Sub auth()
        GridView1.Visible = True
        DetailsView1.Visible = True
    End Sub

    Protected Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If txtPW.Text = "geheim" Then
            Session("PWRichtig") = True
            Auth()
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            GridView1.SelectedIndex = 0
        End If

        If Session("PWRichtig") = True Then
            auth()
        End If
    End Sub

    Protected Sub DetailsView1_ItemInserted(sender As Object, e As DetailsViewInsertedEventArgs) Handles DetailsView1.ItemInserted
        GridView1.DataBind()
        GridView1.SelectedIndex = GridView1.Rows.Count - 1
    End Sub

    Protected Sub DetailsView1_ItemUpdated(sender As Object, e As DetailsViewUpdatedEventArgs) Handles DetailsView1.ItemUpdated
        GridView1.DataBind()
    End Sub

    Protected Sub DetailsView1_ItemDeleted(sender As Object, e As DetailsViewDeletedEventArgs) Handles DetailsView1.ItemDeleted
        GridView1.DataBind()
        GridView1.SelectedIndex = GridView1.Rows.Count - 1
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

    Protected Sub DetailsView1_ItemUpdating(sender As Object, e As DetailsViewUpdateEventArgs) Handles DetailsView1.ItemUpdating
        lblWarnung.Text = ""

        If e.NewValues("Vorname") = "" Then
            e.Cancel = True
            lblWarnung.Text &= "Geben Sie einen Vornamen ein!" & vbNewLine
        End If

        If e.NewValues("Nachname") = "" Then
            e.Cancel = True
            lblWarnung.Text &= "Geben Sie einen Nachnamen ein!" & vbNewLine
        End If

        If e.NewValues("Email") = "" Then
            e.Cancel = True
            lblWarnung.Text &= "Geben Sie eine E-Mail-Adresse ein!" & vbNewLine
        End If
    End Sub
End Class
