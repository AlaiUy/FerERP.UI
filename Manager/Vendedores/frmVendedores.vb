Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmVendedores
    Implements IObservable

    Private _MeMiran As List(Of IObserver)
    Private _Vendedores As IList(Of Object)
    Private _Codvendedor As Integer

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _MeMiran = New List(Of IObserver)
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub



    Private Sub frmVendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Vendedores = GesVendedores.getInstance().getListaVendedores()
        Popular()
    End Sub

    Private Sub Popular()
        For Each O As Object In _Vendedores
            Dim B As Button = New Button()
            B.Size = New Size(100, 100)
            B.Text = TryCast(O, Vendedor).Codigo & vbLf & TryCast(O, Vendedor).Nombre
            B.Font = New Font("ARIAL", 15)
            B.TextAlign = ContentAlignment.MiddleCenter
            B.Name = TryCast(O, Vendedor).Codigo
            B.FlatStyle = FlatStyle.Flat
            B.ForeColor = Color.DarkRed
            AddHandler B.Click, AddressOf B_click
            FlowPanel.Controls.Add(B)
        Next
    End Sub

    Private Sub B_click(sender As Object, e As EventArgs)
        _Codvendedor = TryCast(sender, Button).Name
        notifyObservers()
        Me.Close()
    End Sub

    Private Sub frmVendedores_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
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
            Dim Ve As Vendedor = GesVendedores.getInstance().getVendedorByID(_Codvendedor)
            Ob.Update(Ve)
        Next
    End Sub
End Class