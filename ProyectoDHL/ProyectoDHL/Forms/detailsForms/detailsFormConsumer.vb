Imports System.Runtime.InteropServices

Public Class detailsFormConsumer
    Dim newConsumer, editConsumer, viewConsumer As Boolean
    Dim person_id, consumer_id As Integer


    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Public Sub prepareForm(newData As Boolean, editData As Boolean, viewData As Boolean)
        newConsumer = newData
        editConsumer = editData
        viewConsumer = viewData
        prepareButtons()
        prepareTextBox()
    End Sub

    Private Sub prepareButtons()
        If newConsumer Or editConsumer Then
            btnSave.Visible = True
            btnClear.Visible = True
            btnCancel.Visible = True
            btnClose.Visible = False
        ElseIf viewConsumer Then
            btnSave.Visible = False
            btnClear.Visible = False
            btnCancel.Visible = False
            btnClose.Visible = True
        End If
    End Sub

    Private Sub prepareTextBox()
        If newConsumer Or editConsumer Then
            txtConsumerName.Enabled = True
            txtConsumerLastName.Enabled = True
            txtConsumerIdCard.Enabled = True
            txtConsumerPhone.Enabled = True
            txtConsumerPhone.Enabled = True
            txtConsumerEmail.Enabled = True
            txtConsumerAddress.Enabled = True
        ElseIf viewConsumer Then
            txtConsumerName.Enabled = False
            txtConsumerLastName.Enabled = False
            txtConsumerIdCard.Enabled = False
            txtConsumerPhone.Enabled = False
            txtConsumerPhone.Enabled = False
            txtConsumerEmail.Enabled = False
            txtConsumerAddress.Enabled = False
        End If
    End Sub


    Public Sub reciveData(consumerData As eConsumers)
        person_id = consumerData.Id_persona1
        consumer_id = consumerData.Id_cliente1
        txtConsumerName.Text = consumerData.Nombre1
        txtConsumerLastName.Text = consumerData.Apellido1
        txtConsumerIdCard.Text = consumerData.Identidad1
        txtConsumerPhone.Text = consumerData.Telefono1
        txtConsumerEmail.Text = consumerData.Email1
        txtConsumerAddress.Text = consumerData.Direccion1
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If newConsumer Then
            If txtConsumerName.Text <> "" And txtConsumerLastName.Text <> "" And
                txtConsumerIdCard.Text <> "" And txtConsumerPhone.Text <> "" And
                txtConsumerEmail.Text <> "" And txtConsumerAddress.Text <> "" Then
                Try
                    Dim tablaDatos As New eConsumers
                    Dim funciones As New dConsumers
                    tablaDatos.Nombre1 = txtConsumerName.Text
                    tablaDatos.Apellido1 = txtConsumerLastName.Text
                    tablaDatos.Identidad1 = txtConsumerIdCard.Text
                    tablaDatos.Telefono1 = txtConsumerPhone.Text
                    tablaDatos.Email1 = txtConsumerEmail.Text
                    tablaDatos.Direccion1 = txtConsumerAddress.Text
                    If funciones.insertar(tablaDatos) Then
                        MessageBox.Show("Cliente registrado exitosamente",
                                        "Guardando registro", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Ha ocurrido un error! Registro no realizado",
                                        "Guardando registro", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
                    End If
                Catch evento As Exception
                    MsgBox(evento.Message)
                End Try
            Else
                MessageBox.Show("Falta Informacion para almacenar en la Base de Datos",
                                "Guardando registro", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If
        ElseIf editConsumer Then
            If txtConsumerName.Text <> "" And txtConsumerLastName.Text <> "" And
                txtConsumerIdCard.Text <> "" And txtConsumerPhone.Text <> "" And
                txtConsumerEmail.Text <> "" And txtConsumerAddress.Text <> "" Then
                Try
                    Dim tablaDatos As New eConsumers
                    Dim funciones As New dConsumers
                    tablaDatos.Id_persona1 = person_id
                    tablaDatos.Id_cliente1 = consumer_id
                    tablaDatos.Nombre1 = txtConsumerName.Text
                    tablaDatos.Apellido1 = txtConsumerLastName.Text
                    tablaDatos.Identidad1 = txtConsumerIdCard.Text
                    tablaDatos.Telefono1 = txtConsumerPhone.Text
                    tablaDatos.Email1 = txtConsumerEmail.Text
                    tablaDatos.Direccion1 = txtConsumerAddress.Text
                    If funciones.actualizar(tablaDatos) Then
                        MessageBox.Show("Cambios guardados exitosamente",
                                        "Guardando registro", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Ha ocurrido un error! No se guardaron los cambios",
                                        "Guardando registro", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
                    End If
                Catch evento As Exception
                    MsgBox(evento.Message)
                End Try
            Else
                MessageBox.Show("Falta Informacion para almacenar en la Base de Datos",
                                "Guardando registro", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If
        End If
        Me.Close()
        MainForm.refreshConsumersData()
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtConsumerName.Text = ""
        txtConsumerLastName.Text = ""
        txtConsumerIdCard.Text = ""
        txtConsumerPhone.Text = ""
        txtConsumerEmail.Text = ""
        txtConsumerAddress.Text = ""
    End Sub
End Class