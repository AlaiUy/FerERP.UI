<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpProveedor_Material
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
        Me.txtComentarios = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtNumero = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtCalle = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.btnAddMarca = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtCelular = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtTelefono = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtRut = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtRz = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtNombre = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblcodBarras1 = New System.Windows.Forms.Label()
        Me.lblCodBarras = New System.Windows.Forms.Label()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(793, 28)
        Me.Panel1.TabIndex = 2
        '
        'lblTime
        '
        Me.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTime.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(206, 0)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(431, 28)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "ACTUALIZAR UN PROVEEDOR"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtComentarios
        '
        Me.txtComentarios.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtComentarios.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtComentarios.HintForeColor = System.Drawing.Color.Empty
        Me.txtComentarios.HintText = ""
        Me.txtComentarios.isPassword = False
        Me.txtComentarios.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtComentarios.LineIdleColor = System.Drawing.Color.DarkRed
        Me.txtComentarios.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtComentarios.LineThickness = 3
        Me.txtComentarios.Location = New System.Drawing.Point(559, 154)
        Me.txtComentarios.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(220, 184)
        Me.txtComentarios.TabIndex = 141
        Me.txtComentarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtNumero
        '
        Me.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumero.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNumero.HintForeColor = System.Drawing.Color.Empty
        Me.txtNumero.HintText = ""
        Me.txtNumero.isPassword = False
        Me.txtNumero.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtNumero.LineIdleColor = System.Drawing.Color.DarkRed
        Me.txtNumero.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtNumero.LineThickness = 3
        Me.txtNumero.Location = New System.Drawing.Point(559, 115)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(220, 29)
        Me.txtNumero.TabIndex = 140
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtCalle
        '
        Me.txtCalle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCalle.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCalle.HintForeColor = System.Drawing.Color.Empty
        Me.txtCalle.HintText = ""
        Me.txtCalle.isPassword = False
        Me.txtCalle.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtCalle.LineIdleColor = System.Drawing.Color.DarkRed
        Me.txtCalle.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtCalle.LineThickness = 3
        Me.txtCalle.Location = New System.Drawing.Point(559, 78)
        Me.txtCalle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(220, 29)
        Me.txtCalle.TabIndex = 139
        Me.txtCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "OTROS DATOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(429, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 20)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "NUMERO:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(429, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 20)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "CALLE:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbCategoria
        '
        Me.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(160, 315)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(220, 21)
        Me.cbCategoria.TabIndex = 134
        '
        'btnAddMarca
        '
        Me.btnAddMarca.FlatAppearance.BorderSize = 0
        Me.btnAddMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddMarca.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMarca.Location = New System.Drawing.Point(385, 315)
        Me.btnAddMarca.Name = "btnAddMarca"
        Me.btnAddMarca.Size = New System.Drawing.Size(22, 23)
        Me.btnAddMarca.TabIndex = 133
        Me.btnAddMarca.Text = "+"
        Me.btnAddMarca.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "CATEGORIA:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmail
        '
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.HintForeColor = System.Drawing.Color.Empty
        Me.txtEmail.HintText = ""
        Me.txtEmail.isPassword = False
        Me.txtEmail.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtEmail.LineIdleColor = System.Drawing.Color.DarkRed
        Me.txtEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtEmail.LineThickness = 3
        Me.txtEmail.Location = New System.Drawing.Point(160, 265)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(220, 29)
        Me.txtEmail.TabIndex = 130
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtCelular
        '
        Me.txtCelular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCelular.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCelular.HintForeColor = System.Drawing.Color.Empty
        Me.txtCelular.HintText = ""
        Me.txtCelular.isPassword = False
        Me.txtCelular.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtCelular.LineIdleColor = System.Drawing.Color.DarkRed
        Me.txtCelular.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtCelular.LineThickness = 3
        Me.txtCelular.Location = New System.Drawing.Point(160, 228)
        Me.txtCelular.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(220, 29)
        Me.txtCelular.TabIndex = 129
        Me.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtTelefono
        '
        Me.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefono.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTelefono.HintForeColor = System.Drawing.Color.Empty
        Me.txtTelefono.HintText = ""
        Me.txtTelefono.isPassword = False
        Me.txtTelefono.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtTelefono.LineIdleColor = System.Drawing.Color.DarkRed
        Me.txtTelefono.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtTelefono.LineThickness = 3
        Me.txtTelefono.Location = New System.Drawing.Point(160, 191)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(220, 29)
        Me.txtTelefono.TabIndex = 128
        Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtRut
        '
        Me.txtRut.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRut.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRut.HintForeColor = System.Drawing.Color.Empty
        Me.txtRut.HintText = ""
        Me.txtRut.isPassword = False
        Me.txtRut.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtRut.LineIdleColor = System.Drawing.Color.DarkRed
        Me.txtRut.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtRut.LineThickness = 3
        Me.txtRut.Location = New System.Drawing.Point(160, 154)
        Me.txtRut.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(220, 29)
        Me.txtRut.TabIndex = 127
        Me.txtRut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtRz
        '
        Me.txtRz.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRz.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRz.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRz.HintForeColor = System.Drawing.Color.Empty
        Me.txtRz.HintText = ""
        Me.txtRz.isPassword = False
        Me.txtRz.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtRz.LineIdleColor = System.Drawing.Color.DarkRed
        Me.txtRz.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtRz.LineThickness = 3
        Me.txtRz.Location = New System.Drawing.Point(160, 115)
        Me.txtRz.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRz.Name = "txtRz"
        Me.txtRz.Size = New System.Drawing.Size(220, 29)
        Me.txtRz.TabIndex = 126
        Me.txtRz.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.txtNombre.Location = New System.Drawing.Point(160, 78)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(220, 29)
        Me.txtNombre.TabIndex = 125
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblModelo
        '
        Me.lblModelo.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.Location = New System.Drawing.Point(41, 265)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(112, 20)
        Me.lblModelo.TabIndex = 124
        Me.lblModelo.Text = "EMAIL:"
        Me.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcodBarras1
        '
        Me.lblcodBarras1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodBarras1.Location = New System.Drawing.Point(40, 228)
        Me.lblcodBarras1.Name = "lblcodBarras1"
        Me.lblcodBarras1.Size = New System.Drawing.Size(113, 20)
        Me.lblcodBarras1.TabIndex = 123
        Me.lblcodBarras1.Text = "CELULAR:"
        Me.lblcodBarras1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCodBarras
        '
        Me.lblCodBarras.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodBarras.Location = New System.Drawing.Point(37, 191)
        Me.lblCodBarras.Name = "lblCodBarras"
        Me.lblCodBarras.Size = New System.Drawing.Size(116, 20)
        Me.lblCodBarras.TabIndex = 122
        Me.lblCodBarras.Text = "TELEFONO:"
        Me.lblCodBarras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReferencia
        '
        Me.lblReferencia.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReferencia.Location = New System.Drawing.Point(10, 154)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(143, 20)
        Me.lblReferencia.TabIndex = 121
        Me.lblReferencia.Text = "RUT:"
        Me.lblReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(30, 115)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(123, 20)
        Me.lblDescripcion.TabIndex = 120
        Me.lblDescripcion.Text = "RAZON SOLCIAL:"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(30, 87)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(123, 20)
        Me.lblNombre.TabIndex = 119
        Me.lblNombre.Text = "NOMBRE:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Sync
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 32
        Me.IconButton1.Location = New System.Drawing.Point(759, 649)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(30, 33)
        Me.IconButton1.TabIndex = 142
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.IconButton2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(793, 32)
        Me.Panel2.TabIndex = 143
        '
        'IconButton2
        '
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconButton2.IconColor = System.Drawing.Color.Blue
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 20
        Me.IconButton2.Location = New System.Drawing.Point(6, 4)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(29, 23)
        Me.IconButton2.TabIndex = 0
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'frmUpProveedor_Material
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(793, 685)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.txtComentarios)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbCategoria)
        Me.Controls.Add(Me.btnAddMarca)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.txtRz)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.lblcodBarras1)
        Me.Controls.Add(Me.lblCodBarras)
        Me.Controls.Add(Me.lblReferencia)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpProveedor_Material"
        Me.Text = "frmUpProveedor_Material"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents txtComentarios As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtNumero As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtCalle As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbCategoria As ComboBox
    Friend WithEvents btnAddMarca As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtCelular As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtTelefono As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtRut As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtRz As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtNombre As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblModelo As Label
    Friend WithEvents lblcodBarras1 As Label
    Friend WithEvents lblCodBarras As Label
    Friend WithEvents lblReferencia As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
End Class
