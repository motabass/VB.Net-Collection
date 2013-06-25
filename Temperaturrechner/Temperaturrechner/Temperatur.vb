Public Class Temperatur
    Private tempC As Single

    Public Property Celsius
        Get
            Return tempC
        End Get
        Set(value)
            tempC = value
        End Set
    End Property


    Public Property Fahrenheit
        Get
            Return tempC * 1.8 + 32
        End Get
        Set(value)
            tempC = (value - 32) / 1.8
        End Set
    End Property


    Public Sub New()
        tempC = 20
    End Sub

    Public Sub New(starttemp As Single)
        tempC = starttemp
    End Sub
End Class
