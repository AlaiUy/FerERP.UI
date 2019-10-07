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
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PanelIzquierdo = New System.Windows.Forms.Panel()
        Me.PanelInformes = New System.Windows.Forms.Panel()
        Me.btnListadoVentas = New System.Windows.Forms.Button()
        Me.btnListadoArticulos = New System.Windows.Forms.Button()
        Me.btnInformes = New System.Windows.Forms.Button()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.PanelArticulos = New System.Windows.Forms.Panel()
        Me.btnUpArticulo = New System.Windows.Forms.Button()
        Me.btnAddArticulo = New System.Windows.Forms.Button()
        Me.btnImprimirArticulos = New System.Windows.Forms.Button()
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TimerTime = New System.Windows.Forms.Timer(Me.components)
        Me.PanelTop.SuspendLayout()
        Me.PanelIzquierdo.SuspendLayout()
        Me.PanelInformes.SuspendLayout()
        Me.PanelArticulos.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.lblTime)
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Font = New System.Drawing.Font("Poppins", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1022, 43)
        Me.PanelTop.TabIndex = 0
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Poppins", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(25, 0)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(154, 36)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "Label1"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Manager.My.Resources.Resources.icons8_cerrar_ventana_32
        Me.btnCerrar.Location = New System.Drawing.Point(986, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(30, 30)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'PanelIzquierdo
        '
        Me.PanelIzquierdo.AutoScroll = True
        Me.PanelIzquierdo.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelIzquierdo.Controls.Add(Me.PanelInformes)
        Me.PanelIzquierdo.Controls.Add(Me.btnInformes)
        Me.PanelIzquierdo.Controls.Add(Me.btnVenta)
        Me.PanelIzquierdo.Controls.Add(Me.PanelArticulos)
        Me.PanelIzquierdo.Controls.Add(Me.btnArticulos)
        Me.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelIzquierdo.Font = New System.Drawing.Font("Poppins", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelIzquierdo.Location = New System.Drawing.Point(0, 43)
        Me.PanelIzquierdo.Name = "PanelIzquierdo"
        Me.PanelIzquierdo.Size = New System.Drawing.Size(186, 497)
        Me.PanelIzquierdo.TabIndex = 1
        '
        'PanelInformes
        '
        Me.PanelInformes.Controls.Add(Me.btnListadoVentas)
        Me.PanelInformes.Controls.Add(Me.btnListadoArticulos)
        Me.PanelInformes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelInformes.ForeColor = System.Drawing.Color.White
        Me.PanelInformes.Location = New System.Drawing.Point(0, 226)
        Me.PanelInformes.Name = "PanelInformes"
        Me.PanelInformes.Size = New System.Drawing.Size(186, 77)
        Me.PanelInformes.TabIndex = 8
        Me.PanelInformes.Visible = False
        '
        'btnListadoVentas
        '
        Me.btnListadoVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
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
        Me.btnListadoArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
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
        Me.btnInformes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInformes.FlatAppearance.BorderSize = 0
        Me.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInformes.ForeColor = System.Drawing.Color.White
        Me.btnInformes.Location = New System.Drawing.Point(0, 189)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(186, 37)
        Me.btnInformes.TabIndex = 7
        Me.btnInformes.Text = "INFORMES"
        Me.btnInformes.UseVisualStyleBackColor = True
        '
        'btnVenta
        '
        Me.btnVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVenta.FlatAppearance.BorderSize = 0
        Me.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVenta.ForeColor = System.Drawing.Color.White
        Me.btnVenta.Location = New System.Drawing.Point(0, 152)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(186, 37)
        Me.btnVenta.TabIndex = 6
        Me.btnVenta.Text = "NUEVA VENTA"
        Me.btnVenta.UseVisualStyleBackColor = True
        '
        'PanelArticulos
        '
        Me.PanelArticulos.Controls.Add(Me.btnUpArticulo)
        Me.PanelArticulos.Controls.Add(Me.btnAddArticulo)
        Me.PanelArticulos.Controls.Add(Me.btnImprimirArticulos)
        Me.PanelArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelArticulos.ForeColor = System.Drawing.Color.White
        Me.PanelArticulos.Location = New System.Drawing.Point(0, 37)
        Me.PanelArticulos.Name = "PanelArticulos"
        Me.PanelArticulos.Size = New System.Drawing.Size(186, 115)
        Me.PanelArticulos.TabIndex = 5
        Me.PanelArticulos.Visible = False
        '
        'btnUpArticulo
        '
        Me.btnUpArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnUpArticulo.FlatAppearance.BorderSize = 0
        Me.btnUpArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpArticulo.ForeColor = System.Drawing.Color.DarkGray
        Me.btnUpArticulo.Location = New System.Drawing.Point(0, 74)
        Me.btnUpArticulo.Name = "btnUpArticulo"
        Me.btnUpArticulo.Size = New System.Drawing.Size(186, 37)
        Me.btnUpArticulo.TabIndex = 3
        Me.btnUpArticulo.Text = "Modificar Articulo"
        Me.btnUpArticulo.UseVisualStyleBackColor = False
        '
        'btnAddArticulo
        '
        Me.btnAddArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnAddArticulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddArticulo.FlatAppearance.BorderSize = 0
        Me.btnAddArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddArticulo.ForeColor = System.Drawing.Color.DarkGray
        Me.btnAddArticulo.Location = New System.Drawing.Point(0, 37)
        Me.btnAddArticulo.Name = "btnAddArticulo"
        Me.btnAddArticulo.Size = New System.Drawing.Size(186, 37)
        Me.btnAddArticulo.TabIndex = 2
        Me.btnAddArticulo.Text = "Agregar Articulo"
        Me.btnAddArticulo.UseVisualStyleBackColor = False
        '
        'btnImprimirArticulos
        '
        Me.btnImprimirArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnImprimirArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnImprimirArticulos.FlatAppearance.BorderSize = 0
        Me.btnImprimirArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirArticulos.ForeColor = System.Drawing.Color.DarkGray
        Me.btnImprimirArticulos.Location = New System.Drawing.Point(0, 0)
        Me.btnImprimirArticulos.Name = "btnImprimirArticulos"
        Me.btnImprimirArticulos.Size = New System.Drawing.Size(186, 37)
        Me.btnImprimirArticulos.TabIndex = 1
        Me.btnImprimirArticulos.Text = "Imprimir Precios"
        Me.btnImprimirArticulos.UseVisualStyleBackColor = False
        '
        'btnArticulos
        '
        Me.btnArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnArticulos.FlatAppearance.BorderSize = 0
        Me.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArticulos.ForeColor = System.Drawing.Color.White
        Me.btnArticulos.Location = New System.Drawing.Point(0, 0)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(186, 37)
        Me.btnArticulos.TabIndex = 0
        Me.btnArticulos.Text = "ARTICULOS"
        Me.btnArticulos.UseVisualStyleBackColor = True
        '
        'PanelFormularios
        '
        Me.PanelFormularios.Controls.Add(Me.PictureBox1)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(186, 43)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(836, 497)
        Me.PanelFormularios.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.Manager.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(289, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 264)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TimerTime
        '
        Me.TimerTime.Interval = 10
        '
        'frmMain_Material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1022, 540)
        Me.Controls.Add(Me.PanelFormularios)
        Me.Controls.Add(Me.PanelIzquierdo)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1022, 540)
        Me.Name = "frmMain_Material"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain_Material"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelTop.ResumeLayout(False)
        Me.PanelIzquierdo.ResumeLayout(False)
        Me.PanelInformes.ResumeLayout(False)
        Me.PanelArticulos.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelIzquierdo As Panel
    Friend WithEvents btnArticulos As Button
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTime As Label
    Friend WithEvents TimerTime As Timer
    Friend WithEvents PanelInformes As Panel
    Friend WithEvents btnListadoVentas As Button
    Friend WithEvents btnListadoArticulos As Button
    Friend WithEvents btnInformes As Button
    Friend WithEvents btnVenta As Button
    Friend WithEvents PanelArticulos As Panel
    Friend WithEvents btnUpArticulo As Button
    Friend WithEvents btnAddArticulo As Button
    Friend WithEvents btnImprimirArticulos As Button
End Class
