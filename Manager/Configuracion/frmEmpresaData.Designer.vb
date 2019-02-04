<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpresaData
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
        Me.Save = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabEmpresa = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnBuscarLogo = New System.Windows.Forms.Button()
        Me.LogoBox = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRazon = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FileOpen = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabEmpresa.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Save)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1025, 80)
        Me.Panel1.TabIndex = 0
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.White
        Me.Save.Image = Global.Manager.My.Resources.JJRecursos.save
        Me.Save.Location = New System.Drawing.Point(9, 7)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 70)
        Me.Save.TabIndex = 17
        Me.Save.Text = "Guardar"
        Me.Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Save.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.TabEmpresa)
        Me.Panel2.Location = New System.Drawing.Point(0, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1025, 398)
        Me.Panel2.TabIndex = 0
        '
        'TabEmpresa
        '
        Me.TabEmpresa.Controls.Add(Me.TabPage1)
        Me.TabEmpresa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabEmpresa.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabEmpresa.Location = New System.Drawing.Point(0, 0)
        Me.TabEmpresa.Name = "TabEmpresa"
        Me.TabEmpresa.SelectedIndex = 0
        Me.TabEmpresa.Size = New System.Drawing.Size(1025, 398)
        Me.TabEmpresa.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtPais)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtTelefono)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.txtCiudad)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtDireccion)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtRut)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtRazon)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtNombre)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1017, 367)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Generales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtPais
        '
        Me.txtPais.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPais.Location = New System.Drawing.Point(133, 170)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(330, 26)
        Me.txtPais.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 18)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "PAIS"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(133, 240)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(330, 26)
        Me.txtEmail.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 18)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "EMAIL"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(133, 205)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(330, 26)
        Me.txtTelefono.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "TELEFONO"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnBuscarLogo)
        Me.Panel3.Controls.Add(Me.LogoBox)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(493, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(359, 188)
        Me.Panel3.TabIndex = 10
        '
        'btnBuscarLogo
        '
        Me.btnBuscarLogo.Location = New System.Drawing.Point(278, 35)
        Me.btnBuscarLogo.Name = "btnBuscarLogo"
        Me.btnBuscarLogo.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarLogo.TabIndex = 12
        Me.btnBuscarLogo.Text = "Buscar"
        Me.btnBuscarLogo.UseVisualStyleBackColor = True
        '
        'LogoBox
        '
        Me.LogoBox.Location = New System.Drawing.Point(5, 34)
        Me.LogoBox.Name = "LogoBox"
        Me.LogoBox.Size = New System.Drawing.Size(267, 151)
        Me.LogoBox.TabIndex = 11
        Me.LogoBox.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "LOGO"
        '
        'txtCiudad
        '
        Me.txtCiudad.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiudad.Location = New System.Drawing.Point(133, 138)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(330, 26)
        Me.txtCiudad.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "CIUDAD"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(133, 105)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(330, 26)
        Me.txtDireccion.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "DIRECCION"
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.Location = New System.Drawing.Point(133, 72)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(330, 26)
        Me.txtRut.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "RUT"
        '
        'txtRazon
        '
        Me.txtRazon.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazon.Location = New System.Drawing.Point(133, 38)
        Me.txtRazon.Name = "txtRazon"
        Me.txtRazon.Size = New System.Drawing.Size(330, 26)
        Me.txtRazon.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RAZON SOCIAL"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(133, 6)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(330, 26)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE"
        '
        'FileOpen
        '
        Me.FileOpen.FileName = "OpenFile"
        Me.FileOpen.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|"
        '
        'frmEmpresaData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1026, 486)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEmpresaData"
        Me.Text = "Datos de la Empresa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabEmpresa.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabEmpresa As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Save As Button
    Friend WithEvents txtPais As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LogoBox As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRazon As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscarLogo As Button
    Friend WithEvents FileOpen As OpenFileDialog
End Class
