<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateArticulos
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinFindArticulos = New System.Windows.Forms.LinkLabel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbDatos = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtImporteFinal = New System.Windows.Forms.TextBox()
        Me.cbTiposIvaCalculo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCostoCalculo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTiposIva = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbMoneda = New System.Windows.Forms.ComboBox()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.txtGanancia = New System.Windows.Forms.TextBox()
        Me.lblGanancia = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkDescatalogado = New System.Windows.Forms.CheckBox()
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnAsignarStock = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtStocktoAssing = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtStockActual = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbDatos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LinFindArticulos)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtArticulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(849, 47)
        Me.Panel1.TabIndex = 0
        '
        'LinFindArticulos
        '
        Me.LinFindArticulos.ActiveLinkColor = System.Drawing.SystemColors.Highlight
        Me.LinFindArticulos.AutoSize = True
        Me.LinFindArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinFindArticulos.Location = New System.Drawing.Point(11, 11)
        Me.LinFindArticulos.Name = "LinFindArticulos"
        Me.LinFindArticulos.Size = New System.Drawing.Size(113, 33)
        Me.LinFindArticulos.TabIndex = 40
        Me.LinFindArticulos.TabStop = True
        Me.LinFindArticulos.Text = "Articulo"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(746, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Manager.My.Resources.JJRecursos.lens
        Me.Button1.Location = New System.Drawing.Point(395, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 29)
        Me.Button1.TabIndex = 38
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'txtArticulo
        '
        Me.txtArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticulo.Location = New System.Drawing.Point(90, 8)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(299, 40)
        Me.txtArticulo.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(849, 548)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 518)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(849, 30)
        Me.Panel3.TabIndex = 36
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(765, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(84, 30)
        Me.Panel4.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.tbDatos)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(849, 548)
        Me.TabControl1.TabIndex = 1
        '
        'tbDatos
        '
        Me.tbDatos.BackColor = System.Drawing.Color.White
        Me.tbDatos.Controls.Add(Me.GroupBox1)
        Me.tbDatos.Controls.Add(Me.GroupBox2)
        Me.tbDatos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDatos.Location = New System.Drawing.Point(4, 32)
        Me.tbDatos.Name = "tbDatos"
        Me.tbDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDatos.Size = New System.Drawing.Size(841, 512)
        Me.tbDatos.TabIndex = 0
        Me.tbDatos.Text = "DATOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.cbTiposIva)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbMoneda)
        Me.GroupBox1.Controls.Add(Me.lblMoneda)
        Me.GroupBox1.Controls.Add(Me.txtGanancia)
        Me.GroupBox1.Controls.Add(Me.lblGanancia)
        Me.GroupBox1.Controls.Add(Me.txtCosto)
        Me.GroupBox1.Controls.Add(Me.lblPrecio)
        Me.GroupBox1.Location = New System.Drawing.Point(409, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 472)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo precio de venta"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCalcular)
        Me.GroupBox3.Controls.Add(Me.txtImporteFinal)
        Me.GroupBox3.Controls.Add(Me.cbTiposIvaCalculo)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtCostoCalculo)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 195)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(395, 179)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Calcular a partir de:"
        '
        'btnCalcular
        '
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Location = New System.Drawing.Point(124, 138)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 37
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtImporteFinal
        '
        Me.txtImporteFinal.Location = New System.Drawing.Point(124, 101)
        Me.txtImporteFinal.Name = "txtImporteFinal"
        Me.txtImporteFinal.Size = New System.Drawing.Size(208, 31)
        Me.txtImporteFinal.TabIndex = 36
        '
        'cbTiposIvaCalculo
        '
        Me.cbTiposIvaCalculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTiposIvaCalculo.FormattingEnabled = True
        Me.cbTiposIvaCalculo.Location = New System.Drawing.Point(124, 65)
        Me.cbTiposIvaCalculo.Name = "cbTiposIvaCalculo"
        Me.cbTiposIvaCalculo.Size = New System.Drawing.Size(208, 32)
        Me.cbTiposIvaCalculo.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(41, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 20)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "IVA:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCostoCalculo
        '
        Me.txtCostoCalculo.Location = New System.Drawing.Point(124, 33)
        Me.txtCostoCalculo.Name = "txtCostoCalculo"
        Me.txtCostoCalculo.Size = New System.Drawing.Size(208, 31)
        Me.txtCostoCalculo.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(15, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "COSTO:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 24)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "IMPORTE FINAL:"
        '
        'cbTiposIva
        '
        Me.cbTiposIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTiposIva.FormattingEnabled = True
        Me.cbTiposIva.Location = New System.Drawing.Point(89, 136)
        Me.cbTiposIva.Name = "cbTiposIva"
        Me.cbTiposIva.Size = New System.Drawing.Size(208, 32)
        Me.cbTiposIva.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "IVA:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbMoneda
        '
        Me.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMoneda.FormattingEnabled = True
        Me.cbMoneda.Location = New System.Drawing.Point(89, 98)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Size = New System.Drawing.Size(208, 32)
        Me.cbMoneda.TabIndex = 25
        '
        'lblMoneda
        '
        Me.lblMoneda.Location = New System.Drawing.Point(9, 99)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(74, 21)
        Me.lblMoneda.TabIndex = 24
        Me.lblMoneda.Text = "MONEDA:"
        Me.lblMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGanancia
        '
        Me.txtGanancia.Location = New System.Drawing.Point(89, 62)
        Me.txtGanancia.Name = "txtGanancia"
        Me.txtGanancia.Size = New System.Drawing.Size(208, 31)
        Me.txtGanancia.TabIndex = 23
        '
        'lblGanancia
        '
        Me.lblGanancia.Location = New System.Drawing.Point(6, 61)
        Me.lblGanancia.Name = "lblGanancia"
        Me.lblGanancia.Size = New System.Drawing.Size(77, 20)
        Me.lblGanancia.TabIndex = 22
        Me.lblGanancia.Text = "GANANCIA:"
        Me.lblGanancia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(89, 31)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(208, 31)
        Me.txtCosto.TabIndex = 21
        '
        'lblPrecio
        '
        Me.lblPrecio.Location = New System.Drawing.Point(15, 30)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(68, 20)
        Me.lblPrecio.TabIndex = 20
        Me.lblPrecio.Text = "COSTO:"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkDescatalogado)
        Me.GroupBox2.Controls.Add(Me.chkRecalcula)
        Me.GroupBox2.Controls.Add(Me.btnAddSeccion)
        Me.GroupBox2.Controls.Add(Me.btnAddDepto)
        Me.GroupBox2.Controls.Add(Me.btnAddMarca)
        Me.GroupBox2.Controls.Add(Me.cbSeccion)
        Me.GroupBox2.Controls.Add(Me.cbDepartamento)
        Me.GroupBox2.Controls.Add(Me.cbMarca)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtModelo)
        Me.GroupBox2.Controls.Add(Me.lblModelo)
        Me.GroupBox2.Controls.Add(Me.txtCodBarras1)
        Me.GroupBox2.Controls.Add(Me.lblcodBarras1)
        Me.GroupBox2.Controls.Add(Me.txtCodBarras)
        Me.GroupBox2.Controls.Add(Me.lblCodBarras)
        Me.GroupBox2.Controls.Add(Me.txtReferencia)
        Me.GroupBox2.Controls.Add(Me.lblReferencia)
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.lblDescripcion)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.lblNombre)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 481)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        '
        'chkDescatalogado
        '
        Me.chkDescatalogado.AutoSize = True
        Me.chkDescatalogado.Location = New System.Drawing.Point(143, 394)
        Me.chkDescatalogado.Name = "chkDescatalogado"
        Me.chkDescatalogado.Size = New System.Drawing.Size(90, 28)
        Me.chkDescatalogado.TabIndex = 57
        Me.chkDescatalogado.Text = "Activo"
        Me.chkDescatalogado.UseVisualStyleBackColor = True
        '
        'chkRecalcula
        '
        Me.chkRecalcula.AutoSize = True
        Me.chkRecalcula.Location = New System.Drawing.Point(143, 356)
        Me.chkRecalcula.Name = "chkRecalcula"
        Me.chkRecalcula.Size = New System.Drawing.Size(120, 28)
        Me.chkRecalcula.TabIndex = 56
        Me.chkRecalcula.Text = "Recalcula"
        Me.chkRecalcula.UseVisualStyleBackColor = True
        '
        'btnAddSeccion
        '
        Me.btnAddSeccion.Location = New System.Drawing.Point(357, 313)
        Me.btnAddSeccion.Name = "btnAddSeccion"
        Me.btnAddSeccion.Size = New System.Drawing.Size(22, 23)
        Me.btnAddSeccion.TabIndex = 54
        Me.btnAddSeccion.Text = "+"
        Me.btnAddSeccion.UseVisualStyleBackColor = True
        '
        'btnAddDepto
        '
        Me.btnAddDepto.Location = New System.Drawing.Point(357, 275)
        Me.btnAddDepto.Name = "btnAddDepto"
        Me.btnAddDepto.Size = New System.Drawing.Size(22, 23)
        Me.btnAddDepto.TabIndex = 53
        Me.btnAddDepto.Text = "+"
        Me.btnAddDepto.UseVisualStyleBackColor = True
        '
        'btnAddMarca
        '
        Me.btnAddMarca.Location = New System.Drawing.Point(357, 240)
        Me.btnAddMarca.Name = "btnAddMarca"
        Me.btnAddMarca.Size = New System.Drawing.Size(22, 23)
        Me.btnAddMarca.TabIndex = 52
        Me.btnAddMarca.Text = "+"
        Me.btnAddMarca.UseVisualStyleBackColor = True
        '
        'cbSeccion
        '
        Me.cbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSeccion.FormattingEnabled = True
        Me.cbSeccion.Location = New System.Drawing.Point(143, 313)
        Me.cbSeccion.Name = "cbSeccion"
        Me.cbSeccion.Size = New System.Drawing.Size(208, 32)
        Me.cbSeccion.TabIndex = 51
        '
        'cbDepartamento
        '
        Me.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(143, 275)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(208, 32)
        Me.cbDepartamento.TabIndex = 50
        '
        'cbMarca
        '
        Me.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.Location = New System.Drawing.Point(143, 239)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(208, 32)
        Me.cbMarca.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 24)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "SECCION:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 24)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "DEPARTAMENTO:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "MARCA:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(143, 201)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(208, 31)
        Me.txtModelo.TabIndex = 45
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(75, 204)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(95, 24)
        Me.lblModelo.TabIndex = 44
        Me.lblModelo.Text = "MODELO:"
        Me.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodBarras1
        '
        Me.txtCodBarras1.Location = New System.Drawing.Point(143, 166)
        Me.txtCodBarras1.Name = "txtCodBarras1"
        Me.txtCodBarras1.Size = New System.Drawing.Size(208, 31)
        Me.txtCodBarras1.TabIndex = 43
        '
        'lblcodBarras1
        '
        Me.lblcodBarras1.AutoSize = True
        Me.lblcodBarras1.Location = New System.Drawing.Point(8, 167)
        Me.lblcodBarras1.Name = "lblcodBarras1"
        Me.lblcodBarras1.Size = New System.Drawing.Size(199, 24)
        Me.lblcodBarras1.TabIndex = 42
        Me.lblcodBarras1.Text = "CODIGO DE BARRAS:"
        Me.lblcodBarras1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodBarras
        '
        Me.txtCodBarras.Location = New System.Drawing.Point(143, 131)
        Me.txtCodBarras.Name = "txtCodBarras"
        Me.txtCodBarras.Size = New System.Drawing.Size(208, 31)
        Me.txtCodBarras.TabIndex = 41
        '
        'lblCodBarras
        '
        Me.lblCodBarras.AutoSize = True
        Me.lblCodBarras.Location = New System.Drawing.Point(8, 132)
        Me.lblCodBarras.Name = "lblCodBarras"
        Me.lblCodBarras.Size = New System.Drawing.Size(199, 24)
        Me.lblCodBarras.TabIndex = 40
        Me.lblCodBarras.Text = "CODIGO DE BARRAS:"
        Me.lblCodBarras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(143, 99)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(208, 31)
        Me.txtReferencia.TabIndex = 39
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Location = New System.Drawing.Point(52, 102)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(128, 24)
        Me.lblReferencia.TabIndex = 38
        Me.lblReferencia.Text = "REFERENCIA:"
        Me.lblReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(143, 68)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(208, 31)
        Me.txtDescripcion.TabIndex = 37
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(45, 71)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(141, 24)
        Me.lblDescripcion.TabIndex = 36
        Me.lblDescripcion.Text = "DESCRIPCION:"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(143, 34)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(208, 31)
        Me.txtNombre.TabIndex = 35
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(75, 37)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(94, 24)
        Me.lblNombre.TabIndex = 34
        Me.lblNombre.Text = "NOMBRE:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(841, 512)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "STOCKS"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnAsignarStock)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtStocktoAssing)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtStockActual)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(247, 258)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Informacion"
        '
        'btnAsignarStock
        '
        Me.btnAsignarStock.Location = New System.Drawing.Point(9, 221)
        Me.btnAsignarStock.Name = "btnAsignarStock"
        Me.btnAsignarStock.Size = New System.Drawing.Size(231, 23)
        Me.btnAsignarStock.TabIndex = 5
        Me.btnAsignarStock.Text = "Asignar"
        Me.btnAsignarStock.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(235, 88)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "La cantidad se asigna por el total de unidades que abra disponibles. (No se suman" &
    " a la cantidad que ya existe)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStocktoAssing
        '
        Me.txtStocktoAssing.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStocktoAssing.Location = New System.Drawing.Point(93, 80)
        Me.txtStocktoAssing.Name = "txtStocktoAssing"
        Me.txtStocktoAssing.Size = New System.Drawing.Size(148, 31)
        Me.txtStocktoAssing.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 24)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Asignar:"
        '
        'txtStockActual
        '
        Me.txtStockActual.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockActual.Location = New System.Drawing.Point(93, 37)
        Me.txtStockActual.Name = "txtStockActual"
        Me.txtStockActual.ReadOnly = True
        Me.txtStockActual.Size = New System.Drawing.Size(148, 31)
        Me.txtStockActual.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Stock Actual:"
        '
        'frmUpdateArticulos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(849, 595)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmUpdateArticulos"
        Me.Text = "frmUpdateArticulos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tbDatos.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents txtArticulo As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbDatos As TabPage
    Friend WithEvents GroupBox2 As GroupBox
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
    Friend WithEvents chkRecalcula As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtImporteFinal As TextBox
    Friend WithEvents cbTiposIvaCalculo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCostoCalculo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbTiposIva As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbMoneda As ComboBox
    Friend WithEvents lblMoneda As Label
    Friend WithEvents txtGanancia As TextBox
    Friend WithEvents lblGanancia As Label
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents chkDescatalogado As CheckBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnAsignarStock As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtStocktoAssing As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtStockActual As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents LinFindArticulos As LinkLabel
End Class
