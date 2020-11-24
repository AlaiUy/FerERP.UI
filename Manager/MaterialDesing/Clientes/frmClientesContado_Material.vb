Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmClientesContado_Material

    Private _Observers As List(Of IObserver)
    Private _Cliente As ClienteContado

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub



    Private Sub frmClientesContado_Material_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Close()
            Case Keys.F2

        End Select
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Close()
    End Sub

    Private Sub frmClientesContado_Material_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim frmFormFiltro As frmFiltrosClientesContado

        frmFormFiltro = New frmFiltrosClientesContado()
        frmFormFiltro.ShowDialog()
        If frmFormFiltro.DialogResult = DialogResult.OK Then
            _Cliente = TryCast(frmFormFiltro, frmFiltrosClientesContado).Cliente
            frmFormFiltro.Dispose()
            Popular()
        End If

    End Sub

    Private Sub Popular()
        txtNombre.Text = _Cliente.Nombre
        txtDireccion.Text = _Cliente.Direccion
        txtDocumento.Text = _Cliente.Documento
        txtTelefono.Text = _Cliente.Telefono


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        _Cliente.Nombre = txtNombre.Text.ToUpper()
        _Cliente.Documento = txtDocumento.Text
        _Cliente.Direccion = txtDireccion.Text.ToUpper()
        _Cliente.Telefono = txtTelefono.Text.ToUpper()
        Try
            GesPersonas.getInstance().UpdateCliente(_Cliente)
            frmSuccess.FormCorrecto("Los datos del cliente fueron actualizados correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class