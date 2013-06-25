Public Class Auto
    Public Geschwindigkeit As Integer
    Private WithEvents tmrFahren As New Timer
    Private fahrzeug As PictureBox
    Private groesse As Size
    Public richtung As String

    Public ReadOnly Property PosX
        Get
            If richtung = "r" Then
                Return fahrzeug.Location.X + groesse.Width
            Else
                Return fahrzeug.Location.X
            End If
        End Get
    End Property

    Public ReadOnly Property PosY
        Get
            If richtung = "d" Then
                Return fahrzeug.Location.Y + groesse.Height
            Else
                Return fahrzeug.Location.Y
            End If
        End Get
    End Property

    Public Sub New(myform As Form, xpos As Integer, ypos As Integer, laenge As Integer, breite As Integer, direction As String)
        Dim punkt As Point


        richtung = direction

        tmrFahren.Interval = 50

        Geschwindigkeit = 20

        punkt = New Point(xpos, ypos)
        fahrzeug = New PictureBox()
        fahrzeug.Location = punkt

        If direction = "u" Then
            groesse = New Size(breite, laenge)
        ElseIf direction = "l" Then
            groesse = New Size(laenge, breite)
        ElseIf direction = "r" Then
            groesse = New Size(laenge, breite)
        ElseIf direction = "d" Then
            groesse = New Size(breite, laenge)
        End If

        fahrzeug.Size = groesse
        fahrzeug.BackColor = Color.Black
        myform.Controls.Add(fahrzeug)



    End Sub

    Public Sub Starten()
        tmrFahren.Enabled = True
    End Sub

    Public Sub Stoppen()
        tmrFahren.Enabled = False
    End Sub

    Private Sub driving(sender As Object, e As EventArgs) Handles tmrFahren.Tick
        Dim punkt As Point
        If richtung = "u" Then
            punkt = New Point(fahrzeug.Location.X, fahrzeug.Location.Y - Geschwindigkeit)
        ElseIf richtung = "l" Then
            punkt = New Point(fahrzeug.Location.X - Geschwindigkeit, fahrzeug.Location.Y)
        ElseIf richtung = "r" Then
            punkt = New Point(fahrzeug.Location.X + Geschwindigkeit, fahrzeug.Location.Y)
        ElseIf richtung = "d" Then
            punkt = New Point(fahrzeug.Location.X, fahrzeug.Location.Y + Geschwindigkeit)
        End If

        fahrzeug.Location = punkt
    End Sub
End Class
