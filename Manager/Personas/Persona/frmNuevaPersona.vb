Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmNuevaPersona
    Implements IObservable
    Private _Obs As IList(Of IObserver)

    Public Sub notifyObservers() Implements IObservable.notifyObservers
        For Each O As IObserver In _Obs
            O.Update(Me)
        Next
    End Sub

    Public Sub Register(xObserver As IObserver) Implements IObservable.Register
        If IsNothing(_Obs) Then
            _Obs = New List(Of IObserver)
        End If
        _Obs.Add(xObserver)
    End Sub

    Public Sub UnRegister(xObserver As IObserver) Implements IObservable.UnRegister
        For Each O As IObserver In _Obs
            If (O.Equals(xObserver)) Then
                _Obs.Remove(O)
            End If
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim xCedula As String = txtCedula.Text.Trim()
        Dim xNombre As String = txtNombre.Text.Trim()
        Dim xApellido As String = txtApellido.Text.Trim()
        Dim xDireccion As String = txtCalle.Text.Trim()
        Dim xDirNumero As String = txtNumero.Text.Trim()
        Dim xDirApto As String = txtApto.Text.Trim()
        Dim xTelefono As String = txtTelefono.Text.Trim()
        Dim xCelular As String = txtCelular.Text.Trim()
        Dim xPais As String = txtPais.Text.Trim()
        Dim xCiudad As String = txtCiudad.Text.Trim()
        Dim xEmail As String = txtEmail.Text.Trim()
        Dim Cat As Categoria = cbCategoria.SelectedItem
        Dim Per As Persona = New Persona(xCedula, xNombre, xApellido, xDireccion, xDirNumero, xDirApto, xTelefono, xCelular, xPais, xCiudad, Cat, xEmail, 1)
    End Sub

    Private Sub frmNuevaPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbCategoria.DataSource = GesPersonas.getInstance().getCategoriasCliente()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoria.SelectedIndexChanged

    End Sub
End Class