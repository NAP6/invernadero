﻿Public Class Actuador
    Private nomebrev As String
    Private tipov As String
    Private estadov As Boolean
    Private ultimo_cambiov As Date

    Public Property Nomebre As String
        Get
            Return nomebrev
        End Get
        Set(value As String)
            nomebrev = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return tipov
        End Get
        Set(value As String)
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