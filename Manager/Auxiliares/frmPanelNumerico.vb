Imports System.Globalization
Imports JJ.Interfaces.Observer

Public Class frmPanelNumerico
    Private _FlagPrimerIngeso As Boolean = True
    Private _Numero As Decimal = 0



    Public ReadOnly Property Numero As Decimal
        Get
            Return _Numero
        End Get

    End Property


    Private Sub frmPanelNumerico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumero.Text = 0
    End Sub

    Private Sub Enter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Try

            If Not String.IsNullOrEmpty(txtNumero.Text) Then
                _Numero = Convert.ToDecimal(txtNumero.Text)
            End If
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            MsgBox("El valor ingresado no es correcto", vbOK, "Revisar")
        End Try
    End Sub

    Private Sub txtNumero_MouseDown(sender As Object, e As MouseEventArgs) Handles txtNumero.MouseDown

    End Sub

    Private Sub txtNumero_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumero.KeyDown




    End Sub

    Private Sub btnUno_Click(sender As Object, e As EventArgs) Handles btnUno.Click
        AgregarValor("1")
    End Sub

    Private Sub AgregarComa()
        Dim Sep As Char = Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)
        If _FlagPrimerIngeso Then
            txtNumero.Text = "0" & Sep
            _FlagPrimerIngeso = False
        ElseIf txtNumero.Text.Contains(Sep) Then
            Return
        Else
            txtNumero.Text = txtNumero.Text & Sep
            Return
        End If
        txtNumero.Focus()
        txtNumero.SelectionStart = txtNumero.Text.Length
    End Sub


    Private Sub AgregarValor(ByVal xIngreso As String)
        If Convert.ToInt32(xIngreso) > 9 Then
            Return
        End If

        If _FlagPrimerIngeso Then
            txtNumero.Text = xIngreso
            _FlagPrimerIngeso = False
            Return
        Else
            txtNumero.Text = txtNumero.Text & xIngreso
        End If

        txtNumero.Focus()
        txtNumero.SelectionStart = txtNumero.Text.Length
    End Sub

    Private Sub btnDos_Click(sender As Object, e As EventArgs) Handles btnDos.Click
        AgregarValor("2")
    End Sub

    Private Sub btnTres_Click(sender As Object, e As EventArgs) Handles btnTres.Click
        AgregarValor("3")
    End Sub

    Private Sub btnCuatro_Click(sender As Object, e As EventArgs) Handles btnCuatro.Click
        AgregarValor("4")
    End Sub

    Private Sub btnCinco_Click(sender As Object, e As EventArgs) Handles btnCinco.Click
        AgregarValor("5")
    End Sub

    Private Sub btnSeis_Click(sender As Object, e As EventArgs) Handles btnSeis.Click
        AgregarValor("6")
    End Sub

    Private Sub btnSiete_Click(sender As Object, e As EventArgs) Handles btnSiete.Click
        AgregarValor("7")
    End Sub

    Private Sub btnOcho_Click(sender As Object, e As EventArgs) Handles btnOcho.Click
        AgregarValor("8")
    End Sub

    Private Sub btnNueve_Click(sender As Object, e As EventArgs) Handles btnNueve.Click
        AgregarValor("9")
    End Sub

    Private Sub btnComa_Click(sender As Object, e As EventArgs) Handles btnComa.Click
        AgregarComa()
    End Sub

    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged

    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        e.Handled = True
        Select Case (e.KeyChar)
            Case "0"
                AgregarValor("0")
            Case "1"
                AgregarValor("1")
            Case "2"
                AgregarValor("2")
            Case "3"
                AgregarValor("3")
            Case "4"
                AgregarValor("4")
            Case "5"
                AgregarValor("5")
            Case "6"
                AgregarValor("6")
            Case "7"
                AgregarValor("7")
            Case "8"
                AgregarValor("8")
            Case "9"
                AgregarValor("9")
            Case ","
                AgregarComa()
            Case Convert.ToChar(Keys.Back)
                e.Handled = False
            Case Convert.ToChar(Keys.Enter)
                btnEnter.PerformClick()
            Case "."
                AgregarComa()

                'Case Keys.Back
                '    e.Handled = True
                'Case Keys.Enter
                '    btnEnter.PerformClick()
        End Select
    End Sub


End Class