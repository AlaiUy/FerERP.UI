Imports JJ.Gestoras
Imports JJ.Reportes

Public Class frmListadoVentas

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try
            If txtPath.Text.Trim().Length > 0 Then
                GestionReporte.ExportExcelVentas(Grid.DataSource, txtPath.Text.Trim())
                Return
            End If
            GestionReporte.ExportExcelVentas(Grid.DataSource, Nothing)
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

    Private Sub frmListadoVentas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmListadoVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Estilos.Redondear(Panel1, 5)
    End Sub

    Private Sub btnMostrarDev_Click(sender As Object, e As EventArgs) Handles btnMostrarDev.Click
        Try
            Grid.DataSource = GesDocumentos.getInstance().ListadoDevoluciones(DateInicio.Value, DateFinal.Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class