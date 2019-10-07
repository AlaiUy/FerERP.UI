Imports System.Windows.Forms
Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer
Imports JJ.Reportes

Public Class frmNuevaVenta
    Implements IObservable, IObserver
    Private _Obs As IList(Of IObserver)

    Private _Vendedor As Vendedor = Nothing
    Private Art As Articulo
    Private ListLineas As List(Of Linea) = New List(Of Linea)
    Private esp As UESPERA = New UESPERA(GesPrecios.getInstance().getCotizacion(2))
    Private frmListArticulos As Form = Nothing
    Dim Diseño As Integer = 0


    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Diseño = LeerIni.LeerDato("INTERFAZ", "MATERIAL", 0, ".\config.ini")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Sub New(ByVal xVendedor As Vendedor)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _Vendedor = xVendedor
        Diseño = LeerIni.LeerDato("INTERFAZ", "MATERIAL", 0, ".\config.ini")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub FormatearForm()
        txtImporte.BackColor = Color.White
        txtImporteGral.BackColor = Color.White
        txtCantidad.BackColor = Color.White
        If Not IsNothing(_Vendedor) Then
            lblVendedor.Text = _Vendedor.Nombre
        End If
        PopularGrilla()
    End Sub

    Private Sub PopularGrilla()
        If Not IsNothing(esp) Then
            If dgItemsView.Rows.Count > 0 Then
                dgItemsView.DataSource = Nothing
                dgItemsView.Refresh()
            End If
            dgItemsView.DataSource = esp.MostrarTabla()
            txtImporte.Text = FormatearImporte(esp.Total())
            txtImporteGral.Text = FormatearImporte(esp.Total() * (1 + (GesEmpresa.getInstance().Empresa.DescuentoContado / 100)))
        End If

        Dim EstiloIzquierda As DataGridViewCellStyle = New DataGridViewCellStyle()
        EstiloIzquierda.Alignment = DataGridViewContentAlignment.BottomLeft

        Dim EstiloDerecha As DataGridViewCellStyle = New DataGridViewCellStyle()
        EstiloDerecha.Alignment = DataGridViewContentAlignment.BottomRight

        Dim EstiloCentro As DataGridViewCellStyle = New DataGridViewCellStyle()
        EstiloCentro.Alignment = DataGridViewContentAlignment.BottomCenter

        dgItemsView.Columns("REFERENCIA").DefaultCellStyle = EstiloCentro
        dgItemsView.Columns("NOMBRE").DefaultCellStyle = EstiloIzquierda
        dgItemsView.Columns("CANTIDAD").DefaultCellStyle = EstiloCentro
        dgItemsView.Columns("PRECIO").DefaultCellStyle = EstiloDerecha
        dgItemsView.Columns("DESCUENTO").DefaultCellStyle = EstiloCentro
        dgItemsView.Columns("FINAL").DefaultCellStyle = EstiloDerecha

        For Each C As DataGridViewColumn In dgItemsView.Columns
            C.SortMode = DataGridViewColumnSortMode.NotSortable
            C.ReadOnly = True
        Next

        If dgItemsView.Rows.Count > 0 Then
            PintarGrilla()
        End If

        dgItemsView.Columns("CODIGO").Visible = False
        dgItemsView.Columns("LINEA").Visible = False

        FijarAnchos()

    End Sub

    Private Sub FijarAnchos()
        dgItemsView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        dgItemsView.Columns("REFERENCIA").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgItemsView.Columns("CANTIDAD").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgItemsView.Columns("PRECIO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgItemsView.Columns("DESCUENTO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgItemsView.Columns("FINAL").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        Dim SumaAnchos As Decimal = 0
        For Each C As DataGridViewColumn In dgItemsView.Columns
            If C.Visible Then
                SumaAnchos += C.Width
            End If
        Next


        dgItemsView.Columns("NOMBRE").Width += dgItemsView.Width - (SumaAnchos + 2)
    End Sub

    Private Sub PintarGrilla()
        Dim Index = 0
        For Each R As DataGridViewRow In dgItemsView.Rows
            If Index Mod 2 = 0 Then
                R.DefaultCellStyle.BackColor = Color.LightBlue
            Else
                R.DefaultCellStyle.BackColor = Color.White
            End If
            Index += 1
        Next
    End Sub

    Private Sub seleccionadVendedor()
        If IsNothing(_Vendedor) Then
            Dim Form As frmVendedores_Material = New frmVendedores_Material()
            Form.Register(Me)
            Form.ShowDialog()
        End If
    End Sub
    Private Sub frmNuevaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        While (IsNothing(_Vendedor))
            FormatearForm()
            seleccionadVendedor()
        End While
        esp.Codvendedor = _Vendedor.Codigo
        MsgBox(esp.Codvendedor)
    End Sub

    Private Sub LnkSearchClient_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkSearchItem.LinkClicked
        Try
            If Not IsNothing(frmListArticulos) Then
                frmListArticulos.Show()
                Return
            End If
            If Diseño = 0 Then
                frmListArticulos = New frmArticulos(Me)
                frmListArticulos.Show()
            Else
                frmListArticulos = New frmArticulos_Material(Me)
                frmListArticulos.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub txtCodArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodArticulo.KeyDown

    End Sub





    Private Sub DgItemsView_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs)
        If ((e.RowIndex < 0) OrElse (e.ColumnIndex < 0)) Then Return

        If dgItemsView.Columns(e.ColumnIndex).Name = "NOMBRE" Then
            Dim codigo As Integer = Me.dgItemsView.Item("CODIGO", e.RowIndex).Value
            Try
                Art = esp.getArticuloByCodigo(codigo)
                Dim column As DataGridViewColumn = dgItemsView.Columns(e.ColumnIndex)
                Dim row As DataGridViewRow = dgItemsView.Rows(e.RowIndex)
                Dim value As Object = row.Cells(column.Name).Value

                Dim OtrosDatos As String = String.Format("Descipcion: {0}{1}{2}", Art.Descripcion, Environment.NewLine, Art.Referencia)
                ToolTip1.Active = True
                ToolTip1.ShowAlways = True
                ToolTip1.SetToolTip(dgItemsView, OtrosDatos)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub DgItemsView_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DgItemsView_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs)
        ToolTip1.Active = False
    End Sub

    Private Sub txtCodArticulo_TextChanged(sender As Object, e As EventArgs) Handles txtCodArticulo.TextChanged

    End Sub

    Private Sub txtCodArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodArticulo.KeyPress
        Dim Cantidad As Decimal = 1
        If e.KeyChar = "+" Then
            e.Handled = True
            Try
                Cantidad = Convert.ToDecimal(txtCodArticulo.Text)
                txtCantidad.Text = Cantidad
                txtCodArticulo.Text = String.Empty
                txtCodArticulo.Focus()
            Catch ex As Exception
                Cantidad = 1
            End Try
        End If
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Try
                Art = GesArticulos.getInstance().getArticuloByRef(Convert.ToInt32(txtCodArticulo.Text))
                Cantidad = Convert.ToDecimal(txtCantidad.Text)
            Catch ex As Exception
                Cantidad = 1
                MsgBox(ex.Message)
                Return
            End Try

            AgregarLinea(Art, Cantidad)
        End If
    End Sub

    Private Sub AgregarLinea(ByVal Art As Articulo, ByVal xCantidad As Decimal)
        Dim EL As Esperalin = New Esperalin(Art, Art.Nombre, xCantidad, 0, esp.Lineas.Count + 1)
        esp.AgregarLinea(EL)
        PopularGrilla()
        txtCodArticulo.Text = String.Empty
        txtCodArticulo.Focus()
        txtCantidad.Text = 1

    End Sub




    Private Sub btnDescuentoLineal_Click(sender As Object, e As EventArgs)
        Dim xDescuento As Decimal = 0
        Dim frmNumber As frmPanelNumerico = New frmPanelNumerico()
        frmNumber.ShowDialog()
        If frmNumber.DialogResult = DialogResult.OK Then
            xDescuento = frmNumber.Numero
        End If
        esp.AsignarDescuento(xDescuento, dgItemsView.Item("LINEA", dgItemsView.CurrentRow.Index).Value)
        PopularGrilla()
    End Sub

    Private Sub btnDescuentoTotal_Click(sender As Object, e As EventArgs)
        Dim xDescuento As Decimal = 0
        Dim frmNumber As frmPanelNumerico = New frmPanelNumerico()
        frmNumber.ShowDialog()
        If frmNumber.DialogResult = DialogResult.OK Then
            xDescuento = frmNumber.Numero
        End If
        esp.AllDescuento(xDescuento)
        PopularGrilla()
    End Sub



    Public Overloads Sub Update(Obj As Object) Implements IObserver.Update
        If TypeOf Obj Is Vendedor Then
            _Vendedor = DirectCast(Obj, Vendedor)
        End If

        If TypeOf Obj Is Articulo Then
            If Diseño = 0 Then
                AgregarLinea(DirectCast(Obj, Articulo), TryCast(frmListArticulos, frmArticulos).Cantidad)
            Else
                AgregarLinea(DirectCast(Obj, Articulo), TryCast(frmListArticulos, frmArticulos_Material).Cantidad)
            End If
        End If

        If TypeOf Obj Is String Then
            If DirectCast(Obj, String).ToString() = "VENTA" Then
                esp = New UESPERA(GesPrecios.getInstance().getCotizacion(2))
                esp.Codvendedor = _Vendedor.Codigo
                PopularGrilla()
            End If
            If DirectCast(Obj, String).ToString() = "CERRAR" Then
                frmListArticulos.Close()
                frmListArticulos.Dispose()
                frmListArticulos = Nothing
            End If
        End If

    End Sub

    Public Sub Register(xObserver As IObserver) Implements IObservable.Register
        If IsNothing(_Obs) Then
            _Obs = New List(Of IObserver)
        End If
        _Obs.Add(xObserver)
    End Sub

    Public Sub UnRegister(xObserver As IObserver) Implements IObservable.UnRegister
        For Each O As IObserver In _Obs
            If (O.Equals(xObserver)) Then
                _Obs.Remove(O)
            End If
        Next
    End Sub

    Public Sub notifyObservers() Implements IObservable.notifyObservers
        For Each O As IObserver In _Obs
            O.Update(Me)
        Next
    End Sub

    Private Sub GuardarEspera_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnNuevaVenta_Click(sender As Object, e As EventArgs) Handles btnNuevaVenta.Click
        If esp.Lineas.Count < 1 Then
            MsgBox("No se puede guardar una venta sin lineas", vbOKOnly, "Atencion!")
            Return
        End If
        Dim frmTipoVenta As Form = New frmSeleccionTipoVenta(esp, Me)
        frmTipoVenta.ShowDialog()
    End Sub




    Private Sub btnCantidad_Click(sender As Object, e As EventArgs) Handles btnCantidad.Click

        'If dgridFactura.Rows.Count > 1 Then
        '    If (dgridFactura.CurrentRow Is Nothing) Then
        '        _Factura.Lineas(0).AplicarDescuento(Convert.ToDecimal(frmDesc.Unidades), "", ConfiguracionesLog.DescuentoEspecialHabilitado(Configuracion.mLocal), False, False)
        '    Else
        '        Dim fila As Integer = dgridFactura.CurrentRow.Index
        '        _Factura.Lineas(dgridFactura.Item("NUMERO LINEA", fila).Value).AplicarDescuento(Convert.ToDecimal(frmDesc.Unidades), "", ConfiguracionesLog.DescuentoEspecialHabilitado(Configuracion.mLocal), False, False)
        '    End If

        If dgItemsView.Rows.Count < 1 Then
            Return
        End If

        Dim xCantidad As Decimal
        Dim frmNumber As frmPanelNumerico = New frmPanelNumerico()
        frmNumber.ShowDialog()
        Try
            If frmNumber.DialogResult = DialogResult.OK Then
                xCantidad = frmNumber.Numero
            End If
            If (dgItemsView.CurrentRow Is Nothing) Then
                esp.CambiarCantidad(xCantidad, 1)
            Else
                esp.CambiarCantidad(xCantidad, dgItemsView.Item("LINEA", dgItemsView.CurrentRow.Index).Value)
            End If

            PopularGrilla()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnBorrarLinea_Click(sender As Object, e As EventArgs) Handles btnBorrarLinea.Click
        If dgItemsView.SelectedRows.Count < 1 Then
            Return
        End If

        If (dgItemsView.CurrentRow Is Nothing) Then
            esp.BorrarLinea(1)
        Else
            esp.BorrarLinea(dgItemsView.Item("LINEA", dgItemsView.CurrentRow.Index).Value)
        End If
        PopularGrilla()
    End Sub

    Private Sub txtImporte_TextChanged(sender As Object, e As EventArgs) Handles txtImporte.TextChanged

    End Sub

    Private Sub btnPresupuesto_Click(sender As Object, e As EventArgs) Handles btnPresupuesto.Click
        If esp.Lineas.Count > 0 Then
            Dim frm As frmOpcionesPresupuestos_Material = New frmOpcionesPresupuestos_Material(esp)
            frm.ShowDialog()
            If frm.DialogResult = DialogResult.OK Then
                esp = New UESPERA(GesPrecios.getInstance().getCotizacion(2))
                esp.CodMoneda = 1
                esp.Codvendedor = _Vendedor.Codigo
                PopularGrilla()
            End If
        End If
    End Sub

    Private Sub txtImporteGral_TextChanged(sender As Object, e As EventArgs) Handles txtImporteGral.TextChanged

    End Sub

    Private Sub dgItemsView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgItemsView.ColumnHeaderMouseClick
        If e.ColumnIndex = dgItemsView.Columns("CANTIDAD").Index Then
            btnCantidad.PerformClick()
        End If

        If e.ColumnIndex = dgItemsView.Columns("DESCUENTO").Index Then
            AsignarDescuentoLineal()
        End If
    End Sub


    Private Sub AsignarDescuentoLineal()
        If dgItemsView.Rows.Count < 1 Then
            Return
        End If

        Dim xCantidad As Decimal
        Dim frmNumber As frmPanelNumerico = New frmPanelNumerico()
        frmNumber.ShowDialog()
        Try
            If frmNumber.DialogResult = DialogResult.OK Then
                xCantidad = frmNumber.Numero
            End If
            If (dgItemsView.CurrentRow Is Nothing) Then
                esp.AsignarDescuento(0, 1)
            Else
                esp.AsignarDescuento(xCantidad, dgItemsView.Item("LINEA", dgItemsView.CurrentRow.Index).Value)
            End If
            PopularGrilla()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgItemsView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgItemsView.CellContentClick

    End Sub

    Private Sub dgItemsView_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgItemsView.CellPainting



    End Sub

    Private Sub btnRecuperarEspera_Click(sender As Object, e As EventArgs) Handles btnRecuperarEspera.Click
        Dim Perder As Boolean = True
        If esp.Lineas.Count > 0 Then
            If MsgBox("Desea perder las lineas escritas hasta el momento", vbOKCancel, "Atencion!") = MsgBoxResult.Cancel Then
                Perder = False
            End If
        End If

        If Perder Then
            Dim frmE As New frmRecEspera_Material(0)
            frmE.ShowDialog()
            If frmE.DialogResult = DialogResult.OK Then
                esp = New UESPERA(GesPrecios.getInstance().getCotizacion(2))
                esp.Adenda = frmE.objEspera.Adenda
                esp.AgregarLineas(frmE.objEspera.Lineas)
                esp.CodMoneda = 1
                esp.Codvendedor = _Vendedor.Codigo
                PopularGrilla()
            End If
        End If
    End Sub

    Private Sub btnRecuperarPresupuesto_Click(sender As Object, e As EventArgs) Handles btnRecuperarPresupuesto.Click
        Dim Perder As Boolean = True
        If esp.Lineas.Count > 0 Then
            If MsgBox("Desea perder las lineas escritas hasta el momento", vbOKCancel, "Atencion!") = MsgBoxResult.Cancel Then
                Perder = False
            End If
        End If

        If Perder Then
            Dim frmE As New frmRecEspera_Material(2)
            frmE.ShowDialog()
            If frmE.DialogResult = DialogResult.OK Then
                esp = New UESPERA(GesPrecios.getInstance().getCotizacion(2))
                esp.Adenda = frmE.objEspera.Adenda
                esp.AgregarLineas(frmE.objEspera.Lineas)
                esp.CodMoneda = 1
                esp.Codvendedor = _Vendedor.Codigo
                PopularGrilla()
            End If
        End If
    End Sub
End Class