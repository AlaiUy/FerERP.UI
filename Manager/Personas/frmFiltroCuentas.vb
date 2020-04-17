Imports JJ.Gestoras

Public Class frmFiltroCuentas

    Private Cuentas As Object = Nothing
    Private ClientesFiltrados As DataTable = Nothing

    Private mIndex As Byte = 0 'Columna seleccionada
    Private mActiva As String = "CODIGO" ' Nombre columna activa
    Private mFiltro As String = ""
    Private mCodCliente As Integer
    'Private _Cliente As Cuenta

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub frmFiltroCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cuentas = TryCast(GesPersonas.getInstance().TablaClientesContado(), DataTable)
        'ClientesFiltrados = TryCast(ClientesContado, DataTable)
        DGV_CLIENTES.DataSource = ClientesFiltrados

        Funciones.DoubleBuffered(DGV_CLIENTES, True)
    End Sub
End Class