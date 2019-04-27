Imports System.ComponentModel
Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmNuevoArticulo
    Implements IObserver, IObservable
    Private Observadores As List(Of IObserver) = New List(Of IObserver)
    Private _Tarifas As List(Of Object)
    Private _Monedas As List(Of Object)
    Private _Departamentos As List(Of Object)
    Private _PreciosVenta As IList(Of Object)
    Private _Marcas As IList(Of Object)

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub



    Private Sub frmNuevoArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopularFormulario()
        Try

            _Tarifas = GesPrecios.getInstance().getTarifas()
            _Monedas = GesPrecios.getInstance().getMonedas()
            _Departamentos = GesArticulos.getInstance().getDepartamentos()
            _Marcas = GesArticulos.getInstance().getMarcas()
            Popular()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs)
        Popular()
    End Sub

    Private Sub Popular()
        Try
            cbMoneda.DataSource = _Monedas
            cbDepartamento.DataSource = _Departamentos
            If Not IsNothing(cbDepartamento.SelectedItem) Then
                cbSeccion.DataSource = TryCast(cbDepartamento.SelectedItem, Departamento).Secciones()
            End If
            cbMarca.DataSource = _Marcas
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart, 2)
    End Sub

    Private Sub txtGanancia_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart, 2)
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim CodMoneda As Integer = TryCast(cbMoneda.SelectedItem, Moneda).Codigo
        Dim A = New Articulo(txtDescripcion.Text, txtReferencia.Text, txtCosto.Text, txtIva.Text, txtGanancia.Text, CodMoneda)
        A.Activo = 1
        A.Codbarras = txtCodBarras.Text
        A.Codbarras1 = txtCodBarras1.Text
        A.Nombre = txtNombre.Text
        A.Coddepto = TryCast(cbDepartamento.SelectedItem, Departamento).Codigo
        A.Codmarca = TryCast(cbMarca.SelectedItem, Marca).Codigo
        A.Codseccion = TryCast(cbSeccion.SelectedItem, Seccion).Codigo
        A.Modelo = txtModelo.Text
        Try
            GesArticulos.getInstance().AddArticulo(A)
            MsgBox("Agregado con exito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddMarca_Click(sender As Object, e As EventArgs)
        Dim F As Form = New frmNuevaMarca(Me)
        F.Show()
    End Sub

    Public Overloads Sub Update(Obj As Object) Implements IObserver.Update
        If TypeOf Obj Is Marca Then
            _Marcas = GesArticulos.getInstance().getMarcas()
            Popular()
        End If
        If TypeOf Obj Is Departamento Then
            _Departamentos = GesArticulos.getInstance().getDepartamentos()
            Popular()
        End If
    End Sub

    Private Sub frmNuevoArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAddDepto_Click(sender As Object, e As EventArgs)
        Dim F As Form = New frmDepartamentoNuevo(Me)
        F.Show()
    End Sub

    Private Sub btnAddSeccion_Click(sender As Object, e As EventArgs)
        Dim Dpto As Departamento = TryCast(cbDepartamento.SelectedItem, Departamento)
        If IsNothing(Dpto) Then
            Return
        End If
        Dim F As Form = New frmNuevaSeccion(Me, Dpto)
        F.Show()
    End Sub

    Public Sub PopularFormulario()
        Dim X As Decimal = ((Panel1.Width - lblTitle.Width) / 2)
        Dim Y As Decimal = ((Panel1.Height - lblTitle.Height) / 2)
        lblTitle.Location = New Point(X, Y)
    End Sub

    Private Sub frmNuevoArticulo_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        PopularFormulario()
    End Sub

    Public Sub Register(xObserver As IObserver) Implements IObservable.Register
        If IsNothing(Observadores) Then
            Observadores = New List(Of IObserver)
        End If
        Observadores.Add(xObserver)
    End Sub

    Public Sub UnRegister(xObserver As IObserver) Implements IObservable.UnRegister
        For Each O As IObserver In Observadores
            If (O.Equals(xObserver)) Then
                Observadores.Remove(O)
            End If
        Next
    End Sub

    Public Sub notifyObservers() Implements IObservable.notifyObservers
        For Each O As IObserver In Observadores
            O.Update(Me)
        Next
    End Sub

    Private Sub frmNuevoArticulo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub frmNuevoArticulo_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.DialogResult = DialogResult.Abort
        notifyObservers()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


End Class