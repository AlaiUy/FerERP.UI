Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmListaProveedores
    Implements IObservable

    Private _lista As List(Of Proveedor)
    Private _TablaProveedores As DataTable
    Private _ListaFiltrada As DataTable
    Private _Observers As List(Of IObserver)
    Private _Proveedor As Proveedor = Nothing
    Private mIndex As Byte = 1 'Columna seleccionada
    Private mActiva As String = "CODIGO" ' Nombre columna activa
    Private mFiltro As String = ""

    Public Sub New(ByVal xObserver As IObserver)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Register(xObserver)
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub Register(xObserver As IObserver) Implements IObservable.Register
        If IsNothing(_Observers) Then
            _Observers = New List(Of IObserver)
        End If
        _Observers.Add(xObserver)
    End Sub

    Public Sub UnRegister(xObserver As IObserver) Implements IObservable.UnRegister
        For Each O As IObserver In _Observers
            If (O.Equals(xObserver)) Then
                _Observers.Remove(O)
            End If
        Next
    End Sub

    Public Sub notifyObservers() Implements IObservable.notifyObservers
        For Each O As IObserver In _Observers
            O.Update(_Proveedor)
        Next
    End Sub

    Public Sub notifyObservers(ByVal xNotificar As Object)
        For Each O As IObserver In _Observers
            O.Update(xNotificar)
        Next
    End Sub

    Private Sub frmListaProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _TablaProveedores = GesPersonas.getInstance().getVistaProveedores()
            _ListaFiltrada = _TablaProveedores
            dgProveedores.DataSource = _ListaFiltrada
            Funciones.DoubleBuffered(dgProveedores, True)
            PopularGrilla()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PopularGrilla()
        Dim SumaAnchos As Decimal = 1
        dgProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        dgProveedores.Columns("CODIGO").Visible = False
        'dgProveedores.Columns("MONEDA").Visible = LeerIni.LeerDato("VISTA_ARTICULOS", "MONEDA", 0, ".\config.ini")
        'dgProveedores.Columns("ACTIVO").Visible = LeerIni.LeerDato("VISTA_ARTICULOS", "ACTIVO", 0, ".\config.ini")
        'dgProveedores.Columns("MARCA").Visible = LeerIni.LeerDato("VISTA_ARTICULOS", "MARCA", 0, ".\config.ini")
        'dgProveedores.Columns("MODELO").Visible = LeerIni.LeerDato("VISTA_ARTICULOS", "MODELO", 0, ".\config.ini")
        'dgProveedores.Columns("STOCK").Visible = LeerIni.LeerDato("VISTA_ARTICULOS", "STOCK", 0, ".\config.ini")
        'dgProveedores.Columns("DESCRIPCION").Visible = LeerIni.LeerDato("VISTA_ARTICULOS", "DESCRIPCION", 0, ".\config.ini")


        With dgProveedores
            For Each ObjCol As DataGridViewColumn In .Columns
                ObjCol.SortMode = DataGridViewColumnSortMode.Programmatic
            Next
            .Columns(mIndex).DefaultCellStyle.BackColor = Color.Beige
        End With


    End Sub

    Private Sub dgProveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProveedores.CellDoubleClick
        Dim xCod As String
        Dim xIndexColumn As Integer = dgProveedores.Columns("CODIGO").Index
        xCod = dgProveedores.Item(xIndexColumn, e.RowIndex).Value
        Try
            _Proveedor = GesPersonas.getInstance().getProveedorById(xCod)
            notifyObservers(_Proveedor)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgProveedores_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgProveedores.ColumnHeaderMouseClick
        mFiltro = ""
        mActiva = (sender.Columns(e.ColumnIndex).Name)
        With sender
            .Columns(mIndex).DefaultCellStyle.BackColor = Color.White
            .Columns(e.ColumnIndex).DefaultCellStyle.BackColor = Color.Beige
        End With
        mIndex = e.ColumnIndex

        If txtReferencia.Text.Length > 1 Then
            Try

                _ListaFiltrada = (From Cliente In _TablaProveedores.AsEnumerable()
                                  Where Cliente(mActiva).Contains(txtReferencia.Text.ToUpper())
                                  Select Cliente).CopyToDataTable()
                dgProveedores.DataSource = _ListaFiltrada
                txtReferencia.Clear()
            Catch ex As Exception


            End Try
        End If
    End Sub
End Class