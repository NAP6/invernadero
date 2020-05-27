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
            Dim ventana As Control_ventanas = New Control_ventanas()
            ventana.cambiar("escritorio")
        End If
    End Sub
End Class
