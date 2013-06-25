Public Class Form1

    Private Sub ÖffnenToolStripButton_Click(sender As Object, e As EventArgs) Handles ÖffnenToolStripButton.Click
        Dim antw As DialogResult
        Dim datei As System.IO.FileInfo
        Dim sr As System.IO.StreamReader
        Dim i As Integer = 0
        Dim durchschnitt As Single, min As Single, max As Single

        antw = OpenFileDialog1.ShowDialog

        If antw = Windows.Forms.DialogResult.OK Then
            datei = New System.IO.FileInfo(OpenFileDialog1.FileName)
            sr = datei.OpenText

            Do
                lstWerte.Items.Add(sr.ReadLine)
                i += 1

            Loop While Not sr.EndOfStream

            sr.Close()

            For Each zahl As String In lstWerte.Items
                durchschnitt += zahl
            Next
            durchschnitt = (durchschnitt / lstWerte.Items.Count) / 10

            i = 0
            For i = 0 To lstWerte.Items.Count - 1
                If i = 0 Then
                    min = lstWerte.Items(i)
                Else
                    min = Math.Min(lstWerte.Items(i) * 10, min)
                End If
            Next


            i = 0
            i = 0
            For i = 0 To lstWerte.Items.Count - 1
                If i = 0 Then
                    max = lstWerte.Items(i)
                Else
                    max = Math.Max(lstWerte.Items(i) * 10, max)
                End If
            Next
            lbMin.Text = "Minimum: " & min / 100
            lbMax.Text = "Maximum: " & max / 100
            lbDurch.Text = "Durchschnitt: " & durchschnitt
        End If
    End Sub

    Private Sub NeuToolStripButton_Click(sender As Object, e As EventArgs) Handles NeuToolStripButton.Click
        Dim antw As MsgBoxResult

        antw = MsgBox("Liste wirklich leeren?", MsgBoxStyle.YesNo)

        If antw = MsgBoxResult.Yes Then
            lstWerte.Items.Clear()
            lbDurch.Text = "Durchschnitt:"
            lbMax.Text = "Maximum:"
            lbMin.Text = "Minimum:"
        End If
    End Sub
End Class
