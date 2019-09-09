Imports JJ.Entidades
Imports JJ.Gestoras

Public Class frmDatosFactura
    Private Esp As Type
    Private Cliente As Object = Nothing
    Private BanderaAddCC As Boolean = False
    Private Espera As UESPERA
    Public Sub New(ByVal xTipo As Type, ByVal xEspera As UESPERA)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Esp = xTipo
        Espera = xEspera
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmDatosFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DiseñoForm()
        centrar(Panel_Datos, grp_personales)
    End Sub

    Private Sub centrar(ObjectWich As Object, ObjectWhere As GroupBox)
        ObjectWich.Left = (ObjectWhere.Width - ObjectWich.Width) / 2
        ObjectWich.Top = (ObjectWhere.Height - ObjectWich.Height) / 2
    End Sub

    Private Sub brnFiltro_Click(sender As Object, e As EventArgs) Handles brnFiltro.Click
        If txtIdCliente.Text.Trim.Length > 1 Then
            If IsNumeric(txtIdCliente.Text) Then
                Cliente = GesPersonas.getInstance().getClienteContadoByID(Convert.ToInt32(txtIdCliente.Text))
            End If
        End If
        If IsNothing(Cliente) Then
            Dim frmFormFiltro As Form
            Select Case Esp.Name
                Case "EsperaContado"
                    frmFormFiltro = New frmFiltrosClientesContado()
                    frmFormFiltro.ShowDialog()
                    If frmFormFiltro.DialogResult = DialogResult.OK Then
                        Cliente = TryCast(frmFormFiltro, frmFiltrosClientesContado).Cliente
                    End If
                Case "EsperaCuenta"
            End Select
        End If
        Popular()
    End Sub

    Private Sub Popular()
        If Not IsNothing(Cliente) Then
            If TypeOf Cliente Is ClienteContado Then
                txtDireccion.Text = TryCast(Cliente, ClienteContado).Direccion
                txtIdCliente.Text = TryCast(Cliente, ClienteContado).Codigo
                txtNombre.Text = TryCast(Cliente, ClienteContado).Nombre
                txtDocumento.Text = TryCast(Cliente, ClienteContado).Documento
                txtTelefono.Text = TryCast(Cliente, ClienteContado).Telefono
            End If
            If TryCast(Cliente, ClienteContado).Codigo > 1 Then
                txtDocumento.ReadOnly = True
                txtDireccion.ReadOnly = True
                txtIdCliente.ReadOnly = True
                txtNombre.ReadOnly = True
                txtDocumento.ReadOnly = True
                txtTelefono.ReadOnly = True
            End If
        End If

    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        Select Case Esp.Name
            Case "EsperaContado"
                If IsNothing(Cliente) Then
                    BanderaAddCC = True
                    Cliente = New ClienteContado(txtDocumento.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text)
                End If
                Try
                    If BanderaAddCC Then
                        GesPersonas.getInstance().addClienteContado(TryCast(Cliente, ClienteContado))
                    End If
                    Dim EsperaC As New EsperaContado(Now)
                    EsperaC.Codclientecontado = TryCast(Cliente, ClienteContado).Codigo
                    EsperaC.Adenda = txtAdenda.Text
                    EsperaC.AgregarLineas(Espera.Lineas)
                    EsperaC.Codvendedor = Espera.Codvendedor
                    EsperaC.NombreCLiente = TryCast(Cliente, ClienteContado).Nombre
                    EsperaC.Estado = 0
                    EsperaC.DirEnvio = txtDirEnvio.Text
                    GesDocumentos.getInstance().AddEspera(EsperaC)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "EsperaCuenta"
        End Select



    End Sub

    Private Sub txtIdCliente_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtIdCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            brnFiltro.PerformClick()
        End If
    End Sub
End Class