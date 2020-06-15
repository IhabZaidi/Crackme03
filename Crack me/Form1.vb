Public Class Form1
    Dim dd As Date = "01/01/2020"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r As Date = Date.Today
        If r.ToString("dd/MM/yyyy") > dd Then
            MsgBox("Trial period has been ended")
        End If
    End Sub
End Class
