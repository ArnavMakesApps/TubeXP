Imports System.Net
Imports System.Text.RegularExpressions

Public Class YoutubeApi

    Private ApiKey As String

    Public Sub New(ByVal key As String)

        ApiKey = key

    End Sub


    '-----------------------------------
    ' SEARCH VIDEOS
    '-----------------------------------

    Public Function SearchVideos(ByVal query As String) As List(Of VideoInfo)

        Dim results As New List(Of VideoInfo)

        Dim url As String =
        "https://www.googleapis.com/youtube/v3/search" &
        "?part=snippet&type=video&maxResults=10&q=" &
        Uri.EscapeDataString(query) &
        "&key=" & ApiKey

        Dim wc As New WebClient()

        Dim json As String = wc.DownloadString(url)

        Dim matches = Regex.Matches(json,
        """videoId"":\s*""(.*?)"".*?""title"":\s*""(.*?)"".*?""channelTitle"":\s*""(.*?)"".*?""description"":\s*""(.*?)""",
        RegexOptions.Singleline)

        For Each m As Match In matches

            Dim v As New VideoInfo

            v.VideoId = m.Groups(1).Value
            v.Title = m.Groups(2).Value
            v.Channel = m.Groups(3).Value
            v.Description = m.Groups(4).Value

            v.VideoUrl = "https://youtube.com/watch?v=" & v.VideoId

            results.Add(v)

            If results.Count >= 10 Then Exit For

        Next

        Return results

    End Function


    '-----------------------------------
    ' TRENDING VIDEOS
    '-----------------------------------

    Public Function GetTrending() As List(Of VideoInfo)

        Dim results As New List(Of VideoInfo)

        Dim url As String =
        "https://www.googleapis.com/youtube/v3/videos" &
        "?part=snippet,statistics&chart=mostPopular" &
        "&maxResults=10&regionCode=US&key=" & ApiKey

        Dim wc As New WebClient()

        Dim json As String = wc.DownloadString(url)

        Dim matches = Regex.Matches(json,
        """id"":\s*""(.*?)"".*?""title"":\s*""(.*?)"".*?""channelTitle"":\s*""(.*?)"".*?""viewCount"":\s*""(.*?)""",
        RegexOptions.Singleline)

        For Each m As Match In matches

            Dim v As New VideoInfo

            v.VideoId = m.Groups(1).Value
            v.Title = m.Groups(2).Value
            v.Channel = m.Groups(3).Value
            v.Views = m.Groups(4).Value & " views"

            v.VideoUrl = "https://youtube.com/watch?v=" & v.VideoId

            results.Add(v)

            If results.Count >= 10 Then Exit For

        Next

        Return results

    End Function

End Class