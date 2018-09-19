Public Class tableFormConsumers
    Private tabla As New DataTable

    Private Sub btnExitForm_Click(sender As Object, e As EventArgs) Handles btnExitForm.Click
        Me.Close()
    End Sub

    Private Sub tableFormConsumers_Load(sender As Object, e As EventArgs) Handles Me.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim funciones As New dConsumers
            tabla = funciones.mostrar
            If tabla.Rows.Count <> 0 Then
                datalistConsumers.DataSource = tabla
                datalistConsumers.ColumnHeadersVisible = True
            Else
                datalistConsumers.DataSource = Nothing
                datalistConsumers.ColumnHeadersVisible = False
            End If
        Catch evento As Exception
            MsgBox(evento.Message)
        End Try
    End Sub
End Class