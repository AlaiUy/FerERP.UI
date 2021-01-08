Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer
Imports JJ.Reportes

Public Class frmListadoArticulos
    Implements IObservable


    Private _observadores As List(Of IObserver)

    Public Sub Register(xObserver As IObserver) Implements IObservable.Register
        If IsNothing(_observadores) Then
            _observadores = New List(Of IObserver)
        End If
        _observadores.Add(xObserver)
    End Sub

    Public Sub UnRegister(xObserver As IObserver) Implements IObservable.UnRegister
        Throw New NotImplementedException()
    End Sub

    Public Sub notifyObservers() Implements IObservable.notifyObservers
        For Each O As IObserver In _observadores
            O.Update(Me)
        Next
    End Sub

    Private list As List(Of Articulo)

    Private Sub frmListadoArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Estilos.Redondear(Panel1, 5)
            Estilos.Redondear(Grid, 5)
            Grid.DataSource = GesArticulos.getInstance().getListadoArticulos()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub frmListadoArticulos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = DialogResult.Abort
            notifyObservers()
        End If
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try
            GestionReporte.ExportExcelGral(Grid.DataSource, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            GestionReporte.ImprimirArticulos(Grid.DataSource)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class