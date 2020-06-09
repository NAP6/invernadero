Public Class Actuador
    Private nomebrev As String
    Private tipov As Integer
    Private estadov As Boolean
    Private ultimo_cambiov As Date
    Public Sub New()

    End Sub
    Public Sub New(nomebrev As String, tipov As Integer, estadov As Boolean)
        Me.nomebrev = nomebrev
        Me.tipov = tipov
        Me.estadov = estadov
    End Sub


    Public Property Nomebre As String
        Get
            Return nomebrev
        End Get
        Set(value As String)
            nomebrev = value
        End Set
    End Property

    Public Property Tipo As Integer
        Get
            Return tipov
        End Get
        Set(value As Integer)
            tipov = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return estadov
        End Get
        Set(value As Boolean)
            estadov = value
        End Set
    End Property

    Public Property Ultimo_cambio As Date
        Get
            Return ultimo_cambiov
        End Get
        Set(value As Date)
            ultimo_cambiov = value
        End Set
    End Property

End Class
