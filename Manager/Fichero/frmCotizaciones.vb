Imports JJ.Entidades
Imports JJ.Gestoras

Public Class frmCotizaciones
    Private _Monedas As List(Of Object) = Nothing
    Private Sub frmCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _Monedas = GesPrecios.getInstance().getMonedas()
            cbMonedas.DataSource = _Monedas.FindAll(Function(Mon) Mon.Codigo > 1)
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim Cotizacion As Decimal = 0
        Try
            Cotizacion = Convert.ToDecimal(txtCotizacion.Text)
            GesEmpresa.getInstance().ChangeCot(Cotizacion, cbMonedas.SelectedItem)
            MsgBox("Cotizacion actualizada con exito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtCotizacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCotizacion.KeyPress
        e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart, 2)
    End Sub
End Class