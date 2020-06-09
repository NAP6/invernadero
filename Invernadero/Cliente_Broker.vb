Imports System.Text
Imports M2Mqtt
Imports M2Mqtt.Messages

Public Class Cliente_Broker
    Private direccion_urlv As String = "192.168.0.103"
    Private puerto As Integer = 1880
    Private usuario As UsuarioNotify
    Private username As String
    Private password As String
    Private client As MqttClient
    Private subcripciones As List(Of String)

    Public Sub New(username As String, password As String, ByRef usuario As UsuarioNotify)
        Me.username = username
        Me.password = password
        Me.usuario = usuario
    End Sub

    Public Sub conectar()
        Try
            client = New MqttClient(direccion_urlv, puerto, False, Nothing, Nothing, MqttSslProtocols.TLSv1_2)
            AddHandler client.MqttMsgPublishReceived, AddressOf Client_MqttMsgPublishReceived
            AddHandler client.ConnectionClosed, AddressOf Client_Disconnect
            client.Connect("Aplicacion", username, password)
            If Not client.IsConnected Then
                MsgBox("No se pudo establecer coneccion con el broker")
            End If

            Dim Qos() As Byte = {0}
            Dim aux As String
            For Each elem In usuario.Invernaderos_propios.Registro_invernadero
                aux = username + "/" + elem.Id + "/invernadero"
                subcripciones.Add(aux)
                Dim Topic() As String = {aux}
                client.Subscribe(Topic, Qos)

            Next

        Catch ex As M2Mqtt.Exceptions.MqttClientException
            MsgBox(ex.Message(), MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Client_MqttMsgPublishReceived(ByVal sender As Object, ByVal e As MqttMsgPublishEventArgs)

        If subcripciones.Contains(e.Topic.ToString()) Then
            Dim aux() As String = e.Topic.ToString().Split(New Char() {"/"c})
            Dim InverId As Integer = Convert.ToInt32(aux(1))
            Dim mss As String = Encoding.Default.GetString(e.Message)
            Dim aux2() As String = mss.Split(New Char() {":"c})
            Dim ambiente() As String = aux2(0).Split(New Char() {"/"c})
            Dim actuador() As String = aux2(1).Split(New Char() {"/"c})
            Dim aux3() As String = ambiente(0).Split(New Char() {"-"c})
            usuario.Invernaderos_propios.getID(InverId).Ambiente_exterior.Temperatura = Convert.ToDouble(aux(1))
            usuario.Invernaderos_propios.getID(InverId).Ambiente_interior.Temperatura = Convert.ToDouble(aux(0))
            aux3 = ambiente(1).Split(New Char() {"-"c})
            usuario.Invernaderos_propios.getID(InverId).Ambiente_exterior.Co2 = Convert.ToDouble(aux(1))
            usuario.Invernaderos_propios.getID(InverId).Ambiente_interior.Co2 = Convert.ToDouble(aux(0))
            aux3 = ambiente(2).Split(New Char() {"-"c})
            usuario.Invernaderos_propios.getID(InverId).Ambiente_exterior.Humedad_suelo = Convert.ToDouble(aux(1))
            usuario.Invernaderos_propios.getID(InverId).Ambiente_interior.Humedad_suelo = Convert.ToDouble(aux(0))
            aux3 = ambiente(3).Split(New Char() {"-"c})
            usuario.Invernaderos_propios.getID(InverId).Ambiente_exterior.Humedad_aire = Convert.ToDouble(aux(1))
            usuario.Invernaderos_propios.getID(InverId).Ambiente_interior.Humedad_aire = Convert.ToDouble(aux(0))
        End If
    End Sub
    Private Sub Client_Disconnect(sender As Object, e As EventArgs)
    End Sub
    Public Sub desconectar()
        If (client IsNot Nothing AndAlso client.IsConnected()) Then
            client.Disconnect()
        End If
    End Sub

    Public Sub publicar(topic As String, mensaje As String)
        client.Publish(topic, Encoding.Default.GetBytes(mensaje))
    End Sub
End Class
