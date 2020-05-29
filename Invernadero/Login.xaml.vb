Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Login


    Public Sub New()
        InitializeComponent()
        Dim ventana As Control_ventanas = New Control_ventanas()
        If (ventana.getTipo() = "") Then
            ventana.setVentana(Me)
        End If
    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim Mysql As ConexionMysql = New ConexionMysql()
        Dim sql As String
        Dim usuario As String = box_usuario.Text
        Dim contrasenia As String = box_contrasenia.Password
        sql = "SELECT * FROM ta_usuarios WHERE username= '" & usuario & "' and contraseña= '" & contrasenia & "'"
        Dim data As DataSet = Mysql.consulta(sql, "ta_usuarios")
        If (data.Tables("ta_usuarios").Rows.Count() <> 0) Then
            Dim controlDatos As Control_datos = New Control_datos(usuario, contrasenia)
            Dim ventana As Control_ventanas = New Control_ventanas()
            ventana.cambiar("escritorio")
        Else
            MessageBox.Show("Usuario y/o Contraseña Incorrector")
        End If
    End Sub
End Class
