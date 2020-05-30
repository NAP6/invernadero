Imports System.Globalization

Public Class Historial_Invernadero
    Private registro_historicov As List(Of Historico_Invernadero)

    Public Property Registro_historico As List(Of Historico_Invernadero)
        Get
            Return registro_historicov
        End Get
        Set(value As List(Of Historico_Invernadero))
            registro_historicov = value
        End Set
    End Property

    Public Function getFecha(fecha As Date)
        Dim nuevo As List(Of Historico_Invernadero) = From h In registro_historicov Where h.Fecha = fecha Select h
        Return nuevo
    End Function

    Public Function getFecha(fecha_inicio As Date, fecha_fin As Date)
        Dim nuevo As List(Of Historial_Invernadero) = From h In registro_historicov Where h.Fecha.CompareTo(fecha_inicio) > 0 And h.Fecha.CompareTo(fecha_fin) < 0 Select h
        Return nuevo
    End Function

    Public Function getFechaAVG(fecha_inicio As Date, fecha_fin As Date)
        Dim nuevo As List(Of Historico_Invernadero) = New List(Of Historico_Invernadero)()
        Dim grupos = From h In registro_historicov Where h.Fecha.CompareTo(fecha_inicio) > 0 And h.Fecha.CompareTo(fecha_fin) < 0 Group By h.fechaFormato() Into grupo_historial = Group
        For Each grupo In grupos
            Dim tem_ex = Aggregate g In grupo.grupo_historial Into Average(g.Ambiente_exterior.Temperatura)
            Dim tem_in = Aggregate g In grupo.grupo_historial Into Average(g.Ambiente_interior.Temperatura)
            Dim hum_s_ex = Aggregate g In grupo.grupo_historial Into Average(g.Ambiente_exterior.Humedad_suelo)
            Dim hum_s_in = Aggregate g In grupo.grupo_historial Into Average(g.Ambiente_interior.Humedad_suelo)
            Dim hum_a_ex = Aggregate g In grupo.grupo_historial Into Average(g.Ambiente_exterior.Humedad_aire)
            Dim hum_a_in = Aggregate g In grupo.grupo_historial Into Average(g.Ambiente_interior.Humedad_aire)
            Dim co2_ex = Aggregate g In grupo.grupo_historial Into Average(g.Ambiente_exterior.Co2)
            Dim co2_in = Aggregate g In grupo.grupo_historial Into Average(g.Ambiente_interior.Co2)
            nuevo.Add(New Historico_Invernadero(New Ambiente(tem_ex, hum_s_ex, hum_a_ex, co2_ex), New Ambiente(tem_in, hum_s_in, hum_a_in, co2_in), grupo.grupo_historial.ElementAt(0).Fecha))
        Next
        Return nuevo
    End Function

    Public Function getFechaAVG(menos_dias As Int16)
        Dim fecha_ahora As Date = New Date()
        Dim fecha_atras As Date = fecha_ahora.AddDays((-1 * menos_dias))
        Return getFechaAVG(fecha_atras, fecha_ahora)
    End Function

    Public Function getFechaAntes(fecha As Date)
        Dim nuevo As List(Of Historial_Invernadero) = From h In registro_historicov Where h.Fecha.CompareTo(fecha) < 0 Select h
        Return nuevo
    End Function

    Public Function getFechaDespues(fecha As Date)
        Dim nuevo As List(Of Historial_Invernadero) = From h In registro_historicov Where h.Fecha.CompareTo(fecha) > 0 Select h
        Return nuevo
    End Function

    Public Function listar()
        Return registro_historicov
    End Function

    Public Sub add(nuevo As Historico_Invernadero)
        registro_historicov.Add(nuevo)
    End Sub
End Class
