Imports JJ.Entidades

Public Class _ALBARANCOMPRA
    Private _Proveedor As Proveedor
    Private _Lineas As List(Of CompraLin)
    Private _Subtotal As Decimal = 0
    Private _Total As Decimal = 0
    Private _DPP As Decimal = 0

    Public ReadOnly Property Lineas As List(Of CompraLin)
        Get
            Return _Lineas
        End Get
    End Property

    Public ReadOnly Property Subtotal As Decimal
        Get
            Totalizar()
            Return _Subtotal
        End Get

    End Property

    Public ReadOnly Property Total As Decimal
        Get
            Totalizar()
            Return _Total
        End Get

    End Property

    Public Property Proveedor As Proveedor
        Get
            Return _Proveedor
        End Get
        Set(value As Proveedor)
            _Proveedor = value
        End Set
    End Property

    Public Property DPP As Decimal
        Get
            Return _DPP
        End Get
        Set(value As Decimal)
            _DPP = value
        End Set
    End Property

    Public Sub New()
        _Lineas = New List(Of CompraLin)
    End Sub

    Public Sub AgregarLinea(ByVal xLinea As CompraLin)
        If (xLinea.TotalConDescuento() < 0) Then
            MsgBox("No se puede agregar un importe negativo")
            Return
        End If

        If _Lineas.Count = 0 Then
            _Lineas.Add(xLinea)
            Return
        End If

        For Each espLin As CompraLin In _Lineas
            If (espLin.Articulo.CodArticulo = xLinea.Articulo.CodArticulo) Then
                If espLin.Descripcion.Equals(xLinea.Descripcion) Then
                    espLin.Cantidad += xLinea.Cantidad
                    Return
                End If
            End If
        Next
        _Lineas.Add(xLinea)

    End Sub



    Public Sub AgregarLineas(ByVal xLineas As List(Of CompraLin))
        For Each EspLin As CompraLin In xLineas
            AgregarLinea(EspLin)
        Next
    End Sub

    Friend Function getArticuloByCodigo(codigo As Integer) As Articulo
        For Each L As CompraLin In _Lineas
            If L.Articulo.CodArticulo = codigo Then
                Return L.Articulo
            End If
        Next
        Return Nothing
    End Function



    Friend Function CambiarCantidad(ByVal xCantidad As Decimal, ByVal xLinea As Integer) As Boolean
        For Each L As CompraLin In _Lineas
            If L.NumLinea = xLinea Then
                L.Cantidad = xCantidad
            End If
        Next
        Return True
    End Function

    Friend Function CambiarCostoUnitario(ByVal xPrecio As Decimal, ByVal xLinea As Integer) As Boolean
        For Each L As CompraLin In _Lineas
            If L.NumLinea = xLinea Then
                L.Costo = xPrecio
            End If
        Next
        Return True
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
        For Each L As CompraLin In _Lineas
            L.NumLinea = IndexLin
            IndexLin += 1
        Next
    End Sub

    Friend Sub AllDescuento(xDescuento As Decimal)
        'For Each Linea As CompraLin In _Lineas
        '    If AsignarDescuento(xDescuento, Linea.NumLinea) = False Then

        '    End If
        'Next
        'Totalizar()

    End Sub

    Friend Function AsignarDescuento(xDescuentos As List(Of Decimal), xLinea As Integer) As Boolean
        For Each Valor As Decimal In xDescuentos
            If Valor < 0 Then
                Return False
            End If
        Next
        _Lineas.Find(Function(Linea As CompraLin) Linea.NumLinea = xLinea).Descuentos = xDescuentos
        Return True
    End Function

    Public Function getLineaByID(ByVal xIndex As Integer) As CompraLin
        Return _Lineas.Find(Function(Linea As CompraLin) Linea.NumLinea = xIndex)
    End Function

    Private Sub Totalizar()
        If Not IsNothing(_Lineas) Then
            _Subtotal = 0
            _Total = 0
            For Each L As CompraLin In _Lineas
                _Subtotal += L.SubTotal()
                _Total += L.TotalconIva()
            Next
        End If
    End Sub

    Public Function MostrarTabla() As DataTable
        'codigo
        'Linea
        'referencia
        'nombre
        'cantidad
        'precio
        'iva
        'Subtotal
        'descuento
        'final
        Dim T As New DataTable("COMPRA")
        Dim COLCODIGO As DataColumn = New DataColumn("CODIGO", Type.GetType("System.String"))
        Dim COLLINEA As DataColumn = New DataColumn("LINEA", Type.GetType("System.String"))
        Dim COLREFERENCIA As DataColumn = New DataColumn("REFERENCIA", Type.GetType("System.String"))
        Dim COLNOMBRE As DataColumn = New DataColumn("NOMBRE", Type.GetType("System.String"))
        Dim COLCANTIDAD As DataColumn = New DataColumn("CANTIDAD", Type.GetType("System.String"))
        Dim COLPRECIO As DataColumn = New DataColumn("PRECIO", Type.GetType("System.String"))
        Dim COLIVA As DataColumn = New DataColumn("IVA", Type.GetType("System.String"))
        Dim COLDESCUENTO As DataColumn = New DataColumn("DESCUENTO", Type.GetType("System.String"))
        Dim COLFINAL As DataColumn = New DataColumn("FINAL", Type.GetType("System.String"))

        T.Columns.Add(COLCODIGO)
        T.Columns.Add(COLLINEA)
        T.Columns.Add(COLREFERENCIA)
        T.Columns.Add(COLNOMBRE)
        T.Columns.Add(COLCANTIDAD)
        T.Columns.Add(COLPRECIO)
        T.Columns.Add(COLIVA)
        T.Columns.Add(COLDESCUENTO)
        T.Columns.Add(COLFINAL)

        For Each Lin As CompraLin In _Lineas
            Dim Row As DataRow = T.NewRow()
            Row.Item("CODIGO") = Lin.Articulo.CodArticulo
            Row.Item("LINEA") = Lin.NumLinea
            Row.Item("REFERENCIA") = Lin.Articulo.Referencia.Trim()
            Row.Item("NOMBRE") = Lin.Articulo.Nombre.Trim()
            Row.Item("CANTIDAD") = FormatearImporte(Lin.Cantidad)
            Row.Item("PRECIO") = FormatearImporte(Lin.Costo)
            Row.Item("IVA") = Lin.Articulo.Iva
            Row.Item("DESCUENTO") = Lin.stringDescuentos()
            Row.Item("FINAL") = FormatearImporte(Lin.SubTotal())
            T.Rows.Add(Row)
        Next
        Return T
    End Function



End Class
