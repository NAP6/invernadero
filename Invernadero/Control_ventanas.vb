Public Class Control_ventanas
    Private Shared ventana As Window
    Private Shared tipo As String = ""

    Public Sub setVentana(v As Object)
        ventana = v
    End Sub

    Public Function getTipo() As String
        Return tipo
    End Function

    Public Sub cambiar(tipo As String)
        Dim aux_ventana As Window
        Select Case tipo
            Case "login"
                aux_ventana = New Login()
                tipo = "login"
            Case "escritorio"
                aux_ventana = New Escritorio()
                tipo = "escritorio"
            Case "perfil"
                aux_ventana = New Usuario()
                tipo = "perfil"
            Case "tablas"
                aux_ventana = New Escritorio()
                tipo = "tablas"
            Case "invernadero"
                aux_ventana = New Usuario()
                tipo = "invernadero"
            Case "control"
                aux_ventana = New Usuario()
                tipo = "control"
            Case "configuracion"
                aux_ventana = New Usuario()
                tipo = "configuracion"
            Case Else
                aux_ventana = New Login()
                tipo = "login"
        End Select
        If tipo <> "login" Then
            ventana.Close()
            ventana = aux_ventana
        End If
        ventana.Show()
    End Sub
End Class
