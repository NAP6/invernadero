Public Class Usuario
    Protected nombrev As String
    Protected usuariov As String
    Protected correov As String
    Protected invernaderos_propiosv As Registro_invernadero


    Public Property Nombre As String
        Get
            Return nombrev
        End Get
        Set(value As String)
            nombrev = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return usuariov
        End Get
        Set(value As String)
            usuariov = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return correov
        End Get
        Set(value As String)
            correov = value
        End Set
    End Property

    Public Property Invernaderos_propios As Registro_invernadero
        Get
            Return invernaderos_propiosv
        End Get
        Set(value As Registro_invernadero)
            invernaderos_propiosv = value
        End Set
    End Property
End Class
