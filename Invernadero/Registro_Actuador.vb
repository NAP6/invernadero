Public Class Registro_Actuador
    Private registro_actuadoresv As List(Of Actuador)

    Public Property Registro_actuadores As List(Of Actuador)
        Get
            Return registro_actuadoresv
        End Get
        Set(value As List(Of Actuador))
            registro_actuadoresv = value
        End Set
    End Property

    Public Function listar_estado(estado As Boolean)
        Dim nuevo As List(Of Actuador) = From a In registro_actuadoresv Where a.Estado = estado Select a
        Return nuevo
    End Function

    Public Sub add(nuevo As Actuador)
        registro_actuadoresv.Add(nuevo)
    End Sub

    Public Function listar()
        Return registro_actuadoresv
    End Function

    Public Function getItem(tipo As String)
        Dim nuevo As List(Of Actuador) = From a In registro_actuadoresv Where a.Tipo = tipo Select a
        Return nuevo
    End Function

    Public Function getItem(tipo As String, nombre As String)
        Dim nuevo As List(Of Actuador) = From a In registro_actuadoresv Where a.Tipo = tipo And a.Nomebre Select a
        Return nuevo
    End Function

End Class
