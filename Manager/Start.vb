Imports JJ
Imports JJ.Logger

Public Class Start
    Declare Function SetProcessDPIAware Lib "user32.dll" () As Boolean

    <STAThread()>
    Shared Sub Main()
        Try
            Log.LogVersion()
            If (Environment.OSVersion.Version.Major >= 6) Then
                SetProcessDPIAware()
            End If
            Application.SetCompatibleTextRenderingDefault(False)
            Application.EnableVisualStyles()
            Dim main As Form
            If LeerIni.LeerDato("INTERFAZ", "MATERIAL", 1, ".\config.ini") = 0 Then
                main = New frmMain()
            Else
                main = New frmMainMaterial()
            End If
            Application.Run(main)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
