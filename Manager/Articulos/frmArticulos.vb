Imports System.Configuration
Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmArticulos
    Implements IObservable

    Private _Observers As List(Of IObserver)
    'Private _lista As List(Of Articulo)
    Private _TablaArticulos As DataTable
    Private _ListaFiltrada As DataTable
    Private _Articulo As Articulo = Nothing
    Private _Cantidad As Decimal = 0
    Private mIndex As Byte = 1 'Columna seleccionada
    Private mActiva As String = "CODIGO" ' Nombre columna activa
    Private mFiltro As String = ""
    Private xDescuento As Decimal = GesEmpresa.getInstance().Empresa.DescuentoContado
    Private ColorContado As Color = Color.FromArgb(192, 255, 192)

    Public Sub New(ByVal xObserver As IObserver)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Register(xObserver)
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public ReadOnly Property Articulo As Articulo
        Get
            Return _Articulo
        End Get

    End Property

    Public ReadOnly Property Cantidad As Decimal
        Get
            Return _Cantidad
        End Get
    End Property

    Private Sub frmArticulos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.F2
                dgArticulos.DataSource = _TablaArticulos
        End Select

    End Sub

    Private Sub frmArticulos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub



    Private Sub frmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _TablaArticulos = GesArticulos.getInstance().getVistaArticulos()
            _ListaFiltrada = _TablaArticulos.Copy()

            dgArticulos.DataSource = _ListaFiltrada
            Funciones.DoubleBuffered(dgArticulos, True)
            PopularGrilla()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





    Private Sub PopularGrilla()
        Dim SumaAnchos As Decimal = 1
        dgArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        dgArticulos.Columns("CODIGO").Visible = False
        dgArticulos.Columns("MONEDA").Visible = LeerIni.LeerDato("VISTA_ARTICULOS", "MONEDA", 0, ".\config.ini")
        dgArticulos.Columns("ACTIVO").Visible = LeerIni.LeerDato("VISTA_ARTICULOS", "ACTIVO", 0, ".\config.ini")
        dgArticulos.Columns("MARCA").Visible = LeerIni.LeerDato("VISTA_ARTICULOS", "MARCA", 0, ".\config.ini")
        dgArticulos.Columns("MODELO").Visible = LeerIni.LeerDato("VISTA_ARTICULOS", "MODELO", 0, ".\config.ini")
        dgArticulos.Columns("STOCK").Visible = LeerIni.LeerDato("VISTA_ARTICULOS", "STOCK", 0, ".\config.ini")
        dgArticulos.Columns("DESCRIPCION").Visible = LeerIni.LeerDato("VISTA_ARTICULOS", "DESCRIPCION", 0, ".\config.ini")

        For Each C As DataGridViewColumn In dgArticulos.Columns
            If C.Visible Then
                Select Case C.Name
                    Case "REFERENCIA"
                        C.Width += 10
                        SumaAnchos += C.Width
                    Case "PRECIO"
                        C.Width += 43
                        SumaAnchos += C.Width
                        C.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    Case "CONTADO"
                        C.Width += 43
                        SumaAnchos += C.Width
                        C.DefaultCellStyle.BackColor = ColorContado
                        C.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                End Select

            End If
        Next
        With dgArticulos

            For Each ObjCol As DataGridViewColumn In .Columns
                ObjCol.SortMode = DataGridViewColumnSortMode.Programmatic
            Next
            .Columns(mIndex).DefaultCellStyle.BackColor = Color.Beige

        End With


        Dim Resto As Decimal = dgArticulos.Width - SumaAnchos

        dgArticulos.Columns("NOMBRE").Width = Resto / 2
    End Sub

    Private Sub dgArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgArticulos.CellDoubleClick
        If e.RowIndex = -1 Then
            Return
        End If
        Dim xCod As String
        Dim xIndexColumn As Integer = dgArticulos.Columns("CODIGO").Index
        xCod = dgArticulos.Item(xIndexColumn, e.RowIndex).Value
        Try
            _Articulo = GesArticulos.getInstance().getArticuloById(xCod)
            _Cantidad = Convert.ToDecimal(txtCantidad.Text)
            txtCantidad.Text = 1
            notifyObservers(_Articulo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Register(xObserver As IObserver) Implements IObservable.Register
        If IsNothing(_Observers) Then
            _Observers = New List(Of IObserver)
        End If
        _Observers.Add(xObserver)
    End Sub

    Public Sub UnRegister(xObserver As IObserver) Implements IObservable.UnRegister
        For Each O As IObserver In _Observers
            If (O.Equals(xObserver)) Then
                _Observers.Remove(O)
            End If
        Next
    End Sub

    Public Sub notifyObservers() Implements IObservable.notifyObservers
        For Each O As IObserver In _Observers
            O.Update(_Articulo)
        Next
    End Sub

    Public Sub notifyObservers(ByVal xNotificar As Object)
        For Each O As IObserver In _Observers
            O.Update(xNotificar)
        Next
    End Sub

    Private Sub txtReferencia_TextChanged(sender As Object, e As EventArgs) Handles txtReferencia.TextChanged

    End Sub

    Private Sub txtReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReferencia.KeyPress
        If e.KeyChar = "+" Then
            e.Handled = True
            If IsNumeric(txtReferencia.Text) Then
                If ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart, 6) Then
                    txtCantidad.Text = txtReferencia.Text
                End If
                txtReferencia.Text = String.Empty
            End If
        End If
    End Sub



    Private Sub dgArticulos_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgArticulos.ColumnHeaderMouseClick
        mFiltro = ""
        mActiva = (sender.Columns(e.ColumnIndex).Name)
        For Each C As DataGridViewColumn In dgArticulos.Columns
            If C.Visible Then
                Select Case C.Name
                    Case "CONTADO"
                        C.DefaultCellStyle.BackColor = ColorContado

                    Case Else
                        C.DefaultCellStyle.BackColor = Color.White


                End Select

            End If
        Next
        With sender
            .Columns(e.ColumnIndex).DefaultCellStyle.BackColor = Color.Beige
        End With
        mIndex = e.ColumnIndex

        If txtReferencia.Text.Length > 1 Then
            Try

                _ListaFiltrada = (From Cliente In _TablaArticulos.AsEnumerable()
                                  Where Cliente(mActiva).Contains(txtReferencia.Text.ToUpper())
                                  Select Cliente).CopyToDataTable()
                dgArticulos.DataSource = _ListaFiltrada
                txtReferencia.Clear()
            Catch ex As Exception


            End Try
        End If
    End Sub

    Private Sub dgArticulos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgArticulos.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim xCod As String
            Dim xIndexColumn As Integer = dgArticulos.Columns("CODIGO").Index
            xCod = dgArticulos.Item(xIndexColumn, dgArticulos.CurrentRow.Index).Value
            Try
                _Articulo = GesArticulos.getInstance().getArticuloById(xCod)
                _Cantidad = Convert.ToDecimal(txtCantidad.Text)
                txtCantidad.Text = 1
                notifyObservers(_Articulo)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
End Class