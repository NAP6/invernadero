Public Class MainGUI
    Private Property usuario As UsuarioNotify
    Private Property inver_actual As Integer = 0
    Public Sub New(ByRef usuario As UsuarioNotify)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.usuario = usuario
        'usuario.Invernaderos_propios.getID(inver_actual).Historial.getFechaAVG()
        inver_actual = Me.usuario.Invernaderos_propios.Registro_invernadero(0).Id
        For Each inver In Me.usuario.Invernaderos_propios.Registro_invernadero
            combo_invernadero.Items.Add(inver.Nombre)
        Next
        combo_invernadero.SelectedIndex = inver_actual
    End Sub
    Private Sub cargar_datos()
        Tabla.ItemsSource = Me.usuario.Invernaderos_propios.getID(inver_actual).Historial
    End Sub
    Private Sub btn_enfriar_Click(sender As Object, e As RoutedEventArgs)
        'client.Publish(datos.Username + "/" + datos.InvernaderoID + "/actuador/enfriar", Encoding.Default.GetBytes("Activar"))
    End Sub
    Private Sub btn_regar_Click(sender As Object, e As RoutedEventArgs)
        'client.Publish(datos.Username + "/" + datos.InvernaderoID + "/actuador/regar", Encoding.Default.GetBytes("Activar"))
    End Sub
    Private Sub btn_calentar_Click(sender As Object, e As RoutedEventArgs)
        'client.Publish(datos.Username + "/" + datos.InvernaderoID + "/actuador/calentar", Encoding.Default.GetBytes("Activar"))
    End Sub
    Private Sub btn_salir_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub
    Private Sub combo_invernadero_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles combo_invernadero.SelectionChanged
        inver_actual = usuario.Invernaderos_propios.Registro_invernadero(combo_invernadero.SelectedIndex).Id
        cargar_datos()
    End Sub
End Class
