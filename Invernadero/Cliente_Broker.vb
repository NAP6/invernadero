Imports System.Text
Imports M2Mqtt
Imports M2Mqtt.Messages

Public Class Cliente_Broker
    Private direccion_urlv As String = ""
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

            Dim elementos() As String = {"/sensor/in_T", "/sensor/out_T", "/sensor/in_H", "/sensor/out_H", "/sensor/in_H_A", "/sensor/out_H_A", "/sensor/in_C""/sensor/out_C"}
            Dim Qos() As Byte = {0}
            Dim aux As String
            For Each elem In usuario.Invernaderos_propios.Registro_invernadero
                For Each top In elementos
                    aux = username + "/" + elem.Id + top
                    subcripciones.Add(aux)
                    Dim Topic() As String = {aux}
                    client.Subscribe(Topic, Qos)
                Next
            Next

        Catch ex As M2Mqtt.Exceptions.MqttClientException
            MsgBox(ex.Message(), MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Client_MqttMsgPublishReceived(ByVal sender As Object, ByVal e As MqttMsgPublishEventArgs)

        If subcripciones.Contains(e.Topic.ToString()) Then
            Dim aux() As String = e.Topic.ToString().Split(New Char() {"\"c})
            Select Case e.Topic.ToString()
                Case "in_T"
                    usuario.Invernaderos_propios.getID(aux(1)).Ambiente_interior.Temperatura = Encoding.Default.GetString(e.Message)
                Case "out_T"
                    usuario.Invernaderos_propios.getID(aux(1)).Ambiente_exterior.Temperatura = Encoding.Default.GetString(e.Message)
                Case "in_H"
                    usuario.Invernaderos_propios.getID(aux(1)).Ambiente_interior.Humedad_suelo = Encoding.Default.GetString(e.Message)
                Case "out_H"
                    usuario.Invernaderos_propios.getID(aux(1)).Ambiente_exterior.Humedad_suelo = Encoding.Default.GetString(e.Message)
                Case "in_H_A"
                    usuario.Invernaderos_propios.getID(aux(1)).Ambiente_interior.Humedad_aire = Encoding.Default.GetString(e.Message)
                Case "out_H_A"
                    usuario.Invernaderos_propios.getID(aux(1)).Ambiente_exterior.Humedad_aire = Encoding.Default.GetString(e.Message)
                Case "in_C"
                    usuario.Invernaderos_propios.getID(aux(1)).Ambiente_interior.Co2 = Encoding.Default.GetString(e.Message)
                Case "out_C"
                    usuario.Invernaderos_propios.getID(aux(1)).Ambiente_exterior.Co2 = Encoding.Default.GetString(e.Message)
                Case Else
                    MsgBox("Publicado en: " + e.Topic.ToString + " : " + Encoding.Default.GetString(e.Message))
            End Select
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
