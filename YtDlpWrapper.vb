Imports System.Diagnostics

Public Class YtDlpWrapper

    Public Shared Function GetStream(ByVal videoId As String) As String

        Try

            Dim psi As New ProcessStartInfo

            psi.FileName = "yt-dlp.exe"

            psi.Arguments =
            "-f best[ext=mp4] -g https://www.youtube.com/watch?v=" &
            videoId

            psi.UseShellExecute = False
            psi.RedirectStandardOutput = True
            psi.CreateNoWindow = True

            Dim p As Process = Process.Start(psi)

            Dim url As String = p.StandardOutput.ReadLine()

            p.WaitForExit()

            Debug.WriteLine("Stream URL: " & url)

            Return url

        Catch ex As Exception

            Debug.WriteLine("yt-dlp error: " & ex.Message)

        End Try

        Return ""

    End Function

End Class