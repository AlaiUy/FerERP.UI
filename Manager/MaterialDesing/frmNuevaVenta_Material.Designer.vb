﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgItemsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Manager.My.Resources.Resources.Caja_de_busqueda
        Me.PictureBox1.Location = New System.Drawing.Point(5, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(359, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 33)
        Me.Panel1.TabIndex = 5
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(0, 2)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(226, 31)
        Me.lblTime.TabIndex = 7
        Me.lblTime.Text = "Label1"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = Global.Manager.My.Resources.Resources.icons8_cerrar_ventana_32
        Me.PictureBox3.Location = New System.Drawing.Point(985, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.Manager.My.Resources.Resources.icons8_búsqueda_32
        Me.PictureBox2.Location = New System.Drawing.Point(11, 41)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 32)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Poppins", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgItemsView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgItemsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgItemsView.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgItemsView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgItemsView.EnableHeadersVisualStyles = False
        Me.dgItemsView.GridColor = System.Drawing.Color.White
        Me.dgItemsView.Location = New System.Drawing.Point(5, 83)
        Me.dgItemsView.Name = "dgItemsView"
        Me.dgItemsView.ReadOnly = True
        Me.dgItemsView.RowHeadersVisible = False
        Me.dgItemsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItemsView.Size = New System.Drawing.Size(912, 399)
        Me.dgItemsView.TabIndex = 8
        '
        'txtImporteGral
        '
        Me.txtImporteGral.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporteGral.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteGral.Location = New System.Drawing.Point(666, 529)
        Me.txtImporteGral.Name = "txtImporteGral"
        Me.txtImporteGral.Size = New System.Drawing.Size(251, 36)
        Me.txtImporteGral.TabIndex = 129
        Me.txtImporteGral.Text = "0"
        Me.txtImporteGral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(493, 532)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 28)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "IMPORTE GENERAL:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtImporte
        '
        Me.txtImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporte.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(666, 488)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(251, 36)
        Me.txtImporte.TabIndex = 128
        Me.txtImporte.Text = "0"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(493, 491)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 28)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "IMPORTE CONTADO:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(370, 39)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(63, 36)
        Me.txtCantidad.TabIndex = 132
        Me.txtCantidad.Text = "1"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCodArticulo
        '
        Me.txtCodArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodArticulo.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodArticulo.Location = New System.Drawing.Point(50, 43)
        Me.txtCodArticulo.Name = "txtCodArticulo"
        Me.txtCodArticulo.Size = New System.Drawing.Size(305, 29)
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
        'frmNuevaVenta_Material
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1024, 571)
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
        Me.Controls.Add(Me.PictureBox2)
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
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgItemsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
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
End Class