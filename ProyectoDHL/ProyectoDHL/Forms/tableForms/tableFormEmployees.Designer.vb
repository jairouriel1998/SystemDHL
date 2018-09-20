<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tableFormEmployees
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExitForm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDeleteEmployee = New System.Windows.Forms.Button()
        Me.btnEditEmployee = New System.Windows.Forms.Button()
        Me.btnAddNewEmployee = New System.Windows.Forms.Button()
        Me.btnViewDetailsEmployee = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.datalistEmployees = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.datalistEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnExitForm)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(833, 55)
        Me.Panel1.TabIndex = 0
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
        Me.btnExitForm.Size = New System.Drawing.Size(68, 55)
        Me.btnExitForm.TabIndex = 3
        Me.btnExitForm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(74, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(747, 42)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "REGISTRO DE EMPLEADOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 533)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(833, 39)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnDeleteEmployee)
        Me.Panel3.Controls.Add(Me.btnEditEmployee)
        Me.Panel3.Controls.Add(Me.btnAddNewEmployee)
        Me.Panel3.Controls.Add(Me.btnViewDetailsEmployee)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(633, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 478)
        Me.Panel3.TabIndex = 2
        '
        'btnDeleteEmployee
        '
        Me.btnDeleteEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteEmployee.FlatAppearance.BorderSize = 0
        Me.btnDeleteEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnDeleteEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteEmployee.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteEmployee.ForeColor = System.Drawing.Color.White
        Me.btnDeleteEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteEmployee.Location = New System.Drawing.Point(0, 288)
        Me.btnDeleteEmployee.Name = "btnDeleteEmployee"
        Me.btnDeleteEmployee.Size = New System.Drawing.Size(200, 40)
        Me.btnDeleteEmployee.TabIndex = 7
        Me.btnDeleteEmployee.Text = "Eliminar Empleado"
        Me.btnDeleteEmployee.UseVisualStyleBackColor = True
        '
        'btnEditEmployee
        '
        Me.btnEditEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditEmployee.FlatAppearance.BorderSize = 0
        Me.btnEditEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnEditEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditEmployee.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditEmployee.ForeColor = System.Drawing.Color.White
        Me.btnEditEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditEmployee.Location = New System.Drawing.Point(0, 221)
        Me.btnEditEmployee.Name = "btnEditEmployee"
        Me.btnEditEmployee.Size = New System.Drawing.Size(200, 40)
        Me.btnEditEmployee.TabIndex = 6
        Me.btnEditEmployee.Text = "Editar Empleado"
        Me.btnEditEmployee.UseVisualStyleBackColor = True
        '
        'btnAddNewEmployee
        '
        Me.btnAddNewEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewEmployee.FlatAppearance.BorderSize = 0
        Me.btnAddNewEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnAddNewEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAddNewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewEmployee.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewEmployee.ForeColor = System.Drawing.Color.White
        Me.btnAddNewEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNewEmployee.Location = New System.Drawing.Point(0, 153)
        Me.btnAddNewEmployee.Name = "btnAddNewEmployee"
        Me.btnAddNewEmployee.Size = New System.Drawing.Size(200, 40)
        Me.btnAddNewEmployee.TabIndex = 5
        Me.btnAddNewEmployee.Text = "Nuevo Empleado"
        Me.btnAddNewEmployee.UseVisualStyleBackColor = True
        '
        'btnViewDetailsEmployee
        '
        Me.btnViewDetailsEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewDetailsEmployee.FlatAppearance.BorderSize = 0
        Me.btnViewDetailsEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnViewDetailsEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnViewDetailsEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewDetailsEmployee.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDetailsEmployee.ForeColor = System.Drawing.Color.White
        Me.btnViewDetailsEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewDetailsEmployee.Location = New System.Drawing.Point(0, 89)
        Me.btnViewDetailsEmployee.Name = "btnViewDetailsEmployee"
        Me.btnViewDetailsEmployee.Size = New System.Drawing.Size(197, 40)
        Me.btnViewDetailsEmployee.TabIndex = 4
        Me.btnViewDetailsEmployee.Text = "Ver detalles"
        Me.btnViewDetailsEmployee.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.datalistEmployees)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 55)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(633, 478)
        Me.Panel4.TabIndex = 3
        '
        'datalistEmployees
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod
        Me.datalistEmployees.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistEmployees.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datalistEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datalistEmployees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.datalistEmployees.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.datalistEmployees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistEmployees.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datalistEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistEmployees.DefaultCellStyle = DataGridViewCellStyle3
        Me.datalistEmployees.Location = New System.Drawing.Point(0, 0)
        Me.datalistEmployees.MultiSelect = False
        Me.datalistEmployees.Name = "datalistEmployees"
        Me.datalistEmployees.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistEmployees.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.datalistEmployees.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.datalistEmployees.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.datalistEmployees.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.datalistEmployees.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.datalistEmployees.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.datalistEmployees.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Goldenrod
        Me.datalistEmployees.RowTemplate.Height = 30
        Me.datalistEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistEmployees.Size = New System.Drawing.Size(633, 478)
        Me.datalistEmployees.TabIndex = 0
        '
        'tableFormEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(833, 572)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tableFormEmployees"
        Me.Text = "tableFormEmployees"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.datalistEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExitForm As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents datalistEmployees As DataGridView
    Friend WithEvents btnViewDetailsEmployee As Button
    Friend WithEvents btnDeleteEmployee As Button
    Friend WithEvents btnEditEmployee As Button
    Friend WithEvents btnAddNewEmployee As Button
End Class
