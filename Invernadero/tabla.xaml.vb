
Public Class tabla
    Public datos As Control_datos


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        datos = New Control_datos()
        Me.DataContext = datos
        Tabla.ItemsSource = datos.datRec

    End Sub
    Private Sub GridBarraTitulo_MouseDown(sender As Object, e As MouseButtonEventArgs)
        DragMove()
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As RoutedEventArgs)
        Application.Current.Shutdown()
    End Sub
    Private Sub Btn_login_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana As Control_ventanas = New Control_ventanas()
        ventana.cambiar("login")
    End Sub
    Private Sub Btn_notificaciones_Click(sender As Object, e As RoutedEventArgs)

    End Sub
    Private Sub btn_escritorio_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana As Control_ventanas = New Control_ventanas()
        ventana.cambiar("escritorio")
    End Sub
    Private Sub btn_perfil_click(sender As Object, e As RoutedEventArgs)
        Dim ventana As Control_ventanas = New Control_ventanas()
        ventana.cambiar("perfil")
    End Sub
    Private Sub btn_tablas_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana As Control_ventanas = New Control_ventanas()
        ventana.cambiar("tablas")
    End Sub
    Private Sub btn_invernadero_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana As Control_ventanas = New Control_ventanas()
        ventana.cambiar("invernadero")
    End Sub
    Private Sub btn_control_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana As Control_ventanas = New Control_ventanas()
        ventana.cambiar("control")
    End Sub
    Private Sub btn_configuracion_Click(sender As Object, e As RoutedEventArgs)
        Dim ventana As Control_ventanas = New Control_ventanas()
        ventana.cambiar("configuracion")
    End Sub

End Class
