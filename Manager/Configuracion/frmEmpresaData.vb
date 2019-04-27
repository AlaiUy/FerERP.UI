Imports System.IO
Imports JJ.Entidades
Imports JJ.Gestoras

Public Class frmEmpresaData
    Private _Emprea As Empresa = Nothing

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

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Dim Em As Empresa = Nothing
        Em = New Empresa(txtRazon.Text, txtRut.Text)
        Em.Nombre = txtNombre.Text
        Em.Telefono = txtTelefono.Text
        Em.Email = txtEmail.Text
        Em.Direccion = txtDireccion.Text
        Em.Ciudad = txtCiudad.Text
        Em.Pais = txtPais.Text
        Dim imageConverter As New ImageConverter()
        Em.Imagen = DirectCast(imageConverter.ConvertTo(LogoBox.Image, GetType(Byte())), Byte())
        Try
            GesPersonas.getInstance().AddEmpresa(Em)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmEmpresaData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _Emprea = GesPersonas.getInstance().getEmpresa()
            If Not IsNothing(_Emprea) Then
                popularform()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub popularform()
        txtCiudad.Text = _Emprea.Ciudad
        txtDireccion.Text = _Emprea.Direccion
        txtEmail.Text = _Emprea.Email
        txtNombre.Text = _Emprea.Nombre
        txtPais.Text = _Emprea.Pais
        txtRazon.Text = _Emprea.Razonsocial
        txtRut.Text = _Emprea.Rut
        txtTelefono.Text = _Emprea.Telefono
        arrtoimg()
    End Sub

    Private Sub arrtoimg()
        Dim ms As New IO.MemoryStream(CType(_Emprea.Imagen, Byte())) 'This is correct...
        Dim returnImage As Image = Image.FromStream(ms)
        LogoBox.Image = returnImage
    End Sub
End Class