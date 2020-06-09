Public Class Invernadero
    Private idv As Integer
    Private nombrev As String
    Private descripcionv As String
    Private ambiente_interiorv As Ambiente
    Private ambiente_exteriorv As Ambiente
    Private actuadoresv As Registro_Actuador
    Private historialv As Historial_Invernadero

    Public Sub New()

    End Sub
    Public Sub New(id As Integer, nombre As String, descripcion As String, ambiente_exterior As Ambiente, ambiente_interior As Ambiente, actuadores As Registro_Actuador, historial As Historial_Invernadero)
        Me.Id = id
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Ambiente_exterior = ambiente_exterior
        Me.Ambiente_interior = ambiente_interior
        Me.Actuadores = actuadores
        Me.Historial = historial
    End Sub

    Public Property Id As Integer
        Get
            Return idv
        End Get
        Set(value As Integer)
            idv = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return nombrev
        End Get
        Set(value As String)
            nombrev = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return descripcionv
        End Get
        Set(value As String)
            descripcionv = value
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

    Public Property Ambiente_exterior As Ambiente
        Get
            Return ambiente_exteriorv
        End Get
        Set(value As Ambiente)
            ambiente_exteriorv = value
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

    Public Property Historial As Historial_Invernadero
        Get
            Return historialv
        End Get
        Set(value As Historial_Invernadero)
            historialv = value
        End Set
    End Property
End Class
