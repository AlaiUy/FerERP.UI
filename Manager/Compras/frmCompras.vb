Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmCompras
    Implements IObservable, IObserver
    Private _Obs As IList(Of IObserver)
    Private _Compra As _ALBARANCOMPRA = New _ALBARANCOMPRA()
    Private _Caja As Caja = GesCajas.getInstance().Caja()
    Private _Monedas As List(Of Object) = GesPrecios.getInstance().getMonedas()
    Private bandera As Integer = 0


    '' formularios de interaccion
    Private _fArticulos As frmArticulos = Nothing
    Private _fProveedores As frmListaProveedores = Nothing

    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PopularForm()
            Popular()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub FijarAnchos()
        dgCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        dgCompras.Columns("PRECIO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgCompras.Columns("SUBTOTAL").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgCompras.Columns("FINAL").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        Dim SumaAnchos As Decimal = 0
        For Each C As DataGridViewColumn In dgCompras.Columns
            If C.Visible Then
                SumaAnchos += C.Width
            End If
        Next


        dgCompras.Columns("NOMBRE").Width += dgCompras.Width - (SumaAnchos + 2)



    End Sub

    Private Sub PopularForm()
        If Not IsNothing(_Compra.Proveedor) Then
            txtCodProveedor.Text = _Compra.Proveedor.Codigo
            txtNombreProveedor.Text = _Compra.Proveedor.Nombre
        End If
        cbMonedas.DataSource = _Monedas
        StatusBarLabel.Text = "INGRESAR UNA COMPRA CON SERIE: " & _Caja.getSerieByID(20).Serie
    End Sub

    Private Sub PintarGrilla()
        Dim Index = 0
        For Each R As DataGridViewRow In dgCompras.Rows
            If Index Mod 2 = 0 Then
                R.DefaultCellStyle.BackColor = Color.LightBlue
            Else
                R.DefaultCellStyle.BackColor = Color.White
            End If
            Index += 1
        Next
    End Sub

    Private Sub PopularGrilla()
        For Each column As DataGridViewColumn In dgCompras.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        txtFinal.Text = FormatearImporte(0)
        txtSubTotal.Text = FormatearImporte(0)
        txtIva.Text = FormatearImporte(0)
        Redondear(Panel7, 3) ' PANEL DE LOS BOTONES
        Redondear(Panel8, 3) 'PANEL DE LOS IMPORTES


        dgCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        dgCompras.Columns("CODIGO").Visible = False
        dgCompras.Columns("LINEA").Visible = False

        dgCompras.Columns("CODIGO").ReadOnly = True
        dgCompras.Columns("LINEA").ReadOnly = True
        dgCompras.Columns("REFERENCIA").ReadOnly = True
        dgCompras.Columns("NOMBRE").ReadOnly = True
        dgCompras.Columns("CANTIDAD").ReadOnly = True
        dgCompras.Columns("IVA").ReadOnly = False
        'dgCompras.Columns("DESCUENTO").ReadOnly = True

        Dim EstiloIzquierda As DataGridViewCellStyle = New DataGridViewCellStyle()
        EstiloIzquierda.Alignment = DataGridViewContentAlignment.BottomLeft

        Dim EstiloDerecha As DataGridViewCellStyle = New DataGridViewCellStyle()
        EstiloDerecha.Alignment = DataGridViewContentAlignment.BottomRight

        Dim EstiloCentro As DataGridViewCellStyle = New DataGridViewCellStyle()
        EstiloCentro.Alignment = DataGridViewContentAlignment.BottomCenter

        dgCompras.Columns("REFERENCIA").DefaultCellStyle = EstiloCentro
        dgCompras.Columns("NOMBRE").DefaultCellStyle = EstiloIzquierda
        dgCompras.Columns("CANTIDAD").DefaultCellStyle = EstiloCentro
        dgCompras.Columns("PRECIO").DefaultCellStyle = EstiloDerecha
        dgCompras.Columns("IVA").DefaultCellStyle = EstiloCentro
        dgCompras.Columns("SUBTOTAL").DefaultCellStyle = EstiloDerecha
        ' dgCompras.Columns("DESCUENTO").DefaultCellStyle = EstiloCentro
        dgCompras.Columns("FINAL").DefaultCellStyle = EstiloDerecha


    End Sub

    Private Sub txtReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReferencia.KeyPress
        If e.KeyChar = Chr(13) And Not String.IsNullOrEmpty(DirectCast(sender, TextBox).Text) Then
            Dim Cantidad As Decimal = Convert.ToDecimal(txtCantidad.Text)
            Try
                Dim A As Articulo = GesArticulos.getInstance().getArticuloByRef(TryCast(sender, TextBox).Text)
                If Not IsNothing(A) Then
                    _Compra.AgregarLinea(New CompraLin(A, "", Cantidad, 0, _Compra.Lineas.Count, A.Costo))
                    Popular()
                    PintarGrilla()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If e.KeyChar = "+" Then
            e.Handled = True
            If IsNumeric(txtReferencia.Text) Then
                If ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart, 6) Then
                    txtCantidad.Text = txtReferencia.Text
                End If
                txtReferencia.Text = String.Empty
            End If

        End If

    End Sub

    Private Sub dgCompras_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgCompras.CellEndEdit


    End Sub


    Private Sub Popular()
        If Not IsNothing(_Compra) Then
            If dgCompras.Rows.Count > 0 Then
                dgCompras.DataSource = Nothing
                dgCompras.Refresh()
            End If

            dgCompras.DataSource = _Compra.MostrarTabla()

            PopularGrilla()
        End If

        If dgCompras.Rows.Count > 0 Then
            PintarGrilla()
        End If
        FijarAnchos()
        txtSubTotal.Text = FormatearImporte(_Compra.Subtotal())
        txtFinal.Text = FormatearImporte(_Compra.Total())
    End Sub






    Private Sub btnBorrarLinea_Click(sender As Object, e As EventArgs) Handles btnBorrarLinea.Click
        If Not IsNothing(dgCompras.CurrentRow) Then
            dgCompras.Rows.Remove(dgCompras.CurrentRow)
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

    Private Sub btnCantidad_Click(sender As Object, e As EventArgs) Handles btnCantidad.Click
        Dim xCantidad As Decimal
        Dim frmNumber As frmPanelNumerico = New frmPanelNumerico()
        frmNumber.ShowDialog()
        If frmNumber.DialogResult = DialogResult.OK Then
            xCantidad = frmNumber.Numero
            If xCantidad < 0 Then
                xCantidad = 1
            End If
        End If
        _Compra.CambiarCantidad(xCantidad, dgCompras.Item("LINEA", dgCompras.CurrentRow.Index).Value)
        Popular()
    End Sub

    Private Sub btnBorrarLinea_Click_1(sender As Object, e As EventArgs)
        _Compra.BorrarLinea(dgCompras.Item("LINEA", dgCompras.CurrentRow.Index).Value)
        Popular()
    End Sub

    Private Sub btnDescuentoLineal_Click(sender As Object, e As EventArgs) Handles btnDescuentoLineal.Click
        Dim xDescuento As Decimal = 0
        Dim frmNumber As frmPanelNumerico = New frmPanelNumerico()
        frmNumber.ShowDialog()
        If frmNumber.DialogResult = DialogResult.OK Then
            xDescuento = frmNumber.Numero
            If xDescuento < 0 Or xDescuento > 99 Then
                xDescuento = 0
            End If
        End If
        '_Compra.AsignarDescuento(xDescuento, dgCompras.Item("LINEA", dgCompras.CurrentRow.Index).Value)
        Popular()
    End Sub

    Private Sub btnDescuentoTotal_Click(sender As Object, e As EventArgs) Handles btnDescuentoTotal.Click
        Dim xDescuento As Decimal = 0
        Dim frmNumber As frmPanelNumerico = New frmPanelNumerico()
        frmNumber.ShowDialog()
        If frmNumber.DialogResult = DialogResult.OK Then
            xDescuento = frmNumber.Numero
            If xDescuento < 0 Or xDescuento > 99 Then
                xDescuento = 0
            End If
        End If
        _Compra.AllDescuento(xDescuento)
        Popular()
    End Sub

    Private Sub LinkArticulos_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkArticulos.LinkClicked
        _fArticulos = New frmArticulos(Me)
        _fArticulos.Show()
    End Sub

    Private Sub AddToGrid(ByVal xArticulo As Articulo)
        Dim cantidad As Decimal = Convert.ToDecimal(txtCantidad.Text)
        _Compra.AgregarLinea(New CompraLin(xArticulo, "", cantidad, 0, _Compra.Lineas.Count, xArticulo.Costo))
        Popular()
        PintarGrilla()
    End Sub

    Public Overloads Sub Update(Obj As Object) Implements IObserver.Update
        Select Case True
            Case TypeOf Obj Is Articulo
                AddToGrid(TryCast(Obj, Articulo))
            Case TypeOf Obj Is Form
                If _fArticulos.Equals(TryCast(Obj, Form)) Then
                    txtCantidad.Text = _fArticulos.Cantidad
                    AddToGrid(_fArticulos.Articulo)
                End If
            Case TypeOf Obj Is Proveedor
                txtCodProveedor.Text = TryCast(Obj, Proveedor).Codigo
                txtNombreProveedor.Text = TryCast(Obj, Proveedor).Nombre
                _Compra.Proveedor = TryCast(Obj, Proveedor)
                If Not IsNothing(_fProveedores) Then
                    _fProveedores.Close()
                End If
        End Select
    End Sub



    Private Sub btnIngresarCompra_MouseEnter(sender As Object, e As EventArgs) Handles btnIngresarCompra.MouseEnter
        lblInfo.Text = "INGRESAR COMPRA."
    End Sub

    Private Sub btnIngresarCompra_MouseLeave(sender As Object, e As EventArgs) Handles btnIngresarCompra.MouseLeave
        lblInfo.Text = ""
    End Sub

    Private Sub btnIngresarCompra_Click(sender As Object, e As EventArgs) Handles btnIngresarCompra.Click

        If IsNothing(_Compra) Then
            Return
        End If

        If _Compra.Lineas.Count < 1 Then
            MsgBox("No se puede generar una factura sin lineas", vbOK, "Lineas en la compra")
            Return
        End If

        If _Compra.Total() < 0.1 Then
            MsgBox("No se puede generar una compra con importe menor a 0", vbOK, "Importe de la compra")
            Return
        End If

        If IsNothing(_Compra.Proveedor) Then
            MsgBox("Se debe especificar el proveedor de la compra", vbOK, "Proveedor de la compra")
            Return
        End If

        If cbMonedas.Items.Count < 1 Then
            MsgBox("No se encontraron monedas para la factura", vbOK, "Monedas para la factura")
            Return
        End If

        Dim AC As AlbaranCompra
        Dim SCompra As Seriedoc = _Caja.getSerieByID(20)
        Dim _Moneda As Moneda = TryCast(cbMonedas.SelectedItem(), Moneda)
        AC = New AlbaranCompra(SCompra.Serie, Date.Now, _Compra.Proveedor.Codigo, _Moneda)
        AC.SerieFacturaProveedor = txtSerieP.Text
        If txtNumeroP.Text.Length > 0 Then
            AC.NumFacturaProveedor = Convert.ToInt32(txtNumeroP.Text)
        End If

        Try
            AC.AgregarLineas(_Compra.Lineas)
            GesDocumentos.getInstance().IngresarCompra(AC)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LinkProveedor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkProveedor.LinkClicked
        _fProveedores = New frmListaProveedores(Me)
        _fProveedores.Show()
    End Sub

    Private Sub txtCodProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodProveedor.KeyPress
        If e.KeyChar = Chr(13) And Not String.IsNullOrEmpty(DirectCast(sender, TextBox).Text) Then
            Try
                Dim P As Proveedor = GesPersonas.getInstance().getProveedorById(TryCast(sender, TextBox).Text)
                If Not IsNothing(P) Then
                    _Compra.Proveedor = P
                    PopularForm()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgCompras_CellParsing(sender As Object, e As DataGridViewCellParsingEventArgs) Handles dgCompras.CellParsing

    End Sub



    Private Sub dgCompras_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgCompras.CellValueChanged
        If dgCompras.RowCount > 0 Then


            Dim xLinea As Integer = TryCast(sender, DataGridView).Rows(e.RowIndex).Cells("LINEA").Value

            Dim Cantidad As Decimal = TryCast(sender, DataGridView).Rows(e.RowIndex).Cells("CANTIDAD").Value

            Dim Precio As Decimal = TryCast(sender, DataGridView).Rows(e.RowIndex).Cells("PRECIO").Value

            Dim Descuento As Decimal = TryCast(sender, DataGridView).Rows(e.RowIndex).Cells("DESCUENTO").Value

            Dim Iva As Decimal = TryCast(sender, DataGridView).Rows(e.RowIndex).Cells("IVA").Value

            Dim PrecioIva As Decimal = TryCast(sender, DataGridView).Rows(e.RowIndex).Cells("SUBTOTAL").Value

            If e.ColumnIndex = TryCast(sender, DataGridView).Columns("SUBTOTAL").Index Then
                Precio = PrecioIva / (1 + (Iva / 100))
            End If

            If Cantidad < 0 Then
                Cantidad = 1
            End If
            _Compra.CambiarCantidad(Cantidad, xLinea)


            If Precio < 0 Then
                Precio = 1

            End If
            _Compra.CambiarCostoUnitario(Precio, xLinea)

            If Descuento >= 100 Then
                Descuento = 99

            End If
            ' _Compra.AsignarDescuento(Descuento, xLinea)


            Popular()
        End If
    End Sub

    Private Sub dgCompras_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgCompras.CellValidating

    End Sub

    Private Sub dgCompras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCompras.CellClick

    End Sub

    Private Sub dgCompras_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCompras.ColumnHeaderMouseClick


    End Sub

    Private Sub txtReferencia_TextChanged(sender As Object, e As EventArgs) Handles txtReferencia.TextChanged

    End Sub
End Class