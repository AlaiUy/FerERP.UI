Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer
Imports JJ.Reportes

Public Class frmPresupuestos_Material
    Implements IObserver
    Private _Obs As IList(Of IObserver)
    Private frmListArticulos As Form = Nothing
    Private _presupuesto As Presupuesto = New Presupuesto()

    Private Sub PopularGrilla()
        For Each column As DataGridViewColumn In dgCompras.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next



        dgCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        dgCompras.Columns("CODIGO").Visible = False
        dgCompras.Columns("LINEA").Visible = False

        dgCompras.Columns("CODIGO").ReadOnly = True
        dgCompras.Columns("LINEA").ReadOnly = True
        dgCompras.Columns("REFERENCIA").ReadOnly = True
        dgCompras.Columns("NOMBRE").ReadOnly = True
        dgCompras.Columns("CANTIDAD").ReadOnly = True
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
        dgCompras.Columns("FINAL").DefaultCellStyle = EstiloDerecha

        txtImporte.Text = JJ.Entidades.Estilos.FormatearImporte(_presupuesto.Total())
    End Sub

    Public Sub Update(Obj As Object) Implements IObserver.Update
        If TypeOf Obj Is Articulo Then
            Dim _A As Articulo = TryCast(Obj, Articulo)
            _presupuesto.addLinea(New PresupuestoLin(_A, _A.Nombre, Convert.ToDecimal(txtCantidad.Text), _A.Precio(), _A.Iva.Valor, 0))
            Popular()
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

    Private Sub frmPresupuestos_Material_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Estilos.Redondear(Panel5, 5)
        cbMonedas.DataSource = GesPrecios.getInstance().getMonedas()
    End Sub

    Private Sub dgCompras_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCompras.ColumnHeaderMouseClick
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
            _presupuesto.CambiarPrecio(dgCompras.Item("CODIGO", dgCompras.CurrentRow.Index).Value, xPrecio)
            Popular()
        End If

        If e.ColumnIndex = dgCompras.Columns("CANTIDAD").Index Then
            Dim xPrecio As Decimal
            Dim frmNumber As frmPanelNumerico = New frmPanelNumerico()
            frmNumber.ShowDialog()
            If frmNumber.DialogResult = DialogResult.OK Then
                xPrecio = frmNumber.Numero
                If xPrecio < 0 Then
                    xPrecio = 1
                End If
            End If
            _presupuesto.CambiarCantidad(dgCompras.Item("CODIGO", dgCompras.CurrentRow.Index).Value, xPrecio)
            Popular()
        End If
    End Sub

    Private Sub Popular()
        dgCompras.DataSource = _presupuesto.Popular()
        PopularGrilla()
        FijarAnchos()
    End Sub
    Private Sub FijarAnchos()
        dgCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        dgCompras.Columns("FINAL").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Dim SumaAnchos As Decimal = 0
        For Each C As DataGridViewColumn In dgCompras.Columns
            If C.Visible Then
                SumaAnchos += C.Width
            End If
        Next
        dgCompras.Columns("NOMBRE").Width += dgCompras.Width - (SumaAnchos)
    End Sub

    Private Sub btnBorrarLinea_Click(sender As Object, e As EventArgs) Handles btnBorrarLinea.Click
        If dgCompras.RowCount > 0 Then
            _presupuesto.BorrarLinea(dgCompras.Item("CODIGO", dgCompras.CurrentRow.Index).Value, dgCompras.Item("CANTIDAD", dgCompras.CurrentRow.Index).Value)
            Popular()
        End If
    End Sub

    Private Sub btnDescuento_Click(sender As Object, e As EventArgs) Handles btnDescuento.Click
        Dim xPrecio As Decimal
        Dim frmNumber As frmPanelNumerico = New frmPanelNumerico()
        frmNumber.ShowDialog()
        If frmNumber.DialogResult = DialogResult.OK Then
            xPrecio = frmNumber.Numero
            _presupuesto.AsignarDescuento(xPrecio)
        End If
        Popular()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Try
            Dim xDias As Integer = 1
            If txtDias.Text.Length > 0 Then
                If IsNumeric(txtDias.Text) Then
                    xDias = Convert.ToInt32(txtDias.Text)
                End If
            End If
            Dim DT As DataTable = _presupuesto.Popular()
            DT.TableName = "Presupuesto"
            GestionReporte.Presupuesto(DT, xDias, txtPago.Text, "0", txtNombre.Text, txtDireccion.Text, TryCast(cbMonedas.SelectedItem, Moneda).SubFijo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        Try
            GesDocumentos.getInstance().GesFacturar()
        Catch ex As Exception

        End Try
    End Sub
End Class