<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaVenta_Material
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.TimerTime = New System.Windows.Forms.Timer(Me.components)
        Me.dgItemsView = New System.Windows.Forms.DataGridView()
        Me.txtImporteGral = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtCodArticulo = New System.Windows.Forms.TextBox()
        Me.btnNuevaVenta = New System.Windows.Forms.Button()
        Me.btnRecuperarPresupuesto = New System.Windows.Forms.Button()
        Me.btnPresupuesto = New System.Windows.Forms.Button()
        Me.btnRecuperarEspera = New System.Windows.Forms.Button()
        Me.btnBorrarLinea = New System.Windows.Forms.Button()
        Me.btnCantidad = New System.Windows.Forms.Button()
        Me.btnSearch = New FontAwesome.Sharp.IconButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgItemsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Manager.My.Resources.Resources.Caja_de_busqueda
        Me.PictureBox1.Location = New System.Drawing.Point(5, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(359, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 23)
        Me.Panel1.TabIndex = 5
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Black
        Me.lblTime.Location = New System.Drawing.Point(0, 1)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(226, 19)
        Me.lblTime.TabIndex = 7
        Me.lblTime.Text = "Label1"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerTime
        '
        Me.TimerTime.Interval = 1
        '
        'dgItemsView
        '
        Me.dgItemsView.AllowUserToAddRows = False
        Me.dgItemsView.AllowUserToDeleteRows = False
        Me.dgItemsView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgItemsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgItemsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgItemsView.BackgroundColor = System.Drawing.Color.White
        Me.dgItemsView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgItemsView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgItemsView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgItemsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgItemsView.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgItemsView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgItemsView.EnableHeadersVisualStyles = False
        Me.dgItemsView.GridColor = System.Drawing.Color.White
        Me.dgItemsView.Location = New System.Drawing.Point(5, 72)
        Me.dgItemsView.Name = "dgItemsView"
        Me.dgItemsView.ReadOnly = True
        Me.dgItemsView.RowHeadersVisible = False
        Me.dgItemsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItemsView.Size = New System.Drawing.Size(912, 410)
        Me.dgItemsView.TabIndex = 8
        '
        'txtImporteGral
        '
        Me.txtImporteGral.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporteGral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteGral.Location = New System.Drawing.Point(666, 529)
        Me.txtImporteGral.Name = "txtImporteGral"
        Me.txtImporteGral.Size = New System.Drawing.Size(251, 26)
        Me.txtImporteGral.TabIndex = 129
        Me.txtImporteGral.Text = "0"
        Me.txtImporteGral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(493, 532)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 20)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "IMPORTE GENERAL:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtImporte
        '
        Me.txtImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(666, 488)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(251, 26)
        Me.txtImporte.TabIndex = 128
        Me.txtImporte.Text = "0"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(493, 491)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 20)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "IMPORTE CONTADO:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(370, 28)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(63, 33)
        Me.txtCantidad.TabIndex = 132
        Me.txtCantidad.Text = "1"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCodArticulo
        '
        Me.txtCodArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodArticulo.Location = New System.Drawing.Point(50, 31)
        Me.txtCodArticulo.Multiline = True
        Me.txtCodArticulo.Name = "txtCodArticulo"
        Me.txtCodArticulo.Size = New System.Drawing.Size(305, 30)
        Me.txtCodArticulo.TabIndex = 133
        '
        'btnNuevaVenta
        '
        Me.btnNuevaVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevaVenta.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevaVenta.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaVenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaVenta.Image = Global.Manager.My.Resources.JJRecursos.stopwatch
        Me.btnNuevaVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevaVenta.Location = New System.Drawing.Point(925, 83)
        Me.btnNuevaVenta.Name = "btnNuevaVenta"
        Me.btnNuevaVenta.Size = New System.Drawing.Size(93, 64)
        Me.btnNuevaVenta.TabIndex = 134
        Me.btnNuevaVenta.Text = "Espera"
        Me.btnNuevaVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevaVenta.UseVisualStyleBackColor = False
        '
        'btnRecuperarPresupuesto
        '
        Me.btnRecuperarPresupuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecuperarPresupuesto.BackColor = System.Drawing.Color.Transparent
        Me.btnRecuperarPresupuesto.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnRecuperarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecuperarPresupuesto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecuperarPresupuesto.Image = Global.Manager.My.Resources.JJRecursos.icons8_cita_recurrente_32
        Me.btnRecuperarPresupuesto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRecuperarPresupuesto.Location = New System.Drawing.Point(924, 302)
        Me.btnRecuperarPresupuesto.Name = "btnRecuperarPresupuesto"
        Me.btnRecuperarPresupuesto.Size = New System.Drawing.Size(94, 72)
        Me.btnRecuperarPresupuesto.TabIndex = 137
        Me.btnRecuperarPresupuesto.Text = "Recuperar Presupuesto"
        Me.btnRecuperarPresupuesto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRecuperarPresupuesto.UseVisualStyleBackColor = False
        '
        'btnPresupuesto
        '
        Me.btnPresupuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPresupuesto.BackColor = System.Drawing.Color.Transparent
        Me.btnPresupuesto.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPresupuesto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPresupuesto.Image = Global.Manager.My.Resources.JJRecursos.contract
        Me.btnPresupuesto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPresupuesto.Location = New System.Drawing.Point(924, 233)
        Me.btnPresupuesto.Name = "btnPresupuesto"
        Me.btnPresupuesto.Size = New System.Drawing.Size(94, 63)
        Me.btnPresupuesto.TabIndex = 136
        Me.btnPresupuesto.Text = "Presupuesto"
        Me.btnPresupuesto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPresupuesto.UseVisualStyleBackColor = False
        '
        'btnRecuperarEspera
        '
        Me.btnRecuperarEspera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecuperarEspera.BackColor = System.Drawing.Color.Transparent
        Me.btnRecuperarEspera.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnRecuperarEspera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecuperarEspera.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecuperarEspera.Image = Global.Manager.My.Resources.JJRecursos.pending
        Me.btnRecuperarEspera.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRecuperarEspera.Location = New System.Drawing.Point(924, 154)
        Me.btnRecuperarEspera.Name = "btnRecuperarEspera"
        Me.btnRecuperarEspera.Size = New System.Drawing.Size(94, 73)
        Me.btnRecuperarEspera.TabIndex = 135
        Me.btnRecuperarEspera.Text = "Recuperar Espera"
        Me.btnRecuperarEspera.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRecuperarEspera.UseVisualStyleBackColor = False
        '
        'btnBorrarLinea
        '
        Me.btnBorrarLinea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBorrarLinea.BackColor = System.Drawing.Color.Transparent
        Me.btnBorrarLinea.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBorrarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarLinea.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarLinea.Image = Global.Manager.My.Resources.JJRecursos.eraser
        Me.btnBorrarLinea.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrarLinea.Location = New System.Drawing.Point(130, 498)
        Me.btnBorrarLinea.Name = "btnBorrarLinea"
        Me.btnBorrarLinea.Size = New System.Drawing.Size(119, 59)
        Me.btnBorrarLinea.TabIndex = 138
        Me.btnBorrarLinea.Text = "Borrar Linea"
        Me.btnBorrarLinea.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrarLinea.UseVisualStyleBackColor = False
        '
        'btnCantidad
        '
        Me.btnCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCantidad.BackColor = System.Drawing.Color.Transparent
        Me.btnCantidad.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCantidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCantidad.Image = Global.Manager.My.Resources.JJRecursos.countdown
        Me.btnCantidad.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCantidad.Location = New System.Drawing.Point(7, 498)
        Me.btnCantidad.Name = "btnCantidad"
        Me.btnCantidad.Size = New System.Drawing.Size(119, 59)
        Me.btnCantidad.TabIndex = 139
        Me.btnCantidad.Text = "Cantidad"
        Me.btnCantidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCantidad.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnSearch.IconColor = System.Drawing.Color.Black
        Me.btnSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSearch.IconSize = 32
        Me.btnSearch.Location = New System.Drawing.Point(11, 30)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(39, 32)
        Me.btnSearch.TabIndex = 140
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'frmNuevaVenta_Material
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1024, 571)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnCantidad)
        Me.Controls.Add(Me.btnBorrarLinea)
        Me.Controls.Add(Me.btnRecuperarPresupuesto)
        Me.Controls.Add(Me.btnPresupuesto)
        Me.Controls.Add(Me.btnRecuperarEspera)
        Me.Controls.Add(Me.btnNuevaVenta)
        Me.Controls.Add(Me.txtCodArticulo)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtImporteGral)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgItemsView)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNuevaVenta_Material"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNuevaVenta_Material"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgItemsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents TimerTime As Timer
    Friend WithEvents dgItemsView As DataGridView
    Friend WithEvents txtImporteGral As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtCodArticulo As TextBox
    Friend WithEvents btnNuevaVenta As Button
    Friend WithEvents btnRecuperarPresupuesto As Button
    Friend WithEvents btnPresupuesto As Button
    Friend WithEvents btnRecuperarEspera As Button
    Friend WithEvents btnBorrarLinea As Button
    Friend WithEvents btnCantidad As Button
    Friend WithEvents btnSearch As FontAwesome.Sharp.IconButton
End Class
