Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmCotizaciones
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

    Private _Monedas As List(Of Object) = Nothing
    Private Sub frmCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _Monedas = GesPrecios.getInstance().getMonedas()
            cbMonedas.DataSource = _Monedas.FindAll(Function(Mon) Mon.Codigo > 1)
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCotizacion.Text Is String.Empty Then
            Return
        End If
        Dim Cotizacion As Decimal = 0
        Try
            Cotizacion = Convert.ToDecimal(txtCotizacion.Text)
            GesEmpresa.getInstance().ChangeCot(Cotizacion, cbMonedas.SelectedItem)
            frmSuccess.FormCorrecto("Cotizacion actualizada correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtCotizacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCotizacion.KeyPress
        e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart, 2)
    End Sub

    Private Sub cbMonedas_KeyDown(sender As Object, e As KeyEventArgs) Handles cbMonedas.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = DialogResult.Abort
            notifyObservers()
        End If
    End Sub
End Class