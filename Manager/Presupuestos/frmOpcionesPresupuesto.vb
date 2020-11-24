Imports JJ.Reportes

Public Class frmOpcionesPresupuesto
    Dim Espera As UESPERA

    Public Sub New(ByVal xEspera As UESPERA)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Espera = xEspera
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub frmOpcionesPresupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim DT As DataTable = Espera.MostrarTabla
            DT.TableName = "Presupuesto"
            GestionReporte.Presupuesto(DT, txtDias.Text, txtPago.Text, txtDto.Text, "", "", "")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmOpcionesPresupuesto_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class