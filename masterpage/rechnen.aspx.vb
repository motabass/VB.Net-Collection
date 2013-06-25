
Partial Class _Default
    Inherits System.Web.UI.Page

    Public Sub zufallszahl()
        Dim rnd As New Random

        lbZahl1.Text = rnd.Next(1, 50)
        lbZahl2.Text = rnd.Next(1, 50)
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If IsPostBack Then
        Else
            zufallszahl()
            Session("Richtige") = 0
            Session("Falsche") = 0
        End If
    End Sub

    Protected Sub cmdBerechnen_Click(sender As Object, e As EventArgs) Handles cmdBerechnen.Click
        If CInt(txtErg.Text) = CInt(lbZahl1.Text) + CInt(lbZahl2.Text) Then
            lbRichtig.ForeColor = Drawing.Color.Green
            lbRichtig.Text = "Richtig!"
            Session("Richtige") += 1
            lbRi.Text = "Richtig: " & Session("Richtige")
        Else
            lbRichtig.ForeColor = Drawing.Color.Red
            lbRichtig.Text = "Falsch!"
            Session("Falsche") += 1
            lbFa.Text = "Falsch: " & Session("Falsche")
        End If
    End Sub

    Protected Sub cmdNeu_Click(sender As Object, e As EventArgs) Handles cmdNeu.Click
        lbRichtig.Text = ""
        zufallszahl()
    End Sub
End Class
