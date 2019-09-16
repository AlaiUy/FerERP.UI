Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Reportes

Public Class frmListadoArticulos

    Private list As List(Of Articulo)

    Private Sub frmListadoArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            list = GesArticulos.getInstance().getArticulos()
            Grid.DataSource = MostraTabla()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function MostraTabla() As DataTable
        Dim tTable As New DataTable
        Dim ColCod As DataColumn = tTable.Columns.Add("REFERENCIA", Type.GetType("System.String"))
        Dim ColRef As DataColumn = tTable.Columns.Add("NOMBRE", Type.GetType("System.String"))
        Dim ColCan As DataColumn = tTable.Columns.Add("ACTIVO", Type.GetType("System.String"))
        Dim ColCos As DataColumn = tTable.Columns.Add("COSTO", Type.GetType("System.Decimal"))
        Dim ColGan As DataColumn = tTable.Columns.Add("GANANCIA", Type.GetType("System.Decimal"))
        Dim ColPre As DataColumn = tTable.Columns.Add("PRECIO", Type.GetType("System.Decimal"))
        Dim ColSto As DataColumn = tTable.Columns.Add("STOCK", Type.GetType("System.Decimal"))
        Dim ColMon As DataColumn = tTable.Columns.Add("MONEDA", Type.GetType("System.String"))

        For Each A As Articulo In list
            Dim Row As DataRow = tTable.NewRow()
            Row.Item("REFERENCIA") = A.Referencia
            Row.Item("NOMBRE") = A.Nombre
            If (A.Activo) Then
                Row.Item("ACTIVO") = "SI"
            Else
                Row.Item("ACTIVO") = "NO"
            End If
            Row.Item("COSTO") = Decimal.Round(A.Costo, 2)
            Row.Item("GANANCIA") = Decimal.Round(A.Ganancia, 2)
            Row.Item("PRECIO") = Decimal.Round(A.PrecioIva(), 2)
            Row.Item("STOCK") = Decimal.Round(A.Stock, 2)
            If A.CodMoneda = 1 Then
                Row.Item("MONEDA") = "$"
            End If
            If A.CodMoneda = 2 Then
                Row.Item("MONEDA") = "U$S"
            End If
            tTable.Rows.Add(Row)
        Next

        Return tTable
    End Function

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            GestionReporte.ImprimirArticulos(Grid.DataSource)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

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

    Private Sub btnBuscarDirectorio_Click(sender As Object, e As EventArgs) Handles btnBuscarDirectorio.Click
        If FolderBrowser.ShowDialog = DialogResult.OK Then

            txtPath.Text = FolderBrowser.SelectedPath + "\Informe.xlsx"
        End If

    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs)

    End Sub
End Class