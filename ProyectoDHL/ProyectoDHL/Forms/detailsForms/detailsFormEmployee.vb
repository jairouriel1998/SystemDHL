Imports System.Runtime.InteropServices
Public Class detailsFormEmployee
    Dim newEmployee, editEmployee, viewEmployee As Boolean
    Dim person_id, employee_id As Integer


    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Public Sub prepareForm(newData As Boolean, editData As Boolean, viewData As Boolean)
        newEmployee = newData
        editEmployee = editData
        viewEmployee = viewData
        prepareButtons()
        prepareTextBox()
    End Sub

    Private Sub prepareButtons()
        If newEmployee Or editEmployee Then
            btnSave.Visible = True
            btnClear.Visible = True
            btnCancel.Visible = True
            btnClose.Visible = False
        ElseIf viewEmployee Then
            btnSave.Visible = False
            btnClear.Visible = False
            btnCancel.Visible = False
            btnClose.Visible = True
        End If
    End Sub

    Private Sub prepareTextBox()
        If newEmployee Or editEmployee Then
            txtEmployeeName.Enabled = True
            txtEmployeeLastName.Enabled = True
            txtEmployeeIdCard.Enabled = True
            txtEmployeePhone.Enabled = True
            txtEmployeePhone.Enabled = True
            txtEmployeeEmail.Enabled = True
            txtEmployeePosition.Enabled = True
        ElseIf viewEmployee Then
            txtEmployeeName.Enabled = False
            txtEmployeeLastName.Enabled = False
            txtEmployeeIdCard.Enabled = False
            txtEmployeePhone.Enabled = False
            txtEmployeePhone.Enabled = False
            txtEmployeeEmail.Enabled = False
            txtEmployeePosition.Enabled = False
        End If
    End Sub


    Public Sub reciveData(employeeData As eEmployees)
        person_id = employeeData.Id_persona1
        employee_id = employeeData.Id_empleado1
        txtEmployeeName.Text = employeeData.Nombre1
        txtEmployeeLastName.Text = employeeData.Apellido1
        txtEmployeeIdCard.Text = employeeData.Identidad1
        txtEmployeePhone.Text = employeeData.Telefono1
        txtEmployeeEmail.Text = employeeData.Email1
        txtEmployeePosition.Text = employeeData.Cargo1
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If newEmployee Then
            If txtEmployeeName.Text <> "" And txtEmployeeLastName.Text <> "" And
                txtEmployeeIdCard.Text <> "" And txtEmployeePhone.Text <> "" And
                txtEmployeeEmail.Text <> "" And txtEmployeePosition.Text <> "" Then
                Try
                    Dim tablaDatos As New eEmployees
                    Dim funciones As New dEmployees
                    tablaDatos.Nombre1 = txtEmployeeName.Text
                    tablaDatos.Apellido1 = txtEmployeeLastName.Text
                    tablaDatos.Identidad1 = txtEmployeeIdCard.Text
                    tablaDatos.Telefono1 = txtEmployeePhone.Text
                    tablaDatos.Email1 = txtEmployeeEmail.Text
                    tablaDatos.Cargo1 = txtEmployeePosition.Text
                    If funciones.insertar(tablaDatos) Then
                        MessageBox.Show("Empleado registrado exitosamente",
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
        ElseIf editEmployee Then
            If txtEmployeeName.Text <> "" And txtEmployeeLastName.Text <> "" And
                txtEmployeeIdCard.Text <> "" And txtEmployeePhone.Text <> "" And
                txtEmployeeEmail.Text <> "" And txtEmployeePosition.Text <> "" Then
                Try
                    Dim tablaDatos As New eEmployees
                    Dim funciones As New dEmployees
                    tablaDatos.Id_persona1 = person_id
                    tablaDatos.Id_empleado1 = employee_id
                    tablaDatos.Nombre1 = txtEmployeeName.Text
                    tablaDatos.Apellido1 = txtEmployeeLastName.Text
                    tablaDatos.Identidad1 = txtEmployeeIdCard.Text
                    tablaDatos.Telefono1 = txtEmployeePhone.Text
                    tablaDatos.Email1 = txtEmployeeEmail.Text
                    tablaDatos.Cargo1 = txtEmployeePosition.Text
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
        MainForm.refreshEmployeesData()
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
        txtEmployeeName.Text = ""
        txtEmployeeLastName.Text = ""
        txtEmployeeIdCard.Text = ""
        txtEmployeePhone.Text = ""
        txtEmployeeEmail.Text = ""
        txtEmployeePosition.Text = ""
    End Sub


End Class