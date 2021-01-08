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
        Me.PanelFichero = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCotizacion = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelVentas = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnNewVenta = New FontAwesome.Sharp.IconButton()
        Me.btnEntregar = New FontAwesome.Sharp.IconButton()
        Me.btnPresupuestoa = New FontAwesome.Sharp.IconButton()
        Me.lblVentas = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnNuevaCompra = New FontAwesome.Sharp.IconButton()
        Me.btnEstadoCuenta = New FontAwesome.Sharp.IconButton()
        Me.btnPago = New FontAwesome.Sharp.IconButton()
        Me.btnNuevoProveedor = New FontAwesome.Sharp.IconButton()
        Me.btnUpProveedor = New FontAwesome.Sharp.IconButton()
        Me.lblCompras = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnInfoArticulos = New FontAwesome.Sharp.IconButton()
        Me.btnInfoVentas = New FontAwesome.Sharp.IconButton()
        Me.lblInformes = New System.Windows.Forms.Label()
        Me.PanelArticulos = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnNewArticulo = New FontAwesome.Sharp.IconButton()
        Me.btnUpArticulo = New FontAwesome.Sharp.IconButton()
        Me.btnPrintPrices = New FontAwesome.Sharp.IconButton()
        Me.lblArticulos = New System.Windows.Forms.Label()
        Me.LeftTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.btnOff = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.PanelLeft.SuspendLayout()
        Me.PanelFichero.SuspendLayout()
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
        Me.PanelLeft.Controls.Add(Me.PanelFichero)
        Me.PanelLeft.Controls.Add(Me.Label2)
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
        'PanelFichero
        '
        Me.PanelFichero.Controls.Add(Me.btnCotizacion)
        Me.PanelFichero.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFichero.Location = New System.Drawing.Point(0, 488)
        Me.PanelFichero.Name = "PanelFichero"
        Me.PanelFichero.Size = New System.Drawing.Size(200, 25)
        Me.PanelFichero.TabIndex = 14
        '
        'btnCotizacion
        '
        Me.btnCotizacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCotizacion.FlatAppearance.BorderSize = 0
        Me.btnCotizacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCotizacion.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCotizacion.ForeColor = System.Drawing.Color.White
        Me.btnCotizacion.IconChar = FontAwesome.Sharp.IconChar.Donate
        Me.btnCotizacion.IconColor = System.Drawing.Color.White
        Me.btnCotizacion.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCotizacion.IconSize = 15
        Me.btnCotizacion.Location = New System.Drawing.Point(0, 0)
        Me.btnCotizacion.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCotizacion.Name = "btnCotizacion"
        Me.btnCotizacion.Size = New System.Drawing.Size(200, 25)
        Me.btnCotizacion.TabIndex = 5
        Me.btnCotizacion.Text = "Cotizacion"
        Me.btnCotizacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCotizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCotizacion.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 463)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Fichero"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelVentas
        '
        Me.PanelVentas.Controls.Add(Me.btnNewVenta)
        Me.PanelVentas.Controls.Add(Me.btnEntregar)
        Me.PanelVentas.Controls.Add(Me.btnPresupuestoa)
        Me.PanelVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelVentas.Location = New System.Drawing.Point(0, 388)
        Me.PanelVentas.Name = "PanelVentas"
        Me.PanelVentas.Size = New System.Drawing.Size(200, 75)
        Me.PanelVentas.TabIndex = 12
        '
        'btnNewVenta
        '
        Me.btnNewVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNewVenta.FlatAppearance.BorderSize = 0
        Me.btnNewVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnNewVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewVenta.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewVenta.ForeColor = System.Drawing.Color.White
        Me.btnNewVenta.IconChar = FontAwesome.Sharp.IconChar.Donate
        Me.btnNewVenta.IconColor = System.Drawing.Color.White
        Me.btnNewVenta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNewVenta.IconSize = 15
        Me.btnNewVenta.Location = New System.Drawing.Point(0, 0)
        Me.btnNewVenta.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNewVenta.Name = "btnNewVenta"
        Me.btnNewVenta.Size = New System.Drawing.Size(200, 25)
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
        Me.btnEntregar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntregar.ForeColor = System.Drawing.Color.White
        Me.btnEntregar.IconChar = FontAwesome.Sharp.IconChar.Outdent
        Me.btnEntregar.IconColor = System.Drawing.Color.White
        Me.btnEntregar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEntregar.IconSize = 15
        Me.btnEntregar.Location = New System.Drawing.Point(0, 25)
        Me.btnEntregar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Size = New System.Drawing.Size(200, 25)
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
        Me.btnPresupuestoa.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPresupuestoa.ForeColor = System.Drawing.Color.White
        Me.btnPresupuestoa.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnPresupuestoa.IconColor = System.Drawing.Color.White
        Me.btnPresupuestoa.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPresupuestoa.IconSize = 15
        Me.btnPresupuestoa.Location = New System.Drawing.Point(0, 50)
        Me.btnPresupuestoa.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPresupuestoa.Name = "btnPresupuestoa"
        Me.btnPresupuestoa.Size = New System.Drawing.Size(200, 25)
        Me.btnPresupuestoa.TabIndex = 6
        Me.btnPresupuestoa.Text = "Presupuestos"
        Me.btnPresupuestoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPresupuestoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPresupuestoa.UseVisualStyleBackColor = True
        '
        'lblVentas
        '
        Me.lblVentas.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblVentas.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentas.ForeColor = System.Drawing.Color.White
        Me.lblVentas.Location = New System.Drawing.Point(0, 363)
        Me.lblVentas.Name = "lblVentas"
        Me.lblVentas.Size = New System.Drawing.Size(200, 25)
        Me.lblVentas.TabIndex = 11
        Me.lblVentas.Text = "Ventas"
        Me.lblVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnNuevaCompra)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnEstadoCuenta)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnPago)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnNuevoProveedor)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnUpProveedor)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 238)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(200, 125)
        Me.FlowLayoutPanel2.TabIndex = 10
        '
        'btnNuevaCompra
        '
        Me.btnNuevaCompra.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNuevaCompra.FlatAppearance.BorderSize = 0
        Me.btnNuevaCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnNuevaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaCompra.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaCompra.ForeColor = System.Drawing.Color.White
        Me.btnNuevaCompra.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btnNuevaCompra.IconColor = System.Drawing.Color.White
        Me.btnNuevaCompra.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNuevaCompra.IconSize = 15
        Me.btnNuevaCompra.Location = New System.Drawing.Point(0, 0)
        Me.btnNuevaCompra.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNuevaCompra.Name = "btnNuevaCompra"
        Me.btnNuevaCompra.Size = New System.Drawing.Size(200, 25)
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
        Me.btnEstadoCuenta.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstadoCuenta.ForeColor = System.Drawing.Color.White
        Me.btnEstadoCuenta.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.btnEstadoCuenta.IconColor = System.Drawing.Color.White
        Me.btnEstadoCuenta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEstadoCuenta.IconSize = 15
        Me.btnEstadoCuenta.Location = New System.Drawing.Point(0, 25)
        Me.btnEstadoCuenta.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEstadoCuenta.Name = "btnEstadoCuenta"
        Me.btnEstadoCuenta.Size = New System.Drawing.Size(200, 25)
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
        Me.btnPago.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPago.ForeColor = System.Drawing.Color.White
        Me.btnPago.IconChar = FontAwesome.Sharp.IconChar.DollarSign
        Me.btnPago.IconColor = System.Drawing.Color.White
        Me.btnPago.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPago.IconSize = 15
        Me.btnPago.Location = New System.Drawing.Point(0, 50)
        Me.btnPago.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(200, 25)
        Me.btnPago.TabIndex = 6
        Me.btnPago.Text = "Ingresar pago"
        Me.btnPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPago.UseVisualStyleBackColor = True
        '
        'btnNuevoProveedor
        '
        Me.btnNuevoProveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNuevoProveedor.FlatAppearance.BorderSize = 0
        Me.btnNuevoProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnNuevoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoProveedor.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoProveedor.ForeColor = System.Drawing.Color.White
        Me.btnNuevoProveedor.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnNuevoProveedor.IconColor = System.Drawing.Color.White
        Me.btnNuevoProveedor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNuevoProveedor.IconSize = 15
        Me.btnNuevoProveedor.Location = New System.Drawing.Point(0, 75)
        Me.btnNuevoProveedor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNuevoProveedor.Name = "btnNuevoProveedor"
        Me.btnNuevoProveedor.Size = New System.Drawing.Size(200, 25)
        Me.btnNuevoProveedor.TabIndex = 7
        Me.btnNuevoProveedor.Text = "Nuevo Proveedor"
        Me.btnNuevoProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevoProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevoProveedor.UseVisualStyleBackColor = True
        '
        'btnUpProveedor
        '
        Me.btnUpProveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUpProveedor.FlatAppearance.BorderSize = 0
        Me.btnUpProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnUpProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpProveedor.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpProveedor.ForeColor = System.Drawing.Color.White
        Me.btnUpProveedor.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnUpProveedor.IconColor = System.Drawing.Color.White
        Me.btnUpProveedor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUpProveedor.IconSize = 15
        Me.btnUpProveedor.Location = New System.Drawing.Point(0, 100)
        Me.btnUpProveedor.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUpProveedor.Name = "btnUpProveedor"
        Me.btnUpProveedor.Size = New System.Drawing.Size(200, 25)
        Me.btnUpProveedor.TabIndex = 8
        Me.btnUpProveedor.Text = "Modificar proveedor"
        Me.btnUpProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpProveedor.UseVisualStyleBackColor = True
        '
        'lblCompras
        '
        Me.lblCompras.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCompras.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompras.ForeColor = System.Drawing.Color.White
        Me.lblCompras.Location = New System.Drawing.Point(0, 213)
        Me.lblCompras.Name = "lblCompras"
        Me.lblCompras.Size = New System.Drawing.Size(200, 25)
        Me.lblCompras.TabIndex = 10
        Me.lblCompras.Text = "Compras"
        Me.lblCompras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnInfoArticulos)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnInfoVentas)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 163)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 50)
        Me.FlowLayoutPanel1.TabIndex = 9
        '
        'btnInfoArticulos
        '
        Me.btnInfoArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInfoArticulos.FlatAppearance.BorderSize = 0
        Me.btnInfoArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnInfoArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfoArticulos.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfoArticulos.ForeColor = System.Drawing.Color.White
        Me.btnInfoArticulos.IconChar = FontAwesome.Sharp.IconChar.Tools
        Me.btnInfoArticulos.IconColor = System.Drawing.Color.White
        Me.btnInfoArticulos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInfoArticulos.IconSize = 15
        Me.btnInfoArticulos.Location = New System.Drawing.Point(0, 0)
        Me.btnInfoArticulos.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInfoArticulos.Name = "btnInfoArticulos"
        Me.btnInfoArticulos.Size = New System.Drawing.Size(200, 25)
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
        Me.btnInfoVentas.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfoVentas.ForeColor = System.Drawing.Color.White
        Me.btnInfoVentas.IconChar = FontAwesome.Sharp.IconChar.History
        Me.btnInfoVentas.IconColor = System.Drawing.Color.White
        Me.btnInfoVentas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInfoVentas.IconSize = 15
        Me.btnInfoVentas.Location = New System.Drawing.Point(0, 25)
        Me.btnInfoVentas.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInfoVentas.Name = "btnInfoVentas"
        Me.btnInfoVentas.Size = New System.Drawing.Size(200, 25)
        Me.btnInfoVentas.TabIndex = 4
        Me.btnInfoVentas.Text = "Ventas"
        Me.btnInfoVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInfoVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInfoVentas.UseVisualStyleBackColor = True
        '
        'lblInformes
        '
        Me.lblInformes.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblInformes.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblInformes.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformes.ForeColor = System.Drawing.Color.White
        Me.lblInformes.Location = New System.Drawing.Point(0, 138)
        Me.lblInformes.Name = "lblInformes"
        Me.lblInformes.Size = New System.Drawing.Size(200, 25)
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
        Me.PanelArticulos.Location = New System.Drawing.Point(0, 63)
        Me.PanelArticulos.Name = "PanelArticulos"
        Me.PanelArticulos.Size = New System.Drawing.Size(200, 75)
        Me.PanelArticulos.TabIndex = 3
        '
        'btnNewArticulo
        '
        Me.btnNewArticulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNewArticulo.FlatAppearance.BorderSize = 0
        Me.btnNewArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnNewArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewArticulo.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewArticulo.ForeColor = System.Drawing.Color.White
        Me.btnNewArticulo.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnNewArticulo.IconColor = System.Drawing.Color.White
        Me.btnNewArticulo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNewArticulo.IconSize = 15
        Me.btnNewArticulo.Location = New System.Drawing.Point(0, 0)
        Me.btnNewArticulo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNewArticulo.Name = "btnNewArticulo"
        Me.btnNewArticulo.Size = New System.Drawing.Size(200, 25)
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
        Me.btnUpArticulo.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpArticulo.ForeColor = System.Drawing.Color.White
        Me.btnUpArticulo.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnUpArticulo.IconColor = System.Drawing.Color.White
        Me.btnUpArticulo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUpArticulo.IconSize = 15
        Me.btnUpArticulo.Location = New System.Drawing.Point(0, 25)
        Me.btnUpArticulo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUpArticulo.Name = "btnUpArticulo"
        Me.btnUpArticulo.Size = New System.Drawing.Size(200, 25)
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
        Me.btnPrintPrices.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPrices.ForeColor = System.Drawing.Color.White
        Me.btnPrintPrices.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnPrintPrices.IconColor = System.Drawing.Color.White
        Me.btnPrintPrices.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrintPrices.IconSize = 15
        Me.btnPrintPrices.Location = New System.Drawing.Point(0, 50)
        Me.btnPrintPrices.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPrintPrices.Name = "btnPrintPrices"
        Me.btnPrintPrices.Size = New System.Drawing.Size(200, 25)
        Me.btnPrintPrices.TabIndex = 3
        Me.btnPrintPrices.Text = "Imprimir precios"
        Me.btnPrintPrices.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrintPrices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrintPrices.UseVisualStyleBackColor = True
        '
        'lblArticulos
        '
        Me.lblArticulos.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblArticulos.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticulos.ForeColor = System.Drawing.Color.White
        Me.lblArticulos.Location = New System.Drawing.Point(0, 38)
        Me.lblArticulos.Name = "lblArticulos"
        Me.lblArticulos.Size = New System.Drawing.Size(200, 25)
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
        'frmMainMaterial
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
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
        Me.PanelFichero.ResumeLayout(False)
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
    Friend WithEvents btnNuevoProveedor As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents btnUpProveedor As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelFichero As FlowLayoutPanel
    Friend WithEvents btnCotizacion As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
End Class
