Imports System.Diagnostics
Imports System.Text.RegularExpressions

Public Class YtDlpWrapper

    Public Event StreamReady(ByVal url As String)

    Public Sub GetStream(ByVal videoUrl As String)

        Dim psi As New ProcessStartInfo()

        psi.FileName = "yt-dlp.exe"

        psi.Arguments =
        "--no-check-certificates -f best[ext=mp4]/best --get-url " & videoUrl

        psi.RedirectStandardOutput = True
        psi.UseShellExecute = False
        psi.CreateNoWindow = True

        Dim p As New Process()
        p.StartInfo = psi

        AddHandler p.OutputDataReceived,
        Sub(sender, e)

            If String.IsNullOrEmpty(e.Data) Then Exit Sub

            RaiseEvent StreamReady(e.Data)

        End Sub

        p.Start()

        p.BeginOutputReadLine()

    End Sub

End Class
