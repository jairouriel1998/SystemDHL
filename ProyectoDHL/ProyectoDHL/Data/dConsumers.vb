Imports System.Data.SqlClient
Public Class dConsumers
    Inherits conection
    Dim comandos As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conexionBD()
            comandos = New SqlCommand("sp_sClientes")
            comandos.CommandType = CommandType.StoredProcedure
            comandos.Connection = conectar
            If comandos.ExecuteNonQuery Then
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
End Class
