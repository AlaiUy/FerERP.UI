Imports System.IO
Imports JJ.Entidades
Imports JJ.Gestoras

Public Class frmEmpresaData
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
End Class