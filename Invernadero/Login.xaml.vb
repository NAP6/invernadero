Public Class Login

    Public Sub New()
        InitializeComponent()
        Dim ventana As Control_ventanas = New Control_ventanas()
        If (ventana.getTipo() = "") Then
            ventana.setVentana(Me)
        End If
    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim usuario As String = box_usuario.Text
        Dim contrasenia As String = box_contrasenia.Password
        Dim conexion As ConexiconMysql = New ConexiconMysql()
        If conexion.ComprobarUsuario(usuario, contrasenia) Then
            Dim usuario_class As UsuarioNotify = conexion.getUsuario(usuario)
            Dim brocker As Cliente_Broker
            Dim gui As MainGUI
            brocker = New Cliente_Broker(usuario, contrasenia, usuario_class)
            gui = New MainGUI(brocker)
        End If
    End Sub
End Class
