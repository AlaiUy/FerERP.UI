Imports System.Globalization
Imports JJ.Interfaces.Observer

Public Class frmMainMaterial

    Dim frmAbierto As Form = Nothing

    Private Sub frmMainMaterial_Load(sender As Object, e As EventArgs) Handles Me.Load
        Estilos.Redondear(PanelLeft, 5)
        Estilos.Redondear(PanelContainer, 5)


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

    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        If Not IsNothing(frmAbierto) Then
            frmAbierto.Close()
            frmAbierto.Dispose()
        End If
        frmAbierto = PanelContainer.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si form no fue econtrado/ no existe
        If frmAbierto Is Nothing Then
            frmAbierto = New Miform()
            frmAbierto.TopLevel = False

            frmAbierto.FormBorderStyle = FormBorderStyle.None
            frmAbierto.Dock = DockStyle.Fill

            PanelContainer.Controls.Add(frmAbierto)
            PanelContainer.Tag = frmAbierto
            AddHandler frmAbierto.FormClosed, AddressOf Me.CerrarFormulario
            frmAbierto.Show()
            frmAbierto.BringToFront()
        Else
            frmAbierto.BringToFront()
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
        AbrirFormEnPanel(Of frmAddArticulo_Material)()
    End Sub

    Private Sub btnUpArticulo_Click(sender As Object, e As EventArgs) Handles btnUpArticulo.Click
        AbrirFormEnPanel(Of frmUpArticulo_Material)()
    End Sub

    Private Sub btnPrintPrices_Click(sender As Object, e As EventArgs) Handles btnPrintPrices.Click
        AbrirFormEnPanel(Of frmPrintPrices)()
    End Sub


    Private Sub btnNuevaCompra_Click(sender As Object, e As EventArgs) Handles btnNuevaCompra.Click
        AbrirFormEnPanel(Of frmCompras_Material)()
    End Sub

    Private Sub btnEstadoCuenta_Click(sender As Object, e As EventArgs) Handles btnEstadoCuenta.Click
        AbrirFormEnPanel(Of frmCompras_EstadoCuenta)()
    End Sub

    Private Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
        AbrirFormEnPanel(Of frmCobros_Material)()
    End Sub

    Private Sub btnInfoArticulos_Click(sender As Object, e As EventArgs) Handles btnInfoArticulos.Click
        AbrirFormEnPanel(Of frmListadoArticulos)()
    End Sub

    Private Sub btnInfoVentas_Click(sender As Object, e As EventArgs) Handles btnInfoVentas.Click
        AbrirFormEnPanel(Of frmListadoVentas)()
    End Sub

    Private Sub btnNewVenta_Click(sender As Object, e As EventArgs) Handles btnNewVenta.Click
        AbrirFormEnPanel(Of frmNuevaVenta_Material)()
    End Sub

    Private Sub btnPresupuestoa_Click(sender As Object, e As EventArgs) Handles btnPresupuestoa.Click
        AbrirFormEnPanel(Of frmPresupuestos_Material)()
    End Sub
End Class