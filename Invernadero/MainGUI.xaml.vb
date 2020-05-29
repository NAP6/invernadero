Public Class MainGUI
    Private dat As List(Of Datos) = New List(Of Datos)()
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        dat.Add(New Datos(New Date(), 12, 12, 12, 12, 12, 12))
        dat.Add(New Datos(New Date(), 12, 12, 12, 12, 12, 12))
        dat.Add(New Datos(New Date(), 12, 12, 12, 12, 12, 12))
        dat.Add(New Datos(New Date(), 12, 12, 12, 12, 12, 12))
        dat.Add(New Datos(New Date(), 12, 12, 12, 12, 12, 12))
        dat.Add(New Datos(New Date(), 12, 12, 12, 12, 12, 12))
        dat.Add(New Datos(New Date(), 12, 12, 12, 12, 12, 12))
        dat.Add(New Datos(New Date(), 12, 12, 12, 12, 12, 12))
        dat.Add(New Datos(New Date(), 12, 12, 12, 12, 12, 12))
        dat.Add(New Datos(New Date(), 12, 12, 12, 12, 12, 12))
        dat.Add(New Datos(New Date(), 12, 12, 12, 12, 12, 12))
        dat.Add(New Datos(New Date(), 12, 12, 12, 12, 12, 12))

        Tabla.ItemsSource = dat

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
End Class

Public Class Datos
    Public Property fecha As Date
    Public Property temeratura_esterior As Double
    Public Property temeratura_interior As Double
    Public Property humedad_esterior As Double
    Public Property humedad_interior As Double
    Public Property co2_esterior As Double
    Public Property co2_interior As Double

    Public Sub New(fecha As Date, t_e As Double, t_i As Double, h_e As Double, h_i As Double, c_e As Double, c_i As Double)
        Me.fecha = fecha
        Me.temeratura_esterior = t_e
        Me.temeratura_interior = t_i
        Me.humedad_esterior = h_e
        Me.humedad_interior = h_i
        Me.co2_esterior = c_e
        Me.co2_interior = c_i
    End Sub
End Class