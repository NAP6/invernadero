Imports M2Mqtt
Imports M2Mqtt.Messages
Imports System.Text
Imports System.Threading
Public Class Control
    Public Property datos As Control_datos
    Dim client As MqttClient
    Dim Msg As StringBuilder = New StringBuilder(4096)

    Public Sub New()
        InitializeComponent()
        datos = New Control_datos()
        Mqtt_init()
        DataContext = Me
    End Sub
    Private Sub Mqtt_init()
        Try
            client = New MqttClient(datos.Servidor)

            AddHandler client.MqttMsgPublishReceived, AddressOf Client_MqttMsgPublishReceived
            AddHandler client.ConnectionClosed, AddressOf Client_Disconnect

            client.Connect(datos.MqttID, datos.Username, datos.Password)

            If Not client.IsConnected Then
                MsgBox("No se pudo establecer coneccion con el broker")
            End If

            Dim Topic() As String = {datos.Username + "/" + datos.InvernaderoID + "/actuador/enfriar/respuesta", datos.Username + "/" + datos.InvernaderoID + "/actuador/calentar/respuesta", datos.Username + "/" + datos.InvernaderoID + "/actuador/regar/respuesta"}
            Dim Qos() As Byte = {0, 0, 0}
            client.Subscribe(Topic, Qos)
        Catch ex As M2Mqtt.Exceptions.MqttClientException
            MsgBox(ex.Message(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Client_MqttMsgPublishReceived(ByVal sender As Object, ByVal e As MqttMsgPublishEventArgs)
        Select Case e.Topic.ToString()
            Case datos.Username + "/" + datos.InvernaderoID + "/actuador/enfriar/respuesta"
                MsgBox("Enfriarr: " + Encoding.Default.GetString(e.Message))
            Case datos.Username + "/" + datos.InvernaderoID + "/actuador/calentar/respuesta"
                MsgBox("Calentar: " + Encoding.Default.GetString(e.Message))
            Case datos.Username + "/" + datos.InvernaderoID + "/actuador/regar/respuesta"
                MsgBox("Regar: " + Encoding.Default.GetString(e.Message))
            Case Else
                MsgBox("Publicado en: " + e.Topic.ToString + " : " + Encoding.Default.GetString(e.Message))
        End Select
    End Sub
    Private Sub Client_Disconnect(sender As Object, e As EventArgs)

    End Sub
    Private Sub GridBarraTitulo_MouseDown(sender As Object, e As MouseButtonEventArgs)
        DragMove()
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As RoutedEventArgs)
        If (client IsNot Nothing AndAlso client.IsConnected()) Then
            client.Disconnect()
        End If
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

    Private Sub btn_enfriar_Click(sender As Object, e As RoutedEventArgs)
        client.Publish(datos.Username + "/" + datos.InvernaderoID + "/actuador/enfriar", Encoding.Default.GetBytes("Activar"))
    End Sub
    Private Sub btn_regar_Click(sender As Object, e As RoutedEventArgs)
        client.Publish(datos.Username + "/" + datos.InvernaderoID + "/actuador/regar", Encoding.Default.GetBytes("Activar"))
    End Sub
    Private Sub btn_calentar_Click(sender As Object, e As RoutedEventArgs)
        client.Publish(datos.Username + "/" + datos.InvernaderoID + "/actuador/calentar", Encoding.Default.GetBytes("Activar"))
    End Sub
End Class
