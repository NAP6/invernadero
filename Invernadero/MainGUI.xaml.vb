Public Class MainGUI

    Private Property Cliente As Cliente_Broker

    Private Property inver_actual As Integer = 0
    Public Sub New(ByRef cliente As Cliente_Broker)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.Cliente = cliente
        'usuario.Invernaderos_propios.getID(inver_actual).Historial.getFechaAVG()
    End Sub
    Private Sub cargar_datos()

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

    End Sub
End Class
