Public Class Schachbrett
    Private grafik As Graphics
    Private _farbe As Color
    Private _brush As SolidBrush
   
    Public Property Farbe As Color
        Get
            Return _farbe
        End Get
        Set(value As Color)
            _farbe = value
            _brush = New SolidBrush(_farbe)
        End Set
    End Property

    Public Sub drawfields(ByRef picbox As PictureBox, spalten As Integer, zeilen As Integer)
        Dim switch As Boolean
        Dim rowswitch As Boolean = True
        Dim xfeld As Integer = picbox.Width \ spalten
        Dim yfeld As Integer = picbox.Height \ zeilen

        picbox.Image = New Bitmap(picbox.Width, picbox.Height)
        grafik = Graphics.FromImage(picbox.Image)
        grafik.Clear(SystemColors.Control)
        For i As Integer = 0 To spalten - 1
            If rowswitch = True Then
                switch = True
                rowswitch = False
            Else
                switch = False
                rowswitch = True
            End If
            For j As Integer = 0 To zeilen - 1

                If switch = True Then
                    switch = False
                    grafik.FillRectangle(_brush, xfeld * i, yfeld * j, xfeld, yfeld)
                Else
                    switch = True
                    grafik.FillRectangle(Brushes.White, xfeld * i, yfeld * j, xfeld, yfeld)
                End If
            Next
        Next
        picbox.Refresh()
    End Sub
End Class
