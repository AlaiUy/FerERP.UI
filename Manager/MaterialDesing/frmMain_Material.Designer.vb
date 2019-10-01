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
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.PanelArticulos = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnAddArticulo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TimerTime = New System.Windows.Forms.Timer(Me.components)
        Me.PanelTop.SuspendLayout()
        Me.PanelIzquierdo.SuspendLayout()
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
        Me.PanelIzquierdo.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelIzquierdo.Controls.Add(Me.btnArticulos)
        Me.PanelIzquierdo.Controls.Add(Me.PanelArticulos)
        Me.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelIzquierdo.Font = New System.Drawing.Font("Poppins", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelIzquierdo.Location = New System.Drawing.Point(0, 43)
        Me.PanelIzquierdo.Name = "PanelIzquierdo"
        Me.PanelIzquierdo.Size = New System.Drawing.Size(186, 497)
        Me.PanelIzquierdo.TabIndex = 1
        '
        'btnArticulos
        '
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
        'PanelArticulos
        '
        Me.PanelArticulos.Controls.Add(Me.Button4)
        Me.PanelArticulos.Controls.Add(Me.btnAddArticulo)
        Me.PanelArticulos.Controls.Add(Me.Button2)
        Me.PanelArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelArticulos.ForeColor = System.Drawing.Color.White
        Me.PanelArticulos.Location = New System.Drawing.Point(0, 0)
        Me.PanelArticulos.Name = "PanelArticulos"
        Me.PanelArticulos.Size = New System.Drawing.Size(186, 150)
        Me.PanelArticulos.TabIndex = 1
        Me.PanelArticulos.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.DarkGray
        Me.Button4.Location = New System.Drawing.Point(0, 74)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(186, 37)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Modificar Articulo"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnAddArticulo
        '
        Me.btnAddArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
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
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.DarkGray
        Me.Button2.Location = New System.Drawing.Point(0, 111)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(186, 37)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Imprimir Precios"
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.PanelArticulos.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelIzquierdo As Panel
    Friend WithEvents btnArticulos As Button
    Friend WithEvents PanelArticulos As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents btnAddArticulo As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTime As Label
    Friend WithEvents TimerTime As Timer
End Class
