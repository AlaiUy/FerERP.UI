<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosFactura
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.grp_DatosCuenta = New System.Windows.Forms.GroupBox()
        Me.txtAdenda = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDirEnvio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grp_personales = New System.Windows.Forms.GroupBox()
        Me.Panel_Datos = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.brnFiltro = New System.Windows.Forms.Button()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.grp_DatosCuenta.SuspendLayout()
        Me.grp_personales.SuspendLayout()
        Me.Panel_Datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.grp_DatosCuenta)
        Me.Panel1.Controls.Add(Me.grp_personales)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(677, 473)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnContinuar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 427)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(677, 46)
        Me.Panel2.TabIndex = 2
        '
        'btnContinuar
        '
        Me.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinuar.Location = New System.Drawing.Point(589, 3)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(75, 40)
        Me.btnContinuar.TabIndex = 14
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'grp_DatosCuenta
        '
        Me.grp_DatosCuenta.Controls.Add(Me.txtAdenda)
        Me.grp_DatosCuenta.Controls.Add(Me.Label7)
        Me.grp_DatosCuenta.Controls.Add(Me.txtDirEnvio)
        Me.grp_DatosCuenta.Controls.Add(Me.Label4)
        Me.grp_DatosCuenta.Location = New System.Drawing.Point(12, 260)
        Me.grp_DatosCuenta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grp_DatosCuenta.Name = "grp_DatosCuenta"
        Me.grp_DatosCuenta.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grp_DatosCuenta.Size = New System.Drawing.Size(652, 160)
        Me.grp_DatosCuenta.TabIndex = 1
        Me.grp_DatosCuenta.TabStop = False
        Me.grp_DatosCuenta.Text = "--------- Datos de envio ----------"
        '
        'txtAdenda
        '
        Me.txtAdenda.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdenda.Location = New System.Drawing.Point(219, 67)
        Me.txtAdenda.Multiline = True
        Me.txtAdenda.Name = "txtAdenda"
        Me.txtAdenda.Size = New System.Drawing.Size(345, 81)
        Me.txtAdenda.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(136, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 19)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Adenda:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDirEnvio
        '
        Me.txtDirEnvio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirEnvio.Location = New System.Drawing.Point(219, 28)
        Me.txtDirEnvio.Name = "txtDirEnvio"
        Me.txtDirEnvio.Size = New System.Drawing.Size(345, 27)
        Me.txtDirEnvio.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 19)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Direccion de envio:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grp_personales
        '
        Me.grp_personales.Controls.Add(Me.Panel_Datos)
        Me.grp_personales.Location = New System.Drawing.Point(12, 11)
        Me.grp_personales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grp_personales.Name = "grp_personales"
        Me.grp_personales.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grp_personales.Size = New System.Drawing.Size(652, 241)
        Me.grp_personales.TabIndex = 0
        Me.grp_personales.TabStop = False
        Me.grp_personales.Text = "  Datos personales  "
        '
        'Panel_Datos
        '
        Me.Panel_Datos.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel_Datos.Controls.Add(Me.btnClear)
        Me.Panel_Datos.Controls.Add(Me.txtTelefono)
        Me.Panel_Datos.Controls.Add(Me.Label6)
        Me.Panel_Datos.Controls.Add(Me.txtDireccion)
        Me.Panel_Datos.Controls.Add(Me.Label5)
        Me.Panel_Datos.Controls.Add(Me.txtDocumento)
        Me.Panel_Datos.Controls.Add(Me.Label3)
        Me.Panel_Datos.Controls.Add(Me.txtNombre)
        Me.Panel_Datos.Controls.Add(Me.Label2)
        Me.Panel_Datos.Controls.Add(Me.brnFiltro)
        Me.Panel_Datos.Controls.Add(Me.txtIdCliente)
        Me.Panel_Datos.Controls.Add(Me.Label1)
        Me.Panel_Datos.Location = New System.Drawing.Point(64, 23)
        Me.Panel_Datos.Name = "Panel_Datos"
        Me.Panel_Datos.Size = New System.Drawing.Size(525, 211)
        Me.Panel_Datos.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(349, 167)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(121, 26)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Borrar Datos"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(120, 168)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(223, 27)
        Me.txtTelefono.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 19)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Telefono:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(120, 132)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(223, 27)
        Me.txtDireccion.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 19)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Direccion:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDocumento
        '
        Me.txtDocumento.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumento.Location = New System.Drawing.Point(120, 96)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(223, 27)
        Me.txtDocumento.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "C.I / RUT:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(120, 57)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(223, 27)
        Me.txtNombre.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nombre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'brnFiltro
        '
        Me.brnFiltro.BackColor = System.Drawing.Color.White
        Me.brnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brnFiltro.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brnFiltro.Location = New System.Drawing.Point(349, 16)
        Me.brnFiltro.Name = "brnFiltro"
        Me.brnFiltro.Size = New System.Drawing.Size(75, 26)
        Me.brnFiltro.TabIndex = 15
        Me.brnFiltro.Text = "Buscar"
        Me.brnFiltro.UseVisualStyleBackColor = False
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCliente.Location = New System.Drawing.Point(120, 16)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(223, 27)
        Me.txtIdCliente.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(41, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Cliente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmDatosFactura
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(677, 473)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmDatosFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDatosFactura"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.grp_DatosCuenta.ResumeLayout(False)
        Me.grp_DatosCuenta.PerformLayout()
        Me.grp_personales.ResumeLayout(False)
        Me.Panel_Datos.ResumeLayout(False)
        Me.Panel_Datos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents grp_DatosCuenta As GroupBox
    Friend WithEvents grp_personales As GroupBox
    Friend WithEvents btnContinuar As Button
    Friend WithEvents Panel_Datos As Panel
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents brnFiltro As Button
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAdenda As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDirEnvio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClear As Button
End Class
