Imports JJ.Entidades

Public Class frmSeleccionTipoVenta
    Private Espera As UESPERA
    Public Sub New(ByVal xEspera As UESPERA)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Espera = xEspera
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnContado_Click(sender As Object, e As EventArgs) Handles btnContado.Click
        Dim DatosVenta As New frmDatosFactura(GetType(EsperaContado), Espera)
        DatosVenta.ShowDialog()
    End Sub
End Class