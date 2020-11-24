<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCompras
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.dgCompras = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnIngresarCompra = New System.Windows.Forms.Button()
        Me.btnDescuentoTotal = New System.Windows.Forms.Button()
        Me.btnDescuentoLineal = New System.Windows.Forms.Button()
        Me.btnBorrarLinea = New System.Windows.Forms.Button()
        Me.btnCantidad = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtNumeroP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSerieP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMonedas = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.LinkArticulos = New System.Windows.Forms.LinkLabel()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkProveedor = New System.Windows.Forms.LinkLabel()
        Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodProveedor = New System.Windows.Forms.TextBox()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.StatusBarLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.dgCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1095, 730)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel9)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 105)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1095, 484)
        Me.Panel4.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel9.Controls.Add(Me.dgCompras)
        Me.Panel9.Location = New System.Drawing.Point(3, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1089, 476)
        Me.Panel9.TabIndex = 0
        '
        'dgCompras
        '
        Me.dgCompras.AllowUserToAddRows = False
        Me.dgCompras.AllowUserToDeleteRows = False
        Me.dgCompras.AllowUserToResizeRows = False
        Me.dgCompras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.dgCompras.BackgroundColor = System.Drawing.Color.White
        Me.dgCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCompras.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgCompras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgCompras.EnableHeadersVisualStyles = False
        Me.dgCompras.Location = New System.Drawing.Point(4, 4)
        Me.dgCompras.MultiSelect = False
        Me.dgCompras.Name = "dgCompras"
        Me.dgCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgCompras.RowHeadersVisible = False
        Me.dgCompras.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Transparent
        Me.dgCompras.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCompras.RowTemplate.Height = 30
        Me.dgCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgCompras.Size = New System.Drawing.Size(1082, 469)
        Me.dgCompras.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 589)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1095, 141)
        Me.Panel3.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Controls.Add(Me.btnDescuentoTotal)
        Me.Panel7.Controls.Add(Me.btnDescuentoLineal)
        Me.Panel7.Controls.Add(Me.btnBorrarLinea)
        Me.Panel7.Controls.Add(Me.btnCantidad)
        Me.Panel7.Location = New System.Drawing.Point(5, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(818, 114)
        Me.Panel7.TabIndex = 17
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.GroupBox2)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(608, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(210, 114)
        Me.Panel10.TabIndex = 21
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblInfo)
        Me.GroupBox2.Controls.Add(Me.btnIngresarCompra)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Facturacion"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(14, 35)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(0, 16)
        Me.lblInfo.TabIndex = 26
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnIngresarCompra
        '
        Me.btnIngresarCompra.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresarCompra.FlatAppearance.BorderSize = 0
        Me.btnIngresarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresarCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarCompra.Image = Global.Manager.My.Resources.JJRecursos.Facturar24px
        Me.btnIngresarCompra.Location = New System.Drawing.Point(6, 66)
        Me.btnIngresarCompra.Name = "btnIngresarCompra"
        Me.btnIngresarCompra.Size = New System.Drawing.Size(36, 28)
        Me.btnIngresarCompra.TabIndex = 25
        Me.btnIngresarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIngresarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnIngresarCompra.UseVisualStyleBackColor = False
        '
        'btnDescuentoTotal
        '
        Me.btnDescuentoTotal.BackColor = System.Drawing.Color.White
        Me.btnDescuentoTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDescuentoTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescuentoTotal.Image = Global.Manager.My.Resources.JJRecursos.Descuento24px
        Me.btnDescuentoTotal.Location = New System.Drawing.Point(330, 4)
        Me.btnDescuentoTotal.Name = "btnDescuentoTotal"
        Me.btnDescuentoTotal.Size = New System.Drawing.Size(104, 52)
        Me.btnDescuentoTotal.TabIndex = 20
        Me.btnDescuentoTotal.Text = "Descuento Total"
        Me.btnDescuentoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDescuentoTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDescuentoTotal.UseVisualStyleBackColor = False
        Me.btnDescuentoTotal.Visible = False
        '
        'btnDescuentoLineal
        '
        Me.btnDescuentoLineal.BackColor = System.Drawing.Color.White
        Me.btnDescuentoLineal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDescuentoLineal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescuentoLineal.Image = Global.Manager.My.Resources.JJRecursos.Lineal24px
        Me.btnDescuentoLineal.Location = New System.Drawing.Point(219, 4)
        Me.btnDescuentoLineal.Name = "btnDescuentoLineal"
        Me.btnDescuentoLineal.Size = New System.Drawing.Size(105, 52)
        Me.btnDescuentoLineal.TabIndex = 19
        Me.btnDescuentoLineal.Text = "Descuento Lineal"
        Me.btnDescuentoLineal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDescuentoLineal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDescuentoLineal.UseVisualStyleBackColor = False
        Me.btnDescuentoLineal.Visible = False
        '
        'btnBorrarLinea
        '
        Me.btnBorrarLinea.BackColor = System.Drawing.Color.White
        Me.btnBorrarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarLinea.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarLinea.Image = Global.Manager.My.Resources.JJRecursos.Borrar24px
        Me.btnBorrarLinea.Location = New System.Drawing.Point(112, 4)
        Me.btnBorrarLinea.Name = "btnBorrarLinea"
        Me.btnBorrarLinea.Size = New System.Drawing.Size(99, 52)
        Me.btnBorrarLinea.TabIndex = 18
        Me.btnBorrarLinea.Text = "Borrar Linea"
        Me.btnBorrarLinea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrarLinea.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnBorrarLinea.UseVisualStyleBackColor = False
        '
        'btnCantidad
        '
        Me.btnCantidad.BackColor = System.Drawing.Color.White
        Me.btnCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCantidad.Image = Global.Manager.My.Resources.JJRecursos.Cambiar24px
        Me.btnCantidad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCantidad.Location = New System.Drawing.Point(6, 4)
        Me.btnCantidad.Name = "btnCantidad"
        Me.btnCantidad.Size = New System.Drawing.Size(100, 52)
        Me.btnCantidad.TabIndex = 17
        Me.btnCantidad.Text = "Cambiar Cantidad"
        Me.btnCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCantidad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnCantidad.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(829, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(266, 141)
        Me.Panel6.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.MistyRose
        Me.Panel8.Controls.Add(Me.txtFinal)
        Me.Panel8.Controls.Add(Me.txtIva)
        Me.Panel8.Controls.Add(Me.txtSubTotal)
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Location = New System.Drawing.Point(5, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(258, 114)
        Me.Panel8.TabIndex = 0
        '
        'txtFinal
        '
        Me.txtFinal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinal.Location = New System.Drawing.Point(102, 78)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(150, 30)
        Me.txtFinal.TabIndex = 15
        Me.txtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIva
        '
        Me.txtIva.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva.Location = New System.Drawing.Point(102, 44)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(150, 30)
        Me.txtIva.TabIndex = 13
        Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(102, 10)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(150, 30)
        Me.txtSubTotal.TabIndex = 12
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 26)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "TOTAL:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 28)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Iva:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Subtotal:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.Panel11)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1095, 105)
        Me.Panel2.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtNumeroP)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtSerieP)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cbMonedas)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(329, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(267, 99)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "De factura de proveedor"
        '
        'txtNumeroP
        '
        Me.txtNumeroP.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroP.Location = New System.Drawing.Point(78, 46)
        Me.txtNumeroP.Name = "txtNumeroP"
        Me.txtNumeroP.Size = New System.Drawing.Size(89, 22)
        Me.txtNumeroP.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 14)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Numero:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSerieP
        '
        Me.txtSerieP.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieP.Location = New System.Drawing.Point(78, 19)
        Me.txtSerieP.Name = "txtSerieP"
        Me.txtSerieP.Size = New System.Drawing.Size(89, 22)
        Me.txtSerieP.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 14)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Serie:"
        '
        'cbMonedas
        '
        Me.cbMonedas.FormattingEnabled = True
        Me.cbMonedas.Location = New System.Drawing.Point(78, 75)
        Me.cbMonedas.Name = "cbMonedas"
        Me.cbMonedas.Size = New System.Drawing.Size(172, 21)
        Me.cbMonedas.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 14)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Moneda:"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.txtCantidad)
        Me.Panel11.Controls.Add(Me.LinkArticulos)
        Me.Panel11.Controls.Add(Me.txtReferencia)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(323, 105)
        Me.Panel11.TabIndex = 8
        '
        'txtCantidad
        '
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(241, 15)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(76, 30)
        Me.txtCantidad.TabIndex = 9
        Me.txtCantidad.Text = "1"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LinkArticulos
        '
        Me.LinkArticulos.AutoSize = True
        Me.LinkArticulos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkArticulos.ForeColor = System.Drawing.Color.Blue
        Me.LinkArticulos.LinkColor = System.Drawing.Color.Blue
        Me.LinkArticulos.Location = New System.Drawing.Point(6, 23)
        Me.LinkArticulos.Name = "LinkArticulos"
        Me.LinkArticulos.Size = New System.Drawing.Size(64, 16)
        Me.LinkArticulos.TabIndex = 8
        Me.LinkArticulos.TabStop = True
        Me.LinkArticulos.Text = "Articulo:"
        '
        'txtReferencia
        '
        Me.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReferencia.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia.Location = New System.Drawing.Point(76, 15)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(159, 30)
        Me.txtReferencia.TabIndex = 7
        Me.txtReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GroupBox1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(695, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(400, 105)
        Me.Panel5.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LinkProveedor)
        Me.GroupBox1.Controls.Add(Me.txtNombreProveedor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCodProveedor)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de proveedor"
        '
        'LinkProveedor
        '
        Me.LinkProveedor.AutoSize = True
        Me.LinkProveedor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkProveedor.Location = New System.Drawing.Point(28, 26)
        Me.LinkProveedor.Name = "LinkProveedor"
        Me.LinkProveedor.Size = New System.Drawing.Size(70, 14)
        Me.LinkProveedor.TabIndex = 9
        Me.LinkProveedor.TabStop = True
        Me.LinkProveedor.Text = "Proveedor"
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProveedor.Location = New System.Drawing.Point(104, 54)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.ReadOnly = True
        Me.txtNombreProveedor.Size = New System.Drawing.Size(278, 27)
        Me.txtNombreProveedor.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre:"
        '
        'txtCodProveedor
        '
        Me.txtCodProveedor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProveedor.Location = New System.Drawing.Point(104, 19)
        Me.txtCodProveedor.Name = "txtCodProveedor"
        Me.txtCodProveedor.Size = New System.Drawing.Size(278, 27)
        Me.txtCodProveedor.TabIndex = 6
        '
        'StatusBar
        '
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBarLabel})
        Me.StatusBar.Location = New System.Drawing.Point(0, 708)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(1095, 22)
        Me.StatusBar.TabIndex = 1
        '
        'StatusBarLabel
        '
        Me.StatusBarLabel.Name = "StatusBarLabel"
        Me.StatusBarLabel.Size = New System.Drawing.Size(121, 17)
        Me.StatusBarLabel.Text = "ToolStripStatusLabel1"
        '
        'frmCompras
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1095, 730)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "frmCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCompras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.dgCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnDescuentoTotal As Button
    Friend WithEvents btnDescuentoLineal As Button
    Friend WithEvents btnBorrarLinea As Button
    Friend WithEvents btnCantidad As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtFinal As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIva As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents dgCompras As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents LinkArticulos As LinkLabel
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents StatusBar As StatusStrip
    Friend WithEvents StatusBarLabel As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LinkProveedor As LinkLabel
    Friend WithEvents txtNombreProveedor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodProveedor As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtNumeroP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSerieP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbMonedas As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnIngresarCompra As Button
End Class
