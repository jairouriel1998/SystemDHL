<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tableFormConsumers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExitForm = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDeleteConsumer = New System.Windows.Forms.Button()
        Me.btnEditConsumer = New System.Windows.Forms.Button()
        Me.btnAddNewConsumer = New System.Windows.Forms.Button()
        Me.btnViewDetailsConsumer = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.datalistConsumers = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.datalistConsumers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnExitForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(875, 58)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(97, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(747, 43)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "REGISTRO DE CLIENTES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExitForm
        '
        Me.btnExitForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExitForm.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnExitForm.FlatAppearance.BorderSize = 0
        Me.btnExitForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitForm.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExitForm.Image = Global.ProyectoDHL.My.Resources.Resources.Icono_cerrar_FN
        Me.btnExitForm.Location = New System.Drawing.Point(0, 0)
        Me.btnExitForm.Name = "btnExitForm"
        Me.btnExitForm.Size = New System.Drawing.Size(68, 58)
        Me.btnExitForm.TabIndex = 4
        Me.btnExitForm.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnDeleteConsumer)
        Me.Panel2.Controls.Add(Me.btnEditConsumer)
        Me.Panel2.Controls.Add(Me.btnAddNewConsumer)
        Me.Panel2.Controls.Add(Me.btnViewDetailsConsumer)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(670, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(205, 494)
        Me.Panel2.TabIndex = 1
        '
        'btnDeleteConsumer
        '
        Me.btnDeleteConsumer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteConsumer.FlatAppearance.BorderSize = 0
        Me.btnDeleteConsumer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnDeleteConsumer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDeleteConsumer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteConsumer.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteConsumer.ForeColor = System.Drawing.Color.White
        Me.btnDeleteConsumer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteConsumer.Location = New System.Drawing.Point(1, 327)
        Me.btnDeleteConsumer.Name = "btnDeleteConsumer"
        Me.btnDeleteConsumer.Size = New System.Drawing.Size(200, 40)
        Me.btnDeleteConsumer.TabIndex = 11
        Me.btnDeleteConsumer.Text = "Eliminar Cliente"
        Me.btnDeleteConsumer.UseVisualStyleBackColor = True
        '
        'btnEditConsumer
        '
        Me.btnEditConsumer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditConsumer.FlatAppearance.BorderSize = 0
        Me.btnEditConsumer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnEditConsumer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEditConsumer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditConsumer.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditConsumer.ForeColor = System.Drawing.Color.White
        Me.btnEditConsumer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditConsumer.Location = New System.Drawing.Point(4, 260)
        Me.btnEditConsumer.Name = "btnEditConsumer"
        Me.btnEditConsumer.Size = New System.Drawing.Size(200, 40)
        Me.btnEditConsumer.TabIndex = 10
        Me.btnEditConsumer.Text = "Editar Cliente"
        Me.btnEditConsumer.UseVisualStyleBackColor = True
        '
        'btnAddNewConsumer
        '
        Me.btnAddNewConsumer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewConsumer.FlatAppearance.BorderSize = 0
        Me.btnAddNewConsumer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnAddNewConsumer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAddNewConsumer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewConsumer.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewConsumer.ForeColor = System.Drawing.Color.White
        Me.btnAddNewConsumer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNewConsumer.Location = New System.Drawing.Point(4, 192)
        Me.btnAddNewConsumer.Name = "btnAddNewConsumer"
        Me.btnAddNewConsumer.Size = New System.Drawing.Size(200, 40)
        Me.btnAddNewConsumer.TabIndex = 9
        Me.btnAddNewConsumer.Text = "Nuevo Cliente"
        Me.btnAddNewConsumer.UseVisualStyleBackColor = True
        '
        'btnViewDetailsConsumer
        '
        Me.btnViewDetailsConsumer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewDetailsConsumer.FlatAppearance.BorderSize = 0
        Me.btnViewDetailsConsumer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnViewDetailsConsumer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnViewDetailsConsumer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewDetailsConsumer.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDetailsConsumer.ForeColor = System.Drawing.Color.White
        Me.btnViewDetailsConsumer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewDetailsConsumer.Location = New System.Drawing.Point(1, 128)
        Me.btnViewDetailsConsumer.Name = "btnViewDetailsConsumer"
        Me.btnViewDetailsConsumer.Size = New System.Drawing.Size(200, 40)
        Me.btnViewDetailsConsumer.TabIndex = 8
        Me.btnViewDetailsConsumer.Text = "Ver detalles"
        Me.btnViewDetailsConsumer.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 489)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(670, 63)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.datalistConsumers)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 58)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(670, 431)
        Me.Panel4.TabIndex = 3
        '
        'datalistConsumers
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod
        Me.datalistConsumers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistConsumers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datalistConsumers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.datalistConsumers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.datalistConsumers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistConsumers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datalistConsumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistConsumers.DefaultCellStyle = DataGridViewCellStyle3
        Me.datalistConsumers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datalistConsumers.Location = New System.Drawing.Point(0, 0)
        Me.datalistConsumers.MultiSelect = False
        Me.datalistConsumers.Name = "datalistConsumers"
        Me.datalistConsumers.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistConsumers.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.datalistConsumers.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.datalistConsumers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.datalistConsumers.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.datalistConsumers.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.datalistConsumers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.datalistConsumers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Goldenrod
        Me.datalistConsumers.RowTemplate.Height = 30
        Me.datalistConsumers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistConsumers.Size = New System.Drawing.Size(670, 431)
        Me.datalistConsumers.TabIndex = 1
        '
        'tableFormConsumers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(875, 552)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tableFormConsumers"
        Me.Text = "tableFormConsumers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.datalistConsumers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExitForm As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents datalistConsumers As DataGridView
    Friend WithEvents btnDeleteConsumer As Button
    Friend WithEvents btnEditConsumer As Button
    Friend WithEvents btnAddNewConsumer As Button
    Friend WithEvents btnViewDetailsConsumer As Button
End Class
