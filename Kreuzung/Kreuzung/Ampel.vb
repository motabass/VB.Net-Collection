Public Class Ampel
    Public Enum Status
        gruen = 0
        rot = 1
        change = 2
        blink = 3
        yellow = 4
    End Enum

    Private rot As Boolean, gelb As Boolean, gruen As Boolean
    Private state As Status
    Private gruenblinks As Integer
    WithEvents tmrBlinkGelb As New Timer
    WithEvents tmrIntGR As New Timer
    WithEvents tmrBlinkGruen As New Timer
    WithEvents tmrIntGG As New Timer
    WithEvents tmrInterv As New Timer
    Private picRot As PictureBox
    Private picGelb As PictureBox
    Private picGruen As PictureBox
    Private richtung As String
    Private ampGroesse As Size

    Public Event StateChange(status As Integer)

    Public ReadOnly Property StateNow
        Get
            Return state
        End Get
    End Property

    Public ReadOnly Property PosX
        Get
            If richtung = "r" Then
                Return picRot.Location.X + ampGroesse.Width
            Else
                Return picRot.Location.X
            End If
        End Get
    End Property


    Public ReadOnly Property PosY
        Get
            If richtung = "d" Then
                Return picRot.Location.Y + ampGroesse.Height
            Else
                Return picRot.Location.Y
            End If
        End Get
    End Property

    Public Property FarbeRot As Boolean
        Get
            Return rot
        End Get
        Set(value As Boolean)
            rot = value
            gelb = False
            gruen = False
            state = Status.rot
            Call colorschange(gruen, gelb, rot)

        End Set
    End Property


    Public Property FarbeGrün As Boolean
        Get
            Return gruen
        End Get
        Set(value As Boolean)
            gruen = value
            rot = False
            gelb = False
            state = Status.gruen
            Call colorschange(gruen, gelb, rot)
        End Set
    End Property

    Public Sub New(myform As Form, xpos As Integer, ypos As Integer, sizex As Integer, sizey As Integer, direction As String)
        picRot = New PictureBox
        picGelb = New PictureBox
        picGruen = New PictureBox
        Dim punkt As New Point(xpos, ypos)
        Dim groesse As New Size(sizex, sizey)
        picRot.Size = groesse
        picGelb.Size = groesse
        picGruen.Size = groesse

        ampGroesse = groesse
        richtung = direction

        If direction = "u" Then
            picRot.Location = punkt
            punkt = New Point(xpos, ypos + groesse.Height)
            picGelb.Location = punkt
            punkt = New Point(xpos, ypos + (groesse.Height * 2))
            picGruen.Location = punkt
        ElseIf direction = "l" Then
            picRot.Location = punkt
            punkt = New Point(xpos + groesse.Width, ypos)
            picGelb.Location = punkt
            punkt = New Point(xpos + (groesse.Width * 2), ypos)
            picGruen.Location = punkt
        ElseIf direction = "r" Then
            picGruen.Location = punkt
            punkt = New Point(xpos + groesse.Width, ypos)
            picGelb.Location = punkt
            punkt = New Point(xpos + (groesse.Width * 2), ypos)
            picRot.Location = punkt
        ElseIf direction = "d" Then
            picGruen.Location = punkt
            punkt = New Point(xpos, ypos + groesse.Height)
            picGelb.Location = punkt
            punkt = New Point(xpos, ypos + (groesse.Height * 2))
            picRot.Location = punkt
        End If

        myform.Controls.Add(picRot)
        myform.Controls.Add(picGelb)
        myform.Controls.Add(picGruen)


        gruen = True
        rot = False
        gelb = False
        Call colorschange(gruen, gelb, rot)
        state = Status.gruen
        tmrBlinkGelb.Interval = 500
        tmrBlinkGruen.Interval = 350
        tmrIntGR.Interval = 1000
        tmrIntGG.Interval = 1000
        tmrInterv.Interval = 6000
    End Sub

    Public Sub New()
        gruen = True
        rot = False
        gelb = False
        Call colorschange(gruen, gelb, rot)
        state = Status.gruen
        tmrBlinkGelb.Interval = 500
        tmrBlinkGruen.Interval = 350
        tmrIntGR.Interval = 1000
        tmrIntGG.Interval = 1000
        tmrInterv.Interval = 6000
    End Sub

    Public Sub wait()
        tmrInterv.Enabled = True
    End Sub

    Public Sub UmschaltenGruen()
        If state = Status.blink Then
            tmrBlinkGelb.Enabled = False
            tmrInterv.Enabled = False
            tmrBlinkGruen.Enabled = False
            tmrIntGR.Enabled = False
            rot = False
            gelb = False
            gruen = True
            state = Status.gruen
            RaiseEvent StateChange(state)
            Call colorschange(gruen, gelb, rot)
        Else
            rot = False
            gelb = True
            state = Status.yellow
            RaiseEvent StateChange(state)
            Call colorschange(gruen, gelb, rot)
            tmrIntGG.Enabled = True
        End If
    End Sub

    Public Sub UmschaltenRot()
        If state = Status.blink Then
            tmrBlinkGelb.Enabled = False
            tmrInterv.Enabled = False
            tmrIntGR.Enabled = False
            tmrIntGG.Enabled = False

            gelb = False
            'rot = True
            'gruen = False
            'state = Status.rot
            'RaiseEvent StateChange(state)
            'Call colorschange(gruen, gelb, rot)
            state = Status.change
            RaiseEvent StateChange(state)
            tmrBlinkGruen.Enabled = True
        Else
            state = Status.change
            RaiseEvent StateChange(state)
            tmrBlinkGruen.Enabled = True
        End If
    End Sub

    Public Sub Blinken()
        tmrInterv.Enabled = False
        tmrBlinkGruen.Enabled = False
        tmrIntGR.Enabled = False
        tmrIntGG.Enabled = False
        rot = False
        gruen = False
        Call colorschange(gruen, gelb, rot)
        tmrBlinkGelb.Enabled = True


        state = Status.blink
        RaiseEvent StateChange(state)
    End Sub
    Private Sub tmrBlinkGelb_Tick(sender As Object, e As EventArgs) Handles tmrBlinkGelb.Tick
        If gelb = True Then
            gelb = False
            Call colorschange(gruen, gelb, rot)
        Else
            gelb = True
            Call colorschange(gruen, gelb, rot)
        End If
    End Sub

    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmrBlinkGruen.Tick
        If gruenblinks < 6 Then
            If gruen = True Then
                gruen = False
                Call colorschange(gruen, gelb, rot)
            Else
                gruen = True
                Call colorschange(gruen, gelb, rot)
            End If
            gruenblinks += 1
        Else
            gruen = False
            gelb = True
            Call colorschange(gruen, gelb, rot)
            state = Status.yellow
            RaiseEvent StateChange(state)
            tmrIntGR.Enabled = True

            gruenblinks = 0
            tmrBlinkGruen.Enabled = False
        End If
    End Sub


    Private Sub tmr_Tick2(sender As Object, e As EventArgs) Handles tmrIntGR.Tick
        gruen = False
        gelb = False
        rot = True
        Call colorschange(gruen, gelb, rot)
        tmrIntGR.Enabled = False
        state = Status.rot
        RaiseEvent StateChange(state)
    End Sub

    Private Sub tmr_Tick3(sender As Object, e As EventArgs) Handles tmrIntGG.Tick
        rot = False
        gelb = False
        gruen = True
        Call colorschange(gruen, gelb, rot)
        tmrIntGG.Enabled = False
        state = Status.gruen
        RaiseEvent StateChange(state)
    End Sub

    Private Sub tmr_Tick4(sender As Object, e As EventArgs) Handles tmrInterv.Tick
        Select Case state
            Case Status.gruen
                tmrInterv.Enabled = False
                UmschaltenRot()
            Case Status.rot
                tmrInterv.Enabled = False
                UmschaltenGruen()
        End Select
    End Sub

    Private Sub colorschange(gruen As Boolean, gelb As Boolean, rot As Boolean)
        If gruen = True Then
            picGruen.BackColor = Color.Green
        Else
            picGruen.BackColor = Color.DarkGray
        End If

        If gelb = True Then
            picGelb.BackColor = Color.Yellow
        Else
            picGelb.BackColor = Color.DarkGray
        End If

        If rot = True Then
            picRot.BackColor = Color.Red
        Else
            picRot.BackColor = Color.DarkGray
        End If
    End Sub
End Class
