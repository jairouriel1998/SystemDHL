Imports System.Runtime.InteropServices
Public Class MainForm
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        btnMaximize.Visible = False
        btnRestaurate.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnRestaurate_Click(sender As Object, e As EventArgs) Handles btnRestaurate.Click
        btnMaximize.Visible = True
        btnRestaurate.Visible = False
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnRestaurate.Visible = False
        openFormInPanel(New frmStart)
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles superiorPanel.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub hiddenMenuTimer_Tick(sender As Object, e As EventArgs) Handles hiddenMenuTimer.Tick
        If menuPanel.Width <= 60 Then
            Me.hiddenMenuTimer.Enabled = False
        Else
            Me.menuPanel.Width = menuPanel.Width - 20
        End If
    End Sub

    Private Sub showMenuTimer_Tick(sender As Object, e As EventArgs) Handles showMenuTimer.Tick
        If menuPanel.Width >= 220 Then
            Me.showMenuTimer.Enabled = False
        Else
            Me.menuPanel.Width = menuPanel.Width + 20
        End If
    End Sub

    Private Sub btnAcordeon_Click(sender As Object, e As EventArgs) Handles btnAcordeon.Click
        If menuPanel.Width = 220 Then
            hiddenMenuTimer.Enabled = True
        ElseIf menuPanel.width = 60 Then
            showMenuTimer.Enabled = True
        End If

    End Sub

    Private Sub openFormInPanel(ByVal sonForm As Object)
        If Me.formsPanel.Controls.Count > 0 Then
            Me.formsPanel.Controls.RemoveAt(0)
        End If
        Dim sonFormObject As Form = TryCast(sonForm, Form)
            sonFormObject.TopLevel = False
            sonFormObject.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            sonFormObject.Dock = DockStyle.Fill
            Me.formsPanel.Controls.Add(sonFormObject)
            Me.formsPanel.Tag = sonFormObject
        sonFormObject.Show()
    End Sub

    Private Sub btnFormAbout_Click(sender As Object, e As EventArgs) Handles btnFormAbout.Click
        openFormInPanel(New frmAbout)
    End Sub

    Private Sub formsPanel_MouseHover(sender As Object, e As EventArgs) Handles formsPanel.MouseHover
        openFormInPanel(New frmStart)
    End Sub

    Private Sub btnFormEmpleados_Click(sender As Object, e As EventArgs) Handles btnFormEmpleados.Click
        openFormInPanel(New tableFormEmployees)
    End Sub

    Private Sub btnFormClientes_Click(sender As Object, e As EventArgs) Handles btnFormClientes.Click
        openFormInPanel(New tableFormConsumers)
    End Sub

    Public Sub refreshEmployeesData()
        openFormInPanel(New tableFormEmployees)
    End Sub

    Public Sub refreshConsumersData()
        openFormInPanel(New tableFormConsumers)
    End Sub
End Class
