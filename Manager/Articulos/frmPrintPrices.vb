Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer
Imports JJ.Reportes

Public Class frmPrintPrices
    Implements IObserver, IObservable

    Private _observadores As List(Of IObserver)
    Private _Articulos As New List(Of Articulo)
    Private _frmArticulos As Form
    Private Sub frmPrintPrices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Estilos.Redondear(Imprimir, 3)
    End Sub



    Public Function MostrarTabla() As DataTable

        Dim tTable As New DataTable
        Dim ColCod As DataColumn = tTable.Columns.Add("NOMBRE", Type.GetType("System.String"))
        Dim ColRef As DataColumn = tTable.Columns.Add("PRECIO", Type.GetType("System.String"))
        Dim ColCan As DataColumn = tTable.Columns.Add("REFERENCIA", Type.GetType("System.String"))

        For Each A As Articulo In _Articulos
            Dim Row As DataRow = tTable.NewRow()
            Row.Item("REFERENCIA") = "COD: " & A.Referencia
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
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmPrintPrices_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = DialogResult.Abort
            notifyObservers()
        End If
    End Sub

    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If IsNothing(_frmArticulos) Then
            _frmArticulos = New frmArticulos_Material(Me)
        End If
        _frmArticulos.Show()
    End Sub

    Public Sub Update(Obj As Object) Implements IObserver.Update
        If TypeOf Obj Is Articulo Then
            _Articulos.Add(TryCast(Obj, Articulo))
            GridArticulos.DataSource = MostrarTabla()
        End If
        If TypeOf Obj Is String Then
            _frmArticulos.Close()
            _frmArticulos.Dispose()
        End If
    End Sub

    Public Sub Register(xObserver As IObserver) Implements IObservable.Register
        If IsNothing(_observadores) Then
            _observadores = New List(Of IObserver)
        End If
        _observadores.Add(xObserver)
    End Sub

    Public Sub UnRegister(xObserver As IObserver) Implements IObservable.UnRegister
        Throw New NotImplementedException()
    End Sub

    Public Sub notifyObservers() Implements IObservable.notifyObservers
        For Each O As IObserver In _observadores
            O.Update(Me)
        Next
    End Sub
End Class