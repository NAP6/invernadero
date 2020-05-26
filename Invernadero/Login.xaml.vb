Public Class Login
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim usuario As String = box_usuario.Text
        Dim contrasenia As String = box_contrasenia.Password

        If usuario = "nicolas" And contrasenia = "1234" Then
            Dim escritorio As Escritorio = New Escritorio()
            Me.Hide()
            escritorio.Show()
            Me.Close()
        End If
    End Sub
End Class
