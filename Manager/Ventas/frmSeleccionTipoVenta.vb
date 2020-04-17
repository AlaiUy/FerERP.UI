Imports JJ.Entidades
Imports JJ.Interfaces.Observer

Public Class frmSeleccionTipoVenta
    Private Espera As UESPERA
    Private _Obs As IObserver
    Public Sub New(ByVal xEspera As UESPERA, ByVal xObserver As IObserver)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Espera = xEspera
        _Obs = xObserver
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnContado_Click(sender As Object, e As EventArgs) Handles btnContado.Click
        Dim DatosVenta As New frmDatosFactura(GetType(EsperaContado), Espera)
        DatosVenta.Register(_Obs)
        DatosVenta.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnCredito_Click(sender As Object, e As EventArgs) Handles btnCredito.Click
        Dim DatosVenta As New frmDatosFactura(GetType(EsperaCredito), Espera)
        DatosVenta.Register(_Obs)
        DatosVenta.ShowDialog()
        Me.Close()
    End Sub
End Class