Imports System.Windows.Forms
Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmNuevaVenta
    Implements IObserver

    Private _Vendedor As Vendedor = Nothing
    Private Art As Articulo
    Private ListLineas As List(Of Facturalin) = New List(Of Facturalin)
    Private esp As UESPERA

    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Sub New(ByVal xVendedor As Vendedor)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _Vendedor = xVendedor
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub FormatearForm()
        txtImporte.BackColor = Color.White
        txtCantidad.BackColor = Color.White
        If Not IsNothing(_Vendedor) Then
            lblVendedor.Text = _Vendedor.Nombre
        End If
        Popular()
        PopularGrilla()
    End Sub

    Private Sub PopularGrilla()
        Dim SumaAnchos As Decimal = 1
        For Each C As DataGridViewColumn In DgItemsView.Columns
            If C.Visible Then
                SumaAnchos += C.Width
            End If
        Next
        DgItemsView.Columns("NOMBRE").Width += DgItemsView.Width - (SumaAnchos)

    End Sub

    Private Sub seleccionadVendedor()
        If IsNothing(_Vendedor) Then
            Dim Form As frmVendedores = New frmVendedores()
            Form.TopMost = True
            Form.StartPosition = FormStartPosition.CenterScreen
            Form.Register(Me)
            Form.ShowDialog()
        End If
    End Sub
    Private Sub frmNuevaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        While (IsNothing(_Vendedor))
            FormatearForm()
            seleccionadVendedor()

        End While
        esp = New UESPERA()
        esp.Codvendedor = _Vendedor.Codigo
    End Sub

    Private Sub LnkSearchClient_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkSearchItem.LinkClicked
        Dim frmListArticulos As frmArticulos = New frmArticulos()
        frmListArticulos.Show()
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub txtCodArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodArticulo.KeyDown

    End Sub

    Private Sub Popular()
        Dim Total As Decimal = 0
        If Not IsNothing(esp) Then
            For Each Linea As Esperalin In esp.Lineas
                AgregarLinea(Linea.ObjArticulo.CodArticulo, Linea.ObjArticulo.Nombre, Linea.Cantidad, FormatearImporte(Linea.PrecioUnitarioConIva), Linea.Descuento, FormatearImporte(Linea.PrecioTotalConDescuento), Linea.NumLinea)
                Total += Linea.PrecioTotalConDescuento
            Next

        End If
        txtImporte.Text = FormatearImporte(Total)
    End Sub

    Private Sub AgregarLinea(ByVal xCodigo As String, ByVal xNombre As String, ByVal xCantidad As String, ByVal xImporte As String, ByVal xDescuento As String, ByVal xTotal As String, ByVal xLinea As String)
        DgItemsView.Rows.Add(xCodigo, xNombre, xCantidad, xImporte, xDescuento, xTotal, xLinea)
    End Sub

    Private Sub DgItemsView_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgItemsView.CellMouseEnter
        If ((e.RowIndex < 0) OrElse (e.ColumnIndex < 0)) Then Return

        If DgItemsView.Columns(e.ColumnIndex).Name = "NOMBRE" Then
            Dim codigo As Integer = Me.DgItemsView.Item("CODIGO", e.RowIndex).Value
            Try
                Art = esp.getArticuloByCodigo(codigo)
                Dim column As DataGridViewColumn = DgItemsView.Columns(e.ColumnIndex)
                Dim row As DataGridViewRow = DgItemsView.Rows(e.RowIndex)
                Dim value As Object = row.Cells(column.Name).Value

                Dim OtrosDatos As String = String.Format("Descipcion: {0}{1}{2}", Art.Descripcion, Environment.NewLine, Art.Referencia)
                ToolTip1.Active = True
                ToolTip1.ShowAlways = True
                ToolTip1.SetToolTip(DgItemsView, OtrosDatos)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub DgItemsView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgItemsView.CellClick

    End Sub

    Private Sub DgItemsView_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DgItemsView.CellMouseLeave
        ToolTip1.Active = False
    End Sub

    Private Sub txtCodArticulo_TextChanged(sender As Object, e As EventArgs) Handles txtCodArticulo.TextChanged

    End Sub

    Private Sub txtCodArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodArticulo.KeyPress
        If e.KeyChar = "+" Then
            e.Handled = True
            Try
                Dim Cantidad As Decimal = Convert.ToDecimal(txtCodArticulo.Text)
                txtCantidad.Text = Cantidad
                txtCodArticulo.Text = String.Empty
                txtCodArticulo.Focus()
            Catch ex As Exception

            End Try

        End If

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Try
                Art = GesArticulos.getInstance().getArticuloById(Convert.ToInt32(txtCodArticulo.Text))
            Catch ex As Exception
                MsgBox(ex.Message)
                Return
            End Try

            Dim EL As Esperalin = New Esperalin(Art, Art.Descripcion, Convert.ToDecimal(txtCantidad.Text), 0, esp.Lineas.Count + 1)
            esp.AgregarLinea(EL)
            Popular()
            txtCodArticulo.Text = String.Empty
            txtCodArticulo.Focus()
            txtCantidad.Text = 1
        End If

    End Sub

    Private Sub btnCantidad_Click(sender As Object, e As EventArgs) Handles btnCantidad.Click
        Dim xCantidad As Decimal
        Dim frmNumber As frmPanelNumerico = New frmPanelNumerico()
        frmNumber.ShowDialog()
        If frmNumber.DialogResult = DialogResult.OK Then
            xCantidad = frmNumber.Numero
        End If
        esp.CambiarCantidad(xCantidad, DgItemsView.Item("LINEA", DgItemsView.CurrentRow.Index).Value)
        Popular()
    End Sub

    Private Sub btnBorrarLinea_Click(sender As Object, e As EventArgs) Handles btnBorrarLinea.Click

        esp.BorrarLinea(DgItemsView.Item("LINEA", DgItemsView.CurrentRow.Index).Value)
        Popular()
    End Sub

    Private Sub btnDescuentoLineal_Click(sender As Object, e As EventArgs) Handles btnDescuentoLineal.Click
        Dim xDescuento As Decimal = 0
        Dim frmNumber As frmPanelNumerico = New frmPanelNumerico()
        frmNumber.ShowDialog()
        If frmNumber.DialogResult = DialogResult.OK Then
            xDescuento = frmNumber.Numero
        End If
        esp.AsignarDescuento(xDescuento, DgItemsView.Item("LINEA", DgItemsView.CurrentRow.Index).Value)
        Popular()
    End Sub

    Private Sub btnDescuentoTotal_Click(sender As Object, e As EventArgs) Handles btnDescuentoTotal.Click
        Dim xDescuento As Decimal = 0
        Dim frmNumber As frmPanelNumerico = New frmPanelNumerico()
        frmNumber.ShowDialog()
        If frmNumber.DialogResult = DialogResult.OK Then
            xDescuento = frmNumber.Numero
        End If
        esp.AllDescuento(xDescuento)
        Popular()
    End Sub

    Private Sub btnNuevaVenta_Click(sender As Object, e As EventArgs) Handles btnNuevaVenta.Click
        Dim frmTipoVenta As Form = New frmSeleccionTipoVenta(esp)
        frmTipoVenta.ShowDialog()
    End Sub

    Public Overloads Sub Update(Obj As Object) Implements IObserver.Update
        If TypeOf Obj Is Vendedor Then
            _Vendedor = DirectCast(Obj, Vendedor)
            MsgBox(_Vendedor.Nombre)
        End If
    End Sub




End Class