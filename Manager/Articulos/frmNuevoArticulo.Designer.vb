﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoArticulo
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
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbDatos = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAddSeccion = New System.Windows.Forms.Button()
        Me.btnAddDepto = New System.Windows.Forms.Button()
        Me.btnAddMarca = New System.Windows.Forms.Button()
        Me.cbSeccion = New System.Windows.Forms.ComboBox()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cbMarca = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.txtCodBarras1 = New System.Windows.Forms.TextBox()
        Me.lblcodBarras1 = New System.Windows.Forms.Label()
        Me.txtCodBarras = New System.Windows.Forms.TextBox()
        Me.lblCodBarras = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMoneda = New System.Windows.Forms.ComboBox()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.txtGanancia = New System.Windows.Forms.TextBox()
        Me.lblGanancia = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PanelContainer.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbDatos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelContainer.BackColor = System.Drawing.Color.White
        Me.PanelContainer.Controls.Add(Me.Panel3)
        Me.PanelContainer.Controls.Add(Me.Panel2)
        Me.PanelContainer.Controls.Add(Me.Panel1)
        Me.PanelContainer.Location = New System.Drawing.Point(2, 2)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(861, 523)
        Me.PanelContainer.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TabControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(861, 445)
        Me.Panel3.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.tbDatos)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(859, 443)
        Me.TabControl1.TabIndex = 0
        '
        'tbDatos
        '
        Me.tbDatos.BackColor = System.Drawing.Color.White
        Me.tbDatos.Controls.Add(Me.GroupBox2)
        Me.tbDatos.Controls.Add(Me.GroupBox1)
        Me.tbDatos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDatos.Location = New System.Drawing.Point(4, 25)
        Me.tbDatos.Name = "tbDatos"
        Me.tbDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDatos.Size = New System.Drawing.Size(851, 414)
        Me.tbDatos.TabIndex = 0
        Me.tbDatos.Text = "DATOS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAddSeccion)
        Me.GroupBox2.Controls.Add(Me.btnAddDepto)
        Me.GroupBox2.Controls.Add(Me.btnAddMarca)
        Me.GroupBox2.Controls.Add(Me.cbSeccion)
        Me.GroupBox2.Controls.Add(Me.cbDepartamento)
        Me.GroupBox2.Controls.Add(Me.cbMarca)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtModelo)
        Me.GroupBox2.Controls.Add(Me.lblModelo)
        Me.GroupBox2.Controls.Add(Me.txtCodBarras1)
        Me.GroupBox2.Controls.Add(Me.lblcodBarras1)
        Me.GroupBox2.Controls.Add(Me.txtCodBarras)
        Me.GroupBox2.Controls.Add(Me.lblCodBarras)
        Me.GroupBox2.Controls.Add(Me.txtReferencia)
        Me.GroupBox2.Controls.Add(Me.lblReferencia)
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.lblDescripcion)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.lblNombre)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 350)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'btnAddSeccion
        '
        Me.btnAddSeccion.Location = New System.Drawing.Point(357, 313)
        Me.btnAddSeccion.Name = "btnAddSeccion"
        Me.btnAddSeccion.Size = New System.Drawing.Size(22, 23)
        Me.btnAddSeccion.TabIndex = 54
        Me.btnAddSeccion.Text = "+"
        Me.btnAddSeccion.UseVisualStyleBackColor = True
        '
        'btnAddDepto
        '
        Me.btnAddDepto.Location = New System.Drawing.Point(357, 275)
        Me.btnAddDepto.Name = "btnAddDepto"
        Me.btnAddDepto.Size = New System.Drawing.Size(22, 23)
        Me.btnAddDepto.TabIndex = 53
        Me.btnAddDepto.Text = "+"
        Me.btnAddDepto.UseVisualStyleBackColor = True
        '
        'btnAddMarca
        '
        Me.btnAddMarca.Location = New System.Drawing.Point(357, 240)
        Me.btnAddMarca.Name = "btnAddMarca"
        Me.btnAddMarca.Size = New System.Drawing.Size(22, 23)
        Me.btnAddMarca.TabIndex = 52
        Me.btnAddMarca.Text = "+"
        Me.btnAddMarca.UseVisualStyleBackColor = True
        '
        'cbSeccion
        '
        Me.cbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSeccion.FormattingEnabled = True
        Me.cbSeccion.Location = New System.Drawing.Point(143, 313)
        Me.cbSeccion.Name = "cbSeccion"
        Me.cbSeccion.Size = New System.Drawing.Size(208, 24)
        Me.cbSeccion.TabIndex = 51
        '
        'cbDepartamento
        '
        Me.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(143, 275)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(208, 24)
        Me.cbDepartamento.TabIndex = 50
        '
        'cbMarca
        '
        Me.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.Location = New System.Drawing.Point(143, 239)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(208, 24)
        Me.cbMarca.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "SECCION:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "DEPARTAMENTO:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "MARCA:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(143, 201)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(208, 23)
        Me.txtModelo.TabIndex = 45
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(75, 204)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(62, 16)
        Me.lblModelo.TabIndex = 44
        Me.lblModelo.Text = "MODELO:"
        Me.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodBarras1
        '
        Me.txtCodBarras1.Location = New System.Drawing.Point(143, 166)
        Me.txtCodBarras1.Name = "txtCodBarras1"
        Me.txtCodBarras1.Size = New System.Drawing.Size(208, 23)
        Me.txtCodBarras1.TabIndex = 43
        '
        'lblcodBarras1
        '
        Me.lblcodBarras1.AutoSize = True
        Me.lblcodBarras1.Location = New System.Drawing.Point(8, 167)
        Me.lblcodBarras1.Name = "lblcodBarras1"
        Me.lblcodBarras1.Size = New System.Drawing.Size(129, 16)
        Me.lblcodBarras1.TabIndex = 42
        Me.lblcodBarras1.Text = "CODIGO DE BARRAS:"
        Me.lblcodBarras1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodBarras
        '
        Me.txtCodBarras.Location = New System.Drawing.Point(143, 131)
        Me.txtCodBarras.Name = "txtCodBarras"
        Me.txtCodBarras.Size = New System.Drawing.Size(208, 23)
        Me.txtCodBarras.TabIndex = 41
        '
        'lblCodBarras
        '
        Me.lblCodBarras.AutoSize = True
        Me.lblCodBarras.Location = New System.Drawing.Point(8, 132)
        Me.lblCodBarras.Name = "lblCodBarras"
        Me.lblCodBarras.Size = New System.Drawing.Size(129, 16)
        Me.lblCodBarras.TabIndex = 40
        Me.lblCodBarras.Text = "CODIGO DE BARRAS:"
        Me.lblCodBarras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(143, 99)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(208, 23)
        Me.txtReferencia.TabIndex = 39
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Location = New System.Drawing.Point(52, 102)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(85, 16)
        Me.lblReferencia.TabIndex = 38
        Me.lblReferencia.Text = "REFERENCIA:"
        Me.lblReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(143, 68)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(208, 23)
        Me.txtDescripcion.TabIndex = 37
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(45, 71)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(92, 16)
        Me.lblDescripcion.TabIndex = 36
        Me.lblDescripcion.Text = "DESCRIPCION:"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(143, 34)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(208, 23)
        Me.txtNombre.TabIndex = 35
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(75, 37)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(62, 16)
        Me.lblNombre.TabIndex = 34
        Me.lblNombre.Text = "NOMBRE:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIva)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbMoneda)
        Me.GroupBox1.Controls.Add(Me.lblMoneda)
        Me.GroupBox1.Controls.Add(Me.txtGanancia)
        Me.GroupBox1.Controls.Add(Me.lblGanancia)
        Me.GroupBox1.Controls.Add(Me.txtCosto)
        Me.GroupBox1.Controls.Add(Me.lblPrecio)
        Me.GroupBox1.Location = New System.Drawing.Point(426, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 185)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo precio de venta"
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(89, 138)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(208, 23)
        Me.txtIva.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "IVA:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbMoneda
        '
        Me.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMoneda.FormattingEnabled = True
        Me.cbMoneda.Location = New System.Drawing.Point(89, 98)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Size = New System.Drawing.Size(208, 24)
        Me.cbMoneda.TabIndex = 25
        '
        'lblMoneda
        '
        Me.lblMoneda.Location = New System.Drawing.Point(9, 99)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(74, 21)
        Me.lblMoneda.TabIndex = 24
        Me.lblMoneda.Text = "MONEDA:"
        Me.lblMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGanancia
        '
        Me.txtGanancia.Location = New System.Drawing.Point(89, 62)
        Me.txtGanancia.Name = "txtGanancia"
        Me.txtGanancia.Size = New System.Drawing.Size(208, 23)
        Me.txtGanancia.TabIndex = 23
        '
        'lblGanancia
        '
        Me.lblGanancia.Location = New System.Drawing.Point(6, 61)
        Me.lblGanancia.Name = "lblGanancia"
        Me.lblGanancia.Size = New System.Drawing.Size(77, 20)
        Me.lblGanancia.TabIndex = 22
        Me.lblGanancia.Text = "GANANCIA:"
        Me.lblGanancia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(89, 31)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(208, 23)
        Me.txtCosto.TabIndex = 21
        '
        'lblPrecio
        '
        Me.lblPrecio.Location = New System.Drawing.Point(15, 30)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(68, 20)
        Me.lblPrecio.TabIndex = 20
        Me.lblPrecio.Text = "COSTO:"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 485)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(861, 38)
        Me.Panel2.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(772, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(87, 36)
        Me.Panel4.TabIndex = 31
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(3, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 31
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(861, 40)
        Me.Panel1.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(229, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(242, 19)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "REGISTRO DE UN ARTICULO"
        '
        'frmNuevoArticulo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(864, 527)
        Me.Controls.Add(Me.PanelContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmNuevoArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNuevoArticulo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelContainer.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tbDatos.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContainer As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbDatos As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAddSeccion As Button
    Friend WithEvents btnAddDepto As Button
    Friend WithEvents btnAddMarca As Button
    Friend WithEvents cbSeccion As ComboBox
    Friend WithEvents cbDepartamento As ComboBox
    Friend WithEvents cbMarca As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents lblModelo As Label
    Friend WithEvents txtCodBarras1 As TextBox
    Friend WithEvents lblcodBarras1 As Label
    Friend WithEvents txtCodBarras As TextBox
    Friend WithEvents lblCodBarras As Label
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents lblReferencia As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIva As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbMoneda As ComboBox
    Friend WithEvents lblMoneda As Label
    Friend WithEvents txtGanancia As TextBox
    Friend WithEvents lblGanancia As Label
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnSave As Button
End Class
