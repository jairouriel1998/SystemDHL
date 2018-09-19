<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.superiorPanel = New System.Windows.Forms.Panel()
        Me.menuPanel = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.formsPanel = New System.Windows.Forms.Panel()
        Me.hiddenMenuTimer = New System.Windows.Forms.Timer(Me.components)
        Me.showMenuTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnFormAbout = New System.Windows.Forms.Button()
        Me.btnFormAlmacenaje = New System.Windows.Forms.Button()
        Me.btnFormTipoPago = New System.Windows.Forms.Button()
        Me.btnFormTarifas = New System.Windows.Forms.Button()
        Me.btnFormServiciosExtras = New System.Windows.Forms.Button()
        Me.btnFormPaquetes = New System.Windows.Forms.Button()
        Me.btnFormArticulos = New System.Windows.Forms.Button()
        Me.btnFormEmpleados = New System.Windows.Forms.Button()
        Me.btnFormClientes = New System.Windows.Forms.Button()
        Me.btnFormTipoServicio = New System.Windows.Forms.Button()
        Me.btnFormPaises = New System.Windows.Forms.Button()
        Me.btnFormEnvios = New System.Windows.Forms.Button()
        Me.picboxLogo = New System.Windows.Forms.PictureBox()
        Me.btnAcordeon = New System.Windows.Forms.PictureBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.btnRestaurate = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.superiorPanel.SuspendLayout()
        Me.menuPanel.SuspendLayout()
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAcordeon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'superiorPanel
        '
        Me.superiorPanel.BackColor = System.Drawing.Color.Goldenrod
        Me.superiorPanel.Controls.Add(Me.logo)
        Me.superiorPanel.Controls.Add(Me.btnRestaurate)
        Me.superiorPanel.Controls.Add(Me.btnMinimize)
        Me.superiorPanel.Controls.Add(Me.btnMaximize)
        Me.superiorPanel.Controls.Add(Me.btnClose)
        Me.superiorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.superiorPanel.Location = New System.Drawing.Point(0, 0)
        Me.superiorPanel.Name = "superiorPanel"
        Me.superiorPanel.Size = New System.Drawing.Size(1100, 40)
        Me.superiorPanel.TabIndex = 0
        '
        'menuPanel
        '
        Me.menuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.menuPanel.Controls.Add(Me.Panel12)
        Me.menuPanel.Controls.Add(Me.btnFormAbout)
        Me.menuPanel.Controls.Add(Me.Panel11)
        Me.menuPanel.Controls.Add(Me.Panel10)
        Me.menuPanel.Controls.Add(Me.Panel9)
        Me.menuPanel.Controls.Add(Me.Panel8)
        Me.menuPanel.Controls.Add(Me.Panel7)
        Me.menuPanel.Controls.Add(Me.Panel6)
        Me.menuPanel.Controls.Add(Me.btnFormAlmacenaje)
        Me.menuPanel.Controls.Add(Me.btnFormTipoPago)
        Me.menuPanel.Controls.Add(Me.btnFormTarifas)
        Me.menuPanel.Controls.Add(Me.btnFormServiciosExtras)
        Me.menuPanel.Controls.Add(Me.btnFormPaquetes)
        Me.menuPanel.Controls.Add(Me.btnFormArticulos)
        Me.menuPanel.Controls.Add(Me.Panel5)
        Me.menuPanel.Controls.Add(Me.Panel4)
        Me.menuPanel.Controls.Add(Me.Panel3)
        Me.menuPanel.Controls.Add(Me.Panel2)
        Me.menuPanel.Controls.Add(Me.btnFormEmpleados)
        Me.menuPanel.Controls.Add(Me.btnFormClientes)
        Me.menuPanel.Controls.Add(Me.btnFormTipoServicio)
        Me.menuPanel.Controls.Add(Me.btnFormPaises)
        Me.menuPanel.Controls.Add(Me.Panel1)
        Me.menuPanel.Controls.Add(Me.btnFormEnvios)
        Me.menuPanel.Controls.Add(Me.picboxLogo)
        Me.menuPanel.Controls.Add(Me.btnAcordeon)
        Me.menuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.menuPanel.Location = New System.Drawing.Point(0, 40)
        Me.menuPanel.Name = "menuPanel"
        Me.menuPanel.Size = New System.Drawing.Size(220, 660)
        Me.menuPanel.TabIndex = 1
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel12.Location = New System.Drawing.Point(0, 616)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(5, 38)
        Me.Panel12.TabIndex = 6
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel11.Location = New System.Drawing.Point(0, 570)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(5, 38)
        Me.Panel11.TabIndex = 5
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel10.Location = New System.Drawing.Point(0, 524)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(5, 38)
        Me.Panel10.TabIndex = 5
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel9.Location = New System.Drawing.Point(0, 478)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(5, 38)
        Me.Panel9.TabIndex = 5
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel8.Location = New System.Drawing.Point(0, 432)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(5, 38)
        Me.Panel8.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel7.Location = New System.Drawing.Point(0, 386)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 38)
        Me.Panel7.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel6.Location = New System.Drawing.Point(0, 340)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 38)
        Me.Panel6.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel5.Location = New System.Drawing.Point(0, 296)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 38)
        Me.Panel5.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel4.Location = New System.Drawing.Point(0, 250)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 38)
        Me.Panel4.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel3.Location = New System.Drawing.Point(0, 204)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 38)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel2.Location = New System.Drawing.Point(0, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 38)
        Me.Panel2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel1.Location = New System.Drawing.Point(0, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 38)
        Me.Panel1.TabIndex = 3
        '
        'formsPanel
        '
        Me.formsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.formsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.formsPanel.Location = New System.Drawing.Point(220, 40)
        Me.formsPanel.Name = "formsPanel"
        Me.formsPanel.Size = New System.Drawing.Size(880, 660)
        Me.formsPanel.TabIndex = 2
        '
        'hiddenMenuTimer
        '
        '
        'showMenuTimer
        '
        '
        'btnFormAbout
        '
        Me.btnFormAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormAbout.FlatAppearance.BorderSize = 0
        Me.btnFormAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnFormAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFormAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormAbout.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormAbout.ForeColor = System.Drawing.Color.White
        Me.btnFormAbout.Image = Global.ProyectoDHL.My.Resources.Resources.empleados
        Me.btnFormAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormAbout.Location = New System.Drawing.Point(0, 616)
        Me.btnFormAbout.Name = "btnFormAbout"
        Me.btnFormAbout.Size = New System.Drawing.Size(220, 40)
        Me.btnFormAbout.TabIndex = 14
        Me.btnFormAbout.Text = "About"
        Me.btnFormAbout.UseVisualStyleBackColor = True
        '
        'btnFormAlmacenaje
        '
        Me.btnFormAlmacenaje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormAlmacenaje.FlatAppearance.BorderSize = 0
        Me.btnFormAlmacenaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnFormAlmacenaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFormAlmacenaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormAlmacenaje.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormAlmacenaje.ForeColor = System.Drawing.Color.White
        Me.btnFormAlmacenaje.Image = Global.ProyectoDHL.My.Resources.Resources.producto
        Me.btnFormAlmacenaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormAlmacenaje.Location = New System.Drawing.Point(0, 570)
        Me.btnFormAlmacenaje.Name = "btnFormAlmacenaje"
        Me.btnFormAlmacenaje.Size = New System.Drawing.Size(220, 40)
        Me.btnFormAlmacenaje.TabIndex = 13
        Me.btnFormAlmacenaje.Text = "Almacenaje"
        Me.btnFormAlmacenaje.UseVisualStyleBackColor = True
        '
        'btnFormTipoPago
        '
        Me.btnFormTipoPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormTipoPago.FlatAppearance.BorderSize = 0
        Me.btnFormTipoPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnFormTipoPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFormTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormTipoPago.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormTipoPago.ForeColor = System.Drawing.Color.White
        Me.btnFormTipoPago.Image = Global.ProyectoDHL.My.Resources.Resources.venta
        Me.btnFormTipoPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormTipoPago.Location = New System.Drawing.Point(0, 524)
        Me.btnFormTipoPago.Name = "btnFormTipoPago"
        Me.btnFormTipoPago.Size = New System.Drawing.Size(220, 40)
        Me.btnFormTipoPago.TabIndex = 12
        Me.btnFormTipoPago.Text = "Finanzas"
        Me.btnFormTipoPago.UseVisualStyleBackColor = True
        '
        'btnFormTarifas
        '
        Me.btnFormTarifas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormTarifas.FlatAppearance.BorderSize = 0
        Me.btnFormTarifas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnFormTarifas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFormTarifas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormTarifas.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormTarifas.ForeColor = System.Drawing.Color.White
        Me.btnFormTarifas.Image = Global.ProyectoDHL.My.Resources.Resources.pagos
        Me.btnFormTarifas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormTarifas.Location = New System.Drawing.Point(0, 478)
        Me.btnFormTarifas.Name = "btnFormTarifas"
        Me.btnFormTarifas.Size = New System.Drawing.Size(220, 40)
        Me.btnFormTarifas.TabIndex = 11
        Me.btnFormTarifas.Text = "Tarifas"
        Me.btnFormTarifas.UseVisualStyleBackColor = True
        '
        'btnFormServiciosExtras
        '
        Me.btnFormServiciosExtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormServiciosExtras.FlatAppearance.BorderSize = 0
        Me.btnFormServiciosExtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnFormServiciosExtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFormServiciosExtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormServiciosExtras.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormServiciosExtras.ForeColor = System.Drawing.Color.White
        Me.btnFormServiciosExtras.Image = Global.ProyectoDHL.My.Resources.Resources.relo3
        Me.btnFormServiciosExtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormServiciosExtras.Location = New System.Drawing.Point(0, 432)
        Me.btnFormServiciosExtras.Name = "btnFormServiciosExtras"
        Me.btnFormServiciosExtras.Size = New System.Drawing.Size(220, 40)
        Me.btnFormServiciosExtras.TabIndex = 10
        Me.btnFormServiciosExtras.Text = "Extras"
        Me.btnFormServiciosExtras.UseVisualStyleBackColor = True
        '
        'btnFormPaquetes
        '
        Me.btnFormPaquetes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormPaquetes.FlatAppearance.BorderSize = 0
        Me.btnFormPaquetes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnFormPaquetes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFormPaquetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormPaquetes.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormPaquetes.ForeColor = System.Drawing.Color.White
        Me.btnFormPaquetes.Image = Global.ProyectoDHL.My.Resources.Resources.reportes
        Me.btnFormPaquetes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormPaquetes.Location = New System.Drawing.Point(0, 386)
        Me.btnFormPaquetes.Name = "btnFormPaquetes"
        Me.btnFormPaquetes.Size = New System.Drawing.Size(220, 40)
        Me.btnFormPaquetes.TabIndex = 9
        Me.btnFormPaquetes.Text = "Paquetes"
        Me.btnFormPaquetes.UseVisualStyleBackColor = True
        '
        'btnFormArticulos
        '
        Me.btnFormArticulos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormArticulos.FlatAppearance.BorderSize = 0
        Me.btnFormArticulos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnFormArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFormArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormArticulos.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormArticulos.ForeColor = System.Drawing.Color.White
        Me.btnFormArticulos.Image = Global.ProyectoDHL.My.Resources.Resources.producto
        Me.btnFormArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormArticulos.Location = New System.Drawing.Point(0, 340)
        Me.btnFormArticulos.Name = "btnFormArticulos"
        Me.btnFormArticulos.Size = New System.Drawing.Size(220, 40)
        Me.btnFormArticulos.TabIndex = 8
        Me.btnFormArticulos.Text = "Articulos"
        Me.btnFormArticulos.UseVisualStyleBackColor = True
        '
        'btnFormEmpleados
        '
        Me.btnFormEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormEmpleados.FlatAppearance.BorderSize = 0
        Me.btnFormEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnFormEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFormEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormEmpleados.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormEmpleados.ForeColor = System.Drawing.Color.White
        Me.btnFormEmpleados.Image = Global.ProyectoDHL.My.Resources.Resources.empleados
        Me.btnFormEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormEmpleados.Location = New System.Drawing.Point(0, 158)
        Me.btnFormEmpleados.Name = "btnFormEmpleados"
        Me.btnFormEmpleados.Size = New System.Drawing.Size(220, 40)
        Me.btnFormEmpleados.TabIndex = 7
        Me.btnFormEmpleados.Text = "Empleados"
        Me.btnFormEmpleados.UseVisualStyleBackColor = True
        '
        'btnFormClientes
        '
        Me.btnFormClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormClientes.FlatAppearance.BorderSize = 0
        Me.btnFormClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnFormClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFormClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormClientes.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormClientes.ForeColor = System.Drawing.Color.White
        Me.btnFormClientes.Image = Global.ProyectoDHL.My.Resources.Resources.clientes
        Me.btnFormClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormClientes.Location = New System.Drawing.Point(0, 204)
        Me.btnFormClientes.Name = "btnFormClientes"
        Me.btnFormClientes.Size = New System.Drawing.Size(220, 40)
        Me.btnFormClientes.TabIndex = 6
        Me.btnFormClientes.Text = "Clientes"
        Me.btnFormClientes.UseVisualStyleBackColor = True
        '
        'btnFormTipoServicio
        '
        Me.btnFormTipoServicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormTipoServicio.FlatAppearance.BorderSize = 0
        Me.btnFormTipoServicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnFormTipoServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFormTipoServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormTipoServicio.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormTipoServicio.ForeColor = System.Drawing.Color.White
        Me.btnFormTipoServicio.Image = Global.ProyectoDHL.My.Resources.Resources.venta
        Me.btnFormTipoServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormTipoServicio.Location = New System.Drawing.Point(0, 296)
        Me.btnFormTipoServicio.Name = "btnFormTipoServicio"
        Me.btnFormTipoServicio.Size = New System.Drawing.Size(220, 40)
        Me.btnFormTipoServicio.TabIndex = 5
        Me.btnFormTipoServicio.Text = "Servicios"
        Me.btnFormTipoServicio.UseVisualStyleBackColor = True
        '
        'btnFormPaises
        '
        Me.btnFormPaises.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormPaises.FlatAppearance.BorderSize = 0
        Me.btnFormPaises.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnFormPaises.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFormPaises.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormPaises.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormPaises.ForeColor = System.Drawing.Color.White
        Me.btnFormPaises.Image = Global.ProyectoDHL.My.Resources.Resources.reportes
        Me.btnFormPaises.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormPaises.Location = New System.Drawing.Point(0, 250)
        Me.btnFormPaises.Name = "btnFormPaises"
        Me.btnFormPaises.Size = New System.Drawing.Size(220, 40)
        Me.btnFormPaises.TabIndex = 4
        Me.btnFormPaises.Text = "Paises"
        Me.btnFormPaises.UseVisualStyleBackColor = True
        '
        'btnFormEnvios
        '
        Me.btnFormEnvios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormEnvios.FlatAppearance.BorderSize = 0
        Me.btnFormEnvios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnFormEnvios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFormEnvios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormEnvios.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormEnvios.ForeColor = System.Drawing.Color.White
        Me.btnFormEnvios.Image = Global.ProyectoDHL.My.Resources.Resources.compras
        Me.btnFormEnvios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormEnvios.Location = New System.Drawing.Point(0, 112)
        Me.btnFormEnvios.Name = "btnFormEnvios"
        Me.btnFormEnvios.Size = New System.Drawing.Size(220, 40)
        Me.btnFormEnvios.TabIndex = 2
        Me.btnFormEnvios.Text = "Envios"
        Me.btnFormEnvios.UseVisualStyleBackColor = True
        '
        'picboxLogo
        '
        Me.picboxLogo.Image = Global.ProyectoDHL.My.Resources.Resources.ll
        Me.picboxLogo.Location = New System.Drawing.Point(0, 56)
        Me.picboxLogo.Name = "picboxLogo"
        Me.picboxLogo.Size = New System.Drawing.Size(220, 50)
        Me.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picboxLogo.TabIndex = 1
        Me.picboxLogo.TabStop = False
        '
        'btnAcordeon
        '
        Me.btnAcordeon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAcordeon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAcordeon.Image = Global.ProyectoDHL.My.Resources.Resources.Mobile_Menu_Icon
        Me.btnAcordeon.Location = New System.Drawing.Point(166, 0)
        Me.btnAcordeon.Name = "btnAcordeon"
        Me.btnAcordeon.Size = New System.Drawing.Size(54, 50)
        Me.btnAcordeon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAcordeon.TabIndex = 0
        Me.btnAcordeon.TabStop = False
        '
        'logo
        '
        Me.logo.Dock = System.Windows.Forms.DockStyle.Left
        Me.logo.Image = Global.ProyectoDHL.My.Resources.Resources.DHL_Logo
        Me.logo.Location = New System.Drawing.Point(0, 0)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(220, 40)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 4
        Me.logo.TabStop = False
        '
        'btnRestaurate
        '
        Me.btnRestaurate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurate.FlatAppearance.BorderSize = 0
        Me.btnRestaurate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRestaurate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnRestaurate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurate.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestaurate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRestaurate.Image = Global.ProyectoDHL.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurate.Location = New System.Drawing.Point(1014, 0)
        Me.btnRestaurate.Name = "btnRestaurate"
        Me.btnRestaurate.Size = New System.Drawing.Size(40, 40)
        Me.btnRestaurate.TabIndex = 3
        Me.btnRestaurate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRestaurate.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMinimize.Image = Global.ProyectoDHL.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimize.Location = New System.Drawing.Point(968, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaximize.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMaximize.Image = Global.ProyectoDHL.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximize.Location = New System.Drawing.Point(1014, 0)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(40, 40)
        Me.btnMaximize.TabIndex = 1
        Me.btnMaximize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClose.Image = Global.ProyectoDHL.My.Resources.Resources.Icono_cerrar_FN
        Me.btnClose.Location = New System.Drawing.Point(1060, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.formsPanel)
        Me.Controls.Add(Me.menuPanel)
        Me.Controls.Add(Me.superiorPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.superiorPanel.ResumeLayout(False)
        Me.menuPanel.ResumeLayout(False)
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAcordeon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents superiorPanel As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnRestaurate As Button
    Friend WithEvents menuPanel As Panel
    Friend WithEvents formsPanel As Panel
    Friend WithEvents btnAcordeon As PictureBox
    Friend WithEvents hiddenMenuTimer As Timer
    Friend WithEvents showMenuTimer As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnFormEnvios As Button
    Friend WithEvents picboxLogo As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnFormEmpleados As Button
    Friend WithEvents btnFormClientes As Button
    Friend WithEvents btnFormTipoServicio As Button
    Friend WithEvents btnFormPaises As Button
    Friend WithEvents btnFormAlmacenaje As Button
    Friend WithEvents btnFormTipoPago As Button
    Friend WithEvents btnFormTarifas As Button
    Friend WithEvents btnFormServiciosExtras As Button
    Friend WithEvents btnFormPaquetes As Button
    Friend WithEvents btnFormArticulos As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents btnFormAbout As Button
    Friend WithEvents logo As PictureBox
End Class
