Imports JJ.Entidades

Public Class UESPERA
    Private _Lineas As List(Of Esperalin)
    Private _Adenda As String = String.Empty
    Private _CodMoneda As Integer = 1
    Private _Codvendedor As Integer
    Public Sub New()
        _Lineas = New List(Of Esperalin)
        _Adenda = ""
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
        If (xLinea.PrecioTotalConDescuento < 0) Then
            MsgBox("No se puede agregar un importe negativo")
            Return
        End If

        If Lineas.Count = 0 Then
            Lineas.Add(xLinea)
            Return
        End If

        For Each espLin As Esperalin In Lineas
            If (espLin.ObjArticulo.CodArticulo = xLinea.ObjArticulo.CodArticulo) Then
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
            If L.ObjArticulo.CodArticulo = codigo Then
                Return L.ObjArticulo
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

    Friend Sub AllDescuento(xDescuento As Decimal)


        For Each Linea As Esperalin In _Lineas
            If AsignarDescuento(xDescuento, Linea.NumLinea) = False Then
                Return
            End If
        Next


    End Sub

    Friend Function AsignarDescuento(xDescuento As Decimal, xLinea As Integer) As Boolean
        If (xDescuento < 0) Then
            Return False
        End If

        If (xDescuento >= 100) Then
            Return False
        End If

        _Lineas.Find(Function(Linea As Esperalin) Linea.NumLinea = xLinea).Descuento = xDescuento
        Return True
    End Function
End Class
