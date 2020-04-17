Public Class Start
    <STAThread()>
    Shared Sub Main()
        Try
            'SetRegion()

            Application.SetCompatibleTextRenderingDefault(False)
            Application.EnableVisualStyles()

            Dim main As Form

            If LeerIni.LeerDato("INTERFAZ", "MATERIAL", 0, ".\config.ini") = 0 Then
                main = New frmMain()
            Else
                main = New frmMain_Material()
            End If


            main.ShowDialog()

            'If (Login.DialogResult = DialogResult.OK) Then
            '    Dim MainForm As Form = New Main()
            '    Application.Run(MainForm)
            'Else
            '    Return
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
