Public Class frmSuccess
    Private Sub New(ByVal xMensaje As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lblMensaje.Text = xMensaje
    End Sub

    Public Shared Sub FormCorrecto(ByVal xMensaje As String)
        Dim Form As frmSuccess = New frmSuccess(xMensaje)
        Form.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub frmSuccess_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmSuccess_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub
End Class