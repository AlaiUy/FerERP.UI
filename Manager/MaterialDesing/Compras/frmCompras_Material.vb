Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmCompras_Material
    Implements IObservable, IObserver
    Private _Obs As IList(Of IObserver)
    Private _Caja As Caja
    Private _Monedas As List(Of Object)

    Private _Compra As _ALBARANCOMPRA = New _ALBARANCOMPRA()
    Private Art As Articulo
    Private ListLineas As List(Of Linea) = New List(Of Linea)
    Private frmListArticulos As Form = Nothing
    Private _fProveedores As frmListaProveedores = Nothing
    Private _fDescuentos As frmDescuentosCompra = Nothing


    'Banderas click derecho

    'Private _ArticuloClickDerecho As Articulo = Nothing
    'Private _LineaArticulo As Integer = -1
    Private _LineaSeleccionada As CompraLin = Nothing

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub AddToGrid(ByVal xArticulo As Articulo)
        Dim cantidad As Decimal = Convert.ToDecimal(txtCantidad.Text)
        _Compra.AgregarLinea(New CompraLin(xArticulo, "", cantidad, 0, _Compra.Lineas.Count, xArticulo.Costo))
        Popular()

    End Sub

    Private Sub PintarGrilla()
        Dim Index = 0
        For Each R As DataGridViewRow In dgCompras.Rows
            Dim CL As CompraLin = _Compra.getLineaByID(dgCompras.Item("LINEA", R.Index).Value)
            If CL.Articulo.CodMoneda <> TryCast(cbMonedas.SelectedItem, Moneda).Codigo Then
                R.DefaultCellStyle.BackColor = Color.Red
            Else
                If Index Mod 2 = 0 Then
                    R.DefaultCellStyle.BackColor = Color.LightBlue
                Else
                    R.DefaultCellStyle.BackColor = Color.White
                End If
            End If
            Index += 1
        Next
    End Sub

    Public Overloads Sub Update(Obj As Object) Implements IObserver.Update
        If TypeOf Obj Is Articulo Then
            AddToGrid(TryCast(Obj, Articulo))
            Return
        End If


        If TypeOf Obj Is String Then
            If DirectCast(Obj, String) = "CERRAR" Then
                If Not IsNothing(frmListArticulos) Then
                    frmListArticulos.Close()
                    frmListArticulos.Dispose()
                    frmListArticulos = Nothing
                End If
            End If
        End If

        If TypeOf Obj Is Proveedor Then
            txtCodProveedor.Text = TryCast(Obj, Proveedor).Codigo
            txtNombreProveedor.Text = TryCast(Obj, Proveedor).Nombre
            _Compra.Proveedor = TryCast(Obj, Proveedor)
            If Not IsNothing(_fProveedores) Then
                _fProveedores.Close()
            End If
        End If

        If TypeOf Obj Is List(Of Decimal) Then
            If Not IsNothing(_fDescuentos) Then
                _Compra.AsignarDescuento(Obj, _LineaSeleccionada.NumLinea)
                _fDescuentos.Close()
            End If
        End If


        Popular()


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



    Private Sub txtCodArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReferencia.KeyPress
        If e.KeyChar = Chr(13) And Not String.IsNullOrEmpty(DirectCast(sender, TextBox).Text) Then
            Dim Cantidad As Decimal = Convert.ToDecimal(txtCantidad.Text)
            Try
                Dim A As Articulo = GesArticulos.getInstance().getArticuloByRef(TryCast(sender, TextBox).Text)
                If Not IsNothing(A) Then
                    _Compra.AgregarLinea(New CompraLin(A, "", Cantidad, 0, _Compra.Lineas.Count, A.Costo))
                    Popular()
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
            'PintarGrilla()
        End If
        FijarAnchos()
        Dim ImporteCompra As Decimal = FormatearImporte(_Compra.Total())
        txtImporte.Text = ImporteCompra
        'txtFinal.Text = FormatearImporte(_Compra.Total())
        PintarGrilla()
    End Sub

    Private Sub FijarAnchos()
        dgCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        dgCompras.Columns("PRECIO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgCompras.Columns("FINAL").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        Dim SumaAnchos As Decimal = 0
        For Each C As DataGridViewColumn In dgCompras.Columns
            If C.Visible Then
                SumaAnchos += C.Width
            End If
        Next


        dgCompras.Columns("NOMBRE").Width += dgCompras.Width - (SumaAnchos)



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PopularGrilla()
        For Each column As DataGridViewColumn In dgCompras.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        'txtFinal.Text = FormatearImporte(0)
        'txtSubTotal.Text = FormatearImporte(0)
        'txtIva.Text = FormatearImporte(0)



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
        dgCompras.Columns("DESCUENTO").DefaultCellStyle = EstiloCentro
        dgCompras.Columns("FINAL").DefaultCellStyle = EstiloDerecha


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If Not IsNothing(frmListArticulos) Then
                frmListArticulos.Show()
                Return
            End If
            frmListArticulos = New frmArticulos_Material(Me)
            frmListArticulos.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub IconButton1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub dgCompras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCompras.CellContentClick

    End Sub

    Private Sub frmCompras_Material_Load(sender As Object, e As EventArgs) Handles Me.Load
        _Caja = GesCajas.getInstance().Caja()
        _Monedas = GesPrecios.getInstance().getMonedas()
        cbMonedas.DataSource = _Monedas
    End Sub

    Private Sub frmCompras_Material_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            Close()
        End If
    End Sub

    Private Sub frmCompras_Material_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub dgCompras_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCompras.ColumnHeaderMouseClick
        If e.ColumnIndex = dgCompras.Columns("CANTIDAD").Index Then
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
        End If

        If e.ColumnIndex = dgCompras.Columns("PRECIO").Index Then
            Dim xPrecio As Decimal
            Dim frmNumber As frmPanelNumerico = New frmPanelNumerico()
            frmNumber.ShowDialog()
            If frmNumber.DialogResult = DialogResult.OK Then
                xPrecio = frmNumber.Numero
                If xPrecio < 0 Then
                    xPrecio = 1
                End If
            End If
            _Compra.CambiarCostoUnitario(xPrecio, dgCompras.Item("LINEA", dgCompras.CurrentRow.Index).Value)
            Popular()
        End If

        If e.ColumnIndex = dgCompras.Columns("FINAL").Index Then
            Dim xPrecio As Decimal
            Dim frmNumber As frmPanelNumerico = New frmPanelNumerico()
            frmNumber.ShowDialog()
            If frmNumber.DialogResult = DialogResult.OK Then
                xPrecio = frmNumber.Numero
                If xPrecio < 0 Then
                    xPrecio = 1
                End If
            End If
            Dim xDescuento As Decimal
            Dim PrecioLinea As Decimal
            Dim xCompraL As CompraLin = Nothing

            xCompraL = _Compra.getLineaByID(dgCompras.Item("LINEA", dgCompras.CurrentRow.Index).Value)
            PrecioLinea = xCompraL.Costo * xCompraL.Cantidad
            xDescuento = Val(PrecioLinea - xPrecio)
            xDescuento = xDescuento / PrecioLinea
            xDescuento *= 100
            Dim xDescuentos As List(Of Decimal) = New List(Of Decimal)
            xDescuentos.Add(xDescuento)
            xCompraL.Descuentos = xDescuentos
            Popular()
        End If
    End Sub

    Private Sub dgCompras_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dgCompras_Click(sender As Object, e As EventArgs) Handles dgCompras.Click

    End Sub

    Private Sub dgCompras_MouseClick(sender As Object, e As MouseEventArgs) Handles dgCompras.MouseClick
        Dim Hitest As DataGridView.HitTestInfo
        If (e.Button = MouseButtons.Right) Then
            Hitest = dgCompras.HitTest(e.X, e.Y)
            Try
                _LineaSeleccionada = _Compra.getLineaByID(dgCompras.Item("LINEA", Hitest.RowIndex).Value)
                menClickDerecho.Show(dgCompras, New Point(e.X, e.Y))
            Catch ex As Exception
                Return
            End Try
        End If
    End Sub

    Private Sub HolaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HolaToolStripMenuItem.Click
        Dim form As frmUpArticulo_Material
        form = New frmUpArticulo_Material(_LineaSeleccionada.Articulo)
        form.Register(Me)
        form.WindowState = FormWindowState.Normal
        form.Show()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        _fProveedores = New frmListaProveedores(Me)
        _fProveedores.Show()
    End Sub

    Private Sub DescuentosDeLineaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescuentosDeLineaToolStripMenuItem.Click
        _fDescuentos = New frmDescuentosCompra(_LineaSeleccionada.Descuentos)
        _fDescuentos.Register(Me)
        _fDescuentos.Show()
    End Sub



    Private Sub cbMonedas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMonedas.SelectedIndexChanged
        PintarGrilla()
    End Sub



    Private Sub txtDPP_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (TryCast(sender, TextBox).SelectedText.Length = TryCast(sender, TextBox).TextLength) Then
            TryCast(sender, TextBox).Text = ""
            e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart)
        End If

        If Not e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart)
        End If
    End Sub


    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
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
            If IsNumeric(txtNumeroP.Text) Then
                AC.NumFacturaProveedor = Convert.ToInt32(txtNumeroP.Text)
            End If
        End If

        Try
            AC.AgregarLineas(_Compra.Lineas)
            GesDocumentos.getInstance().IngresarCompra(AC)
            frmSuccess.FormCorrecto("Compra facturada correctamente")
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFacturar_MouseHover(sender As Object, e As EventArgs) Handles btnFacturar.MouseHover

    End Sub

    Private Sub btnBorrarLinea_Click(sender As Object, e As EventArgs) Handles btnBorrarLinea.Click
        If dgCompras.RowCount > 0 Then
            Dim xLinea As Decimal = dgCompras.Item("LINEA", dgCompras.SelectedRows(0).Index).Value
            _Compra.BorrarLinea(xLinea)
            Popular()
        End If
    End Sub



    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtReferencia_TextChanged(sender As Object, e As EventArgs) Handles txtReferencia.TextChanged

    End Sub
End Class