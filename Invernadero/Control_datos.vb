Imports System.ComponentModel

Public Class Control_datos
    Implements INotifyPropertyChanged

    Private Shared interno_temperarura As String = "1"
    Private Shared externo_temperarura As String = "2"
    Private Shared interno_humedad As String = "3"
    Private Shared externo_humedad As String = "4"
    Private Shared interno_c02 As String = "5"
    Private Shared externo_c02 As String = "6"

    Private Shared servidor_dir As String = "192.168.0.103"
    Private Shared servidor_port As Int32 = 1880
    Private Shared client_id As String = "Aplicacion"
    Private Shared client_username As String = "nicolas"
    Private Shared client_password As String = "nico05061998"
    Private Shared invernadero_id As String = "Invernadero1"


    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub NotifyPropertyChanged(ByVal info As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
    End Sub


    'Controlador de eventos de los cambios en la TEMPERATURA interno y externo
    Public Property ExternoTemperatura() As String
        Get
            Return externo_temperarura
        End Get

        Set(ByVal value As String)
            If Not (value = externo_temperarura) Then
                externo_temperarura = value
                NotifyPropertyChanged("ExternoTemperatura")
            End If
        End Set
    End Property
    Public Property InternoTemperatura() As String
        Get
            Return interno_temperarura
        End Get

        Set(ByVal value As String)
            If Not (value = interno_temperarura) Then
                interno_temperarura = value
                NotifyPropertyChanged("InternoTemperatura")
            End If
        End Set
    End Property


    'Controlador de eventos de los cambios en la HUMEDAD interno y externo
    Public Property ExternoHumedad() As String
        Get
            Return externo_humedad
        End Get

        Set(ByVal value As String)
            If Not (value = externo_humedad) Then
                externo_humedad = value
                NotifyPropertyChanged("ExternoHumedad")
            End If
        End Set
    End Property
    Public Property InternoHumedad() As String
        Get
            Return interno_humedad
        End Get

        Set(ByVal value As String)
            If Not (value = interno_humedad) Then
                interno_humedad = value
                NotifyPropertyChanged("InternoHumedad")
            End If
        End Set
    End Property

    'Controlador de eventos de los cambios en el CO2 interno y externo
    Public Property ExternoC02() As String
        Get
            Return externo_c02
        End Get

        Set(ByVal value As String)
            If Not (value = externo_c02) Then
                externo_c02 = value
                NotifyPropertyChanged("ExternoC02")
            End If
        End Set
    End Property
    Public Property InternoC02() As String
        Get
            Return interno_c02
        End Get

        Set(ByVal value As String)
            If Not (value = interno_c02) Then
                interno_c02 = value
                NotifyPropertyChanged("InternoC02")
            End If
        End Set
    End Property

    Public Property Servidor() As String
        Get
            Return servidor_dir
        End Get

        Set(ByVal value As String)

        End Set
    End Property
    Public Property MqttID() As String
        Get
            Return client_id
        End Get

        Set(ByVal value As String)

        End Set
    End Property
    Public Property Username() As String
        Get
            Return client_username
        End Get

        Set(ByVal value As String)

        End Set
    End Property
    Public Property Password() As String
        Get
            Return client_password
        End Get

        Set(ByVal value As String)

        End Set
    End Property

    Public Property InvernaderoID() As String
        Get
            Return invernadero_id
        End Get

        Set(ByVal value As String)

        End Set
    End Property
    Public Property puertoMqtt() As String
        Get
            Return servidor_port
        End Get

        Set(ByVal value As String)

        End Set
    End Property

End Class