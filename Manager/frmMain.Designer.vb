<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolsMain = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnMenuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.GUIA1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFichero = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AgregarPersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CotizacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAgregarProveedor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GUIA2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCompras = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NuevaCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GUIA3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GUIA4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFicArticulos = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnAgregarArticulo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirPreciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GUIA5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolsConfig = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FicherosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GUIA7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnInformes = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnContenedor = New System.Windows.Forms.Panel()
        Me.PanelBienvenida = New System.Windows.Forms.Panel()
        Me.lblAgregarProveedor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAgregarPersona = New System.Windows.Forms.Button()
        Me.lblNuevoArticulo = New System.Windows.Forms.Button()
        Me.ToolsMain.SuspendLayout()
        Me.PnContenedor.SuspendLayout()
        Me.PanelBienvenida.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolsMain
        '
        Me.ToolsMain.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.GUIA1, Me.btnFichero, Me.GUIA2, Me.btnCompras, Me.GUIA3, Me.ToolStripDropDownButton3, Me.GUIA4, Me.btnFicArticulos, Me.GUIA5, Me.ToolsConfig, Me.GUIA7, Me.btnInformes})
        Me.ToolsMain.Location = New System.Drawing.Point(0, 0)
        Me.ToolsMain.Name = "ToolsMain"
        Me.ToolsMain.Size = New System.Drawing.Size(1008, 25)
        Me.ToolsMain.TabIndex = 1
        Me.ToolsMain.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMenuSalir})
        Me.ToolStripDropDownButton1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripDropDownButton1.Text = "Archivo"
        Me.ToolStripDropDownButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnMenuSalir
        '
        Me.btnMenuSalir.Name = "btnMenuSalir"
        Me.btnMenuSalir.Size = New System.Drawing.Size(104, 22)
        Me.btnMenuSalir.Text = "Salir"
        '
        'GUIA1
        '
        Me.GUIA1.Name = "GUIA1"
        Me.GUIA1.Size = New System.Drawing.Size(6, 25)
        '
        'btnFichero
        '
        Me.btnFichero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnFichero.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPersonaToolStripMenuItem, Me.CotizacionToolStripMenuItem, Me.ProveedoresToolStripMenuItem})
        Me.btnFichero.Image = CType(resources.GetObject("btnFichero.Image"), System.Drawing.Image)
        Me.btnFichero.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFichero.Name = "btnFichero"
        Me.btnFichero.Size = New System.Drawing.Size(74, 22)
        Me.btnFichero.Text = "Ficheros"
        '
        'AgregarPersonaToolStripMenuItem
        '
        Me.AgregarPersonaToolStripMenuItem.Name = "AgregarPersonaToolStripMenuItem"
        Me.AgregarPersonaToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.AgregarPersonaToolStripMenuItem.Text = "Agregar persona"
        '
        'CotizacionToolStripMenuItem
        '
        Me.CotizacionToolStripMenuItem.Name = "CotizacionToolStripMenuItem"
        Me.CotizacionToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CotizacionToolStripMenuItem.Text = "Cotizacion"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregarProveedor, Me.ModificarProveedorToolStripMenuItem})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'btnAgregarProveedor
        '
        Me.btnAgregarProveedor.Name = "btnAgregarProveedor"
        Me.btnAgregarProveedor.Size = New System.Drawing.Size(207, 22)
        Me.btnAgregarProveedor.Text = "Agregar Proveedor"
        '
        'ModificarProveedorToolStripMenuItem
        '
        Me.ModificarProveedorToolStripMenuItem.Name = "ModificarProveedorToolStripMenuItem"
        Me.ModificarProveedorToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ModificarProveedorToolStripMenuItem.Text = "Modificar Proveedor"
        '
        'GUIA2
        '
        Me.GUIA2.Name = "GUIA2"
        Me.GUIA2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCompras
        '
        Me.btnCompras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnCompras.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaCompraToolStripMenuItem})
        Me.btnCompras.Image = CType(resources.GetObject("btnCompras.Image"), System.Drawing.Image)
        Me.btnCompras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(77, 22)
        Me.btnCompras.Text = "Compras"
        '
        'NuevaCompraToolStripMenuItem
        '
        Me.NuevaCompraToolStripMenuItem.Name = "NuevaCompraToolStripMenuItem"
        Me.NuevaCompraToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.NuevaCompraToolStripMenuItem.Text = "Nueva compra"
        '
        'GUIA3
        '
        Me.GUIA3.Name = "GUIA3"
        Me.GUIA3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaVentaToolStripMenuItem})
        Me.ToolStripDropDownButton3.Image = CType(resources.GetObject("ToolStripDropDownButton3.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripDropDownButton3.Text = "Venta"
        '
        'NuevaVentaToolStripMenuItem
        '
        Me.NuevaVentaToolStripMenuItem.Name = "NuevaVentaToolStripMenuItem"
        Me.NuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.NuevaVentaToolStripMenuItem.Text = "Nueva venta"
        '
        'GUIA4
        '
        Me.GUIA4.Name = "GUIA4"
        Me.GUIA4.Size = New System.Drawing.Size(6, 25)
        '
        'btnFicArticulos
        '
        Me.btnFicArticulos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnFicArticulos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregarArticulo, Me.ModificarArticuloToolStripMenuItem, Me.ImprimirPreciosToolStripMenuItem})
        Me.btnFicArticulos.Image = CType(resources.GetObject("btnFicArticulos.Image"), System.Drawing.Image)
        Me.btnFicArticulos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFicArticulos.Name = "btnFicArticulos"
        Me.btnFicArticulos.Size = New System.Drawing.Size(79, 22)
        Me.btnFicArticulos.Text = "Articulos"
        '
        'btnAgregarArticulo
        '
        Me.btnAgregarArticulo.Name = "btnAgregarArticulo"
        Me.btnAgregarArticulo.Size = New System.Drawing.Size(190, 22)
        Me.btnAgregarArticulo.Text = "Agregar Articulo"
        '
        'ModificarArticuloToolStripMenuItem
        '
        Me.ModificarArticuloToolStripMenuItem.Name = "ModificarArticuloToolStripMenuItem"
        Me.ModificarArticuloToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ModificarArticuloToolStripMenuItem.Text = "Modificar Articulo"
        '
        'ImprimirPreciosToolStripMenuItem
        '
        Me.ImprimirPreciosToolStripMenuItem.Name = "ImprimirPreciosToolStripMenuItem"
        Me.ImprimirPreciosToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ImprimirPreciosToolStripMenuItem.Text = "Imprimir Precios"
        '
        'GUIA5
        '
        Me.GUIA5.Name = "GUIA5"
        Me.GUIA5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolsConfig
        '
        Me.ToolsConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolsConfig.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguracionToolStripMenuItem})
        Me.ToolsConfig.Image = CType(resources.GetObject("ToolsConfig.Image"), System.Drawing.Image)
        Me.ToolsConfig.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolsConfig.Name = "ToolsConfig"
        Me.ToolsConfig.Size = New System.Drawing.Size(61, 22)
        Me.ToolsConfig.Text = "Config"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosToolStripMenuItem, Me.FicherosToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ConfiguracionToolStripMenuItem.Text = "Empresa"
        '
        'DatosToolStripMenuItem
        '
        Me.DatosToolStripMenuItem.Name = "DatosToolStripMenuItem"
        Me.DatosToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.DatosToolStripMenuItem.Text = "Datos"
        '
        'FicherosToolStripMenuItem
        '
        Me.FicherosToolStripMenuItem.Name = "FicherosToolStripMenuItem"
        Me.FicherosToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.FicherosToolStripMenuItem.Text = "Ficheros"
        '
        'GUIA7
        '
        Me.GUIA7.Name = "GUIA7"
        Me.GUIA7.Size = New System.Drawing.Size(6, 25)
        '
        'btnInformes
        '
        Me.btnInformes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnInformes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticulosToolStripMenuItem})
        Me.btnInformes.Image = CType(resources.GetObject("btnInformes.Image"), System.Drawing.Image)
        Me.btnInformes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(79, 22)
        Me.btnInformes.Text = "Informes"
        '
        'ArticulosToolStripMenuItem
        '
        Me.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        Me.ArticulosToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ArticulosToolStripMenuItem.Text = "Articulos"
        '
        'PnContenedor
        '
        Me.PnContenedor.Controls.Add(Me.PanelBienvenida)
        Me.PnContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnContenedor.Location = New System.Drawing.Point(0, 25)
        Me.PnContenedor.Name = "PnContenedor"
        Me.PnContenedor.Size = New System.Drawing.Size(1008, 705)
        Me.PnContenedor.TabIndex = 2
        '
        'PanelBienvenida
        '
        Me.PanelBienvenida.BackgroundImage = Global.Manager.My.Resources.JJRecursos.Fondo
        Me.PanelBienvenida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelBienvenida.Controls.Add(Me.lblAgregarProveedor)
        Me.PanelBienvenida.Controls.Add(Me.Label1)
        Me.PanelBienvenida.Controls.Add(Me.PictureBox1)
        Me.PanelBienvenida.Controls.Add(Me.lblAgregarPersona)
        Me.PanelBienvenida.Controls.Add(Me.lblNuevoArticulo)
        Me.PanelBienvenida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBienvenida.Location = New System.Drawing.Point(0, 0)
        Me.PanelBienvenida.Name = "PanelBienvenida"
        Me.PanelBienvenida.Size = New System.Drawing.Size(1008, 705)
        Me.PanelBienvenida.TabIndex = 7
        '
        'lblAgregarProveedor
        '
        Me.lblAgregarProveedor.BackColor = System.Drawing.Color.Transparent
        Me.lblAgregarProveedor.FlatAppearance.BorderSize = 0
        Me.lblAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAgregarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarProveedor.ForeColor = System.Drawing.Color.White
        Me.lblAgregarProveedor.Image = Global.Manager.My.Resources.JJRecursos.man
        Me.lblAgregarProveedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblAgregarProveedor.Location = New System.Drawing.Point(129, 269)
        Me.lblAgregarProveedor.Name = "lblAgregarProveedor"
        Me.lblAgregarProveedor.Size = New System.Drawing.Size(186, 37)
        Me.lblAgregarProveedor.TabIndex = 12
        Me.lblAgregarProveedor.Text = "Agregar Proveedor"
        Me.lblAgregarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAgregarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.lblAgregarProveedor.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(124, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "JJ Soluciones Informaticas."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Manager.My.Resources.JJRecursos.JOLOGO1
        Me.PictureBox1.Location = New System.Drawing.Point(45, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'lblAgregarPersona
        '
        Me.lblAgregarPersona.BackColor = System.Drawing.Color.Transparent
        Me.lblAgregarPersona.FlatAppearance.BorderSize = 0
        Me.lblAgregarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAgregarPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarPersona.ForeColor = System.Drawing.Color.White
        Me.lblAgregarPersona.Image = Global.Manager.My.Resources.JJRecursos.man
        Me.lblAgregarPersona.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblAgregarPersona.Location = New System.Drawing.Point(129, 203)
        Me.lblAgregarPersona.Name = "lblAgregarPersona"
        Me.lblAgregarPersona.Size = New System.Drawing.Size(186, 37)
        Me.lblAgregarPersona.TabIndex = 4
        Me.lblAgregarPersona.Text = "Agregar Persona"
        Me.lblAgregarPersona.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAgregarPersona.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.lblAgregarPersona.UseVisualStyleBackColor = False
        '
        'lblNuevoArticulo
        '
        Me.lblNuevoArticulo.BackColor = System.Drawing.Color.Transparent
        Me.lblNuevoArticulo.FlatAppearance.BorderSize = 0
        Me.lblNuevoArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNuevoArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoArticulo.ForeColor = System.Drawing.Color.White
        Me.lblNuevoArticulo.Image = Global.Manager.My.Resources.JJRecursos.Tools
        Me.lblNuevoArticulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblNuevoArticulo.Location = New System.Drawing.Point(129, 135)
        Me.lblNuevoArticulo.Name = "lblNuevoArticulo"
        Me.lblNuevoArticulo.Size = New System.Drawing.Size(186, 37)
        Me.lblNuevoArticulo.TabIndex = 1
        Me.lblNuevoArticulo.Text = "Agregar Articulos"
        Me.lblNuevoArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNuevoArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.lblNuevoArticulo.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.PnContenedor)
        Me.Controls.Add(Me.ToolsMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Menu principal"
        Me.ToolsMain.ResumeLayout(False)
        Me.ToolsMain.PerformLayout()
        Me.PnContenedor.ResumeLayout(False)
        Me.PanelBienvenida.ResumeLayout(False)
        Me.PanelBienvenida.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolsMain As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents btnMenuSalir As ToolStripMenuItem
    Friend WithEvents GUIA1 As ToolStripSeparator
    Friend WithEvents btnFichero As ToolStripDropDownButton
    Friend WithEvents GUIA3 As ToolStripSeparator
    Friend WithEvents GUIA4 As ToolStripSeparator
    Friend WithEvents AgregarPersonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PnContenedor As Panel
    Friend WithEvents PanelBienvenida As Panel
    Friend WithEvents lblAgregarPersona As Button
    Friend WithEvents lblNuevoArticulo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolsConfig As ToolStripDropDownButton
    Friend WithEvents ConfiguracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FicherosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GUIA2 As ToolStripSeparator
    Friend WithEvents btnCompras As ToolStripDropDownButton
    Friend WithEvents NuevaCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GUIA7 As ToolStripSeparator
    Friend WithEvents GUIA5 As ToolStripSeparator
    Friend WithEvents btnFicArticulos As ToolStripDropDownButton
    Friend WithEvents btnAgregarArticulo As ToolStripMenuItem
    Friend WithEvents ModificarArticuloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton3 As ToolStripDropDownButton
    Friend WithEvents NuevaVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblAgregarProveedor As Button
    Friend WithEvents ImprimirPreciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnInformes As ToolStripDropDownButton
    Friend WithEvents ArticulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CotizacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAgregarProveedor As ToolStripMenuItem
    Friend WithEvents ModificarProveedorToolStripMenuItem As ToolStripMenuItem
End Class
