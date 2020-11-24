Imports JJ.Entidades
Imports JJ.Gestoras
Imports JJ.Interfaces.Observer
Imports JJ.Reportes

Public Class frmOpcionesPresupuestos_Material

    Dim Espera As UESPERA
    Dim _Cliente As ClienteContado

    Public Sub New(ByVal xEspera As UESPERA)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Espera = xEspera
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub frmOpcionesPresupuestos_Material_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If CheckBox1.Checked Then
                Espera.AllDescuento(-10, True)
            End If
            Dim DT As DataTable = Espera.MostrarTabla
            DT.TableName = "Presupuesto"
            GestionReporte.Presupuesto(DT, txtDias.Text, txtPago.Text, txtDto.Text, txtNombre.Text, txtDireccion.Text, "")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim frmFormFiltro = New frmFiltrosClientesContado()
        frmFormFiltro.ShowDialog()
        If frmFormFiltro.DialogResult = DialogResult.OK Then
            _Cliente = TryCast(frmFormFiltro, frmFiltrosClientesContado).Cliente
            Popular()
        End If
    End Sub

    Private Sub Popular()
        If Not IsNothing(_Cliente) Then
            txtNombre.Text = _Cliente.Nombre
            txtDireccion.Text = _Cliente.Direccion
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            If IsNothing(_Cliente) Then
                _Cliente = New ClienteContado(1, 1, "CLIENTES VARIOS", "")
            End If
            Dim EsperaC As New EsperaContado(Now)
                EsperaC.Codclientecontado = TryCast(_Cliente, ClienteContado).Codigo
                EsperaC.AgregarLineas(Espera.Lineas)
                EsperaC.Codvendedor = Espera.Codvendedor
                If (TryCast(_Cliente, ClienteContado).Codigo) = 1 Then
                    EsperaC.NombreCLiente = txtNombre.Text
                Else
                    EsperaC.NombreCLiente = TryCast(_Cliente, ClienteContado).Nombre
                End If
                EsperaC.Estado = 2
                EsperaC.DirEnvio = txtDireccion.Text
                GesDocumentos.getInstance().AddEspera(EsperaC)
            frmSuccess.FormCorrecto("Presupuesto guardado exitosamente")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class