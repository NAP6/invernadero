Public Class Registro_invernadero
    Private registro_invernaderov As List(Of Invernadero)

    Public Property Registro_invernadero As List(Of Invernadero)
        Get
            Return registro_invernaderov
        End Get
        Set(value As List(Of Invernadero))
            registro_invernaderov = value
        End Set
    End Property

    Public Function getID(id As Integer) As Invernadero
        Dim nuevo As Invernadero = From i In registro_invernaderov Where i.Id = id Select i
        Return nuevo
    End Function

    Public Function getNombre(nombre As String)
        Dim nuevo As List(Of Registro_invernadero) = From i In registro_invernaderov Where i.Nombre = nombre Select i
        Return nuevo
    End Function

    Public Function listar()
        Return registro_invernaderov
    End Function

    Public Sub add(nuevo As Invernadero)
        registro_invernaderov.Add(nuevo)
    End Sub
End Class
