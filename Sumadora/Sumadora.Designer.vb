<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sumadora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sumadora))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lNotificacion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvHistorial = New System.Windows.Forms.DataGridView()
        Me.Datos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ope = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbEmpresa = New System.Windows.Forms.TextBox()
        Me.cbNombre = New System.Windows.Forms.CheckBox()
        Me.cbFecha = New System.Windows.Forms.CheckBox()
        Me.cbLogo = New System.Windows.Forms.CheckBox()
        Me.cbPrint = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbMas = New System.Windows.Forms.Button()
        Me.cbIgual = New System.Windows.Forms.Button()
        Me.cbPunto = New System.Windows.Forms.Button()
        Me.cb0 = New System.Windows.Forms.Button()
        Me.cbMenos = New System.Windows.Forms.Button()
        Me.cb3 = New System.Windows.Forms.Button()
        Me.cb2 = New System.Windows.Forms.Button()
        Me.cb1 = New System.Windows.Forms.Button()
        Me.cbPor = New System.Windows.Forms.Button()
        Me.cb6 = New System.Windows.Forms.Button()
        Me.cb5 = New System.Windows.Forms.Button()
        Me.cb4 = New System.Windows.Forms.Button()
        Me.cbDividir = New System.Windows.Forms.Button()
        Me.cb9 = New System.Windows.Forms.Button()
        Me.cb8 = New System.Windows.Forms.Button()
        Me.cb7 = New System.Windows.Forms.Button()
        Me.tbResultado = New System.Windows.Forms.TextBox()
        Me.Tabla = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lNotificacion)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.dgvHistorial)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 513)
        Me.Panel1.TabIndex = 18
        '
        'lNotificacion
        '
        Me.lNotificacion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNotificacion.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lNotificacion.Location = New System.Drawing.Point(17, 179)
        Me.lNotificacion.Name = "lNotificacion"
        Me.lNotificacion.Size = New System.Drawing.Size(24, 22)
        Me.lNotificacion.TabIndex = 7
        Me.lNotificacion.Text = "."
        Me.lNotificacion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(-4, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Historial"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sumadora.My.Resources.Resources.Logo_Piramide
        Me.PictureBox1.Location = New System.Drawing.Point(3, 9)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'dgvHistorial
        '
        Me.dgvHistorial.BackgroundColor = System.Drawing.Color.White
        Me.dgvHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHistorial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Datos, Me.ope})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHistorial.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHistorial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvHistorial.GridColor = System.Drawing.Color.White
        Me.dgvHistorial.Location = New System.Drawing.Point(-42, 127)
        Me.dgvHistorial.Name = "dgvHistorial"
        Me.dgvHistorial.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvHistorial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistorial.Size = New System.Drawing.Size(244, 339)
        Me.dgvHistorial.TabIndex = 5
        Me.Tabla.SetToolTip(Me.dgvHistorial, "Doble click para editar valor.")
        '
        'Datos
        '
        Me.Datos.HeaderText = "Historial"
        Me.Datos.Name = "Datos"
        Me.Datos.Width = 175
        '
        'ope
        '
        Me.ope.HeaderText = "Operación"
        Me.ope.Name = "ope"
        Me.ope.Visible = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Sumadora.My.Resources.Resources.print
        Me.Button3.Location = New System.Drawing.Point(63, 470)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 39)
        Me.Button3.TabIndex = 4
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.cbMas)
        Me.Panel2.Controls.Add(Me.cbIgual)
        Me.Panel2.Controls.Add(Me.cbPunto)
        Me.Panel2.Controls.Add(Me.cb0)
        Me.Panel2.Controls.Add(Me.cbMenos)
        Me.Panel2.Controls.Add(Me.cb3)
        Me.Panel2.Controls.Add(Me.cb2)
        Me.Panel2.Controls.Add(Me.cb1)
        Me.Panel2.Controls.Add(Me.cbPor)
        Me.Panel2.Controls.Add(Me.cb6)
        Me.Panel2.Controls.Add(Me.cb5)
        Me.Panel2.Controls.Add(Me.cb4)
        Me.Panel2.Controls.Add(Me.cbDividir)
        Me.Panel2.Controls.Add(Me.cb9)
        Me.Panel2.Controls.Add(Me.cb8)
        Me.Panel2.Controls.Add(Me.cb7)
        Me.Panel2.Controls.Add(Me.tbResultado)
        Me.Panel2.Location = New System.Drawing.Point(221, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(471, 513)
        Me.Panel2.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbEmpresa)
        Me.GroupBox1.Controls.Add(Me.cbNombre)
        Me.GroupBox1.Controls.Add(Me.cbFecha)
        Me.GroupBox1.Controls.Add(Me.cbLogo)
        Me.GroupBox1.Controls.Add(Me.cbPrint)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 61)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'tbEmpresa
        '
        Me.tbEmpresa.BackColor = System.Drawing.SystemColors.Window
        Me.tbEmpresa.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmpresa.Location = New System.Drawing.Point(6, 22)
        Me.tbEmpresa.Name = "tbEmpresa"
        Me.tbEmpresa.Size = New System.Drawing.Size(124, 29)
        Me.tbEmpresa.TabIndex = 44
        Me.Tabla.SetToolTip(Me.tbEmpresa, "Puede editar presionando la tecla ""Espacio""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Para continuar operando presione ""In" & _
        "tro""")
        '
        'cbNombre
        '
        Me.cbNombre.AutoSize = True
        Me.cbNombre.Checked = True
        Me.cbNombre.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbNombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNombre.Location = New System.Drawing.Point(136, 27)
        Me.cbNombre.Name = "cbNombre"
        Me.cbNombre.Size = New System.Drawing.Size(83, 22)
        Me.cbNombre.TabIndex = 43
        Me.cbNombre.Text = "Nombre"
        Me.cbNombre.UseVisualStyleBackColor = True
        '
        'cbFecha
        '
        Me.cbFecha.AutoSize = True
        Me.cbFecha.Checked = True
        Me.cbFecha.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFecha.Location = New System.Drawing.Point(225, 27)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(71, 22)
        Me.cbFecha.TabIndex = 42
        Me.cbFecha.Text = "Fecha"
        Me.cbFecha.UseVisualStyleBackColor = True
        '
        'cbLogo
        '
        Me.cbLogo.AutoSize = True
        Me.cbLogo.Checked = True
        Me.cbLogo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbLogo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLogo.Location = New System.Drawing.Point(304, 27)
        Me.cbLogo.Name = "cbLogo"
        Me.cbLogo.Size = New System.Drawing.Size(63, 22)
        Me.cbLogo.TabIndex = 41
        Me.cbLogo.Text = "Logo"
        Me.cbLogo.UseVisualStyleBackColor = True
        '
        'cbPrint
        '
        Me.cbPrint.AutoSize = True
        Me.cbPrint.Checked = True
        Me.cbPrint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPrint.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPrint.Location = New System.Drawing.Point(374, 27)
        Me.cbPrint.Name = "cbPrint"
        Me.cbPrint.Size = New System.Drawing.Size(59, 22)
        Me.cbPrint.TabIndex = 40
        Me.cbPrint.Text = "Print"
        Me.cbPrint.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(151, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 21)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "_"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(238, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 21)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "_"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(318, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 21)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "_"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(388, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 21)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "_"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(16, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 80)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "CE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cbMas
        '
        Me.cbMas.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMas.Location = New System.Drawing.Point(375, 246)
        Me.cbMas.Name = "cbMas"
        Me.cbMas.Size = New System.Drawing.Size(80, 250)
        Me.cbMas.TabIndex = 34
        Me.cbMas.Text = "+"
        Me.cbMas.UseVisualStyleBackColor = True
        '
        'cbIgual
        '
        Me.cbIgual.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIgual.Location = New System.Drawing.Point(16, 244)
        Me.cbIgual.Name = "cbIgual"
        Me.cbIgual.Size = New System.Drawing.Size(80, 80)
        Me.cbIgual.TabIndex = 33
        Me.cbIgual.Text = "="
        Me.cbIgual.UseVisualStyleBackColor = True
        '
        'cbPunto
        '
        Me.cbPunto.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPunto.ForeColor = System.Drawing.Color.DimGray
        Me.cbPunto.Location = New System.Drawing.Point(280, 416)
        Me.cbPunto.Name = "cbPunto"
        Me.cbPunto.Size = New System.Drawing.Size(80, 82)
        Me.cbPunto.TabIndex = 32
        Me.cbPunto.Text = "."
        Me.cbPunto.UseVisualStyleBackColor = True
        '
        'cb0
        '
        Me.cb0.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb0.ForeColor = System.Drawing.Color.DimGray
        Me.cb0.Location = New System.Drawing.Point(108, 416)
        Me.cb0.Name = "cb0"
        Me.cb0.Size = New System.Drawing.Size(166, 80)
        Me.cb0.TabIndex = 31
        Me.cb0.Text = "0"
        Me.cb0.UseVisualStyleBackColor = True
        '
        'cbMenos
        '
        Me.cbMenos.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMenos.Location = New System.Drawing.Point(375, 159)
        Me.cbMenos.Name = "cbMenos"
        Me.cbMenos.Size = New System.Drawing.Size(80, 80)
        Me.cbMenos.TabIndex = 30
        Me.cbMenos.Text = "-"
        Me.cbMenos.UseVisualStyleBackColor = True
        '
        'cb3
        '
        Me.cb3.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb3.ForeColor = System.Drawing.Color.DimGray
        Me.cb3.Location = New System.Drawing.Point(280, 332)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(80, 80)
        Me.cb3.TabIndex = 29
        Me.cb3.Text = "3"
        Me.cb3.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb2.ForeColor = System.Drawing.Color.DimGray
        Me.cb2.Location = New System.Drawing.Point(194, 332)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(80, 80)
        Me.cb2.TabIndex = 28
        Me.cb2.Text = "2"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb1.ForeColor = System.Drawing.Color.DimGray
        Me.cb1.Location = New System.Drawing.Point(108, 330)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(80, 80)
        Me.cb1.TabIndex = 27
        Me.cb1.Text = "1"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'cbPor
        '
        Me.cbPor.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPor.Location = New System.Drawing.Point(16, 330)
        Me.cbPor.Name = "cbPor"
        Me.cbPor.Size = New System.Drawing.Size(80, 80)
        Me.cbPor.TabIndex = 26
        Me.cbPor.Text = "x"
        Me.cbPor.UseVisualStyleBackColor = True
        '
        'cb6
        '
        Me.cb6.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb6.ForeColor = System.Drawing.Color.DimGray
        Me.cb6.Location = New System.Drawing.Point(280, 246)
        Me.cb6.Name = "cb6"
        Me.cb6.Size = New System.Drawing.Size(80, 80)
        Me.cb6.TabIndex = 25
        Me.cb6.Text = "6"
        Me.cb6.UseVisualStyleBackColor = True
        '
        'cb5
        '
        Me.cb5.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb5.ForeColor = System.Drawing.Color.DimGray
        Me.cb5.Location = New System.Drawing.Point(194, 246)
        Me.cb5.Name = "cb5"
        Me.cb5.Size = New System.Drawing.Size(80, 80)
        Me.cb5.TabIndex = 24
        Me.cb5.Text = "5"
        Me.cb5.UseVisualStyleBackColor = True
        '
        'cb4
        '
        Me.cb4.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb4.ForeColor = System.Drawing.Color.DimGray
        Me.cb4.Location = New System.Drawing.Point(108, 244)
        Me.cb4.Name = "cb4"
        Me.cb4.Size = New System.Drawing.Size(80, 80)
        Me.cb4.TabIndex = 23
        Me.cb4.Text = "4"
        Me.cb4.UseVisualStyleBackColor = True
        '
        'cbDividir
        '
        Me.cbDividir.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDividir.Location = New System.Drawing.Point(16, 158)
        Me.cbDividir.Name = "cbDividir"
        Me.cbDividir.Size = New System.Drawing.Size(80, 80)
        Me.cbDividir.TabIndex = 22
        Me.cbDividir.Text = "/"
        Me.cbDividir.UseVisualStyleBackColor = True
        '
        'cb9
        '
        Me.cb9.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb9.ForeColor = System.Drawing.Color.DimGray
        Me.cb9.Location = New System.Drawing.Point(280, 159)
        Me.cb9.Name = "cb9"
        Me.cb9.Size = New System.Drawing.Size(80, 80)
        Me.cb9.TabIndex = 21
        Me.cb9.Text = "9"
        Me.cb9.UseVisualStyleBackColor = True
        '
        'cb8
        '
        Me.cb8.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb8.ForeColor = System.Drawing.Color.DimGray
        Me.cb8.Location = New System.Drawing.Point(194, 159)
        Me.cb8.Name = "cb8"
        Me.cb8.Size = New System.Drawing.Size(80, 80)
        Me.cb8.TabIndex = 20
        Me.cb8.Text = "8"
        Me.cb8.UseVisualStyleBackColor = True
        '
        'cb7
        '
        Me.cb7.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb7.ForeColor = System.Drawing.Color.DimGray
        Me.cb7.Location = New System.Drawing.Point(108, 158)
        Me.cb7.Name = "cb7"
        Me.cb7.Size = New System.Drawing.Size(80, 80)
        Me.cb7.TabIndex = 19
        Me.cb7.Text = "7"
        Me.cb7.UseVisualStyleBackColor = True
        '
        'tbResultado
        '
        Me.tbResultado.BackColor = System.Drawing.Color.White
        Me.tbResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbResultado.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResultado.Location = New System.Drawing.Point(16, 11)
        Me.tbResultado.MaxLength = 10
        Me.tbResultado.Name = "tbResultado"
        Me.tbResultado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbResultado.Size = New System.Drawing.Size(439, 63)
        Me.tbResultado.TabIndex = 18
        Me.tbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tabla
        '
        Me.Tabla.IsBalloon = True
        Me.Tabla.Tag = "Doble Click para editar"
        Me.Tabla.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Tabla.ToolTipTitle = "Editar"
        '
        'Sumadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(38.0!, 72.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(689, 520)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(21, 16, 21, 16)
        Me.MaximizeBox = False
        Me.Name = "Sumadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GEP Calculator V.2.0"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cbMas As System.Windows.Forms.Button
    Friend WithEvents cbIgual As System.Windows.Forms.Button
    Friend WithEvents cbPunto As System.Windows.Forms.Button
    Friend WithEvents cb0 As System.Windows.Forms.Button
    Friend WithEvents cbMenos As System.Windows.Forms.Button
    Friend WithEvents cb3 As System.Windows.Forms.Button
    Friend WithEvents cb2 As System.Windows.Forms.Button
    Friend WithEvents cb1 As System.Windows.Forms.Button
    Friend WithEvents cbPor As System.Windows.Forms.Button
    Friend WithEvents cb6 As System.Windows.Forms.Button
    Friend WithEvents cb5 As System.Windows.Forms.Button
    Friend WithEvents cb4 As System.Windows.Forms.Button
    Friend WithEvents cbDividir As System.Windows.Forms.Button
    Friend WithEvents cb9 As System.Windows.Forms.Button
    Friend WithEvents cb8 As System.Windows.Forms.Button
    Friend WithEvents cb7 As System.Windows.Forms.Button
    Friend WithEvents tbResultado As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dgvHistorial As System.Windows.Forms.DataGridView
    Friend WithEvents Datos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ope As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbFecha As CheckBox
    Friend WithEvents cbLogo As CheckBox
    Friend WithEvents cbPrint As CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents cbNombre As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Tabla As System.Windows.Forms.ToolTip
    Friend WithEvents lNotificacion As System.Windows.Forms.Label
End Class
