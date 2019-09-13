Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmUpProveedor
    Implements IObserver, IObservable

    Private objProveedor As Proveedor = Nothing
    Private _fProveedores As frmListaProveedores = Nothing
    Private Observadores As List(Of IObserver) = New List(Of IObserver)
    Private Lista As IList(Of Object) = New List(Of Object)

    Private Sub frmUpProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centrar(lbltitle, Panel2)
    End Sub

    Private Function BuscarIndex(ByVal Combo As ComboBox) As Integer
        Dim Index As Integer = 0
        For Each C As CatProveedor In Combo.Items

            If C.Codigo = objProveedor.Categoria Then
                Return Index
            End If
            Index += 1
        Next
        Return 1
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        objProveedor.Celular = txtCelular.Text
        objProveedor.Direccion = txtCalle.Text
        objProveedor.Dirnumero = txtNumero.Text
        objProveedor.Email = txtEmail.Text
        objProveedor.Nombre = txtNombre.Text
        objProveedor.Rut = txtRut.Text
        objProveedor.Rz = txtRz.Text
        objProveedor.Telefono = txtTelefono.Text
        objProveedor.Categoria = TryCast(cbCategoria.SelectedItem, CatProveedor).Codigo
        Try
            GesPersonas.getInstance().UpdateProveedor(objProveedor)
            MsgBox("Actualizado correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Overloads Sub Update(Obj As Object) Implements IObserver.Update

        Select Case True
            Case TypeOf Obj Is Proveedor
                objProveedor = TryCast(Obj, Proveedor)
                Popular()
        End Select
    End Sub

    Private Sub Popular()
        cbCategoria.DataSource = GesPersonas.getInstance().getCategoriasProveedor()
        txtCelular.Text = objProveedor.Celular
        txtCalle.Text = objProveedor.Direccion
        txtNumero.Text = objProveedor.Dirnumero
        txtEmail.Text = objProveedor.Email
        txtNombre.Text = objProveedor.Nombre
        txtRut.Text = objProveedor.Rut
        txtRz.Text = objProveedor.Rz
        txtTelefono.Text = objProveedor.Telefono
        cbCategoria.SelectedIndex = BuscarIndex(cbCategoria)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        _fProveedores = New frmListaProveedores(Me)
        _fProveedores.Show()
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

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        Dim AddCat As frmNuevaCategoriaProveedor = New frmNuevaCategoriaProveedor()
        AddCat.ShowDialog()
        PopularForm()
    End Sub

    Private Sub PopularForm()
        Lista = GesPersonas.getInstance().getCategoriasProveedor()
        cbCategoria.DataSource = Lista
    End Sub
End Class