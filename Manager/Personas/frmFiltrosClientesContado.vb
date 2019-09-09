Imports JJ.Entidades
Imports JJ.Gestoras

Public Class frmFiltrosClientesContado

    Private ClientesContado As Object = Nothing
    Private ClientesFiltrados As DataTable = Nothing

    Private mIndex As Byte = 0 'Columna seleccionada
    Private mActiva As String = "CODIGO" ' Nombre columna activa
    Private mFiltro As String = ""
    Private mCodCliente As Integer
    Private _Cliente As ClienteContado

    Public ReadOnly Property Cliente As ClienteContado
        Get
            Return _Cliente
        End Get
    End Property

    Private Sub frmFiltrosClientesContado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientesContado = TryCast(GesPersonas.getInstance().TablaClientesContado(), DataTable)
        ClientesFiltrados = TryCast(ClientesContado, DataTable)
        DGV_CLIENTES.DataSource = ClientesFiltrados

        Funciones.DoubleBuffered(DGV_CLIENTES, True)
        With DGV_CLIENTES
            .DataSource = ClientesFiltrados
            For Each ObjCol As DataGridViewColumn In .Columns
                ObjCol.SortMode = DataGridViewColumnSortMode.Programmatic
            Next
            .Columns(mIndex).DefaultCellStyle.BackColor = Color.Beige
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub

    Private Sub frmFiltrosClientesContado_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.F2
                ClientesFiltrados = ClientesContado
                DGV_CLIENTES.DataSource = ClientesFiltrados
        End Select
    End Sub

    Private Sub DGV_CLIENTES_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_CLIENTES.ColumnHeaderMouseClick
        mFiltro = ""
        mActiva = (sender.Columns(e.ColumnIndex).Name)
        With sender
            .Columns(mIndex).DefaultCellStyle.BackColor = Color.White
            .Columns(e.ColumnIndex).DefaultCellStyle.BackColor = Color.Beige
        End With
        mIndex = e.ColumnIndex

        If txtDato.Text.Length > 1 Then
            Try

                ClientesFiltrados = (From Cliente In ClientesFiltrados.AsEnumerable()
                                     Where Cliente(mActiva).Contains(txtDato.Text.ToUpper())
                                     Select Cliente).CopyToDataTable()
                DGV_CLIENTES.DataSource = ClientesFiltrados
                txtDato.Clear()
            Catch ex As Exception


            End Try
        End If
    End Sub

    Private Sub DGV_CLIENTES_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_CLIENTES.CellMouseDoubleClick
        mCodCliente = DGV_CLIENTES.Item("CODIGO", DGV_CLIENTES.CurrentRow.Index).Value()
        Try
            _Cliente = GesPersonas.getInstance().getClienteContadoByID(mCodCliente)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.DialogResult = DialogResult.Abort
        End Try

    End Sub

    Private Sub DGV_CLIENTES_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_CLIENTES.CellContentClick

    End Sub
End Class