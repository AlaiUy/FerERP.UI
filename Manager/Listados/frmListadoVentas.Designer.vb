<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoVentas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnImprimir = New FontAwesome.Sharp.IconButton()
        Me.btnExcel = New FontAwesome.Sharp.IconButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrarDev = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateFinal = New System.Windows.Forms.DateTimePicker()
        Me.DateInicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarDirectorio = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnImprimir)
        Me.Panel1.Controls.Add(Me.btnExcel)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(957, 65)
        Me.Panel1.TabIndex = 1
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnImprimir.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnImprimir.IconColor = System.Drawing.Color.DeepSkyBlue
        Me.btnImprimir.IconSize = 32
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(9, 3)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(0)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Rotation = 0R
        Me.btnImprimir.Size = New System.Drawing.Size(59, 54)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.FlatAppearance.BorderSize = 0
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnExcel.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel
        Me.btnExcel.IconColor = System.Drawing.Color.DeepSkyBlue
        Me.btnExcel.IconSize = 32
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExcel.Location = New System.Drawing.Point(67, 3)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Rotation = 0R
        Me.btnExcel.Size = New System.Drawing.Size(94, 54)
        Me.btnExcel.TabIndex = 6
        Me.btnExcel.Text = "Exportar a Excel"
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMostrarDev)
        Me.GroupBox2.Controls.Add(Me.btnMostrar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.DateFinal)
        Me.GroupBox2.Controls.Add(Me.DateInicio)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(535, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(411, 56)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parametros"
        '
        'btnMostrarDev
        '
        Me.btnMostrarDev.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnMostrarDev.FlatAppearance.BorderSize = 0
        Me.btnMostrarDev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMostrarDev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMostrarDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarDev.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarDev.Location = New System.Drawing.Point(316, 31)
        Me.btnMostrarDev.Name = "btnMostrarDev"
        Me.btnMostrarDev.Size = New System.Drawing.Size(89, 23)
        Me.btnMostrarDev.TabIndex = 4
        Me.btnMostrarDev.Text = "Devoluciones"
        Me.btnMostrarDev.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnMostrar.FlatAppearance.BorderSize = 0
        Me.btnMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrar.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.Location = New System.Drawing.Point(316, 9)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(89, 23)
        Me.btnMostrar.TabIndex = 2
        Me.btnMostrar.Text = "Ventas"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde:"
        '
        'DateFinal
        '
        Me.DateFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFinal.Location = New System.Drawing.Point(219, 19)
        Me.DateFinal.Name = "DateFinal"
        Me.DateFinal.Size = New System.Drawing.Size(91, 20)
        Me.DateFinal.TabIndex = 1
        '
        'DateInicio
        '
        Me.DateInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateInicio.Location = New System.Drawing.Point(56, 19)
        Me.DateInicio.Name = "DateInicio"
        Me.DateInicio.Size = New System.Drawing.Size(105, 20)
        Me.DateInicio.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscarDirectorio)
        Me.GroupBox1.Controls.Add(Me.txtPath)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(165, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 56)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guardado"
        '
        'btnBuscarDirectorio
        '
        Me.btnBuscarDirectorio.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnBuscarDirectorio.FlatAppearance.BorderSize = 0
        Me.btnBuscarDirectorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBuscarDirectorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBuscarDirectorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarDirectorio.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarDirectorio.Location = New System.Drawing.Point(281, 17)
        Me.btnBuscarDirectorio.Name = "btnBuscarDirectorio"
        Me.btnBuscarDirectorio.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarDirectorio.TabIndex = 1
        Me.btnBuscarDirectorio.Text = "Buscar"
        Me.btnBuscarDirectorio.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(18, 19)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(257, 20)
        Me.txtPath.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Grid)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(963, 526)
        Me.Panel2.TabIndex = 3
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Grid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grid.DefaultCellStyle = DataGridViewCellStyle4
        Me.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Grid.EnableHeadersVisualStyles = False
        Me.Grid.GridColor = System.Drawing.SystemColors.ControlLight
        Me.Grid.Location = New System.Drawing.Point(3, 71)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersVisible = False
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(957, 443)
        Me.Grid.TabIndex = 9
        '
        'frmListadoVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 526)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmListadoVentas"
        Me.Text = "frmListadoVentas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscarDirectorio As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnMostrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateFinal As DateTimePicker
    Friend WithEvents DateInicio As DateTimePicker
    Friend WithEvents btnMostrarDev As Button
    Friend WithEvents Grid As DataGridView
    Friend WithEvents btnImprimir As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExcel As FontAwesome.Sharp.IconButton
End Class
