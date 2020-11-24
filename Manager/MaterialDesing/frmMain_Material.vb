Imports System.Runtime.InteropServices
Public Class frmMain_Material
    Dim frmAbierto As Form = Nothing

    'ARRASTRAR EL FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        TimerTime.Enabled = True
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub



    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        If MsgBox("Desea cerrar la aplicacion", vbOKCancel, "Atencion") = MsgBoxResult.Ok Then
            Close()
        End If
    End Sub



    Private Sub OcultarMenu()
        PanelArticulos.Visible = False
        PanelCompras.Visible = False
        PanelFichero.Visible = False
        PanelInformes.Visible = False
        PanelVentas.Visible = False
    End Sub

    Private Sub MostrarPanel(ByVal xMenu As Panel)
        If xMenu.Visible = False Then
            OcultarMenu()
            xMenu.Visible = True
        Else
            xMenu.Visible = False
        End If
    End Sub

    Private Sub btnArticulos_Click(sender As Object, e As EventArgs)
        MostrarPanel(PanelArticulos)
    End Sub



    Private Sub frmMain_Material_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmMain_Material_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
        Dim Pen As New Pen(Color.Black, 1)
        e.Graphics.DrawLine(Pen, 0, 0, PanelFormularios.Width, 0)

    End Sub

    Private Sub PanelTop_MouseMove(sender As Object, e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    'METODO DE ABRIR FORMULARIO
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        If Not IsNothing(frmAbierto) Then
            frmAbierto.Close()
            frmAbierto.Dispose()
        End If
        frmAbierto = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si form no fue econtrado/ no existe
        If frmAbierto Is Nothing Then
            frmAbierto = New Miform()
            frmAbierto.TopLevel = False

            frmAbierto.FormBorderStyle = FormBorderStyle.None
            frmAbierto.Dock = DockStyle.Fill

            PanelFormularios.Controls.Add(frmAbierto)
            PanelFormularios.Tag = frmAbierto
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







    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        MostrarPanel(PanelVentas)
    End Sub

    Private Sub btnInformes_Click(sender As Object, e As EventArgs) Handles btnInformes.Click
        MostrarPanel(PanelInformes)
    End Sub

    Private Sub btnListadoArticulos_Click(sender As Object, e As EventArgs) Handles btnListadoArticulos.Click
        AbrirFormEnPanel(Of frmListadoArticulos)()
    End Sub

    Private Sub btnListadoVentas_Click(sender As Object, e As EventArgs) Handles btnListadoVentas.Click
        AbrirFormEnPanel(Of frmListadoVentas)()
    End Sub

    Private Sub btnFicheros_Click(sender As Object, e As EventArgs) Handles btnFicheros.Click
        MostrarPanel(PanelFichero)
    End Sub

    Private Sub btnClientesContado_Click(sender As Object, e As EventArgs) Handles btnClientesContado.Click
        AbrirFormEnPanel(Of frmClientesContado_Material)()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormEnPanel(Of frmCompras_Material)()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MostrarPanel(PanelCompras)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AbrirFormEnPanel(Of frmCompras_EstadoCuenta)()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AbrirFormEnPanel(Of frmCobros_Material)()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AbrirFormEnPanel(Of frmNuevaVenta_Material)()
    End Sub

    Private Sub TimerTime_Tick(sender As Object, e As EventArgs) Handles TimerTime.Tick
        lblHora.Text = DateTime.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub btnArticulos_Click_1(sender As Object, e As EventArgs) Handles btnArticulos.Click
        MostrarPanel(PanelArticulos)
    End Sub

    Private Sub btnNewArticulo_Click(sender As Object, e As EventArgs) Handles btnNewArticulo.Click
        AbrirFormEnPanel(Of frmAddArticulo_Material)()
    End Sub

    Private Sub btnPrintPrices_Click(sender As Object, e As EventArgs) Handles btnPrintPrices.Click
        AbrirFormEnPanel(Of frmPrintPrices)()
    End Sub

    Private Sub btnUpArticulo_Click(sender As Object, e As EventArgs) Handles btnUpArticulo.Click
        AbrirFormEnPanel(Of frmUpArticulo_Material)()
    End Sub

    ''
    ''
    '' 
End Class