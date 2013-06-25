Public Class Playlist
    Inherits ListBox

    Public WithEvents bgwAddFiles As New System.ComponentModel.BackgroundWorker

    Private plsaved As Boolean = True
    Private nopls As Boolean = False

    Private liste As ListBox
    Private searching As Boolean = False

    Public Event ItemsChanged(itcount As Integer)
    Public Event FileAddStarted()
    Public Event FileAddProgressChanged(prozent As Integer, element As String)
    Public Event FileAddFinished()

    Public Sub Search(text As String)
        Dim i As Integer
        If searching = False Then
            liste = New ListBox
            For Each element In Me.Items
                liste.Items.Add(element)
                searching = True
            Next
        End If
        Me.Items.Clear()
        For i = 0 To liste.Items.Count - 1
            If liste.Items(i).ToString.ToLower().Contains(text.ToLower) Then
                Me.Items.Add(liste.Items(i))
            End If
        Next
    End Sub
    Public Sub ClearList()
        If bgwAddFiles.IsBusy Then
        Else
            Dim antw As MsgBoxResult

            antw = MsgBox("Wirklich alle Einträge entfernen?", MsgBoxStyle.YesNo)
            If antw = MsgBoxResult.Yes Then
                Me.Items.Clear()
                RaiseEvent ItemsChanged(Me.Items.Count)
            End If
        End If
    End Sub

    Public Sub MoveUp()
        If bgwAddFiles.IsBusy Then
        Else
            Dim temp As New Musikdatei
            Dim i As Integer
            If Me.SelectedIndices.Count > 0 Then
                If Me.SelectedIndices(0) > 0 Then

                    For i = 0 To Me.Items.Count - 1

                        If Me.GetSelected(i) = True Then

                            temp = Me.Items(i - 1)

                            Me.Items(i - 1) = Me.Items(i)

                            Me.Items(i) = temp

                            Me.SetSelected(i - 1, True)
                            Me.SetSelected(i, False)

                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Public Sub MoveDown()
        If bgwAddFiles.IsBusy Then
        Else
            Dim temp As New Musikdatei
            Dim i As Integer
            i = Me.Items.Count - 1
            If Me.SelectedIndices.Count > 0 Then
                If Me.SelectedIndices(Me.SelectedIndices.Count - 1) < Me.Items.Count - 1 Then
                    Do While i >= 0
                        If Me.GetSelected(i) = True Then

                            temp = Me.Items(i + 1)

                            Me.Items(i + 1) = Me.Items(i)

                            Me.Items(i) = temp

                            Me.SetSelected(i + 1, True)
                            Me.SetSelected(i, False)
                        End If
                        i -= 1
                    Loop
                End If
            End If
        End If
    End Sub

    Public Sub Delete()
        If bgwAddFiles.IsBusy Then
        Else
            Dim i As Integer

            Do While i < Me.Items.Count
                If Me.GetSelected(i) = True Then
                    Me.Items.RemoveAt(i)
                Else
                    i += 1
                End If
            Loop
            RaiseEvent ItemsChanged(Me.Items.Count)
        End If
    End Sub

    Public Sub AddDir(ByRef folder As String)

        Dim dir As New IO.DirectoryInfo(folder)
        Dim files() As IO.FileInfo = dir.GetFiles("*.*", IO.SearchOption.AllDirectories)
        Dim dirfiles(files.Count) As String
        Dim i As Integer = 0

        nopls = True
        For Each element As IO.FileInfo In files
            dirfiles(i) = element.FullName
            i += 1
        Next
        AddFile(dirfiles)
    End Sub
    Public Sub AddURL()
        Dim url As New Musikdatei

        url.Pfad = InputBox("Bitte den URL zu einer Datei oder einem Stream eingeben")
        If url.Pfad <> "" Then
            url.Titel = url.Pfad
            Me.Items.Add(url)
            plsaved = False
            RaiseEvent ItemsChanged(Me.Items.Count)
        Else
            Exit Sub
        End If
    End Sub

    Public Sub AddFile(ByRef pfade As String())
        plsaved = False
        RaiseEvent FileAddStarted()
        bgwAddFiles.WorkerSupportsCancellation = True
        bgwAddFiles.RunWorkerAsync(pfade)
    End Sub


    Private Sub bgwAddFiles_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwAddFiles.DoWork
        Dim pfade() As String = DirectCast(e.Argument, String())

        Dim mtitle As Musikdatei
        Dim pfadarray() As String
        Dim myMP3 As ID3TagLibrary.MP3File
        Dim zähler, prozent As Integer

        For Each element As String In pfade
            If bgwAddFiles.CancellationPending = True Then
                e.Cancel = True
                Exit Sub
            End If
            Me.Refresh()
            If Mid(element, Len(element) - 2, 3) = "pls" And nopls = False Then
                AddPLS(element)
            ElseIf Mid(element, Len(element) - 2, 3) = "m3u" And nopls = False Then
                AddM3U(element)
            ElseIf Mid(element, Len(element) - 2, 3) = "mp3" Or Mid(element, Len(element) - 2, 3) = "wma" Or Mid(element, Len(element) - 2, 3) = "avi" Or Mid(element, Len(element) - 2, 3) = "mpg" Or Mid(element, Len(element) - 2, 3) = "wmv" Or Mid(element, Len(element) - 2, 3) = "wav" Then
                Try
                    mtitle = New Musikdatei
                    mtitle.Pfad = element

                    myMP3 = New ID3TagLibrary.MP3File(element)
                    If myMP3.Title = "" Then
                        pfadarray = Split(element, "\")
                        mtitle.Titel = Mid(pfadarray(pfadarray.Count - 1), 1, Len((pfadarray(pfadarray.Count - 1))) - 4)
                    Else
                        mtitle.Titel = myMP3.Title
                    End If
                    Me.Items.Add(mtitle)
                Catch
                End Try
                zähler += 1
                prozent = zähler / pfade.Count * 100
                RaiseEvent FileAddProgressChanged(prozent, element)
                RaiseEvent ItemsChanged(Me.Items.Count)
            End If
        Next
    End Sub

    Private Sub bgwAddFiles_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwAddFiles.RunWorkerCompleted
        nopls = False
        RaiseEvent FileAddFinished()
        RaiseEvent ItemsChanged(Me.Items.Count)
    End Sub


    Public Sub SavePLS(ByRef input As String)
        Dim datei As System.IO.FileInfo
        Dim sw As System.IO.StreamWriter
        Dim i As Integer
        Dim mtitle As Musikdatei

        datei = New System.IO.FileInfo(input)
        sw = datei.CreateText
        sw.WriteLine("[playlist]")

        For i = 1 To Me.Items.Count
            mtitle = Me.Items(i - 1)
            sw.WriteLine("File" & i & "=" & mtitle.Pfad)
            sw.WriteLine("Title" & i & "=" & mtitle.Titel)
        Next
        sw.WriteLine("NumberOfEntries=" & i)
        sw.WriteLine("Version=2")
        sw.Close()
        plsaved = True
    End Sub

    Public Sub SaveM3U(ByVal input As String)
        Dim datei As System.IO.FileInfo
        Dim sw As System.IO.StreamWriter
        Dim i As Integer
        Dim mtitle As Musikdatei

        datei = New System.IO.FileInfo(input)
        sw = datei.CreateText
        sw.WriteLine("#EXTM3U")

        For i = 1 To Me.Items.Count
            mtitle = Me.Items(i - 1)
            sw.WriteLine("#EXTINF:0," & mtitle.Titel)
            sw.WriteLine(mtitle.Pfad)
        Next
        sw.Close()
        plsaved = True
    End Sub
    Public Sub AddM3U(ByVal input As String)
        Dim antw2 As MsgBoxResult
        Dim datei As System.IO.FileInfo
        Dim sr As System.IO.StreamReader
        Dim entry As String

        Dim mtitle As Musikdatei
        Dim pfadarray() As String


        datei = New System.IO.FileInfo(input)
        sr = datei.OpenText

        entry = sr.ReadLine
        If entry = "#EXTM3U" Then
            If Me.Items.Count > 0 And plsaved = False Then
                antw2 = MsgBox("Wirklich neue Playlist laden?" & vbNewLine & "Nicht gespeicherte Playlist wird gelöscht!", MsgBoxStyle.YesNo)
            Else
                antw2 = MsgBoxResult.Yes
            End If
            If antw2 = MsgBoxResult.Yes Then
                Me.Items.Clear()
                Do
                    entry = sr.ReadLine
                    mtitle = New Musikdatei

                    If Mid(entry, 1, 1) = "#" Then
                        Dim komma As Integer, strich As Integer, check As String, i As Integer
                        For i = 1 To Len(entry)
                            check = Mid(entry, i, 1)
                            If check = "," Then
                                komma = i
                            End If
                            If check = "-" Then
                                strich = i
                                Exit For
                            End If
                        Next
                        mtitle.Titel = Mid(entry, strich + 2, Len(entry) - strich)
                        entry = sr.ReadLine
                        mtitle.Pfad = entry
                        Me.Items.Add(mtitle)
                    Else
                        mtitle.Pfad = entry
                        pfadarray = Split(entry, "\")
                        mtitle.Titel = Mid(pfadarray(pfadarray.Count - 1), 1, Len((pfadarray(pfadarray.Count - 1))) - 4)
                        Me.Items.Add(mtitle)
                    End If
                Loop While Not sr.EndOfStream
                sr.Close()
            End If
        Else
            MsgBox("Keine M3U Datei!")
            sr.Close()
        End If
        RaiseEvent ItemsChanged(Me.Items.Count)
    End Sub
    Public Sub AddPLS(ByVal input As String)
        Dim antw2 As MsgBoxResult
        Dim datei As System.IO.FileInfo
        Dim sr As System.IO.StreamReader
        Dim entry As String
        Dim filenumber As Integer = 0
        Dim mtitle As Musikdatei
        'Dim pfadarray() As String
        Dim position As Integer


        datei = New System.IO.FileInfo(input)
        sr = datei.OpenText

        entry = sr.ReadLine
        If entry = "[playlist]" Then
            If Me.Items.Count > 0 And plsaved = False Then
                antw2 = MsgBox("Wirklich neue Playlist laden?" & vbNewLine & "Nicht gespeicherte Playlist wird gelöscht!", MsgBoxStyle.YesNo)
            Else
                antw2 = MsgBoxResult.Yes
            End If
            If antw2 = MsgBoxResult.Yes Then
                Me.Items.Clear()
                Do
                    entry = sr.ReadLine
                    If Mid(entry, 1, 4) = "File" Then
                        If filenumber < 10 Then
                            position = 0
                        ElseIf filenumber < 100 Then
                            position = 1
                        ElseIf filenumber < 1000 Then
                            position = 2
                        ElseIf filenumber < 10000 Then
                            position = 3
                        ElseIf filenumber < 100000 Then
                            position = 4

                        End If

                        mtitle = New Musikdatei
                        mtitle.Pfad = Mid(entry, 7 + position, Len(entry) - 6 + position)
                        entry = sr.ReadLine
                        Dim ist As Integer, check As String, i As Integer
                        For i = 1 To Len(entry)
                            check = Mid(entry, i, 1)
                            If check = "=" Then
                                ist = i
                            End If
                        Next
                        mtitle.Titel = Mid(entry, ist + 1, Len(entry) - ist)
                        'pfadarray = Split(pfad, "\")
                        'mtitle.Titel = Mid(pfadarray(pfadarray.Count - 1), 1, Len((pfadarray(pfadarray.Count - 1))) - 4)
                        Me.Items.Add(mtitle)
                        filenumber += 1
                    End If
                Loop While Not sr.EndOfStream
                sr.Close()
            End If
        Else
            MsgBox("Keine PLS Datei!")
            sr.Close()
        End If
        RaiseEvent ItemsChanged(Me.Items.Count)
    End Sub

    Public Sub New()
        bgwAddFiles.WorkerSupportsCancellation=True
    End Sub
End Class
