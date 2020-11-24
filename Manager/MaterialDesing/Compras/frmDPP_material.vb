Imports JJ.Entidades
Imports JJ.Gestoras

Public Class frmDPP_material
    Private _Proveedor As Proveedor

    Public Sub New(ByVal xProveedor As Proveedor)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        _Proveedor = xProveedor

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Close()
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        If txtAdenda.Text.Length > 500 Then
            MsgBox("la adenda tiene mas de 500 caracteres", vbOK, "Verificar")
            Return
        End If

        Dim xImporte As Decimal = 0

        Try
            xImporte = Convert.ToDecimal(txtImporte.Text)
            Dim NC As AlbaranCompraNC
            Dim SCompra As Seriedoc = GesCajas.getInstance().Caja().getSerieByID(21)
            Dim Moneda As Moneda = GesPrecios.getInstance().getMonedaByID(_Proveedor.CodMoneda)
            NC = New AlbaranCompraNC(SCompra.Serie, Date.Now, _Proveedor.Codigo, Moneda)
            NC.SerieFacturaProveedor = txtSerie.Text
            NC.Adenda = txtAdenda.Text
            If txtNumero.Text.Length > 0 Then
                If IsNumeric(txtNumero.Text) Then
                    NC.NumFacturaProveedor = Convert.ToInt32(txtNumero.Text)
                End If
            End If

            Try
                Dim Art As Articulo = GesArticulos.getInstance().getArticuloByRef("DPP")
                Dim CLin As CompraLin = New CompraLin(Art, "N/C", 1, 0, 1, xImporte / 1.22)
                NC.AgregarLinea(CLin)
                GesDocumentos.getInstance().IngresarCompra(NC)
                frmSuccess.FormCorrecto("Compra facturada correctamente")
            Catch ex As Exception

                MsgBox(ex.Message)
            End Try
        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporte.KeyPress
        If (TryCast(sender, TextBox).SelectedText.Length = TryCast(sender, TextBox).TextLength) Then
            TryCast(sender, TextBox).Text = ""
            e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart)
        End If

        If Not e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart)
        End If
    End Sub

    Private Sub txtImporte_TextChanged(sender As Object, e As EventArgs) Handles txtImporte.TextChanged

    End Sub

    Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click

    End Sub

    Private Sub frmDPP_material_Load(sender As Object, e As EventArgs) Handles Me.Load
        Popular()
    End Sub

    Private Sub Popular()
        txtProveedor.Text = _Proveedor.ToString()
    End Sub
End Class