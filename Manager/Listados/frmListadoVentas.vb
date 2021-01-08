Imports JJ.Gestoras
Imports JJ.Interfaces.Observer
Imports JJ.Reportes

Public Class frmListadoVentas
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

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try
            If txtPath.Text.Trim().Length > 0 Then
                GestionReporte.ExportExcelVentas(Grid.DataSource, txtPath.Text.Trim())
                Return
            End If
            GestionReporte.ExportExcelVentas(Grid.DataSource, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            GestionReporte.Ventas(Grid.DataSource, DateInicio.Value, DateFinal.Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            Grid.DataSource = GesDocumentos.getInstance().ListadoVentas(DateInicio.Value, DateFinal.Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmListadoVentas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = DialogResult.Abort
            notifyObservers()
        End If
    End Sub

    Private Sub frmListadoVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Estilos.Redondear(Panel1, 5)
    End Sub

    Private Sub btnMostrarDev_Click(sender As Object, e As EventArgs) Handles btnMostrarDev.Click
        Try
            Grid.DataSource = GesDocumentos.getInstance().ListadoDevoluciones(DateInicio.Value, DateFinal.Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class