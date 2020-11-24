Imports System.Runtime.InteropServices


Module Estilos

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr

    End Function


    Public Sub Redondear(ByVal xObj As Object, ByVal xPx As Integer)
        If TypeOf xObj Is Control Then
            Dim F As Control = TryCast(xObj, Control)
            TryCast(xObj, Control).Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, F.Width, F.Height, xPx, xPx))
        End If
        'If TypeOf xObj Is Form Then
        '    Dim F As Form = TryCast(xObj, Form)
        '    TryCast(xObj, Form).Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, F.Width, F.Height, xPx, xPx))
        'End If
        'If TypeOf xObj Is Panel Then
        '    Dim P As Panel = TryCast(xObj, Panel)
        '    TryCast(xObj, Panel).Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, P.Width, P.Height, xPx, xPx))
        'End If
        'If TypeOf xObj Is Label Then
        '    Dim P As Label = TryCast(xObj, Label)
        '    TryCast(xObj, Label).Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, P.Width, P.Height, xPx, xPx))
        'End If
        'If TypeOf xObj Is Button Then
        '    Dim P As Button = TryCast(xObj, Button)
        '    TryCast(xObj, Button).Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, P.Width, P.Height, xPx, xPx))
        'End If
        'If TypeOf xObj Is TextBox Then
        '    Dim P As TextBox = TryCast(xObj, TextBox)
        '    TryCast(xObj, TextBox).Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, P.Width, P.Height, xPx, xPx))
        'End If
    End Sub




End Module
