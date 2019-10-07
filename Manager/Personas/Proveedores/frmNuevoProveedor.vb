Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmNuevoProveedor
    Implements IObservable
    Private _Obs As IList(Of IObserver)
    Private Lista As IList(Of Object) = New List(Of Object)

    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
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

    Private Sub PopularForm()
        Lista = GesPersonas.getInstance().getCategoriasProveedor()
        cbCategoria.DataSource = Lista
    End Sub

    Private Sub frmNuevoProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Lista = GesPersonas.getInstance().getCategoriasProveedor()
            cbCategoria.DataSource = Lista
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmNuevoProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave
        TryCast(sender, TextBox).BackColor = BackTextBox(Tools.Texto.isLarge(TryCast(sender, TextBox).Text, 1, 50))

    End Sub



    Private Sub txtRz_Leave(sender As Object, e As EventArgs) Handles txtRz.Leave
        TryCast(sender, TextBox).BackColor = BackTextBox(Tools.Texto.isLarge(TryCast(sender, TextBox).Text, 1, 50))
    End Sub

    Private Sub txtRut_TextChanged(sender As Object, e As EventArgs) Handles txtRut.TextChanged

    End Sub

    Private Sub txtRut_Leave(sender As Object, e As EventArgs) Handles txtRut.Leave
        TryCast(sender, TextBox).BackColor = BackTextBox(((Tools.Texto.isLarge(TryCast(sender, TextBox).Text, 11, 12) And Tools.Numeros.isNumeric(TryCast(sender, TextBox).Text)) Or TryCast(sender, TextBox).Text.Length < 1))

    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged

    End Sub

    Private Sub txtTelefono_Leave(sender As Object, e As EventArgs) Handles txtTelefono.Leave
        TryCast(sender, TextBox).BackColor = BackTextBox((Tools.Numeros.isNumeric(TryCast(sender, TextBox).Text)) Or TryCast(sender, TextBox).Text.Length < 1)
    End Sub

    Private Sub txtCelular_TextChanged(sender As Object, e As EventArgs) Handles txtCelular.TextChanged

    End Sub

    Private Sub txtCelular_Leave(sender As Object, e As EventArgs) Handles txtCelular.Leave
        TryCast(sender, TextBox).BackColor = BackTextBox((Tools.Numeros.isNumeric(TryCast(sender, TextBox).Text)) Or TryCast(sender, TextBox).Text.Length < 1)
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        TryCast(sender, TextBox).BackColor = BackTextBox(Tools.Texto.AcceptEmail(TryCast(sender, TextBox).Text) Or TryCast(sender, TextBox).Text.Length < 1)
    End Sub

    Private Sub txtCalle_TextChanged(sender As Object, e As EventArgs) Handles txtCalle.TextChanged

    End Sub

    Private Sub txtCalle_Leave(sender As Object, e As EventArgs) Handles txtCalle.Leave
        TryCast(sender, TextBox).BackColor = BackTextBox(Tools.Texto.isLarge(TryCast(sender, TextBox).Text, 0, 50))
    End Sub

    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged

    End Sub

    Private Sub txtNumero_Leave(sender As Object, e As EventArgs) Handles txtNumero.Leave
        TryCast(sender, TextBox).BackColor = BackTextBox(Tools.Texto.isLarge(TryCast(sender, TextBox).Text, 0, 10))
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim objProveedor As New Proveedor()
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
            MsgBox("Agregado correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        Dim AddCat As frmNuevaCategoriaProveedor = New frmNuevaCategoriaProveedor()
        AddCat.ShowDialog()
        PopularForm()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class