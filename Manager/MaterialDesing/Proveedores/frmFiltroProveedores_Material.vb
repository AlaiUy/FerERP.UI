Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmFiltroProveedores_Material
    Implements IObservable

    Private _Observers As List(Of IObserver)
    'Private _lista As List(Of Articulo)
    Private _TablaProveedores As DataTable
    Private _ListaFiltrada As DataTable
    Private _Cantidad As Decimal = 0
    Private mIndex As Byte = 1 'Columna seleccionada
    Private mActiva As String = "CODIGO" ' Nombre columna activa
    Private mFiltro As String = ""
    Private ColorContado As Color = Color.FromArgb(192, 255, 192)
    Private ColorCredito As Color = Color.FromArgb(255, 87, 51)
    Private _Proveedor As Proveedor

    Public Sub New(ByVal xObserver As IObserver)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Register(xObserver)
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        notifyObservers("CERRAR")
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

    Private Sub frmFiltroProveedores_Material_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                notifyObservers("CERRAR")
            Case Keys.F2
                dgItemsView.DataSource = _TablaProveedores
                _ListaFiltrada = _TablaProveedores
        End Select
    End Sub

    Private Sub dgItemsView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgItemsView.ColumnHeaderMouseClick
        mFiltro = ""
        mActiva = (sender.Columns(e.ColumnIndex).Name)
        For Each C As DataGridViewColumn In dgItemsView.Columns
            'If C.Visible Then
            '    Select Case C.Name
            '        Case "CONTADO"
            '            C.DefaultCellStyle.BackColor = ColorContado

            '        Case Else
            '            C.DefaultCellStyle.BackColor = Color.White


            '    End Select

            'End If
        Next
        With sender
            .Columns(e.ColumnIndex).DefaultCellStyle.BackColor = Color.Beige
        End With
        mIndex = e.ColumnIndex

        If txtReferencia.Text.Length > 1 Then
            Try
                _ListaFiltrada = (From Cliente In _ListaFiltrada.AsEnumerable()
                                  Where Cliente(mActiva).Contains(txtReferencia.Text.ToUpper())
                                  Select Cliente).CopyToDataTable()
                dgItemsView.DataSource = _ListaFiltrada
                txtReferencia.Clear()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub frmFiltroProveedores_Material_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _TablaProveedores = GesPersonas.getInstance().getVistaProveedores()
            _ListaFiltrada = _TablaProveedores
            dgItemsView.DataSource = _ListaFiltrada
            Funciones.DoubleBuffered(dgItemsView, True)
            PopularGrilla()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PopularGrilla()
        Dim SumaAnchos As Decimal = 1
        dgItemsView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        dgItemsView.Columns("CODIGO").Visible = False
        'dgProveedores.Columns("MONEDA").Visible = LeerIni.LeerDato("VISTA_ARTICULOS", "MONEDA", 0, ".\config.ini")
        'dgProveedores.Columns("ACTIVO").Visible = LeerIni.LeerDato("VISTA_ARTICULOS", "ACTIVO", 0, ".\config.ini")
        'dgProveedores.Columns("MARCA").Visible = LeerIni.LeerDato("VISTA_ARTICULOS", "MARCA", 0, ".\config.ini")
        'dgProveedores.Columns("MODELO").Visible = LeerIni.LeerDato("VISTA_ARTICULOS", "MODELO", 0, ".\config.ini")
        'dgProveedores.Columns("STOCK").Visible = LeerIni.LeerDato("VISTA_ARTICULOS", "STOCK", 0, ".\config.ini")
        'dgProveedores.Columns("DESCRIPCION").Visible = LeerIni.LeerDato("VISTA_ARTICULOS", "DESCRIPCION", 0, ".\config.ini")


        With dgItemsView
            For Each ObjCol As DataGridViewColumn In .Columns
                ObjCol.SortMode = DataGridViewColumnSortMode.Programmatic
            Next
            .Columns(mIndex).DefaultCellStyle.BackColor = Color.Beige
        End With

    End Sub

    Private Sub dgItemsView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgItemsView.CellClick
        SeleccionarProveedor(e.RowIndex)
    End Sub

    Private Sub SeleccionarProveedor(ByVal xIndex As Integer)
        If xIndex = -1 Then
            Return
        End If
        Dim xCod As String
        Dim xIndexColumn As Integer = dgItemsView.Columns("CODIGO").Index
        xCod = dgItemsView.Item(xIndexColumn, xIndex).Value
        Try
            _Proveedor = GesPersonas.getInstance().getProveedorById(xCod)
            Me.Hide()
            notifyObservers(_Proveedor)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class