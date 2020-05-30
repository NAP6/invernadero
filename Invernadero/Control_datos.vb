Imports System.Data
Imports System.ComponentModel

Public Class Control_datos
    Implements INotifyPropertyChanged
    Private Shared historial_Tiempo As LiveCharts.SeriesCollection
    Private Shared etiquetas_Tiempo As New List(Of String)
    Private Shared historial_Humedad As LiveCharts.SeriesCollection
    Private Shared etiquetas_Humedad As New List(Of String)
    Private Shared historial_co2 As LiveCharts.SeriesCollection
    Private Shared etiquetas_co2 As New List(Of String)
    Private Shared formato_AxisY As Func(Of Double, String)
    Private Shared FechaArray(10) As String

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
    Private Shared invernadero_id As String = "100"
    Public Sub New()



    End Sub
    Public Sub New(username As String, Password As String)
        Dim sql As String
        Dim sql2 As String
        Dim Mysql As ConexionMysql = New ConexionMysql()
        Me.Username = username
        Me.Password = Password
        sql = "SELECT * FROM ta_historial_invernadero WHERE inver_id= " & InvernaderoID & " and fecha_historial=(select max(fecha_historial) from ta_historial_invernadero);
"
        Dim data As DataSet = Mysql.consulta(sql, "ta_historial_invernadero")
        InternoTemperatura = Format(data.Tables("ta_historial_invernadero").Rows(0).Item("his_temperatura_int"), "###")
        ExternoTemperatura = Format(data.Tables("ta_historial_invernadero").Rows(0).Item("his_temperatura_ex"), "###")
        InternoHumedad = Format(data.Tables("ta_historial_invernadero").Rows(0).Item("hist_humedad_suelo_int"), "###")
        ExternoHumedad = Format(data.Tables("ta_historial_invernadero").Rows(0).Item("hist_humedad_suelo_ex"), "###")
        InternoC02 = Format(data.Tables("ta_historial_invernadero").Rows(0).Item("hist_Co2_int"), "###")
        ExternoC02 = Format(data.Tables("ta_historial_invernadero").Rows(0).Item("his_Co2_ext"), "###")
        data.Clear()

        sql2 = "Select date_format(fecha_historial,'%d/%m/%y') from invernadero.ta_historial_invernadero  group by(date_format(fecha_historial,'%d/%m/%y') ) asc LIMIT 10 ;"
        data = Mysql.consulta(sql2, "ta_historial_invernadero")
        For i = 0 To 9
            FechaArray(i) = data.Tables("ta_historial_invernadero").Rows(i).Item("date_format(fecha_historial,'%d/%m/%y')")
        Next

        Tiempo_historial()
        Humedad_historial()
        Co2_historial()
    End Sub



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

    Public Property HistorialTiempo() As LiveCharts.SeriesCollection
        Get
            Return historial_Tiempo
        End Get

        Set(ByVal value As LiveCharts.SeriesCollection)
            If Not (value.Equals(historial_Tiempo)) Then
                historial_Tiempo = value
                NotifyPropertyChanged("HistorialTiempo")
            End If
        End Set
    End Property

    Public Property EtiquetasTiempo() As List(Of String)
        Get
            Return etiquetas_Tiempo
        End Get

        Set(ByVal value As List(Of String))
            If Not (value.Equals(etiquetas_Tiempo)) Then
                etiquetas_Tiempo = value
                NotifyPropertyChanged("EtiquetasTiempo")
            End If
        End Set
    End Property

    Public Property HistorialHumedad() As LiveCharts.SeriesCollection
        Get
            Return historial_Humedad
        End Get

        Set(ByVal value As LiveCharts.SeriesCollection)
            If Not (value.Equals(historial_Humedad)) Then
                historial_Humedad = value
                NotifyPropertyChanged("HistorialHumedad")
            End If
        End Set
    End Property
    Public Property EtiquetasHumedad() As List(Of String)
        Get
            Return etiquetas_Humedad
        End Get

        Set(ByVal value As List(Of String))
            If Not (value.Equals(etiquetas_Humedad)) Then
                etiquetas_Humedad = value
                NotifyPropertyChanged("EtiquetasHumedad")
            End If
        End Set
    End Property
    Public Property HistorialCo2() As LiveCharts.SeriesCollection
        Get
            Return historial_co2
        End Get

        Set(ByVal value As LiveCharts.SeriesCollection)
            If Not (value.Equals(historial_co2)) Then
                historial_co2 = value
                NotifyPropertyChanged("HistorialCo2")
            End If
        End Set
    End Property
    Public Property EtiquetasCo2() As List(Of String)
        Get
            Return etiquetas_co2
        End Get

        Set(ByVal value As List(Of String))
            If Not (value.Equals(etiquetas_co2)) Then
                etiquetas_Humedad = value
                NotifyPropertyChanged("EtiquetasCo2")
            End If
        End Set
    End Property
    Public Property FormatoAxisY() As Func(Of Double, String)
        Get
            Return formato_AxisY
        End Get

        Set(ByVal value As Func(Of Double, String))
            If Not (value.Equals(formato_AxisY)) Then
                formato_AxisY = value
                NotifyPropertyChanged("FormatoAxisY")
            End If
        End Set
    End Property
    Private Sub Tiempo_historial()
        '---Aqui es donde agregas la informacion recuperada del tiempo y los datos de temperatura y esas cosas---
        HistorialTiempo = New LiveCharts.SeriesCollection()
        '---Agregamos las lineas para el interior y el exterior del invernadero---   
        HistorialTiempo.Add(New LiveCharts.Wpf.LineSeries With {
                .Title = "Interior del invernadero",
                .PointForeground = Brushes.Transparent,
                .Values = New LiveCharts.ChartValues(Of Double)})
        HistorialTiempo.Add(New LiveCharts.Wpf.LineSeries With {
                .Title = "Exterior del invernadero",
                .PointForeground = Brushes.Transparent,
                .Values = New LiveCharts.ChartValues(Of Double)})
        '---Aqui se ingresan los valores para cada una de las lineas ---
        For i = 1 To 10
            HistorialTiempo(0).Values.Add(CDbl(i + (2 * i) ^ 2))
            HistorialTiempo(1).Values.Add(CDbl(i + (2.3 * i) ^ 2))
        Next
        '---Aqui se ingresan las etiquetas del eje X---
        For i = 0 To 9

            EtiquetasTiempo.Add(FechaArray(i))
        Next
        '---Se define el formato del eje Y---
        FormatoAxisY = Function(value) value.ToString("N")
    End Sub

    Private Sub Humedad_historial()
        '---Aqui es donde agregas la informacion recuperada del tiempo y los datos de temperatura y esas cosas---
        HistorialHumedad = New LiveCharts.SeriesCollection()
        '---Agregamos las lineas para el interior y el exterior del invernadero---   
        HistorialHumedad.Add(New LiveCharts.Wpf.LineSeries With {
                .Title = "Interior del invernadero",
                .PointForeground = Brushes.Transparent,
                .Values = New LiveCharts.ChartValues(Of Double)})
        HistorialHumedad.Add(New LiveCharts.Wpf.LineSeries With {
                .Title = "Exterior del invernadero",
                .PointForeground = Brushes.Transparent,
                .Values = New LiveCharts.ChartValues(Of Double)})
        '---Aqui se ingresan los valores para cada una de las lineas ---
        For i = 1 To 10
            HistorialHumedad(0).Values.Add(CDbl(i + (2 * i) ^ (1 / 2)))
            HistorialHumedad(1).Values.Add(CDbl(i + (2.3 * i) ^ (1 / 2)))
        Next
        '---Aqui se ingresan las etiquetas del eje X---
        For i = 0 To 9
            EtiquetasHumedad.Add(FechaArray(i))
        Next
        '---Se define el formato del eje Y---
        FormatoAxisY = Function(value) value.ToString("N")
    End Sub

    Private Sub Co2_historial()
        '---Aqui es donde agregas la informacion recuperada del tiempo y los datos de temperatura y esas cosas---
        HistorialCo2 = New LiveCharts.SeriesCollection()
        '---Agregamos las lineas para el interior y el exterior del invernadero---   
        HistorialCo2.Add(New LiveCharts.Wpf.LineSeries With {
                .Title = "Interior del invernadero",
                .PointForeground = Brushes.Transparent,
                .Values = New LiveCharts.ChartValues(Of Double)})
        HistorialCo2.Add(New LiveCharts.Wpf.LineSeries With {
                .Title = "Exterior del invernadero",
                .PointForeground = Brushes.Transparent,
                .Values = New LiveCharts.ChartValues(Of Double)})
        '---Aqui se ingresan los valores para cada una de las lineas ---
        For i = 1 To 10
            HistorialCo2(0).Values.Add(CDbl(2 * i))
            HistorialCo2(1).Values.Add(CDbl(5 * i))
        Next
        '---Aqui se ingresan las etiquetas del eje X---
        For i = 0 To 9
            EtiquetasCo2.Add(FechaArray(i))
        Next
        '---Se define el formato del eje Y---
        FormatoAxisY = Function(value) value.ToString("N")
    End Sub


End Class