<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMaterial
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
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.PanelVentas = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblVentas = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblCompras = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblInformes = New System.Windows.Forms.Label()
        Me.PanelArticulos = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblArticulos = New System.Windows.Forms.Label()
        Me.LeftTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.btnOff = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnNewVenta = New FontAwesome.Sharp.IconButton()
        Me.btnEntregar = New FontAwesome.Sharp.IconButton()
        Me.btnPresupuestoa = New FontAwesome.Sharp.IconButton()
        Me.btnNuevaCompra = New FontAwesome.Sharp.IconButton()
        Me.btnEstadoCuenta = New FontAwesome.Sharp.IconButton()
        Me.btnPago = New FontAwesome.Sharp.IconButton()
        Me.btnInfoArticulos = New FontAwesome.Sharp.IconButton()
        Me.btnInfoVentas = New FontAwesome.Sharp.IconButton()
        Me.btnNewArticulo = New FontAwesome.Sharp.IconButton()
        Me.btnUpArticulo = New FontAwesome.Sharp.IconButton()
        Me.btnPrintPrices = New FontAwesome.Sharp.IconButton()
        Me.PanelLeft.SuspendLayout()
        Me.PanelVentas.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PanelArticulos.SuspendLayout()
        Me.LeftTop.SuspendLayout()
        CType(Me.btnOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLeft
        '
        Me.PanelLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelLeft.Controls.Add(Me.PanelVentas)
        Me.PanelLeft.Controls.Add(Me.lblVentas)
        Me.PanelLeft.Controls.Add(Me.FlowLayoutPanel2)
        Me.PanelLeft.Controls.Add(Me.lblCompras)
        Me.PanelLeft.Controls.Add(Me.FlowLayoutPanel1)
        Me.PanelLeft.Controls.Add(Me.lblInformes)
        Me.PanelLeft.Controls.Add(Me.PanelArticulos)
        Me.PanelLeft.Controls.Add(Me.lblArticulos)
        Me.PanelLeft.Controls.Add(Me.LeftTop)
        Me.PanelLeft.Location = New System.Drawing.Point(3, 7)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(200, 754)
        Me.PanelLeft.TabIndex = 0
        '
        'PanelVentas
        '
        Me.PanelVentas.Controls.Add(Me.btnNewVenta)
        Me.PanelVentas.Controls.Add(Me.btnEntregar)
        Me.PanelVentas.Controls.Add(Me.btnPresupuestoa)
        Me.PanelVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelVentas.Location = New System.Drawing.Point(0, 486)
        Me.PanelVentas.Name = "PanelVentas"
        Me.PanelVentas.Size = New System.Drawing.Size(200, 123)
        Me.PanelVentas.TabIndex = 12
        '
        'lblVentas
        '
        Me.lblVentas.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblVentas.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentas.ForeColor = System.Drawing.Color.White
        Me.lblVentas.Location = New System.Drawing.Point(0, 456)
        Me.lblVentas.Name = "lblVentas"
        Me.lblVentas.Size = New System.Drawing.Size(200, 30)
        Me.lblVentas.TabIndex = 11
        Me.lblVentas.Text = "Ventas"
        Me.lblVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnNuevaCompra)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnEstadoCuenta)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnPago)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 333)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(200, 123)
        Me.FlowLayoutPanel2.TabIndex = 10
        '
        'lblCompras
        '
        Me.lblCompras.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCompras.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompras.ForeColor = System.Drawing.Color.White
        Me.lblCompras.Location = New System.Drawing.Point(0, 303)
        Me.lblCompras.Name = "lblCompras"
        Me.lblCompras.Size = New System.Drawing.Size(200, 30)
        Me.lblCompras.TabIndex = 10
        Me.lblCompras.Text = "Compras"
        Me.lblCompras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnInfoArticulos)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnInfoVentas)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 221)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 82)
        Me.FlowLayoutPanel1.TabIndex = 9
        '
        'lblInformes
        '
        Me.lblInformes.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblInformes.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblInformes.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformes.ForeColor = System.Drawing.Color.White
        Me.lblInformes.Location = New System.Drawing.Point(0, 191)
        Me.lblInformes.Name = "lblInformes"
        Me.lblInformes.Size = New System.Drawing.Size(200, 30)
        Me.lblInformes.TabIndex = 8
        Me.lblInformes.Text = "Informes"
        Me.lblInformes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelArticulos
        '
        Me.PanelArticulos.Controls.Add(Me.btnNewArticulo)
        Me.PanelArticulos.Controls.Add(Me.btnUpArticulo)
        Me.PanelArticulos.Controls.Add(Me.btnPrintPrices)
        Me.PanelArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelArticulos.Location = New System.Drawing.Point(0, 68)
        Me.PanelArticulos.Name = "PanelArticulos"
        Me.PanelArticulos.Size = New System.Drawing.Size(200, 123)
        Me.PanelArticulos.TabIndex = 3
        '
        'lblArticulos
        '
        Me.lblArticulos.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblArticulos.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticulos.ForeColor = System.Drawing.Color.White
        Me.lblArticulos.Location = New System.Drawing.Point(0, 38)
        Me.lblArticulos.Name = "lblArticulos"
        Me.lblArticulos.Size = New System.Drawing.Size(200, 30)
        Me.lblArticulos.TabIndex = 1
        Me.lblArticulos.Text = "Articulos"
        Me.lblArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LeftTop
        '
        Me.LeftTop.Controls.Add(Me.Label1)
        Me.LeftTop.Controls.Add(Me.BunifuSeparator1)
        Me.LeftTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.LeftTop.Location = New System.Drawing.Point(0, 0)
        Me.LeftTop.Name = "LeftTop"
        Me.LeftTop.Size = New System.Drawing.Size(200, 38)
        Me.LeftTop.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(8, 25)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(185, 11)
        Me.BunifuSeparator1.TabIndex = 8
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PanelContainer
        '
        Me.PanelContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelContainer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelContainer.Location = New System.Drawing.Point(209, 38)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(809, 723)
        Me.PanelContainer.TabIndex = 2
        '
        'lblFecha
        '
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.lblFecha.Location = New System.Drawing.Point(211, 11)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(351, 23)
        Me.lblFecha.TabIndex = 10
        Me.lblFecha.Text = "Label2"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnOff
        '
        Me.btnOff.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOff.BackColor = System.Drawing.Color.Transparent
        Me.btnOff.Image = Global.Manager.My.Resources.Resources.icons8_shutdown_32
        Me.btnOff.ImageActive = Nothing
        Me.btnOff.Location = New System.Drawing.Point(985, 2)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(33, 33)
        Me.btnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnOff.TabIndex = 1
        Me.btnOff.TabStop = False
        Me.btnOff.Zoom = 10
        '
        'btnNewVenta
        '
        Me.btnNewVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNewVenta.FlatAppearance.BorderSize = 0
        Me.btnNewVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnNewVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewVenta.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnNewVenta.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewVenta.ForeColor = System.Drawing.Color.White
        Me.btnNewVenta.IconChar = FontAwesome.Sharp.IconChar.Donate
        Me.btnNewVenta.IconColor = System.Drawing.Color.White
        Me.btnNewVenta.IconSize = 15
        Me.btnNewVenta.Location = New System.Drawing.Point(0, 0)
        Me.btnNewVenta.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNewVenta.Name = "btnNewVenta"
        Me.btnNewVenta.Rotation = 0R
        Me.btnNewVenta.Size = New System.Drawing.Size(200, 41)
        Me.btnNewVenta.TabIndex = 5
        Me.btnNewVenta.Text = "Nueva venta"
        Me.btnNewVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNewVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewVenta.UseVisualStyleBackColor = True
        '
        'btnEntregar
        '
        Me.btnEntregar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEntregar.FlatAppearance.BorderSize = 0
        Me.btnEntregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnEntregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEntregar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntregar.ForeColor = System.Drawing.Color.White
        Me.btnEntregar.IconChar = FontAwesome.Sharp.IconChar.Outdent
        Me.btnEntregar.IconColor = System.Drawing.Color.White
        Me.btnEntregar.IconSize = 15
        Me.btnEntregar.Location = New System.Drawing.Point(0, 41)
        Me.btnEntregar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Rotation = 0R
        Me.btnEntregar.Size = New System.Drawing.Size(200, 41)
        Me.btnEntregar.TabIndex = 4
        Me.btnEntregar.Text = "Entregar mercaderia"
        Me.btnEntregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEntregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEntregar.UseVisualStyleBackColor = True
        '
        'btnPresupuestoa
        '
        Me.btnPresupuestoa.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPresupuestoa.FlatAppearance.BorderSize = 0
        Me.btnPresupuestoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnPresupuestoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPresupuestoa.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnPresupuestoa.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPresupuestoa.ForeColor = System.Drawing.Color.White
        Me.btnPresupuestoa.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnPresupuestoa.IconColor = System.Drawing.Color.White
        Me.btnPresupuestoa.IconSize = 15
        Me.btnPresupuestoa.Location = New System.Drawing.Point(0, 82)
        Me.btnPresupuestoa.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPresupuestoa.Name = "btnPresupuestoa"
        Me.btnPresupuestoa.Rotation = 0R
        Me.btnPresupuestoa.Size = New System.Drawing.Size(200, 41)
        Me.btnPresupuestoa.TabIndex = 6
        Me.btnPresupuestoa.Text = "Presupuestos"
        Me.btnPresupuestoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPresupuestoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPresupuestoa.UseVisualStyleBackColor = True
        '
        'btnNuevaCompra
        '
        Me.btnNuevaCompra.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNuevaCompra.FlatAppearance.BorderSize = 0
        Me.btnNuevaCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnNuevaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaCompra.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnNuevaCompra.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaCompra.ForeColor = System.Drawing.Color.White
        Me.btnNuevaCompra.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btnNuevaCompra.IconColor = System.Drawing.Color.White
        Me.btnNuevaCompra.IconSize = 15
        Me.btnNuevaCompra.Location = New System.Drawing.Point(0, 0)
        Me.btnNuevaCompra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNuevaCompra.Name = "btnNuevaCompra"
        Me.btnNuevaCompra.Rotation = 0R
        Me.btnNuevaCompra.Size = New System.Drawing.Size(200, 41)
        Me.btnNuevaCompra.TabIndex = 5
        Me.btnNuevaCompra.Text = "Ingresar compra"
        Me.btnNuevaCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevaCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevaCompra.UseVisualStyleBackColor = True
        '
        'btnEstadoCuenta
        '
        Me.btnEstadoCuenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEstadoCuenta.FlatAppearance.BorderSize = 0
        Me.btnEstadoCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnEstadoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstadoCuenta.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEstadoCuenta.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstadoCuenta.ForeColor = System.Drawing.Color.White
        Me.btnEstadoCuenta.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.btnEstadoCuenta.IconColor = System.Drawing.Color.White
        Me.btnEstadoCuenta.IconSize = 15
        Me.btnEstadoCuenta.Location = New System.Drawing.Point(0, 41)
        Me.btnEstadoCuenta.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEstadoCuenta.Name = "btnEstadoCuenta"
        Me.btnEstadoCuenta.Rotation = 0R
        Me.btnEstadoCuenta.Size = New System.Drawing.Size(200, 41)
        Me.btnEstadoCuenta.TabIndex = 4
        Me.btnEstadoCuenta.Text = "Estado de cuenta"
        Me.btnEstadoCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEstadoCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEstadoCuenta.UseVisualStyleBackColor = True
        '
        'btnPago
        '
        Me.btnPago.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPago.FlatAppearance.BorderSize = 0
        Me.btnPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPago.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnPago.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPago.ForeColor = System.Drawing.Color.White
        Me.btnPago.IconChar = FontAwesome.Sharp.IconChar.DollarSign
        Me.btnPago.IconColor = System.Drawing.Color.White
        Me.btnPago.IconSize = 15
        Me.btnPago.Location = New System.Drawing.Point(0, 82)
        Me.btnPago.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Rotation = 0R
        Me.btnPago.Size = New System.Drawing.Size(200, 41)
        Me.btnPago.TabIndex = 6
        Me.btnPago.Text = "Ingresar pago"
        Me.btnPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPago.UseVisualStyleBackColor = True
        '
        'btnInfoArticulos
        '
        Me.btnInfoArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInfoArticulos.FlatAppearance.BorderSize = 0
        Me.btnInfoArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnInfoArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfoArticulos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnInfoArticulos.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfoArticulos.ForeColor = System.Drawing.Color.White
        Me.btnInfoArticulos.IconChar = FontAwesome.Sharp.IconChar.Tools
        Me.btnInfoArticulos.IconColor = System.Drawing.Color.White
        Me.btnInfoArticulos.IconSize = 15
        Me.btnInfoArticulos.Location = New System.Drawing.Point(0, 0)
        Me.btnInfoArticulos.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInfoArticulos.Name = "btnInfoArticulos"
        Me.btnInfoArticulos.Rotation = 0R
        Me.btnInfoArticulos.Size = New System.Drawing.Size(200, 41)
        Me.btnInfoArticulos.TabIndex = 5
        Me.btnInfoArticulos.Text = "Articulos"
        Me.btnInfoArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInfoArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInfoArticulos.UseVisualStyleBackColor = True
        '
        'btnInfoVentas
        '
        Me.btnInfoVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInfoVentas.FlatAppearance.BorderSize = 0
        Me.btnInfoVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnInfoVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfoVentas.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnInfoVentas.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfoVentas.ForeColor = System.Drawing.Color.White
        Me.btnInfoVentas.IconChar = FontAwesome.Sharp.IconChar.History
        Me.btnInfoVentas.IconColor = System.Drawing.Color.White
        Me.btnInfoVentas.IconSize = 15
        Me.btnInfoVentas.Location = New System.Drawing.Point(0, 41)
        Me.btnInfoVentas.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInfoVentas.Name = "btnInfoVentas"
        Me.btnInfoVentas.Rotation = 0R
        Me.btnInfoVentas.Size = New System.Drawing.Size(200, 41)
        Me.btnInfoVentas.TabIndex = 4
        Me.btnInfoVentas.Text = "Ventas"
        Me.btnInfoVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInfoVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInfoVentas.UseVisualStyleBackColor = True
        '
        'btnNewArticulo
        '
        Me.btnNewArticulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNewArticulo.FlatAppearance.BorderSize = 0
        Me.btnNewArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnNewArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewArticulo.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnNewArticulo.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewArticulo.ForeColor = System.Drawing.Color.White
        Me.btnNewArticulo.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnNewArticulo.IconColor = System.Drawing.Color.White
        Me.btnNewArticulo.IconSize = 15
        Me.btnNewArticulo.Location = New System.Drawing.Point(0, 0)
        Me.btnNewArticulo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNewArticulo.Name = "btnNewArticulo"
        Me.btnNewArticulo.Rotation = 0R
        Me.btnNewArticulo.Size = New System.Drawing.Size(200, 41)
        Me.btnNewArticulo.TabIndex = 5
        Me.btnNewArticulo.Text = "Ingresar articulo"
        Me.btnNewArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNewArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewArticulo.UseVisualStyleBackColor = True
        '
        'btnUpArticulo
        '
        Me.btnUpArticulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUpArticulo.FlatAppearance.BorderSize = 0
        Me.btnUpArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnUpArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpArticulo.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnUpArticulo.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpArticulo.ForeColor = System.Drawing.Color.White
        Me.btnUpArticulo.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnUpArticulo.IconColor = System.Drawing.Color.White
        Me.btnUpArticulo.IconSize = 15
        Me.btnUpArticulo.Location = New System.Drawing.Point(0, 41)
        Me.btnUpArticulo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUpArticulo.Name = "btnUpArticulo"
        Me.btnUpArticulo.Rotation = 0R
        Me.btnUpArticulo.Size = New System.Drawing.Size(200, 41)
        Me.btnUpArticulo.TabIndex = 4
        Me.btnUpArticulo.Text = "Modificar articulo"
        Me.btnUpArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpArticulo.UseVisualStyleBackColor = True
        '
        'btnPrintPrices
        '
        Me.btnPrintPrices.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPrintPrices.FlatAppearance.BorderSize = 0
        Me.btnPrintPrices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnPrintPrices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintPrices.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnPrintPrices.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPrices.ForeColor = System.Drawing.Color.White
        Me.btnPrintPrices.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnPrintPrices.IconColor = System.Drawing.Color.White
        Me.btnPrintPrices.IconSize = 15
        Me.btnPrintPrices.Location = New System.Drawing.Point(0, 82)
        Me.btnPrintPrices.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPrintPrices.Name = "btnPrintPrices"
        Me.btnPrintPrices.Rotation = 0R
        Me.btnPrintPrices.Size = New System.Drawing.Size(200, 41)
        Me.btnPrintPrices.TabIndex = 3
        Me.btnPrintPrices.Text = "Imprimir precios"
        Me.btnPrintPrices.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrintPrices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrintPrices.UseVisualStyleBackColor = True
        '
        'frmMainMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.PanelLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMainMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMainMaterial"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelVentas.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.PanelArticulos.ResumeLayout(False)
        Me.LeftTop.ResumeLayout(False)
        CType(Me.btnOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLeft As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LeftTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents lblArticulos As Label
    Friend WithEvents btnOff As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents lblFecha As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnInfoArticulos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInfoVentas As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents lblInformes As Label
    Friend WithEvents PanelArticulos As FlowLayoutPanel
    Friend WithEvents btnNewArticulo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpArticulo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPrintPrices As FontAwesome.Sharp.IconButton
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btnNuevaCompra As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEstadoCuenta As FontAwesome.Sharp.IconButton
    Friend WithEvents lblCompras As Label
    Friend WithEvents btnPago As FontAwesome.Sharp.IconButton
    Friend WithEvents lblVentas As Label
    Friend WithEvents PanelVentas As FlowLayoutPanel
    Friend WithEvents btnNewVenta As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEntregar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPresupuestoa As FontAwesome.Sharp.IconButton
End Class
