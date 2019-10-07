Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmVendedores_Material
    Implements IObservable

    Private _MeMiran As List(Of IObserver)
    Private _Vendedores As List(Of Object) = New List(Of Object)
    Private _Vendedor As Vendedor = Nothing


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _MeMiran = New List(Of IObserver)
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub Register(xObserver As IObserver) Implements IObservable.Register
        'If IsNothing(_MeMiran.Find(xObserver)) Then
        '    Return
        'End If
        _MeMiran.Add(xObserver)
    End Sub

    Public Sub UnRegister(xObserver As IObserver) Implements IObservable.UnRegister
        _MeMiran.Remove(xObserver)
    End Sub

    Public Sub notifyObservers() Implements IObservable.notifyObservers
        For Each Ob As IObserver In _MeMiran
            Ob.Update(_Vendedor)
        Next
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        _Vendedor = _Vendedores.Find(Function(V As Vendedor) V.Codigo = 1)
        notifyObservers()
        Close()
    End Sub

    Private Sub frmVendedores_Material_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Vendedores = GesVendedores.getInstance().getListaVendedores()
        DGVendedores.DataSource = _Vendedores
        DGVendedores.Columns("ACTIVO").Visible = False
    End Sub

    Private Sub DGVendedores_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVendedores.CellContentDoubleClick

    End Sub

    Private Sub DGVendedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVendedores.CellContentClick

    End Sub

    Private Sub DGVendedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVendedores.CellClick
        _Vendedor = _Vendedores.Find(Function(V As Vendedor) V.Codigo = DGVendedores.Item("CODIGO", DGVendedores.CurrentRow.Index).Value)
        notifyObservers()
        Close()
    End Sub
End Class