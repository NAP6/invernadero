Public Class Escritorio
    Public Property historial_Tiempo As LiveCharts.SeriesCollection
    Public Property etiquetas_Tiempo As New List(Of String)
    Public Property historial_Humedad As LiveCharts.SeriesCollection
    Public Property etiquetas_Humedad As New List(Of String)
    Public Property historial_co2 As LiveCharts.SeriesCollection
    Public Property etiquetas_co2 As New List(Of String)
    Public Property formato_AxisY As Func(Of Double, String)

    Public Sub New()
        InitializeComponent()
        Tiempo_historial()
        Humedad_historial()
        Co2_historial()
        DataContext = Me
    End Sub

    Private Sub Tiempo_historial()
        '---Aqui es donde agregas la informacion recuperada del tiempo y los datos de temperatura y esas cosas---
        historial_Tiempo = New LiveCharts.SeriesCollection()
        '---Agregamos las lineas para el interior y el exterior del invernadero---   
        historial_Tiempo.Add(New LiveCharts.Wpf.LineSeries With {
                .Title = "Interior del invernadero",
                .PointForeground = Brushes.Transparent,
                .Values = New LiveCharts.ChartValues(Of Double)})
        historial_Tiempo.Add(New LiveCharts.Wpf.LineSeries With {
                .Title = "Exterior del invernadero",
                .PointForeground = Brushes.Transparent,
                .Values = New LiveCharts.ChartValues(Of Double)})
        '---Aqui se ingresan los valores para cada una de las lineas ---
        For i = 1 To 10
            historial_Tiempo(0).Values.Add(CDbl(i + (2 * i) ^ 2))
            historial_Tiempo(1).Values.Add(CDbl(i + (2.3 * i) ^ 2))
        Next
        '---Aqui se ingresan las etiquetas del eje X---
        For i = 1 To 10
            etiquetas_Tiempo.Add("str-" & CStr(i))
        Next
        '---Se define el formato del eje Y---
        formato_AxisY = Function(value) value.ToString("N")
    End Sub

    Private Sub Humedad_historial()
        '---Aqui es donde agregas la informacion recuperada del tiempo y los datos de temperatura y esas cosas---
        historial_Humedad = New LiveCharts.SeriesCollection()
        '---Agregamos las lineas para el interior y el exterior del invernadero---   
        historial_Humedad.Add(New LiveCharts.Wpf.LineSeries With {
                .Title = "Interior del invernadero",
                .PointForeground = Brushes.Transparent,
                .Values = New LiveCharts.ChartValues(Of Double)})
        historial_Humedad.Add(New LiveCharts.Wpf.LineSeries With {
                .Title = "Exterior del invernadero",
                .PointForeground = Brushes.Transparent,
                .Values = New LiveCharts.ChartValues(Of Double)})
        '---Aqui se ingresan los valores para cada una de las lineas ---
        For i = 1 To 10
            historial_Humedad(0).Values.Add(CDbl(i + (2 * i) ^ (1 / 2)))
            historial_Humedad(1).Values.Add(CDbl(i + (2.3 * i) ^ (1 / 2)))
        Next
        '---Aqui se ingresan las etiquetas del eje X---
        For i = 1 To 10
            etiquetas_Humedad.Add("str-" & CStr(i))
        Next
        '---Se define el formato del eje Y---
        formato_AxisY = Function(value) value.ToString("N")
    End Sub

    Private Sub Co2_historial()
        '---Aqui es donde agregas la informacion recuperada del tiempo y los datos de temperatura y esas cosas---
        historial_co2 = New LiveCharts.SeriesCollection()
        '---Agregamos las lineas para el interior y el exterior del invernadero---   
        historial_co2.Add(New LiveCharts.Wpf.LineSeries With {
                .Title = "Interior del invernadero",
                .PointForeground = Brushes.Transparent,
                .Values = New LiveCharts.ChartValues(Of Double)})
        historial_co2.Add(New LiveCharts.Wpf.LineSeries With {
                .Title = "Exterior del invernadero",
                .PointForeground = Brushes.Transparent,
                .Values = New LiveCharts.ChartValues(Of Double)})
        '---Aqui se ingresan los valores para cada una de las lineas ---
        For i = 1 To 10
            historial_co2(0).Values.Add(CDbl(2 * i))
            historial_co2(1).Values.Add(CDbl(5 * i))
        Next
        '---Aqui se ingresan las etiquetas del eje X---
        For i = 1 To 10
            etiquetas_co2.Add("str-" & CStr(i))
        Next
        '---Se define el formato del eje Y---
        formato_AxisY = Function(value) value.ToString("N")
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
