Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmCobros_Material
    Implements IObserver

    Private _Caja As Caja
    Private _Recibo As PreRecibo

    'formularios banderas
    Private _fProveedores As frmListaProveedores = Nothing
    Private _Proveedor As Proveedor = Nothing
    Private _Movimientos As List(Of Object)
    Private _Pesos As Decimal = 0
    Private _Dolares As Decimal = 0


    Public Overloads Sub Update(Obj As Object) Implements IObserver.Update
        If TypeOf Obj Is Proveedor Then
            _Proveedor = TryCast(Obj, Proveedor)
            txtCodProveedor.Text = _Proveedor.Codigo
            txtNombreProveedor.Text = _Proveedor.Nombre
            _Movimientos = GesDocumentos.getInstance().getMovimientosPPendientes(_Proveedor.Codigo)
            PopularForm()
            PopularTabla()
            PopularGrilla()

            If Not IsNothing(_fProveedores) Then
                _fProveedores.Close()
            End If
        End If
    End Sub
    Private Sub IconButton3_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PopularGrilla()
        For Each column As DataGridViewColumn In dgCompras.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        dgCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None


        Dim EstiloIzquierda As DataGridViewCellStyle = New DataGridViewCellStyle()
        EstiloIzquierda.Alignment = DataGridViewContentAlignment.BottomLeft

        Dim EstiloDerecha As DataGridViewCellStyle = New DataGridViewCellStyle()
        EstiloDerecha.Alignment = DataGridViewContentAlignment.BottomRight

        Dim EstiloCentro As DataGridViewCellStyle = New DataGridViewCellStyle()
        EstiloCentro.Alignment = DataGridViewContentAlignment.BottomCenter

        dgCompras.Columns("FECHA").DefaultCellStyle = EstiloCentro
        dgCompras.Columns("SERIE").DefaultCellStyle = EstiloCentro
        dgCompras.Columns("NUMERO").DefaultCellStyle = EstiloCentro
        dgCompras.Columns("MONEDA").DefaultCellStyle = EstiloCentro
        dgCompras.Columns("IMPORTE").DefaultCellStyle = EstiloDerecha
        dgCompras.Columns("LINEA").DefaultCellStyle = EstiloCentro
        dgCompras.Columns("PAGO").DefaultCellStyle = EstiloDerecha



        For Each C As DataGridViewColumn In dgCompras.Columns
            If C.Name <> "PAGO" Then
                C.ReadOnly = True
            End If
        Next




    End Sub

    Private Sub PopularForm()
        If Not IsNothing(_Movimientos) Then
            dgCompras.DataSource = PopularTabla()
            txtDeudaPesos.Text = FormatearImporte(_Pesos)
            txtDeudaDolares.Text = FormatearImporte(_Dolares)
        End If

    End Sub

    Private Function PopularTabla() As Object
        Dim T As DataTable = New DataTable("PENDIENTES")
        Dim ColFecha As DataColumn = T.Columns.Add("FECHA", System.Type.GetType("System.String"))
        Dim ColLinea As DataColumn = T.Columns.Add("LINEA", System.Type.GetType("System.String"))
        Dim ColSerie As DataColumn = T.Columns.Add("SERIE", Type.GetType("System.String"))
        Dim ColNumero As DataColumn = T.Columns.Add("NUMERO", Type.GetType("System.String"))
        Dim ColMoneda As DataColumn = T.Columns.Add("MONEDA", Type.GetType("System.String"))
        Dim ColImporte As DataColumn = T.Columns.Add("IMPORTE", Type.GetType("System.String"))
        Dim ColSaldo As DataColumn = T.Columns.Add("PAGO", Type.GetType("System.String"))
        _Pesos = 0
        _Dolares = 0
        For Each M As MovimientoP In _Movimientos
            Dim Row As DataRow = T.NewRow()
            If M.Moneda = 1 Then
                _Pesos += M.Importe
                Row("MONEDA") = "PESOS"
            Else
                _Dolares += M.Importe
                Row("MONEDA") = "DOLARES"
            End If
            Row("FECHA") = M.Fecha
            Row("LINEA") = M.Linea
            Row("SERIE") = M.SerieInterna
            Row("NUMERO") = M.NumeroInterno
            Row("IMPORTE") = FormatearImporte(M.Importe)
            If (M.Saldar = 0) Then
                Row("PAGO") = String.Empty
            Else
                Row("PAGO") = FormatearImporte(M.Saldar)
            End If

            T.Rows.Add(Row)
        Next
        Return T
    End Function

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        _fProveedores = New frmListaProveedores(Me)
        _fProveedores.Show()
    End Sub

    Private Sub RecargarFormulario()
        _Movimientos = GesDocumentos.getInstance().getMovimientosPPendientes(_Proveedor.Codigo)
        PopularForm()
        PopularTabla()
        PopularGrilla()
        _Recibo = Nothing
        _Pesos = 0
        _Dolares = 0
        _Recibo = New PreRecibo(Now, _Caja.getSerieByID(50).Serie)
        txtSaldarD.Text = FormatearImporte(0.00)
        txtSaldarP.Text = FormatearImporte(0.00)
    End Sub

    Private Sub dgCompras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCompras.CellClick
        If e.RowIndex = -1 Then
            Return
        End If
        If e.ColumnIndex <> dgCompras.Columns("PAGO").DisplayIndex Then
            Dim mTemp As Movimiento = Nothing
            mTemp = BuscarMovimiento(dgCompras.Rows(e.RowIndex).Cells("LINEA").Value, dgCompras.Rows(e.RowIndex).Cells("NUMERO").Value, dgCompras.Rows(e.RowIndex).Cells("SERIE").Value)
            mTemp.Saldar = mTemp.Importe
            _Recibo.AddMovimiento(mTemp)
            PopularForm()
            PopularRecibo()
            dgCompras.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Function BuscarMovimiento(ByVal xLinea As Integer, ByVal xNumero As Integer, ByVal xSerie As String) As Movimiento
        Return _Movimientos.Find(Function(M As Movimiento) M.Linea = xLinea And M.SerieInterna = xSerie And M.NumeroInterno = xNumero)
    End Function

    Private Sub frmCobros_Material_Load(sender As Object, e As EventArgs) Handles Me.Load
        _Caja = GesCajas.getInstance().Caja
        _Recibo = New PreRecibo(Now, _Caja.getSerieByID(50).Serie)
        Estilos.Redondear(Panel2, 5)
        Estilos.Redondear(Panel4, 5)
        Estilos.Redondear(Panel5, 5)
    End Sub

    Private Sub PopularRecibo()
        If Not IsNothing(_Recibo) Then
            txtSaldarD.Text = FormatearImporte(_Recibo.Total(2))
            txtSaldarP.Text = FormatearImporte(_Recibo.Total(1))
        End If
    End Sub

    Private Sub dgCompras_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgCompras.CellEndEdit
        If IsDBNull(TryCast(sender, DataGridView).Rows(e.RowIndex).Cells("PAGO").Value) Then
            Return
        End If

        If Not IsNumeric(TryCast(sender, DataGridView).Rows(e.RowIndex).Cells("PAGO").Value) Then
            TryCast(sender, DataGridView).Rows(e.RowIndex).Cells("PAGO").Value = String.Empty
            Return
        End If

        If TryCast(sender, DataGridView).Rows(e.RowIndex).Cells("PAGO").Value = 0 Then
            TryCast(sender, DataGridView).Rows(e.RowIndex).Cells("PAGO").Value = String.Empty
            Return
        End If



        If Not IsNumeric(TryCast(sender, DataGridView).Rows(e.RowIndex).Cells("PAGO").Value) Then
            Return
        End If

        Dim mTemp As Movimiento = Nothing
        mTemp = BuscarMovimiento(dgCompras.Rows(e.RowIndex).Cells("LINEA").Value, dgCompras.Rows(e.RowIndex).Cells("NUMERO").Value, dgCompras.Rows(e.RowIndex).Cells("SERIE").Value)
        mTemp.Saldar = dgCompras.Rows(e.RowIndex).Cells("PAGO").Value
        _Recibo.AddMovimiento(mTemp)
        PopularForm()
        PopularRecibo()
    End Sub



    Private Sub dgCompras_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgCompras.CellBeginEdit
        If Not IsNumeric(TryCast(sender, DataGridView).Rows(e.RowIndex).Cells("PAGO").Value) Then
            Return
        End If
    End Sub

    Private Sub dgCompras_CellParsing(sender As Object, e As DataGridViewCellParsingEventArgs) Handles dgCompras.CellParsing
        If Not IsNumeric(TryCast(sender, DataGridView).Rows(e.RowIndex).Cells("PAGO").Value) Then
            TryCast(sender, DataGridView).Rows(e.RowIndex).Cells("PAGO").Value = String.Empty
        End If
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        If _Recibo.Movimientos.Count <= 0 Then
            Return
        End If

        If ((_Recibo.Total(1) < 0) Or (_Recibo.Total(2) < 0)) Then
            MsgBox("No se puede realizar este recibo en multi moneda", vbOKOnly, "Verificar")
            Return
        End If
        Try
            GesCobros.getInstance().GenerarPago(_Recibo)
            frmSuccess.FormCorrecto("Recibo generado correctamente")
            RecargarFormulario()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnDPP_Click(sender As Object, e As EventArgs) Handles btnDPP.Click
        If dgCompras.RowCount <= 0 Then
            Return
        End If

        If dgCompras.SelectedRows.Count > 1 Then
            MsgBox("El descuento pronto pago es aplicable a una factura a la vez.", vbOK, "Verificar")
            Return
        End If

        Dim xSerieP As String = txtSerieP.Text
        Dim xNumeroP As Integer = -1
        If txtNumeroP.Text.Length > 0 And IsNumeric(txtNumeroP.Text) Then
            xNumeroP = Convert.ToInt32(txtNumeroP.Text)
        End If

        Dim xMovimiento As MovimientoP = BuscarMovimiento(dgCompras.SelectedRows(0).Cells("LINEA").Value, dgCompras.SelectedRows(0).Cells("NUMERO").Value, dgCompras.SelectedRows(0).Cells("SERIE").Value)

        Try
            If MsgBox("Desea hacer un DPP por el monto de: " & xMovimiento.Importe, vbOKCancel, "¿Estas seguro?") = MsgBoxResult.Ok Then
                GesDocumentos.getInstance().newDPP(xMovimiento, xMovimiento.Moneda, xMovimiento.Codproveedor, txtSerieP.Text, xNumeroP)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPagar_MouseHover(sender As Object, e As EventArgs) Handles btnPagar.MouseHover
        lblAcciones.Text = "Generar pago"
    End Sub

    Private Sub btnPagar_MouseLeave(sender As Object, e As EventArgs) Handles btnPagar.MouseLeave
        lblAcciones.Text = ""
    End Sub

    Private Sub btnPagar_MouseEnter(sender As Object, e As EventArgs) Handles btnPagar.MouseEnter
        lblAcciones.Text = "Generar pago"
    End Sub

    Private Sub btnDPP_MouseEnter(sender As Object, e As EventArgs) Handles btnDPP.MouseEnter
        lblAcciones.Text = "Generar DPP"
    End Sub

    Private Sub btnDPP_MouseLeave(sender As Object, e As EventArgs) Handles btnDPP.MouseLeave
        lblAcciones.Text = ""
    End Sub

    Private Sub dgCompras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCompras.CellContentClick

    End Sub
End Class