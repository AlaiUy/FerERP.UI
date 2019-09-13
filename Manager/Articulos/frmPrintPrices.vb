Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Reportes

Public Class frmPrintPrices
    Private _Articulos As New List(Of Articulo)
    Private Sub frmPrintPrices_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim objArticulo As Articulo = Nothing

        Try
            objArticulo = GesArticulos.getInstance().getArticuloByRef(txtArticulo.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If IsNothing(objArticulo) Then
            txtArticulo.Text = ""
            MsgBox("No existe el Articulo")
            Return
        End If
        _Articulos.Add(objArticulo)

        Me.GridArticulos.DataSource = MostrarTabla()
    End Sub

    Public Function MostrarTabla() As DataTable

        Dim tTable As New DataTable
        Dim ColCod As DataColumn = tTable.Columns.Add("NOMBRE", Type.GetType("System.String"))
        Dim ColRef As DataColumn = tTable.Columns.Add("PRECIO", Type.GetType("System.String"))
        Dim ColCan As DataColumn = tTable.Columns.Add("REFERENCIA", Type.GetType("System.String"))

        For Each A As Articulo In _Articulos
            Dim Row As DataRow = tTable.NewRow()
            Row.Item("REFERENCIA") = A.Referencia
            If A.CodMoneda = 1 Then
                Row.Item("PRECIO") = "$" + " " + Math.Ceiling(A.PrecioIva()).ToString()
            End If
            If A.CodMoneda = 2 Then
                Row.Item("PRECIO") = "U$S" + " " + Math.Ceiling(A.PrecioIva()).ToString()
            End If
            Row.Item("NOMBRE") = A.Nombre
            tTable.Rows.Add(Row)
        Next

        Return tTable

    End Function

    Private Sub Imprimir_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
        Try
            GestionReporte.ImprimirPrecio(MostrarTabla())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtArticulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAgregar.PerformClick()
        End If
    End Sub


End Class