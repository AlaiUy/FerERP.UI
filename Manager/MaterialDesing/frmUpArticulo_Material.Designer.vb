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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkDescatalogado = New System.Windows.Forms.CheckBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtImporteFinal = New System.Windows.Forms.TextBox()
        Me.cbTiposIvaCalculo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCostoCalculo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbTiposIva
        '
        Me.cbTiposIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTiposIva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTiposIva.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.cbTiposIva.FormattingEnabled = True
        Me.cbTiposIva.Location = New System.Drawing.Point(430, 167)
        Me.cbTiposIva.Name = "cbTiposIva"
        Me.cbTiposIva.Size = New System.Drawing.Size(217, 23)
        Me.cbTiposIva.TabIndex = 117
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(391, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 20)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "IVA:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbMoneda
        '
        Me.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMoneda.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.cbMoneda.FormattingEnabled = True
        Me.cbMoneda.Location = New System.Drawing.Point(430, 123)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Size = New System.Drawing.Size(217, 23)
        Me.cbMoneda.TabIndex = 115
        '
        'lblMoneda
        '
        Me.lblMoneda.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.lblMoneda.Location = New System.Drawing.Point(351, 125)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(73, 21)
        Me.lblMoneda.TabIndex = 114
        Me.lblMoneda.Text = "MONEDA:"
        Me.lblMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGanancia
        '
        Me.txtGanancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGanancia.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.txtGanancia.Location = New System.Drawing.Point(430, 86)
        Me.txtGanancia.Name = "txtGanancia"
        Me.txtGanancia.Size = New System.Drawing.Size(217, 23)
        Me.txtGanancia.TabIndex = 113
        '
        'lblGanancia
        '
        Me.lblGanancia.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.lblGanancia.Location = New System.Drawing.Point(348, 86)
        Me.lblGanancia.Name = "lblGanancia"
        Me.lblGanancia.Size = New System.Drawing.Size(76, 20)
        Me.lblGanancia.TabIndex = 112
        Me.lblGanancia.Text = "GANANCIA:"
        Me.lblGanancia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCosto
        '
        Me.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCosto.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.txtCosto.Location = New System.Drawing.Point(430, 42)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(217, 23)
        Me.txtCosto.TabIndex = 111
        '
        'lblPrecio
        '
        Me.lblPrecio.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.lblPrecio.Location = New System.Drawing.Point(368, 42)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(56, 20)
        Me.lblPrecio.TabIndex = 110
        Me.lblPrecio.Text = "COSTO:"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkRecalcula
        '
        Me.chkRecalcula.AutoSize = True
        Me.chkRecalcula.Checked = True
        Me.chkRecalcula.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRecalcula.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.chkRecalcula.Location = New System.Drawing.Point(137, 460)
        Me.chkRecalcula.Name = "chkRecalcula"
        Me.chkRecalcula.Size = New System.Drawing.Size(82, 19)
        Me.chkRecalcula.TabIndex = 109
        Me.chkRecalcula.Text = "Recalcula"
        Me.chkRecalcula.UseVisualStyleBackColor = True
        '
        'btnAddSeccion
        '
        Me.btnAddSeccion.FlatAppearance.BorderSize = 0
        Me.btnAddSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSeccion.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.btnAddSeccion.Location = New System.Drawing.Point(303, 420)
        Me.btnAddSeccion.Name = "btnAddSeccion"
        Me.btnAddSeccion.Size = New System.Drawing.Size(22, 23)
        Me.btnAddSeccion.TabIndex = 108
        Me.btnAddSeccion.Text = "+"
        Me.btnAddSeccion.UseVisualStyleBackColor = True
        '
        'btnAddDepto
        '
        Me.btnAddDepto.FlatAppearance.BorderSize = 0
        Me.btnAddDepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDepto.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.btnAddDepto.Location = New System.Drawing.Point(303, 378)
        Me.btnAddDepto.Name = "btnAddDepto"
        Me.btnAddDepto.Size = New System.Drawing.Size(22, 23)
        Me.btnAddDepto.TabIndex = 107
        Me.btnAddDepto.Text = "+"
        Me.btnAddDepto.UseVisualStyleBackColor = True
        '
        'btnAddMarca
        '
        Me.btnAddMarca.FlatAppearance.BorderSize = 0
        Me.btnAddMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddMarca.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.btnAddMarca.Location = New System.Drawing.Point(303, 335)
        Me.btnAddMarca.Name = "btnAddMarca"
        Me.btnAddMarca.Size = New System.Drawing.Size(22, 23)
        Me.btnAddMarca.TabIndex = 106
        Me.btnAddMarca.Text = "+"
        Me.btnAddMarca.UseVisualStyleBackColor = True
        '
        'cbSeccion
        '
        Me.cbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSeccion.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.cbSeccion.FormattingEnabled = True
        Me.cbSeccion.Location = New System.Drawing.Point(137, 421)
        Me.cbSeccion.Name = "cbSeccion"
        Me.cbSeccion.Size = New System.Drawing.Size(160, 23)
        Me.cbSeccion.TabIndex = 105
        '
        'cbDepartamento
        '
        Me.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDepartamento.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(137, 377)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(160, 23)
        Me.cbDepartamento.TabIndex = 104
        '
        'cbMarca
        '
        Me.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMarca.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.Location = New System.Drawing.Point(137, 335)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(160, 23)
        Me.cbMarca.TabIndex = 103
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(61, 421)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "SECCION:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(12, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "DEPARTAMENTO:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(74, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "MARCA:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtModelo
        '
        Me.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtModelo.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.txtModelo.Location = New System.Drawing.Point(137, 293)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(160, 23)
        Me.txtModelo.TabIndex = 99
        '
        'lblModelo
        '
        Me.lblModelo.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.lblModelo.Location = New System.Drawing.Point(65, 292)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(66, 20)
        Me.lblModelo.TabIndex = 98
        Me.lblModelo.Text = "MODELO:"
        Me.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodBarras1
        '
        Me.txtCodBarras1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodBarras1.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.txtCodBarras1.Location = New System.Drawing.Point(137, 251)
        Me.txtCodBarras1.Name = "txtCodBarras1"
        Me.txtCodBarras1.Size = New System.Drawing.Size(160, 23)
        Me.txtCodBarras1.TabIndex = 97
        '
        'lblcodBarras1
        '
        Me.lblcodBarras1.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.lblcodBarras1.Location = New System.Drawing.Point(2, 250)
        Me.lblcodBarras1.Name = "lblcodBarras1"
        Me.lblcodBarras1.Size = New System.Drawing.Size(131, 20)
        Me.lblcodBarras1.TabIndex = 96
        Me.lblcodBarras1.Text = "CODIGO DE BARRAS:"
        Me.lblcodBarras1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodBarras
        '
        Me.txtCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodBarras.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.txtCodBarras.Location = New System.Drawing.Point(137, 209)
        Me.txtCodBarras.Name = "txtCodBarras"
        Me.txtCodBarras.Size = New System.Drawing.Size(160, 23)
        Me.txtCodBarras.TabIndex = 95
        '
        'lblCodBarras
        '
        Me.lblCodBarras.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.lblCodBarras.Location = New System.Drawing.Point(2, 208)
        Me.lblCodBarras.Name = "lblCodBarras"
        Me.lblCodBarras.Size = New System.Drawing.Size(131, 20)
        Me.lblCodBarras.TabIndex = 94
        Me.lblCodBarras.Text = "CODIGO DE BARRAS:"
        Me.lblCodBarras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReferencia
        '
        Me.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReferencia.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.txtReferencia.Location = New System.Drawing.Point(137, 167)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(160, 23)
        Me.txtReferencia.TabIndex = 93
        '
        'lblReferencia
        '
        Me.lblReferencia.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.lblReferencia.Location = New System.Drawing.Point(46, 167)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(85, 20)
        Me.lblReferencia.TabIndex = 92
        Me.lblReferencia.Text = "REFERENCIA:"
        Me.lblReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.txtDescripcion.Location = New System.Drawing.Point(137, 125)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(160, 23)
        Me.txtDescripcion.TabIndex = 91
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.lblDescripcion.Location = New System.Drawing.Point(37, 123)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(94, 20)
        Me.lblDescripcion.TabIndex = 90
        Me.lblDescripcion.Text = "DESCRIPCION:"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.txtNombre.Location = New System.Drawing.Point(137, 86)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(160, 23)
        Me.txtNombre.TabIndex = 89
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.lblNombre.Location = New System.Drawing.Point(68, 86)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(63, 20)
        Me.lblNombre.TabIndex = 88
        Me.lblNombre.Text = "NOMBRE:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 24)
        Me.Panel1.TabIndex = 120
        '
        'lblTime
        '
        Me.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTime.Font = New System.Drawing.Font("Roboto", 14.25!)
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(212, 2)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(432, 22)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "ACTUALIZAR UN ARTICULO"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = Global.Manager.My.Resources.Resources.icons8_reemplazar_32
        Me.btnSave.Location = New System.Drawing.Point(772, 681)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(30, 30)
        Me.btnSave.TabIndex = 119
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'chkDescatalogado
        '
        Me.chkDescatalogado.AutoSize = True
        Me.chkDescatalogado.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.chkDescatalogado.Location = New System.Drawing.Point(236, 460)
        Me.chkDescatalogado.Name = "chkDescatalogado"
        Me.chkDescatalogado.Size = New System.Drawing.Size(61, 19)
        Me.chkDescatalogado.TabIndex = 121
        Me.chkDescatalogado.Text = "Activo"
        Me.chkDescatalogado.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.btnSearch.Image = Global.Manager.My.Resources.Resources.icons8_búsqueda_32
        Me.btnSearch.Location = New System.Drawing.Point(306, 37)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(30, 30)
        Me.btnSearch.TabIndex = 122
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.txtCodigo.Location = New System.Drawing.Point(137, 42)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(160, 23)
        Me.txtCodigo.TabIndex = 124
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(69, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 20)
        Me.Label8.TabIndex = 123
        Me.Label8.Text = "CODIGO:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.GroupBox3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(356, 214)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(291, 187)
        Me.GroupBox3.TabIndex = 125
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Calcular a partir de:"
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCalcular.FlatAppearance.BorderSize = 0
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(188, 144)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(94, 36)
        Me.btnCalcular.TabIndex = 37
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'txtImporteFinal
        '
        Me.txtImporteFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImporteFinal.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.txtImporteFinal.Location = New System.Drawing.Point(122, 111)
        Me.txtImporteFinal.Name = "txtImporteFinal"
        Me.txtImporteFinal.Size = New System.Drawing.Size(160, 23)
        Me.txtImporteFinal.TabIndex = 36
        '
        'cbTiposIvaCalculo
        '
        Me.cbTiposIvaCalculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTiposIvaCalculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTiposIvaCalculo.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.cbTiposIvaCalculo.FormattingEnabled = True
        Me.cbTiposIvaCalculo.Location = New System.Drawing.Point(122, 68)
        Me.cbTiposIvaCalculo.Name = "cbTiposIvaCalculo"
        Me.cbTiposIvaCalculo.Size = New System.Drawing.Size(160, 23)
        Me.cbTiposIvaCalculo.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(63, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "IVA:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCostoCalculo
        '
        Me.txtCostoCalculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostoCalculo.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.txtCostoCalculo.Location = New System.Drawing.Point(122, 27)
        Me.txtCostoCalculo.Name = "txtCostoCalculo"
        Me.txtCostoCalculo.Size = New System.Drawing.Size(160, 23)
        Me.txtCostoCalculo.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(37, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "COSTO:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(8, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 24)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "IMPORTE FINAL:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmUpArticulo_Material
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(809, 723)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.chkDescatalogado)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSave)
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
        Me.KeyPreview = True
        Me.Name = "frmUpArticulo_Material"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUpArticulo_Material"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
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
    Friend WithEvents chkDescatalogado As CheckBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtImporteFinal As TextBox
    Friend WithEvents cbTiposIvaCalculo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCostoCalculo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
