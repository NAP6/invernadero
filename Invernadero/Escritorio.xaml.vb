Imports M2Mqtt
Imports M2Mqtt.Messages
Imports System.Net
Imports System.Text
Imports System.Threading

Public Class Escritorio


    Public Property datos As Control_datos
    Dim client As MqttClient
    Dim Msg As StringBuilder = New StringBuilder(4096)

    Public Sub New()
        InitializeComponent()
        datos = New Control_datos()
        Me.DataContext = datos
        Mqtt_init()



    End Sub


    Private Sub Mqtt_init()
        Try
            ', datos.puertoMqtt, True, Nothing, Nothing, MqttSslProtocols.TLSv1_
            client = New MqttClient(IPAddress.Parse(datos.Servidor), datos.puertoMqtt, False, Nothing, Nothing, MqttSslProtocols.TLSv1_2)
            AddHandler client.MqttMsgPublishReceived, AddressOf Client_MqttMsgPublishReceived
            AddHandler client.ConnectionClosed, AddressOf Client_Disconnect
            client.Connect(datos.MqttID, datos.Username, datos.Password)
            If Not client.IsConnected Then
                MsgBox("No se pudo establecer coneccion con el broker")
            End If

            Dim Topic() As String = {datos.Username + "/" + datos.InvernaderoID + "/sensor/in_T", datos.Username + "/" + datos.InvernaderoID + "/sensor/out_T", datos.Username + "/" + datos.InvernaderoID + "/sensor/in_H", datos.Username + "/" + datos.InvernaderoID + "/sensor/out_H", datos.Username + "/" + datos.InvernaderoID + "/sensor/in_C", datos.Username + "/" + datos.InvernaderoID + "/sensor/out_C"}
            Dim Qos() As Byte = {0, 0, 0, 0, 0, 0}
            client.Subscribe(Topic, Qos)
        Catch ex As M2Mqtt.Exceptions.MqttClientException
            MsgBox(ex.Message(), MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Client_MqttMsgPublishReceived(ByVal sender As Object, ByVal e As MqttMsgPublishEventArgs)
        Select Case e.Topic.ToString()
            Case datos.Username + "/" + datos.InvernaderoID + "/sensor/in_T"
                datos.InternoTemperatura = Encoding.Default.GetString(e.Message)
            Case datos.Username + "/" + datos.InvernaderoID + "/sensor/out_T"
                datos.ExternoTemperatura = Encoding.Default.GetString(e.Message)
            Case datos.Username + "/" + datos.InvernaderoID + "/sensor/in_H"
                datos.InternoHumedad = Encoding.Default.GetString(e.Message)
            Case datos.Username + "/" + datos.InvernaderoID + "/sensor/out_H"
                datos.ExternoHumedad = Encoding.Default.GetString(e.Message)
            Case datos.Username + "/" + datos.InvernaderoID + "/sensor/in_C"
                datos.InternoC02 = Encoding.Default.GetString(e.Message)
            Case datos.Username + "/" + datos.InvernaderoID + "/sensor/out_C"
                datos.ExternoC02 = Encoding.Default.GetString(e.Message)
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

End Class
