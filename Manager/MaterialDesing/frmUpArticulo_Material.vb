Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmUpArticulo_Material
    Implements IObserver, IObservable
    Private Observadores As List(Of IObserver) = New List(Of IObserver)
    Private _articulo As Articulo = Nothing
    Private _Departamentos As List(Of Object)
    Private _PreciosVenta As IList(Of Object)
    Private _Marcas As IList(Of Object)
    Private _Ivas As List(Of Iva) = New List(Of Iva)
    Private _Monedas As List(Of Object)
    Private _frmArticulos As Form

    Private Sub Popular()
        Dim x As Integer = 0
        If Not IsNothing(_articulo) Then
            txtCodigo.Text = _articulo.CodArticulo
            txtCodigo.Enabled = False
            txtCodigo.BackColor = Color.White
            txtNombre.Text = _articulo.Nombre
            txtDescripcion.Text = _articulo.Descripcion
            txtReferencia.Text = _articulo.Referencia
            txtCodBarras.Text = _articulo.Codbarras
            txtCodBarras1.Text = _articulo.Codbarras1
            txtModelo.Text = _articulo.Modelo
            cbDepartamento.SelectedIndex = BuscarIndex(cbDepartamento, "D")
            cbMarca.SelectedIndex = BuscarIndex(cbMarca, "M")
            chkDescatalogado.Checked = _articulo.Activo
            chkRecalcula.Checked = _articulo.Recalcula
            txtCosto.Text = _articulo.Costo
            txtGanancia.Text = _articulo.Ganancia
            cbTiposIva.SelectedIndex = BuscarIndex(cbTiposIva, "I")
            cbMoneda.SelectedIndex = BuscarIndex(cbMoneda, "MON")
            chkDescatalogado.Checked = _articulo.Activo
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
        End If
    End Sub

    Private Function BuscarIndex(ByVal Combo As ComboBox, ByVal Texto As String) As Integer
        Dim Index As Integer = 0
        If Texto = "D" Then
            For Each D As Departamento In Combo.Items

                If D.Codigo = _articulo.Coddepto Then
                    Return Index
                End If
                Index += 1
            Next
        End If

        If Texto = "M" Then
            For Each D As Marca In Combo.Items

                If D.Codigo = _articulo.Codmarca Then
                    Return Index
                End If
                Index += 1
            Next
        End If
        If Texto = "I" Then
            For Each I As Iva In Combo.Items

                If I.Id = _articulo.Iva.Id Then
                    Return Index
                End If
                Index += 1
            Next
        End If

        If Texto = "MON" Then
            For Each M As Moneda In Combo.Items

                If M.Codigo = _articulo.CodMoneda Then
                    Return Index
                End If
                Index += 1
            Next
        End If
        Return 1
    End Function

    Private Sub txtArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = Chr(13) And Not String.IsNullOrEmpty(DirectCast(sender, TextBox).Text) Then
            Try
                _articulo = GesArticulos.getInstance().getArticuloByRef(TryCast(sender, TextBox).Text)
                If Not IsNothing(_articulo) Then
                    Popular()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtNombre.Text.Trim() Is String.Empty Or txtNombre.Text.Trim().Length > 50 Then
            MsgBox("El nombre del articulos no es valido [Min 1 caracter Max 50].", vbOKOnly, "Verificar")
            Return
        End If

        _articulo.Nombre = txtNombre.Text.Trim()

        If txtDescripcion.Text.Trim() Is String.Empty Or txtDescripcion.Text.Trim().Length > 100 Then
            MsgBox("La descripcion del articulo no es valida [Min 1 caracter Max 100].", vbOKOnly, "Verificar")
            Return
        End If

        _articulo.Descripcion = txtDescripcion.Text.Trim()


        If txtReferencia.Text.Trim() Is String.Empty Or txtReferencia.Text.Trim().Length > 12 Then
            MsgBox("La descripcion del articulo no es valida [Min 1 caracter Max 12].", vbOKOnly, "Verificar")
            Return
        End If

        _articulo.Referencia = txtReferencia.Text.Trim()

        If txtCodBarras.Text.Trim().Length() > 254 Then
            MsgBox("El codigo de barras no es valido. [Max 254].", vbOKOnly, "Verificar")
            Return
        End If

        _articulo.Codbarras = txtCodBarras.Text.Trim()

        If txtCodBarras1.Text.Trim().Length() > 254 Then
            MsgBox("El codigo de barras no es valido. [Max 254].", vbOKOnly, "Verificar")
            Return
        End If

        _articulo.Codbarras1 = txtCodBarras1.Text.Trim()

        If txtModelo.Text.Trim().Length() > 20 Then
            MsgBox("El modelo no es valido. [Max 20].", vbOKOnly, "Verificar")
            Return
        End If

        _articulo.Modelo = txtModelo.Text.Trim()

        If txtGanancia.Text.Trim().Length < 0 Or Convert.ToDecimal(txtGanancia.Text) <= 0 Then
            MsgBox("La ganancia no puede ser menor o igual a 0 [Valor > 0]", vbOKOnly, "Verificar")
            Return
        End If

        If IsNothing(cbMarca.SelectedItem) Then
            MsgBox("Debe seleccionar una marca para este articulo")
            Return
        End If

        If IsNothing(cbDepartamento.SelectedItem) Then
            MsgBox("Debe seleccionar un departamento para este articulo")
            Return
        End If

        If IsNothing(cbSeccion.SelectedItem) Then
            MsgBox("Debe seleccionar una seccion para este articulo")
            Return
        End If

        _articulo.Codseccion = TryCast(cbSeccion.SelectedItem, Seccion).Codigo
        _articulo.Codmarca = TryCast(cbMarca.SelectedItem, Marca).Codigo
        _articulo.Coddepto = TryCast(cbDepartamento.SelectedItem, Departamento).Codigo
        _articulo.Recalcula = chkRecalcula.Checked
        _articulo.Activo = chkDescatalogado.Checked
        _articulo.Modelo = txtModelo.Text
        _articulo.Iva = cbTiposIva.SelectedItem
        _articulo.CodMoneda = TryCast(cbMoneda.SelectedItem, Moneda).Codigo

        Dim xCosto As Decimal = Convert.ToDecimal(txtCosto.Text)
        Dim xGanancia As Decimal = Convert.ToDecimal(txtGanancia.Text)

        Try
            GesArticulos.getInstance().ActualizarArticulo(_articulo, xCosto, xGanancia)
            frmSuccess.FormCorrecto("Articulo: " & _articulo.Referencia & " actualizado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        _frmArticulos = New frmArticulos_Material(Me)
        _frmArticulos.Show()
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

    Private Sub frmUpArticulo_Material_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Departamentos = GesArticulos.getInstance().getDepartamentos()
        _Marcas = GesArticulos.getInstance().getMarcas()
        cbMarca.DataSource = _Marcas
        cbDepartamento.DataSource = _Departamentos
        If Not IsNothing(cbDepartamento.SelectedItem) Then
            cbSeccion.DataSource = TryCast(cbDepartamento.SelectedItem, Departamento).Secciones()
        End If
        _Monedas = GesPrecios.getInstance().getMonedas()
        _Ivas = GesEmpresa.getInstance().Empresa.Ivas
        cbMoneda.DataSource = _Monedas
        cbTiposIva.DataSource = _Ivas
        cbTiposIvaCalculo.DataSource = _Ivas
    End Sub

    Private Sub btnAddMarca_Click(sender As Object, e As EventArgs) Handles btnAddMarca.Click
        Dim F As Form = New frmNuevaMarca(Me)
        F.Show()
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

    Public Overloads Sub Update(Obj As Object) Implements IObserver.Update
        If TypeOf Obj Is Marca Then
            _Marcas = GesArticulos.getInstance().getMarcas()
            Popular()
        End If
        If TypeOf Obj Is Departamento Then
            _Departamentos = GesArticulos.getInstance().getDepartamentos()
            Popular()
        End If
        Select Case True
            Case TypeOf Obj Is Articulo
                _articulo = TryCast(Obj, Articulo)
                Popular()
            Case TypeOf Obj Is String
                If TryCast(Obj, String).ToString() = "CERRAR" Then
                    If Not IsNothing(_frmArticulos) Then
                        _frmArticulos.Close()
                        _frmArticulos.Dispose()
                        _frmArticulos = Nothing
                    End If
                End If
        End Select
    End Sub

    Private Sub cbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartamento.SelectedIndexChanged
        Dim Dpto As Departamento = cbDepartamento.SelectedItem()
        cbSeccion.DataSource = Dpto.Secciones()
    End Sub

    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress, txtCostoCalculo.KeyPress
        e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart, 2)
    End Sub

    Private Sub txtGanancia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGanancia.KeyPress
        e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart, 2)
    End Sub

    Private Sub txtImporteFinal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporteFinal.KeyPress
        e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart, 2)
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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub



    Private Sub frmUpArticulo_Material_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class