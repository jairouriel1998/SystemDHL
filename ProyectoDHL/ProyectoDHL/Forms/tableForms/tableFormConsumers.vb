Public Class tableFormConsumers
    Private tabla As New DataTable

    Private Sub btnExitForm_Click(sender As Object, e As EventArgs) Handles btnExitForm.Click
        Me.Close()
    End Sub

    Private Sub tableFormConsumers_Load(sender As Object, e As EventArgs) Handles Me.Load
        mostrar()
    End Sub

    Public Sub refreshData()
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim funciones As New dConsumers
            tabla = funciones.mostrar
            If tabla.Rows.Count <> 0 Then
                datalistConsumers.DataSource = tabla
                datalistConsumers.ColumnHeadersVisible = True
                datalistConsumers.Columns("id_persona").Visible = False
            Else
                datalistConsumers.DataSource = Nothing
                datalistConsumers.ColumnHeadersVisible = False
            End If
        Catch evento As Exception
            MsgBox(evento.Message)
        End Try
        If tabla.Rows.Count = 0 Then
            Dim emptyDataTable As New DataTable
            emptyDataTable.Columns.Add("dataEmpty")
            Dim emptyRow As DataRow = emptyDataTable.NewRow()
            emptyRow("dataEmpty") = "No hay datos"
            emptyDataTable.Rows.Add(emptyRow)
            datalistConsumers.DataSource = emptyDataTable
            btnDeleteConsumer.Enabled = False
            btnEditConsumer.Enabled = False
            btnViewDetailsConsumer.Enabled = False
        End If
    End Sub

    Private Sub btnViewDetailsConsumer_Click(sender As Object, e As EventArgs) Handles btnViewDetailsConsumer.Click
        Dim detailsConsumer = New detailsFormConsumer
        detailsConsumer.prepareForm(False, False, True)
        detailsConsumer.reciveData(sendData())
        detailsConsumer.Show()
    End Sub

    Function sendData() As eConsumers
        Dim consumerData As New eConsumers
        consumerData.Id_persona1 = datalistConsumers.SelectedCells.Item(0).Value
        consumerData.Id_cliente1 = datalistConsumers.SelectedCells.Item(1).Value
        consumerData.Nombre1 = datalistConsumers.SelectedCells.Item(2).Value
        consumerData.Apellido1 = datalistConsumers.SelectedCells.Item(3).Value
        consumerData.Identidad1 = datalistConsumers.SelectedCells.Item(4).Value
        consumerData.Telefono1 = datalistConsumers.SelectedCells.Item(5).Value
        consumerData.Email1 = datalistConsumers.SelectedCells.Item(6).Value
        consumerData.Direccion1 = datalistConsumers.SelectedCells.Item(7).Value
        Return consumerData
    End Function

    Private Sub btnAddNewConsumer_Click(sender As Object, e As EventArgs) Handles btnAddNewConsumer.Click
        Dim detailsConsumer = New detailsFormConsumer
        detailsConsumer.prepareForm(True, False, False)
        detailsConsumer.Show()
    End Sub

    Private Sub btnEditConsumer_Click(sender As Object, e As EventArgs) Handles btnEditConsumer.Click
        Dim detailsConsumer = New detailsFormConsumer
        detailsConsumer.prepareForm(False, True, False)
        detailsConsumer.reciveData(sendData())
        detailsConsumer.Show()
    End Sub

    Private Sub btnDeleteConsumer_Click(sender As Object, e As EventArgs) Handles btnDeleteConsumer.Click
        Dim deletePeticion As Integer = MessageBox.Show("¿Desea eliminar el registro seleccionado?", "caption", MessageBoxButtons.YesNoCancel)
        If deletePeticion = DialogResult.Cancel Then
            MessageBox.Show("Eliminacion cancelada")
        ElseIf deletePeticion = DialogResult.Yes Then
            Dim setData As New dConsumers
            setData.eliminar(datalistConsumers.SelectedCells.Item(1).Value)
        End If
        refreshData()
    End Sub
End Class