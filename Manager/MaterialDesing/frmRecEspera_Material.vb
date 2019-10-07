Imports JJ.Entidades
Imports JJ.Gestoras

Public Class frmRecEspera_Material
    Private _estado As Integer = 0

    Public Sub New(ByVal xEstado As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _estado = xEstado
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private mListaDocumentos As List(Of Object)
    Private mLisVendedores As List(Of Object)
    Public objEspera As EsperaContado
    Private Sub frmRecEspera_Material_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mLisVendedores = GesVendedores.getInstance.getListaVendedores()
            mListaDocumentos = GesDocumentos.getInstance.getListaEspera(_estado)
            Dim X As DataTable = New DataTable()
            X = MostrarEncabezado()
            GridEncabezados.DataSource = X
            GridEncabezados.Columns("CLIENTECOD").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function MostrarEncabezado() As DataTable
        Dim tTable As New DataTable("Encabezados")
        Dim ColA As DataColumn = tTable.Columns.Add("NUMERO", Type.GetType("System.Int32"))
        Dim ColV As DataColumn = tTable.Columns.Add("VENDEDOR", Type.GetType("System.String"))


        Dim COLC As DataColumn = tTable.Columns.Add("CLIENTECOD", Type.GetType("System.String"))
        Dim COLCN As DataColumn = tTable.Columns.Add("CLIENTE", Type.GetType("System.String"))


        For Each objE As EsperaContado In mListaDocumentos
            Dim objf As DataRow = tTable.NewRow()
            objf.Item("NUMERO") = objE.Numero
            For Each objV As Vendedor In mLisVendedores
                If objV.Codigo = objE.Codvendedor Then
                    objf.Item("VENDEDOR") = objV.Nombre
                End If
            Next

            objf.Item("CLIENTECOD") = objE.Codclientecontado
            objf.Item("CLIENTE") = objE.NombreCLiente



            tTable.Rows.Add(objf)
        Next

        Return tTable
    End Function

    Public Function ObtenerEsperabyIdEspera(xcodigo As Integer) As EsperaContado
        For Each E As EsperaContado In mListaDocumentos
            If E.Numero = xcodigo Then
                Return E
            End If
        Next
        Return Nothing
    End Function

    Public Function MostrarLineas(xobjE As EsperaContado) As DataTable
        Dim tTable As New DataTable

        Dim ColRef As DataColumn = tTable.Columns.Add("REFERENCIA", Type.GetType("System.String"))
        Dim ColDes As DataColumn = tTable.Columns.Add("DESCRIPCION", Type.GetType("System.String"))
        Dim ColCan As DataColumn = tTable.Columns.Add("CANTIDAD", Type.GetType("System.Decimal"))

        If Not (xobjE.Lineas Is Nothing) Then


            For Each xobjL As Esperalin In xobjE.Lineas

                'If MyBase.Moneda.Id = objl.Articulo.MONEDA.Id Then
                Dim objf As DataRow = tTable.NewRow()
                objf.Item("REFERENCIA") = xobjL.Articulo.Referencia
                objf.Item("DESCRIPCION") = xobjL.Descripcion
                objf.Item("CANTIDAD") = xobjL.Cantidad

                tTable.Rows.Add(objf)


            Next
        End If
        Return tTable

    End Function

    Private Sub GridEncabezados_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles GridEncabezados.CellEnter
        Dim objE As EsperaContado = ObtenerEsperabyIdEspera(GridEncabezados.Item("NUMERO", e.RowIndex).Value)
        Me.dgridLineas.DataSource = MostrarLineas(objE)
        txtAdenda.Text = objE.Adenda
        txtImporteTotal.Text = objE.ImporteTotal
        Dim objCC As ClienteContado
        objCC = GesPersonas.getInstance.getClienteContadoByID(GridEncabezados.Item("ClienteCod", e.RowIndex).Value)
        txtNombre.Text = objCC.Nombre
        txtDireccion.Text = objCC.Direccion
        txtDocumento.Text = objCC.Documento
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnRecuperar_Click(sender As Object, e As EventArgs) Handles btnRecuperar.Click
        If Me.mListaDocumentos.Count > 0 Then
            If GridEncabezados.Rows.Count > 1 Then

                objEspera = mListaDocumentos.Find(Function(Esp As EsperaContado) Esp.Numero = GridEncabezados.Item("NUMERO", GridEncabezados.CurrentRow.Index).Value)
            Else
                objEspera = mListaDocumentos.Find(Function(Esp As EsperaContado) Esp.Numero = GridEncabezados.Item("NUMERO", 0).Value)
            End If
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub GridEncabezados_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridEncabezados.CellContentDoubleClick
        btnRecuperar.PerformClick()
    End Sub

    Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click

    End Sub
End Class