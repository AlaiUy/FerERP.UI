Imports JJ.Entidades
Imports JJ.Gestoras

Public Class UESPERA
    Private _Lineas As List(Of Esperalin)
    Private _Adenda As String = String.Empty
    Private _CodMoneda As Integer = 1
    Private _Codvendedor As Integer
    Private _cotizacion As Decimal = 1
    Public Sub New(ByVal xcotizacion As Decimal)
        _Lineas = New List(Of Esperalin)
        _Adenda = ""
        _cotizacion = xcotizacion
    End Sub

    Public Property Lineas As List(Of Esperalin)
        Get
            Return _Lineas
        End Get
        Set(value As List(Of Esperalin))
            _Lineas = value
        End Set
    End Property

    Public Property Adenda As String
        Get
            Return _Adenda
        End Get
        Set(value As String)
            _Adenda = value
        End Set
    End Property

    Public Property CodMoneda As Integer
        Get
            Return _CodMoneda
        End Get
        Set(value As Integer)
            _CodMoneda = value
        End Set
    End Property

    Public Property Codvendedor As Integer
        Get
            Return _Codvendedor
        End Get
        Set(value As Integer)
            _Codvendedor = value
        End Set
    End Property



    Public Sub AgregarLinea(ByVal xLinea As Esperalin)
        If (xLinea.TotalConDescuento() < 0) Then
            MsgBox("No se puede agregar un importe negativo")
            Return
        End If

        If Lineas.Count = 0 Then
            Lineas.Add(xLinea)
            Return
        End If

        For Each espLin As Esperalin In Lineas
            If (espLin.Articulo.CodArticulo = xLinea.Articulo.CodArticulo) Then
                If espLin.Descripcion.Equals(xLinea.Descripcion) Then
                    espLin.Cantidad += xLinea.Cantidad
                    Return
                Else
                    Lineas.Add(xLinea)
                    Return
                End If
            End If
        Next
        Lineas.Add(xLinea)
    End Sub

    Public Sub AgregarLineas(ByVal xLineas As List(Of Esperalin))
        For Each EspLin As Esperalin In xLineas
            AgregarLinea(EspLin)
        Next
    End Sub

    Friend Function getArticuloByCodigo(codigo As Integer) As Articulo
        For Each L As Esperalin In Lineas
            If L.Articulo.CodArticulo = codigo Then
                Return L.Articulo
            End If
        Next
        Return Nothing
    End Function




    Friend Function CambiarCantidad(ByVal xCantidad As Decimal, ByVal xLinea As Integer) As Boolean
        For Each L As Esperalin In _Lineas
            If L.NumLinea = xLinea Then
                L.Cantidad = xCantidad
                Return True
            End If
        Next
        Return False
    End Function

    Friend Function BorrarLinea(ByVal xLinea As Integer) As Boolean
        For Index As Integer = 0 To _Lineas.Count
            If _Lineas(Index).NumLinea = xLinea Then
                _Lineas.RemoveAt(Index)
                Exit For
            End If
        Next
        ReindexarLineas()
        Return True

    End Function

    Private Sub ReindexarLineas()
        Dim IndexLin As Integer = 1
        For Each L As Esperalin In _Lineas
            L.NumLinea = IndexLin
            IndexLin += 1
        Next
    End Sub

    Friend Sub AllDescuento(xDescuento As Decimal, ByVal xPresupuesto As Boolean)


        For Each Linea As Esperalin In _Lineas
            If AsignarDescuento(xDescuento, Linea.NumLinea, xPresupuesto) = False Then
                Return
            End If
        Next


    End Sub

    Friend Function AsignarDescuento(xDescuento As Decimal, xLinea As Integer, ByVal xPresupuesto As Boolean) As Boolean
        If (xDescuento < 0) Then
            If Not xPresupuesto Then
                Return False
            End If
        End If

        If (xDescuento >= 100) Then
            Return False
        End If

        _Lineas.Find(Function(Linea As Esperalin) Linea.NumLinea = xLinea).Descuento = xDescuento
        Return True
    End Function

    Public Function MostrarTabla() As DataTable

        Dim T As New DataTable("VENTA")
        Dim COLCODIGO As DataColumn = New DataColumn("CODIGO", Type.GetType("System.String"))
        Dim COLLINEA As DataColumn = New DataColumn("LINEA", Type.GetType("System.String"))
        Dim COLREFERENCIA As DataColumn = New DataColumn("REFERENCIA", Type.GetType("System.String"))
        Dim COLNOMBRE As DataColumn = New DataColumn("NOMBRE", Type.GetType("System.String"))
        Dim COLCANTIDAD As DataColumn = New DataColumn("CANTIDAD", Type.GetType("System.String"))
        Dim COLPRECIO As DataColumn = New DataColumn("PRECIO", Type.GetType("System.String"))
        Dim COLDESCUENTO As DataColumn = New DataColumn("DESCUENTO", Type.GetType("System.String"))
        Dim COLFINAL As DataColumn = New DataColumn("FINAL", Type.GetType("System.String"))

        T.Columns.Add(COLCODIGO)
        T.Columns.Add(COLLINEA)
        T.Columns.Add(COLREFERENCIA)
        T.Columns.Add(COLNOMBRE)
        T.Columns.Add(COLCANTIDAD)
        T.Columns.Add(COLPRECIO)
        T.Columns.Add(COLDESCUENTO)
        T.Columns.Add(COLFINAL)

        For Each Lin As Esperalin In _Lineas
            Dim Row As DataRow = T.NewRow()
            If Lin.Articulo.CodMoneda = 2 Then
                Row.Item("PRECIO") = FormatearImporte(Lin.Articulo.PrecioIva * _cotizacion)
                Row.Item("FINAL") = FormatearImporte(Lin.TotalConDescuento * _cotizacion)
            Else
                Row.Item("PRECIO") = FormatearImporte(Lin.Articulo.PrecioIva)
                Row.Item("FINAL") = FormatearImporte(Lin.TotalConDescuento)
            End If
            Row.Item("CODIGO") = Lin.Articulo.CodArticulo
            Row.Item("LINEA") = Lin.NumLinea
            Row.Item("REFERENCIA") = Lin.Articulo.Referencia.Trim()
            Row.Item("NOMBRE") = Lin.Articulo.Nombre.Trim()
            Row.Item("CANTIDAD") = FormatearImporte(Lin.Cantidad)
            Row.Item("DESCUENTO") = FormatearImporte(Lin.Descuento)

            T.Rows.Add(Row)
        Next
        Return T
    End Function

    Public Function Total() As Decimal
        Dim zTotal As Decimal = 0
        For Each L As Esperalin In _Lineas
            If L.Articulo.CodMoneda = 2 Then
                Dim xPre As Decimal = L.TotalConDescuento()
                zTotal += xPre * _cotizacion
            Else
                zTotal += L.TotalConDescuento
            End If

        Next
        Return zTotal
    End Function
End Class
