
Imports System.Data
Imports MySql.Data.MySqlClient

Class ConexionMysql

    Public conexion As New MySqlConnection
    Public Data As New DataSet

    Sub Conectar()
        Try
            conexion.ConnectionString = "server=192.168.0.103;User Id=invernadero;database=invernadero;Password=invernadero12"
            conexion.Open()
        Catch ex As Exception

        End Try
    End Sub
    Function consulta(sql As String, tabla As String) As DataSet
        Try
            Conectar()
            Dim DataAdapter As MySqlDataAdapter
            DataAdapter = New MySqlDataAdapter(sql, conexion)
            DataAdapter.Fill(Data, tabla)
            conexion.Close()
            Return Data
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return New DataSet
    End Function
End Class
