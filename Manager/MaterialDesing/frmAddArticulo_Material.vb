Imports Bunifu.Framework.UI
Imports JJ.Entidades
Imports JJ.Gestoras

Public Class frmAddArticulo_Material
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
        SetRegion()
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

    Private Sub cbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs)
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




    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim CodMoneda As Integer = TryCast(cbMoneda.SelectedValue, Moneda).Codigo
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
        If IsNothing(cbDepartamento.SelectedValue) Then
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
            frmSuccess.FormCorrecto("El articulo ha sido creado exitosamente.")
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

    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporteFinal.KeyPress

    End Sub

    Private Sub txtGanancia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGanancia.KeyPress

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub txtCostoCalculo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCostoCalculo.KeyUp

    End Sub

    Private Sub txtCosto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCosto.KeyUp


    End Sub
End Class