<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecEspera_Material
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgridLineas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtAdenda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtImporteTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GridEncabezados = New System.Windows.Forms.DataGridView()
        Me.btnRecuperar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.dgridLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GridEncabezados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(135, 140)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(302, 36)
        Me.txtDireccion.TabIndex = 95
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(13, 143)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(99, 28)
        Me.lblDescripcion.TabIndex = 94
        Me.lblDescripcion.Text = "DIRECCION:"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(135, 99)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(302, 36)
        Me.txtNombre.TabIndex = 93
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(13, 102)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(80, 28)
        Me.lblNombre.TabIndex = 92
        Me.lblNombre.Text = "NOMBRE:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDocumento
        '
        Me.txtDocumento.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumento.Location = New System.Drawing.Point(135, 57)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(302, 36)
        Me.txtDocumento.TabIndex = 97
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 28)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "DOCUMENTO:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgridLineas
        '
        Me.dgridLineas.AllowUserToAddRows = False
        Me.dgridLineas.AllowUserToDeleteRows = False
        Me.dgridLineas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgridLineas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgridLineas.BackgroundColor = System.Drawing.Color.White
        Me.dgridLineas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgridLineas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgridLineas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poppins", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgridLineas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgridLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgridLineas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgridLineas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgridLineas.EnableHeadersVisualStyles = False
        Me.dgridLineas.GridColor = System.Drawing.Color.White
        Me.dgridLineas.Location = New System.Drawing.Point(432, 188)
        Me.dgridLineas.Name = "dgridLineas"
        Me.dgridLineas.ReadOnly = True
        Me.dgridLineas.RowHeadersVisible = False
        Me.dgridLineas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgridLineas.Size = New System.Drawing.Size(587, 283)
        Me.dgridLineas.TabIndex = 99
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 37)
        Me.Panel1.TabIndex = 121
        '
        'lblTime
        '
        Me.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTime.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(322, 0)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(402, 36)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "RECUPERAR UN DOCUMENTO"
        '
        'txtAdenda
        '
        Me.txtAdenda.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdenda.Location = New System.Drawing.Point(135, 487)
        Me.txtAdenda.Multiline = True
        Me.txtAdenda.Name = "txtAdenda"
        Me.txtAdenda.Size = New System.Drawing.Size(302, 116)
        Me.txtAdenda.TabIndex = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 490)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 28)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "ADENDA:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtImporteTotal
        '
        Me.txtImporteTotal.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteTotal.Location = New System.Drawing.Point(135, 626)
        Me.txtImporteTotal.Name = "txtImporteTotal"
        Me.txtImporteTotal.Size = New System.Drawing.Size(302, 36)
        Me.txtImporteTotal.TabIndex = 123
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 629)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 28)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "IMPORTE:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GridEncabezados
        '
        Me.GridEncabezados.AllowUserToAddRows = False
        Me.GridEncabezados.AllowUserToDeleteRows = False
        Me.GridEncabezados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridEncabezados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.GridEncabezados.BackgroundColor = System.Drawing.Color.White
        Me.GridEncabezados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridEncabezados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.GridEncabezados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridEncabezados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GridEncabezados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Poppins", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridEncabezados.DefaultCellStyle = DataGridViewCellStyle4
        Me.GridEncabezados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridEncabezados.EnableHeadersVisualStyles = False
        Me.GridEncabezados.GridColor = System.Drawing.Color.White
        Me.GridEncabezados.Location = New System.Drawing.Point(6, 188)
        Me.GridEncabezados.Name = "GridEncabezados"
        Me.GridEncabezados.ReadOnly = True
        Me.GridEncabezados.RowHeadersVisible = False
        Me.GridEncabezados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridEncabezados.Size = New System.Drawing.Size(419, 283)
        Me.GridEncabezados.TabIndex = 98
        '
        'btnRecuperar
        '
        Me.btnRecuperar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecuperar.FlatAppearance.BorderSize = 0
        Me.btnRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecuperar.Image = Global.Manager.My.Resources.Resources.icons8_de_acuerdo_32
        Me.btnRecuperar.Location = New System.Drawing.Point(982, 632)
        Me.btnRecuperar.Name = "btnRecuperar"
        Me.btnRecuperar.Size = New System.Drawing.Size(30, 30)
        Me.btnRecuperar.TabIndex = 126
        Me.btnRecuperar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecuperar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Manager.My.Resources.Resources.icons8_cerrar_ventana_32
        Me.btnCerrar.Location = New System.Drawing.Point(989, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(30, 30)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'frmRecEspera_Material
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1024, 670)
        Me.Controls.Add(Me.btnRecuperar)
        Me.Controls.Add(Me.txtAdenda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtImporteTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgridLineas)
        Me.Controls.Add(Me.GridEncabezados)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Font = New System.Drawing.Font("Poppins", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1024, 400)
        Me.Name = "frmRecEspera_Material"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRecEspera_Material"
        CType(Me.dgridLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridEncabezados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgridLineas As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents txtAdenda As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtImporteTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRecuperar As Button
    Friend WithEvents GridEncabezados As DataGridView
End Class
