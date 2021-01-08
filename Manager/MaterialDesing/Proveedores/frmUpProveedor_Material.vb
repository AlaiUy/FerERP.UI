Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmUpProveedor_Material
    Implements IObserver, IObservable

    Private objProveedor As Proveedor = Nothing
    Private _fProveedores As frmFiltroProveedores_Material = Nothing
    Private Observadores As List(Of IObserver) = New List(Of IObserver)
    Private Lista As IList(Of Object) = New List(Of Object)

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
        txtComentarios.Text = objProveedor.Comentarios
    End Sub

    Public Sub Update(Obj As Object) Implements IObserver.Update
        Select Case True
            Case TypeOf Obj Is Proveedor
                objProveedor = TryCast(Obj, Proveedor)
                Popular()
            Case TypeOf Obj Is String
                If Obj = "CERRAR" Then
                    _fProveedores.Close()
                End If
        End Select
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

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        objProveedor.Comentarios = txtComentarios.Text
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
            frmSuccess.FormCorrecto("El proveedor fue actualizado correctamente")
            ClearForm()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub ClearForm()

        cbCategoria.DataSource = GesPersonas.getInstance().getCategoriasProveedor()
        txtCelular.Text = String.Empty
        txtCalle.Text = String.Empty
        txtNumero.Text = String.Empty
        txtEmail.Text = String.Empty
        txtNombre.Text = String.Empty
        txtRut.Text = String.Empty
        txtRz.Text = String.Empty
        txtTelefono.Text = String.Empty
        cbCategoria.SelectedIndex = BuscarIndex(cbCategoria)
        txtComentarios.Text = String.Empty

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        _fProveedores = New frmFiltroProveedores_Material(Me)
        _fProveedores.Show()
    End Sub
End Class