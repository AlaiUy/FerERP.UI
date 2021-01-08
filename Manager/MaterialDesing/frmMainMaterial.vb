Imports System.Globalization
Imports JJ.Entidades
Imports JJ.Interfaces.Observer
Imports JJ.Logger

Public Class frmMainMaterial
    Implements IObserver

    Dim frmAbierto As Form = Nothing
    Dim Tab As TabControl = Nothing

    Private Sub frmMainMaterial_Load(sender As Object, e As EventArgs) Handles Me.Load

        Log.LogOut("Te envio la moneda", New Moneda(2, "qwe", "sb", 1.0, 2.0))

        Estilos.Redondear(PanelLeft, 5)
        'Estilos.Redondear(PanelContainer, 5)


        Estilos.Redondear(lblArticulos, 5)
        Estilos.Redondear(lblInformes, 5)
        Estilos.Redondear(lblCompras, 5)
        Estilos.Redondear(lblVentas, 5)
        lblFecha.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(DateTime.Now.ToLongDateString())
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("HH:mm:ss")

    End Sub

    Private Sub PanelLeft_Paint(sender As Object, e As PaintEventArgs) Handles PanelLeft.Paint

    End Sub

    Private Sub btnOff_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnOff_Click_1(sender As Object, e As EventArgs) Handles btnOff.Click
        If MsgBox("Desea cerrar la aplicacion", vbOKCancel, "Cierre total") = vbOK Then
            Close()
        End If
    End Sub

    'Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
    '    If Not IsNothing(frmAbierto) Then
    '        frmAbierto.Close()
    '        frmAbierto.Dispose()
    '    End If
    '    frmAbierto = PanelContainer.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
    '    'Si form no fue econtrado/ no existe
    '    If frmAbierto Is Nothing Then
    '        frmAbierto = New Miform()
    '        frmAbierto.TopLevel = False

    '        frmAbierto.FormBorderStyle = FormBorderStyle.None
    '        frmAbierto.Dock = DockStyle.Fill

    '        PanelContainer.Controls.Add(frmAbierto)
    '        PanelContainer.Tag = frmAbierto
    '        AddHandler frmAbierto.FormClosed, AddressOf Me.CerrarFormulario
    '        frmAbierto.Show()
    '        frmAbierto.BringToFront()
    '    Else
    '        frmAbierto.BringToFront()
    '    End If
    'End Sub

    Private Sub CargarFormulario(ByVal xFormulario As Form)
        If IsNothing(Tab) Then
            Tab = New TabControl()
            AddHandler Tab.KeyDown, AddressOf Tab_KeyPress
            PanelContainer.Controls.Add(Tab)
            Tab.Dock = DockStyle.Fill
        End If
        Dim TP As TabPage = New TabPage(xFormulario.Name)
        Dim Panel As Panel = New Panel()
        With xFormulario
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
        End With
        With Panel
            .Controls.Add(xFormulario)
            .Dock = DockStyle.Fill
        End With

        With TP
            .Controls.Add(Panel)
            .BackColor = Color.White
        End With
        With Tab
            Tab.TabPages.Add(TP)
            Tab.Appearance = TabAppearance.FlatButtons
        End With

        xFormulario.Show()
    End Sub

    Private Sub Tab_KeyPress(sender As Object, e As KeyEventArgs)
        Dim Key As System.Windows.Forms.KeyEventArgs = e
        If Key.KeyCode = Keys.Escape Then
            If Not IsNothing(Tab) Then
                If Tab.TabCount > 0 Then
                    Tab.TabPages.Remove(Tab.SelectedTab)
                End If

            End If
        End If
    End Sub

    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'CONDICION SI FORMS ESTA ABIERTO
        'If (Application.OpenForms(frmAbierto.Name) Is Nothing) Then
        '    btnAddArticulo.BackColor = Color.FromArgb(4, 41, 68)
        'End If

    End Sub

    Private Sub lblFecha_Click(sender As Object, e As EventArgs) Handles lblFecha.Click

    End Sub

    Private Sub btnNewArticulo_Click(sender As Object, e As EventArgs) Handles btnNewArticulo.Click
        Dim frm As Form = New frmAddArticulo_Material()
        frm.Name = "Crear Articulo"
        TryCast(frm, frmAddArticulo_Material).Register(Me)
        CargarFormulario(frm)
        'AbrirFormEnPanel(Of )()
    End Sub

    Private Sub btnUpArticulo_Click(sender As Object, e As EventArgs) Handles btnUpArticulo.Click
        Dim frm As Form = New frmUpArticulo_Material()
        frm.Name = "Actualizar articulos"
        TryCast(frm, frmUpArticulo_Material).Register(Me)
        CargarFormulario(frm)
        'AbrirFormEnPanel(Of frmUpArticulo_Material)()
    End Sub

    Private Sub btnPrintPrices_Click(sender As Object, e As EventArgs) Handles btnPrintPrices.Click
        Dim frm As Form = New frmPrintPrices()
        frm.Name = "Imprimir Precios"
        TryCast(frm, frmPrintPrices).Register(Me)
        CargarFormulario(frm)
        'AbrirFormEnPanel(Of frmPrintPrices)()
    End Sub


    Private Sub btnNuevaCompra_Click(sender As Object, e As EventArgs) Handles btnNuevaCompra.Click
        Dim frm As Form = New frmCompras_Material()
        frm.Name = "Nueva compra"
        TryCast(frm, frmCompras_Material).Register(Me)
        CargarFormulario(frm)
        'AbrirFormEnPanel(Of frmCompras_Material)()
    End Sub

    Private Sub btnEstadoCuenta_Click(sender As Object, e As EventArgs) Handles btnEstadoCuenta.Click
        Dim frm As Form = New frmCompras_EstadoCuenta()
        frm.Name = "Estado cuenta proveedor"
        TryCast(frm, frmCompras_EstadoCuenta).Register(Me)
        CargarFormulario(frm)
        'AbrirFormEnPanel(Of frmCompras_EstadoCuenta)()
    End Sub

    Private Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
        Dim frm As Form = New frmCobros_Material()
        frm.Name = "Ingresar Pago"
        TryCast(frm, frmCobros_Material).Register(Me)
        CargarFormulario(frm)
        'AbrirFormEnPanel(Of frmCobros_Material)()
    End Sub

    Private Sub btnInfoArticulos_Click(sender As Object, e As EventArgs) Handles btnInfoArticulos.Click
        Dim frm As Form = New frmListadoArticulos()
        frm.Name = "Listado de articulos"
        TryCast(frm, frmListadoArticulos).Register(Me)
        CargarFormulario(frm)
        'AbrirFormEnPanel(Of frmListadoArticulos)()
    End Sub

    Private Sub btnInfoVentas_Click(sender As Object, e As EventArgs) Handles btnInfoVentas.Click
        Dim frm As Form = New frmListadoVentas()
        frm.Name = "Listado de ventas"
        TryCast(frm, frmListadoVentas).Register(Me)
        CargarFormulario(frm)
        'AbrirFormEnPanel(Of frmListadoVentas)()
    End Sub

    Private Sub btnNewVenta_Click(sender As Object, e As EventArgs) Handles btnNewVenta.Click
        Dim frm As Form = New frmNuevaVenta_Material()
        frm.Name = "Venta"
        TryCast(frm, frmNuevaVenta_Material).Register(Me)
        CargarFormulario(frm)
    End Sub

    Private Sub btnPresupuestoa_Click(sender As Object, e As EventArgs) Handles btnPresupuestoa.Click
        Dim frm As Form = New frmPresupuestos_Material()
        frm.Name = "Presupuesto"
        TryCast(frm, frmPresupuestos_Material).Register(Me)
        CargarFormulario(frm)
    End Sub

    Private Sub lblArticulos_Click(sender As Object, e As EventArgs) Handles lblArticulos.Click

    End Sub

    Public Sub Update(Obj As Object) Implements IObserver.Update
        If (TypeOf Obj Is Form) Then
            If Not IsNothing(Tab) Then
                If Tab.TabPages.Count > 0 Then
                    Tab.TabPages.Remove(Tab.SelectedTab)
                End If
            End If
        End If
    End Sub

    Private Sub btnNuevoProveedor_Click(sender As Object, e As EventArgs) Handles btnNuevoProveedor.Click
        Dim frm As Form = New frmNuevoProveedor_Material()
        frm.Name = "Listado de ventas"
        TryCast(frm, frmNuevoProveedor_Material).Register(Me)
        CargarFormulario(frm)
    End Sub

    Private Sub btnCotizacion_Click(sender As Object, e As EventArgs) Handles btnCotizacion.Click
        Dim frm As Form = New frmCotizaciones()
        frm.Name = "Cambiar cotizacion"
        TryCast(frm, frmCotizaciones).Register(Me)
        CargarFormulario(frm)
    End Sub

    Private Sub btnUpProveedor_Click(sender As Object, e As EventArgs) Handles btnUpProveedor.Click
        Dim frm As Form = New frmUpProveedor_Material()
        frm.Name = "Actualizar proveedor"
        TryCast(frm, frmUpProveedor_Material).Register(Me)
        CargarFormulario(frm)
    End Sub
End Class