<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNuevaVenta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.dgItemsView = New System.Windows.Forms.DataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGuardarEspera = New System.Windows.Forms.Button()
        Me.btnNuevaVenta = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnBorrarLinea = New System.Windows.Forms.Button()
        Me.btnCantidad = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.LnkSearchItem = New System.Windows.Forms.LinkLabel()
        Me.txtCodArticulo = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.dgItemsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 730)
        Me.Panel1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Panel9)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 66)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1008, 598)
        Me.Panel6.TabIndex = 6
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.dgItemsView)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(886, 598)
        Me.Panel9.TabIndex = 10
        '
        'dgItemsView
        '
        Me.dgItemsView.AllowUserToAddRows = False
        Me.dgItemsView.AllowUserToDeleteRows = False
        Me.dgItemsView.AllowUserToResizeRows = False
        Me.dgItemsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.dgItemsView.BackgroundColor = System.Drawing.Color.White
        Me.dgItemsView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgItemsView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgItemsView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgItemsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgItemsView.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgItemsView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgItemsView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgItemsView.EnableHeadersVisualStyles = False
        Me.dgItemsView.Location = New System.Drawing.Point(0, 0)
        Me.dgItemsView.MultiSelect = False
        Me.dgItemsView.Name = "dgItemsView"
        Me.dgItemsView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgItemsView.RowHeadersVisible = False
        Me.dgItemsView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Transparent
        Me.dgItemsView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgItemsView.RowTemplate.Height = 30
        Me.dgItemsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItemsView.Size = New System.Drawing.Size(886, 598)
        Me.dgItemsView.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Button1)
        Me.Panel7.Controls.Add(Me.btnGuardarEspera)
        Me.Panel7.Controls.Add(Me.btnNuevaVenta)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(886, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(122, 598)
        Me.Panel7.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Manager.My.Resources.JJRecursos.contract
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(5, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 63)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Presupuesto"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'btnGuardarEspera
        '
        Me.btnGuardarEspera.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardarEspera.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnGuardarEspera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarEspera.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarEspera.Image = Global.Manager.My.Resources.JJRecursos.pending
        Me.btnGuardarEspera.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardarEspera.Location = New System.Drawing.Point(5, 144)
        Me.btnGuardarEspera.Name = "btnGuardarEspera"
        Me.btnGuardarEspera.Size = New System.Drawing.Size(109, 61)
        Me.btnGuardarEspera.TabIndex = 7
        Me.btnGuardarEspera.Text = "Guardar"
        Me.btnGuardarEspera.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardarEspera.UseVisualStyleBackColor = False
        Me.btnGuardarEspera.Visible = False
        '
        'btnNuevaVenta
        '
        Me.btnNuevaVenta.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevaVenta.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaVenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaVenta.Image = Global.Manager.My.Resources.JJRecursos.stopwatch
        Me.btnNuevaVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevaVenta.Location = New System.Drawing.Point(5, 5)
        Me.btnNuevaVenta.Name = "btnNuevaVenta"
        Me.btnNuevaVenta.Size = New System.Drawing.Size(109, 64)
        Me.btnNuevaVenta.TabIndex = 4
        Me.btnNuevaVenta.Text = "Espera"
        Me.btnNuevaVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevaVenta.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnBorrarLinea)
        Me.Panel5.Controls.Add(Me.btnCantidad)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 664)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1008, 66)
        Me.Panel5.TabIndex = 5
        '
        'btnBorrarLinea
        '
        Me.btnBorrarLinea.BackColor = System.Drawing.Color.Transparent
        Me.btnBorrarLinea.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBorrarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarLinea.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarLinea.Image = Global.Manager.My.Resources.JJRecursos.eraser
        Me.btnBorrarLinea.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrarLinea.Location = New System.Drawing.Point(136, 3)
        Me.btnBorrarLinea.Name = "btnBorrarLinea"
        Me.btnBorrarLinea.Size = New System.Drawing.Size(119, 59)
        Me.btnBorrarLinea.TabIndex = 11
        Me.btnBorrarLinea.Text = "Borrar Linea"
        Me.btnBorrarLinea.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrarLinea.UseVisualStyleBackColor = False
        '
        'btnCantidad
        '
        Me.btnCantidad.BackColor = System.Drawing.Color.Transparent
        Me.btnCantidad.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCantidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCantidad.Image = Global.Manager.My.Resources.JJRecursos.countdown
        Me.btnCantidad.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCantidad.Location = New System.Drawing.Point(11, 3)
        Me.btnCantidad.Name = "btnCantidad"
        Me.btnCantidad.Size = New System.Drawing.Size(119, 59)
        Me.btnCantidad.TabIndex = 9
        Me.btnCantidad.Text = "Cantidad"
        Me.btnCantidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCantidad.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.GroupBox1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(666, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(340, 64)
        Me.Panel8.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtImporte)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 58)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtImporte
        '
        Me.txtImporte.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(147, 18)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.ReadOnly = True
        Me.txtImporte.Size = New System.Drawing.Size(170, 23)
        Me.txtImporte.TabIndex = 1
        Me.txtImporte.Text = "0,00"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Importe a facturar:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblVendedor)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1008, 66)
        Me.Panel2.TabIndex = 0
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.Location = New System.Drawing.Point(380, 33)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(0, 25)
        Me.lblVendedor.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(577, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(429, 64)
        Me.Panel4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtCantidad)
        Me.Panel3.Controls.Add(Me.LnkSearchItem)
        Me.Panel3.Controls.Add(Me.txtCodArticulo)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(281, 64)
        Me.Panel3.TabIndex = 1
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(218, 35)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(58, 23)
        Me.txtCantidad.TabIndex = 6
        Me.txtCantidad.Text = "1"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LnkSearchItem
        '
        Me.LnkSearchItem.AutoSize = True
        Me.LnkSearchItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkSearchItem.Location = New System.Drawing.Point(71, 13)
        Me.LnkSearchItem.Name = "LnkSearchItem"
        Me.LnkSearchItem.Size = New System.Drawing.Size(92, 16)
        Me.LnkSearchItem.TabIndex = 5
        Me.LnkSearchItem.TabStop = True
        Me.LnkSearchItem.Text = "Buscar articulo"
        '
        'txtCodArticulo
        '
        Me.txtCodArticulo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodArticulo.Location = New System.Drawing.Point(16, 35)
        Me.txtCodArticulo.Name = "txtCodArticulo"
        Me.txtCodArticulo.Size = New System.Drawing.Size(196, 23)
        Me.txtCodArticulo.TabIndex = 4
        '
        'frmNuevaVenta
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmNuevaVenta"
        Me.Text = "frmNuevaVenta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.dgItemsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LnkSearchItem As LinkLabel
    Friend WithEvents txtCodArticulo As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnNuevaVenta As Button
    Friend WithEvents lblVendedor As Label
    Friend WithEvents dgItemsView As DataGridView
    Friend WithEvents btnGuardarEspera As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCantidad As Button
    Friend WithEvents btnBorrarLinea As Button
End Class
