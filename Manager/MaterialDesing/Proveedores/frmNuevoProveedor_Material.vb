Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmNuevoProveedor_Material
    Implements IObservable

    Private _Obs As IList(Of IObserver)
    Private Lista As IList(Of Object) = New List(Of Object)
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim xCodmoneda As Integer
        Try
            xCodmoneda = TryCast(Cbmonedas.SelectedItem, Moneda).Codigo
        Catch ex As Exception

        End Try
        Dim objProveedor As New Proveedor(xCodmoneda)
        objProveedor.Celular = txtCelular.Text
        objProveedor.Direccion = txtCalle.Text
        objProveedor.Dirnumero = txtNumero.Text
        objProveedor.Email = txtEmail.Text
        objProveedor.Nombre = txtNombre.Text
        objProveedor.Rut = txtRut.Text
        objProveedor.Rz = txtRz.Text
        objProveedor.Telefono = txtTelefono.Text
        objProveedor.Categoria = TryCast(cbCategoria.SelectedItem, CatProveedor).Codigo
        objProveedor.Comentarios = txtComentarios.Text
        Try
            GesPersonas.getInstance().AddProveedor(objProveedor)
            frmSuccess.FormCorrecto("El proveedor fue guardado correctamente")
            ClearForm()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearForm()
        txtCelular.Text = String.Empty
        txtCalle.Text = String.Empty
        txtNumero.Text = String.Empty
        txtEmail.Text = String.Empty
        txtNombre.Text = String.Empty
        txtRut.Text = String.Empty
        txtRz.Text = String.Empty
        txtTelefono.Text = String.Empty
        txtComentarios.Text = String.Empty
    End Sub

    Private Sub frmNuevoProveedor_Material_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = DialogResult.Abort
            notifyObservers()
        End If
    End Sub

    Private Sub PopularForm()
        Lista = GesPersonas.getInstance().getCategoriasProveedor()
        cbCategoria.DataSource = Lista
    End Sub

    Private Sub frmNuevoProveedor_Material_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Lista = GesPersonas.getInstance().getCategoriasProveedor()
            cbCategoria.DataSource = Lista
            Cbmonedas.DataSource = GesPrecios.getInstance().getMonedas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddMarca_Click(sender As Object, e As EventArgs) Handles btnAddMarca.Click
        Dim AddCat As frmNuevaCategoriaProveedor = New frmNuevaCategoriaProveedor()
        AddCat.ShowDialog()
        PopularForm()
    End Sub




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



End Class