Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Reportes

Public Class frmListadoArticulos

    Private list As List(Of Articulo)

    Private Sub frmListadoArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Estilos.Redondear(Panel1, 5)
            Estilos.Redondear(Grid, 5)
            Grid.DataSource = GesArticulos.getInstance().getListadoArticulos()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub frmListadoArticulos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try
            GestionReporte.ExportExcelGral(Grid.DataSource, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            GestionReporte.ImprimirArticulos(Grid.DataSource)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub
End Class