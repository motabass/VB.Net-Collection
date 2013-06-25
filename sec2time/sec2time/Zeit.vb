Public Class Zeit
    Private sec As Integer

    Public Property Sekunden
        Get
            Return sec
        End Get
        Set(value)
            sec = value
        End Set
    End Property

    Public Function getSekundenUhr() As Integer
        Dim secrest As Integer
        Math.DivRem(sec, 60, secrest)
        Return secrest
    End Function

    Public Function getMinutenUhr() As Integer
        Dim min, stu As Integer
        min = Math.Floor(sec / 60)
        stu = Math.Floor(min / 60)

        Return min - (stu * 60)
    End Function

    Public Function getStundenUhr() As Integer
        Dim min, stu, tag As Integer
        min = Math.Floor(sec / 60)
        stu = Math.Floor(min / 60)
        tag = Math.Floor(stu / 24)

        Return stu - (tag * 24)
    End Function

    Public Function getSekunden() As Integer
        Return sec
    End Function

    Public Function getMinuten() As Integer
        Return Math.Floor(sec / 60)
    End Function

    Public Function getStunden() As Integer
        Return Math.Floor(Math.Floor(sec / 60) / 60)
    End Function

    Public Function getTage() As Integer
        Return Math.Floor(Math.Floor(Math.Floor(sec / 60) / 60) / 24)
    End Function

    Public Function getClock() As String
        Dim sec2, min, stu, tag As Integer
        min = Math.Floor(sec / 60)
        stu = Math.Floor(min / 60)
        tag = Math.Floor(stu / 24)

        sec2 = sec - (min * 60)
        min = min - (stu * 60)
        stu = stu - (tag * 24)

        Return tag & "T " & stu.ToString("00") & ":" & min.ToString("00") & ":" & sec2.ToString("00")
    End Function
End Class
