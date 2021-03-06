﻿Imports System.Data.SqlClient

Public Class dEmployees
    Inherits conection
    Dim comandos As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conexionBD()
            comandos = New SqlCommand("sp_sEmpleados")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = conectar
            If comandos.ExecuteNonQuery() Then
                Dim tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(comandos)
                adaptador.Fill(tabla)
                Return tabla
            Else
                Return Nothing
            End If
        Catch evento As Exception
            MsgBox(evento.Message)
            Return Nothing
        Finally
            desconexionBD()
        End Try
    End Function

    Public Function actualizarPersona(id_persona As String, nombre As String, apellido As String, identidad As String, telefono As String, email As String) As Boolean
        Try
            conexionBD()
            comandos = New SqlCommand("sp_uPersonas")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = conectar
            comandos.Parameters.AddWithValue("@id_persona", id_persona)
            comandos.Parameters.AddWithValue("@nombre", nombre)
            comandos.Parameters.AddWithValue("@apellido", apellido)
            comandos.Parameters.AddWithValue("@identidad", identidad)
            comandos.Parameters.AddWithValue("@telefono", telefono)
            comandos.Parameters.AddWithValue("@email", email)
            If comandos.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch evento As Exception
            MsgBox(evento.Message)
        Finally
            desconexionBD()
        End Try
    End Function

    Public Function insertarPersona(nombre As String, apellido As String, identidad As String, telefono As String, email As String) As Integer
        Try
            conexionBD()
            comandos = New SqlCommand("sp_iPersonas")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = conectar
            comandos.Parameters.AddWithValue("@nombre", nombre)
            comandos.Parameters.AddWithValue("@apellido", apellido)
            comandos.Parameters.AddWithValue("@identidad", identidad)
            comandos.Parameters.AddWithValue("@telefono", telefono)
            comandos.Parameters.AddWithValue("@email", email)
            comandos.ExecuteNonQuery()
        Catch evento As Exception
            MsgBox(evento.Message)
            Return 0
        Finally
            desconexionBD()
        End Try
        Return extraerPersona()
    End Function

    Public Function extraerPersona() As Integer
        Try
            conexionBD()
            comandos = New SqlCommand("sp_ultimaPersona")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = conectar
            If comandos.ExecuteNonQuery Then
                Dim dataResolve As Integer
                Dim tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(comandos)
                Dim entranceRow As DataRow
                adaptador.Fill(tabla)
                entranceRow = tabla.Rows(0)
                dataResolve = entranceRow("ultimoRegistro")
                Return dataResolve
            Else
                Return Nothing
            End If
        Catch evento As Exception
            MsgBox(evento.Message)
            Return Nothing
        Finally
            desconexionBD()
        End Try
    End Function

    Public Function insertar(tabla As eEmployees) As Boolean
        Try
            Dim id_persona As Integer
            id_persona = insertarPersona(tabla.Nombre1, tabla.Apellido1, tabla.Identidad1, tabla.Telefono1, tabla.Email1)
            conexionBD()
            comandos = New SqlCommand("sp_iEmpleados")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = conectar
            comandos.Parameters.AddWithValue("@id_persona", id_persona)
            comandos.Parameters.AddWithValue("@cargo", tabla.Cargo1)
            comandos.Parameters.AddWithValue("@usuario", "none")
            comandos.Parameters.AddWithValue("@contrasena", "none")
            If comandos.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch evento As Exception
            MsgBox(evento.Message)
            Return False
        Finally
            desconexionBD()
        End Try
    End Function

    Public Function actualizar(tabla As eEmployees) As Boolean
        Try
            actualizarPersona(tabla.Id_persona1, tabla.Nombre1, tabla.Apellido1, tabla.Identidad1, tabla.Telefono1, tabla.Email1)
            conexionBD()
            comandos = New SqlCommand("sp_uEmpleados")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = conectar
            comandos.Parameters.AddWithValue("@id_persona", tabla.Id_persona1)
            comandos.Parameters.AddWithValue("@id_empleado", tabla.Id_empleado1)
            comandos.Parameters.AddWithValue("@cargo", tabla.Cargo1)
            comandos.Parameters.AddWithValue("@usuario", "none")
            comandos.Parameters.AddWithValue("@contrasena", "none")
            If comandos.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch evento As Exception
            MsgBox(evento.Message)
            Return False
        Finally
            desconexionBD()
        End Try
    End Function

    Public Function eliminar(id_empleado As Integer) As Boolean
        Try
            conexionBD()
            comandos = New SqlCommand("sp_dEmpleados")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = conectar
            comandos.Parameters.AddWithValue("@id_empleado", id_empleado)
            If comandos.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch evento As Exception
            MsgBox(evento.Message)
            Return False
        Finally
            desconexionBD()
        End Try
    End Function


End Class
