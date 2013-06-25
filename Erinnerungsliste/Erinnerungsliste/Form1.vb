Public Class Form1
    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click

        Call add()

    End Sub

    Private Sub cmdAnzeigen_Click(sender As System.Object, e As System.EventArgs) Handles cmdAnzeigen.Click
        Dim i As Integer, anzeigen As String = ""


        For i = 0 To lstErinnerungen.Items.Count - 1


            If lstErinnerungen.GetSelected(i) Then
                anzeigen &= lstErinnerungen.Items(i) & vbNewLine

            End If

        Next



        MsgBox(anzeigen)

    End Sub

    Sub delAll()
        Dim antwort As MsgBoxResult

        antwort = MsgBox("Sicher?", MsgBoxStyle.YesNo)
        If antwort = MsgBoxResult.Yes Then
            lstErinnerungen.Items.Clear()
            lstFertig.Items.Clear()

        End If


    End Sub

    Private Sub cmdAlle_Click(sender As System.Object, e As System.EventArgs) Handles cmdAlle.Click
        Dim anzeigen As String = ""


        For Each element As String In lstErinnerungen.Items
            anzeigen &= element & vbNewLine
        Next
        MsgBox(anzeigen)
    End Sub

    Private Sub cmdDelAll_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelAll.Click
        Call delAll()
    End Sub

    Private Sub cmdDelChosed_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelChoosed.Click
       
        Call deletechosed(lstErinnerungen)
        Call deletechosed(lstFertig)

    End Sub

    Function deletechosed(mylist As ListBox)
        Dim i As Integer


        Do While i < mylist.Items.Count
            If mylist.GetSelected(i) Then
                mylist.Items.RemoveAt(i)
            Else
                i += 1

            End If

        Loop

        Return 0

    End Function


    Private Sub cmdMove_Click(sender As System.Object, e As System.EventArgs) Handles cmdMove.Click
        Dim i As Integer


        Do While i < lstErinnerungen.Items.Count
            If lstErinnerungen.GetSelected(i) Then
                lstFertig.Items.Add(lstErinnerungen.Items(i))
                lstErinnerungen.Items.RemoveAt(i)

            Else
                i += 1

            End If

        Loop
    End Sub

    Private Sub lstFertig_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles lstFertig.KeyDown
        If e.KeyValue = Keys.Delete Then
            Call deletechosed(lstErinnerungen)
            Call deletechosed(lstFertig)

        End If

    End Sub

    Private Sub lstErinnerungen_KeyDown(sender As Object, e As KeyEventArgs) Handles lstErinnerungen.KeyDown
        If e.KeyValue = Keys.Delete Then
            Call deletechosed(lstErinnerungen)
            Call deletechosed(lstFertig)

        End If




        'Dim pos As Integer
        'pos = lstErinnerungen.SelectedIndex
        'If e.KeyValue = Keys.Delete Then
        '    If lstErinnerungen.SelectedIndex > -1 Then

        '        lstErinnerungen.Items.RemoveAt(pos)
        '        If pos < lstErinnerungen.Items.Count Then
        '            lstErinnerungen.SetSelected(pos, True)
        '        ElseIf pos > 0 Then

        '            lstErinnerungen.SetSelected(pos - 1, True)
        '        End If


        '    End If



        'End If
    End Sub

    Private Sub txtEintrag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEintrag.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Call add()

        End If
    End Sub

    Sub add()

        If txtEintrag.Text <> "" Then
            lstErinnerungen.Items.Add(txtEintrag.Text)
        Else
            MsgBox("Leerer Eintrag")
        End If

        txtEintrag.Focus()
        txtEintrag.SelectAll()


    End Sub

    Private Sub NeuToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles NeuToolStripButton.Click
        Call delAll()
    End Sub

    Private Sub SpeichernToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SpeichernToolStripButton.Click
        Dim antw As DialogResult
        Dim datei As System.IO.FileInfo
        Dim sw As System.IO.StreamWriter

        antw = SaveFileDialog1.ShowDialog

        If antw = Windows.Forms.DialogResult.OK Then
            datei = New System.IO.FileInfo(SaveFileDialog1.FileName)
            sw = datei.CreateText

            For Each element As String In lstErinnerungen.Items
                sw.WriteLine(element)
            Next
            sw.WriteLine("\NEXTLIST")

            For Each element As String In lstFertig.Items
                sw.WriteLine(element)
            Next

            sw.Close()
        End If
    End Sub

    Private Sub ÖffnenToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles ÖffnenToolStripButton.Click
        Dim antw As DialogResult
        Dim datei As System.IO.FileInfo
        Dim sr As System.IO.StreamReader
        Dim gelZeile As String

        antw = OpenFileDialog1.ShowDialog

        If antw = Windows.Forms.DialogResult.OK Then
            datei = New System.IO.FileInfo(OpenFileDialog1.FileName)
            sr = datei.OpenText

            Do
                gelZeile = sr.ReadLine
                If gelZeile <> "\NEXTLIST" Then
                    lstErinnerungen.Items.Add(gelZeile)
                End If
            Loop While gelZeile <> "\NEXTLIST"

            Do
                gelZeile = sr.ReadLine
                lstFertig.Items.Add(gelZeile)
            Loop While Not sr.EndOfStream
            sr.Close()
        End If
    End Sub
End Class
