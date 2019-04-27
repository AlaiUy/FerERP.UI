Public Class frmPanelNumerico
    Private _Numero As Decimal = 0

    Public ReadOnly Property Numero As Decimal
        Get
            Return _Numero
        End Get

    End Property

    Private Sub frmPanelNumerico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumero.Text = 0
    End Sub

    Private Sub Enter_Click(sender As Object, e As EventArgs) Handles Enter.Click
        Try
            _Numero = Convert.ToDecimal(txtNumero.Text)
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            MsgBox("El valor ingresado no es correcto", vbOK, "Revisar")
        End Try
    End Sub
End Class