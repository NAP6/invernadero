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
        Dim Data As DataSet = New DataSet()
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
    Public Function getUltimoHistorico(invernadero As Integer) As Historico_Invernadero
        Dim DataAdapter As MySqlDataAdapter
        Dim Data As DataSet = New DataSet()
        Dim Data2 As DataSet = New DataSet()
        Dim conn As MySqlConnection = conectar()
        Dim sql As String
        Dim sql2 As String
        Dim Lista As Historico_Invernadero = New Historico_Invernadero()
        Try
            sql = "Select * from invernadero.ta_historial_invernadero where inver_id='" & invernadero & "' order by(fecha_historial)  desc LIMIT 1;"
            conn.Open()
            DataAdapter = New MySqlDataAdapter(sql, conn)
            DataAdapter.Fill(Data, "ta_historial_invernadero")
            If (Data.Tables("ta_historial_invernadero").Rows.Count() <> 0) Then
                Dim exterior As Ambiente = New Ambiente(Data.Tables("ta_historial_invernadero").Rows(0).Item("his_temperatura_ex"), Data.Tables("ta_historial_invernadero").Rows(0).Item("his_humedad_aire_ex"), Data.Tables("ta_historial_invernadero").Rows(0).Item("his_humedad_suelo_ex"), Data.Tables("ta_historial_invernadero").Rows(0).Item("his_Co2_ex"))
                Dim interior As Ambiente = New Ambiente(Data.Tables("ta_historial_invernadero").Rows(0).Item("his_temperatura_int"), Data.Tables("ta_historial_invernadero").Rows(0).Item("his_humedad_aire_int"), Data.Tables("ta_historial_invernadero").Rows(0).Item("his_humedad_suelo_int"), Data.Tables("ta_historial_invernadero").Rows(0).Item("his_Co2_int"))
                sql2 = "select Actu.actu_id,actu_nombre,actu_descripcion,inver_id,fecha_historial,his_actu_estado from invernadero.ta_actuadores Actu,invernadero.ta_histo_actuadores HisActu where HisActu.inver_id = " & invernadero & " and HisActu.actu_id = Actu.actu_id and fecha_historial='" & Data.Tables("ta_historial_invernadero").Rows(0).Item("fecha_historial") & "'"
                DataAdapter = New MySqlDataAdapter(sql2, conn)
                DataAdapter.Fill(Data2, "ta_actuadores")
                Dim actuadores As Registro_Actuador = New Registro_Actuador()
                For x As Integer = 0 To Data2.Tables("ta_actuadores").Rows.Count
                    actuadores.add(New Actuador(Data2.Tables("ta_actuadores").Rows(x).Item("actu_nombre"), Data2.Tables("ta_actuadores").Rows(x).Item("actu_id"), Data2.Tables("ta_actuadores").Rows(x).Item("his_actu_estado")))
                Next
                Lista = New Historico_Invernadero(exterior, interior, Data.Tables("ta_historial_invernadero").Rows(0).Item("fecha_historial"), actuadores)
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
        Dim Data As DataSet = New DataSet()
        Dim Data2 As DataSet = New DataSet()
        Dim conn As MySqlConnection = conectar()
        Dim sql As String
        Dim sql2 As String
        Dim Lista As Historial_Invernadero = New Historial_Invernadero()
        Dim AmbienteInt As Ambiente
        Dim AmbienteExt As Ambiente
        Dim aux As Historico_Invernadero
        Try
            sql = "select * from invernadero.ta_historial_invernadero where inver_id=" & invernadero & ";"
            conn.Open()
            DataAdapter = New MySqlDataAdapter(sql, conn)
            DataAdapter.Fill(Data, "ta_historial_invernadero")
            If (Data.Tables("ta_historial_invernadero").Rows.Count() <> 0) Then

                For i As Integer = 0 To Data.Tables("ta_historial_invernadero").Rows.Count
                    sql2 = "select Actu.actu_id,actu_nombre,actu_descripcion,inver_id,fecha_historial,his_actu_estado from invernadero.ta_actuadores Actu,invernadero.ta_hist   o_actuadores HisActu where HisActu.inver_id = " & invernadero & " and HisActu.actu_id = Actu.actu_id and fecha_historial='" & Data.Tables("ta_historial_invernadero").Rows(i).Item("fecha_historial") & "'"
                    DataAdapter = New MySqlDataAdapter(sql2, conn)
                    DataAdapter.Fill(Data2, "ta_actuadores")
                    Dim actuadores As Registro_Actuador = New Registro_Actuador()
                    For x As Integer = 0 To Data2.Tables("ta_actuadores").Rows.Count
                        actuadores.add(New Actuador(Data2.Tables("ta_actuadores").Rows(x).Item("actu_nombre"), Data2.Tables("ta_actuadores").Rows(x).Item("actu_id"), Data2.Tables("ta_actuadores").Rows(x).Item("his_actu_estado")))
                    Next
                    AmbienteExt = New Ambiente(Data.Tables("ta_historial_invernadero").Rows(0).Item("his_temperatura_ex"), Data.Tables("ta_historial_invernadero").Rows(0).Item("his_humedad_aire_ex"), Data.Tables("ta_historial_invernadero").Rows(0).Item("his_humedad_suelo_ex"), Data.Tables("ta_historial_invernadero").Rows(0).Item("his_Co2_ext"))
                    AmbienteInt = New Ambiente(Data.Tables("ta_historial_invernadero").Rows(0).Item("his_temperatura_int"), Data.Tables("ta_historial_invernadero").Rows(0).Item("his_humedad_aire_int"), Data.Tables("ta_historial_invernadero").Rows(0).Item("his_humedad_suelo_int"), Data.Tables("ta_historial_invernadero").Rows(0).Item("his_Co2_int"))
                    aux = New Historico_Invernadero(AmbienteExt, AmbienteInt, Data.Tables("ta_historial_invernadero").Rows(i).Item("fecha_historial"), actuadores)
                    Lista.add(aux)
                Next

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
        Dim Data As DataSet = New DataSet()
        Dim conn As MySqlConnection = conectar()
        Dim sql As String
        Dim actuadores As Registro_Actuador = New Registro_Actuador()

        Try
            sql = "select Actu.actu_id,actu_nombre,actu_descripcion,inver_id,fecha_historial,his_actu_estado from invernadero.ta_actuadores Actu,invernadero.ta_hist   o_actuadores HisActu where HisActu.inver_id=" & invernadero & "  and HisActu.actu_id = Actu.actu_id "
            DataAdapter = New MySqlDataAdapter(sql, conn)
            DataAdapter.Fill(Data, "ta_actuadores")

            If (Data.Tables("ta_actuadores").Rows.Count() <> 0) Then
                For x As Integer = 0 To Data.Tables("ta_actuadores").Rows.Count
                    actuadores.add(New Actuador(Data.Tables("ta_actuadores").Rows(x).Item("actu_nombre"), Data.Tables("ta_actuadores").Rows(x).Item("actu_id"), Data.Tables("ta_actuadores").Rows(x).Item("his_actu_estado")))

                Next
            Else
                MessageBox.Show("No hay Datos")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        conn.Close()
        Return actuadores
    End Function

    Public Function getInvernadero(invernadero As Integer) As Invernadero
        Dim DataAdapter As MySqlDataAdapter
        Dim Data As DataSet = New DataSet()
        Dim conn As MySqlConnection = conectar()
        Dim sql As String
        Dim Lista As Invernadero = New Invernadero()
        Try
            sql = "Select inver_nombre,inver_descripcion from invernadero.ta_invernaderos where inver_id=" & invernadero & ";"
            conn.Open()
            DataAdapter = New MySqlDataAdapter(sql, conn)
            DataAdapter.Fill(Data, "ta_invernaderos")
            If (Data.Tables("ta_invernaderos").Rows.Count() <> 0) Then
                Dim histo As Historico_Invernadero = getUltimoHistorico(invernadero)
                Lista = New Invernadero(invernadero, Data.Tables("ta_invernaderos").Rows(0).Item("inver_nombre"), Data.Tables("ta_invernaderos").Rows(0).Item("inver_descripcion"), histo.Ambiente_exterior, histo.Ambiente_interior, histo.Actuadores, getHistorial(invernadero))
            Else
                MessageBox.Show("No hay Datos")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        conn.Close()
        Return Lista
    End Function
    Public Function getUsuario(username As String) As Usuario
        Dim DataAdapter As MySqlDataAdapter
        Dim Data As DataSet = New DataSet()
        Dim conn As MySqlConnection = conectar()
        Dim sql As String
        Dim Lista As Usuario = New Usuario()
        Dim registroIn As Registro_invernadero = New Registro_invernadero()
        Try
            sql = "select usuari.username, contraseña,correo,inver_id from invernadero.ta_usuarios usuari,invernadero.ta_invernaderos inver where inver.username='" & username & "';"
            conn.Open()
            DataAdapter = New MySqlDataAdapter(sql, conn)
            DataAdapter.Fill(Data, "ta_usuarios")
            If (Data.Tables("ta_usuarios").Rows.Count() <> 0) Then
                For i As Integer = 0 To Data.Tables("ta_usuarios").Rows.Count
                    registroIn.add(getInvernadero(Data.Tables("ta_usuarios").Rows(i).Item("inver_id")))
                Next
                Lista = New Usuario(username, Data.Tables("ta_usuarios").Rows(0).Item("correo"), Data.Tables("ta_usuarios").Rows(0).Item("contraseña"), registroIn)
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
