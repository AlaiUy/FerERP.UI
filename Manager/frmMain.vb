Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer

Public Class frmMain
    Implements IObserver
    Public xClaveAdmin As Boolean = True

    Dim Tab As TabControl = Nothing

    Private Sub btnNuevoArticulo_Click(sender As Object, e As EventArgs) Handles lblNuevoArticulo.Click
        btnAgregarArticulo.PerformClick()
    End Sub


    Private Sub btnMenuSalir_Click(sender As Object, e As EventArgs) Handles btnMenuSalir.Click
        If MsgBox("¿Desea salir de la aplicacion?", vbOKCancel, "Realmente...") = MsgBoxResult.Ok Then
            Close()
        End If
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = New Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.PrimaryScreen.WorkingArea.Size.Height)
        PopularForm()

    End Sub

    Private Sub CargarFormulario(ByVal xFormulario As Form)
        If IsNothing(Tab) Then
            PanelBienvenida.Hide()
            Tab = New TabControl()
            AddHandler Tab.KeyDown, AddressOf Tab_KeyPress
            PnContenedor.Controls.Add(Tab)
            Tab.Dock = DockStyle.Fill
        Else
            If Tab.TabPages.Count = 0 Then
                PanelBienvenida.Hide()
            End If
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

    Private Sub Tab_KeyPress(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim Key As System.Windows.Forms.KeyEventArgs = e
        If Key.KeyCode = Keys.Escape Then
            If Not IsNothing(Tab) Then

                If Tab.TabCount = 1 Then
                    Tab.Dispose()
                    Tab = Nothing
                    PanelBienvenida.Show()
                Else
                    Tab.TabPages.Remove(Tab.SelectedTab)
                End If
            End If
        End If
    End Sub

    Public Overloads Sub Update(Obj As Object) Implements IObserver.Update
        If (TypeOf Obj Is Form) Then
            If Not IsNothing(Tab) Then
                If Tab.TabCount = 1 Then
                    If TryCast(Obj, Form).DialogResult = DialogResult.Abort Then
                        PanelBienvenida.Show()
                        Tab.Dispose()
                        Tab = Nothing
                    End If
                Else
                    Tab.TabPages.Remove(Tab.SelectedTab)
                End If
            End If
        End If
    End Sub

    Private Sub PopularForm()
        MaximizeBox = False
        btnFicArticulos.Visible = LeerIni.LeerDato("MODULOS", "ARTICULOS", 0, ".\config.ini")
        lblNuevoArticulo.Visible = LeerIni.LeerDato("MODULOS", "ARTICULOS", 0, ".\config.ini")

        btnFichero.Visible = LeerIni.LeerDato("MODULOS", "FICHEROS", 0, ".\config.ini")
        lblAgregarProveedor.Visible = btnFichero.Visible
        lblAgregarPersona.Visible = btnFichero.Visible

        btnCompras.Visible = LeerIni.LeerDato("MODULOS", "COMPRAS", 0, ".\config.ini")

        ToolsConfig.Visible = LeerIni.LeerDato("MODULOS", "CONFIGURACION", 0, ".\config.ini")

        btnInformes.Visible = LeerIni.LeerDato("MODULOS", "INFORMES", 0, ".\config.ini")

        If LeerIni.LeerDato("MODULOS", "GUIA", 0, ".\config.ini") = 0 Then
            Try
                For Each Guia As Object In ToolsMain.Items
                    If TypeOf Guia Is ToolStripSeparator Then
                        Guia.Visible = False
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub


    Private Sub DatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosToolStripMenuItem.Click
        Dim Form As Form = New frmEmpresaData()
        Form.ShowDialog()
    End Sub

    Private Sub CompraToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As Form = New frmCompras()
        frm.Name = "Nueva compra"
        TryCast(frm, frmCompras).Register(Me)
        CargarFormulario(frm)
    End Sub

    Private Sub btnAgregarPersona_Click(sender As Object, e As EventArgs) Handles lblAgregarPersona.Click
        AgregarPersonaToolStripMenuItem.PerformClick()
    End Sub

    Private Sub AgregarPersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPersonaToolStripMenuItem.Click
        Dim frm As Form = New frmNuevaPersona()
        frm.Name = "Ingresar Persona"
        TryCast(frm, frmNuevaPersona).Register(Me)
        CargarFormulario(frm)
    End Sub

    Private Sub NuevaCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaCompraToolStripMenuItem.Click
        Try
            Dim frm As Form = New frmCompras()
            frm.Name = "Nueva Compra"
            TryCast(frm, frmCompras).Register(Me)
            CargarFormulario(frm)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub



    Private Sub btnAgregarArticulo_Click(sender As Object, e As EventArgs) Handles btnAgregarArticulo.Click
        Dim frm As Form = New frmNuevoArticulo()
        frm.Name = "Articulos"
        TryCast(frm, frmNuevoArticulo).Register(Me)
        CargarFormulario(frm)
    End Sub

    Private Sub ModificarArticuloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarArticuloToolStripMenuItem.Click
        Dim frm As Form = New frmUpdateArticulos()
        frm.Name = "Modificar un articulo"
        TryCast(frm, frmUpdateArticulos).Register(Me)
        CargarFormulario(frm)
    End Sub

    Private Sub NuevaVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaVentaToolStripMenuItem.Click
        'Dim frm As Form = New frmNuevaVenta()
        'frm.Name = "Nueva Venta"
        'TryCast(frm, frmNuevaVenta).Register(Me)
        'CargarFormulario(frm)


        Dim frm As Form = New frmNuevaVenta_Material()
        frm.Name = "Nueva Venta"
        TryCast(frm, frmNuevaVenta_Material).Register(Me)
        CargarFormulario(frm)
    End Sub

    Private Sub lblAgregarProveedor_Click(sender As Object, e As EventArgs) Handles lblAgregarProveedor.Click
        btnAgregarProveedor.PerformClick()
    End Sub

    Private Sub ImprimirPreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirPreciosToolStripMenuItem.Click
        Dim Form As Form = New frmPrintPrices()
        Form.ShowDialog()
    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArticulosToolStripMenuItem.Click
        Dim Form As Form = New frmListadoArticulos()
        Form.ShowDialog()
    End Sub

    Private Sub CotizacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CotizacionToolStripMenuItem.Click
        Dim fr As frmCotizaciones = New frmCotizaciones()
        fr.Show()
    End Sub



    Private Sub ModificarProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarProveedorToolStripMenuItem.Click
        Dim frm As Form = New frmUpProveedor()
        frm.Name = "Modificar un proveedor"
        TryCast(frm, frmUpProveedor).Register(Me)
        CargarFormulario(frm)
    End Sub

    Private Sub btnAgregarProveedor_Click(sender As Object, e As EventArgs) Handles btnAgregarProveedor.Click
        Dim frm As Form = New frmNuevoProveedor()
        frm.Name = "Ingresar Proveedor"
        TryCast(frm, frmNuevoProveedor).Register(Me)
        CargarFormulario(frm)
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Dim Form As Form = New frmListadoVentas()
        Form.ShowDialog()
    End Sub

    Private Sub FicherosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FicherosToolStripMenuItem.Click

    End Sub
End Class