Imports JJ.Interfaces.Observer

Public Class frmDescuentosCompra
    Implements IObservable
    Private _Obs As IList(Of IObserver)
    Private _Descuentos As List(Of Decimal) = New List(Of Decimal)

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(ByVal xLista As List(Of Decimal))

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _Descuentos = xLista
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        _Descuentos = New List(Of Decimal)
        _Descuentos.Add(ValorDescuento(TextBox1.Text))
        _Descuentos.Add(ValorDescuento(TextBox2.Text))
        _Descuentos.Add(ValorDescuento(TextBox3.Text))
        _Descuentos.Add(ValorDescuento(TextBox4.Text))
        notifyObservers()
    End Sub

    Private Function ValorDescuento(ByVal xTexto As String) As Decimal
        If xTexto.Length >= 0 Then
            Try
                Return Convert.ToDecimal(xTexto)
            Catch ex As Exception
                Return 0
            End Try
        End If
        Return 0
    End Function

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (TryCast(sender, TextBox).SelectedText.Length = TryCast(sender, TextBox).TextLength) Then
            TryCast(sender, TextBox).Text = ""
            e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart)
        End If

        If Not e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart)
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (TryCast(sender, TextBox).SelectedText.Length = TryCast(sender, TextBox).TextLength) Then
            TryCast(sender, TextBox).Text = ""
            e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart)
        End If

        If Not e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart)
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (TryCast(sender, TextBox).SelectedText.Length = TryCast(sender, TextBox).TextLength) Then
            TryCast(sender, TextBox).Text = ""
            e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart)
        End If

        If Not e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart)
        End If

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If (TryCast(sender, TextBox).SelectedText.Length = TryCast(sender, TextBox).TextLength) Then
            TryCast(sender, TextBox).Text = ""
            e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart)
        End If

        If Not e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = ValidarImportes(e.KeyChar, TryCast(sender, TextBox).Text, TryCast(sender, TextBox).SelectionLength, TryCast(sender, TextBox).SelectionStart)
        End If
    End Sub

    Public Sub UnRegister(xObserver As IObserver) Implements IObservable.UnRegister
        For Each O As IObserver In _Obs
            If (O.Equals(xObserver)) Then
                _Obs.Remove(O)
            End If
        Next
    End Sub

    Public Sub notifyObservers() Implements IObservable.notifyObservers
        For Each O As IObserver In _Obs
            O.Update(_Descuentos)
        Next
    End Sub

    Public Sub Register(xObserver As IObserver) Implements IObservable.Register
        If IsNothing(_Obs) Then
            _Obs = New List(Of IObserver)
        End If
        _Obs.Add(xObserver)
    End Sub

    Private Sub frmDescuentosCompra_Load(sender As Object, e As EventArgs) Handles Me.Load
        Popular()
    End Sub

    Private Sub Popular()
        If Not IsNothing(_Descuentos) And _Descuentos.Count > 0 Then
            TextBox1.Text = _Descuentos(0)
            TextBox2.Text = _Descuentos(1)
            TextBox3.Text = _Descuentos(2)
            TextBox4.Text = _Descuentos(3)
        End If
    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class