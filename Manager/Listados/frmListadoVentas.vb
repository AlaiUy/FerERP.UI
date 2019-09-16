Imports JJ.Gestoras
Imports JJ.Reportes

Public Class frmListadoVentas

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try
            If txtPath.Text.Trim().Length > 0 Then
                GestionReporte.ExportExcel(Grid.DataSource, txtPath.Text.Trim())
                Return
            End If
            GestionReporte.ExportExcel(Grid.DataSource, Nothing)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            GestionReporte.Ventas(Grid.DataSource, DateInicio.Value, DateFinal.Value)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            Grid.DataSource = GesDocumentos.getInstance().ListadoVentas(DateInicio.Value, DateFinal.Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class