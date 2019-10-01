<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpArticulo_Material
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtImporteFinal = New System.Windows.Forms.TextBox()
        Me.cbTiposIvaCalculo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCostoCalculo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbTiposIva = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMoneda = New System.Windows.Forms.ComboBox()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.txtGanancia = New System.Windows.Forms.TextBox()
        Me.lblGanancia = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.chkRecalcula = New System.Windows.Forms.CheckBox()
        Me.btnAddSeccion = New System.Windows.Forms.Button()
        Me.btnAddDepto = New System.Windows.Forms.Button()
        Me.btnAddMarca = New System.Windows.Forms.Button()
        Me.cbSeccion = New System.Windows.Forms.ComboBox()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cbMarca = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.txtCodBarras1 = New System.Windows.Forms.TextBox()
        Me.lblcodBarras1 = New System.Windows.Forms.Label()
        Me.txtCodBarras = New System.Windows.Forms.TextBox()
        Me.lblCodBarras = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkDescatalogado = New System.Windows.Forms.CheckBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCalcular)
        Me.GroupBox3.Controls.Add(Me.txtImporteFinal)
        Me.GroupBox3.Controls.Add(Me.cbTiposIvaCalculo)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtCostoCalculo)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(460, 313)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(452, 201)
        Me.GroupBox3.TabIndex = 118
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Calcular a partir de:"
        '
        'btnCalcular
        '
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.btnCalcular.Location = New System.Drawing.Point(200, 150)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(94, 36)
        Me.btnCalcular.TabIndex = 37
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtImporteFinal
        '
        Me.txtImporteFinal.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.txtImporteFinal.Location = New System.Drawing.Point(200, 103)
        Me.txtImporteFinal.Name = "txtImporteFinal"
        Me.txtImporteFinal.Size = New System.Drawing.Size(245, 36)
        Me.txtImporteFinal.TabIndex = 36
        '
        'cbTiposIvaCalculo
        '
        Me.cbTiposIvaCalculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTiposIvaCalculo.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.cbTiposIvaCalculo.FormattingEnabled = True
        Me.cbTiposIvaCalculo.Location = New System.Drawing.Point(200, 61)
        Me.cbTiposIvaCalculo.Name = "cbTiposIvaCalculo"
        Me.cbTiposIvaCalculo.Size = New System.Drawing.Size(245, 36)
        Me.cbTiposIvaCalculo.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(67, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 20)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "IVA:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCostoCalculo
        '
        Me.txtCostoCalculo.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.txtCostoCalculo.Location = New System.Drawing.Point(200, 19)
        Me.txtCostoCalculo.Name = "txtCostoCalculo"
        Me.txtCostoCalculo.Size = New System.Drawing.Size(245, 36)
        Me.txtCostoCalculo.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(41, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "COSTO:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(41, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 24)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "IMPORTE FINAL:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbTiposIva
        '
        Me.cbTiposIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTiposIva.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.cbTiposIva.FormattingEnabled = True
        Me.cbTiposIva.Location = New System.Drawing.Point(660, 268)
        Me.cbTiposIva.Name = "cbTiposIva"
        Me.cbTiposIva.Size = New System.Drawing.Size(252, 36)
        Me.cbTiposIva.TabIndex = 117
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(516, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "IVA:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbMoneda
        '
        Me.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMoneda.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.cbMoneda.FormattingEnabled = True
        Me.cbMoneda.Location = New System.Drawing.Point(660, 226)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Size = New System.Drawing.Size(252, 36)
        Me.cbMoneda.TabIndex = 115
        '
        'lblMoneda
        '
        Me.lblMoneda.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.lblMoneda.Location = New System.Drawing.Point(519, 233)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(135, 21)
        Me.lblMoneda.TabIndex = 114
        Me.lblMoneda.Text = "MONEDA:"
        Me.lblMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGanancia
        '
        Me.txtGanancia.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.txtGanancia.Location = New System.Drawing.Point(660, 184)
        Me.txtGanancia.Name = "txtGanancia"
        Me.txtGanancia.Size = New System.Drawing.Size(252, 36)
        Me.txtGanancia.TabIndex = 113
        '
        'lblGanancia
        '
        Me.lblGanancia.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.lblGanancia.Location = New System.Drawing.Point(516, 191)
        Me.lblGanancia.Name = "lblGanancia"
        Me.lblGanancia.Size = New System.Drawing.Size(138, 20)
        Me.lblGanancia.TabIndex = 112
        Me.lblGanancia.Text = "GANANCIA:"
        Me.lblGanancia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCosto
        '
        Me.txtCosto.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.txtCosto.Location = New System.Drawing.Point(660, 143)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(252, 36)
        Me.txtCosto.TabIndex = 111
        '
        'lblPrecio
        '
        Me.lblPrecio.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.lblPrecio.Location = New System.Drawing.Point(525, 150)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(129, 20)
        Me.lblPrecio.TabIndex = 110
        Me.lblPrecio.Text = "COSTO:"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkRecalcula
        '
        Me.chkRecalcula.AutoSize = True
        Me.chkRecalcula.Checked = True
        Me.chkRecalcula.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRecalcula.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRecalcula.Location = New System.Drawing.Point(173, 517)
        Me.chkRecalcula.Name = "chkRecalcula"
        Me.chkRecalcula.Size = New System.Drawing.Size(110, 32)
        Me.chkRecalcula.TabIndex = 109
        Me.chkRecalcula.Text = "Recalcula"
        Me.chkRecalcula.UseVisualStyleBackColor = True
        '
        'btnAddSeccion
        '
        Me.btnAddSeccion.Location = New System.Drawing.Point(430, 483)
        Me.btnAddSeccion.Name = "btnAddSeccion"
        Me.btnAddSeccion.Size = New System.Drawing.Size(22, 23)
        Me.btnAddSeccion.TabIndex = 108
        Me.btnAddSeccion.Text = "+"
        Me.btnAddSeccion.UseVisualStyleBackColor = True
        '
        'btnAddDepto
        '
        Me.btnAddDepto.Location = New System.Drawing.Point(430, 441)
        Me.btnAddDepto.Name = "btnAddDepto"
        Me.btnAddDepto.Size = New System.Drawing.Size(22, 23)
        Me.btnAddDepto.TabIndex = 107
        Me.btnAddDepto.Text = "+"
        Me.btnAddDepto.UseVisualStyleBackColor = True
        '
        'btnAddMarca
        '
        Me.btnAddMarca.Location = New System.Drawing.Point(430, 402)
        Me.btnAddMarca.Name = "btnAddMarca"
        Me.btnAddMarca.Size = New System.Drawing.Size(22, 23)
        Me.btnAddMarca.TabIndex = 106
        Me.btnAddMarca.Text = "+"
        Me.btnAddMarca.UseVisualStyleBackColor = True
        '
        'cbSeccion
        '
        Me.cbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSeccion.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSeccion.FormattingEnabled = True
        Me.cbSeccion.Location = New System.Drawing.Point(173, 478)
        Me.cbSeccion.Name = "cbSeccion"
        Me.cbSeccion.Size = New System.Drawing.Size(251, 36)
        Me.cbSeccion.TabIndex = 105
        '
        'cbDepartamento
        '
        Me.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartamento.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(173, 436)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(251, 36)
        Me.cbDepartamento.TabIndex = 104
        '
        'cbMarca
        '
        Me.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMarca.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.Location = New System.Drawing.Point(173, 394)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(251, 36)
        Me.cbMarca.TabIndex = 103
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 481)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 28)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "SECCION:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 439)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 28)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "DEPARTAMENTO:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 397)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 28)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "MARCA:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(173, 352)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(251, 36)
        Me.txtModelo.TabIndex = 99
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.Location = New System.Drawing.Point(0, 355)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(81, 28)
        Me.lblModelo.TabIndex = 98
        Me.lblModelo.Text = "MODELO:"
        Me.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodBarras1
        '
        Me.txtCodBarras1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBarras1.Location = New System.Drawing.Point(173, 310)
        Me.txtCodBarras1.Name = "txtCodBarras1"
        Me.txtCodBarras1.Size = New System.Drawing.Size(251, 36)
        Me.txtCodBarras1.TabIndex = 97
        '
        'lblcodBarras1
        '
        Me.lblcodBarras1.AutoSize = True
        Me.lblcodBarras1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodBarras1.Location = New System.Drawing.Point(0, 313)
        Me.lblcodBarras1.Name = "lblcodBarras1"
        Me.lblcodBarras1.Size = New System.Drawing.Size(166, 28)
        Me.lblcodBarras1.TabIndex = 96
        Me.lblcodBarras1.Text = "CODIGO DE BARRAS:"
        Me.lblcodBarras1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodBarras
        '
        Me.txtCodBarras.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBarras.Location = New System.Drawing.Point(173, 268)
        Me.txtCodBarras.Name = "txtCodBarras"
        Me.txtCodBarras.Size = New System.Drawing.Size(251, 36)
        Me.txtCodBarras.TabIndex = 95
        '
        'lblCodBarras
        '
        Me.lblCodBarras.AutoSize = True
        Me.lblCodBarras.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodBarras.Location = New System.Drawing.Point(0, 271)
        Me.lblCodBarras.Name = "lblCodBarras"
        Me.lblCodBarras.Size = New System.Drawing.Size(166, 28)
        Me.lblCodBarras.TabIndex = 94
        Me.lblCodBarras.Text = "CODIGO DE BARRAS:"
        Me.lblCodBarras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReferencia
        '
        Me.txtReferencia.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia.Location = New System.Drawing.Point(173, 226)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(251, 36)
        Me.txtReferencia.TabIndex = 93
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReferencia.Location = New System.Drawing.Point(0, 229)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(103, 28)
        Me.lblReferencia.TabIndex = 92
        Me.lblReferencia.Text = "REFERENCIA:"
        Me.lblReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(173, 184)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(251, 36)
        Me.txtDescripcion.TabIndex = 91
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(0, 187)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(117, 28)
        Me.lblDescripcion.TabIndex = 90
        Me.lblDescripcion.Text = "DESCRIPCION:"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(173, 143)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(251, 36)
        Me.txtNombre.TabIndex = 89
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(0, 146)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(80, 28)
        Me.lblNombre.TabIndex = 88
        Me.lblNombre.Text = "NOMBRE:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(913, 37)
        Me.Panel1.TabIndex = 120
        '
        'lblTime
        '
        Me.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTime.Font = New System.Drawing.Font("Poppins", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(266, 0)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(404, 36)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "ACTUALIZAR UN ARTICULO"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Manager.My.Resources.Resources.icons8_cerrar_ventana_32
        Me.btnCerrar.Location = New System.Drawing.Point(878, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(30, 30)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = Global.Manager.My.Resources.Resources.icons8_reemplazar_32
        Me.btnSave.Location = New System.Drawing.Point(876, 726)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(30, 30)
        Me.btnSave.TabIndex = 119
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'chkDescatalogado
        '
        Me.chkDescatalogado.AutoSize = True
        Me.chkDescatalogado.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.chkDescatalogado.Location = New System.Drawing.Point(306, 517)
        Me.chkDescatalogado.Name = "chkDescatalogado"
        Me.chkDescatalogado.Size = New System.Drawing.Size(81, 32)
        Me.chkDescatalogado.TabIndex = 121
        Me.chkDescatalogado.Text = "Activo"
        Me.chkDescatalogado.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = Global.Manager.My.Resources.Resources.icons8_búsqueda_32
        Me.btnSearch.Location = New System.Drawing.Point(430, 102)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(30, 30)
        Me.btnSearch.TabIndex = 122
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(173, 101)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(251, 36)
        Me.txtCodigo.TabIndex = 124
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 28)
        Me.Label8.TabIndex = 123
        Me.Label8.Text = "CODIGO:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmUpArticulo_Material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(913, 768)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.chkDescatalogado)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cbTiposIva)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbMoneda)
        Me.Controls.Add(Me.lblMoneda)
        Me.Controls.Add(Me.txtGanancia)
        Me.Controls.Add(Me.lblGanancia)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.chkRecalcula)
        Me.Controls.Add(Me.btnAddSeccion)
        Me.Controls.Add(Me.btnAddDepto)
        Me.Controls.Add(Me.btnAddMarca)
        Me.Controls.Add(Me.cbSeccion)
        Me.Controls.Add(Me.cbDepartamento)
        Me.Controls.Add(Me.cbMarca)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.txtCodBarras1)
        Me.Controls.Add(Me.lblcodBarras1)
        Me.Controls.Add(Me.txtCodBarras)
        Me.Controls.Add(Me.lblCodBarras)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.lblReferencia)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpArticulo_Material"
        Me.Text = "frmUpArticulo_Material"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtImporteFinal As TextBox
    Friend WithEvents cbTiposIvaCalculo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCostoCalculo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbTiposIva As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbMoneda As ComboBox
    Friend WithEvents lblMoneda As Label
    Friend WithEvents txtGanancia As TextBox
    Friend WithEvents lblGanancia As Label
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents chkRecalcula As CheckBox
    Friend WithEvents btnAddSeccion As Button
    Friend WithEvents btnAddDepto As Button
    Friend WithEvents btnAddMarca As Button
    Friend WithEvents cbSeccion As ComboBox
    Friend WithEvents cbDepartamento As ComboBox
    Friend WithEvents cbMarca As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents lblModelo As Label
    Friend WithEvents txtCodBarras1 As TextBox
    Friend WithEvents lblcodBarras1 As Label
    Friend WithEvents txtCodBarras As TextBox
    Friend WithEvents lblCodBarras As Label
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents lblReferencia As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents chkDescatalogado As CheckBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label8 As Label
End Class
