Public Class Historico_Invernadero
    Private ambiente_exteriorv As Ambiente
    Private ambiente_interiorv As Ambiente
    Private actuadoresv As Registro_Actuador
    Private fechav As Date

    Public Sub New()

    End Sub

    Public Sub New(ambiente_exterior As Ambiente, ambiente_interior As Ambiente, fecha As Date)
        Me.Ambiente_exterior = ambiente_exterior
        Me.Ambiente_interior = ambiente_interior
        Me.Fecha = fecha
    End Sub

    Public Property Ambiente_exterior As Ambiente
        Get
            Return ambiente_exteriorv
        End Get
        Set(value As Ambiente)
            ambiente_exteriorv = value
        End Set
    End Property

    Public Property Ambiente_interior As Ambiente
        Get
            Return ambiente_interiorv
        End Get
        Set(value As Ambiente)
            ambiente_interiorv = value
        End Set
    End Property

    Public Property Actuadores As Registro_Actuador
        Get
            Return actuadoresv
        End Get
        Set(value As Registro_Actuador)
            actuadoresv = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return fechav
        End Get
        Set(value As Date)
            fechav = value
        End Set
    End Property

    Public Function fechaFormato()
        Return fechav.ToString("yyyy-MM-dd")
    End Function
End Class
