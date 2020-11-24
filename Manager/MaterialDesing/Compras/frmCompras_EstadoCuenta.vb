Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer
Imports JJ.Reportes

Public Class frmCompras_EstadoCuenta
    Implements IObserver

    Private _Caja As Caja

    'formularios banderas
    Private _fProveedores As frmListaProveedores = Nothing
    Private _Proveedor As Proveedor = Nothing
    Private _Pesos As Object = Nothing
    Private _Dolares As Object = Nothing
    Private _EC As EstadoCuentaProveedor



    Public Overloads Sub Update(Obj As Object) Implements IObserver.Update
        If TypeOf Obj Is Proveedor Then
            _Proveedor = TryCast(Obj, Proveedor)
            txtCodProveedor.Text = _Proveedor.Codigo
            txtNombreProveedor.Text = _Proveedor.Nombre
            If Not IsNothing(_fProveedores) Then
                _fProveedores.Close()
            End If
        End If
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        _fProveedores = New frmListaProveedores(Me)
        _fProveedores.Show()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        If Not IsNothing(_Proveedor) Then
            _EC = GesDocumentos.getInstance().getEstadoCuentaProveedor(dtpFecha.Value, _Proveedor)
            PopularForm()
            PopularGrilla()
        End If
    End Sub

    Private Sub PopularForm()
        If Not IsNothing(_EC) Then
            dgCompras.DataSource = _EC.Pesos
            txtDeudaPesos.Text = FormatearImporte(_EC.DeudaPesos)
            txtDeudaDolares.Text = FormatearImporte(_EC.DeudaDolares)
        End If

    End Sub

    Private Sub PopularGrilla()
        For Each column As DataGridViewColumn In dgCompras.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        dgCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None


        Dim EstiloIzquierda As DataGridViewCellStyle = New DataGridViewCellStyle()
        EstiloIzquierda.Alignment = DataGridViewContentAlignment.BottomLeft

        Dim EstiloDerecha As DataGridViewCellStyle = New DataGridViewCellStyle()
        EstiloDerecha.Alignment = DataGridViewContentAlignment.BottomRight

        Dim EstiloCentro As DataGridViewCellStyle = New DataGridViewCellStyle()
        EstiloCentro.Alignment = DataGridViewContentAlignment.BottomCenter

        dgCompras.Columns("FECHA").DefaultCellStyle = EstiloCentro
        dgCompras.Columns("SERIE").DefaultCellStyle = EstiloCentro
        dgCompras.Columns("NUMERO").DefaultCellStyle = EstiloCentro
        dgCompras.Columns("IMPORTE").DefaultCellStyle = EstiloDerecha
        dgCompras.Columns("TOTAL").DefaultCellStyle = EstiloDerecha


    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtDeudaPesos.TextChanged

    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        If Not IsNothing(_EC) Then
            dgCompras.DataSource = _EC.Pesos
        End If
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        If Not IsNothing(_EC) Then
            dgCompras.DataSource = _EC.Dolares
        End If
    End Sub

    Private Sub btnDPP_Click(sender As Object, e As EventArgs)
        Dim frmDPP As frmDPP_material = New frmDPP_material(_Proveedor)
        frmDPP.Show()
    End Sub

    Private Sub btnAnularRecibo_Click(sender As Object, e As EventArgs) Handles btnAnularRecibo.Click
        Try
            If dgCompras.SelectedRows(0).Cells("IMPORTE").Value < 0 Then
                Dim Serie As String = dgCompras.SelectedRows(0).Cells("SERIE").Value
                Dim Numero As Integer = dgCompras.SelectedRows(0).Cells("NUMERO").Value
                GesDocumentos.getInstance().AnularReciboCompra(Serie, Numero)
                frmSuccess.FormCorrecto("Recibo anulado correctamente")
                IconButton3.PerformClick()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        Try
            'GestionReporte.ExportExcelGral(dgCompras.DataSource, Nothing, "Estado de cuenta de: " & _Proveedor.Nombre)
            GestionReporte.Excel(dgCompras.DataSource)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnExportExcel_MouseEnter(sender As Object, e As EventArgs) Handles btnExportExcel.MouseEnter

    End Sub

    Private Sub btnExportExcel_MouseLeave(sender As Object, e As EventArgs) Handles btnExportExcel.MouseLeave

    End Sub

    Private Sub btnExportExcel_MouseHover(sender As Object, e As EventArgs) Handles btnExportExcel.MouseHover

    End Sub

    Private Sub btnAnularRecibo_MouseEnter(sender As Object, e As EventArgs) Handles btnAnularRecibo.MouseEnter

    End Sub

    Private Sub btnAnularRecibo_MouseLeave(sender As Object, e As EventArgs) Handles btnAnularRecibo.MouseLeave

    End Sub

    Private Sub btnAnularRecibo_MouseHover(sender As Object, e As EventArgs) Handles btnAnularRecibo.MouseHover

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub frmCompras_EstadoCuenta_Load(sender As Object, e As EventArgs) Handles Me.Load
        Estilos.Redondear(Panel5, 5)
        Estilos.Redondear(Panel6, 5)
        ' Estilos.Redondear(txtNombreProveedor, 5)
        Estilos.Redondear(txtCodProveedor, 1)
    End Sub

    Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click

    End Sub
End Class