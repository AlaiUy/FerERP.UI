Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmNuevaSeccion
    Implements IObservable
    Private _Obs As IList(Of IObserver)
    Private _Seccion As Seccion = Nothing
    Private _Depto As Departamento = Nothing

    Public Sub New(ByVal xDepto As Departamento)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _Depto = xDepto
        lblDepto.Text = _Depto.Nombre
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(ByVal xObserver As IObserver, ByVal xDepto As Departamento)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _Depto = xDepto
        Register(xObserver)
        lblDepto.Text = _Depto.Nombre
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub Register(xObserver As IObserver) Implements IObservable.Register
        If IsNothing(xObserver) Then
            Return
        End If
        If IsNothing(_Obs) Then
            _Obs = New List(Of IObserver)
        End If
        _Obs.Add(xObserver)
    End Sub

    Public Sub UnRegister(xObserver As IObserver) Implements IObservable.UnRegister
        If IsNothing(xObserver) Then Return
        If IsNothing(_Obs) Then Return
        _Obs.Remove(xObserver)
    End Sub

    Public Sub notifyObservers() Implements IObservable.notifyObservers
        If Not IsNothing(_Depto) Then
            For Each Obs As IObserver In _Obs
                Obs.Update(_Depto)
            Next
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If String.IsNullOrEmpty(txtSeccion.Text) Then
            Return
        End If
        Dim xSeccion As Seccion = New Seccion()
        xSeccion.Nombre = txtSeccion.Text.Trim.ToUpper()
        Try
            _Seccion = GesArticulos.getInstance().addSeccion(xSeccion, _Depto)
            If Not IsNothing(_Seccion) Then
                notifyObservers()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmNuevaSeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class