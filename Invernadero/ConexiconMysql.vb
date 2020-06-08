Imports System.Data
Imports MySql.Data.MySqlClient
Public Class ConexiconMysql
    Private usuario As String
    Private contrasenia As String
    Private puerto As Integer
    Private servidor As String
    Public Function conectar() As MySqlConnection
        Dim conexion As New MySqlConnection


        Try
            conexion.ConnectionString = "server=192.168.0.103;database=invernadero;user id=invernadero;password=invernadero12"

        Catch ex As Exception

        End Try
        Return conexion
    End Function
    Public Function ComprobarUsuario(usuario As String, contrasenia As String) As Boolean
        Dim Conecto As Boolean
        Dim DataAdapter As MySqlDataAdapter
        Dim Data As DataSet
        Dim conn As MySqlConnection = conectar()
        Dim sql As String
        Try
            sql = "Select * From invernadero.ta_usuarios Where username='" & usuario & "' and contraseña= '" & contrasenia & "'"
            conn.Open()
            DataAdapter = New MySqlDataAdapter(sql, conn)
            DataAdapter.Fill(Data, "ta_usuarios")
            If (Data.Tables("ta_usuarios").Rows.Count() <> 0) Then
                MessageBox.Show("Bienvenido")
                Conecto = True
            Else
                MessageBox.Show("Error el usuario o la contraseña fueron Mal ingresados")
                Conecto = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


        conn.Close()
        Return Conecto
    End Function
    Public Function getUltimoHistorico(invernadero As Integer) As Ambiente
        Dim DataAdapter As MySqlDataAdapter
        Dim Data As DataSet
        Dim conn As MySqlConnection = conectar()
        Dim sql As String
        Dim Lista As Ambiente

        Try
            sql = "Select his_temperatura_ex,his_humedad_aire_ex,hist_humedad_suelo_ex,his_Co2_ext from invernadero.ta_historial_invernadero where inver_id='" & invernadero & "' order by(fecha_historial)  desc LIMIT 1;"
            conn.Open()
            DataAdapter = New MySqlDataAdapter(sql, conn)
            DataAdapter.Fill(Data, "ta_historial_invernadero")
            If (Data.Tables("ta_historial_invernadero").Rows.Count() <> 0) Then
                Lista = New Ambiente(Data.Tables("ta_historial_invernadero").Rows(0).Item("his_temperatura_ex"), Data.Tables("ta_historial_invernadero").Rows(0).Item("his_humedad_aire_ex"), Data.Tables("ta_historial_invernadero").Rows(0).Item("hist_humedad_suelo_ex"), Data.Tables("ta_historial_invernadero").Rows(0).Item("his_Co2_ext"))

            Else
                MessageBox.Show("No hay Datos")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        conn.Close()
        Return Lista
    End Function

    Public Function getHistorial(invernadero As Integer) As Historial_Invernadero
        Dim DataAdapter As MySqlDataAdapter
        Dim Data As DataSet
        Dim conn As MySqlConnection = conectar()
        Dim sql As String
        Dim Lista As Historial_Invernadero
        Dim aux As Historico_Invernadero
        Try
            sql = "Select his_temperatura_ex,his_humedad_aire_ex,hist_humedad_suelo_ex,his_Co2_ext from invernadero.ta_historial_invernadero where inver_id='" & invernadero & "' order by(fecha_historial)  desc LIMIT 1;"
            conn.Open()
            DataAdapter = New MySqlDataAdapter(sql, conn)
            DataAdapter.Fill(Data, "ta_historial_invernadero")
            If (Data.Tables("ta_historial_invernadero").Rows.Count() <> 0) Then
                Lista = New Historial_Invernadero()
            Else
                MessageBox.Show("No hay Datos")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        conn.Close()
        Return Lista
    End Function


    Public Function getActuadores(invernadero As Integer) As Registro_Actuador
        Dim DataAdapter As MySqlDataAdapter
        Dim Data As DataSet
        Dim conn As MySqlConnection = conectar()
        Dim sql As String
        Dim Lista As Registro_Actuador
        Try
            sql = "Select actu_nombre, actu_descripcion from invernadero.ta_actuadores;"
            conn.Open()
            DataAdapter = New MySqlDataAdapter(sql, conn)
            DataAdapter.Fill(Data, "ta_actuadores")
            If (Data.Tables("ta_actuadores").Rows.Count() <> 0) Then


            Else
                MessageBox.Show("No hay Datos")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        conn.Close()
        Return Lista
    End Function


End Class
