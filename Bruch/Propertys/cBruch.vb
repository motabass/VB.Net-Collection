Public Class cBruch
    Private _zaehler As Integer
    Private _nenner As Integer

    Public Property Zähler As Integer
        Get
            Return _zaehler
        End Get
        Set(value As Integer)
            _zaehler = value
        End Set
    End Property

    Public Property Nenner As Integer
        Get
            Return _nenner
        End Get
        Set(value As Integer)
            If value > 0 Then
                _nenner = value
            Else
                MsgBox("Der Nenner darf nicht NULL sein!")
                _nenner = 1
            End If
        End Set
    End Property

    Public Sub New()
        _nenner = 1
        _zaehler = 1
    End Sub

    Public Sub New(zaehler As Integer, nenner As Integer)
        _nenner = nenner
        _zaehler = zaehler
    End Sub

    Public Function getWert() As Double
        Return _zaehler / _nenner
    End Function

    Private Function ggt(z1 As Long, z2 As Long) As Long
        Dim rest As Long
        Do
            rest = z1 Mod z2
            z1 = z2
            z2 = rest
        Loop While z2 <> 0
        Return z1
    End Function


    Private Function kgv(z1 As Long, z2 As Long) As Long
        Return z1 * z2 / ggt(z1, z2)
    End Function

    Public Sub kuerzen()
        Dim groessterGT As Long = ggt(_zaehler, _nenner)

        _zaehler = _zaehler / groessterGT
        _nenner = _nenner / groessterGT
    End Sub
    ''' <summary>
    ''' Addiert einen Bruch
    ''' </summary>
    ''' <param name="z">Zähler</param>
    ''' <param name="n">Nenner</param>
    ''' <remarks></remarks>
    Public Sub addiere(z As Long, n As Long)
        Dim zaehler, nenner As Long

        zaehler = _zaehler
        nenner = _nenner

        zaehler = zaehler * n
        nenner = nenner * n

        z = z * _nenner

        _zaehler = zaehler + z
        _nenner = nenner
    End Sub

    Public Sub multipliziere(z As Long, n As Long)
        Dim zaehler, nenner As Long

        zaehler = _zaehler
        nenner = _nenner

        zaehler *= z
        nenner *= n

        _zaehler = zaehler
        _nenner = nenner
    End Sub
End Class
