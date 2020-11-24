<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain_Material
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain_Material))
        Me.PanelIzquierdo = New System.Windows.Forms.Panel()
        Me.PanelVentas = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.PanelCompras = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelFichero = New System.Windows.Forms.Panel()
        Me.btnClientesContado = New System.Windows.Forms.Button()
        Me.btnFicheros = New System.Windows.Forms.Button()
        Me.PanelInformes = New System.Windows.Forms.Panel()
        Me.btnListadoVentas = New System.Windows.Forms.Button()
        Me.btnListadoArticulos = New System.Windows.Forms.Button()
        Me.btnInformes = New System.Windows.Forms.Button()
        Me.PanelArticulos = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.TimerTime = New System.Windows.Forms.Timer(Me.components)
        Me.PanelFormularios = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnPrintPrices = New FontAwesome.Sharp.IconButton()
        Me.btnUpArticulo = New FontAwesome.Sharp.IconButton()
        Me.btnNewArticulo = New FontAwesome.Sharp.IconButton()
        Me.btnArticulos = New FontAwesome.Sharp.IconButton()
        Me.PanelIzquierdo.SuspendLayout()
        Me.PanelVentas.SuspendLayout()
        Me.PanelCompras.SuspendLayout()
        Me.PanelFichero.SuspendLayout()
        Me.PanelInformes.SuspendLayout()
        Me.PanelArticulos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelIzquierdo
        '
        Me.PanelIzquierdo.AutoScroll = True
        Me.PanelIzquierdo.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelIzquierdo.Controls.Add(Me.PanelVentas)
        Me.PanelIzquierdo.Controls.Add(Me.btnVenta)
        Me.PanelIzquierdo.Controls.Add(Me.PanelCompras)
        Me.PanelIzquierdo.Controls.Add(Me.Button1)
        Me.PanelIzquierdo.Controls.Add(Me.PanelFichero)
        Me.PanelIzquierdo.Controls.Add(Me.btnFicheros)
        Me.PanelIzquierdo.Controls.Add(Me.PanelInformes)
        Me.PanelIzquierdo.Controls.Add(Me.btnInformes)
        Me.PanelIzquierdo.Controls.Add(Me.PanelArticulos)
        Me.PanelIzquierdo.Controls.Add(Me.btnArticulos)
        Me.PanelIzquierdo.Controls.Add(Me.Panel1)
        Me.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelIzquierdo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelIzquierdo.Location = New System.Drawing.Point(0, 0)
        Me.PanelIzquierdo.Name = "PanelIzquierdo"
        Me.PanelIzquierdo.Size = New System.Drawing.Size(186, 768)
        Me.PanelIzquierdo.TabIndex = 1
        '
        'PanelVentas
        '
        Me.PanelVentas.Controls.Add(Me.Button6)
        Me.PanelVentas.Controls.Add(Me.Button7)
        Me.PanelVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelVentas.ForeColor = System.Drawing.Color.White
        Me.PanelVentas.Location = New System.Drawing.Point(0, 577)
        Me.PanelVentas.Name = "PanelVentas"
        Me.PanelVentas.Size = New System.Drawing.Size(186, 115)
        Me.PanelVentas.TabIndex = 6
        Me.PanelVentas.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.DarkGray
        Me.Button6.Location = New System.Drawing.Point(0, 37)
        Me.Button6.Margin = New System.Windows.Forms.Padding(0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(186, 37)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Entregar mercaderia"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.DarkGray
        Me.Button7.Location = New System.Drawing.Point(0, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(186, 37)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Nueva venta"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btnVenta
        '
        Me.btnVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVenta.FlatAppearance.BorderSize = 0
        Me.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVenta.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVenta.ForeColor = System.Drawing.Color.White
        Me.btnVenta.Location = New System.Drawing.Point(0, 547)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(186, 30)
        Me.btnVenta.TabIndex = 6
        Me.btnVenta.Text = "VENTA"
        Me.btnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVenta.UseVisualStyleBackColor = False
        '
        'PanelCompras
        '
        Me.PanelCompras.Controls.Add(Me.Button4)
        Me.PanelCompras.Controls.Add(Me.Button3)
        Me.PanelCompras.Controls.Add(Me.Button2)
        Me.PanelCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCompras.ForeColor = System.Drawing.Color.White
        Me.PanelCompras.Location = New System.Drawing.Point(0, 436)
        Me.PanelCompras.Name = "PanelCompras"
        Me.PanelCompras.Size = New System.Drawing.Size(186, 111)
        Me.PanelCompras.TabIndex = 12
        Me.PanelCompras.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.DarkGray
        Me.Button4.Location = New System.Drawing.Point(0, 74)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(186, 37)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Cobros"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.DarkGray
        Me.Button3.Location = New System.Drawing.Point(0, 37)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(186, 37)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Deuda proveedor"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.DarkGray
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(186, 37)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Nueva compra"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 406)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 30)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "COMPRAS"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PanelFichero
        '
        Me.PanelFichero.Controls.Add(Me.btnClientesContado)
        Me.PanelFichero.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFichero.ForeColor = System.Drawing.Color.White
        Me.PanelFichero.Location = New System.Drawing.Point(0, 369)
        Me.PanelFichero.Name = "PanelFichero"
        Me.PanelFichero.Size = New System.Drawing.Size(186, 37)
        Me.PanelFichero.TabIndex = 10
        Me.PanelFichero.Visible = False
        '
        'btnClientesContado
        '
        Me.btnClientesContado.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnClientesContado.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientesContado.FlatAppearance.BorderSize = 0
        Me.btnClientesContado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientesContado.ForeColor = System.Drawing.Color.DarkGray
        Me.btnClientesContado.Location = New System.Drawing.Point(0, 0)
        Me.btnClientesContado.Name = "btnClientesContado"
        Me.btnClientesContado.Size = New System.Drawing.Size(186, 37)
        Me.btnClientesContado.TabIndex = 4
        Me.btnClientesContado.Text = "Clientes contado"
        Me.btnClientesContado.UseVisualStyleBackColor = False
        '
        'btnFicheros
        '
        Me.btnFicheros.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnFicheros.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFicheros.FlatAppearance.BorderSize = 0
        Me.btnFicheros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFicheros.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFicheros.ForeColor = System.Drawing.Color.White
        Me.btnFicheros.Location = New System.Drawing.Point(0, 339)
        Me.btnFicheros.Name = "btnFicheros"
        Me.btnFicheros.Size = New System.Drawing.Size(186, 30)
        Me.btnFicheros.TabIndex = 9
        Me.btnFicheros.Text = "FICHERO"
        Me.btnFicheros.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnFicheros.UseVisualStyleBackColor = False
        '
        'PanelInformes
        '
        Me.PanelInformes.Controls.Add(Me.btnListadoVentas)
        Me.PanelInformes.Controls.Add(Me.btnListadoArticulos)
        Me.PanelInformes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelInformes.ForeColor = System.Drawing.Color.White
        Me.PanelInformes.Location = New System.Drawing.Point(0, 262)
        Me.PanelInformes.Name = "PanelInformes"
        Me.PanelInformes.Size = New System.Drawing.Size(186, 77)
        Me.PanelInformes.TabIndex = 8
        Me.PanelInformes.Visible = False
        '
        'btnListadoVentas
        '
        Me.btnListadoVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnListadoVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListadoVentas.FlatAppearance.BorderSize = 0
        Me.btnListadoVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListadoVentas.ForeColor = System.Drawing.Color.DarkGray
        Me.btnListadoVentas.Location = New System.Drawing.Point(0, 37)
        Me.btnListadoVentas.Name = "btnListadoVentas"
        Me.btnListadoVentas.Size = New System.Drawing.Size(186, 37)
        Me.btnListadoVentas.TabIndex = 5
        Me.btnListadoVentas.Text = "Ventas"
        Me.btnListadoVentas.UseVisualStyleBackColor = False
        '
        'btnListadoArticulos
        '
        Me.btnListadoArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnListadoArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListadoArticulos.FlatAppearance.BorderSize = 0
        Me.btnListadoArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListadoArticulos.ForeColor = System.Drawing.Color.DarkGray
        Me.btnListadoArticulos.Location = New System.Drawing.Point(0, 0)
        Me.btnListadoArticulos.Name = "btnListadoArticulos"
        Me.btnListadoArticulos.Size = New System.Drawing.Size(186, 37)
        Me.btnListadoArticulos.TabIndex = 4
        Me.btnListadoArticulos.Text = "Articulos"
        Me.btnListadoArticulos.UseVisualStyleBackColor = False
        '
        'btnInformes
        '
        Me.btnInformes.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnInformes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInformes.FlatAppearance.BorderSize = 0
        Me.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInformes.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformes.ForeColor = System.Drawing.Color.White
        Me.btnInformes.Location = New System.Drawing.Point(0, 232)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(186, 30)
        Me.btnInformes.TabIndex = 7
        Me.btnInformes.Text = "INFORMES"
        Me.btnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInformes.UseVisualStyleBackColor = False
        '
        'PanelArticulos
        '
        Me.PanelArticulos.Controls.Add(Me.btnPrintPrices)
        Me.PanelArticulos.Controls.Add(Me.btnUpArticulo)
        Me.PanelArticulos.Controls.Add(Me.btnNewArticulo)
        Me.PanelArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelArticulos.ForeColor = System.Drawing.Color.White
        Me.PanelArticulos.Location = New System.Drawing.Point(0, 145)
        Me.PanelArticulos.Name = "PanelArticulos"
        Me.PanelArticulos.Size = New System.Drawing.Size(186, 87)
        Me.PanelArticulos.TabIndex = 5
        Me.PanelArticulos.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuSeparator2)
        Me.Panel1.Controls.Add(Me.lblHora)
        Me.Panel1.Controls.Add(Me.BunifuSeparator1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(186, 115)
        Me.Panel1.TabIndex = 7
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(13, 25)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(155, 12)
        Me.BunifuSeparator2.TabIndex = 3
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'lblHora
        '
        Me.lblHora.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(12, 52)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(157, 19)
        Me.lblHora.TabIndex = 2
        Me.lblHora.Text = "Label1"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(13, 90)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(155, 10)
        Me.BunifuSeparator1.TabIndex = 0
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'TimerTime
        '
        Me.TimerTime.Interval = 10
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackgroundImage = CType(resources.GetObject("PanelFormularios.BackgroundImage"), System.Drawing.Image)
        Me.PanelFormularios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelFormularios.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelFormularios.GradientTopLeft = System.Drawing.Color.Transparent
        Me.PanelFormularios.GradientTopRight = System.Drawing.Color.Transparent
        Me.PanelFormularios.Location = New System.Drawing.Point(186, 0)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Quality = 10
        Me.PanelFormularios.Size = New System.Drawing.Size(838, 768)
        Me.PanelFormularios.TabIndex = 2
        '
        'btnPrintPrices
        '
        Me.btnPrintPrices.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPrintPrices.FlatAppearance.BorderSize = 0
        Me.btnPrintPrices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintPrices.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnPrintPrices.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPrices.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnPrintPrices.IconColor = System.Drawing.Color.White
        Me.btnPrintPrices.IconSize = 16
        Me.btnPrintPrices.Location = New System.Drawing.Point(0, 58)
        Me.btnPrintPrices.Name = "btnPrintPrices"
        Me.btnPrintPrices.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnPrintPrices.Rotation = 0R
        Me.btnPrintPrices.Size = New System.Drawing.Size(186, 29)
        Me.btnPrintPrices.TabIndex = 2
        Me.btnPrintPrices.Text = "- Imprimir precios"
        Me.btnPrintPrices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintPrices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrintPrices.UseVisualStyleBackColor = True
        '
        'btnUpArticulo
        '
        Me.btnUpArticulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUpArticulo.FlatAppearance.BorderSize = 0
        Me.btnUpArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpArticulo.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnUpArticulo.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpArticulo.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnUpArticulo.IconColor = System.Drawing.Color.White
        Me.btnUpArticulo.IconSize = 16
        Me.btnUpArticulo.Location = New System.Drawing.Point(0, 29)
        Me.btnUpArticulo.Name = "btnUpArticulo"
        Me.btnUpArticulo.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.btnUpArticulo.Rotation = 0R
        Me.btnUpArticulo.Size = New System.Drawing.Size(186, 29)
        Me.btnUpArticulo.TabIndex = 1
        Me.btnUpArticulo.Text = "- Modificar articulo"
        Me.btnUpArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpArticulo.UseVisualStyleBackColor = True
        '
        'btnNewArticulo
        '
        Me.btnNewArticulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNewArticulo.FlatAppearance.BorderSize = 0
        Me.btnNewArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewArticulo.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnNewArticulo.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewArticulo.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.btnNewArticulo.IconColor = System.Drawing.Color.White
        Me.btnNewArticulo.IconSize = 16
        Me.btnNewArticulo.Location = New System.Drawing.Point(0, 0)
        Me.btnNewArticulo.Name = "btnNewArticulo"
        Me.btnNewArticulo.Padding = New System.Windows.Forms.Padding(44, 0, 0, 0)
        Me.btnNewArticulo.Rotation = 0R
        Me.btnNewArticulo.Size = New System.Drawing.Size(186, 29)
        Me.btnNewArticulo.TabIndex = 0
        Me.btnNewArticulo.Text = "- Nuevo articulo"
        Me.btnNewArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewArticulo.UseVisualStyleBackColor = True
        '
        'btnArticulos
        '
        Me.btnArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnArticulos.FlatAppearance.BorderSize = 0
        Me.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArticulos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnArticulos.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArticulos.ForeColor = System.Drawing.Color.White
        Me.btnArticulos.IconChar = FontAwesome.Sharp.IconChar.Hammer
        Me.btnArticulos.IconColor = System.Drawing.Color.White
        Me.btnArticulos.IconSize = 22
        Me.btnArticulos.Location = New System.Drawing.Point(0, 115)
        Me.btnArticulos.Margin = New System.Windows.Forms.Padding(0)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Rotation = 0R
        Me.btnArticulos.Size = New System.Drawing.Size(186, 30)
        Me.btnArticulos.TabIndex = 4
        Me.btnArticulos.Text = " Articulos"
        Me.btnArticulos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnArticulos.UseVisualStyleBackColor = False
        '
        'frmMain_Material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.PanelFormularios)
        Me.Controls.Add(Me.PanelIzquierdo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1022, 540)
        Me.Name = "frmMain_Material"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain_Material"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelIzquierdo.ResumeLayout(False)
        Me.PanelVentas.ResumeLayout(False)
        Me.PanelCompras.ResumeLayout(False)
        Me.PanelFichero.ResumeLayout(False)
        Me.PanelInformes.ResumeLayout(False)
        Me.PanelArticulos.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelIzquierdo As Panel
    Friend WithEvents TimerTime As Timer
    Friend WithEvents PanelInformes As Panel
    Friend WithEvents btnListadoVentas As Button
    Friend WithEvents btnListadoArticulos As Button
    Friend WithEvents btnVenta As Button
    Friend WithEvents PanelArticulos As Panel
    Friend WithEvents PanelFichero As Panel
    Friend WithEvents btnClientesContado As Button
    Friend WithEvents btnFicheros As Button
    Friend WithEvents PanelCompras As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PanelVentas As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents PanelFormularios As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnArticulos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInformes As Button
    Friend WithEvents btnPrintPrices As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpArticulo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnNewArticulo As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents lblHora As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
End Class
