Imports System.IO
Imports JJ.Entidades
Imports JJ.Gestoras

Public Class frmEmpresaData
    Private _Empresa As Empresa = Nothing
    Private _SeriesDoc As List(Of Seriedoc) = New List(Of Seriedoc)


    Private Sub btnBuscarLogo_Click(sender As Object, e As EventArgs) Handles btnBuscarLogo.Click
        Dim R As DialogResult = FileOpen.ShowDialog()
        If R = DialogResult.OK Then
            Dim Ruta As String = FileOpen.FileName
            Try
                LogoBox.Image = Image.FromFile(Ruta)
            Catch ex As Exception
            End Try
        End If
    End Sub


    Private Sub frmEmpresaData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _Empresa = GesEmpresa.getInstance().Empresa
            If Not IsNothing(_Empresa) Then
                popularform()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub popularform()
        txtCiudad.Text = _Empresa.Ciudad
        txtDireccion.Text = _Empresa.Direccion
        txtEmail.Text = _Empresa.Email
        txtNombre.Text = _Empresa.Nombre
        txtPais.Text = _Empresa.Pais
        txtRazon.Text = _Empresa.Razonsocial
        txtRut.Text = _Empresa.Rut
        txtTelefono.Text = _Empresa.Telefono
        txtDescuentoContado.Text = _Empresa.DescuentoContado
        arrtoimg()

        If Not IsNothing(_Empresa.Parametros) Then
            cbParameters.DataSource = _Empresa.Parametros
        End If

        If Not IsNothing(_Empresa.Grupos) Then
            cbGroups.DataSource = _Empresa.Grupos
            CargarListParametros(cbGroups.SelectedItem())
        End If

        If Not IsNothing(_Empresa.Series) Then
            For Each S As Seriedoc In _Empresa.Series
                ltsDocumentos.Items.Add(S)
            Next
        End If

        If Not IsNothing(_Empresa.Equipos) Then
            cbEquipos.DataSource = _Empresa.Equipos
        End If

        If Not IsNothing(_Empresa.Vendedores) Then
            cbVendedores.DataSource = _Empresa.Vendedores
        End If

        If Not IsNothing(_Empresa.Cajas) Then
            CbCajasDisponibles.DataSource = _Empresa.Cajas
        End If
    End Sub

    Private Sub arrtoimg()
        Dim ms As New IO.MemoryStream(CType(_Empresa.Imagen, Byte())) 'This is correct...
        Dim returnImage As Image = Image.FromStream(ms)
        LogoBox.Image = returnImage
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim imageConverter As New ImageConverter()
        If Not IsNothing(GesEmpresa.getInstance().Empresa) Then
            Dim UpEmpresa As Empresa = GesEmpresa.getInstance().Empresa
            UpEmpresa.Nombre = txtNombre.Text
            UpEmpresa.Telefono = txtTelefono.Text
            UpEmpresa.Email = txtEmail.Text
            UpEmpresa.Direccion = txtDireccion.Text
            UpEmpresa.Ciudad = txtCiudad.Text
            UpEmpresa.Pais = txtPais.Text
            UpEmpresa.Imagen = DirectCast(imageConverter.ConvertTo(LogoBox.Image, GetType(Byte())), Byte())
            UpEmpresa.DescuentoContado = txtDescuentoContado.Text
            Try
                GesEmpresa.getInstance().AddEmpresa(UpEmpresa)
                MsgBox("Datos actualizados correctamente", vbOKOnly, "Exito!")
                Return
            Catch ex As Exception
                MsgBox(ex.Message)
                Return
            End Try
        End If

        Dim Em As Empresa = Nothing
        Em = New Empresa(txtRazon.Text, txtRut.Text)
        Em.Nombre = txtNombre.Text
        Em.Telefono = txtTelefono.Text
        Em.Email = txtEmail.Text
        Em.Direccion = txtDireccion.Text
        Em.Ciudad = txtCiudad.Text
        Em.Pais = txtPais.Text
        Em.Imagen = DirectCast(imageConverter.ConvertTo(LogoBox.Image, GetType(Byte())), Byte())
        Em.DescuentoContado = txtDescuentoContado.Text
        Try
            GesEmpresa.getInstance().AddEmpresa(Em)
            MsgBox("Datos agregados correctamente", vbOKOnly, "Exito!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbGroups_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGroups.SelectedIndexChanged
        ltsParams.Items.Clear()
        If Not IsNothing(_Empresa.Grupos) Then
            cbGroups.DataSource = _Empresa.Grupos
            CargarListParametros(cbGroups.SelectedItem)
        End If
    End Sub

    Private Sub CargarListParametros(ByVal xGrupo As Grupo)
        RemoveListParametros()
        If Not IsNothing(xGrupo) Then
            For Each P As Parametro In xGrupo.Parametros
                ltsParams.Items.Add(P)
            Next
        End If

    End Sub

    Private Sub RemoveListParametros()
        ltsParams.Items.Clear()
    End Sub

    Private Sub ltsParams_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltsParams.SelectedIndexChanged

    End Sub

    Private Sub ltsParams_Click(sender As Object, e As EventArgs) Handles ltsParams.Click
        Dim P As Parametro
        P = TryCast(ltsParams.SelectedItem, Parametro)
        txtInfoValue.Text = P.Valor
    End Sub

    Private Sub btnAddParam_Click(sender As Object, e As EventArgs) Handles btnAddParam.Click

        If IsNothing(TryCast(cbParameters.SelectedItem, Parametro)) Then
            Return
        End If

        If txtParamValue.Text.Length < 1 Then
            MsgBox("El parametro no puede ser vacio")
            Return
        End If

        Dim Grp As Grupo = cbGroups.SelectedItem

        If (Grp.Parametroexists(cbParameters.SelectedItem)) Then
            If MsgBox("Desea actualizar el valor del parametro?", vbOKCancel, "Atencion") = vbOK Then
                Grp.UpdateParameter(cbParameters.SelectedItem, txtParamValue.Text)
                MsgBox("Parametro actualizado, no se olvide de guardar el grupo.", vbOK, "Exito.!")
                Return
            Else
                Return
            End If
        End If

        Dim Param As Parametro = cbParameters.SelectedItem
        Param.Valor = txtParamValue.Text
        Grp.Addparam(Param)
        CargarListParametros(Grp)
        MsgBox("Parametro agregado, no se olvide de guardar el grupo.", vbOKOnly, "Exito.!")


    End Sub

    Private Sub btnAddGroup_Click(sender As Object, e As EventArgs) Handles btnAddGroup.Click
        If cbGroups.Items.Count < 1 Then
            MsgBox("No hay grupo para guardar o actualizar", vbOKOnly)
            Return
        End If

        Dim Grp As Grupo = cbGroups.SelectedItem



        Try
            GesEmpresa.getInstance().UpdateGroup(Grp)
            MsgBox("Grupo actualizado correctamente", vbOKOnly, "Exito.!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnNewGroup_Click(sender As Object, e As EventArgs) Handles btnNewGroup.Click
        If txtGroupName.Text.Length < 1 Then
            MsgBox("El nombre del grupo no puede ser vacio", vbOKOnly)
            Return
        End If

        Dim C As Caja = CbCajasDisponibles.SelectedItem



        Dim Grp As Grupo = New Grupo(txtGroupName.Text, C)

        Try
            GesEmpresa.getInstance().AddGroup(Grp)
            MsgBox("Grupo creado exitosamente", vbOKOnly, "Exito!")
            Return
            _Empresa = GesEmpresa.getInstance().getEmpresa()

            popularform()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAsignarSerie_Click(sender As Object, e As EventArgs) Handles btnAsignarSerie.Click
        If txtSerieValue.Text.Length < 1 Then
            MsgBox("La serie escrita no es correcta", vbOKOnly, "Verificar")
            Return
        End If

        If IsNothing(ltsDocumentos.SelectedItem) Then
            MsgBox("Se debe seleccionar un documento")
            Return
        End If

        Dim Doc As Seriedoc = ltsDocumentos.SelectedItem


        If Not IsNothing(_SeriesDoc.Find(Function(S) S.Documento = Doc.Documento)) Then
            _SeriesDoc.Find(Function(S) S.Documento = Doc.Documento).Serie = txtSerieValue.Text
            MsgBox("Se actualizo la serie con exito", vbOKOnly, "Exito!")
            Return
        End If

        Doc.Serie = txtSerieValue.Text
        _SeriesDoc.Add(Doc)


    End Sub

    Private Sub ltsDocumentos_Click(sender As Object, e As EventArgs) Handles ltsDocumentos.Click
        Dim SD As Seriedoc
        SD = TryCast(ltsDocumentos.SelectedItem, Seriedoc)
        txtSerieValue.Text = SD.Serie
    End Sub

    Private Sub btnAgregarCaja_Click(sender As Object, e As EventArgs) Handles btnAgregarCaja.Click
        If txtCodCaja.Text.Length < 1 Then
            MsgBox("El codigo de caja no puede ser vacio", vbOKOnly, "Verificar")
            Return
        End If

        If txtCodCaja.Text.Length > 3 Then
            MsgBox("El codigo de caja es demasiado extenso [Max 3 Caracteres]", vbOKOnly, "Verificar")
            Return
        End If

        If txtDescripcionCaja.Text.Length < 1 Then
            MsgBox("La descripcion de la caja no puede ser vacia", vbOKOnly, "Verificar")
            Return
        End If

        If _SeriesDoc.Count < 1 Then
            MsgBox("No hay series asignadas para la caja", vbOKOnly, "Verificar")
            Return
        End If

        If _SeriesDoc.Count > 1 Then
            If (CheckSeries(_SeriesDoc) = False) Then
                MsgBox("Alguno de los documentos no tiene serie asignada", vbOKOnly, "Verificar")
                Return
            End If
        End If

        Dim Caja As Caja = New Caja(txtCodCaja.Text, txtDescripcionCaja.Text, _SeriesDoc)
        Try
            GesEmpresa.getInstance().AddCaja(Caja)
            MsgBox("Caja creada exitosamente", vbOKOnly, "Exito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function CheckSeries(_SeriesDoc As List(Of Seriedoc)) As Boolean
        For Each S As Seriedoc In _SeriesDoc
            If S.Serie.Length < 1 Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btnAddEquipo_Click(sender As Object, e As EventArgs) Handles btnAddEquipo.Click
        If IsNothing(TryCast(cbEquipos.SelectedItem, Equipo)) Then
            Return
        End If

        Dim Grp As Grupo = cbGroups.SelectedItem

        If (Grp.EquipoExists(cbEquipos.SelectedItem)) Then
            MsgBox("El equipo ya esta ingresado en el grupo", vbOKOnly, "Atencion")
            Return
        End If

        Dim Equipo As Equipo = cbEquipos.SelectedItem
        Grp.AddEquipo(Equipo)
        MsgBox("Equipo agregado, no se olvide de guardar el grupo.", vbOKOnly, "Exito.!")
    End Sub

    Private Sub btnAgregarEquipo_Click(sender As Object, e As EventArgs) Handles btnAgregarEquipo.Click
        If (txtDirIp.Text.Length > 15) Then
            MsgBox("La direccion de ip no es correcta", vbOKOnly, "Verificar")
            Return
        End If

        If (txtDescripcionEquipo.Text.Length > 100) Then
            MsgBox("La descripcion es demasiado extensa", vbOKOnly, "Verificar")
            Return
        End If

        If (txtNombreEquipo.Text.Length > 100) Then
            MsgBox("El nombre del equipo es demasiado extenso", vbOKOnly, "Verificar")
            Return
        End If

        Try
            Dim Eq As Equipo = New Equipo(txtNombreEquipo.Text, txtDescripcionEquipo.Text)
            Eq.DirIP = txtDirIp.Text
            GesEmpresa.getInstance().AgregarEquipo(Eq)
            MsgBox("Equipo agregado exitosamente")
            cbEquipos.DataSource = GesEmpresa.getInstance()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSaveVendedor_Click(sender As Object, e As EventArgs) Handles btnSaveVendedor.Click
        If txtNombreVendedor.Text.Trim().Length < 1 Then
            MsgBox("El nombre del vendedor no puede ser vacio", vbOKOnly, "Atencion!")
            Return
        End If

        Dim Ven As Vendedor = New Vendedor(txtNombreVendedor.Text)

        Try
            GesVendedores.getInstance().AddVendedor(Ven)
            MsgBox("Vendedor agregado con exito", vbOKOnly, "Exito!")
            txtNombreVendedor.Text = ""
            txtNombreVendedor.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbVendedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVendedores.SelectedIndexChanged
        If Not IsNothing(_Empresa.Vendedores) Then
            cbVendedores.DataSource = _Empresa.Vendedores
            txtNombreModVendedor.Text = TryCast(cbVendedores.SelectedItem, Vendedor).Nombre
            chkVendedorActivo.Checked = TryCast(cbVendedores.SelectedItem, Vendedor).Activo
        End If
    End Sub

    Private Sub txtDescuentoContado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescuentoContado.KeyPress
        e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart, 2)
    End Sub

    Private Sub frmEmpresaData_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
End Class