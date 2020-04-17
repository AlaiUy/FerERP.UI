Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmDatosFactura
    Implements IObservable

    Private Esp As Type
    Private Cliente As Object = Nothing
    Private BanderaAddCC As Boolean = False
    Private Espera As UESPERA
    Private Observadores As List(Of IObserver)

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
                Cliente = GesPersonas.getInstance().getClienteContadoByDoc(txtIdCliente.Text)
            End If
        End If

        Popular()
    End Sub

    Private Sub Popular()
        If Not IsNothing(Cliente) Then
            If TypeOf Cliente Is ClienteContado Then
                txtDireccion.Text = TryCast(Cliente, ClienteContado).Direccion
                txtIdCliente.Text = TryCast(Cliente, ClienteContado).Documento
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
                        Cliente = GesPersonas.getInstance().addClienteContado(TryCast(Cliente, ClienteContado))
                    End If
                    Dim EsperaC As New EsperaContado(Now)
                    EsperaC.Codclientecontado = TryCast(Cliente, ClienteContado).Codigo
                    EsperaC.Adenda = txtAdenda.Text
                    EsperaC.AgregarLineas(Espera.Lineas)
                    EsperaC.Codvendedor = Espera.Codvendedor
                    If (TryCast(Cliente, ClienteContado).Codigo) = 1 Then
                        EsperaC.NombreCLiente = txtNombre.Text
                    Else
                        EsperaC.NombreCLiente = TryCast(Cliente, ClienteContado).Nombre
                    End If
                    EsperaC.Estado = 0
                    EsperaC.DirEnvio = txtDirEnvio.Text
                    GesDocumentos.getInstance().AddEspera(EsperaC)
                    notifyObservers()
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    ClearData()
                End Try
            Case "EsperaCuenta"
                Dim eCredito As New EsperaCredito()
        End Select



    End Sub

    Private Sub ClearData()
        Cliente = Nothing
        txtDocumento.Clear()
        txtNombre.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtIdCliente.Clear()
        txtDocumento.ReadOnly = False
        txtDireccion.ReadOnly = False
        txtIdCliente.ReadOnly = False
        txtNombre.ReadOnly = False
        txtDocumento.ReadOnly = False
        txtTelefono.ReadOnly = False
    End Sub

    Private Sub txtIdCliente_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtIdCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            brnFiltro.PerformClick()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim frmFormFiltro As Form
        Select Case Esp.Name
            Case "EsperaContado"
                frmFormFiltro = New frmFiltrosClientesContado()
                frmFormFiltro.ShowDialog()
                If frmFormFiltro.DialogResult = DialogResult.OK Then
                    Cliente = TryCast(frmFormFiltro, frmFiltrosClientesContado).Cliente

                    Popular()
                End If
            Case "EsperaCuenta"
        End Select
    End Sub

    Public Sub Register(xObserver As IObserver) Implements IObservable.Register
        If IsNothing(xObserver) Then
            Return
        End If
        If IsNothing(Observadores) Then
            Observadores = New List(Of IObserver)
        End If
        Observadores.Add(xObserver)
    End Sub

    Public Sub UnRegister(xObserver As IObserver) Implements IObservable.UnRegister
        If IsNothing(xObserver) Then Return
        If IsNothing(Observadores) Then Return
        Observadores.Remove(xObserver)
    End Sub

    Public Sub notifyObservers() Implements IObservable.notifyObservers

        For Each Obs As IObserver In Observadores
            Obs.Update("VENTA")
        Next
    End Sub

    Private Sub txtIdCliente_TextChanged_1(sender As Object, e As EventArgs) Handles txtIdCliente.TextChanged

    End Sub

    Private Sub txtIdCliente_LostFocus(sender As Object, e As EventArgs) Handles txtIdCliente.LostFocus
        If txtIdCliente.Text.Length > 0 Then
            brnFiltro.PerformClick()
            If IsNothing(Cliente) Then
                txtDocumento.Text = txtIdCliente.Text
                txtNombre.Focus()
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearData()

    End Sub
End Class