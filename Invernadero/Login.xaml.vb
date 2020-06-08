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

        If usuario = "nicolas" And contrasenia = "1234" Then
            Dim usuario_class As UsuarioNotify = New UsuarioNotify()
            Dim brocker As Cliente_Broker
            Dim gui As MainGUI
            'Todas las consultas de la base de datos para llenar la variable usuario van aqui
            '####################################
            '####################################
            '####################################
            brocker = New Cliente_Broker(usuario, contrasenia, usuario_class)
            gui = New MainGUI(usuario_class)
        End If
    End Sub
End Class
