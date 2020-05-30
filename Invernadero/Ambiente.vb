Public Class Ambiente
    Private temperaturav As Double
    Private humedad_airev As Double
    Private co2v As Double
    Private humedad_suelov As Double

    Public Sub New()

    End Sub

    Public Sub New(teperatura As Double, humedad_suelo As Double, humedad_aire As Double, co2 As Double)
        Me.Temperatura = teperatura
        Me.Humedad_suelo = humedad_suelo
        Me.Humedad_aire = humedad_aire
        Me.Co2 = co2
    End Sub

    Public Property Temperatura As Double
        Get
            Return temperaturav
        End Get
        Set(value As Double)
            temperaturav = value
        End Set
    End Property

    Public Property Humedad_aire As Double
        Get
            Return humedad_airev
        End Get
        Set(value As Double)
            humedad_airev = value
        End Set
    End Property

    Public Property Humedad_suelo As Double
        Get
            Return humedad_suelov
        End Get
        Set(value As Double)
            humedad_suelov = value
        End Set
    End Property

    Public Property Co2 As Double
        Get
            Return co2v
        End Get
        Set(value As Double)
            co2v = value
        End Set
    End Property

End Class
