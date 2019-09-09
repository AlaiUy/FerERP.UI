Imports JJ.Entidades
Imports JJ.Gestoras

Public Class frmNuevaCategoriaProveedor
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim Cat As CatProveedor = New CatProveedor()
        Cat.Nombre = txtCategoria.Text
        Try
            GesPersonas.getInstance().addCatProveedor(Cat)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class