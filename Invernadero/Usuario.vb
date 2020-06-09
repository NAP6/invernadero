Public Class Usuario

    Protected usuariov As String
    Protected correov As String
    Protected contraseniav As String
    Protected invernaderos_propiosv As Registro_invernadero

    Public Sub New()

    End Sub
    Public Sub New(usuario As String, correo As String, contrasenia As String, invernaderos As Registro_invernadero)
        Me.Usuario = usuario
        Me.Correo = correo
        Me.Contrasenia = contrasenia
        Me.Invernaderos_propios = invernaderos
    End Sub
    Public Property Contrasenia As String
        Get
            Return contraseniav
        End Get
        Set(value As String)
            contraseniav = value
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
