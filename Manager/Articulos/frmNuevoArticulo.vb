Imports System.ComponentModel
Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmNuevoArticulo
    Implements IObserver, IObservable
    Private Observadores As List(Of IObserver) = New List(Of IObserver)
    Private _Tarifas As List(Of Object)
    Private _Monedas As List(Of Object)
    Private _Departamentos As List(Of Object)
    Private _PreciosVenta As IList(Of Object)
    Private _Marcas As IList(Of Object)
    Private _Ivas As List(Of Iva) = New List(Of Iva)


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub



    Private Sub frmNuevoArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SetRegion()
        PopularFormulario()
        Try

            _Tarifas = GesPrecios.getInstance().getTarifas()
            _Monedas = GesPrecios.getInstance().getMonedas()
            _Departamentos = GesArticulos.getInstance().getDepartamentos()
            _Marcas = GesArticulos.getInstance().getMarcas()
            _Ivas = GesEmpresa.getInstance().Empresa.Ivas
            Popular()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartamento.SelectedIndexChanged
        Dim Dpto As Departamento = cbDepartamento.SelectedItem()
        cbSeccion.DataSource = Dpto.Secciones()
    End Sub

    Private Sub Popular()
        Try
            cbMoneda.DataSource = _Monedas
            cbDepartamento.DataSource = _Departamentos
            If Not IsNothing(cbDepartamento.SelectedItem) Then
                cbSeccion.DataSource = TryCast(cbDepartamento.SelectedItem, Departamento).Secciones()
            End If
            cbMarca.DataSource = _Marcas
            cbTiposIva.DataSource = _Ivas
            cbTiposIvaCalculo.DataSource = _Ivas
            ''centrar(PanelData, tbDatos)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporteFinal.KeyPress
        e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart, 2)
    End Sub

    Private Sub txtGanancia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGanancia.KeyPress
        e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart, 2)
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim CodMoneda As Integer = TryCast(cbMoneda.SelectedItem, Moneda).Codigo
        Dim Costo As Decimal = 0
        Dim Ganancia As Decimal = 0
        Try
            Costo = Convert.ToDecimal(txtCosto.Text)
            Ganancia = Convert.ToDecimal(txtGanancia.Text)
        Catch ex As Exception
            Costo = 0
            Ganancia = 0
        End Try

        Dim A = New Articulo(txtDescripcion.Text, txtReferencia.Text, Costo, cbTiposIva.SelectedItem, Ganancia, CodMoneda, chkRecalcula.Checked)
        A.Activo = 1
        A.Codbarras = txtCodBarras.Text
        A.Codbarras1 = txtCodBarras1.Text
        A.Nombre = txtNombre.Text
        If IsNothing(cbDepartamento.SelectedItem) Then
            btnAddDepto.PerformClick()
            Return
        End If

        If IsNothing(cbMarca.SelectedItem) Then
            btnAddMarca.PerformClick()
            Return
        End If
        If IsNothing(cbSeccion.SelectedItem) Then
            btnAddSeccion.PerformClick()
            Return
        End If

        A.Codseccion = TryCast(cbSeccion.SelectedItem, Seccion).Codigo
        A.Codmarca = TryCast(cbMarca.SelectedItem, Marca).Codigo
        A.Coddepto = TryCast(cbDepartamento.SelectedItem, Departamento).Codigo
        A.Recalcula = chkRecalcula.Checked
        A.Modelo = txtModelo.Text
        If (A.PrecioIva() <= 0) Then
            MsgBox("El precio ingresado no es correcto", vbOKOnly, "Atencion!")
            Return
        End If

        Try
            GesArticulos.getInstance().AddArticulo(A)
            MsgBox("Agregado con exito")
            ClearForm()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearForm()
        txtNombre.Text = ""
        txtDescripcion.Text = ""
        txtReferencia.Text = ""
        txtCodBarras.Text = ""
        txtCodBarras1.Text = ""
        txtModelo.Text = ""
        txtCosto.Text = ""
        txtGanancia.Text = ""
        txtCostoCalculo.Text = ""
        txtImporteFinal.Text = ""
        txtNombre.Focus()
    End Sub

    Private Sub btnAddMarca_Click(sender As Object, e As EventArgs) Handles btnAddMarca.Click
        Dim F As Form = New frmNuevaMarca(Me)
        F.Show()
    End Sub

    Public Overloads Sub Update(Obj As Object) Implements IObserver.Update
        If TypeOf Obj Is Marca Then
            _Marcas = GesArticulos.getInstance().getMarcas()
            Popular()
        End If
        If TypeOf Obj Is Departamento Then
            _Departamentos = GesArticulos.getInstance().getDepartamentos()
            Popular()
        End If
    End Sub

    Private Sub frmNuevoArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAddDepto_Click(sender As Object, e As EventArgs) Handles btnAddDepto.Click
        Dim F As Form = New frmDepartamentoNuevo(Me)
        F.Show()
    End Sub

    Private Sub btnAddSeccion_Click(sender As Object, e As EventArgs) Handles btnAddSeccion.Click
        Dim Dpto As Departamento = TryCast(cbDepartamento.SelectedItem, Departamento)
        If IsNothing(Dpto) Then
            Return
        End If
        Dim F As Form = New frmNuevaSeccion(Me, Dpto)
        F.Show()
    End Sub

    Public Sub PopularFormulario()
        Dim X As Decimal = ((Panel1.Width - lblTitle.Width) / 2)
        Dim Y As Decimal = ((Panel1.Height - lblTitle.Height) / 2)
        lblTitle.Location = New Point(X, Y)
    End Sub

    Private Sub frmNuevoArticulo_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        PopularFormulario()
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


    Private Sub frmNuevoArticulo_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.DialogResult = DialogResult.Abort
        notifyObservers()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If txtCostoCalculo.Text Is String.Empty Or txtCostoCalculo.Text.Trim().Length < 1 Then
            MsgBox("El costo no puede ser vacio")
            Return
        End If

        If IsNothing(cbTiposIvaCalculo.SelectedItem) Then
            MsgBox("Debe seleccionar un tipo de IVA")
            Return
        End If

        If txtImporteFinal.Text Is String.Empty Or txtImporteFinal.Text.Trim().Length < 1 Then
            MsgBox("El costo no puede ser vacio")
            Return
        End If

        txtCosto.Text = txtCostoCalculo.Text
        txtGanancia.Text = Articulo.ObtenerGanancia(txtCostoCalculo.Text, cbTiposIvaCalculo.SelectedItem, txtImporteFinal.Text)
    End Sub


    Private Sub centrar(ObjectWich As Object, ObjectWhere As Object)
        ObjectWich.Left = (ObjectWhere.Width - ObjectWich.Width) / 2
        ObjectWich.Top = (ObjectWhere.Height - ObjectWich.Height) / 2
    End Sub


    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostoCalculo.KeyPress, txtCosto.KeyPress
        e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart, 2)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class