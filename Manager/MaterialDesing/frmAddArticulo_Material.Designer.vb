<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddArticulo_Material
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
        Me.lblTime = New System.Windows.Forms.Label()
        Me.chkRecalcula = New System.Windows.Forms.CheckBox()
        Me.btnAddSeccion = New System.Windows.Forms.Button()
        Me.btnAddDepto = New System.Windows.Forms.Button()
        Me.btnAddMarca = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblcodBarras1 = New System.Windows.Forms.Label()
        Me.lblCodBarras = New System.Windows.Forms.Label()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.lblGanancia = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtImporteFinal = New System.Windows.Forms.TextBox()
        Me.cbTiposIvaCalculo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCostoCalculo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtNombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtDescripcion = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtReferencia = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtCodBarras = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtCodBarras1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtModelo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtCosto = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtGanancia = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.cbMarca = New System.Windows.Forms.ComboBox()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cbSeccion = New System.Windows.Forms.ComboBox()
        Me.cbMoneda = New System.Windows.Forms.ComboBox()
        Me.cbTiposIva = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 28)
        Me.Panel1.TabIndex = 0
        '
        'lblTime
        '
        Me.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTime.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(214, 0)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(431, 28)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "REGISTRAR UN ARTICULO"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkRecalcula
        '
        Me.chkRecalcula.Checked = True
        Me.chkRecalcula.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRecalcula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkRecalcula.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRecalcula.Location = New System.Drawing.Point(162, 418)
        Me.chkRecalcula.Name = "chkRecalcula"
        Me.chkRecalcula.Size = New System.Drawing.Size(12, 18)
        Me.chkRecalcula.TabIndex = 77
        Me.chkRecalcula.UseVisualStyleBackColor = True
        '
        'btnAddSeccion
        '
        Me.btnAddSeccion.FlatAppearance.BorderSize = 0
        Me.btnAddSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSeccion.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSeccion.Location = New System.Drawing.Point(387, 363)
        Me.btnAddSeccion.Name = "btnAddSeccion"
        Me.btnAddSeccion.Size = New System.Drawing.Size(22, 23)
        Me.btnAddSeccion.TabIndex = 76
        Me.btnAddSeccion.Text = "+"
        Me.btnAddSeccion.UseVisualStyleBackColor = True
        '
        'btnAddDepto
        '
        Me.btnAddDepto.FlatAppearance.BorderSize = 0
        Me.btnAddDepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDepto.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddDepto.Location = New System.Drawing.Point(387, 321)
        Me.btnAddDepto.Name = "btnAddDepto"
        Me.btnAddDepto.Size = New System.Drawing.Size(22, 23)
        Me.btnAddDepto.TabIndex = 75
        Me.btnAddDepto.Text = "+"
        Me.btnAddDepto.UseVisualStyleBackColor = True
        '
        'btnAddMarca
        '
        Me.btnAddMarca.FlatAppearance.BorderSize = 0
        Me.btnAddMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddMarca.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMarca.Location = New System.Drawing.Point(387, 279)
        Me.btnAddMarca.Name = "btnAddMarca"
        Me.btnAddMarca.Size = New System.Drawing.Size(22, 23)
        Me.btnAddMarca.TabIndex = 74
        Me.btnAddMarca.Text = "+"
        Me.btnAddMarca.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "SECCION:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "DEPARTAMENTO:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "MARCA:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModelo
        '
        Me.lblModelo.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.Location = New System.Drawing.Point(43, 227)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(112, 20)
        Me.lblModelo.TabIndex = 66
        Me.lblModelo.Text = "MODELO:"
        Me.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcodBarras1
        '
        Me.lblcodBarras1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodBarras1.Location = New System.Drawing.Point(42, 190)
        Me.lblcodBarras1.Name = "lblcodBarras1"
        Me.lblcodBarras1.Size = New System.Drawing.Size(113, 20)
        Me.lblcodBarras1.TabIndex = 64
        Me.lblcodBarras1.Text = "COD. DE BARRAS:"
        Me.lblcodBarras1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCodBarras
        '
        Me.lblCodBarras.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodBarras.Location = New System.Drawing.Point(39, 153)
        Me.lblCodBarras.Name = "lblCodBarras"
        Me.lblCodBarras.Size = New System.Drawing.Size(116, 20)
        Me.lblCodBarras.TabIndex = 62
        Me.lblCodBarras.Text = "COD. DE BARRAS:"
        Me.lblCodBarras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReferencia
        '
        Me.lblReferencia.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReferencia.Location = New System.Drawing.Point(12, 116)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(143, 20)
        Me.lblReferencia.TabIndex = 60
        Me.lblReferencia.Text = "REFERENCIA:"
        Me.lblReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(32, 77)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(123, 20)
        Me.lblDescripcion.TabIndex = 58
        Me.lblDescripcion.Text = "DESCRIPCION:"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(32, 40)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(123, 20)
        Me.lblNombre.TabIndex = 56
        Me.lblNombre.Text = "NOMBRE:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(413, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "IVA:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMoneda
        '
        Me.lblMoneda.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoneda.Location = New System.Drawing.Point(416, 130)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(135, 21)
        Me.lblMoneda.TabIndex = 82
        Me.lblMoneda.Text = "MONEDA:"
        Me.lblMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGanancia
        '
        Me.lblGanancia.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGanancia.Location = New System.Drawing.Point(413, 88)
        Me.lblGanancia.Name = "lblGanancia"
        Me.lblGanancia.Size = New System.Drawing.Size(138, 20)
        Me.lblGanancia.TabIndex = 80
        Me.lblGanancia.Text = "GANANCIA:"
        Me.lblGanancia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrecio
        '
        Me.lblPrecio.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(422, 47)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(129, 20)
        Me.lblPrecio.TabIndex = 78
        Me.lblPrecio.Text = "COSTO:"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.GroupBox3.Location = New System.Drawing.Point(487, 213)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(291, 187)
        Me.GroupBox3.TabIndex = 86
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
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = Global.Manager.My.Resources.Resources.icons8_guardar_cerrar_32
        Me.btnSave.Location = New System.Drawing.Point(774, 685)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(30, 30)
        Me.btnSave.TabIndex = 87
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombre.HintForeColor = System.Drawing.Color.Empty
        Me.txtNombre.HintText = ""
        Me.txtNombre.isPassword = False
        Me.txtNombre.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtNombre.LineIdleColor = System.Drawing.Color.DarkRed
        Me.txtNombre.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtNombre.LineThickness = 3
        Me.txtNombre.Location = New System.Drawing.Point(162, 40)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(220, 29)
        Me.txtNombre.TabIndex = 88
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescripcion.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDescripcion.HintForeColor = System.Drawing.Color.Empty
        Me.txtDescripcion.HintText = ""
        Me.txtDescripcion.isPassword = False
        Me.txtDescripcion.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtDescripcion.LineIdleColor = System.Drawing.Color.DarkRed
        Me.txtDescripcion.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtDescripcion.LineThickness = 3
        Me.txtDescripcion.Location = New System.Drawing.Point(162, 77)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(220, 29)
        Me.txtDescripcion.TabIndex = 89
        Me.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtReferencia
        '
        Me.txtReferencia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReferencia.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtReferencia.HintForeColor = System.Drawing.Color.Empty
        Me.txtReferencia.HintText = ""
        Me.txtReferencia.isPassword = False
        Me.txtReferencia.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtReferencia.LineIdleColor = System.Drawing.Color.DarkRed
        Me.txtReferencia.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtReferencia.LineThickness = 3
        Me.txtReferencia.Location = New System.Drawing.Point(162, 116)
        Me.txtReferencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(220, 29)
        Me.txtReferencia.TabIndex = 90
        Me.txtReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtCodBarras
        '
        Me.txtCodBarras.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodBarras.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBarras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCodBarras.HintForeColor = System.Drawing.Color.Empty
        Me.txtCodBarras.HintText = ""
        Me.txtCodBarras.isPassword = False
        Me.txtCodBarras.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtCodBarras.LineIdleColor = System.Drawing.Color.DarkRed
        Me.txtCodBarras.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtCodBarras.LineThickness = 3
        Me.txtCodBarras.Location = New System.Drawing.Point(162, 153)
        Me.txtCodBarras.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodBarras.Name = "txtCodBarras"
        Me.txtCodBarras.Size = New System.Drawing.Size(220, 29)
        Me.txtCodBarras.TabIndex = 91
        Me.txtCodBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtCodBarras1
        '
        Me.txtCodBarras1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodBarras1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBarras1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCodBarras1.HintForeColor = System.Drawing.Color.Empty
        Me.txtCodBarras1.HintText = ""
        Me.txtCodBarras1.isPassword = False
        Me.txtCodBarras1.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtCodBarras1.LineIdleColor = System.Drawing.Color.DarkRed
        Me.txtCodBarras1.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtCodBarras1.LineThickness = 3
        Me.txtCodBarras1.Location = New System.Drawing.Point(162, 190)
        Me.txtCodBarras1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodBarras1.Name = "txtCodBarras1"
        Me.txtCodBarras1.Size = New System.Drawing.Size(220, 29)
        Me.txtCodBarras1.TabIndex = 92
        Me.txtCodBarras1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtModelo
        '
        Me.txtModelo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtModelo.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtModelo.HintForeColor = System.Drawing.Color.Empty
        Me.txtModelo.HintText = ""
        Me.txtModelo.isPassword = False
        Me.txtModelo.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtModelo.LineIdleColor = System.Drawing.Color.DarkRed
        Me.txtModelo.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtModelo.LineThickness = 3
        Me.txtModelo.Location = New System.Drawing.Point(162, 227)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(220, 29)
        Me.txtModelo.TabIndex = 93
        Me.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtCosto
        '
        Me.txtCosto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCosto.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCosto.HintForeColor = System.Drawing.Color.Empty
        Me.txtCosto.HintText = ""
        Me.txtCosto.isPassword = False
        Me.txtCosto.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtCosto.LineIdleColor = System.Drawing.Color.DarkRed
        Me.txtCosto.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtCosto.LineThickness = 3
        Me.txtCosto.Location = New System.Drawing.Point(558, 40)
        Me.txtCosto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(220, 29)
        Me.txtCosto.TabIndex = 97
        Me.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtGanancia
        '
        Me.txtGanancia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGanancia.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGanancia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtGanancia.HintForeColor = System.Drawing.Color.Empty
        Me.txtGanancia.HintText = ""
        Me.txtGanancia.isPassword = False
        Me.txtGanancia.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtGanancia.LineIdleColor = System.Drawing.Color.DarkRed
        Me.txtGanancia.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtGanancia.LineThickness = 3
        Me.txtGanancia.Location = New System.Drawing.Point(557, 77)
        Me.txtGanancia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGanancia.Name = "txtGanancia"
        Me.txtGanancia.Size = New System.Drawing.Size(220, 29)
        Me.txtGanancia.TabIndex = 98
        Me.txtGanancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cbMarca
        '
        Me.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.Location = New System.Drawing.Point(162, 279)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(220, 21)
        Me.cbMarca.TabIndex = 101
        '
        'cbDepartamento
        '
        Me.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(162, 325)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(220, 21)
        Me.cbDepartamento.TabIndex = 102
        '
        'cbSeccion
        '
        Me.cbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSeccion.FormattingEnabled = True
        Me.cbSeccion.Location = New System.Drawing.Point(162, 368)
        Me.cbSeccion.Name = "cbSeccion"
        Me.cbSeccion.Size = New System.Drawing.Size(220, 21)
        Me.cbSeccion.TabIndex = 103
        '
        'cbMoneda
        '
        Me.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMoneda.FormattingEnabled = True
        Me.cbMoneda.Location = New System.Drawing.Point(558, 131)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Size = New System.Drawing.Size(220, 21)
        Me.cbMoneda.TabIndex = 104
        '
        'cbTiposIva
        '
        Me.cbTiposIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTiposIva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTiposIva.FormattingEnabled = True
        Me.cbTiposIva.Location = New System.Drawing.Point(557, 171)
        Me.cbTiposIva.Name = "cbTiposIva"
        Me.cbTiposIva.Size = New System.Drawing.Size(220, 21)
        Me.cbTiposIva.TabIndex = 105
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(62, 416)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 20)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "RECALCULA:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmAddArticulo_Material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(809, 723)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbTiposIva)
        Me.Controls.Add(Me.cbMoneda)
        Me.Controls.Add(Me.cbSeccion)
        Me.Controls.Add(Me.cbDepartamento)
        Me.Controls.Add(Me.cbMarca)
        Me.Controls.Add(Me.txtGanancia)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.txtCodBarras1)
        Me.Controls.Add(Me.txtCodBarras)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMoneda)
        Me.Controls.Add(Me.lblGanancia)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.chkRecalcula)
        Me.Controls.Add(Me.btnAddSeccion)
        Me.Controls.Add(Me.btnAddDepto)
        Me.Controls.Add(Me.btnAddMarca)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.lblcodBarras1)
        Me.Controls.Add(Me.lblCodBarras)
        Me.Controls.Add(Me.lblReferencia)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmAddArticulo_Material"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddArticulo_Material"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents chkRecalcula As CheckBox
    Friend WithEvents btnAddSeccion As Button
    Friend WithEvents btnAddDepto As Button
    Friend WithEvents btnAddMarca As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblModelo As Label
    Friend WithEvents lblcodBarras1 As Label
    Friend WithEvents lblCodBarras As Label
    Friend WithEvents lblReferencia As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMoneda As Label
    Friend WithEvents lblGanancia As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtImporteFinal As TextBox
    Friend WithEvents cbTiposIvaCalculo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCostoCalculo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtNombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtDescripcion As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtReferencia As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtCodBarras As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtCodBarras1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtModelo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtGanancia As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtCosto As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents cbMarca As ComboBox
    Friend WithEvents cbDepartamento As ComboBox
    Friend WithEvents cbSeccion As ComboBox
    Friend WithEvents cbMoneda As ComboBox
    Friend WithEvents cbTiposIva As ComboBox
    Friend WithEvents Label8 As Label
End Class
