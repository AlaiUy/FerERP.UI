Imports JJ.Interfaces.Observer

Public Class frmArticulos
    Implements IObservable
    Private _Obs As IList(Of IObserver)
    Public Sub notifyObservers() Implements IObservable.notifyObservers
        For Each O As IObserver In _Obs
            O.Update(Me)
        Next
    End Sub

    Public Sub Register(xObserver As IObserver) Implements IObservable.Register
        Throw New NotImplementedException()
    End Sub

    Public Sub UnRegister(xObserver As IObserver) Implements IObservable.UnRegister
        Throw New NotImplementedException()
    End Sub

    Private Sub frmArticulos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If Not IsNothing(_Obs) Then
                notifyObservers()
            End If
            Close()
        End If

    End Sub

    Private Sub frmArticulos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub frmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class