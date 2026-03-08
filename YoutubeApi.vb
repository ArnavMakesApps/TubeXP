Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Diagnostics

Public Class YouTubeVideo

    Public Property VideoId As String
    Public Property Title As String
    Public Property Channel As String
    Public Property Thumbnail As String

End Class


Public Class YouTubeApi

    Public Shared Function GetApiKey() As String

        Dim path As String =
        Application.StartupPath & "\apikey.txt"

        Try

            If File.Exists(path) Then

                Dim key As String = File.ReadAllText(path).Trim

                If key <> "" Then Return key

            End If


            Dim userKey As String =
            InputBox("Enter your YouTube Data API key:", "API Key Required")

            If userKey <> "" Then

                File.WriteAllText(path, userKey)

                Return userKey

            End If

        Catch ex As Exception

            Debug.WriteLine("API key error: " & ex.Message)

        End Try

        Return ""

    End Function



    Public Shared Function SearchVideos(ByVal query As String) As List(Of YouTubeVideo)

        Dim videos As New List(Of YouTubeVideo)

        Try

            Dim key As String = GetApiKey()

            If key = "" Then Return videos

            Dim url As String =
            "https://www.googleapis.com/youtube/v3/search?part=snippet&type=video&maxResults=20&q=" &
            Uri.EscapeDataString(query) &
            "&key=" & key

            Debug.WriteLine("Search URL: " & url)

            Dim wc As New WebClient
            wc.Headers.Add("User-Agent", "Mozilla/5.0")

            Dim json As String = wc.DownloadString(url)

            Dim idMatches = Regex.Matches(json, """videoId"":\s*""(.*?)""")
            Dim titleMatches = Regex.Matches(json, """title"":\s*""(.*?)""")
            Dim channelMatches = Regex.Matches(json, """channelTitle"":\s*""(.*?)""")

            Dim count As Integer =
            Math.Min(idMatches.Count,
            Math.Min(titleMatches.Count, channelMatches.Count))

            For i As Integer = 0 To count - 1

                Dim v As New YouTubeVideo

                v.VideoId = idMatches(i).Groups(1).Value
                v.Title = Regex.Unescape(titleMatches(i).Groups(1).Value)
                v.Channel = Regex.Unescape(channelMatches(i).Groups(1).Value)

                v.Thumbnail =
                "https://i.ytimg.com/vi/" &
                v.VideoId &
                "/mqdefault.jpg"

                videos.Add(v)

            Next

            Debug.WriteLine("Videos parsed: " & videos.Count)

        Catch ex As Exception

            Debug.WriteLine("Search error: " & ex.Message)

        End Try

        Return videos

    End Function

End Class